using System.Collections.Generic;
using Newtonsoft.Json;

namespace BringApi.Net
{
    public class BringTrackingConsignment
    {
        [JsonProperty("consignmentId")]
        public string ConsignmentId { get; set; }
        
        [JsonProperty("previousConsignmentId")]
        public string PreviousConsignmentId { get; set; }

        [JsonProperty("packageSet")]
        public IEnumerable<BringPackage> PackageSet { get; set; } 

        [JsonProperty("senderName")]
        public string SenderName { get; set; }

        [JsonProperty("senderAddress")]
        public BringAddress SenderAddress { get; set; }

        [JsonProperty("recipientHandlingAddress")]
        public BringAddress RecipientHandlingAddress { get; set; }

        [JsonProperty("senderReference")]
        public string SenderReference { get; set; }

        [JsonProperty("totalWeightInKgs")]
        public decimal TotalWeightInKgs { get; set; }

        [JsonProperty("totalVolumeInDm3")]
        public decimal TotalVolumeInDm3 { get; set; }
    }
}
