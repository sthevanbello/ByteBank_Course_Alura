using ByteBank_Examples_Alura_POO.Entities;
using ByteBank_Examples_Alura_POO.Entities.Exceptions;
using System;
using System.IO;

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

                account1.Withdraw(15000);

                Console.WriteLine($"Balance account1 after transfer: {account1.Balance:C}");
                Console.WriteLine($"Balance account2: {account2.Balance:C}");
            }

            catch (BalanceInsufficientException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);

            }
            catch (ArgumentException ex)
            {

                Console.WriteLine(ex.Message);
            }
            catch (FinancialOperationException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                
            }
            

            Console.ReadKey();
        }

    }
}
