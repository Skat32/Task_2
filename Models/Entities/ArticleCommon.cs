using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Entities
{
    public class ArticleCommon
    {
        [Key]
        public int Id { get; set; }

        public string ArticleTitle { get; set; }

        public string Type { get; set; }
        public ArticleFirstType ArticleFirstType { get; set; }

        public ArticleSecondType ArticleSecondType { get; set; }
    }
}