using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace FilesExample
{
    internal class WriteEmployFile
    {
        static void Main()
        {
            Employ emp = new Employ();
            emp.Empno = 1;
            emp.Name = "Venkat";
            emp.Basic = 12423.22;

            FileStream fs = new FileStream(@"E:\Wipro\Day5\FilesExample\Employ.txt", FileMode.Create, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, emp);
            fs.Close();
            Console.WriteLine("Employee Data Stored in File...");

            
        }
    }
}
