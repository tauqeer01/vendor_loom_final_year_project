using FinalYearProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalYearProject.DataAccess.Repository.IRepository
{
    public interface ICategoryRepo : IRepository<Category>
    {
        Task UpdateAsync(Category category);
        Task SaveAsync();
    }
}
