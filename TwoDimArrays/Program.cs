using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDimArrays
{
    class Program
    {
        static void AddRandomValues(int[,]array)
        {

            Random r = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = r.Next(-100, 100);
                }
            }
        }
        static void DisplayTwoDimArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write("Arr[{0},{1}]={2}", i, j, array[i, j]);
                    Console.Write("\t");
                }
                Console.WriteLine();
            }
        }
        static int MatrixMainDiagonaleSum(int[,] array)
        {
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        sum += array[i, j];
                    }
                }
            }
            return sum;
        }
        static double MatrixMainDiagonaleAverage(int[,] array)
        {
            int sum = MatrixMainDiagonaleSum(array);
            int count = array.GetLength(0);
            
            return ((double)sum) / count;
        }
        static int MatrixSumUnderMainDiagonale(int[,] array)
        {
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i < j)
                    {
                        sum += array[i, j];
                    }
                }
            }
            return sum;
        }
        static int MatrixSumUnderSecondaryDiagonale(int[,] array)
        {
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i+j >= array.GetLength(0) )
                    {
                        sum += array[i, j];
                    }
                }
            }
            return sum;
        }
        //средно аритметично по редове, изведено в края на всеки ред:
        static void RowsAverage(int[,] array)
        {
            int col = array.GetLength(1);

            for (int i = 0; i < array.GetLength(0); i++)
            {
                double s = 0;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    s += array[i, j];
                    Console.Write($"arr[{i},{j}]={array[i, j]}\t");
                }
                Console.WriteLine("\tRow average value: {0}", Math.Round(s / col,2));
            }
        }
        static void ColumnsSum(int[,] array)
        {
            //създава се нов едномерен масив със сумите, който впоследствие се извежда под двумерния - размерност брой колони:
            int[] sumColumns = new int[array.GetLength(1)];

            //обработка на двумерния масив:

            //външен цикъл по колони: i < arr.GetLength (1):
            for (int i = 0; i < array.GetLength(1); i++)
            {
                int sum = 0;    //това е променлива, която ще трупа сумата на всяка колона, нулира се в началото и

                //вътрешен цикъл по редове: j < arr.GetLength (0):
                for (int j = 0; j < array.GetLength(0); j++)
                {
                    sum += array[j, i];  //при индексиране на елемент винаги първо е редът, в случая j, след него колоната - тук е i !!!
                }
                sumColumns[i] = sum;  // записва се резултатът като съответен елемент в едномерния масив
            }

            //извеждане на двумерния масив:
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write("Arr[{0},{1}]={2}", i, j, array[i, j]);
                    Console.Write("\t");
                }
                Console.WriteLine();
            }
            //извеждане под него на едномерния масив със сумите:
            for (int i = 0; i < array.GetLength(1); i++)
            {
                Console.Write($"Col sum={sumColumns[i]}\t");
            }
        }
        //минимална стойност по колони, изведена под всяка колона:
        //създава се нов едномерен масив с минималните стойност, който впоследствие се извежда под двумерния:
        static void ColumnsMin(int[,] array)
        {
            int[] minColumns = new int[array.GetLength(1)];
            //външен цикъл по колони: i < arr.GetLength (1):
            for (int i = 0; i < array.GetLength(1); i++)
            {
                int min = array[0, i];
                //вътрешен цикъл по редове: j < arr.GetLength (0):
                for (int j = 1; j < array.GetLength(0); j++)
                {
                    if (array[j, i] < min)
                    {
                        min = array[j, i];
                    }
                }
                minColumns[i] = min;
            }
            //извеждане на двумерния масив с предварително разработения метод:
            DisplayTwoDimArray(array);
            //извеждане на едномерния масив с минимумите:
            for (int i = 0; i < array.GetLength(1); i++)
            {
                Console.Write($"Col min={minColumns[i]}\t");
            }
        }
        /*
         *  Да се състави програма на C#, при която предварително са въведени естествени числа от интервала [0..100] в двумерен масив 4*4 елемента.
            Програмата да извежда резултат от проверката какво е съотношението на най-голямата сума по редове спрямо най-голямата сума по колони.
            Пример:
            1, 2,  3,  4
            5, 6,  7,  8
            9, 10, 11, 12
            13,14, 15, 16
            Изход:
            най-голяма сума по редове 58
            най-голяма сума по колони 40
            Максималната сума по редове е > от максималната сума по колони
         */
        static void MaxSumsRowsColumns(int[,] array)
        {
            int MaxRowsSum = 0;
            int MaxColumnSum = 0;
            for (int row = 0; row < array.GetLength(0); row++)
            {
                int TempSum = 0;
                for (int col = 0; col < array.GetLength(1); col++)
                {
                    TempSum += array[row, col];
                }
                if (TempSum > MaxRowsSum)
                    MaxRowsSum = TempSum;
            }
            for (int col = 0; col < array.GetLength(1); col++)
            {
                int TempSum = 0;
                for (int row = 0; row < array.GetLength(0); row++)
                {
                    TempSum += array[row, col];
                }
                if (TempSum > MaxColumnSum)
                    MaxColumnSum = TempSum;
            }
            Console.WriteLine("The biggest row elements sum is:{0}",MaxRowsSum);
            Console.WriteLine("The biggest column elements sum is:{0}", MaxColumnSum);
            if (MaxRowsSum>MaxColumnSum)
                Console.WriteLine("The biggest row elements sum is bigger then the biggest column elements sum");
            else if(MaxColumnSum>MaxRowsSum)
                Console.WriteLine("The biggest columns elements sum is bigger then the biggest row elements sum");
            else
                Console.WriteLine("The biggest row elements sum is equal to the biggest column elements sum");
        }

        static void Main(string[] args)
        {
            Random r = new Random();

            int m = r.Next(3, 7);
            int n = r.Next(3, 7);

            //int[,] IntMatrix = new int[m, m];
            //AddRandomValues(IntMatrix);
            int[,] IntMatrix = {
                                    { 1,2,3,4 },
                                    { 5,6,7,8},
                                    { 9,10,11,12},
                                    { 13,14,15,16}
                                };

            ColumnsSum(IntMatrix);


            //DisplayTwoDimArray(IntMatrix);
            //MaxSumsRowsColumns(IntMatrix);
            Console.ReadKey();
            //сума от елементите по главния диагонал на матрица:
            Console.WriteLine("The main diagonale sum is: {0}", MatrixMainDiagonaleSum(IntMatrix));
            //средно аритметичната от стойностите на главния диагонал на матрица:
            Console.WriteLine("The main diagonale average is: {0}",Math.Round(MatrixMainDiagonaleAverage(IntMatrix),2));
            Console.WriteLine();

            Console.WriteLine("The sum under secondary diagonal is: {0}", MatrixSumUnderSecondaryDiagonale(IntMatrix));
            Console.WriteLine();


            int[,] TwoDimArray = new int[m, n];
            AddRandomValues(TwoDimArray);
            //средно аритметично от елементите на всеки ред, изведено в края на реда:
            Console.WriteLine("Rows average values are:");
            RowsAverage(TwoDimArray);
            Console.WriteLine();
            MaxSumsRowsColumns(TwoDimArray);

            //Минимум на колона, изведен под нея:
            ColumnsMin(TwoDimArray);

            //сума от елементите ПОД ГЛАВНИЯ диагонал на матрица

            //сума от елементите ПОД ВТОРОСТЕПЕННИЯ диагонал на матрица:
            //а00   а01     а02     а03         03, 12, 21, 30
            //а10   а11     а12     а13
            //а20   а21     а22     а23
            //а30   а31     а32     а33
            Console.ReadKey();

        }
    }
}
