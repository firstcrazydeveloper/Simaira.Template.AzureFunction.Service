namespace SimairaDigital.Backend.ItemManagement.Api.Common
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Newtonsoft.Json;

    public class Token
    {
        private const string SuperRole = "DSP-Core-SuperAdmin";
        private const string InternalServiceRole = "DSP-Core-InternalServiceAccess";

        public string AuthorizationHeader { get; set; }

        [JsonProperty("oid")]
        public string UserOid { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        public bool IsSuperAdmin => Roles.Contains(SuperRole);

        public bool IsInternalService => Roles.Contains(InternalServiceRole);

        [JsonProperty("roles")]
        public IList<string> Roles { get; } = new List<string>();

        public static Token GetToken(string authorizationHeaderValue)
        {
            if (string.IsNullOrWhiteSpace(authorizationHeaderValue))
            {
                throw new ArgumentNullException(nameof(authorizationHeaderValue));
            }

            // see here: https://stackoverflow.com/questions/26353710/how-to-achieve-base64-url-safe-encoding-in-c
            var parts = authorizationHeaderValue
                .Substring(7)
                .Split('.');

            var saveString = parts[1].Replace('_', '/').Replace('-', '+');
            switch (parts[1].Length % 4)
            {
                case 2:
                    {
                        saveString += "==";
                        break;
                    }

                case 3:
                    {
                        saveString += "=";
                        break;
                    }
            }

            var bytes = Convert.FromBase64String(saveString);
            var str = Encoding.ASCII.GetString(bytes);
            var token = JsonConvert.DeserializeObject<Token>(str);
            token.AuthorizationHeader = authorizationHeaderValue;

            return token;
        }
    }
}
