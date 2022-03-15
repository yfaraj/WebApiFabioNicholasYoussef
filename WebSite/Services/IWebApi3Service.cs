using CommonStructures;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebSite.Services
{
    public interface IWebApi3Service
    {
        Task<IEnumerable<TC_Data>> LoadData();
        Task<IEnumerable<TC_Data>> PostData();
        Task<IEnumerable<TC_Data>> Search();
    }
}
