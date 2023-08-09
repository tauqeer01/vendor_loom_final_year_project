using FinalYearProject.Data.Repo.IRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalYearProject.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        ICategoryRepo Category { get; }
        IProductRepo Product { get; }
        ICloudinaryUploadRepo CloudinaryUploadRepo { get; }
        IProductImageRepo ProductImage { get; }
        IUsersRepo UsersRepo { get; }
        void Save();
    }
}
