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


namespace BankManagment
{
    public partial class Loging : Form
    {
        public Loging()
        {
            InitializeComponent();
        }


        //Admin
        private bool ValidateLogin(string username, string password)
        {
            string connectionString = "Server=CHANDUPA;Database=MoneyBank;Trusted_Connection=True;";
            string query = "SELECT COUNT(1) FROM passwords WHERE username=@username AND passwords=@password";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                try
                {
                    connection.Open();
                    int result = (int)command.ExecuteScalar();
                    return result == 1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                    return false;
                }
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUserName.Text;
            string password = textBoxPassword.Text;

            if (ValidateLogin(username, password))
            {
                MessageBox.Show("Admin login successful!");
                // Proceed to the next form or main application window for admin
                this.Hide();
                MoneyBank M = new MoneyBank();
                M.Show();
            }
            else
            {
                MessageBox.Show("Invalid admin username or password.");
            }
        }


        //Customer

        private bool ValidateCustomerLogin(string username, string password)
        {
            string connectionString = "Server=CHANDUPA;Database=MoneyBank;Trusted_Connection=True;";
            string query = "SELECT COUNT(1) FROM customer WHERE username=@username AND passwords=@password";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                try
                {
                    connection.Open();
                    int result = (int)command.ExecuteScalar();
                    return result == 1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                    return false;
                }
            }
        }

        private void buttonCusLogin_Click_1(object sender, EventArgs e)
        {

            string username = textBoxCusUserName.Text;
            string password = textBoxCusPassword.Text;

            if (ValidateCustomerLogin(username, password))
            {
                MessageBox.Show("Customer login successful!");
                // Proceed to the next form or main application window for customer
                this.Hide();
                Customer C = new Customer();
                C.catchUserName(username);
                C.Show();
            }
            else
            {
                MessageBox.Show("Invalid customer username or password.");
            }
        }
    }
}