using Newtonsoft.Json;

namespace CommonStructures
{
    public class TC_Data_API_1 : TC_Data_API_0
    {
        [JsonProperty(Order = 6)]
        public string ManufacturerRecallNumber { get; set; }
    }
}