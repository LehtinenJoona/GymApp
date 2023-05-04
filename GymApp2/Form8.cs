using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymApp2
{
    public partial class Form8 : Form
    {
        private Stopwatch stopwatch = new Stopwatch();
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            stopwatch.Start();
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            stopwatch.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            label1.Text = "00:00:00";
           stopwatch.Reset();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = stopwatch.Elapsed;
            label1.Text = string.Format("{0:00}:{1:00}:{2:00}", ts.Hours, ts.Minutes, ts.Seconds);
        }
    }
}
