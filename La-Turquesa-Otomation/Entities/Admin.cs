using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace La_Turquesa_Otomation.Entities
{
    public class Admin : BaseEntity
    {
        [Column(TypeName = "VarChar")]
        [StringLength(10)]
        public string Username { get; set; }
        [Column(TypeName = "VarChar")]
        [StringLength(30)]
        public string Password { get; set; }
        [Column(TypeName = "Char")]
        [StringLength(10)]
        public string Authority { get; set; }
    }
}
