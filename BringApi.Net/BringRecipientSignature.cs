using Newtonsoft.Json;

namespace BringApi.Net
{
    public class BringRecipientSignature
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("linkToImage")]
        public string LinkToImage { get; set; }
    }
}
