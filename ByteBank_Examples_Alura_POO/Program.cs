using System;

namespace ByteBank_Examples_Alura_POO
{
    class Program
    {
        static void Main(string[] args)
        {

            Account acc1 = new Account() { Holder = "Léo" };
            acc1.Balance += 150;
            Console.WriteLine($"Balance: {acc1.Balance:C}");

            bool withdraw = acc1.Withdraw(250);
            
            if (withdraw)
            {
            Console.WriteLine($"Balance after withdraw: {acc1.Balance:C}");
            }

            acc1.Deposit(500);

            Console.WriteLine($"Balance after deposit: {acc1.Balance:C}");

            Account acc2 = new Account() {Holder = "Gabriel" };

            acc1.Transfer(350, acc2);
            Console.WriteLine($"\nDeposit of the $350.00 of the {acc1.Holder} to {acc2.Holder}");
            Console.WriteLine($"\nBalance Account to: {acc1.Holder} = {acc1.Balance:C}");
            Console.WriteLine($"Balance Account to: {acc2.Holder} = {acc2.Balance:C}");

            Console.ReadKey();
        }
            
    }
}
