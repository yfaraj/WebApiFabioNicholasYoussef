using CommonStructures;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Json;
using System.IO;
using System;
using Newtonsoft.Json;

namespace WebSite.Services
{
    public class WebApi3Service : IWebApi3Service
    {
        private readonly HttpClient _httpClient;
        private const string File_Path = "\\WebApiFabioNicholasYoussef\\CommonStructures\\TC_Data.json";

        public WebApi3Service(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<TC_Data>> LoadData()
        {
            try
            {
                var solutionDir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
                var jsonData = File.ReadAllText(solutionDir + File_Path);
                var resultData = JsonConvert.DeserializeObject<TC_Data[]>(jsonData);

                return resultData;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Task<IEnumerable<TC_Data>> PostData()
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<TC_Data>> Search()
        {
            throw new System.NotImplementedException();
        }
    }
}
