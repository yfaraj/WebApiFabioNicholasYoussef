using Newtonsoft.Json;

namespace CommonStructures
{
     public class TC_Data_API_4 : TC_Data_API_3
     {
        [JsonProperty(Order = 11)]
        public string notificationType { get; set; }
     }
}