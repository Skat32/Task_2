using System;

namespace Models.Entities
{
    public class ArticleFirstType
    {
        public Guid Id { get; set; }

        public string ArticleFirstTypeProperty { get; set; }

        public ArticleCommon ArticleCommon { get; set; }
    }
}