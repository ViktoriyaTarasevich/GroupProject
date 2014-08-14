using FileExchange.Domain.Abstract;


namespace FileExchange.Domain.Entities
{
    public class UserRestrictionsConfigDomain : IntBaseEntity
    {
        public int DownloadRateLimit { get; set; }

        public long StorageLimit  { get; set; }

        public long MaxUploadedFileSize { get; set; }
    }
}