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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            string password = textBox2.Text;

            if (email == "" || password == "")
            {
                MessageBox.Show("Please fill all the fields");
                return;
            }
            else
            {
                if (checkUser(email, password))
                {
                    this.Hide();
                    Dashboard dashboard = new Dashboard(email);
                    dashboard.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Invalid email or password");
                }
            }
        }

        private bool checkUser(string email, string password)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = "Data Source=SudhakarRanjith;Initial Catalog=PetDb;Integrated Security=True;Encrypt=False";
            sqlConnection.Open();
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                string query = "SELECT COUNT(*) FROM users WHERE email = @email AND password = @password";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@email", email);
                sqlCommand.Parameters.AddWithValue("@password", password);
                int count = (int)sqlCommand!.ExecuteScalar();
                if (count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
