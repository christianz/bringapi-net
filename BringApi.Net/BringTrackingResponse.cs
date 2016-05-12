using System.Collections.Generic;
using Newtonsoft.Json;

namespace BringApi.Net
{
    public class BringTrackingResponse
    {
        [JsonProperty("consignmentSet")]
        public IEnumerable<BringTrackingConsignment> ConsignmentSet { get; set; }
    }
}
