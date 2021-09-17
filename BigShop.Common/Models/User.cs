namespace BigShop.Common.Models
{
    using Newtonsoft.Json;

    public class User
    {
        [JsonProperty("firstName")]
        public string FirstName;

        [JsonProperty("lastName")]
        public string LastName;

        [JsonProperty("id")]
        public string Id;

        [JsonProperty("userName")]
        public string UserName;

        [JsonProperty("normalizedUserName")]
        public string NormalizedUserName;

        [JsonProperty("email")]
        public string Email;

        [JsonProperty("normalizedEmail")]
        public string NormalizedEmail;

        [JsonProperty("emailConfirmed")]
        public bool EmailConfirmed;

        [JsonProperty("passwordHash")]
        public string PasswordHash;

        [JsonProperty("securityStamp")]
        public string SecurityStamp;

        [JsonProperty("concurrencyStamp")]
        public string ConcurrencyStamp;

        [JsonProperty("phoneNumber")]
        public string PhoneNumber;

        [JsonProperty("phoneNumberConfirmed")]
        public bool PhoneNumberConfirmed;

        [JsonProperty("twoFactorEnabled")]
        public bool TwoFactorEnabled;

        [JsonProperty("lockoutEnd")]
        public object LockoutEnd;

        [JsonProperty("lockoutEnabled")]
        public bool LockoutEnabled;

        [JsonProperty("accessFailedCount")]
        public int AccessFailedCount;
    }




}
