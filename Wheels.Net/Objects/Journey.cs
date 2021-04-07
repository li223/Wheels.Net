using Newtonsoft.Json;
using System;

namespace Wheels.Net.Objects
{
    public class Journey
    {
        [JsonProperty("Id")]
        public ulong Id { get; private set; }

        [JsonProperty("JourneyFirstDate")]
        public DateTime StartDate { get; private set; }

        [JsonProperty("StartDateStr")]
        public string StartDateString { get; private set; }

        [JsonProperty("JourneyLastDate")]
        public DateTime EndDate { get; private set; }

        [JsonProperty("EndDateStr")]
        public string EndDateString { get; private set; }

        [JsonProperty("SpeedScore")]
        public decimal SpeedScore { get; private set; }

        [JsonProperty("SmoothScore")]
        public decimal SmoothnessScore { get; private set; }

        [JsonProperty("UsageScore")]
        public decimal UsageScore { get; private set; }

        [JsonProperty("OverallScore")]
        public decimal OverallScore { get; private set; }

        [JsonProperty("SIMNumber")]
        public ulong SimNumber { get; private set; }

        [JsonProperty("Miles")]
        public decimal Miles { get; private set; }

        [JsonProperty("JourneyNo")]
        public int JourneyNumber { get; private set; }
    }
}
