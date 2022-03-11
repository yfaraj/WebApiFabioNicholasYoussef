using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI_3.Controllers
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
          public async Task<IActionResult> PostFileData([FromBody] string jsonData)
          {
               /*Pseudo Code:
                * Input_Data = Read_TC_Input_File_JSON_Data(jsonData);
               foreach (Recall Number)
               {
                    System_Type = Call_TC_API(ecall Number);//https://data.tc.gc.ca/v1.3/api/eng/vehicle-recall-database/recall-summary/recall-number/2016253
                    Add_To_Input_Data(System_Type);
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
          /// Search data using the System Type
          /// </summary>
          /// <remarks>This Web API retrieves a JSON data resulting from querying data using the System Type</remarks>
          /// <param name="systemType">System Type</param>
          /// <returns>JSON data</returns>
          [HttpGet]
          [Route("Search")]
          [Consumes("application/json")]
          public async Task<IActionResult> Search(string systemType)
          {
               string resultJsonData = "";

               /*Pseudo Code:
                *   jsonFileData = Read_TC_Output_File_JSON_Data();
                *   
                *   foreach(API_Object_Data in jsonFileData)
	               {
		               if ((API_Object_Data.SYSTEM_TYPE_ETXT == systemType) || (API_Object_Data.SYSTEM_TYPE_FTXT == systemType))
		               {
			               resultJsonData.Add(API_Object_Data);
		               }
	               }
                */

               return Ok(resultJsonData);
          }
     }
}
