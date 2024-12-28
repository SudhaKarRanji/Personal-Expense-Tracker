using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PET
{
    public partial class AddExpense : Form
    {
        private string usermail;
        public AddExpense(string email)
        {
            InitializeComponent();
            usermail = email;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void AddExpense_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string expense = textBox1.Text;
            string amount = textBox2.Text;
            DateTime date = monthCalendar1.SelectionStart;
            string category = textBox3.Text;
            string paymenetMethod = checkPayment();
            string note = richTextBox1.Text;
            

            if (expense == "" || amount == "" || category == "" || paymenetMethod == "")
            {
                MessageBox.Show("Please fill all the fields");
            }
            else
            {
                SqlConnection sqlConnection = new SqlConnection();
                sqlConnection.ConnectionString = "Data Source=SudhakarRanjith;Initial Catalog=PetDb;Integrated Security=True;Encrypt=False";
                sqlConnection.Open();
                if (sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    string query = "INSERT INTO expense (email, expense, amount, date, category, paymentMethod, note) VALUES (@email, @expense, @amount, @date, @category, @paymentMethod, @note)";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@email", usermail);
                    sqlCommand.Parameters.AddWithValue("@expense", expense);
                    sqlCommand.Parameters.AddWithValue("@amount", amount);
                    sqlCommand.Parameters.AddWithValue("@date", date);
                    sqlCommand.Parameters.AddWithValue("@category", category);
                    sqlCommand.Parameters.AddWithValue("@paymentMethod", paymenetMethod);
                    sqlCommand.Parameters.AddWithValue("@note", note);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Expense added successfully");
                    this.Close();
                }

            }

        }

        private string checkPayment()
        {
            if(radioButton1.Checked)
            {
                return "Cash";
            }
            else if (radioButton2.Checked)
            {
                return "Card";
            }
            else
            {
                return "Online";
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
