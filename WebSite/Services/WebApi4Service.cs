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
    public class WebApi4Service : IWebApi4Service
    {
        private readonly HttpClient _httpClient;
        private const string File_Path = "\\Upload\\" + "DataFile.json";
        private const string WebApi4PostUrl = "http://localhost:5004/WebAPI/V1/PostFileData";
        private const string WebApi4GetUrl = "http://localhost:5004/WebAPI/V1/GetFileData";
        private const string WebApi4SearchUrl = "http://localhost:5004/WebAPI/V1/Search?manufacturerRecallNumber=";

        public WebApi4Service(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> PostData()
        {
            try
            {
                var jsonString = await GetJsonString();
                var tcData = JsonConvert.DeserializeObject<TC_Data[]>(jsonString);
                var result = await _httpClient.PostAsync(WebApi4PostUrl, tcData, new JsonMediaTypeFormatter());

                return result.StatusCode.ToString();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<IEnumerable<TC_Data>> LoadData()
        {
            try
            {
                var callResult = await _httpClient.GetStringAsync(WebApi4GetUrl);
                var resultData = JsonConvert.DeserializeObject<TC_Data[]>(callResult);

                return resultData;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<IEnumerable<TC_Data>> Search(string manufacturerRecallNumber)
        {
            try
            {
                var resultData = new TC_Data[] { };
                var callResult = await _httpClient.GetStringAsync(WebApi4SearchUrl + manufacturerRecallNumber);
                resultData = JsonConvert.DeserializeObject<TC_Data[]>(callResult);
                return resultData;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
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
