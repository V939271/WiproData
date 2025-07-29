using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using AgentProject.Models;

namespace AgentProject.Util
{
    public static class AgentFileUtil
    {
        private static string filePath = @"E:\\Wipro\\Day6\\Project\\agents.dat";

        public static void WriteToFile(List<Agent> agents)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(filePath));
            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, agents);
            }
        }

        public static List<Agent> ReadFromFile()
        {
            if (!File.Exists(filePath))
                return new List<Agent>();

            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                return (List<Agent>)formatter.Deserialize(fs);
            }
        }
    }
}