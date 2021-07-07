using System;

namespace Arrays
{
    class Program
    {
        static void Main()
        {
            int n = 5;
            double[] A = new double[n];

            int row = 3;
            int col = 4;
            double[,] B = new double[row, col];
            Random rand = new Random();


            Console.WriteLine("Введите значения элементов массива A через запятую: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"A[{i + 1}] = "); A[i] = Convert.ToDouble(Console.ReadLine());
            }

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    B[i, j] = rand.NextDouble() % 100;
                }
            }

            Console.WriteLine("Массив A");
            foreach (double item in A)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine("\n");

            Console.WriteLine("Массив B");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write($"{B[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");

        }
    }
}