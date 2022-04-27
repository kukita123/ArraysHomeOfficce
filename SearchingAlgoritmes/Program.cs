using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchingAlgoritmes
{
    class Program
    {
        static int LinearSearch(int[]array, int value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                    return i;
            }
            return -1;
        }

        private static int BinarySearch1(int[] array, int value, int left, int right)
        {
            if (right >= left)
            {
                int middle = (left + right ) / 2; //5..............10

                // If the element is present at the middle itself: 
    
                if (array[middle] == value)
                    return middle;


                if (array[middle] > value)
                    return BinarySearch1(array, value,left, middle - 1);

                // Else the element can only be in right subarray: 
              
                return BinarySearch1(array, value, middle + 1, right);
            }

            // We reach here when element is not present in array:
  
            return -1;
        }

        public static int BinarySearch1(int[] array, int value)
        {
            return BinarySearch1(array, value, 0, array.Length - 1);
        }

        static int BinarySearch2(int[]array, int value)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int middle = (left + right) / 2; ;

                if (value == array[middle])
                    return middle;
                if (value < array[middle])
                    right = middle - 1;
                else
                    left = middle + 1;
            }
            return -1;
        }
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine(LinearSearch(array, 0));
            //sort array !!!!!
            Console.WriteLine(BinarySearch1(array, 5));
            Console.WriteLine(BinarySearch2(array, 4));

            Console.ReadKey();
        }
    }
}
