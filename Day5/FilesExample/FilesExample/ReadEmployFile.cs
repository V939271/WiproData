using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace FilesExample
{
    internal class ReadEmployFile
    {
        static void Main()
        {
            FileStream fs = new FileStream(@"E:\Wipro\Day5\FilesExample\Employ.txt", FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            //Employ emp = (Employ)bf.Deserialize(fs);
            object obj = bf.Deserialize(fs);
            Employ emp = (Employ)obj; // unboxing here obj data into employ type
            Console.WriteLine(emp);
        }
    }
}
