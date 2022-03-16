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
        private const string BaseFile_Path = "\\WebApiFabioNicholasYoussef\\CommonStructures\\TC_Data.json";
        private const string File_Path = "\\Upload\\" + "DataFile.json";
        private const string WebApi3PostUrl = "http://localhost:5003/WebAPI/V1/PostFileData";
        private const string WebApi3GetUrl = "http://localhost:5003/WebAPI/V1/GetFileData";
        private const string WebApi3SearchUrl = "http://localhost:5003/WebAPI/V1/Search?systemType=";

        public WebApi3Service(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> PostData()
        {
            try
            {
                var jsonString = await GetJsonString();                
                //var tcData = JsonConvert.DeserializeObject<string>(jsonString);
                //tcData = tcData == null ? string.Empty : tcData;
                var result = await _httpClient.PostAsync(WebApi3PostUrl, jsonString, new JsonMediaTypeFormatter());

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
                var callResult = await _httpClient.GetStringAsync(WebApi3GetUrl);
                var resultData = JsonConvert.DeserializeObject<TC_Data[]>(callResult);

                return resultData;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            //try
            //{
            //    var solutionDir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            //    var jsonData = File.ReadAllText(solutionDir + BaseFile_Path);
            //    var resultData = JsonConvert.DeserializeObject<TC_Data[]>(jsonData);

            //    return resultData;
            //}
            //catch (Exception ex)
            //{
            //    throw new Exception(ex.Message);
            //}
        }

        public async Task<IEnumerable<TC_Data>> Search(string systemType)
        {
            try
            {
                var resultData = new TC_Data[] { };
                var callResult = await _httpClient.GetStringAsync(WebApi3SearchUrl + systemType);
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
                return string.Empty;
            }
            var jsonData = File.ReadAllText(fullFilePath);

            return jsonData;
        }
    }
}
