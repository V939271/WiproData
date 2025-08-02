using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LspWIth
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Details[] arr = new Details[]
            {
                new Ganesh(),
                new Kusuma(),
                new Mounika()
            };

            foreach (var v in arr)
            {
                v.ShowInfo();
            }
        }
    }
}
