﻿using CommonStructures;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace WebAPI_3.Services
{
    public static class DataBuilderService
    {
        private static IHttpClientFactory _clientFactory;
        
        // TODO Fabio: Move this to appsettings
        private const string InitialFile_Path = "\\WebApiFabioNicholasYoussef\\CommonStructures\\CSCompVehicleRecallStart.json";
        private const string Manufacturer_Recall_No_Txt = "MANUFACTURER_RECALL_NO_TXT";
        private const string Category_Etxt = "CATEGORY_ETXT";
        private const string Category_Ftxt = "CATEGORY_FTXT";
        private const string System_Type_Etxt = "SYSTEM_TYPE_ETXT";
        private const string System_Type_Ftxt = "SYSTEM_TYPE_FTXT";

        public static void Init(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public static async Task<string> GetSystemTypeData(string inputJson)
        {
            try
            {
                var inputData = JsonConvert.DeserializeObject<TC_Data_API_3[]>(inputJson).ToList();
                var outputData = new List<TC_Data_API_3>();

                foreach (var item in inputData)
                {
                    var vrdData = await GetVrdData(item.RecallNumber);

                    if (vrdData == null || vrdData.ResultSet.Count == 0)
                    {
                        continue;
                    }

                    var vrdDataList = vrdData.ResultSet.FirstOrDefault();
                    var sytemTypeEtxt = vrdDataList.FirstOrDefault(x => x.Name.Equals(System_Type_Etxt)).Value.Literal;
                    var sytemTypeFtxt = vrdDataList.FirstOrDefault(x => x.Name.Equals(System_Type_Ftxt)).Value.Literal;
                    item.SystemTypeETXT = sytemTypeEtxt;
                    item.SystemTypeFTXT = sytemTypeFtxt;

                    // Quick check for missing values
                    // Add value if missing
                    item.ManufacturerRecallNumber = string.IsNullOrWhiteSpace(item.ManufacturerRecallNumber) ?
                        vrdDataList.FirstOrDefault(x => x.Name.Equals(Manufacturer_Recall_No_Txt)).Value.Literal :
                        item.ManufacturerRecallNumber;
                    item.CategoryETXT = string.IsNullOrWhiteSpace(item.ManufacturerRecallNumber) ?
                        vrdDataList.FirstOrDefault(x => x.Name.Equals(Category_Etxt)).Value.Literal :
                        item.CategoryETXT;
                    item.CategoryFTXT = string.IsNullOrWhiteSpace(item.ManufacturerRecallNumber) ?
                        vrdDataList.FirstOrDefault(x => x.Name.Equals(Category_Ftxt)).Value.Literal :
                        item.CategoryFTXT;


                    outputData.Add(item);
                }

                return JsonConvert.SerializeObject(outputData);
            }
            catch (Exception ex)
            {
                // It can be better done by using proper exception handlers and customized exception if the case.
                throw new Exception(ex.Message);
            }
        }

        public static void CreateJsonFile(string completeDataJson)
        {
            // Saving data to the API 3 folder.
            // It's better to have the path being added to appsettings
            var directory = Directory.GetCurrentDirectory();
            File.WriteAllText(directory + "\\InputFromAPI_3.json", completeDataJson);
        }

        public static async Task<string> GetDataBySystemType(string systemType)
        {
            try
            {
                var filePath = Directory.GetCurrentDirectory() + "\\InputFromAPI_3.json";

                if (string.IsNullOrWhiteSpace(systemType) || !File.Exists(filePath))
                {
                    return string.Empty;
                }

                var fileData = File.ReadAllTextAsync(filePath).Result;
                var deserializeData = JsonConvert.DeserializeObject<List<TC_Data_API_3>>(fileData);
                var selection = deserializeData.Where(x => x.SystemTypeETXT == systemType || x.SystemTypeFTXT == systemType).ToList();

                return JsonConvert.SerializeObject(selection);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public static async Task<string> LoadDataFromPreviousAPIs()
        {
            try
            {
                var solutionDir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
                var fullPath = solutionDir + InitialFile_Path;
                var initialJsonFile = File.ReadAllText(fullPath);

                var tc_Data = JsonConvert.DeserializeObject<TC_Data[]>(initialJsonFile);
                var tcApiDataList = new List<TC_Data_API_2>();

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


                    tcApiDataList.Add(new TC_Data_API_2()
                    {
                        RecallNumber = item.recallNumber,
                        ManufactureName = item.manufactureName,
                        MakeName = item.makeName,
                        ModelName = item.modelName,
                        RecallYear = item.recallYear,
                        ManufacturerRecallNumber = manufacturerRecallNumber,
                        CategoryETXT = categoryETXT,
                        CategoryFTXT = categoryFTXT
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