using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;



namespace PET
{
    public partial class Dashboard : Form
    {
        public string usermail;
        private string uname;
        public Dashboard(string email)
        {
            InitializeComponent();
            usermail = email;
            string pattern = @"^([a-zA-Z0-9._%+-]+)@";
            Match match = Regex.Match(email, pattern);
            if (match.Success)
            {
                string name = match.Groups[1].Value;
                uname = name;
            }
            else
            {
                Console.WriteLine("No match found.");
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            
            label1.Text = $"Welcome, {uname}!";
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddExpense addExpense = new AddExpense(usermail);
            addExpense.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
