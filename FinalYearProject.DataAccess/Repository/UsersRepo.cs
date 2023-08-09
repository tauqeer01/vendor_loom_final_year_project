using FinalYearProject.Data;
using FinalYearProject.DataAccess.Repository.IRepository;
using FinalYearProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalYearProject.DataAccess.Repository
{
	public class UsersRepo : Repository<AppUsers> , IUsersRepo
	{
		private readonly ApplicationDbContext _db;
		public UsersRepo(ApplicationDbContext db) : base(db)
		{
			_db = db;
		}

		public async Task UpdateAsync(AppUsers appUsers)
		{
			_db.Update(appUsers);
		}
	}
}
