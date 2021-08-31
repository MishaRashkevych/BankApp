using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class Account
    {
        public string AccountNumber { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string AccountType { get; set; }
        public double Balance { get; set; }

        public Account()
        {
            Balance = 5000;
        }

        public Account(string accountNumber, string name, string phone, double balance)
        {
            AccountNumber = accountNumber;
            Name = name;
            Phone = phone;
            Balance = balance;
        }

        public override string ToString()
        {
            return AccountNumber + " "+ AccountType + " " + Name + " " + Phone ;
        }

        public void GetAccDetFromUser()
        {
            Console.WriteLine("AccountNumber");
            AccountNumber = Console.ReadLine();

            Console.WriteLine("AccountType");
            AccountType = Console.ReadLine();

            Console.WriteLine("Name");
            Name = Console.ReadLine();

            Console.WriteLine("Phone");
            Phone = Console.ReadLine();
        }
    }
}
