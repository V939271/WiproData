using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp
{
    internal class JaggedArrayEx4
    {
        static void Main()
        {
            int n, m;
            Console.WriteLine("Enter No.of Jagged Arrays and Size of elements ");
            n = Convert.ToInt32(Console.ReadLine());
            m = Convert.ToInt32(Console.ReadLine());

            int[][] jaggedArray = new int[n][];  // A jagged array of n rows

            int[,] x = new int[n, m];   // A 2D array (matrix) of size n x m

            Console.WriteLine("Enter The element for Multi-Dimenstional Array");
            for (int i = 0; i < x.GetLength(0); i++)         // Loop rows
            {
                for (int j = 0; j < x.GetLength(1); j++)     // Loop columns
                {
                    x[i, j] = Convert.ToInt32(Console.ReadLine()); // Input value
                }
            }

            Console.WriteLine("Display Elements in Matrix Format");
            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    Console.Write(x[i, j] + "  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Adding Data to Jagged Array");
            for (int i = 0; i < n; i++)               // Loop over rows
            {
                int[] p = new int[m];               // Create new 1D array for row i
                for (int j = 0; j < m; j++)          // Loop over columns
                {
                    p[j] = x[i, j];                 // Copy each element from 2D to 1D
                }
                jaggedArray[i] = p;                 // Assign row array to jaggedArray[i]
            }
            Console.WriteLine("Print Jagged Array Data ");


            Console.WriteLine(jaggedArray.Length);  // Output: 2

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + "    ");
                }
                Console.WriteLine();
            }

        }
    }
}
