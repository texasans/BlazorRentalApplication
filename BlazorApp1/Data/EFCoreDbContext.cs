using BlazorApp1.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Data
{
    public class EFCoreDbContext:DbContext
    {
        // connection string
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            //var serverVersion = new MySqlServerVersion(new Version(8, 0, 13));
            //var connectionString = "server=localhost;user=root;password=root;database=myNewDatabase";

            //optionsBuilder.UseMySql(connectionString, serverVersion);

            optionsBuilder.UseSqlServer(@"Server=HASRAPIDO\SQLEXPRESS;Database=BlazorApp-Test; Trusted_Connection=True;");
            // optionsBuilder.UseMySql(@"Server=localhost;Database=BlazorApp-Test;User=root;Password=root;", );
        }

        //db sets
        public DbSet<Category> Category { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }
        public DbSet<Delivery> Delivery { get; set; }
    }
}
