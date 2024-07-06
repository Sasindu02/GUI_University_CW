using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BankManagment
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void buttongo_Click(object sender, EventArgs e)
        {
            // Retrieve deposit amount
            string depositAmountText = textBoxDepositAmount.Text;
            string transferAmountText = textBoxTransferAmount.Text;
            string transferAccNumber = textBoxTransferAccNo.Text;

            if (!string.IsNullOrEmpty(depositAmountText) && decimal.TryParse(depositAmountText, out decimal depositAmount))
            {
                // Update the database for deposit
                UpdateBalance(depositAmount);

                // Refresh the displayed balance
                string updatedBalance = getBalance().Rows[0]["Amount"].ToString();

                // Hide the current form and open the success form
                this.Hide();
                Success S = new Success(textBoxHello.Text, updatedBalance);
                S.Show();
            }
            else if (!string.IsNullOrEmpty(transferAmountText) && decimal.TryParse(transferAmountText, out decimal transferAmount) && !string.IsNullOrEmpty(transferAccNumber))
            {
                // Update the database for transfer
                TransferAmount(transferAmount, transferAccNumber);

                // Refresh the displayed balance
                string updatedBalance = getBalance().Rows[0]["Amount"].ToString();

                // Hide the current form and open the success form
                this.Hide();
                Success S = new Success(textBoxHello.Text, updatedBalance);
                S.Show();
            }
            else
            {
                // Even if no amount is entered, open the success form with current balance
                string currentBalance = getBalance().Rows[0]["Amount"].ToString();
                this.Hide();
                Success S = new Success(textBoxHello.Text, currentBalance);
                S.Show();
            }
        }

        public void catchUserName(String userName)
        {
            textBoxHello.Text = userName;
            textBoxAccBalance.Text = getBalance().Rows[0]["Amount"].ToString();
        }

        private DataTable getBalance()
        {
            try
            {
                string userName = textBoxHello.Text;
                string connectionString = "Server=CHANDUPA;Database=MoneyBank;Trusted_Connection=True;";
                string query = "SELECT Amount FROM customer WHERE username = @UserName";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@UserName", userName);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    return dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private void UpdateBalance(decimal depositAmount)
        {
            try
            {
                string userName = textBoxHello.Text;
                string connectionString = "Server=CHANDUPA;Database=MoneyBank;Trusted_Connection=True;";
                string query = "UPDATE customer SET Amount = Amount + @DepositAmount WHERE username = @UserName";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@DepositAmount", depositAmount);
                    cmd.Parameters.AddWithValue("@UserName", userName);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TransferAmount(decimal transferAmount, string transferAccNumber)
        {
            try
            {
                string userName = textBoxHello.Text;
                string connectionString = "Server=CHANDUPA;Database=MoneyBank;Trusted_Connection=True;";
                string query = "UPDATE customer SET Amount = Amount - @TransferAmount, TransferAccNumber = @TransferAccNumber WHERE username = @UserName;" +
                               "UPDATE customer SET Amount = Amount + @TransferAmount WHERE username = @TransferAccNumber";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@TransferAmount", transferAmount);
                    cmd.Parameters.AddWithValue("@UserName", userName);
                    cmd.Parameters.AddWithValue("@TransferAccNumber", transferAccNumber);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxDepositAmount_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
