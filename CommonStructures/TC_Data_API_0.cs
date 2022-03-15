using Newtonsoft.Json;

namespace CommonStructures
{

    public class TC_Data_API_0
    {
        [JsonProperty(Order = 1)]
        public string RecallNumber { get; set; }
        [JsonProperty(Order = 2)]
        public string ManufactureName { get; set; }
        [JsonProperty(Order = 3)]
        public string MakeName { get; set; }
        [JsonProperty(Order = 4)]
        public string ModelName { get; set; }
        [JsonProperty(Order = 5)]
        public string RecallYear { get; set; }
    }
}