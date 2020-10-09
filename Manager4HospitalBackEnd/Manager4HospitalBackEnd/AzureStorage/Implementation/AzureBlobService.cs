using Azure.Storage.Blobs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Manager4HospitalBackEnd.AzureStorage
{
    public class AzureBlobService : IAzureBlobService
    {
        private readonly string _connectionString;
        private readonly string _containerName;

        public AzureBlobService(string connectionString, string containerName)
        {
            _connectionString = connectionString;
            _containerName = containerName;
        }

        public string Download(string blobName)
        {
            var blobStorage = new BlobServiceClient(_connectionString);
            var blobContainer = blobStorage.GetBlobContainerClient(_containerName);
            var blob = blobContainer.GetBlobClient(blobName);

            using (var ms = new MemoryStream())
            {
                blob.DownloadTo(ms);
                return Convert.ToBase64String(ms.ToArray());
            }
        }

        //TODO: Implementation
        public void Upliad(string flie)
        {
            throw new NotImplementedException();
        }
    }
}
