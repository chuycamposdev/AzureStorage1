using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureBlobStorage.AzureStorage
{
    public class AzureBlob
    {
        private readonly string _connectionKey;
        private readonly string _container;

        public AzureBlob()
        {
           
        }

        public async Task<Stream> DownloadBlob(string blobName)
        {
            var blobClient = CreateBlobClient(blobName);
            using (MemoryStream memoryStream = new MemoryStream())
            {
                await blobClient.DownloadToAsync(memoryStream);
                return memoryStream;
            }
        }

        public async Task<BlobContentInfo> UploadBlob(Stream Content, string BlobName)
        {
            var blobClient = CreateBlobClient(BlobName);
            return await blobClient.UploadAsync(Content, true);
        }

        private BlobClient CreateBlobClient(string blobName)
        {
            var serviceClient = new BlobServiceClient(_connectionKey);
            var containerClient = serviceClient.GetBlobContainerClient(_container);
            var blobClient = containerClient.GetBlobClient(blobName);
            return blobClient;
        }
    }
}
