using Newtonsoft.Json;

namespace CommonStructures
{
     public class TC_Data_API_2 : TC_Data_API_1
     {
        [JsonProperty(Order = 7)]
        public string CategoryETXT { get; set; }
        [JsonProperty(Order = 8)]
        public string CategoryFTXT { get; set; }
     }
}