namespace Simaira.Template.AzureFunction.Service
{
    using System;

    public interface IAppConfiguration
    {
        string Environment { get; }

        SecretSource SecretSource { get; }

        string KeyVaultName { get; }

        string KeyVaultSecretName { get; }

        string ServicePrincipalId { get; }

        string ServicePrincipalSecret { get; }

        Uri CosmosDatabaseEndpointUrl { get; }

        string CosmosDatabaseAuthorizationKey { get; }

        string CosmosDatabaseId { get; }

        string ApplicationInsightsInstrumentationKey { get; }

        string RedisConnectionString { get; }

        bool UseCache { get; }

        int RetryCount { get; }

        int CachePageSize { get; }

        string HealthCheckAuthenticationToken { get; }
    }
}
