using System;

namespace AgentProject.Models
{
    [Serializable]
    public class Agent
    {
        private static int autoId = 100;
        public int AgentId { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string Gender { get; set; }
        public double PremiumAmount { get; set; }

        public Agent(string firstName, string lastName, string city, string gender, double premium)
        {
            AgentId = ++autoId;
            FirstName = firstName;
            LastName = lastName;
            City = city;
            Gender = gender;
            PremiumAmount = premium;
        }

        public override string ToString()
        {
            return $"AgentId: {AgentId}, Name: {FirstName} {LastName}, City: {City}, Gender: {Gender}, Premium: {PremiumAmount}";
        }
    }
}