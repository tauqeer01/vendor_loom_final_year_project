using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalYearProject.Data.Repo.IRepo
{
    public interface ICloudinaryUploadRepo
    {
        Task<List<string>> UploadMultipleAsync(List<IFormFile> files);
    }
}
