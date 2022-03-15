using CommonStructures;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebSite.Services
{
    public class WebApi3Service : IWebApi3Service
    {
        Task<IEnumerable<TC_Data>> IWebApi3Service.LoadData()
        {
            throw new System.NotImplementedException();
        }

        Task<IEnumerable<TC_Data>> IWebApi3Service.PostData()
        {
            throw new System.NotImplementedException();
        }

        Task<IEnumerable<TC_Data>> IWebApi3Service.Search()
        {
            throw new System.NotImplementedException();
        }
    }
}
