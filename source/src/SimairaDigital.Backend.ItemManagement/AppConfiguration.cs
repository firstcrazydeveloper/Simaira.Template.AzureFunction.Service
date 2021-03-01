using System;
using System.Runtime.CompilerServices;

[assembly: CLSCompliant(false)]
[assembly: InternalsVisibleTo("SimairaDigital.Backend.ItemManagement.Tests")]

namespace SimairaDigital.Backend.ItemManagement
{
    using System;

    internal class AppConfiguration : IAppConfiguration
    {
        public string Environment => throw new NotImplementedException();

        public SecretSource SecretSource => throw new NotImplementedException();

        public string KeyVaultName => throw new NotImplementedException();

        public string KeyVaultSecretName => throw new NotImplementedException();

        public string ServicePrincipalId => throw new NotImplementedException();

        public string ServicePrincipalSecret => throw new NotImplementedException();

        public Uri CosmosDatabaseEndpointUrl => throw new NotImplementedException();

        public string CosmosDatabaseAuthorizationKey => throw new NotImplementedException();

        public string CosmosDatabaseId => throw new NotImplementedException();

        public string ApplicationInsightsInstrumentationKey => throw new NotImplementedException();

        public string HealthCheckAuthenticationToken => throw new NotImplementedException();

        public string RedisConnectionString
        {
            get
            {
                return $"simairarediscache.redis.cache.windows.net:6380,password=bWH3dAjXVwFGfHtrblI96V5RjYJA98mk6xnnKzwFm00=,ssl=True,abortConnect=False";
            }
        }

        public bool UseCache => true;

        public int RetryCount => 5;

        public int CachePageSize => 10;
    }
}
