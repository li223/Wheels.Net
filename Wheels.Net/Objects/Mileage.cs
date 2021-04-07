using Newtonsoft.Json;
using System;

namespace Wheels.Net.Objects
{
    public class Mileage : WheelsResponseBase
    {

        [JsonProperty("AllowanceStart")]
        public DateTime AllowanceStart { get; private set; }

        [JsonProperty("AllowanceEnd")]
        public DateTime AllowanceEnd { get; private set; }

        [JsonProperty("MillageAllowance")]
        public int MillageAllowance { get; private set; }

        [JsonProperty("MillageUsed")]
        public int MillageUsed { get; private set; }

        [JsonProperty("MillagePredicted")]
        public int MillagePredicted { get; private set; }

        [JsonProperty("MillageRemaining")]
        public int MillageRemaining { get; private set; }

        [JsonProperty("MillageExcess")]
        public int MillageExcess { get; private set; }

        [JsonProperty("MillageUsedPerc")]
        public int MillageUsedPercentage { get; private set; }

        [JsonProperty("MillageRemainingPerc")]
        public int MillageRemainingPercentage { get; private set; }

        [JsonProperty("MillageExcessPerc")]
        public int MillageExcessPercentage { get; private set; }
    }
}
