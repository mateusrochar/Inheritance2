using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using inheritance.Entities;
using System.Globalization;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            BussinesAccount account = new BussinesAccount(2, "mateus", 1000, 500);

            Console.WriteLine(account.Balance);
            Console.WriteLine(account.Holder);
            Console.WriteLine(account.Number);

            Console.WriteLine(account);

            Console.WriteLine("Entre com  o valor a ser sacado: ");
            double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            account.Withdraw(amount);

            Console.Write("Novo saldo: ");
            Console.WriteLine(account);

            Console.WriteLine("Entre com  o valor a ser depositado: ");
            amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            account.Deposit(amount);


            Console.Write("Novo saldo: ");
            Console.WriteLine(account);

         


            Console.ReadLine();



        }
    }
}
