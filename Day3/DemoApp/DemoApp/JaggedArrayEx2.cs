using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp
{
    internal class JaggedArrayEx2
    {
        static void Main()
        {
            int a, b;
            Console.WriteLine("Enter No.of Jagged Arrays and Size of elements..");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            int[][] jaggedArray = new int[a][];  // creates outer array of length a (2)
            int[] x = new int[b];  // creates array with 3 elements
            int[] y = new int[b];  // creates another array with 3 elements

            Console.WriteLine("Enter Elements for Array X ");
            for(int i = 0; i < b; i++)
            {
                x[i] = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine("Enter the elements for Array Y..");
            for (int i = 0; i < b; i++)
            {
                y[i] = Convert.ToInt32(Console.ReadLine());
            }

            jaggedArray[0] = x;
            jaggedArray[1] = y;

            for(int i = 0; i < jaggedArray.Length; i++)
            {
                for(int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j]+ " ");
                }
                Console.WriteLine();
            }


        }
    }
}
