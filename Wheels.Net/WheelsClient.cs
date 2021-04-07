using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Wheels.Net.Objects;

namespace Wheels.Net
{
    public class WheelsClient
    {
        private const string BaseUrl = "https://mtsw-api.trakglobal.co.uk/api/driver";
        private HttpClient HttpClient { get; }
        private string UserName { get; }
        private string Password { get; }
        private string Source { get; }
        private StringContent DefaultPostBodyContent { get; set; }

        /// <summary>
        /// Creates a new instance of the client
        /// </summary>
        /// <param name="email">Your email you use to login.</param>
        /// <param name="password">Your password you use to login.</param>
        /// <param name="source">Source of the request, defaults to android.</param>
        public WheelsClient(string email, string password, string source = "Android 2.0.5.77")
        {
            this.UserName = email;
            this.Password = password;
            this.Source = source;
            this.HttpClient = new HttpClient();
            this.LoginAsync().ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Logs into the client using the default username and password passed into the constructor
        /// </summary>
        /// <returns></returns>
        private async Task<UserData> LoginAsync()
        {
            var res = await this.HttpClient.PostAsync(new Uri($"{BaseUrl}/login"), new StringContent(
                JsonConvert.SerializeObject(new LoginRequest()
                {
                    UserName = this.UserName,
                    Password = this.Password,
                    Source = this.Source
                }), Encoding.UTF8, "application/json"));

            var content = await res.Content.ReadAsStringAsync().ConfigureAwait(false);
            var data = JsonConvert.DeserializeObject<UserData>(content);

            this.DefaultPostBodyContent = new StringContent(JsonConvert.SerializeObject(new DefaultPostBody()
            {
                Source = this.Source,
                Token = data.LoginToken
            }), Encoding.UTF8, "application/json");
            return data;
        }

        /// <summary>
        /// Get policy rewards data
        /// </summary>
        /// <returns></returns>
        public async Task<RewardData> GetRewardDataAsync()
        {
            var res = await this.HttpClient.PostAsync(new Uri($"{BaseUrl}/GetRewards"), this.DefaultPostBodyContent);
            var content = await res.Content.ReadAsStringAsync().ConfigureAwait(false);
            return JsonConvert.DeserializeObject<RewardData>(content);
        }

        /// <summary>
        /// Get a list of recent journey scores
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Journey>> GetJourneysAsync()
        {
            var res = await this.HttpClient.PostAsync(new Uri($"{BaseUrl}/GetJourneys"), this.DefaultPostBodyContent);
            var content = await res.Content.ReadAsStringAsync().ConfigureAwait(false);
            return JsonConvert.DeserializeObject<IEnumerable<Journey>>(content);
        }

        /// <summary>
        /// Get a list of policy scores for each period
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<PolicyScore>> GetPolicyScoresAsync()
        {
            var res = await this.HttpClient.PostAsync(new Uri($"{BaseUrl}/GetPolicyScores"), this.DefaultPostBodyContent);
            var content = await res.Content.ReadAsStringAsync().ConfigureAwait(false);
            return JsonConvert.DeserializeObject<IEnumerable<PolicyScore>>(JObject.Parse(content)["Scores"].ToString());
        }

        /// <summary>
        /// Get current mileage data
        /// </summary>
        /// <returns></returns>
        public async Task<Mileage> GetMileageAsync()
        {
            var res = await this.HttpClient.PostAsync(new Uri($"{BaseUrl}/GetMileage"), this.DefaultPostBodyContent);
            var content = await res.Content.ReadAsStringAsync().ConfigureAwait(false);
            return JsonConvert.DeserializeObject<Mileage>(content);
        }
    }
}
