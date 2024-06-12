using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace La_Turquesa_Otomation.Entities
{
    public class Invoice : BaseEntity
    {
        [Column(TypeName = "Char")]
        [StringLength(30)]
        public string SerialNumber { get; set; }
        [Column(TypeName = "VarChar")]
        [StringLength(30)]
        public string OrderNumber { get; set; }
        public DateTime Date { get; set; }
        [Column(TypeName = "VarChar")]
        [StringLength(30)]
        public string TaxOffice { get; set; }
        [Column(TypeName = "VarChar")]
        [StringLength(30)]
        public string Receiver { get; set; }
        [Column(TypeName = "VarChar")]
        [StringLength(30)]
        public string Deliverer { get; set; }
        public ICollection<InvoiceItem> InvoiceItems { get; set; }
    }
}
