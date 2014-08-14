using System.Collections.Generic;

using FileExchange.Domain.Abstract;


namespace FileExchange.Domain.Entities
{
    public class TagDomain : IntBaseEntity
    {
        public string Name { get; set; }

        public ICollection<FileDomain> RelatedFiles { get; set; }
    }
}