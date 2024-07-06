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
    public partial class Success : Form
    {
        private string userName;
        private string accBalance;

        public Success(string userName, string accBalance)
        {
            InitializeComponent();
            this.userName = userName;
            this.accBalance = accBalance;
        }

        private void Success_Load(object sender, EventArgs e)
        {
            textBoxUserName.Text = userName;
            textBoxAccBalance.Text = accBalance;
        }
    }
}