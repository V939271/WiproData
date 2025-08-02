using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttrExampleNew
{
    [Information(InformationString = "Class")]
    public class Student
    {
        private int sno;
        private string name;

        [Information(InformationString = "Constructor")]
        public Student(int sno, string name)
        {
            this.sno = sno;
            this.name = name;
        }

        [Information(InformationString = "Method")]
        public void Display()
        {
            Console.WriteLine("Sno  "+sno+" Name  "+name);
        }
    }
}
