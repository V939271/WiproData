using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication
{
    internal class Perfect
    {
        public void Show(int n)
        {
            int sum = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }
            if (sum == n)
            {
                Console.WriteLine("Perfect Number...");
            }
            else
            {
                Console.WriteLine("Not Perfect Number...");
            }
        }
        static void Main()
        {
            int n;
            Console.WriteLine("Enter N value  ");
            n = Convert.ToInt32(Console.ReadLine());
            Perfect perfect = new Perfect();
            perfect.Show(n);
        }
    }
}
