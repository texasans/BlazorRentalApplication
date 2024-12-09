using BlazorApp1.Data;
using BlazorApp1.Models;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace BlazorApp1.Services
{
    public interface IOrderDetailService 
    {
        List<OrderDetail> GetAll();
        OrderDetail GetById(int id);
        OrderDetail Insert(OrderDetail obj);
        OrderDetail Update(OrderDetail obj);
        void Delete(int id);
    }
    public class OrderDetailService : IOrderDetailService
    {
        private EFCoreDbContext context;
        public OrderDetailService(EFCoreDbContext _context)
        {
            context = _context;
        }
        public void Delete(int id)
        {
            var obj = context.OrderDetail.Find(id);
            context.OrderDetail.Remove(obj);
            context.SaveChanges();
        }

        public List<OrderDetail> GetAll()
        {
            return context.OrderDetail.ToList();
        }

        public OrderDetail GetById(int id)
        {
            return context.OrderDetail.Find(id);
        }

        public OrderDetail Insert(OrderDetail obj)
        {
            context.OrderDetail.Add(obj);
            context.SaveChanges();
            return obj;
        }

        public OrderDetail Update(OrderDetail obj)
        {
            context.OrderDetail.Update(obj);
            context.SaveChanges();
            return obj;
        }
    }
}
