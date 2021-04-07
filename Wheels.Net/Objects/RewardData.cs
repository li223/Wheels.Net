using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Wheels.Net.Objects
{
    public class RewardData : WheelsResponseBase
    {
        [JsonProperty("PolicyRenewalDiscount")]
        public decimal PolicyRenewalDiscount { get; private set; }

        [JsonProperty("PredictedQuarterlyDiscount")]
        public decimal PredictedQuarterlyDiscount { get; private set; }

        [JsonProperty("MaximumYearlyReward")]
        public decimal MaximumYearlyReward { get; private set; }

        [JsonProperty("MaximumQuarterlyReward")]
        public decimal MaximumQuarterlyReward { get; private set; }

        [JsonProperty("CurrentQuarterEndDate")]
        public DateTime CurrentQuarterEndDate { get; private set; }

        [JsonProperty("DiscountAmount")]
        public int DiscountAmount { get; private set; }

        [JsonProperty("DiscountPercentage")]
        public int DiscountPercentage { get; private set; }

        [JsonProperty("MaximumReward")]
        public int MaximumReward { get; private set; }

        [JsonProperty("Rewards")]
        public IEnumerable<Reward> Rewards { get; private set; }
    }
}
