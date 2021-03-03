using Microsoft.Azure.WebJobs.Hosting;
using Simaira.Template.AzureFunction.Service;

#pragma warning disable S1200

[assembly: WebJobsStartup(typeof(Startup))]

namespace Simaira.Template.AzureFunction.Service
{
    using System;
    using System.Collections.Generic;
    using Microsoft.Azure.WebJobs;
    using Microsoft.Azure.WebJobs.Hosting;
    using Microsoft.Extensions.DependencyInjection;
    using Simaira.Template.AzureFunction.Service.Api.Common;
    using Simaira.Template.AzureFunction.Service.Cache;
    using StackExchange.Redis;
    using Swashbuckle.AspNetCore.AzureFunctions.Extensions;
    using Swashbuckle.AspNetCore.Swagger;

    public class Startup : IWebJobsStartup
    {
        public void Configure(IWebJobsBuilder builder)
        {
            if (builder != null)
            {
                ConfigureSwagger(builder.Services);
                RegisterServices(builder.Services);
            }
        }

        private void RegisterServices(IServiceCollection services)
        {
            services.AddSingleton<IAppConfiguration, AppConfiguration>();
            services.AddScoped<IUserAuthorization, UserAuthorization>();
            services.AddSingleton<IMemoryCacheManager, MemoryCacheManager>();
            var config = services.BuildServiceProvider().GetRequiredService<IAppConfiguration>();
            if (config.UseCache)
            {
                services.AddSingleton<IConnectionMultiplexer>(ConnectionMultiplexer.Connect(config.RedisConnectionString));
            }
            else
            {
                services.AddSingleton<IConnectionMultiplexer, FakeMultiplexer>();
            }

            services.AddSingleton<IRedisCacheManager, RedisCacheManager>();
        }

        private void ConfigureSwagger(IServiceCollection services)
        {
            var functionAssembly = typeof(Startup).Assembly;
            services.AddAzureFunctionsApiProvider(functionAssembly);

            var info = new Info
            {
                Title = "SimairaDigital AzureFunction API",
                Version = "1.0.0",
                Description = "SimairaDigital AzureFunction API",
                Contact = new Contact
                {
                    Name = "First Crazy Developer",
                },
            };

            // Add Swagger Configuration
            services.AddSwaggerGen(
                options =>
                {
                    // SwaggerDoc - API
                    options.SwaggerDoc("v1.0.0", info);

                    // Add Enums to Swagger as String
                    options.DescribeAllEnumsAsStrings();
                    options.EnableAnnotations();

                    // Swagger 2.+ support
                    var security = new Dictionary<string, IEnumerable<string>>
                    {
                        { "Bearer", Array.Empty<string>() },
                    };

                    options.AddSecurityDefinition(
                        "Bearer",
                        new ApiKeyScheme { Description = "Add authorization header using the JWT-Token (Bearer)", Name = "Authorization", In = "header", Type = "apiKey" });

                    options.AddSecurityRequirement(security);
                });
        }
    }
}

#pragma warning restore S1200
