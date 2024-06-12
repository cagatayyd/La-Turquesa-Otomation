using System.ComponentModel.DataAnnotations;

namespace La_Turquesa_Otomation.Entities
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
