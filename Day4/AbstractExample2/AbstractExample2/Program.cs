using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExample2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal[] arr = new Animal[]
            {
                new Lion(),
                new Cow(),
                new Crocodile(),
            };

            foreach(Animal a in arr)
            {
                a.Name();
                a.Type();

            }
        }
    }
}
