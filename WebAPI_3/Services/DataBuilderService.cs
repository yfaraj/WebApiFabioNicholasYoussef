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

        public static async Task<string> LoadDataFromPreviousAPIs()
        {
            try
            {
                string solutionDir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
                string fullPath = solutionDir + InitialFile_Path;
                var initialJsonFile = File.ReadAllText(fullPath);

                var tc_Data = JsonConvert.DeserializeObject<TC_Data[]>(initialJsonFile);
                List<TC_Data_API_2> tcApiDataList = new List<TC_Data_API_2>();

                foreach (var item in tc_Data)
                {
                    var vrdData = await GetVrdData(item.recallNumber);
                    if (vrdData == null || vrdData.ResultSet.Count == 0)
                    {
                        continue;
                    }

                    var vrdDataList = vrdData.ResultSet.First();
                    var manufacturerRecallNumber = vrdDataList.FirstOrDefault(x => x.Name.Equals(Manufacturer_Recall_No_Txt)).Value.Literal;
                    var categoryETXT = vrdDataList.FirstOrDefault(x => x.Name.Equals(Category_Etxt)).Value.Literal;
                    var categoryFTXT = vrdDataList.FirstOrDefault(x => x.Name.Equals(Category_Ftxt)).Value.Literal;


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

                var loadedInputJson = JsonConvert.SerializeObject(tcApiDataList);

                return loadedInputJson;
            }
            catch (Exception ex)
            {
                // It can be better done by using proper exception handlers and customized exception if the case.
                throw new Exception(ex.Message);
            }            
        }

        private static async Task<TC_Data_Online> GetVrdData(string recallNumber)
        {
            var client = _clientFactory.CreateClient("VRD");
            client.DefaultRequestHeaders.Add("Accept", "application/vnd.github.v3+json");
            var response = await client.GetAsync("https://data.tc.gc.ca/v1.3/api/eng/vehicle-recall-database/recall-summary/recall-number/" + recallNumber);
            string responseBody = await response.Content.ReadAsStringAsync();
            
            return JsonConvert.DeserializeObject<TC_Data_Online>(responseBody);
        }
    }
}