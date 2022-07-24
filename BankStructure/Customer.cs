using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum accountType
{
    Saving,
    Current
}

namespace BankStructure
{
    internal class Customer
    {
        public static void Main(string[] args)
        {
            SavingAccount C1 = new SavingAccount();
            C1.Name = "Himanshu";
            C1.AccountID = "C1";
            C1.Amount = 100;
            C1.Interest = 0;

            C1.AddInterest();

            CurrentAccount C2 = new CurrentAccount();
            C2.Name = "Yash";
            C2.AccountID = "C2";
            C2.Amount = 200;
            C2.Interest = 0;

            C2.AddInterest();

            Console.WriteLine(C1.Name);
            Console.WriteLine(C1.Interest);

            Console.WriteLine();

            Console.WriteLine(C2.Name);
            Console.WriteLine(C2.Interest);
        }
    }
}
