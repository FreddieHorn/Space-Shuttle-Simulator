using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simulator_v1
{
    public partial class Form3 : Form
    {
        int time_left = 10;
        bool exit = false;
        public Form3()
        {
            InitializeComponent();
            timer1.Start();
        }

        public bool logout()
        {
            if (exit)
            {
                return true;
            }
            else
                return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (time_left>0)
            {
                time_left = time_left - 1;
                countdown.Text = time_left.ToString();
            }
            else if (time_left<=0)
            {
                timer1.Stop();
                MessageBox.Show("You have been logged out!");
                exit = true;
                this.Close();
            }
        }
    }
}
