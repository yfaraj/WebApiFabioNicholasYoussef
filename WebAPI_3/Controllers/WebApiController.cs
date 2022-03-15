using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using WebAPI_3.Services;

namespace WebAPI_3.Controllers
{
    [Route("WebAPI/v{version:apiVersion}")]
     [ApiController]
     [ApiVersion("1.0")]
     public class WebApiController : ControllerBase
     {
        private readonly ILogger<WebApiController> _logger;
        private readonly IHttpClientFactory _clientFactory;

        public WebApiController(ILogger<WebApiController> logger, IHttpClientFactory clientFactory)
        {
            _logger = logger;
            _clientFactory = clientFactory;
            DataBuilderService.Init(_clientFactory);
        }

        // POST WebAPI/PostFileData
        /// <summary>
        /// Post a JSON file data
        /// </summary>
        /// <remarks>This Web API posts file data and manipulates it</remarks>
        /// <param name="jsonInput">JSON file data</param>
        /// <returns></returns>
        [HttpPost]
        [Route("PostFileData")]
        [Consumes("application/json")]
        public async Task<IActionResult> PostFileData([FromBody] string jsonInput)
        {
            await ProcessInputData(jsonInput);

            return Ok("Updated file created successfully.");
        }

        private async Task ProcessInputData(string jsonInput)
        {
            if (string.IsNullOrWhiteSpace(jsonInput))
            {
                jsonInput = await DataBuilderService.LoadDataFromPreviousAPIs();
            }

            var outputData = await DataBuilderService.GetSystemTypeData(jsonInput);

            DataBuilderService.CreateJsonFile(outputData);
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
            //await PostFileData("");

            var filePath = Directory.GetCurrentDirectory() + "\\InputFromAPI_3.json";

            if (!System.IO.File.Exists(filePath))
            {
                return BadRequest("The data is missing or broken. Please run the PostFileData funtion in order to get the data ready.");
            }

            var inputFromApi3 = System.IO.File.ReadAllText(filePath);

            return Ok(inputFromApi3);
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
            var inputFromApi3 = DataBuilderService.GetDataBySystemType(systemType).Result;

            if (inputFromApi3 == string.Empty)
            {
                return BadRequest("Sytem type not found.");
            }

            return Ok(inputFromApi3);
        }
     }
}
