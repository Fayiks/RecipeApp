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
    public partial class SuggestionControl1 : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\my\source\repos\WindowsFormsApp1\Database1.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable ft;
        public SuggestionControl1()
        {
            InitializeComponent();
            showdata();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("insert into Comment values('" + textBox1.Text + "', '" + textBox2.Text + "','" + textBox3.Text + "')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Thanks for the suggestions. We would do well to work on it");
            con.Close();
            showdata();
           
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
        public void showdata()
        {
            adpt = new SqlDataAdapter("Select * from Comment",con);
            ft = new DataTable();
            adpt.Fill(ft);
            dataGridView1.DataSource = ft;
        }
    }
}
