using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication
{
    internal class MileStone3
    {
        public bool IsPalindrom(string str)
        {
            char[] chars = str.ToCharArray();
            string rev = "";
            for (int  i=chars.Length-1; i >= 0; i--)
            {
                rev += chars[i];
            }
            if (rev.Equals(str))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Show(string data)
        {
            string[] words = data.Split(' ');
            foreach(string s in words)
            {
                if(IsPalindrom(s) == true)
                {
                    Console.WriteLine(s);

                }
            }
        }
        static void Main()
        {
            string data;
            Console.WriteLine("Enter a Sentence with palindrome words  ");
            data = Console.ReadLine();
            MileStone3 obj = new MileStone3();
            obj.Show(data);
        }
    }
}
