namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ArticleCommons",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ArticleTitle = c.String(),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ArticleFirstTypes",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        ArticleFirstTypeProperty = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ArticleCommons", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.ArticleSecondTypes",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        ArticleSecondTypeProperty = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ArticleCommons", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ArticleSecondTypes", "Id", "dbo.ArticleCommons");
            DropForeignKey("dbo.ArticleFirstTypes", "Id", "dbo.ArticleCommons");
            DropIndex("dbo.ArticleSecondTypes", new[] { "Id" });
            DropIndex("dbo.ArticleFirstTypes", new[] { "Id" });
            DropTable("dbo.ArticleSecondTypes");
            DropTable("dbo.ArticleFirstTypes");
            DropTable("dbo.ArticleCommons");
        }
    }
}
