using CommonStructures;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebSite.Services
{
    public interface IWebApi2Service
    {
        Task<IEnumerable<TC_Data>> LoadData();
        Task<string> PostData();
        Task<IEnumerable<TC_Data>> Search(string category);
    }
}
