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
    public partial class Saving : Form
    {
        public Saving()
        {
            InitializeComponent();

            // Connect the Validating events to the textboxes
            textBoxInitials.Validating += textBoxInitials_Validating;
            textBoxNIC.Validating += textBoxNIC_Validating;
        }

        private void buttonSavingOK_Click(object sender, EventArgs e)
        {
            // Perform validation on all controls
            if (!ValidateChildren(ValidationConstraints.Enabled))
            {
                buttonSavingOK.Enabled = true;
                return;
            }

            // Disable the button to prevent multiple clicks
            buttonSavingOK.Enabled = false;

            // Collecting input data from form saving textboxes and Update Acc created table
            string initials = textBoxInitials.Text;
            string fullName = textBoxFullName.Text;
            string address = textBoxAddress.Text;
            string nic = textBoxNIC.Text;

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
                command.Parameters.AddWithValue("@NicBisNo", nic);

                SqlCommand commandCustomer = new SqlCommand(queryCustomer, connection);
                commandCustomer.Parameters.AddWithValue("@username", username);
                commandCustomer.Parameters.AddWithValue("@passwords", password);
                commandCustomer.Parameters.AddWithValue("@Amount", amount);

                try
                {
                    // Open the connection to DB
                    connection.Open();
                    // Execute the command to insert data
                    command.ExecuteNonQuery();
                    commandCustomer.ExecuteNonQuery();
                    MessageBox.Show("Data saved successfully!");

                    // Hide the current form and open the next form with creating obj
                    this.Hide();
                    AccCreated A = new AccCreated();
                    A.Show();
                }
                catch (Exception ex)
                {
                    // Error message (.ex.Message to display the error)
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    // Re-enable the button for future use, in case of an error
                    buttonSavingOK.Enabled = true;
                }
            }
        }

        private void textBoxInitials_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxInitials.Text))
            {
                e.Cancel = true;
                textBoxInitials.Focus();
                errorProviderIniName.SetError(textBoxInitials, "Initials can't be empty");
            }
            else
            {
                e.Cancel = false;
                errorProviderIniName.SetError(textBoxInitials, null);
            }
        }

        private void textBoxNIC_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNIC.Text))
            {
                e.Cancel = true;
                textBoxNIC.Focus();
                errorProviderNIC.SetError(textBoxNIC, "NIC can't be empty");
            }
            else
            {
                e.Cancel = false;
                errorProviderNIC.SetError(textBoxNIC, null);
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
