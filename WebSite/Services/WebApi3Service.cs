using CommonStructures;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.IO;
using System;
using Newtonsoft.Json;
using System.Net.Http.Formatting;

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

        public async Task<string> PostData()
        {
            try
            {
                var jsonString = await GetJsonString();
                var tcData = JsonConvert.DeserializeObject<TC_Data[]>(jsonString);
                var result = await _httpClient.PostAsync("http://localhost:5001/WebAPI/V1/PostFileData", tcData, new JsonMediaTypeFormatter());

                return result.StatusCode.ToString();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Task<IEnumerable<TC_Data>> Search()
        {
            throw new System.NotImplementedException();
        }

        private async Task<string> GetJsonString()
        {
            var fullFilePath = Directory.GetCurrentDirectory() + File_Path;
            if (!File.Exists(fullFilePath))
            {
                throw new Exception("Initial input file not found. Please upload the file first.");
            }
            var jsonData = File.ReadAllText(fullFilePath);

            return jsonData;
        }
    }
}
