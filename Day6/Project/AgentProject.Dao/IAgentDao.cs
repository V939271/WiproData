using System.Collections.Generic;
using AgentProject.Models;

namespace AgentProject.Dao
{
    public interface IAgentDao
    {
        void AddAgent(Agent agent);
        List<Agent> ShowAgents();
        Agent SearchAgent(int agentId);
        bool DeleteAgent(int agentId);
        bool UpdateAgent(Agent updatedAgent);
    }
}