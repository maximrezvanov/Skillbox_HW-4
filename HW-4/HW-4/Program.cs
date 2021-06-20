using System;

namespace HW4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            
            double[] mouthts = new double[12];
            double[] income = new double[mouthts.Length];
            double[] consumption = new double[mouthts.Length];
            double[] profit = new double[mouthts.Length];

            double[] sortedProfit = new double[mouthts.Length];
            double[] sortedMounts = new double[mouthts.Length];
            int mounthCounter = 0;
            Random rand = new Random();

            for (int i = 0; i < mouthts.Length; i++)
            {
                mouthts[i] = i + 1;
            }

            InitialiseArr(income);
            InitialiseArr(consumption);

           

            double[][] table = {mouthts, income, consumption, profit};
            for (int i = 0; i < profit.Length; i++)
            {
                profit[i] = income[i] - consumption[i];
            }


            for (int i = 0; i < table.GetLength(0); i++)
            {
                Console.WriteLine();

                for (int j = 0; j < table[i].Length; j++)
                {
                
                  Console.Write("{0:0.00 \t}", table[i][j]);

                }
                if (i == 0 ) Console.Write("Mounth num.");
                if (i == 1 ) Console.Write("Income");
                if (i == 2) Console.Write("Consumption");
                if (i == 3 ) Console.Write("Profit");

                sortedProfit = profit;
                sortedMounts = mouthts;
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Three mounth with minimal profit");

            Array.Sort(sortedProfit, sortedMounts);

            for (int i = 0; i < 3; i++)
            {
               if(sortedProfit[i] == sortedProfit[i + 1])
               {
                    ++mounthCounter;
               }
                Console.WriteLine(Math.Round(sortedProfit[i], 2) + " min profit " + " - " + sortedMounts[i] + " mounth");
            }

            void InitialiseArr(double[] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = rand.NextDouble();
                }
            }

            Console.WriteLine();

            /* Pascal Triangle */

            Console.Write("Enter the number of rows Pascal Triangle: ");
            string input = Console.ReadLine();
            Console.WriteLine();
            int n = Convert.ToInt32(input);

            for (int y = 0; y < n; y++)
            {
                int c = 1;
                for (int q = 0; q < n - y; q++)
                {
                    Console.Write("   ");
                }

                for (int x = 0; x <= y; x++)
                {
                    Console.Write("   {0:D} ", c);
                    c = c * (y - x) / (x + 1);
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.WriteLine();


            /* Task 4.3 */

            Console.WriteLine("original matrix");
            var matrix1 = new double[3, 3];

            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    matrix1[i, j] = rand.Next(1, 5);
                    Console.Write($"{matrix1[i, j]}");

                }
                Console.WriteLine();
            }

            Console.WriteLine("matrix multiplication by 2");

            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    matrix1[i, j] *= 2;

                    Console.Write($"{matrix1[i,j]}");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine("matrix 2");

            var matrix2 = new double[3, 3];
            for (int i = 0; i < matrix2.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    matrix2[i, j] = rand.Next(1, 5);
                    Console.Write($"{matrix2[i, j]}");

                }
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine("matrix addition");
            var addResult = new double[3, 3];
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    addResult[i, j] = matrix1[i, j] + matrix2[i, j];
                    Console.Write($"{addResult[i, j]} ");

                }
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine("subtraction of matrixes");
            var substrResult = new double[3, 3];
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    substrResult[i, j] = matrix1[i, j] - matrix2[i, j];
                    Console.Write($"{substrResult[i, j]} ");

                }
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine("multiplication by matrix");
            var multiResult = new double[3, 3];
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    multiResult[i, j] = matrix1[i, j] * matrix2[i, j];
                    Console.Write($"{multiResult[i, j]} ");

                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
