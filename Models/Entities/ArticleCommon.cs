using System;

namespace Models.Entities
{
    public class ArticleCommon
    {
        public Guid Id { get; set; }

        public string ArticleTitle { get; set; }

        public string Type { get; set; }

        public ArticleFirstType ArticleFirstType { get; set; }

        public ArticleSecondType ArticleSecondType { get; set; }
    }
}