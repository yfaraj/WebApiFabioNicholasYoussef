using CommonStructures;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

          static readonly HttpClient client = new HttpClient();

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
                    string rN = tcDataArray[i].recallNumber;
                    HttpResponseMessage response = await client.GetAsync("https://data.tc.gc.ca/v1.3/api/eng/vehicle-recall-database/recall-summary/recall-number/" + rN, CancellationToken.None);
                    //var s = response.StatusCode;
                    //response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    var v = JsonConvert.DeserializeObject<TC_Data_Online>(responseBody);

                    TC_Data_API_1 tC_Data_API_1 = new TC_Data_API_1();
                    tC_Data_API_1.recallNumber = tcDataArray[i].recallNumber;
                    tC_Data_API_1.manufactureName = tcDataArray[i].manufactureName;
                    tC_Data_API_1.makeName = tcDataArray[i].makeName;
                    tC_Data_API_1.modelName = tcDataArray[i].modelName;
                    tC_Data_API_1.recallYear = tcDataArray[i].recallYear;
                    //tC_Data_API_1.manufacturerRecallNumber = responseBody
                    tcApiDataList.Add(tC_Data_API_1);
               }



               /*Pseudo Code:
                * Input_Data = Read_TC_Input_File_JSON_Data(jsonData);
               foreach (Recall Number)
               {
                    Manufacturer_Recall_Number = Call_TC_API(ecall Number);//https://data.tc.gc.ca/v1.3/api/eng/vehicle-recall-database/recall-summary/recall-number/2016253
                    Add_To_Input_Data(Manufacturer_Recall_Number);
               }
               Save_To_File_1(Input_Data);*/

               return Ok("response");
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
