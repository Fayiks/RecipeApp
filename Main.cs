using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Main : Form
    {
       
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ss = new Form1();
            ss.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            BaseConverter ss = new BaseConverter();
            ss.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Bank ss = new Bank();
            ss.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            FoodApp ss = new FoodApp();
            ss.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal) {
                this.WindowState = FormWindowState.Maximized;
            }
            else {
                this.WindowState = FormWindowState.Normal;
                    }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
