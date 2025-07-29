using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesExample
{
    internal class FileReadExample1cs
    {
        static void Main()
        {

            //FileStream is used to connect to a file on disk.
            FileStream fs = new FileStream(@"E:\Wipro\Day5\ExceptionHandling\ExceptionHandling\FilterException.cs", FileMode.Open,FileAccess.Read);

            //StreamReader helps you read the contents of a text file more easily (line by line, characters, etc.).

            StreamReader sr = new StreamReader(fs);

            //Move to Beginning of File 
            // OR Buy Default it will take but safety perpose we give like this
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
            sr.Close();
            fs.Close();
            
        }
    }
}
