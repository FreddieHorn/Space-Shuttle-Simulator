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
        public int logout_chck_time = 60;
        int fuel_value = 100;
        int oxy_value = 100;
        int electricity_value = 100;
        int sending_time = 10;
        int picbox_enum = 0;
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
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
        }

        private void stop_timers()
        {
            ele_timer.Stop();
            oxy_timer.Stop();
            fuel_timer.Stop();
            escape_cd.Stop();
            timer1.Stop();
            sending_timer.Stop();
            random_event_timer.Stop();
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
        //signaling
        private void button3_Click(object sender, EventArgs e)
        {
            if (progressBar4.Value < 60)
            {
                Console.Beep();
                progressBar4.Value += 20;
                progressBar4.Update();
            }
            if (progressBar4.Value == 60)
            {
                MessageBox.Show("Signaling successfull!");
                progressBar4.Value = 0;
                sending_timer.Stop();
                sending_time = 10;
                progressBar4.Update();
            }
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
            logout_chck_time = 60;
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
                stop_timers();
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
            int choice = rnd.Next(0,4);
            switch (choice)
            {
                case 0:
                    MessageBox.Show("Oxygen Leak!");
                    oxy_crisis = true;
                    oxy_timer.Start();
                    break;
                case 1:
                    MessageBox.Show("Enemy fighter jets! Escape from the system!");
                    escape_cd.Start();
                    break;
                case 2:
                    int spd = rnd.Next(0, 11);
                    velo_correct.Text = spd.ToString();
                    MessageBox.Show("Correct the speed.");
                    break;
                case 3:
                    MessageBox.Show("Send signal to identify yourself.");
                    sending_timer.Start();
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
                stop_timers();
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
                stop_timers();
                MessageBox.Show("You have ran out of electricity. You will freeze.");
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
                stop_timers();
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
                stop_timers();
                this.Close();
            }

        }

        private void refresher_Tick(object sender, EventArgs e)
        {
            spedometer.Text = speed_bar.Value.ToString() + " [10^4 km/h]";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void sending_timer_Tick(object sender, EventArgs e)
        {
            if (sending_time>0)
            {
                sending_time -= 1;
            }
            else
            {
                switch(picbox_enum)
                {
                    case 0:
                        pictureBox2.Visible = true;
                        pictureBox3.Visible = false;
                        pictureBox4.Visible = false;
                        break;
                    case 1:
                        pictureBox2.Visible = true;
                        pictureBox3.Visible = true;
                        pictureBox4.Visible = false;
                        break;
                    case 2:
                        pictureBox2.Visible = true;
                        pictureBox3.Visible = true;
                        pictureBox4.Visible = true;
                        break;
                    case 3:
                        MessageBox.Show("You failed to identify yourself 4 times. You have been logged out and banned fromt he system.");
                        stop_timers();
                        this.Close();
                        break;
                }
                picbox_enum++;
                sending_timer.Stop();
                sending_time = 10;
            }
        }
    }
}
