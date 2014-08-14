using System;
using System.Collections.Generic;

using FileExchange.Domain.Abstract;


namespace FileExchange.Domain.Entities
{
    public class FileDomain : IntBaseEntity
    {
        public string Name { get; set; }

        public DateTime DateUploaded { get; set; }

        public long Size { get; set; }

        public string Description { get; set; }

        public ICollection<TagDomain> Tags { get; set; }

        public ICollection<CommentDomain> Comments { get; set; }

        public UserDomain Owner { get; set; }
    }
}