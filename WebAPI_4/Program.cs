using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
/*Added by Nicholas Luong*/ using System.Net.Http;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI_4
{
     public class Program
     {
          public static void Main(string[] args)
          {     
               CreateHostBuilder(args).Build().Run();
          }

          //GetRequest Added by Nicholas Luong
          async static void GetRequest(string url)
          {
               using (HttpClient client = new HttpClient())
               {
                    using (httpResponseMessage response = await client.GetAsync("www.google.ca"))
                    {
                         using(httpContent content = response.Content)
                         {
                              string mycontent = await content.ReadAsStringAsync();
                              httpContentHeaders header = content.Headers;
                              Console.WriteLine(header);
                         }
                    }
               }
          }

          //PostRequest Added by Nicholas Luong
          async static void PostRequest(string url)
          {
               IEnumerable<KeyValuePair<string,string> > queries = new List<KeyValuePair<string,string>>()
               {
                    new KeyValuePair<string,string>("query1", "Recall"),
                    new KeyValuePair<string,string>("query1", "Notification")
               };
               HttpContent q = new FormUrlEncodedContent(queries);
               using (HttpClient client = new HttpClient())
               {
                    using (httpResponseMessage response = await client.PostAsync(url, q))
                    {
                         using(httpContent content = response.Content)
                         {
                              string mycontent = await content.ReadAsStringAsync();
                              httpContentHeaders header = content.Headers;
                              
                              Console.WriteLine(mycontent);
                         }
                    }
               }
          }

          public static IHostBuilder CreateHostBuilder(string[] args) =>
              Host.CreateDefaultBuilder(args)
                  .ConfigureWebHostDefaults(webBuilder =>
                  {
                       webBuilder.UseStartup<Startup>();
                  });
     }
}
