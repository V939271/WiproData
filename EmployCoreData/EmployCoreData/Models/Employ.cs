//namespace EmployCoreData.Models
//{
//    public class Employ
//    {
//    }
//}

using System.ComponentModel.DataAnnotations;

namespace EmployCoreData.Models
{
    public class Employ
    {

        [Key]
        public int Empno { get; set; }
        public string? Name { get; set; }
        public string? Gender { get; set; }
        public string? Dept { get; set; }

        public string? Desig { get; set; }

        public decimal Basic { get; set; }
    }
}