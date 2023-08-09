using FinalYearProject.Data;
using FinalYearProject.Data.Repo;
using FinalYearProject.Data.Repo.IRepo;
using FinalYearProject.DataAccess.Repository.IRepository;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalYearProject.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;
        private readonly IConfiguration _configuration;
        public UnitOfWork(ApplicationDbContext db, IConfiguration configuration)
        {
           _db = db;
           _configuration = configuration;
           CloudinaryUploadRepo = new CloudinaryUploadRepo(_configuration);
           Category = new CategoryRepo(_db);
           Product = new ProductRepo(_db);
           ProductImage = new ProductImageRepo(_db);
           UsersRepo = new UsersRepo(_db); 
        }
        public ICategoryRepo Category { get; private set; }
        public IProductRepo Product { get; private set; }

        public ICloudinaryUploadRepo CloudinaryUploadRepo { get; private set; }

        public IProductImageRepo ProductImage { get; private set; }

		public IUsersRepo UsersRepo { get; private set; }

		public void Save()
        {
            _db.SaveChanges();
        }
    }
}
