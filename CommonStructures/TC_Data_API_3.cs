using Newtonsoft.Json;

namespace CommonStructures
{
    public class TC_Data_API_3 : TC_Data_API_2
    {
        [JsonProperty(Order = 9)]
        public string SystemTypeETXT { get; set; }
        [JsonProperty(Order = 10)]
        public string SystemTypeFTXT { get; set; }
    }
}