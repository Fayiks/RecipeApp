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
    public partial class Bank : Form
    {
        public Bank()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Console.WriteLine("enter the principal;");// prompt user to enter the principal
            decimal principal = Convert.ToDecimal(textBox1.Text);// convert the principal from string to decimal
            //Console.WriteLine("what interest amount is the transaction?");// Promt the user to enter the interest
            decimal interest = Convert.ToDecimal(textBox3.Text);// Convert the interest input to Decimal
            int interestlimit = 50;// Set a interest limit
            //Console.WriteLine("How long do you want to invest for? ");// Ask for how long the user wanna invest
            int Duration = Convert.ToInt32(textBox2.Text);// Convert string to interger

            if (interest <= 0 || interest > interestlimit)
            {
                MessageBox.Show("dont be a scam!");

            }
            else
            {
                decimal returns;
                returns = Duration * principal * (interest / 100);
                MessageBox.Show("You shall be recieving " + returns + " naira as interest");
                decimal total = principal + returns;
                //Console.WriteLine();
                MessageBox.Show("Total Returns = " + total);

            }

            }
    }
}
