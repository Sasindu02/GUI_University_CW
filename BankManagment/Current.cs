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


namespace BankManagment
{
    public partial class Current : Form
    {
        public Current()
        {
            InitializeComponent();
            textBoxInitialsName.Validating += textBoxInitialsName_Validating;
            textBoxNicBussNo.Validating += textBoxNicBussNo_Validating;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            // Perform validation on all controls
            if (!ValidateChildren(ValidationConstraints.Enabled))
            {
                buttonOK.Enabled = true;
                return;
            }

            // Disable the button to prevent multiple clicks
            buttonOK.Enabled = false;

            // Collecting input data from form textboxes
            string initials = textBoxInitialsName.Text;
            string fullName = textBoaxFullName.Text;
            string address = textBoxAddress.Text;
            string nicBisNo = textBoxNicBussNo.Text;

            //Update customer table
            string username = textBoxUserName.Text;
            string password = textBoxPassword.Text;
            int amount = int.Parse(textBoxDepositAmount.Text);

            // Define the connection string for the Moneybank DB
            string connectionString = "Server=CHANDUPA;Database=MoneyBank;Trusted_Connection=True;";
            // Define SQL query to insert data to DB
            string query = "INSERT INTO AccountCreated (Ininame, Fullname, Addresss, NicBisNo) VALUES (@Ininame, @Fullname, @Addresss, @NicBisNo)";
            string queryCustomer = "INSERT INTO customer (username, passwords, Amount) VALUES (@username, @passwords, @Amount)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Create a command object to execute the query
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Ininame", initials);
                command.Parameters.AddWithValue("@Fullname", fullName);
                command.Parameters.AddWithValue("@Addresss", address);
                command.Parameters.AddWithValue("@NicBisNo", nicBisNo);

                SqlCommand commandCustomer = new SqlCommand(queryCustomer, connection);
                commandCustomer.Parameters.AddWithValue("@username", username);
                commandCustomer.Parameters.AddWithValue("@passwords", password);
                commandCustomer.Parameters.AddWithValue("@Amount", amount);

                try
                {
                    // Open the connection to the database
                    connection.Open();
                    // Execute the command to insert data
                    command.ExecuteNonQuery();
                    commandCustomer.ExecuteNonQuery();
                    MessageBox.Show("Data saved successfully!");

                    // Hide the current form and open the next form with creating an object
                    this.Hide();
                    AccCreated A = new AccCreated();
                    A.Show();
                }
                catch (Exception ex)
                {
                    // Show an error message
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    // Re-enable the button for future use, in case of an error
                    buttonOK.Enabled = true;
                }
            }
        }

        private void textBoxInitialsName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxInitialsName.Text))
            {
                e.Cancel = true;
                textBoxInitialsName.Focus();
                errorProviderIniName.SetError(textBoxInitialsName, "Initials can't be empty");
            }
            else
            {
                e.Cancel = false;
                errorProviderIniName.SetError(textBoxInitialsName, null);
            }
        }

        private void textBoxNicBussNo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNicBussNo.Text))
            {
                e.Cancel = true;
                textBoxNicBussNo.Focus();
                errorProviderNic.SetError(textBoxNicBussNo, "NIC can't be empty");
            }
            else
            {
                e.Cancel = false;
                errorProviderNic.SetError(textBoxNicBussNo, null);
            }
        }

        private void buttonback_Click(object sender, EventArgs e)
        {
            this.Hide();
            MoneyBank S = new MoneyBank();
            S.Show();
        }
    }
}
