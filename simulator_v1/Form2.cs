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
        bool _extract_fuel = false;
        bool _life_support = false;
        bool _mega_drive = false;
        bool oxy_crisis = false;
        bool ele_crisis = false;

        int escape_cooldown = 10;
        public int logout_chck_time = 5;
        int fuel_value = 100;
        int oxy_value = 100;
        int electricity_value = 100;
        public Form2()
        {
            InitializeComponent();
            timer1.Start();
            progressBar1.Step = 1;
            //oxy_timer.Start();
            progressBar1.Value = oxy_value;
            progressBar2.Value = electricity_value;
            fuel_timer.Start();
            random_event_timer.Start();
            ele_timer.Start();
            refresher.Start();
        }
        

        private void show_fuel_box_msg()
        {
            showed_fuel = false;
            MessageBox.Show("Low fuel levels");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //idk xD button
        private void button4_Click(object sender, EventArgs e)
        {
            logout_chck_time = 60;
        }

        //repair crew button
        private void button2_Click(object sender, EventArgs e)
        {
            if (oxy_crisis)
            {
                oxy_timer.Stop();
                for (int x = 100 - progressBar1.Value; x<100;x++)
                {
                    progressBar1.Value = x;
                }
            }
            logout_chck_time = 60;
        }

        //button for Fast travel
        private void button1_Click(object sender, EventArgs e)
        {
            if (_mega_drive)
            {
                escape_cd.Stop();
                escape_cooldown = 10;
                MessageBox.Show("You've successfully mega jumped into a different system");
            }
            logout_chck_time = 60;
        }

        private void extract_fuel_Click(object sender, EventArgs e)
        {
            if (_extract_fuel)
                if (fuel_value+40>100)
                {
                    fuel_value += 100 - fuel_value;
                }
                else
                    fuel_value += 40;
            logout_chck_time = 60;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        //that's a life support checkbox
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (_life_support)
                _life_support = false;
            else
                _life_support = true;
            logout_chck_time = 60;

        }

        private void engage_fuel_chckbx_CheckedChanged(object sender, EventArgs e)
        {
            if (_extract_fuel)
            {
                _extract_fuel = false;
            }
            else
                _extract_fuel = true;
            logout_chck_time = 60;
        }

        private void placeholder_chckbox_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void mega_drive_checkbx_CheckedChanged(object sender, EventArgs e)
        {
            if (_mega_drive)
                _mega_drive = false;
            else
                _mega_drive = true;
            logout_chck_time = 60;
        }

        //speed scroll
        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        //logout timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (logout_chck_time>0)
            {
                logout_chck_time = logout_chck_time - 1;
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
            Random rnd = new Random();
            int choice = rnd.Next(1,4);
            switch (choice)
            {
                case 1:
                    MessageBox.Show("Oxygen Leak!");
                    oxy_crisis = true;
                    oxy_timer.Start();
                    break;
                case 2:
                    MessageBox.Show("Enemy fighter jets! Escape from the system!");
                    escape_cd.Start();
                    break;
                case 3:
                    int spd = rnd.Next(0, 11);
                    velo_correct.Text = spd.ToString();
                    MessageBox.Show("Correct the speed.");
                    break;
                case 4:
                    break;
            }
                    

        }

        private void fuel_timer_Tick(object sender, EventArgs e)
        {
            if (fuel_value >= 20)
            {
                progressBar3.Value = fuel_value;
                fuel_value -= 1;
                progressBar3.Update();
                showed_fuel = true;
                ele_crisis = false;
            }
            else if (fuel_value < 20 && fuel_value > 0)
            {
                if (showed_fuel)
                    show_fuel_box_msg();
                ele_crisis = true;
                progressBar3.Value = fuel_value;
                fuel_value -= 1;
                progressBar3.Update();
            }
            else
            {
                fuel_timer.Stop();
                escape_cd.Stop();
                random_event_timer.Stop();
                MessageBox.Show("You've run out of fuel. You'll die in the vast void of space");
                this.Close();
            }
        }

        private void ele_timer_Tick(object sender, EventArgs e)
        {
            if (ele_crisis && electricity_value>=2)
            {
                electricity_value -= 2;
                progressBar2.Value = electricity_value;
            }
            else if (electricity_value<=98)
            {
                electricity_value += 2;
                progressBar2.Value = electricity_value;
            }
            else if (electricity_value == 0)
            {
                MessageBox.Show("You have ran out of electricity. You will freeze.");
                ele_timer.Stop();
                escape_cd.Stop();
                random_event_timer.Stop();
                this.Close();
            }
        }

        private void oxy_timer_Tick(object sender, EventArgs e)
        {
            if (_life_support && oxy_value >=1)
            {
                oxy_value -= 1;
                progressBar1.Value = oxy_value;
            }
            else if (oxy_value >=5)
            {
                oxy_value -= 5;
                progressBar1.Value = oxy_value;
            }
            else
            {
                MessageBox.Show("You've ran out of oxygen.");
                oxy_timer.Stop();
                escape_cd.Stop();
                random_event_timer.Stop();
                this.Close();
            }
            progressBar1.Update();
        }

        private void escape_cd_Tick(object sender, EventArgs e)
        {
            escape_cooldown -= 1;
            if (escape_cooldown <= 0)
            {
                MessageBox.Show("You were gunned down...");
                escape_cd.Stop();
                random_event_timer.Stop();
                this.Close();
            }

        }

        private void refresher_Tick(object sender, EventArgs e)
        {
            spedometer.Text = speed_bar.Value.ToString() + " [10^4 km/h]";
        }
    }
}
