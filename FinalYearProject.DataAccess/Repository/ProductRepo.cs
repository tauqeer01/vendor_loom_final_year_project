using FinalYearProject.Data;
using FinalYearProject.DataAccess.Repository.IRepository;
using FinalYearProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalYearProject.DataAccess.Repository
{
    public class ProductRepo : Repository<Product> , IProductRepo
    {
        private readonly ApplicationDbContext _db;
        public ProductRepo(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public async Task<int> GetCountByCategoryIdAsync(int categoryId)
        {
            return await _db.Products.CountAsync(p => p.CategoryId == categoryId);
        }

        public async Task SaveAsync()
        {
            await _db.SaveChangesAsync();
        }

        public async Task UpdateAsync(Product products)
        {
            _db.Update(products);
        }
    }
}
