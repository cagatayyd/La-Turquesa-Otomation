namespace La_Turquesa_Otomation.Entities
{
    public class Sale : BaseEntity
    {
        public DateTime Date { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice { get; set; }
        public Customer Customer { get; set; }
        public Product Product { get; set; }
        public Employee Employee { get; set; }

    }
}
