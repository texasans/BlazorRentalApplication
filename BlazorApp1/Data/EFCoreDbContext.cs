using BlazorApp1.Models;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

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

            //optionsBuilder.UseSqlServer(@"Server=tcp:myfreesql2025.database.windows.net,1433;Database=myFreeDB; Trusted_Connection=True;User=superadmin;Password=Turbo@20052019");
            // optionsBuilder.UseMySql(@"Server=localhost;Database=BlazorApp-Test;User=root;Password=root;", );
            optionsBuilder.UseSqlServer(@"Server =tcp:myfreesql2025.database.windows.net,1433; Initial Catalog = myFreeDB; Persist Security Info = False; User ID = superadmin; Password =Turbo@20052019; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;");



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
