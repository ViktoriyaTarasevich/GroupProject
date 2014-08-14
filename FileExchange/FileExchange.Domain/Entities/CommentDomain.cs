using FileExchange.Domain.Abstract;


namespace FileExchange.Domain.Entities
{
    public class CommentDomain : IntBaseEntity
    {
        public string Body { get; set; }

        // TODO: Rename field?
        public FileDomain File { get; set; }
    }
}