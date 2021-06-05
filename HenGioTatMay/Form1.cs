using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HenGioTatMay
{
    public partial class Form1 : Form
    {
        double remainingTime = 0;
        double t = 0;
        public Form1()
        {
            InitializeComponent();

        }
        private void CalculatorTime()
        {
            remainingTime = Convert.ToDouble(numHour.Value * 3600 + numMinute.Value * 60 + numSecond.Value);
            t = remainingTime * 10;
            timer1.Start();
        }
        private void WindowCommand(string cmd)
        {
            System.Diagnostics.Process.Start("shutdown", cmd);      
        }

        private void btnShutdown_Click(object sender, EventArgs e)
        {
            CalculatorTime();
            WindowCommand("-s -t " + remainingTime.ToString());
            lbStatus.Text = "Shutting Down...";
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            CalculatorTime();
            WindowCommand("-r -t " + remainingTime.ToString());
            lbStatus.Text = "Restarting...";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            WindowCommand("-a");
            lbStatus.Text = "Canceled...";
            lbTime.Text = "";
            timer1.Stop();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTime.Text = t.ToString();
            t--;
        }
    }
}
