using Newtonsoft.Json;

namespace CommonStructures
{
    public class TC_Data
    {
        [JsonProperty(Order = 1)]
        public string RecallNumber { get; set; } = string.Empty;
        [JsonProperty(Order = 2)]
        public string ManufactureName { get; set; } = string.Empty;
        [JsonProperty(Order = 3)]
        public string MakeName { get; set; } = string.Empty;
        [JsonProperty(Order = 4)]
        public string ModelName { get; set; } = string.Empty;
        [JsonProperty(Order = 5)]
        public string RecallYear { get; set; } = string.Empty;
        [JsonProperty(Order = 6)]
        public string ManufacturerRecallNumber { get; set; } = string.Empty;
        [JsonProperty(Order = 7)]
        public string CategoryETXT { get; set; } = string.Empty;
        [JsonProperty(Order = 8)]
        public string CategoryFTXT { get; set; } = string.Empty;
        [JsonProperty(Order = 9)]
        public string SystemTypeETXT { get; set; } = string.Empty;
        [JsonProperty(Order = 10)]
        public string SystemTypeFTXT { get; set; } = string.Empty;
        [JsonProperty(Order = 11)]
        public string NotificationTypeETXT { get; set; } = string.Empty;
        [JsonProperty(Order = 12)]
        public string NotificationTypeFTXT { get; set; } = string.Empty;
    }
}