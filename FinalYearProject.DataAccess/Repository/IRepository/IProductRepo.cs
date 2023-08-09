using FinalYearProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalYearProject.DataAccess.Repository.IRepository
{
    public interface IProductRepo : IRepository<Product>
    {
        Task UpdateAsync(Product products);
        Task<int> GetCountByCategoryIdAsync(int categoryId);
        Task SaveAsync();
    }
}
