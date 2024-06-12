using La_Turquesa_Otomation.Entities;
using Microsoft.EntityFrameworkCore;

namespace La_Turquesa_Otomation.Contexts
{
    public class La_TurquesaDbContext : DbContext
    {
        public La_TurquesaDbContext(DbContextOptions<La_TurquesaDbContext> options) : base(options) { }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceItem> InvoiceItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Sale> Sales { get; set; }
    }
}
