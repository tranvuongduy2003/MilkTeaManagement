namespace MilkTeaManagement.Application.Common.Models.Files
{
    public class BlobDto
    {
        public string? Uri { get; set; }
        public string? Name { get; set; }
        public string? ContentType { get; set; }
        public Stream? Content { get; set; }
        public long Size { get; set; }
    }
}
