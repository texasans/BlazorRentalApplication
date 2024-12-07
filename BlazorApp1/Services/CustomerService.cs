using BlazorApp1.Data;
using BlazorApp1.Models;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace BlazorApp1.Services
{
    public interface ICustomerService 
    {
        List<Customer> GetAll();
        Customer GetById(int id);
        Customer Insert(Customer obj);
        Customer Update(Customer obj);
        void Delete(int id);
    }
    public class CustomerService : ICustomerService
    {
        private EFCoreDbContext context;
        public CustomerService(EFCoreDbContext _context)
        {
            context = _context;
        }
        public void Delete(int id)
        {
            var obj = context.Customer.Find(id);
            context.Customer.Remove(obj);
            context.SaveChanges();
        }

        public List<Customer> GetAll()
        {
            return context.Customer.ToList();
        }

        public Customer GetById(int id)
        {
            return context.Customer.Find(id);
        }

        public Customer Insert(Customer obj)
        {
            context.Customer.Add(obj);
            context.SaveChanges();
            return obj;
        }

        public Customer Update(Customer obj)
        {
            context.Customer.Update(obj);
            context.SaveChanges();
            return obj;
        }
    }
}
