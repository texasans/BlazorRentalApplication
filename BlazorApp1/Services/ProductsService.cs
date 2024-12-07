using BlazorApp1.Data;
using BlazorApp1.Models;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace BlazorApp1.Services
{
    public interface IProductsService 
    {
        List<Products> GetAll();
        Products GetById(int id);
        Products Insert(Products obj);
        Products Update(Products obj);
        void Delete(int id);
    }
    public class ProductsService : IProductsService
    {
        private EFCoreDbContext context;
        public ProductsService(EFCoreDbContext _context)
        {
            context = _context;
        }
        public void Delete(int id)
        {
            var obj = context.Products.Find(id);
            context.Products.Remove(obj);
            context.SaveChanges();
        }

        public List<Products> GetAll()
        {
            return context.Products.ToList();
        }

        public Products GetById(int id)
        {
            return context.Products.Find(id);
        }

        public Products Insert(Products obj)
        {
            context.Products.Add(obj);
            context.SaveChanges();
            return obj;
        }

        public Products Update(Products obj)
        {
            context.Products.Update(obj);
            context.SaveChanges();
            return obj;
        }
    }
}
