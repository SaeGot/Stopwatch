using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Diag = System.Diagnostics;


namespace Stopwatch
{
    public partial class Form1 : Form
    {
        private Diag.Stopwatch stopwatch = new Diag.Stopwatch();
        private bool start = false;
        private int listViewCount = 0;
        private TimeSpan beforeTime = new TimeSpan(0);
        private string startKey;
        private string splitKey;
        private string resetKey;

        public Form1()
        {
            InitializeComponent();
        }

        private void Initialize()
        {
            lvTimeline.Items.Clear();
            stopwatch.Reset();
            btnStart.Text = "Start";
            start = false;
            btnSplit.Enabled = false;
            listViewCount = 0;
            beforeTime = new TimeSpan(0);
        }

        private void BtnStartClick(object sender, EventArgs e)
        {
            if (!start)
            {
                stopwatch.Start();
                btnStart.Text = "Pause";
                start = true;
                btnSplit.Enabled = true;
            }
            else
            {
                stopwatch.Stop();
                btnStart.Text = "Start";
                start = false;
                btnSplit.Enabled = false;
            }
        }

        private void TimerTick(object sender, EventArgs e)
        {
            TimeSpan time_span = stopwatch.Elapsed;
            txtCurrentTime.Text = time_span.ToString(@"hh\:mm\:ss\.ff");
            txtCurrentGap.Text = (time_span - beforeTime).ToString(@"hh\:mm\:ss\.ff");
        }

        private void BtnSplitClick(object sender, EventArgs e)
        {
            listViewCount++;
            ListViewItem item = new ListViewItem(listViewCount.ToString());
            TimeSpan time_span = stopwatch.Elapsed;
            item.SubItems.Add(time_span.ToString(@"hh\:mm\:ss\.ff"));
            TimeSpan gap = time_span - beforeTime;
            item.SubItems.Add(gap.ToString(@"hh\:mm\:ss\.ff"));
            lvTimeline.Items.Add(item);
            lvTimeline.EnsureVisible(listViewCount - 1);
            beforeTime = time_span;
        }

        private void BtnResetClick(object sender, EventArgs e)
        {
            Initialize();
        }

        private void BtnHotKeyClick(object sender, EventArgs e)
        {
            List<string> keys = new List<string>() { startKey, splitKey, resetKey };
            HotKey hotkey_form = new HotKey(keys);
            hotkey_form.Owner = this;
            if (hotkey_form.ShowDialog() == DialogResult.OK)
            {
                startKey = hotkey_form.txtStart.Text;
                splitKey = hotkey_form.txtSplit.Text;
                resetKey = hotkey_form.txtReset.Text;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData.ToString() == startKey)
                BtnStartClick(keyData, null);
            else if (keyData.ToString() == splitKey)
            {
                if (btnSplit.Enabled)
                    BtnSplitClick(keyData, null);
            }
            else if (keyData.ToString() == resetKey)
                BtnResetClick(keyData, null);

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
