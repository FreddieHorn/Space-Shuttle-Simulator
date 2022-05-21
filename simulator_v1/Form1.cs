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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Activate();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            var form2 = new Form2();
            form2.Show();
            //this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_box_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
