using FinalYearProject.DataAccess.Repository.IRepository;
using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Threading.Tasks;

namespace FinalYearProject.DataAccess.Repository
{
    public class ImagesUploadRepo : IImagesUploadRepo
    {
        private readonly string _imageUploadDirectory;

        public ImagesUploadRepo(string imageUploadDirectory)
        {
            _imageUploadDirectory = Path.Combine(imageUploadDirectory, "Uploads");

            if (!Directory.Exists(_imageUploadDirectory))
            {
                Directory.CreateDirectory(_imageUploadDirectory);
            }
        }

        public async Task<string> UploadImageAsync(IFormFile imageFile)
        {
            if (imageFile == null || imageFile.Length == 0)
            {
                throw new ArgumentException("Invalid image file.");
            }

            string uniqueFileName = Guid.NewGuid().ToString() + Path.GetExtension(imageFile.FileName);
            string filePath = Path.Combine(_imageUploadDirectory, uniqueFileName);

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await imageFile.CopyToAsync(stream);
            }

            return uniqueFileName;
        }
    }
}
