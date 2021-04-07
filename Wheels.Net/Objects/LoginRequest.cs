using Newtonsoft.Json;

namespace Wheels.Net.Objects
{
    internal class LoginRequest
    {
        [JsonProperty("UserName")]
        public string UserName { get; set; }

        [JsonProperty("Password")]
        public string Password { get; set; }

        [JsonProperty("Encrypted")]
        public bool IsEncrypted => false;

        [JsonProperty("Source")]
        public string Source { get; set; }
    }
}
