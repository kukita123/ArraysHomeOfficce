using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysHomeOfficce
{
    class Program
    {
        //Enter data from keyboard
        static void EnterArrayData(int[] IntArray)
        {
            Console.WriteLine("Enter data from the keyboard:");
            for (int i = 0; i < IntArray.Length; i++)
            {
                Console.Write("Enter Array[{0}]=",i);
                IntArray[i] = int.Parse(Console.ReadLine());
            }
        }      
        //Generating Random ArrayData:
        static void RandomrArrayData(int[] IntArray)
        {
            Console.WriteLine("Generating Random Array Data:");

            Random r=new Random();
            for (int i = 0; i < IntArray.Length; i++)
            {
                IntArray[i] = r.Next(-1000,1000);
            }
        }
        //Display array on the monitor:
        static void DisplayArray(int[] IntArray)
        {
            Console.WriteLine("Dispaying the array:");
            for (int i = 0; i < IntArray.Length; i++)
            {
                Console.WriteLine("Arr[{0}]={1}",i,IntArray[i]);

            }
        }
        //Минимум на масив:
        static int Minimum(int[] IntArray)
        {
            //int min = Int32.MaxValue;
            int min = IntArray[0];
            for (int i = 1; i < IntArray.Length; i++)
            {
                if (IntArray[i]<min)
                {
                    min = IntArray[i];
                }
            }
            return min;
        }
        //Maximum
        static int Maximum(int[] IntArray)
        {
            //int max = Int32.MinValue;
            int max = IntArray[0];
            for (int i = 0; i < IntArray.Length; i++)
            {
                if (IntArray[i]>max)
                {
                    max = IntArray[i];
                }
            }
            return max;  
        }
        static int CountEven(int[] IntArray)
        {
            int count = 0;
            for (int i = 0; i < IntArray.Length; i++)
            {
                if (IntArray[i] %2==0)
                {
                    count++;
                }
            }
            return count;
        }
        static int CountPositives(int[] IntArray)
        {
            int count = 0;
            for (int i = 0; i < IntArray.Length; i++)
            {
                if (IntArray[i]> 0)
                {
                    count++;
                }
            }
            return count;
        }
        static void ArrayIndex(int[] IntArray)
        {
            for (int i = 1; i < IntArray.Length; i++)
            {
                if (IntArray[i] == i)
                {
                    Console.WriteLine("Arr[{0}]={1}", i, IntArray[i]);
                }
            }
        } 
        static int[] ExtractPositives(int[] Array)
        {
            int[] NewArray = new int[CountPositives(Array)];
            int j = 0;
            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] > 0)
                {
                    NewArray[j] = Array[i];
                    j++;
                }         
            }
            return NewArray;
        }
        static int Sum(int[] IntArray)
        {
            int sum = 0;
            foreach (int item in IntArray)
            {
                sum += item;
            }
            return sum;
        }
        static double AverageArray(int[] IntArray)
        {
            return (double)Sum(IntArray) / IntArray.Length;
        }
        static bool IsThereAverageValue(int[] IntArray)
        {
            bool flag = false;
            foreach(int item in IntArray)
            {
                if (item == Math.Round(AverageArray(IntArray)))
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }
        static int CountBiggerThanAverage(int[] IntArray)
        {
            int count = 0;
            foreach(int item in IntArray)
            {
                if (item>AverageArray(IntArray))
                {
                    count++;
                }
            }
            return count;
        }
        static bool IsSorted(int[] intArray)
        {
            bool flagSorted = true;
            for (int i = 0; i < intArray.Length - 1; i++)
            {
                if (intArray[i] > intArray[i + 1])
                {
                    flagSorted = false;
                    break;
                }
            }
            return flagSorted;
        }
        static void AllMinimums(int[] IntArray)
        {
            int min = Minimum(IntArray);
            for (int i = 0; i < IntArray.Length; i++)
            {
                if (IntArray[i] == min)
                {
                    Console.WriteLine("The index of the minimum: {0}", i);
                }
            }
        }
        static bool EqualArrays(int[] IntArray1, int[] IntArray2)
        {
            if (IntArray1.Length != IntArray2.Length)
            {
                return false;
            }
            for (int i = 0; i < IntArray1.Length; i++)
            {
                if (IntArray1[i] != IntArray2[i])
                {
                    return false;
                }
            }
            return true;
        }
        //на екрана елементите на масива, равни на своя индекс???
        //минималния елемент и индексите, на които е той
        //метод, който проверява дали два масива са равни
        static int[] Create_C_Array(int[] A, int[] B)
        {
            int[] c = new int [A.Length];
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > B[i])
                {
                    c[i] = A[i];
                }
                else c[i] = B[i];
            }
            return c;
        }
        static void SumBeforeLastAppereance(int[] array, int number)
        {
            int index = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                    index = i;
            }

            int sum = 0;
            if(index == -1)
                Console.WriteLine("No occurrences were found!");
            else
            {
                for (int i = 0; i < index; i++)
                {
                    sum += array[i];
                }
                Console.WriteLine("Sum={0}",sum);
            }            
        }
        static void Main(string[] args)
            {
            //int[] MyIntArray = new int[5];
            //int[] MyIntArray2 = new int[8];
            //if (EqualArrays(MyIntArray, MyIntArray2))
            //{
            //    //...
            //}
            //Console.WriteLine(EqualArrays(MyIntArray, MyIntArray2));

            ////Entering Data:
            ////EnterArrayData(MyIntArray);
            ////Generating random data in array:
            //RandomrArrayData(MyIntArray);
            ////Display Array Data:
            //DisplayArray(MyIntArray);
            //Console.WriteLine("The minimum is: {0}", Minimum(MyIntArray));
            //Console.WriteLine("The maximum is: {0}", Maximum(MyIntArray));
            //Console.WriteLine("Tne even numbers count is: {0}", CountEven(MyIntArray));
            //ArrayIndex(MyIntArray);
            //AllMinimums(MyIntArray);

            //int[] A = new int[20];
            //RandomrArrayData(A);
            //DisplayArray(A);
            //Console.WriteLine();
            //int[] B = new int[20];
            //RandomrArrayData(B);
            //DisplayArray(B);
            //Console.WriteLine();
            //int[] C = ExtractPositives(A);
            //DisplayArray(C);

            int[] array = new int[10];
            EnterArrayData(array);
            DisplayArray(array);
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());
            SumBeforeLastAppereance(array, number);

            Console.ReadKey();

            }
    }
}
