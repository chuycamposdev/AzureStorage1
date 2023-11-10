using AzureBlobStorage.AzureStorage;
using AzureBlobStorage.Models;
using AzureBlobStorage.Utils;

namespace AzureBlobStorage.Services
{
    public class AzureBlobService
    {
        private readonly AzureBlob _azureBlob;

        public AzureBlobService(AzureBlobOptions azureBlob)
        {
            _azureBlob = azureBlob; 
        }

        public async Task UploadBlob(BlobModel model)
        {
            var stream = BlobUtils.GetStreamFromContentBase64(model.ContentBase64);
            await _azureBlob.UploadBlob(stream, model.BlobName);
        }
    }
}
