using MilkTeaManagement.Application.Common.Models.Files;

namespace MilkTeaManagement.Application.Common.Interfaces
{
    public interface IAzureBlobService
    {
        public Task<List<BlobDto>> ListAsync();

        public Task<BlobResponseDto> UploadAsync(string filePath);

        public Task<BlobDto?> DownloadAsync(string blobFilename);

        public Task<BlobResponseDto> DeleteAsync(string blobFilename);
    }
}
