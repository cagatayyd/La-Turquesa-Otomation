using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace La_Turquesa_Otomation.Entities
{
    public class Customer : BaseEntity
    {
        [Column(TypeName = "VarChar")]
        [StringLength(30)]
        public string Name { get; set; }
        [Column(TypeName = "VarChar")]
        [StringLength(30)]
        public string LastName { get; set; }
        [Column(TypeName = "VarChar")]
        [StringLength(15)]
        public string City { get; set; }
        [Column(TypeName = "VarChar")]
        [StringLength(50)]
        public string Mail { get; set; }
        public ICollection<Sale> Sales { get; set; }

    }
}
