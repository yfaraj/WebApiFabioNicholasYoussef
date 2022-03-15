using Newtonsoft.Json;

namespace CommonStructures
{

    public class TC_Data_API_0
    {
        [JsonProperty(Order = 1)]
        public string recallNumber { get; set; }
        [JsonProperty(Order = 2)]
        public string manufactureName { get; set; }
        [JsonProperty(Order = 3)]
        public string makeName { get; set; }
        [JsonProperty(Order = 4)]
        public string modelName { get; set; }
        [JsonProperty(Order = 5)]
        public string recallYear { get; set; }
    }
}