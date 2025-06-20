using System.IO;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace MyBlobTriggerFunctionApp
{
    public class BlobTriggerFunction
    {
        private readonly ILogger _logger;

        public BlobTriggerFunction(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<BlobTriggerFunction>();
        }

        [Function("BlobTriggerFunction")]
        public void Run([BlobTrigger("samples-workitems/{name}", Connection = "AzureWebJobsStorage")] Stream blobStream, string name)
        {
            _logger.LogInformation($"Blob trigger function processed blob\n Name: {name} \n Size: {blobStream.Length} Bytes");
        }
    }
}