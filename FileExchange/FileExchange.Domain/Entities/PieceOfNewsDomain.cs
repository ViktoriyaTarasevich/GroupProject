using System;

using FileExchange.Domain.Abstract;


namespace FileExchange.Domain.Entities
{
    public class PieceOfNewsDomain : IntBaseEntity
    {
        public string Header { get; set; }

        public string Body { get; set; }

        public string ImagePath { get; set; }

        public DateTime DatePublished { get; set; }
    }
}