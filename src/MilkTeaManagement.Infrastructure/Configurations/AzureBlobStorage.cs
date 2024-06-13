namespace MilkTeaManagement.Infrastructure.Configurations
{
    public class AzureBlobStorage
    {
        public string StorageAccount { get; set; }

        public string Key { get; set; }

        public string ConnectionString { get; set; }

        public string ContainerName { get; set; }
    }
}
