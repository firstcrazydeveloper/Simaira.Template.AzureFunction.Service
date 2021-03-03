namespace Simaira.Template.AzureFunction.Service.Cache
{
    using System.Globalization;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;

    public class CacheManager
    {
        private static readonly MD5 _md5 = MD5.Create();

        public string GenerateCacheKey(string cacheName, params object[] args)
        {
            if (args != null && args.Length > 0)
            {
                const string separator = "_";
                string cacheKey = cacheName;
                return args.Aggregate(cacheKey, (current, param) => current + (separator + ((param is string) ? CalculateMD5Hash(param.ToString()) : param)));
            }
            else
            {
                return cacheName;
            }
        }

        private string CalculateMD5Hash(string input)
        {
            // step 1, calculate MD5 hash from input
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = _md5.ComputeHash(inputBytes);

            // step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2", CultureInfo.InvariantCulture));
            }

            return sb.ToString();
        }
    }
}
