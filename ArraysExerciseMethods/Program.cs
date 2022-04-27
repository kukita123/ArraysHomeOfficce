using System;

namespace ArraysExerciseMethods
{
    class Program
    {
        static void FillArray1(int[] x)
        {
            x[0] = 3;
            x[1] = 5;
        }

        static int[] FillArray2()
        {

            int[] result = new int[5];
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write("Enter arr[" + i + "]="); // Enter arr[0]=
                result[i] = int.Parse(Console.ReadLine());
            }

            return result;
        }

        static double AverageArray(int[] array)
        {
            double x = 0;
            //average...
            return x;
        }

       
//int,string, double,...

        static void Main(string[] args)
        {
            int[] Array1 = new int[10];

           
            FillArray1(Array1);

            Console.WriteLine(String.Join(" ",Array1));


            int[] Array2 = FillArray2();

            Console.WriteLine(String.Join(" ", Array2));


            double average = AverageArray(Array1);

            Console.ReadKey();
        }
    }
}
