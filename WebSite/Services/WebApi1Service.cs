using CommonStructures;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.IO;
using System;
using Newtonsoft.Json;

namespace WebSite.Services
{
    public class WebApi1Service : IWebApi1Service
    {
        private readonly HttpClient _httpClient;
        private const string File_Path = "\\Upload\\" + "InitialInputData.json";

        public WebApi1Service(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<TC_Data>> LoadData()
        {
            try
            {
                var fullFilePath = Directory.GetCurrentDirectory() + File_Path;
                if (!File.Exists(fullFilePath))
                {
                    throw new Exception("Initial input file not found. Please upload the file first");
                }
                var jsonData = File.ReadAllText(fullFilePath);
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
