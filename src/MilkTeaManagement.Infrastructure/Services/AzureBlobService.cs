using Azure.Storage;
using Azure.Storage.Blobs;
using MilkTeaManagement.Application.Common.Interfaces;
using MilkTeaManagement.Application.Common.Models.Files;
using MilkTeaManagement.Infrastructure.Configurations;

namespace MilkTeaManagement.Infrastructure.Services
{
    public class AzureBlobService : IAzureBlobService
    {
        private readonly AzureBlobStorage _azureBlobStorage;
        private readonly BlobContainerClient _filesContainer;

        public AzureBlobService(AzureBlobStorage azureBlobStorage)
        {
            _azureBlobStorage = azureBlobStorage;

            var credential = new StorageSharedKeyCredential(_azureBlobStorage.StorageAccount, _azureBlobStorage.Key);
            var blobUri = $"https://{_azureBlobStorage.StorageAccount}.blob.core.windows.net/{_azureBlobStorage.ContainerName}";
            var blobServiceClient = new BlobServiceClient(new Uri(blobUri), credential);
            _filesContainer = blobServiceClient.GetBlobContainerClient(_azureBlobStorage.ContainerName);
        }

        public async Task<List<BlobDto>> ListAsync()
        {
            List<BlobDto> files = new List<BlobDto>();

            await foreach (var file in _filesContainer.GetBlobsAsync())
            {
                string uri = _filesContainer.Uri.ToString();
                var name = file.Name;
                var fullUri = $"{uri}/{name}";

                files.Add(new BlobDto
                {
                    Uri = fullUri,
                    Name = name,
                    ContentType = file.Properties.ContentType
                });
            }

            return files;
        }

        public async Task<BlobResponseDto> UploadAsync(string filePath)
        {
            try
            {
                BlobResponseDto response = new();

                string fileName = Path.GetFileName(filePath);
                BlobClient client = _filesContainer.GetBlobClient(fileName);

                if (await client.ExistsAsync())
                {
                    response.Status = $"File {fileName} Uploaded Successfully";
                    response.Error = false;
                    response.Blob.Uri = client.Uri.ToString();
                    response.Blob.Name = fileName;
                }
                else
                {
                    using (FileStream fileStream = File.OpenRead(filePath))
                    {
                        await client.UploadAsync(fileStream, true);
                    }

                    response.Status = $"File {fileName} Uploaded Successfully";
                    response.Error = false;
                    response.Blob.Uri = client.Uri.ToString();
                    response.Blob.Name = fileName;
                }

                return response;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error: {ex.Message}");
            }
        }

        public async Task<BlobDto?> DownloadAsync(string blobFilename)
        {
            BlobClient file = _filesContainer.GetBlobClient(blobFilename);

            if (await file.ExistsAsync())
            {
                var data = await file.OpenReadAsync();
                Stream blobContent = data;

                var content = await file.DownloadContentAsync();

                string name = blobFilename;
                string contentType = content.Value.Details.ContentType;

                return new BlobDto { Content = blobContent, Name = name, ContentType = contentType };
            }

            return null;
        }

        public async Task<BlobResponseDto> DeleteAsync(string blobFilename)
        {
            BlobClient file = _filesContainer.GetBlobClient(blobFilename);

            await file.DeleteIfExistsAsync();

            return new BlobResponseDto { Error = false, Status = $"File: {blobFilename} has been successfully deleted" };
        }
    }
}
