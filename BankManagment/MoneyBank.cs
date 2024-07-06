using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManagment
{
    public partial class MoneyBank : Form
    {
        public MoneyBank()
        {
            InitializeComponent();
        }

        private void FormMoneyBank_Load(object sender, EventArgs e)
        {

        }

        private void buttonSavingAcc_Click(object sender, EventArgs e)
        {
            Saving saving = new Saving();
            saving.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Current current = new Current();
            current.Show();
            this.Hide();
        }
    }
}
