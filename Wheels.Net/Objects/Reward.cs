using Newtonsoft.Json;
using System;

namespace Wheels.Net.Objects
{
    public class Reward
    {
        [JsonProperty("Quarter")]
        public int Quarter { get; private set; }

        [JsonProperty("Date")]
        public DateTime Date { get; private set; }

        [JsonProperty("Amount")]
        public int Amount { get; private set; }

        [JsonProperty("CurrentPolicyYear")]
        public int CurrentPolicyYear { get; private set; }
    }
}
