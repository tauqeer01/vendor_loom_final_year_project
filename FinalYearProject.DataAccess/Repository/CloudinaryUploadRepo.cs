using CloudinaryDotNet;
using FinalYearProject.Data.Repo.IRepo;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalYearProject.Data.Repo
{
    public class CloudinaryUploadRepo : ICloudinaryUploadRepo
    {
        private readonly Account account;
        public CloudinaryUploadRepo(IConfiguration configuration)
        {
            account = new Account(configuration.GetSection("Cloudinary")["CloudName"], configuration.GetSection("Cloudinary")["ApiKey"],
                configuration.GetSection("Cloudinary")["ApiSecret"]

                );
                
        }
        public async Task<List<string>> UploadMultipleAsync(List<IFormFile> files)
        {
            var client = new Cloudinary(account);
            var imageUrls = new List<string>();

            foreach (var file in files)
            {
                var uploadParams = new CloudinaryDotNet.Actions.ImageUploadParams()
                {
                    File = new FileDescription(file.FileName, file.OpenReadStream()),
                    DisplayName = file.Name
                };

                var uploadFileResult = await client.UploadAsync(uploadParams);

                if (uploadFileResult != null && uploadFileResult.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    imageUrls.Add(uploadFileResult.SecureUri.ToString());
                }
                else
                {
                    // Handle error or return null for unsuccessful uploads
                    // You can also throw an exception if needed
                }
            }

            return imageUrls;
        }
    }
}
