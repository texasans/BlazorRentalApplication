using BlazorApp1.Data;
using BlazorApp1.Models;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace BlazorApp1.Services
{
    public interface IDeliveryService 
    {
        List<Delivery> GetAll();
        Delivery GetById(int id);
        Delivery Insert(Delivery obj);
        Delivery Update(Delivery obj);
        void Delete(int id);
    }
    public class DeliveryService : IDeliveryService
    {
        private EFCoreDbContext context;
        public DeliveryService(EFCoreDbContext _context)
        {
            context = _context;
        }
        public void Delete(int id)
        {
            var obj = context.Delivery.Find(id);
            context.Delivery.Remove(obj);
            context.SaveChanges();
        }

        public List<Delivery> GetAll()
        {
            return context.Delivery.ToList();
        }

        public Delivery GetById(int id)
        {
            return context.Delivery.Find(id);
        }

        public Delivery Insert(Delivery obj)
        {
            context.Delivery.Add(obj);
            context.SaveChanges();
            return obj;
        }

        public Delivery Update(Delivery obj)
        {
            context.Delivery.Update(obj);
            context.SaveChanges();
            return obj;
        }
    }
}
