namespace Simaira.Template.AzureFunction.Service.GenerateSwaggerCli
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.IO;
    using System.Threading;
    using CommandLine;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using Newtonsoft.Json;
    using NSwag;
    using NSwag.CodeGeneration.CSharp;
    using NSwag.CodeGeneration.OperationNameGenerators;
    using Simaira.Template.AzureFunction.Service.GenerateSwaggerCli.CliOptions;
    using Swashbuckle.AspNetCore.Swagger;

    [ExcludeFromCodeCoverage]
    public static class Program
    {
        public static int Main(string[] args)
        {
            return Parser.Default.ParseArguments<GenerateSwaggerOptions, GenerateClientOptions>(args)
                .MapResult(
                    (GenerateSwaggerOptions opts) => GenerateSwaggerFile(opts),
                    (GenerateClientOptions opts) => GenerateCSharpClient(opts),
                    _ => 1);
        }

        private static int GenerateSwaggerFile(GenerateSwaggerOptions options)
        {
            try
            {
                var filePath = options.SwaggerFilePath.GetRootedPath();

                var swaggerJson = GetSwaggerJson();

                Console.WriteLine($"Start generate swagger file. OutputPath: {filePath}");
                var dirPath = Path.GetDirectoryName(filePath);

                if (!Directory.Exists(dirPath))
                {
                    Directory.CreateDirectory(dirPath);
                }

                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }

                File.WriteAllText(filePath, swaggerJson);
                return 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private static int GenerateCSharpClient(GenerateClientOptions options)
        {
            try
            {
                var swaggerJson = GetSwaggerJson();
#pragma warning disable S4462
                var document = OpenApiDocument.FromJsonAsync(swaggerJson).Result;
#pragma warning restore S4462

                var filePath = options.CsFilePath.GetRootedPath();
                Console.WriteLine($"Start generate client code with nswag. OutputPath: {filePath}");

                var settings = new CSharpClientGeneratorSettings
                {
                    GenerateClientInterfaces = true,
                    OperationNameGenerator = new SingleClientFromOperationIdOperationNameGenerator(),
                    ExceptionClass = "MetadataIntegrationServiceClientException",
                    UseHttpClientCreationMethod = true,
                    InjectHttpClient = true,
                    ClassName = "MetadataIntegrationServiceClient",
                    GenerateBaseUrlProperty = false,
                    UseBaseUrl = false,
                    ClientBaseClass = "ClientBaseClass",
                    UseHttpRequestMessageCreationMethod = true,
                    GenerateUpdateJsonSerializerSettingsMethod = true,
                    CSharpGeneratorSettings =
                    {
                        Namespace = "SimairaDigital.Backend.ItemManagement.Client",
                        InlineNamedTuples = true,
                        GenerateJsonMethods = true,
                    },
                };

                var generator = new CSharpClientGenerator(document, settings);
                var code = generator.GenerateFile();

                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }

                File.WriteAllText(filePath, code);
                return 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return -1;
            }
        }

        private static string GetSwaggerJson()
        {
            var startup = new Startup();
            var builder = new HostBuilder();
            builder.ConfigureWebJobs(b => startup.Configure(b));
            var host = builder.Build();
            string swaggerJson;
            using (host)
            {
                host.RunAsync().GetAwaiter();
                Thread.Sleep(500);
                swaggerJson = GetSwaggerJson(host);
                host.StopAsync();
            }

            return swaggerJson;
        }

        private static string GetSwaggerJson(IHost host)
        {
            var swaggerDocument = host.Services.GetService<ISwaggerProvider>().GetSwagger("v1.0.0");
            var swaggerJson = JsonConvert.SerializeObject(
                swaggerDocument,
                Formatting.Indented,
                new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore, ContractResolver = new SwaggerContractResolver(new JsonSerializerSettings()) });
            return swaggerJson;
        }
    }
}
