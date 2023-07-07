using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stopwatch
{
    public partial class HotKey : Form
    {
        public HotKey(List<string> key_Received)
        {
            InitializeComponent();
            txtStart.Text = key_Received[0];
            txtSplit.Text = key_Received[1];
            txtReset.Text = key_Received[2];
        }

        private void BtnOkClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void BtnCancelClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
