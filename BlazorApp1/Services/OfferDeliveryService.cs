using BlazorApp1.Data;
using BlazorApp1.Models;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace BlazorApp1.Services
{
    public interface IOfferDeliveryService 
    {
        List<OfferDelivery> GetAll();
        OfferDelivery GetById(int id);
        OfferDelivery Insert(OfferDelivery obj);
        OfferDelivery Update(OfferDelivery obj);
        void Delete(int id);
    }
    public class OfferDeliveryService : IOfferDeliveryService
    {
        private EFCoreDbContext context;
        public OfferDeliveryService(EFCoreDbContext _context)
        {
            context = _context;
        }
        public void Delete(int id)
        {
            var obj = context.OfferDelivery.Find(id);
            context.OfferDelivery.Remove(obj);
            context.SaveChanges();
        }

        public List<OfferDelivery> GetAll()
        {
            return context.OfferDelivery.ToList();
        }

        public OfferDelivery GetById(int id)
        {
            return context.OfferDelivery.Find(id);
        }

        public OfferDelivery Insert(OfferDelivery obj)
        {
            context.OfferDelivery.Add(obj);
            //context.SaveChanges();
            return obj;
        }

        public OfferDelivery Update(OfferDelivery obj)
        {
            context.OfferDelivery.Update(obj);
            context.SaveChanges();
            return obj;
        }
    }
}
