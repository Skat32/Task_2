using System.Data.Entity;
using Models.Entities;

namespace DataLayer
{
    public class HomeContext : DbContext
    {
        public HomeContext() : base("DbConnection") { }

        public virtual DbSet<ArticleCommon> ArticleCommonTable { get; set; }

        public virtual DbSet<ArticleFirstType> ArticleFirstTypeTable { get; set; }

        public virtual DbSet<ArticleSecondType> ArticleSecondTypeTable { get; set; }
    }
}