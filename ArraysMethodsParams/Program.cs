using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1. Дефинирайте метод, на който се подават като параметри две числа и логическа стойност и която връща произведението на числата, 
// ако логическата стойност е true, или разликата на числата, ако логическата стойност е false. 
// Въведете две числа от клавиатурата и извикайте дефинираната функция, така че да изведете на екрана тяхното произведение и тяхната разлика.

//2. Дефинирайте функция с два параметъра цели числа.Ако и двата параметъра са с еднаква четност(и двата четни или и двата нечетни), 
// стойностите им се намаляват с 1, иначе - четният параметър се намалява 2 пъти, а нечетният – се увеличава с 1. 
// Въведете две цели числа от клавиатурата (или генерирайте случайни целочислени стойности) и извикайте за тях дефинираната функция.
// След това отпечатайте на екрана стойностите на числата.

//3. Дефинирайте функция на един цял параметър x, който извежда на един ред на екрана четните числа от 2 до x. 
// Използвайте тази функция за отпечатване на:
// 2 4 6 8 10 12 
// 4 6 8 10 12 
// 6 8 10 12 
// 8 10 12 
// 10 12 
// 12 




namespace ArraysMethodsParams
{
    class Program
    {

        static void Addition(params int[] integers)
        {
            int result = 0;
            for (int i = 0; i < integers.Length; i++)
            {
                result += integers[i];
            }
            Console.WriteLine(result);
        }
        public static void IncreaseByTwo(ref int a, ref int x)
        {
            Console.WriteLine("x befor increasing: "+a+ "y before change: "+x);
            a += 2;
            x = 44;
        }


        //Exercise 1:

        //Exercise 2:
        public static void Ex2(out int a, out int b, int x, int y)
        {
            if ((x % 2 == 0 && y % 2 == 0) || (x % 2 != 0 && y % 2 != 0))
            {
                a = x - 1;
                b = y - 1;
            }
            else if(x % 2 == 0 && y % 2 != 0)
            {
                a = x / 2;
                b = y + 1;
            }
            else
            {
                a = x + 1;
                b = y / 2;
            }
        }
        //Exercise 3:
        public static void Ex3(int x)
        {           
                for (int i = 2; i < x; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write(i + " ");
                    }
                }
                Console.WriteLine(); 
        }
        //Exercise 4 - размяна стойности на две числа чрез метод с ref
        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static void Main(string[] args)
        {

            //Addition(1, 2, 3, 4, 5);    //15

            //int[] array = new int[] { 1, 2, 3, 4 };
            //Addition(array);     //10

            //Addition();    //0

            //int x = 5;
            //int y = 6;
            //IncreaseByTwo(ref x, ref y);
            //Console.WriteLine(x);
            //Console.WriteLine(y);

            Random r = new Random();
            ////Exersice 2:
            //int a, b;
            //a = r.Next(-20, 20);
            //b = r.Next(-20, 20);
            //Console.WriteLine("a={0}", a);
            //Console.WriteLine("b={0}", b);

            //Ex2(out a, out b, a, b);
            //Console.WriteLine("a={0}", a);
            //Console.WriteLine("b={0}", b);

            //Exercise 3:
            int x = r.Next(2, 20);
            while (x >= 0)
            {
                Ex3(x);
                x -= 2;
            }

            ////Exercise 4:
            //Console.WriteLine();
            //Console.WriteLine("Before swap:");
            //Console.WriteLine("a={0}", a);
            //Console.WriteLine("b={0}", b);
            //Swap(ref a, ref b);
            //Console.WriteLine("After swap:");
            //Console.WriteLine("a={0}", a);
            //Console.WriteLine("b={0}", b);

            Console.ReadKey();
        }
    }
}
/*
 Да се създадат три числови масива - един с 10 случайни стойности, втори с 5 стойности, въведени от конзола,
 и трети - с 7 стойности, подадени чрез инициализатори. Да се провери дали в тях се съдържа числото -13 - резултат
 проверката да е булева стойност
 Да се изведат и трите масива на конзола.
 */