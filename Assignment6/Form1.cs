using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Assignment6
{
    public partial class Form1 : Form
    {
        BindingList<Account> accounts = new BindingList<Account>();
        readonly string filePath = "../../data/testCSV.csv";

        public Form1()
        {
            InitializeComponent();
        }

        private void fillData()
        {
            dataGridViewAccounts.DataSource = accounts;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            dataGridViewAccounts.Rows.Clear();
            dataGridViewAccounts.Refresh();
            try
            {
                var lines = File.ReadAllLines(filePath);

                for (int i = 1; i < lines.Length; i++)
                {
                    var columns = lines[i].Split(',');

                    accounts.Add(new Account()
                    {
                        AccountID = columns[0],
                        CustomerName = columns[1],
                        Balance = Convert.ToDecimal(columns[2])
                    });
                }

                fillData();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("File cannot be found.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (var writer = new StreamWriter(filePath))
                {
                    writer.WriteLine("AccountID,CustomerName,Balance");

                    foreach (var account in accounts)
                    {
                        writer.WriteLine($"{account.AccountID},{account.CustomerName},{account.Balance}");
                    }
                }

                MessageBox.Show("Data saved successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAccountId.Text) || string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtBalance.Text))
            {
                MessageBox.Show("Please fill out all account information.");
            }
            else
            {
                bool createAccount = true;
                foreach (var account in accounts)
                {
                    if (account.AccountID == txtAccountId.Text)
                    {
                        MessageBox.Show("Account already exists");
                        createAccount = false;
                        break;
                    }
                }
                if (createAccount)
                {
                    accounts.Add(new Account(txtAccountId.Text, txtName.Text, Convert.ToDecimal(txtBalance.Text)));
                    fillData();
                    MessageBox.Show("Account created!");
                }
            }
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAccountID2.Text) || string.IsNullOrEmpty(txtDeposit.Text))
            {
                MessageBox.Show("Please fill out all account information.");
            }
            else
            {
                bool NoAccount = true;
                foreach (var account in accounts)
                {
                    if (account.AccountID == txtAccountID2.Text)
                    {
                        decimal depositAmount = decimal.Parse(txtDeposit.Text);
                        account.Deposit(depositAmount);
                        dataGridViewAccounts.Refresh();
                        MessageBox.Show("Your deposit was successful!");
                        fillData();
                        NoAccount = false;
                    }
                }
                if (NoAccount)
                {
                    MessageBox.Show("Account does not exist.Please check your input");
                }
            }
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAccountID2.Text) || string.IsNullOrEmpty(txtWithdraw.Text))
            {
                MessageBox.Show("Please fill out all account information.");
            }
            else
            {
                bool NoAccount = true;
                foreach (var account in accounts)
                {
                    if (account.AccountID == txtAccountID2.Text)
                    {
                        decimal withdrawAmount = decimal.Parse(txtWithdraw.Text);
                        account.Withdraw(withdrawAmount);
                        dataGridViewAccounts.Refresh();
                        MessageBox.Show("Your withdrawal was successful!");
                        fillData();
                        NoAccount = false;
                    }
                }
                if (NoAccount)
                {
                    MessageBox.Show("Account does not exist.Please check your input");
                }

            }
        }
    }
}
