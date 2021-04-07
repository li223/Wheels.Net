using Newtonsoft.Json;

namespace Wheels.Net.Objects
{
    internal class RequestResult
    {
        [JsonProperty("Success")]
        public bool IsSuccess { get; private set; }

        [JsonProperty("Message")]
        public string Message { get; private set; }
    }
}
