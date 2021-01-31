using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Entities
{
    public class ArticleSecondType
    {
        [Key]
        [ForeignKey("ArticleCommon")]
        public int Id { get; set; }

        public string ArticleSecondTypeProperty { get; set; }

        public ArticleCommon ArticleCommon { get; set; }
    }
}