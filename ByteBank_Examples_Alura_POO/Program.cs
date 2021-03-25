using ByteBank_Examples_Alura_POO.Entities;
using System;

namespace ByteBank_Examples_Alura_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Client client1 = new Client();

            //client1.Name = "Gabriel";
            //client1.Occupation = "Developer";
            //client1.Cpf = "228753654-15";

            //Console.WriteLine($"Name of the client: {client1.Name}");
            Account acc1 = new Account();
            //acc1.Holder = client1;


            //acc1.Holder = new Client();
            if (acc1.Holder == null)
            {
                Console.WriteLine("Acc1.Holder is null");
            }

            //acc1.Holder.Name = "Gabriel";
            //acc1.Holder.Cpf = "228753654-15";
            //acc1.Holder.Occupation = "Developer";

            acc1.Balance = 500;
            acc1.Agency = 563;
            acc1.Number = 5634527;

            Console.WriteLine($"Name of the client of the Account class: {acc1.Holder.Name}");

            Console.ReadKey();
        }
            
    }
}
