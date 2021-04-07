using Newtonsoft.Json;

namespace Wheels.Net.Objects
{
    internal class DefaultPostBody
    {
        [JsonProperty("Token")]
        public string Token { get; set; }

        [JsonProperty("Source")]
        public string Source { get; set; }
    }
}
