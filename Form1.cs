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

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnStartClick(object sender, EventArgs e)
        {
            if (!start)
            {
                stopwatch.Start();
                btnStart.Text = "Pause";
                start = true;
            }
            else
            {
                stopwatch.Stop();
                btnStart.Text = "Start";
                start = false;
            }
        }

        private void TimerTick(object sender, EventArgs e)
        {
            TimeSpan time_span = stopwatch.Elapsed;
            txtCurrentTime.Text = time_span.ToString(@"hh\:mm\:ss\.ff");
        }
    }
}
