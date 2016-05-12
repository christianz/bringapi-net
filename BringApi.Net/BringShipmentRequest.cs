using System;
using Newtonsoft.Json;

namespace BringApi.Net
{
    public class BringShipmentRequest
    {
        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("weightInGrams")]
        public int WeightInGrams { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("length")]
        public int Length { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("date")]
        public DateTime? Date { get; set; }

        [JsonProperty("time")]
        public DateTime? Time { get; set; }

        [JsonProperty("clientUrl")]
        public string ClientUrl => BringConfiguration.GetClientUrl();

        [JsonProperty("edi")]
        public bool? Edi { get; set; }

        [JsonProperty("postingAtPostOffice")]
        public bool? PostingAtPostOffice { get; set; }

        [JsonProperty("additional")]
        public string Additional { get; set; }

        [JsonProperty("priceAdjustments")]
        public string PriceAdjustments { get; set; }

        [JsonProperty("pid")]
        public string Pid { get; set; }

        [JsonProperty("product")]
        public string Product { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("volumeSpecial")]
        public bool? VolumeSpecial { get; set; }
    }
}
