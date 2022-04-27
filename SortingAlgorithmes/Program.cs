using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithmes
{
    class Program
    {
        static int[] FillIntArray(int[] array)
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-100, 100);
            }
            return array;
        }
        static void BubbleSort1(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1]) // swap the elements
                    {
                        int tmp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = tmp;
                    }
                }
            }
        }
        static void BubbleSort2(int[] array)
        {
            bool flag = true;
            while (flag)
            {
                flag = false;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1]) // swap the elements 
                    {
                        int tmp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = tmp;
                        flag = true;
                    }
                }
            }
        }
        static void SelectionSort1(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                // Find the minimum element in the unsorted array:  
                int minIndex = i;
                for (int j = i + 1; j < array.Length; j++)
                    if (array[j] < array[minIndex])
                        minIndex = j;
                // Swap the found minimum element with the first element:  
                int min = array[minIndex];
                array[minIndex] = array[i];
                array[i] = min;
            }
        }
        static void SelectionSort2(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                    if (array[i] < array[j])
                    {
                        int swap = array[i];
                        array[i] = array[j];
                        array[j] = swap;
                    }
            }
        }

        static void Main(string[] args)
        {
            int[] array1 = new int[] { 12, 1, -3, -6, -11, 32, 4 };
            Console.WriteLine("Array1 before sorting: {0}", String.Join(", ", array1));
            //BubbleSort1(array1);
            SelectionSort1(array1);
            Console.WriteLine("Array1 after selection sort: {0}", String.Join(", ", array1));

            int[] array2 = new int[] { 3, 9, 87, 21, 33, 1, -3, -5, 9 };
            Console.WriteLine();
            Console.WriteLine("Array2 before sorting: {0}", String.Join(", ", array2));
            //BubbleSort1(array2);
            SelectionSort2(array2);
            Console.WriteLine("Array2 after selection sort in the deccending order: {0}", String.Join(", ", array2));

            Random random = new Random();
            int n = random.Next(10, 20);
            int[] array3 = new int[n];
            array3 = FillIntArray(array3);
            Console.WriteLine();
            Console.WriteLine("Array3 before sorting: {0}", String.Join(", ", array3));
            //BubbleSort1(array3);
            SelectionSort1(array3);
            Console.WriteLine("Array3 after selection sort: {0}", String.Join(", ", array3));
            SelectionSort2(array3);
            Console.WriteLine("Array3 after selection sort in the deccending order:: {0}", String.Join(", ", array3));

            Console.ReadKey();
        }
    }
}
