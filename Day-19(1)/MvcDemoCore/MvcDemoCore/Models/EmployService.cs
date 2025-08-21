
namespace MvcDemoCore.Models
{
    public class EmployService
    {
        private static List<Employ> employList = null;

        static EmployService()
        {
            employList = new List<Employ>();
            employList.Add(new Employ
            {
                Empno = 101,
                Name = "Anil Patil",
                Basic = 488234
            });
            employList.Add(new Employ
            {
                Empno = 102,
                Name = "Rajesh",
                Basic = 900321
            });
            employList.Add(new Employ
            {
                Empno = 103,
                Name = "Sreeja V",
                Basic = 488234
            });
            employList.Add(new Employ
            {
                Empno = 104,
                Name = "Yashwanth V",
                Basic = 488234
            });
            employList.Add(new Employ
            {
                Empno = 105,
                Name = "Vivek Vardhan",
                Basic = 488234
            });
            employList.Add(new Employ
            {
                Empno = 106,
                Name = "Prachi",
                Basic = 902332
            });
            employList.Add(new Employ
            {
                Empno = 107,
                Name = "Srivalli",
                Basic = 900322
            });
            employList.Add(new Employ
            {
                Empno = 108,
                Name = "Mahesh",
                Basic = 900211
            });
        }

        public bool AddEmploy(Employ newEmploy)
        {
            bool EmployAdded = false;
            int oldCount = employList.Count;
            employList.Add(newEmploy);
            int newCount = employList.Count;
            if (newCount > oldCount)
                EmployAdded = true;
            return EmployAdded;
        }

        public List<Employ> GetAllEmploys()
        {
            return employList;
        }


        public Employ ShowEmploy(int empno)
        {
            return employList.First(g => g.Empno == empno);
        }

        public Employ UpdateEmploy(Employ updateEmploy)
        {
            Employ employ = employList.First(g => g.Empno == updateEmploy.Empno);
            employ.Name = updateEmploy.Name;
            employ.Basic = updateEmploy.Basic;
            return employ;
        }
        public bool DeleteEmploy(int id)
        {
            Employ gs = employList.First(g => g.Empno == id);
            return employList.Remove(gs);
        }

    }
}
