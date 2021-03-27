using ByteBank_Examples_Alura_POO.Entities;
using ByteBank_Examples_Alura_POO.Entities.Exceptions;
using System;

namespace ByteBank_Examples_Alura_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Client client1 = new Client("João", "Developer", "228973015-05");
                Account account1 = new Account(client1, agencyNumber: 152, accountNumber: 456789, balance: 1000);

                Account account2 = new Account();

                account1.Deposit(100);

                Console.WriteLine($"{account1.Balance:C}");

                account1.Transfer(1700, account2);

                Console.WriteLine($"Balance account1 after transfer: {account1.Balance:C}");
                Console.WriteLine($"Balance account2: {account2.Balance:C}");
            }

            catch (BalanceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {

                Console.WriteLine(ex.Message);
            }
            

            Console.ReadKey();
        }

    }
}
