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
    public class ProductImageRepo : IProductImageRepo
    {
        private readonly ApplicationDbContext _db;

        public ProductImageRepo(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task AddProductImagesAsync(int productId, List<string> imageUrls)
        {
            var productImages = imageUrls.Select(url => new ProductImage
            {
                ProductId = productId,
                ImageURL = url
            }).ToList();

            _db.ProductImages.AddRange(productImages);
            await _db.SaveChangesAsync();
        }
    }
}
