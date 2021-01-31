using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Entities
{
    public class ArticleFirstType
    {
        [Key]
        [ForeignKey("ArticleCommon")]
        public int Id { get; set; }

        public string ArticleFirstTypeProperty { get; set; }

        public ArticleCommon ArticleCommon { get; set; }
    }
}