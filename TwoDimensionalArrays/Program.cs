using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDimensionalArrays
{
    class Program
    {    
        static void GenerateTwoDimArray(int[,] array)
        {
            Random r = new Random();
            for (int i = 0; i < array.GetLength(0); i++)   //GetLength(0) - rows
            {
                for (int j = 0; j < array.GetLength(1); j++)   //GetLength(1) - columns
                {
                    array[i, j] = r.Next(-100, 100);
                }
            }
        }
        static void Main(string[] args)
        {
            int[,] TwoDimArr1 = new int[4, 4];

            






        }
    }
}
