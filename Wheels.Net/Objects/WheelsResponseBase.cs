using Newtonsoft.Json;

namespace Wheels.Net.Objects
{
    public class WheelsResponseBase
    {
        [JsonProperty("RequestResult")]
        internal RequestResult RequestResult { get; private set; }
    }
}
