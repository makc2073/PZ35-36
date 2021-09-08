using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PZ35_36
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string connectionString = "server=10.10.1.24;Trusted_Connection=No;DataBase=PZrom;User=pro-41;PWD=IsPro-41";
        private object clientsTableAdapter;
        private object onlineStoreDataSet;

        private void Form1_Load(object sender, EventArgs e)
        {
            
            string sql1 = "SELECT * FROM product";
            string sql2 = "SELECT * FROM provider";
            string sql3 = "SELECT * FROM purchase";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter1 = new SqlDataAdapter(sql1, connection);
                SqlDataAdapter adapter2 = new SqlDataAdapter(sql2, connection);
                SqlDataAdapter adapter3 = new SqlDataAdapter(sql3, connection);
                DataSet ds1 = new DataSet();
                DataSet ds2 = new DataSet();
                DataSet ds3 = new DataSet();
                adapter1.Fill(ds1);             
                dataGridView1.DataSource = ds1.Tables[0];                
                adapter2.Fill(ds2);
                dataGridView2.DataSource = ds2.Tables[0];
                adapter3.Fill(ds3);
                dataGridView3.DataSource = ds3.Tables[0];
                connection.Close();
            }
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string sqlExpression = "INSERT INTO product (product_id, name_product) VALUES (" + textBox1.Text + ", '" + textBox2.Text + "')";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                int number = command.ExecuteNonQuery();
                MessageBox.Show("Объект добавлен");
                connection.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sqlExpression = "INSERT INTO provider (Provider_id, name_provider, email, phone) VALUES (" + textBox3.Text + ", '" + textBox4.Text + "', '" + textBox5.Text + "', '" + textBox6.Text + "')";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                int number = command.ExecuteNonQuery();
                MessageBox.Show("Объект добавлен");
                connection.Close();


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sqlExpression = "INSERT INTO purchase (purchase, provider_ids, product_ids, weigth, cost,count_product ) VALUES (" + textBox7.Text + ", "+ textBox8.Text +", "+ textBox9.Text +", "+ textBox10.Text + " , " + textBox11.Text + " , " + textBox12.Text + ")";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                int number = command.ExecuteNonQuery();
                MessageBox.Show("Объект добавлен");
                connection.Close();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
               

            
        }
    }
}
