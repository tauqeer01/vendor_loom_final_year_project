using FinalYearProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalYearProject.DataAccess.Repository.IRepository
{
	public interface IUsersRepo : IRepository<AppUsers>
	{
		Task UpdateAsync(AppUsers appUsers);
	}
}
