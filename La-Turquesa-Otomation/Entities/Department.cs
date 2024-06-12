using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace La_Turquesa_Otomation.Entities
{
    public class Department : BaseEntity
    {
        [Column(TypeName = "VarChar")]
        [StringLength(30)]
        public string Name { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}
