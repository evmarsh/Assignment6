using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment6
{
    internal class Account
    {
        public string AccountID { get; set; }
        public string CustomerName { get; set; }
        public decimal Balance { get; set; }

        public Account() { }
        public Account(string accountID, string customerName, decimal balance)
        {
            this.AccountID = accountID;
            this.CustomerName = customerName;
            this.Balance = balance;
        }

        public void Deposit(decimal amount)
        {
            if (amount < 0)
            {
                MessageBox.Show("Deposit amount cannot be less than 0.");
            }
            else
            {
                Balance += amount;
            }
        }

        public void Withdraw(decimal amount)
        {
            if (amount < 0)
            {
                MessageBox.Show("Withdrawl amount cannot be less than 0.");
            }
            else if (amount > Balance)
            {
                MessageBox.Show("Cannot withdraw more than account balance.");
            }
            else
            {
                Balance -= amount;
            }
        }

        public string GetAccountDetails()
        {
            return AccountID + " " + CustomerName + " " + Balance;
        }
    }
}
