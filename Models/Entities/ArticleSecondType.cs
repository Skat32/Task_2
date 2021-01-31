using System;

namespace Models.Entities
{
    public class ArticleSecondType
    {
        public Guid Id { get; set; }

        public string ArticleSecondTypeProperty { get; set; }
        
        public ArticleCommon ArticleCommon { get; set; }
    }
}