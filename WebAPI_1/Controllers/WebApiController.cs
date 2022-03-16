using CommonStructures;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WebAPI_1.Controllers
{
     [Route("WebAPI/v{version:apiVersion}")]
     [ApiController]
     [ApiVersion("1.0")]
     public class WebApiController : ControllerBase
     {
          private readonly ILogger<WebApiController> _logger;

          public WebApiController(ILogger<WebApiController> logger)
          {
               _logger = logger;
          }

          // POST WebAPI/PostFileData
          /// <summary>
          /// Post a JSON file data
          /// </summary>
          /// <remarks>This Web API posts file data and manipulates it</remarks>
          /// <param name="jsonData">JSON file data</param>
          /// <returns></returns>
          [HttpPost]
          [Route("PostFileData")]
          [Consumes("application/json")]
          public async Task<IActionResult> PostFileData([FromBody] TC_Data[] tcDataArray)
          {
               List<TC_Data_API_1> tcApiDataList = new List<TC_Data_API_1>();
               for (int i = 0; i < tcDataArray.Length; i++)
               {
                    string rN = tcDataArray[i].RecallNumber;

                    string baseAddress = "https://data.tc.gc.ca/v1.3/api/eng/vehicle-recall-database/recall-summary/recall-number/2015321";
                    var client3 = new RestClient(baseAddress);
                    var request = new RestRequest(baseAddress, Method.Get);
                    request.AddHeader("Content-Type", "application/json");
                    var body = @"" + "\n" + @"";
                    request.AddParameter("application/json", body, ParameterType.RequestBody);
                    var response = await client3.ExecuteGetAsync(request);
                    TC_Data_Online tcDataOnline = JsonConvert.DeserializeObject<TC_Data_Online>(response.Content);

                    bool atLeastFoundOne = false;
                    int maxYear = 0;
                    string manufacturerRecallNumber = "";
                    foreach (var resultSet in tcDataOnline.ResultSet)
                    {
                         bool recallNumberNumFound = false;
                         int year = 0;
                         string currentManufacturerRecallNumber = "";
                         foreach (var resultSetItem in resultSet)
                         {
                              if (resultSetItem.Name == "RECALL_NUMBER_NUM")
                              {
                                   if (resultSetItem.Value.Literal == rN)
                                   {
                                        atLeastFoundOne = recallNumberNumFound = true;
                                   }
                              }
                              if (resultSetItem.Name == "MANUFACTURER_RECALL_NO_TXT")
                              {
                                   currentManufacturerRecallNumber = resultSetItem.Value.Literal;
                              }
                              if (resultSetItem.Name == "DATE_YEAR_CD")
                              {
                                   Int32.TryParse(resultSetItem.Value.Literal, out year);
                              }
                         }
                         if (recallNumberNumFound)
                         {
                              if (year != 0)
                              {
                                   if (year > maxYear)
                                   {
                                        maxYear = year;
                                        manufacturerRecallNumber = currentManufacturerRecallNumber;
                                   }
                              }
                         }
                    }
                    if (atLeastFoundOne)
                    {
                         TC_Data_API_1 tC_Data_API_1 = new TC_Data_API_1();
                         tC_Data_API_1.RecallNumber = tcDataArray[i].RecallNumber;
                         tC_Data_API_1.ManufactureName = tcDataArray[i].ManufactureName;
                         tC_Data_API_1.MakeName = tcDataArray[i].MakeName;
                         tC_Data_API_1.ModelName = tcDataArray[i].ModelName;
                         tC_Data_API_1.RecallYear = tcDataArray[i].RecallYear;
                         tC_Data_API_1.ManufacturerRecallNumber = manufacturerRecallNumber;
                         tcApiDataList.Add(tC_Data_API_1);
                    }
                    else
                    {
                         TC_Data_API_1 tC_Data_API_1 = new TC_Data_API_1();
                         tC_Data_API_1.RecallNumber = tcDataArray[i].RecallNumber;
                         tC_Data_API_1.ManufactureName = tcDataArray[i].ManufactureName;
                         tC_Data_API_1.MakeName = tcDataArray[i].MakeName;
                         tC_Data_API_1.ModelName = tcDataArray[i].ModelName;
                         tC_Data_API_1.RecallYear = tcDataArray[i].RecallYear;
                         tC_Data_API_1.ManufacturerRecallNumber = "";
                         tcApiDataList.Add(tC_Data_API_1);
                    }
               }

               string json = JsonConvert.SerializeObject(tcApiDataList);
               System.IO.File.WriteAllText(@"output.json", json);

               return Ok();
          }

          // GET WebAPI/GetFileData
          /// <summary>
          /// Get the JSON data of the output file
          /// </summary>
          /// <remarks>This Web API retrieves the JSON data of the output file</remarks>
          /// <returns>JSON data of the output file</returns>
          [HttpGet]
          [Route("GetFileData")]
          [Consumes("application/json")]
          public async Task<IActionResult> GetFileData()
          {
               string jsonFileData = "";

               jsonFileData = System.IO.File.ReadAllText(@"output.json");
               var json = JsonConvert.DeserializeObject<List<TC_Data_API_1>>(jsonFileData);

               return Ok(json);
          }

          // GET WebAPI/Search
          /// <summary>
          /// Search data using the Manufacturer Recall Number 
          /// </summary>
          /// <remarks>This Web API retrieves a JSON data resulting from querying data using the Manufacturer Recall Number</remarks>
          /// <param name="manufacturerRecallNumber">Manufacturer Recall Number</param>
          /// <returns>JSON data</returns>
          [HttpGet]
          [Route("Search")]
          [Consumes("application/json")]
          public async Task<IActionResult> Search(string manufacturerRecallNumber)
          {
               string jsonFileData = "";
               List<TC_Data_API_1> result = new List<TC_Data_API_1>();

               jsonFileData = System.IO.File.ReadAllText(@"output.json");
               var json = JsonConvert.DeserializeObject<List<TC_Data_API_1>>(jsonFileData);
               foreach(TC_Data_API_1 tcDataAPI1 in json)
               {
                    if(tcDataAPI1.ManufactureName == manufacturerRecallNumber)
                    {
                         result.Add(tcDataAPI1);
                    }
               }
               if (result.Count() > 0)
               {
                    return Ok(result);
               }
               else
               {
                    return NotFound();
               }
          }
     }
}
