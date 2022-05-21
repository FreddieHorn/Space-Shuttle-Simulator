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
        bool showed_fuel = true;
        public int logout_chck_time = 5;
        int fuel_value = 100;
        public Form2()
        {
            InitializeComponent();
            timer1.Start();
            progressBar1.Step = 1;
            oxy_timer.Start();
            fuel_timer.Start();
        }
        

        private void show_fuel_box_msg()
        {
            showed_fuel = false;
            MessageBox.Show("Low fuel levels");
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

        private void extract_fuel_Click(object sender, EventArgs e)
        {
            fuel_value += 40;
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
                logout_chck_time = 60;
                timer1.Start();
            }
        }

        private void random_event_timer_Tick(object sender, EventArgs e)
        {

        }

        private void fuel_timer_Tick(object sender, EventArgs e)
        {
            if (fuel_value >= 20)
            {
                progressBar3.Value = fuel_value;
                fuel_value -= 5;
                progressBar3.Update();
                showed_fuel = true;
            }
            else if (fuel_value < 20 && fuel_value > 0)
            {
                if (showed_fuel)
                {
                    show_fuel_box_msg();
                }
                progressBar3.Value = fuel_value;
                fuel_value -= 2;
                progressBar3.Update();
            }
            else
            {
                fuel_timer.Stop();
                MessageBox.Show("You've run out of fuel. You'll die in the vast void of space");
                this.Close();
            }
        }

        private void ele_timer_Tick(object sender, EventArgs e)
        {

        }

        private void oxy_timer_Tick(object sender, EventArgs e)
        {
        }

    }
}
