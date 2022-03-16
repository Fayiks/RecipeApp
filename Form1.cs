using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label4.Text = Convert.ToString(DateTime.Now);
        }

        
        
        private void button2_Click(object sender, EventArgs e)
        {

                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\my\source\repos\WindowsFormsApp1\Database1.mdf;Integrated Security=True");
            
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Login WHERE Username='" + txtUsername.Text + "' and Password ='" + txtPassword.Text + "'",con);
                DataTable dt = new DataTable();
                sda.Fill(dt) ;
                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    Main ss = new Main();
                    ss.Show();
                }
                else
                {
                    MessageBox.Show("Please check your details and try again");
                }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
    
            SignUp ss = new SignUp();
            ss.Show();
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !checkBox1.Checked ;
        }

       
    }
}
