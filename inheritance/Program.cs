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

            /*  trabalhando com upcasting - converter a superclasse em subclasse
             como a subclasse é uma superclasse é perfeitamente possível sem nenhum comando adicional */


            Account acc1 = new Account(1001, "Alex", 0.0);
            BussinesAccount bacc1 = new BussinesAccount(1002, "Maria", 0.0, 500.00);

            // UpCasting

            Account acc2 = bacc1;
            // neste caso a variável criada é do tipo account, mas está instanciada como bussines account
            Account acc3 = new BussinesAccount(1003, "Bob", 0.0,200.00);
            Account acc4 = new SavingsAccount(1004, "Tiago", 0.0, 0.01);

            // DownCasting

            BussinesAccount bcc2 = (BussinesAccount)acc3;
            bcc2.Loan(200);

            //  BussinesAccount bcc3 = (BussinesAccount)acc4;
            // testa se instanciaçaõ de acc4 é bussines account

            if (acc4 is BussinesAccount)
            {
                // BussinesAccount bcc3 = (BussinesAccount)acc4;

                // outra formar de fazer a conversão.
                BussinesAccount bcc3 = acc4 as BussinesAccount;
                bcc3.Loan(200.0);
                Console.WriteLine("Loan");
            }

            if (acc4 is SavingsAccount)
            {
                // SavingsAccount Sacc1 = (SavingsAccount)acc4;
                SavingsAccount Sacc1 = acc4 as SavingsAccount;
                Sacc1.UpdateBalance();
                Console.WriteLine("Update");
            }


            Console.ReadLine();



        }
    }
}
