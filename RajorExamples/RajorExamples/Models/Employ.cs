using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RajorExamples.Models
{
    public class Employ
    {
        [Key]
        [Column("Empno")]
        [Display(Name = "Employ Number")]
        public int Empno { get; set; }

        [Column("Name")]
        [Display(Name = "Employ Name")]
        public string? Name { get; set; }
        [Column("Gender")]
        [Display(Name = "Gender")]
        public string? Gender { get; set; }

        [Column("Dept")]
        [Display(Name = "Department")]
        public string? Dept { get; set; }

        [Column("Desig")]
        [Display(Name = "Designation")]
        public string? Desig { get; set; }

        [Column("Basic")]
        [Display(Name = "Salary")]
        public decimal Basic { get; set; }
    }
}
