using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace FilesExample
{
    internal class BinaryWriterExample3
    {
        static void Main()
        {
            FileStream fs = new FileStream(@"E:\Wipro\Day5\FilesExample\data.txt", FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(12);
            bw.Write("Wipro");
            bw.Write(23323.242);
            bw.Write(true);
            bw.Close();
            fs.Close();
            Console.WriteLine("Primitive Data stored in files..");


        }
    }
}
