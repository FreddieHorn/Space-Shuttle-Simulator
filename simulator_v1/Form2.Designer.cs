namespace simulator_v1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.repair_crew = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.speed_bar = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.extract_fuel = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.life_supp_checkbx = new System.Windows.Forms.CheckBox();
            this.mega_drive_checkbx = new System.Windows.Forms.CheckBox();
            this.engage_fuel_chckbx = new System.Windows.Forms.CheckBox();
            this.velo_correct = new System.Windows.Forms.TextBox();
            this.oxy_timer = new System.Windows.Forms.Timer(this.components);
            this.ele_timer = new System.Windows.Forms.Timer(this.components);
            this.fuel_timer = new System.Windows.Forms.Timer(this.components);
            this.random_event_timer = new System.Windows.Forms.Timer(this.components);
            this.escape_cd = new System.Windows.Forms.Timer(this.components);
            this.spedometer = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.refresher = new System.Windows.Forms.Timer(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.sending_timer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.speed_bar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.Chartreuse;
            this.progressBar1.Location = new System.Drawing.Point(84, 66);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(118, 23);
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // progressBar2
            // 
            this.progressBar2.BackColor = System.Drawing.Color.Chartreuse;
            this.progressBar2.Location = new System.Drawing.Point(84, 110);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(118, 23);
            this.progressBar2.TabIndex = 1;
            // 
            // progressBar3
            // 
            this.progressBar3.BackColor = System.Drawing.Color.Chartreuse;
            this.progressBar3.Location = new System.Drawing.Point(84, 153);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(118, 23);
            this.progressBar3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(13, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Oxygen";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(13, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Electricity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(13, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fuel";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 24);
            this.button1.TabIndex = 6;
            this.button1.Text = "Fast travel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // repair_crew
            // 
            this.repair_crew.Location = new System.Drawing.Point(0, 21);
            this.repair_crew.Name = "repair_crew";
            this.repair_crew.Size = new System.Drawing.Size(125, 23);
            this.repair_crew.TabIndex = 7;
            this.repair_crew.Text = "Repair crew";
            this.repair_crew.UseVisualStyleBackColor = true;
            this.repair_crew.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Send signal";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // speed_bar
            // 
            this.speed_bar.Location = new System.Drawing.Point(891, 313);
            this.speed_bar.Name = "speed_bar";
            this.speed_bar.Size = new System.Drawing.Size(119, 45);
            this.speed_bar.TabIndex = 14;
            this.speed_bar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(903, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 31);
            this.label4.TabIndex = 16;
            this.label4.Text = "Control Panel";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.extract_fuel);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.repair_crew);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(885, 205);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(125, 85);
            this.panel1.TabIndex = 17;
            // 
            // extract_fuel
            // 
            this.extract_fuel.Location = new System.Drawing.Point(0, 41);
            this.extract_fuel.Name = "extract_fuel";
            this.extract_fuel.Size = new System.Drawing.Size(125, 23);
            this.extract_fuel.TabIndex = 18;
            this.extract_fuel.Text = "Extract fuel";
            this.extract_fuel.UseVisualStyleBackColor = true;
            this.extract_fuel.Click += new System.EventHandler(this.extract_fuel_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(916, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 31);
            this.label5.TabIndex = 18;
            this.label5.Text = "Action Panel";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(925, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Speed";
            // 
            // life_supp_checkbx
            // 
            this.life_supp_checkbx.AutoSize = true;
            this.life_supp_checkbx.Location = new System.Drawing.Point(885, 77);
            this.life_supp_checkbx.Name = "life_supp_checkbx";
            this.life_supp_checkbx.Size = new System.Drawing.Size(141, 17);
            this.life_supp_checkbx.TabIndex = 20;
            this.life_supp_checkbx.Text = "Seal life support systems";
            this.life_supp_checkbx.UseVisualStyleBackColor = true;
            this.life_supp_checkbx.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // mega_drive_checkbx
            // 
            this.mega_drive_checkbx.AutoSize = true;
            this.mega_drive_checkbx.Location = new System.Drawing.Point(1071, 77);
            this.mega_drive_checkbx.Name = "mega_drive_checkbx";
            this.mega_drive_checkbx.Size = new System.Drawing.Size(79, 17);
            this.mega_drive_checkbx.TabIndex = 21;
            this.mega_drive_checkbx.Text = "Mega drive";
            this.mega_drive_checkbx.UseVisualStyleBackColor = true;
            this.mega_drive_checkbx.CheckedChanged += new System.EventHandler(this.mega_drive_checkbx_CheckedChanged);
            // 
            // engage_fuel_chckbx
            // 
            this.engage_fuel_chckbx.AutoSize = true;
            this.engage_fuel_chckbx.Location = new System.Drawing.Point(927, 118);
            this.engage_fuel_chckbx.Name = "engage_fuel_chckbx";
            this.engage_fuel_chckbx.Size = new System.Drawing.Size(167, 17);
            this.engage_fuel_chckbx.TabIndex = 22;
            this.engage_fuel_chckbx.Text = "Engage fuel extraction system";
            this.engage_fuel_chckbx.UseVisualStyleBackColor = true;
            this.engage_fuel_chckbx.CheckedChanged += new System.EventHandler(this.engage_fuel_chckbx_CheckedChanged);
            // 
            // velo_correct
            // 
            this.velo_correct.Location = new System.Drawing.Point(994, 369);
            this.velo_correct.Name = "velo_correct";
            this.velo_correct.ReadOnly = true;
            this.velo_correct.Size = new System.Drawing.Size(100, 20);
            this.velo_correct.TabIndex = 24;
            // 
            // oxy_timer
            // 
            this.oxy_timer.Interval = 1000;
            this.oxy_timer.Tick += new System.EventHandler(this.oxy_timer_Tick);
            // 
            // ele_timer
            // 
            this.ele_timer.Tick += new System.EventHandler(this.ele_timer_Tick);
            // 
            // fuel_timer
            // 
            this.fuel_timer.Interval = 1000;
            this.fuel_timer.Tick += new System.EventHandler(this.fuel_timer_Tick);
            // 
            // random_event_timer
            // 
            this.random_event_timer.Interval = 30000;
            this.random_event_timer.Tick += new System.EventHandler(this.random_event_timer_Tick);
            // 
            // escape_cd
            // 
            this.escape_cd.Interval = 1000;
            this.escape_cd.Tick += new System.EventHandler(this.escape_cd_Tick);
            // 
            // spedometer
            // 
            this.spedometer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.spedometer.Location = new System.Drawing.Point(84, 196);
            this.spedometer.Name = "spedometer";
            this.spedometer.ReadOnly = true;
            this.spedometer.Size = new System.Drawing.Size(118, 23);
            this.spedometer.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(864, 370);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "Velocity correction";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(13, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 16);
            this.label8.TabIndex = 27;
            this.label8.Text = "Velocity";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(897, 345);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(991, 345);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1100, 372);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "[10^4 km/h]";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1016, 345);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "[10^4 km/h]";
            // 
            // refresher
            // 
            this.refresher.Tick += new System.EventHandler(this.refresher_Tick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(429, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(260, 31);
            this.label13.TabIndex = 32;
            this.label13.Text = "Welcome, Captain.";
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(84, 237);
            this.progressBar4.Maximum = 60;
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(118, 23);
            this.progressBar4.TabIndex = 33;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.Location = new System.Drawing.Point(12, 244);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 16);
            this.label14.TabIndex = 34;
            this.label14.Text = "Signaling";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label15.Location = new System.Drawing.Point(9, 307);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 15);
            this.label15.TabIndex = 38;
            this.label15.Text = "Warning flags";
            // 
            // sending_timer
            // 
            this.sending_timer.Interval = 1000;
            this.sending_timer.Tick += new System.EventHandler(this.sending_timer_Tick);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::simulator_v1.Properties.Resources.panel2;
            this.pictureBox5.Location = new System.Drawing.Point(1019, 205);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(120, 85);
            this.pictureBox5.TabIndex = 39;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::simulator_v1.Properties.Resources.red_flag;
            this.pictureBox4.Location = new System.Drawing.Point(171, 293);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(31, 29);
            this.pictureBox4.TabIndex = 37;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::simulator_v1.Properties.Resources.red_flag;
            this.pictureBox3.Location = new System.Drawing.Point(134, 293);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 29);
            this.pictureBox3.TabIndex = 36;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::simulator_v1.Properties.Resources.red_flag;
            this.pictureBox2.Location = new System.Drawing.Point(97, 293);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 29);
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::simulator_v1.Properties.Resources.cockpit600;
            this.pictureBox1.Location = new System.Drawing.Point(257, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(601, 335);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 391);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.progressBar4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.spedometer);
            this.Controls.Add(this.velo_correct);
            this.Controls.Add(this.engage_fuel_chckbx);
            this.Controls.Add(this.mega_drive_checkbx);
            this.Controls.Add(this.life_supp_checkbx);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.speed_bar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar3);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressBar1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.speed_bar)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button repair_crew;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TrackBar speed_bar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button extract_fuel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox life_supp_checkbx;
        private System.Windows.Forms.CheckBox mega_drive_checkbx;
        private System.Windows.Forms.CheckBox engage_fuel_chckbx;
        private System.Windows.Forms.TextBox velo_correct;
        private System.Windows.Forms.Timer oxy_timer;
        private System.Windows.Forms.Timer ele_timer;
        private System.Windows.Forms.Timer fuel_timer;
        private System.Windows.Forms.Timer random_event_timer;
        private System.Windows.Forms.Timer escape_cd;
        private System.Windows.Forms.TextBox spedometer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Timer refresher;
        private System.Windows.Forms.Label label13;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Timer sending_timer;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}