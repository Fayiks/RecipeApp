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
    public partial class BaseConverter : Form
    {
        
        public BaseConverter()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox_Display.Text);
            string result = Convert.ToString(n, 8);
            textBox1.Text = result;
        }

        private void button_click(object sender, EventArgs e)
        {
            if (textBox_Display.Text == "0")
                textBox_Display.Clear();
            Button b = (Button)sender;
            textBox_Display.Text = textBox_Display.Text + b.Text;
        }
        private void operator_click(object sender, EventArgs e)
        { 
        }
        private void button14_Click(object sender, EventArgs e)
        {   
            int n = int.Parse(textBox_Display.Text);
            string result = Convert.ToString(n, 2);
            textBox1.Text = result;
            //textBox_Display.Clear();
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            textBox_Display.Clear();
        }
    }
}
