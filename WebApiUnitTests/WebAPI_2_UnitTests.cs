using Newtonsoft.Json;
using NUnit.Framework;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CommonStructures;
using System.Text.Json;

namespace WebApiUnitTests
{
     public class WebAPI_2_UnitTests
     {
          [SetUp]
          public void Setup()
          {
          }

          [Test]
          public void TestPostFile()
          {
               string jsonData = File.ReadAllText("CSCompVehicleRecallStart.json");
               TC_Data[] tcOriginalDataArray = JsonConvert.DeserializeObject<TC_Data[]>(jsonData);
               var client = new HttpClient();
               client.PostAsync("http://127.0.0.1:5002/WebAPI/V1/PostFileData", new StringContent(jsonData, Encoding.UTF8, "application/json"));
               Assert.Pass();
          }

          [Test]
          public void TestGetFile()
          {
               Assert.Pass();
          }

          [Test]
          public void TestSearch()
          {
               Assert.Pass();
          }
     }
}