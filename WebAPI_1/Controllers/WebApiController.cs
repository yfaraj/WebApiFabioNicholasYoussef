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

          private static bool ServerCertificateCustomValidation(HttpRequestMessage requestMessage, X509Certificate2 certificate, X509Chain chain, SslPolicyErrors sslErrors)
          {
               // It is possible inpect the certificate provided by server
               Console.WriteLine($"Requested URI: {requestMessage.RequestUri}");
               Console.WriteLine($"Effective date: {certificate.GetEffectiveDateString()}");
               Console.WriteLine($"Exp date: {certificate.GetExpirationDateString()}");
               Console.WriteLine($"Issuer: {certificate.Issuer}");
               Console.WriteLine($"Subject: {certificate.Subject}");

               // Based on the custom logic it is possible to decide whether the client considers certificate valid or not
               Console.WriteLine($"Errors: {sslErrors}");
               return sslErrors == SslPolicyErrors.None;
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
               /*
               List<TC_Data_API_1> tcApiDataList = new List<TC_Data_API_1>();
               for (int i = 0; i < tcDataArray.Length; i++)
               {
                    string rN = tcDataArray[i].recallNumber;

                    string baseAddress = "https://data.tc.gc.ca/v1.3/api/eng/vehicle-recall-database/recall-summary/recall-number/2015321";
                    var client3 = new RestClient(baseAddress);
                    var request = new RestRequest(baseAddress, Method.Get);
                    request.AddHeader("Content-Type", "application/json");
                    var body = @"" + "\n" + @"";
                    request.AddParameter("application/json", body, ParameterType.RequestBody);
                    var response = await client3.ExecuteGetAsync(request);
                    TC_Data_Online tcDataOnline = JsonConvert.DeserializeObject<TC_Data_Online>(response.Content);

                    bool atLeastFoundOne = false;
                    foreach(var resultSet in tcDataOnline.ResultSet)
                    {
                         foreach(var resultSetItem in resultSet)
                         {
                              if (resultSetItem.Name == "RECALL_NUMBER_NUM")
                              {
                                   if (resultSetItem.Value.Literal == rN)
                                   {
                                        TC_Data_API_1 tC_Data_API_1 = new TC_Data_API_1();
                                        tC_Data_API_1.recallNumber = tcDataArray[i].recallNumber;
                                        tC_Data_API_1.manufactureName = tcDataArray[i].manufactureName;
                                        tC_Data_API_1.makeName = tcDataArray[i].makeName;
                                        tC_Data_API_1.modelName = tcDataArray[i].modelName;
                                        tC_Data_API_1.recallYear = tcDataArray[i].recallYear;
                                        tC_Data_API_1.manufacturerRecallNumber = rN;
                                        tcApiDataList.Add(tC_Data_API_1);

                                        atLeastFoundOne = true;
                                   }
                              }
                         }
                    }
                    if (!atLeastFoundOne)
                    {
                         TC_Data_API_1 tC_Data_API_1 = new TC_Data_API_1();
                         tC_Data_API_1.recallNumber = tcDataArray[i].recallNumber;
                         tC_Data_API_1.manufactureName = tcDataArray[i].manufactureName;
                         tC_Data_API_1.makeName = tcDataArray[i].makeName;
                         tC_Data_API_1.modelName = tcDataArray[i].modelName;
                         tC_Data_API_1.recallYear = tcDataArray[i].recallYear;
                         tC_Data_API_1.manufacturerRecallNumber = "";
                         tcApiDataList.Add(tC_Data_API_1);
                    }
               }

               string json = JsonConvert.SerializeObject(tcApiDataList);
               System.IO.File.WriteAllText(@"output.json", json);
               */
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

               /*Pseudo Code:
                * jsonFileData = Read_TC_Output_File_JSON_Data();
                */

               return Ok(jsonFileData);
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
          public async Task<IActionResult> Search(int manufacturerRecallNumber)
          {
               string resultJsonData = "";

               /*Pseudo Code:
                *   jsonFileData = Read_TC_Output_File_JSON_Data();
                *   
                *   foreach(API_Object_Data in jsonFileData)
	               {
		               if (API_Object_Data.Manufacturer_Recall_Number == manufacturerRecallNumber)
		               {
			               resultJsonData.Add(API_Object_Data);
		               }
	               }
                */

               return Ok(resultJsonData);
          }
     }
}
