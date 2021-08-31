using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class CurrentAccount : Account
    {
        public CurrentAccount()
        {
            AccountType = "Current";
        }

        public CurrentAccount(string accountNumber, string name, string phone, double balance) : base(accountNumber, name, phone, balance)
        {
            AccountType = "Current";
        }
    }
}
