using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArrays
{
    class Program
    {
        //Create random array:
        static void RandomrArrayData(int[] IntArray)
        {
            Console.WriteLine("Generating Random Array Data:");

            Random r = new Random();
            for (int i = 0; i < IntArray.Length; i++)
            {
                IntArray[i] = r.Next(1, 1000);
            }
        }
        //Display array on the monitor:
        static void DisplayArray(int[] IntArray)
        {
            Console.WriteLine("Dispaying the array:");
            for (int i = 0; i < IntArray.Length; i++)
            {
                Console.WriteLine("Arr[{0}]={1}", i, IntArray[i]);

            }
        }
        //Swap Array Elements:
        static void SwapElements(ref int a,ref  int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        //Classic Bubble sort:
        static void BubbleSort1(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1]) // swap the elements
                    {
                        SwapElements(ref array[j],ref  array[j + 1]);
                    }
                }
            }
        }
        static int[] BubbleSort1Type(int[] array)
        {
            //....sort
            return array;
        }
        //Accelerated Bubble sort (using flag)
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
                        SwapElements(ref array[i], ref array[i + 1]);
                        flag = true;
                    }
                }
            }
        }
        //Selection sort:
        static void SelectionSort1(int[]array)
        {
            for (int i = 0; i < array.Length-1; i++)
            {
                int minIndex = i;   //int min=array[0], then min=array[1], then ....
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[j]<array[minIndex])
                    {
                        minIndex = j;
                        int swap = array[minIndex]; //here swap remembers array[j], it's the minimum
                        array[minIndex] = array[i];
                        array[i] = swap;
                    }
                }
            }
        }
        //Selection sort2:
        static void SelectionSort2(int[]array)
        {
            for (int i = 0; i < array.Length-1; i++)
            {
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[i]>array[j])
                    {
                        int swap = array[i];
                        array[i] = array[j];
                        array[j] = swap;
                    }
                }
            }
        }
        //Insertion sort (Сортиране чрез вмъкване):
        static int[] InsertionSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int value = array[i];
                int index = i;
                while (index > 0 && array[index - 1] >= value)
                {
                    array[index] = array[index - 1]; //pusing all bigger values to the right
                    index--;
                }
                array[index] = value; //set the value in a specific index
            }
            return array; //sorted array
        }
        static void MaxAreaSortedArray(int[] array)
        {
            BubbleSort1(array);

            int len = 0;         //tekushta dylzhina na ploshtadkata
            int f_pos = 0;      //stratova poziciq na poredna ploshtadka
            int f_num = 0;      //broi otkriti ploshtadki

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    len++;
                }
                else
                {
                    if (len != 0)
                    {
                        Console.WriteLine("Area beginnig index: {0}", f_pos);
                        Console.WriteLine("Area lenth: {0}",len+1);

                        f_num++;
                    }
                    len = 0;
                    f_pos = i + 1;
                }
            }

            if (f_num == 0) Console.WriteLine("There is no areas");

        }
        static int[] BallanceArray(int[] array) ////!!!!!!!!!!!!!1
        {
            int[] newArray = new int[array.Length];

            int[] newArr1 = new int[array.Length / 2];
            int[] newArr2 = new int[array.Length - array.Length / 2]; //!!!! 

            for (int i = 0; i < newArr1.Length; i++)
            {
                newArr1[i] = array[i];
            }
            
            for (int i = 0; i < newArr2.Length; i++)
            {
                newArr2[i] = array[array.Length/2 + i]; //!!!!!!!!!!!!!!!!!
            }
            
            BubbleSort1(newArr1);

            newArr2 = InsertionSort(newArr2);          
            Array.Reverse(newArr2);
           
            for (int i = 0; i < newArr1.Length; i++)
            {
                newArray[i] = newArr1[i];
            }

            for (int i = 0; i < newArr2.Length; i++)
            {
                newArray[newArr1.Length + i] = newArr2[i];  //!!!!!!!!!!!!!!!!
            }

            return newArray;
        }
        static int[] BallanceArray2ByMethods(int[] array)
        {
            int[] resultArray = new int[array.Length];

            int[] firstHalf = new int[array.Length/2];
            int[] secondHalf = new int[array.Length - array.Length / 2];

            Array.Copy(array, 0, firstHalf, 0, array.Length / 2);
            Array.Copy(array, array.Length/2 , secondHalf, 0, array.Length - array.Length / 2);

            Console.WriteLine(string.Join(" ",firstHalf));
            Console.WriteLine(string.Join(" ", secondHalf));

            Array.Sort(firstHalf);
            Array.Sort(secondHalf);
            Array.Reverse(secondHalf);

            firstHalf.CopyTo(resultArray, 0);
            secondHalf.CopyTo(resultArray, resultArray.Length / 2 );           

            return resultArray;
        }
        //count sort the collection with only positive elements:
        static void CountSort(int[] array)
        {
            int[] output = new int[array.Length];

            // Find the largest element of the array
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];
            }

            int[] count = new int[max + 1];

            // Store the count of each element
            for (int i = 0; i < array.Length; i++)
            {
                count[array[i]]++;//or count
            }

            // Store the cummulative count of each array
            for (int i = 1; i <= max; i++)
            {
                count[i] += count[i - 1];
            }

            // Find the index of each element of the original array in count array, and
            // place the elements in output array
            for (int i = array.Length - 1; i >= 0; i--)
            {
                output[count[array[i]] - 1] = array[i];
                count[array[i]]--;
            }

            // Copy the sorted elements into original array
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = output[i];
            }
        }
        //count sort -  generalized version (positive and negative numbers)
        static int[] CountingSort(int[] array)
        {
            int[] sortedArray = new int[array.Length];

            // find smallest and largest value
            int minVal = array[0];
            int maxVal = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < minVal) minVal = array[i];
                else if (array[i] > maxVal) maxVal = array[i];
            }

            // init array of frequencies
            int[] counts = new int[maxVal - minVal + 1];

            // init the frequencies
            for (int i = 0; i < array.Length; i++)
            {
                counts[array[i] - minVal]++;
            }

            // recalculate
            counts[0]--;
            for (int i = 1; i < counts.Length; i++)
            {
                counts[i] = counts[i] + counts[i - 1];
            }

            // Sort the array
            for (int i = array.Length - 1; i >= 0; i--)
            {
                sortedArray[counts[array[i] - minVal]--] = array[i];
            }

            return sortedArray;
        }
        //Merge sort:
        static int[] MergeSort(int[] arr)
        {
            //first method - it recursivelly SPLITS the array , then calls the MERGE method, which combines the elements
            if (arr.Length == 1)
            {
                return arr; //bottom of the recursive split of the array
            }
            int middle = arr.Length / 2;
            int[] leftHalf = new int[middle];
            int[] rightHalf = new int[arr.Length - middle];
            for (int i = 0; i < middle; i++)
            {
                leftHalf[i] = arr[i];
            }
            for (int i = middle, j = 0; j < rightHalf.Length; i++, j++)
            {
                rightHalf[j] = arr[i];
            }
            leftHalf = MergeSort(leftHalf);
            rightHalf = MergeSort(rightHalf);

            return Merge(leftHalf, rightHalf);
        }
        static int[] Merge(int[] left, int[] right)
        {
            int[] Merged = new int[left.Length + right.Length];
            int leftIndexIncrease = 0;//the working index of the left array, it increases by 1 when an element from left goes to Merged
            int rightIndexIncrease = 0;//the working index of the right array, it increases by 1 when an element from right goes to Merged
            for (int i = 0; i < Merged.Length; i++)
            {
                if (rightIndexIncrease == right.Length || 
                    (leftIndexIncrease < left.Length && left[leftIndexIncrease] <= right[rightIndexIncrease]) 
                    )
                {
                    Merged[i] = left[leftIndexIncrease];
                    leftIndexIncrease++;
                }
                else if (leftIndexIncrease == left.Length || 
                    (rightIndexIncrease < right.Length && right[rightIndexIncrease] <= left[leftIndexIncrease]) 
                    )
                {
                    Merged[i] = right[rightIndexIncrease];
                    rightIndexIncrease++;
                }
            }
            return Merged;
        }
        //QuickSort:
        static private void QuickSort(int[] array, int start, int end)
        {
            //base for the recursion - the bottom: ->when the array is only with only 1 element
            if (start >= end)
                return;
            //partition -> it's the next index of the last element of the left part of the array - the elements, smaller then the pivot
            int boundary = partition(array, start, end);

            QuickSort(array, start, boundary - 1);
            QuickSort(array, boundary + 1, end);
        }
        static void QuickSort(int[]array)
        {
            QuickSort(array, 0, array.Length - 1);
        }
        static int partition(int[] array, int start, int end)
        {
            int pivot = array[end];
            int boundary = start - 1;
            for (int i = start; i <= end; i++)
                if (array[i] <= pivot)
                {
                    boundary++;
                    Swap(array, i, boundary);
                }
            return boundary;
        }
        static void Swap(int[]array, int index1, int index2)
        {
            int temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }
        static void Main(string[] args)
        {
            Random r = new Random();
            int m, n, k, l; // m = r.Next(4, 15);    k = r.Next(6, 15);    l = r.Next(3, 13);    
            n = r.Next(3, 20);          
           
            int[] A = new int[n];   //  int[]A={-7,4,6,-12,77,11};
            RandomrArrayData(A); 
            Console.WriteLine("Unsorted array A:");
            //DisplayArray(A);
            //QuickSort(A);
            CountSort(A);
            Console.WriteLine("Sorted array A:");
            DisplayArray(A);
            Console.ReadKey();

            int[] B = new int[n];
            RandomrArrayData(B);
            Console.WriteLine("Unsorted array B:");
            DisplayArray(B);
            BubbleSort2(B);
            Console.WriteLine("Sorted array B:");
            DisplayArray(B);

            int[] C = new int[n];
            RandomrArrayData(C);
            Console.WriteLine("Unsorted array C:");
            DisplayArray(C);
            SelectionSort1(C);
            Console.WriteLine("Sorted array C:");
            DisplayArray(C);

            int[] D = new int[n];
            RandomrArrayData(D);
            Console.WriteLine("Unsorted array D:");
            DisplayArray(D);
            SelectionSort2(D);
            Console.WriteLine("Sorted array D:");
            DisplayArray(D);

            int[] AreaArray = { 3, 4, -9, 9, 9, 13, 4, 13, 13, 77 };
            InsertionSort(AreaArray);
            DisplayArray(AreaArray);

            int[] BallancedArray = new int[n];
            RandomrArrayData(BallancedArray);
            DisplayArray(BallancedArray);
            BallancedArray = BallanceArray2ByMethods(BallancedArray);
            DisplayArray(BallancedArray);


            Console.ReadKey();
        }
    }
}
