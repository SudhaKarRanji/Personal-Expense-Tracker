using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PET
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox3.Text;
            string email = textBox2.Text;

            if (username == "" || password == "" || email == "")
            {
                MessageBox.Show("Please fill all the fields");
                return;
            }
            else
            {
                saveUserData(username, password, email);
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.ShowDialog();
               
            }

        }

        private void saveUserData(string username, string password, string email)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = "Data Source=SudhakarRanjith;Initial Catalog=PetDb;Integrated Security=True;Encrypt=False";
            sqlConnection.Open();
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                string query = "INSERT INTO users (name, password, email) VALUES (@username, @password, @Email)";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@username", username);
                sqlCommand.Parameters.AddWithValue("@password", password);
                sqlCommand.Parameters.AddWithValue("@Email", email);
                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("User registered successfully");
                sqlConnection.Close();
            }
            else
            {
                MessageBox.Show("Database connection failed");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
