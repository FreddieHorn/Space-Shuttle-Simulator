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
    public partial class Form2 : Form
    {
        public int logout_chck_time = 5;
        
        public Form2()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
                
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        //that's a life support checkbox
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void engage_fuel_chckbx_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void placeholder_chckbox_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void mega_drive_checkbx_CheckedChanged(object sender, EventArgs e)
        {

        }

        //speed scroll
        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (logout_chck_time>0)
            {
                logout_chck_time = logout_chck_time - 1;
                textBox1.Text = logout_chck_time.ToString();
            }
            else
            {
                timer1.Stop();
                Form3 f3 = new Form3();
                f3.ShowDialog();
                if (f3.logout())
                {

                    this.Close();
                }
            }
        }
    }
}
