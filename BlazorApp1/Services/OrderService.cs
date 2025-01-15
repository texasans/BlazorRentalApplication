using BlazorApp1.Data;
using BlazorApp1.Models;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace BlazorApp1.Services
{
    public interface IOrderService 
    {
        List<Order> GetAll();
        Order GetById(int id);
        Order Insert(Order obj);
        Order Update(Order obj);
        void Delete(int id);
    }
    public class OrderService : IOrderService
    {
        private EFCoreDbContext context;
        public OrderService(EFCoreDbContext _context)
        {
            context = _context;
        }
        public void Delete(int id)
        {
            var obj = context.Order.Find(id);
            context.Order.Remove(obj);
            context.SaveChanges();
        }

        public List<Order> GetAll()
        {
            return context.Order.ToList();
        }

        public Order GetById(int id)
        {
            return context.Order.Find(id);
        }

        public Order Insert(Order obj)
        {
            context.Order.Add(obj);
            //context.SaveChanges();
            return obj;
        }

        public Order Update(Order obj)
        {
            context.Order.Update(obj);
            context.SaveChanges();
            return obj;
        }

        public void commitData()
        {
            //colocar try catch
            context.SaveChanges();
        }
    }
}
