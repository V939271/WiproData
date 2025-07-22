using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication
{
    internal class MileStoneEx1
    {
        public void show(string data)
        {
            data = data.ToLower();
            int count = 0;
            char[] chars = data.ToCharArray();
            foreach(char c in chars)
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u') ;
                count += 1;
            }
            Console.WriteLine("Tot No.of Vowel count "+count);
        }
        static void Main()
        {
            string data;
            Console.WriteLine("Enter a string..");
            data = Console.ReadLine();
            MileStoneEx1 obj = new MileStoneEx1();
            obj.show(data);
        }
    }
}
