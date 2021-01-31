using System.Data.Entity;
using Models.Entities;

namespace DataLayer
{
    public class HomeContext : DbContext
    {
        public HomeContext() : base("DbConnection") { }
        
        public DbSet<ArticleCommon> ArticleCommonTable { get; set; }
        
        public DbSet<ArticleFirstType> ArticleFirstTypeTable { get; set; }
        
        public DbSet<ArticleSecondType> ArticleSecondTypeTable { get; set; }
    }
}