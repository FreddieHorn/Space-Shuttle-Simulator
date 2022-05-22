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
            this.button4 = new System.Windows.Forms.Button();
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
            this.placeholder_chckbox = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.oxy_timer = new System.Windows.Forms.Timer(this.components);
            this.ele_timer = new System.Windows.Forms.Timer(this.components);
            this.fuel_timer = new System.Windows.Forms.Timer(this.components);
            this.random_event_timer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.escape_cd = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.speed_bar)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.button1.Size = new System.Drawing.Size(125, 23);
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
            this.button3.Location = new System.Drawing.Point(123, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(77, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "idk xD";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "Extract Hydrogen";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // speed_bar
            // 
            this.speed_bar.Location = new System.Drawing.Point(944, 370);
            this.speed_bar.Name = "speed_bar";
            this.speed_bar.Size = new System.Drawing.Size(104, 45);
            this.speed_bar.TabIndex = 14;
            this.speed_bar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(893, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 31);
            this.label4.TabIndex = 16;
            this.label4.Text = "Control Panel";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.extract_fuel);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.repair_crew);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(890, 245);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 85);
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
            this.label5.Location = new System.Drawing.Point(893, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 31);
            this.label5.TabIndex = 18;
            this.label5.Text = "Action Panel";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(977, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Speed";
            // 
            // life_supp_checkbx
            // 
            this.life_supp_checkbx.AutoSize = true;
            this.life_supp_checkbx.Location = new System.Drawing.Point(871, 118);
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
            this.mega_drive_checkbx.Location = new System.Drawing.Point(1041, 118);
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
            this.engage_fuel_chckbx.Location = new System.Drawing.Point(871, 159);
            this.engage_fuel_chckbx.Name = "engage_fuel_chckbx";
            this.engage_fuel_chckbx.Size = new System.Drawing.Size(167, 17);
            this.engage_fuel_chckbx.TabIndex = 22;
            this.engage_fuel_chckbx.Text = "Engage fuel extraction system";
            this.engage_fuel_chckbx.UseVisualStyleBackColor = true;
            this.engage_fuel_chckbx.CheckedChanged += new System.EventHandler(this.engage_fuel_chckbx_CheckedChanged);
            // 
            // placeholder_chckbox
            // 
            this.placeholder_chckbox.AutoSize = true;
            this.placeholder_chckbox.Location = new System.Drawing.Point(1041, 159);
            this.placeholder_chckbox.Name = "placeholder_chckbox";
            this.placeholder_chckbox.Size = new System.Drawing.Size(82, 17);
            this.placeholder_chckbox.TabIndex = 23;
            this.placeholder_chckbox.Text = "Placeholder";
            this.placeholder_chckbox.UseVisualStyleBackColor = true;
            this.placeholder_chckbox.CheckedChanged += new System.EventHandler(this.placeholder_chckbox_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(95, 268);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 24;
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
            this.random_event_timer.Interval = 10000;
            this.random_event_timer.Tick += new System.EventHandler(this.random_event_timer_Tick);
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
            // escape_cd
            // 
            this.escape_cd.Interval = 1000;
            this.escape_cd.Tick += new System.EventHandler(this.escape_cd_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 416);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.placeholder_chckbox);
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
        private System.Windows.Forms.Button button4;
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
        private System.Windows.Forms.CheckBox placeholder_chckbox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer oxy_timer;
        private System.Windows.Forms.Timer ele_timer;
        private System.Windows.Forms.Timer fuel_timer;
        private System.Windows.Forms.Timer random_event_timer;
        private System.Windows.Forms.Timer escape_cd;
    }
}