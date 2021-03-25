using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_Examples_Alura_POO.Entities

{
    class Account
    {
        public Client Holder { get; set; }
        public uint Agency { get; set; }
        public uint Number { get; set; }

        private double _balance = 100;

        // public double Balance { get; set; }

        public double Balance
        {
            get
            {
                return _balance;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                _balance = value;
            }
        }

        public Account(Client holder, uint agency, uint number, double balance)
        {
            Holder = holder;
            Agency = agency;
            Number = number;
            Balance = balance;
        }

        public Account()
        {
            // Balance = 100;
        }

        public double GetBalance()
        {
            return Balance;
        }

        public void SetBalance(double value)
        {
            if (value < 0)
            {
                return;
            }
            _balance += value;
        }
        public bool Withdraw(double value)
        {
            if (_balance < value)
            {
                return false;
            }
            _balance -= value;
            return true;
        }


        public void Deposit(double value)
        {
            _balance += value;
        }

        public bool Transfer(double value, Account accDesnity)
        {
            if (_balance < value)
            {
                return false;
            }

            _balance -= value;
            accDesnity.Deposit(value);
            return true;
        }
    }
}
