using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OcpWith
{
    internal class Program
    {
        public static void Show(ITraining iTraining)
        {
            iTraining.Info();
            iTraining.Timing();
        }
        static void Main(string[] args)
        {
            DotnetTraining dotnetTraining = new DotnetTraining();
            Show(dotnetTraining);
            JavaTraining javaTraining = new JavaTraining();
            Show(javaTraining);
            DataScienceTraining data = new DataScienceTraining();
            Show(data);
            PythonTraining pythonTraining = new PythonTraining();
            Show(pythonTraining);
        }
    }
}
