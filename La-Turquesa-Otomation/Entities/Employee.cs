using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace La_Turquesa_Otomation.Entities
{
    public class Employee : BaseEntity
    {
        [Column(TypeName = "VarChar")]
        [StringLength(30)]
        public string Name { get; set; }
        [Column(TypeName = "VarChar")]
        [StringLength(30)]
        public string LastName { get; set; }
        public string Picture { get; set; }
        public ICollection<Sale> Sales { get; set; }
        public Department Department { get; set; }

        
    }
}
