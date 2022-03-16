using BlazorInputFile;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using System.Threading.Tasks;

namespace WebSite.Services
{
    public class FileUpload : IFileUpload
    {
        private readonly IWebHostEnvironment _environment;

        public FileUpload(IWebHostEnvironment environment)
        {
            _environment = environment;
        }

        public async Task UploadAsync(IFileListEntry fileEntry)
        {           
            // "InitialInputData.json";
            var path= Path.Combine(_environment.ContentRootPath,"Upload",fileEntry.Name);
            var ms = new MemoryStream();
            await fileEntry.Data.CopyToAsync(ms);
            
            using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                ms.WriteTo(fs);
            }
            
            // Renaming the whatever input file to a standard one
            File.Move(path, Path.Combine(_environment.ContentRootPath, "Upload", "InitialInputData.json"));
        }
    }
}
