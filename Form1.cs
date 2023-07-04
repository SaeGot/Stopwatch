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
        }

        private void BtnSplitClick(object sender, EventArgs e)
        {
            listViewCount++;
            ListViewItem item = new ListViewItem(listViewCount.ToString());
            TimeSpan time_span = stopwatch.Elapsed;
            item.SubItems.Add(time_span.ToString(@"hh\:mm\:ss\.ff"));
            lvTimeline.Items.Add(item);
        }

        private void BtnResetClick(object sender, EventArgs e)
        {
            Initialize();
        }
    }
}
