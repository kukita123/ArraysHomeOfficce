using System;

namespace Statics
{
    class Calculator
    {
        public static int Sum(int a, int b)
        {
            return a + b;
        }
        //Substract
        //Multiply
        //Division
    }
    class Account
    {
        public static decimal bonus = 100;
        public decimal totalSum;
        public Account(decimal sum)
        {
            totalSum = sum + bonus;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculator.Sum(4,5));
            //
            //
            //

            /*
            Console.WriteLine(Account.bonus);      // 100
            Account.bonus += 200;

            Account account1 = new Account(150);
            Console.WriteLine(account1.totalSum);   // 450

            Account account2 = new Account(1000);
            Console.WriteLine(account2.totalSum);   // 1300
*/
            Console.ReadKey();
        }
    }
}
