using System.Collections.Generic;
using System.Linq;
using AgentProject.Models;

namespace AgentProject.Dao
{
    public class AgentDaoImpl : IAgentDao
    {
        private static List<Agent> agentList = new List<Agent>();

        public void AddAgent(Agent agent) => agentList.Add(agent);
        public List<Agent> ShowAgents() => agentList;
        public Agent SearchAgent(int agentId) => agentList.FirstOrDefault(a => a.AgentId == agentId);
        public bool DeleteAgent(int agentId)
        {
            var agent = SearchAgent(agentId);
            if (agent != null)
            {
                agentList.Remove(agent);
                return true;
            }
            return false;
        }

        public bool UpdateAgent(Agent updatedAgent)
        {
            var agent = SearchAgent(updatedAgent.AgentId);
            if (agent != null)
            {
                agent.FirstName = updatedAgent.FirstName;
                agent.LastName = updatedAgent.LastName;
                agent.City = updatedAgent.City;
                agent.Gender = updatedAgent.Gender;
                agent.PremiumAmount = updatedAgent.PremiumAmount;
                return true;
            }
            return false;
        }

        public List<Agent> GetAllAgents() => agentList;
    }
}
