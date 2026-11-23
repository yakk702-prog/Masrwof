using Masrwof.Models;
using Masrwof.Interfaces;
using Masrwof.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Text;

namespace Masrwof.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly AppDbContext _context;
        public CategoryService(AppDbContext context)
        {
            _context = context;
        }
        public void InitializeDatabase()
        {
            _context.Database.EnsureCreated();
        }
        public List<Category> GetAllCategories()
        {
            return _context.Categories.OrderBy(c => c.Name).ToList();
        }
        public Category GetCategoryById(Guid id)
        {
            return _context.Categories.FirstOrDefault(c => c.Id == id);
        }
        public void UpdateCategory(Category category)
        {
            if (category == null) return;
            _context.Categories.Update(category);
            _context.SaveChanges();
        }
        public void AddCategory(Category category)
        {
            if (category == null) return;
            _context.Categories.Add(category);
            _context.SaveChanges();
        }
        public void DeleteCategory(Guid id)
        {
            var category = _context.Categories.FirstOrDefault(c => c.Id == id);
            if (category != null)
            {
                _context.Categories.Remove(category);
                _context.SaveChanges();
            }
        }

        public decimal GetTotalCategoryAmount()
        {
            return _context.Categories.Any() ? _context.Categories.Sum(c => c.Amount) : 0;
        }
    }
}
