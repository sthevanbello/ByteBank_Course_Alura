using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_Examples_Alura_POO.Entities.Exceptions
{
    public class BalanceException : Exception
    {
        public double Balance { get; }
        public double Amount { get; }

        public BalanceException(double balance, double withdrawValue) : this($"Withdrawl attempt with insufficient balance\nBalance: {balance}\nWithdraw: {withdrawValue}")
        {
            Balance = balance;
            Amount = withdrawValue;
        }

        public BalanceException(string message) : base(message)
        {

        }



    }
}
