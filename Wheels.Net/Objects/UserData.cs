using Newtonsoft.Json;

namespace Wheels.Net.Objects
{
    public class UserData : WheelsResponseBase
    {
        [JsonProperty("CustomerRef")]
        public string CustomerReference { get; private set; }

        [JsonProperty("PolicyNumber")]
        public string PolicyNumber { get; private set; }

        [JsonProperty("FirstName")]
        public string FirstName { get; private set; }

        [JsonProperty("LastName")]
        public string LastName { get; private set; }

        [JsonIgnore]
        public string FullName => $"{this.FirstName} {this.LastName}";

        [JsonProperty("MarketingRef")]
        public string MarketingReference { get; private set; }

        [JsonProperty("Email")]
        public string Email { get; private set; }

        [JsonProperty("PasswordChangeRequired")]
        public bool IsPasswordChangeRequired { get; private set; }

        [JsonProperty("DocUploadCompleted")]
        public bool HasDocumentUploadCompleted { get; private set; }

        [JsonProperty("RestrictedUser")]
        public bool IsRestrictedUser { get; private set; }

        [JsonProperty("NCDProof")]
        public bool HasNoClaimsDiscountProof { get; private set; }

        [JsonProperty("Token")]
        protected internal string LoginToken { get; private set; }

        [JsonProperty("TopXScore")]
        public decimal TopScore { get; private set; }

        [JsonProperty("IsOldJourneyScreen")]
        public bool IsOldJourneyScreen { get; private set; }
    }
}
