using BlazorInputFile;
using System.Threading.Tasks;

namespace WebSite.Services
{
    public interface IFileUpload
    {
        Task UploadAsync(IFileListEntry file);
    }
}
