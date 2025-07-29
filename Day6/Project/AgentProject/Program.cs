using System;
using AgentProject.Dao;
using AgentProject.Models;
using AgentProject.Util;

namespace AgentProject
{
    class Program
    {
        static IAgentDao dao = new AgentDaoImpl();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Add Agent");
                Console.WriteLine("2. Show Agents");
                Console.WriteLine("3. Search Agent");
                Console.WriteLine("4. Update Agent");
                Console.WriteLine("5. Delete Agent");
                Console.WriteLine("6. Write to File");
                Console.WriteLine("7. Read from File");
                Console.WriteLine("8. Exit");
                Console.Write("Enter Choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: AddAgent(); break;
                    case 2: ShowAgents(); break;
                    case 3: SearchAgent(); break;
                    case 4: UpdateAgent(); break;
                    case 5: DeleteAgent(); break;
                    case 6: AgentFileUtil.WriteToFile(dao.ShowAgents()); Console.WriteLine("Data written to file."); break;
                    case 7: ReadFromFile(); break;
                    case 8: return;
                }
            }
        }

        static void AddAgent()
        {
            Console.Write("Enter First Name: ");
            string fname = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            string lname = Console.ReadLine();
            Console.Write("Enter City: ");
            string city = Console.ReadLine();
            Console.Write("Enter Gender (MALE/FEMALE): ");
            string gender = Console.ReadLine();
            Console.Write("Enter Premium Amount: ");
            double premium = double.Parse(Console.ReadLine());

            dao.AddAgent(new Agent(fname, lname, city, gender, premium));
            Console.WriteLine("Agent Added.");
        }

        static void ShowAgents()
        {
            foreach (var agent in dao.ShowAgents())
                Console.WriteLine(agent);
        }

        static void SearchAgent()
        {
            Console.Write("Enter AgentId to search: ");
            int id = int.Parse(Console.ReadLine());
            var agent = dao.SearchAgent(id);
            Console.WriteLine(agent != null ? agent.ToString() : "Agent not found.");
        }

        static void UpdateAgent()
        {
            Console.Write("Enter AgentId to update: ");
            int id = int.Parse(Console.ReadLine());
            var old = dao.SearchAgent(id);
            if (old == null) { Console.WriteLine("Agent not found."); return; }

            Console.Write("Enter New First Name: ");
            string fname = Console.ReadLine();
            Console.Write("Enter New Last Name: ");
            string lname = Console.ReadLine();
            Console.Write("Enter New City: ");
            string city = Console.ReadLine();
            Console.Write("Enter New Gender: ");
            string gender = Console.ReadLine();
            Console.Write("Enter New Premium Amount: ");
            double premium = double.Parse(Console.ReadLine());

            dao.UpdateAgent(new Agent(fname, lname, city, gender, premium) { });
            Console.WriteLine("Agent Updated.");
        }

        static void DeleteAgent()
        {
            Console.Write("Enter AgentId to delete: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine(dao.DeleteAgent(id) ? "Deleted" : "Agent not found.");
        }

        static void ReadFromFile()
        {
            var agents = AgentFileUtil.ReadFromFile();
            foreach (var agent in agents)
                Console.WriteLine(agent);
        }
    }
}
