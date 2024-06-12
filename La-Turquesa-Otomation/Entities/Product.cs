using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace La_Turquesa_Otomation.Entities
{
    public class Product : BaseEntity
    {
        [Column(TypeName ="VarChar")]
        [StringLength(30)]
        public string Name { get; set; }
        [Column(TypeName = "VarChar")]
        [StringLength(30)]
        public string Brand { get; set; }
        public short Stock { get; set; }
        public decimal PurchasePrice  { get; set; }
        public string SellPrice { get; set; }
        public bool Durum  { get; set; }
        public string Picture { get; set; }
        public Category Category { get; set; }
        public ICollection<Sale> Sales { get; set; }

    }
}
