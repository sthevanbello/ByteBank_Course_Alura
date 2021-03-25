using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_Examples_Alura_POO
{
    class Account
    {
        public string Holder { get; set; }
        public int Agency { get; set; }
        public int Number { get; set; }

        public double Balance = 100;

        public bool Withdraw(double value)
        {
            if (Balance < value)
            {
                return false;
            }
            Balance -= value;
            return true;
        }


        public void Deposit(double value)
        {
            Balance += value;
        }

        public bool Transfer(double value, Account accDesnity)
        {
            if (Balance < value)
            {
                return false;
            }

            Balance -= value;
            accDesnity.Deposit(value);
            return true;
        }
    }
}
