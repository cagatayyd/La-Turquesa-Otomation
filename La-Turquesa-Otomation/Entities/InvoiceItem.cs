using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace La_Turquesa_Otomation.Entities
{
    public class InvoiceItem : BaseEntity
    {
        [Column(TypeName = "VarChar")]
        [StringLength(100)]
        public string Description { get; set; }
        public int Quantity { get; set; }
        public string UnitPrice { get; set; }
        public string TotalPrice { get; set; }
        public Invoice Invoice { get; set; }
    }
}
