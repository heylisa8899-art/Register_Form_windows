using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task3
{
    public partial class Register_Form : Form
    {
        private readonly string connectionString = @"Data Source = Ahsmos\SQLEXPRESS; Initial Catalog = Task3; Integrated Security = True; Connect Timeout = 30; Encrypt = True";

        public Register_Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }
                
            {InitializeComponent();}

      

        private void Register_Form(object sender, EventArgs e)
        {
            conneciton.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT*FROM Users", conneciton);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conneciton.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
