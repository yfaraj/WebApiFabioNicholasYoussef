using CommonStructures;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace WebAPI_3.Services
{
    public static class DataBuilderService
    {
        private static IHttpClientFactory _clientFactory;
        private const string InitialFile_Path = "\\WebApiFabioNicholasYoussef\\CommonStructures\\CSCompVehicleRecallStart.json";
        private const string Manufacturer_Recall_No_Txt = "MANUFACTURER_RECALL_NO_TXT";
        private const string Category_Etxt = "CATEGORY_ETXT";
        private const string Category_Ftxt = "CATEGORY_FTXT";

        public static void Init(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public static async Task<string> LoadPreviousData()
        {
            try
            {
                string solutionDir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
                string fullPath = solutionDir + InitialFile_Path;
                var initialJsonFile = File.ReadAllText(fullPath);

                var tc_Data = JsonConvert.DeserializeObject<TC_Data[]>(initialJsonFile);
                List<TC_Data_API_3> tcApiDataList = new List<TC_Data_API_3>();

                foreach (var item in tc_Data)
                {
                    var vrdDataList = GetVrdData(item.recallNumber).Result.ResultSet.FirstOrDefault();
                    

                    //var response = await client.GetAsync("https://data.tc.gc.ca/v1.3/api/eng/vehicle-recall-database/recall-summary/recall-number/" + item.recallNumber, CancellationToken.None);
                    //string responseBody = await response.Content.ReadAsStringAsync();

                    //var vrdDataList = JsonConvert.DeserializeObject<TC_Data_Online>(responseBody).ResultSet.FirstOrDefault();

                    var manufacturerRecallNumber = vrdDataList.FirstOrDefault(x => x.Name == Manufacturer_Recall_No_Txt).Value.Literal;
                    var categoryETXT = vrdDataList.FirstOrDefault(x => x.Name == Category_Etxt).Value.Literal;
                    var categoryFTXT = vrdDataList.FirstOrDefault(x => x.Name == Category_Ftxt).Value.Literal;


                    tcApiDataList.Add(new TC_Data_API_3()
                    {
                        recallNumber = item.recallNumber,
                        manufactureName = item.manufactureName,
                        makeName = item.makeName,
                        modelName = item.modelName,
                        recallYear = item.recallYear,
                        manufacturerRecallNumber = manufacturerRecallNumber,
                        categoryETXT = categoryETXT,
                        categoryFTXT = categoryFTXT
                    });
                }

                return initialJsonFile;
            }
            catch (Exception ex)
            {
                var xxx = ex.Message;
                throw;
            }            
        }

        private static async Task<TC_Data_Online> GetVrdData(string recallNumber)
        {
            var request = new HttpRequestMessage(HttpMethod.Get,
            "https://data.tc.gc.ca/v1.3/api/eng/vehicle-recall-database/recall-summary/recall-number/" + recallNumber);
            
            var client = _clientFactory.CreateClient("VRD");
            
            var response = await client.SendAsync(request);

            //var responsex = await client.GetAsync("https://data.tc.gc.ca/v1.3/api/eng/vehicle-recall-database/recall-summary/recall-number/" + recallNumber, CancellationToken.None);
            string responseBody = await response.Content.ReadAsStringAsync();
            
            return JsonConvert.DeserializeObject<TC_Data_Online>(responseBody);
        }
    }
}