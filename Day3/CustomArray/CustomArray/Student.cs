using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomArray
{
    internal class Student
    {
        int sid;
        string name;
        string city;

        public Student() { }

        public Student(int sid, string name, string city) 
        {
            this.sid = sid;
            this.name = name;
            this.city = city;
        }

        public override string ToString()
        {
            return "Sid " + sid + " Name " +name + " City " + city;
        }
    }
}
