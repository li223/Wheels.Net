using Newtonsoft.Json;
using System;

namespace Wheels.Net.Objects
{
    public class PolicyScore
    {
        [JsonProperty("Period")]
        public int Period { get; private set; }

        [JsonProperty("StartScore")]
        public decimal StartScore { get; private set; }

        [JsonProperty("DiscountPercentage")]
        public decimal DiscountPercentage { get; private set; }

        [JsonProperty("DiscountCash")]
        public decimal DiscountCash { get; private set; }

        [JsonProperty("SmoothScore")]
        public decimal SmoothnessScore { get; private set; }

        [JsonProperty("SpeedScore")]
        public decimal SpeedScore { get; private set; }

        [JsonProperty("UsageScore")]
        public decimal UsageScore { get; private set; }

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
