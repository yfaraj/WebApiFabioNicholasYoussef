using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace WebAPI_4.Controllers
{
    [Route("WebAPI/v{version:apiVersion}")]
    [ApiController]
    [ApiVersion("1.0")]
    public class WebApiController : ControllerBase
    {
        private readonly ILogger<WebApiController> _logger;
        //private readonly IHttpClientFactory _clientFactory;

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
            ///*Pseudo Code:
            // * */
            //List<TC_Data_API_4> tcApiDataList = new List<TC_Data_API_4>();
            //foreach (var Recall_Number in jsonData)
            //{
            //    string notificationETXT = "";
            //    string motificationFTXT = "";
            //    string Input_Data = Read_TC_Input_File_JSON_Data(jsonData);

            //    string NotificationType = Call_TC_API(Recall_Number);
            //    string baseAddress = "//https://data.tc.gc.ca/v1.3/api/eng/vehicle-recall-database/recall-summary/recall-number/";

            //    var client3 = new RestClient(baseAddress);
            //    var request = new RestRequest(baseAddress, Method.Get);
            //    request.AddHeader("Content-Type", "application/json");
            //    var body = @"" + "\n" + @"";
            //    request.AddParameter("application/json", body, ParameterType.RequestBody);
            //    var response = await client3.ExecuteGetAsync(request);
            //    TC_Data_Online tcDataOnline = JsonConvert.DeserializeObject<TC_Data_Online>(response.Content);

            //    foreach (var resultSet in tcDataOnline.ResultSet)
            //    {
            //        bool notificationNumberNumFound = false;
            //        int year = 0;
            //        string currentNotificationETXT = "";
            //        string currentNotificationFTXT = "";

            //        bool atLeastFoundOne = false;
            //        foreach (var resultSetItem in resultSet)
            //        {
            //            if (resultSetItem.Name == "RECALL_NUMBER_NUM")
            //            {
            //                if (resultSetItem.Value.Literal == rN)
            //                {
            //                    atLeastFoundOne = notificationNumberNumFound = true;
            //                }
            //            }
            //            if (resultSetItem.Name == "NOTOFICATION_ETXT")
            //            {
            //                currentNotificationETXT = resultSetItem.Value.Literal;
            //            }
            //            if (resultSetItem.Name == "MOTIFICATION_FTXT")
            //            {
            //                currentNotificationFTXT = resultSetItem.Value.Literal;
            //            }

            //        }
            //        if (notificationNumberNumFound)
            //        {
            //            if (year != 0)
            //            {
            //                if (year > maxYear)
            //                {
            //                    maxYear = year;
            //                    notificationETXT = currentNotificaitonETXT;
            //                    notificaitonFTXT = currentNotificationFTXT;
            //                }
            //            }
            //        }
            //    }
            //    if (atLeastFoundOne)
            //    {
            //        TC_Data_API_4 tC_Data_API_4 = new TC_Data_API_4();
            //        tC_Data_API_4.NotificationETXT = notificationETXT;
            //        tC_Data_API_4.NotificationFTXT = notificationFTXT;
            //        tcApiDataList.Add(tC_Data_API_4);
            //    }
            //    else
            //    {
            //        TC_Data_API_4 tC_Data_API_4 = new TC_Data_API_4();
            //        tC_Data_API_4.CategoryETXT = "";
            //        tC_Data_API_4.CategoryFTXT = "";
            //        tcApiDataList.Add(tC_Data_API_4);
            //    }
            //}

            //string json = JsonConvert.SerializeObject(tcApiDataList);
            //string path = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            //System.IO.File.WriteAllText(path + "/output.json", json);

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
            //string path = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            //jsonFileData = System.IO.File.ReadAllText(path + "/output.json");
            //var json = JsonConvert.DeserializeObject<List<TC_Data_API_4>>(jsonFileData);

            string[] jsonFileData = { };
            return Ok(jsonFileData);

        }

        // GET WebAPI/Search
        /// <summary>
        /// Search data using the Notification Type
        /// </summary>
        /// <remarks>This Web API retrieves a JSON data resulting from querying data using the Notification Type</remarks>
        /// <param name="notificationType">Notification Type</param>
        /// <returns>JSON data</returns>
        [HttpGet]
        [Route("Search")]
        [Consumes("application/json")]
        public async Task<IActionResult> Search(string notificationType)
        {
            //string resultJsonData = "";
            //List<TC_Data_API_4> result = new List<TC_Data_API_4>();

            //string path = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            //jsonFileData = System.IO.File.ReadAllText(path + "/output.json");
            //var json = JsonConvert.DeserializeObject<List<TC_Data_API_4>>(jsonFileData);
            //foreach (TC_Data_API_4 tcDataAPI4 in json)
            //{
            //    if (tcDataAPI4.NotificationType == notificationType)
            //    {
            //        result.Add(tcDataAPI4);
            //    }
            //}
            //if (result.Count() > 0)
            //{
            //    return Ok(result);
            //}
            //else
            //{
            //    return NotFound();
            //}

            string[] jsonFileData = { };
            return Ok(jsonFileData);
        }
    }
}