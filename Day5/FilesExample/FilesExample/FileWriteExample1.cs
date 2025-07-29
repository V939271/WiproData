using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesExample
{
    internal class FileWriteExample1
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"E:\Wipro\Day5\FilesExample\Demo1.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("This program belongs to wipro Cohert4....");
            sw.WriteLine("Thank you ALL.....");
            sw.WriteLine("Trainer is Prasanna Sir...");
            sw.Flush(); // Forces all buffered data to be written to the file immediately.
                        // Flush() ensures the data in the buffer is physically written to the file or stream right now, even if the buffer isn’t full.
            sw.Close();
            sw.Close();
            Console.WriteLine("File Created SucessFully..");

        }
    }
}
