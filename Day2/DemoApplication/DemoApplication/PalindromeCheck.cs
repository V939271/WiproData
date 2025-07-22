using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication
{
    internal class PalindromeCheck
    {
        public bool show(string str)
        {
            char[] chars = str.ToCharArray();
            string rev = "";
            for (int i = chars.Length - 1; i >= 0; i--) 
            {
                rev += chars[i];
            }
            Console.WriteLine(rev);
            if (rev.Equals(str))
            {
                return true;
            }
            else { return false; }
        }
        static void Main()
        {
            string str = "liril";
            PalindromeCheck obj = new PalindromeCheck();
            Console.WriteLine(obj.show(str));
        }
     
    }
}
