using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp
{
    internal class Conover
    {
        int a, b; // Class-level field(global inside class)
        //Class-level field
        public Conover()
        {
            a = 1; b = 2;
        }

        public Conover(int a, int b)
        {

            this.a = a; // Assigns the parameter a to the instance variable a
            this.b = b;  // the class-level field id.
                         //this keyword refers to the current object.
                         // a,b are para values =101,venkat
                         // sets the object's `id` to 101
                         // this is used to:
                         // Refer to current object's members (fields, methods).
        }

        public void Show()
        {
            Console.WriteLine("A value is "+a+ " B Value is "+b);
        }

        static void Main(string[] args) 
        {
            Conover obj = new Conover();
            obj.Show();
            Conover obj2 = new Conover(66, 12);
            obj2.Show();

        }
    }
}
