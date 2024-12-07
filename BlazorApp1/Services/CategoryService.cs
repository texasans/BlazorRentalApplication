using BlazorApp1.Data;
using BlazorApp1.Models;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace BlazorApp1.Services
{
    public interface ICategoryService 
    {
        List<Category> GetAll();
        Category GetById(int id);
        Category Insert(Category obj);
        Category Update(Category obj);
        void Delete(int id);
    }
    public class CategoryService : ICategoryService
    {
        private EFCoreDbContext context;
        public CategoryService(EFCoreDbContext _context)
        {
            context = _context;
        }
        public void Delete(int id)
        {
            var obj = context.Category.Find(id);
            context.Category.Remove(obj);
            context.SaveChanges();
        }

        public List<Category> GetAll()
        {
            return context.Category.ToList();
        }

        public Category GetById(int id)
        {
            return context.Category.Find(id);
        }

        public Category Insert(Category obj)
        {
            context.Category.Add(obj);
            context.SaveChanges();
            return obj;
        }

        public Category Update(Category obj)
        {
            context.Category.Update(obj);
            context.SaveChanges();
            return obj;
        }
    }
}
