namespace _24Hours.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstUpdate : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Like", "UserId", "dbo.User");
            DropIndex("dbo.Like", new[] { "UserId" });
            RenameColumn(table: "dbo.Like", name: "UserId", newName: "Liker_UserId");
            AddColumn("dbo.Like", "PostId", c => c.Int(nullable: false));
            AlterColumn("dbo.Like", "Liker_UserId", c => c.Guid());
            CreateIndex("dbo.Like", "PostId");
            CreateIndex("dbo.Like", "Liker_UserId");
            AddForeignKey("dbo.Like", "PostId", "dbo.Post", "PostId", cascadeDelete: true);
            AddForeignKey("dbo.Like", "Liker_UserId", "dbo.User", "UserId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Like", "Liker_UserId", "dbo.User");
            DropForeignKey("dbo.Like", "PostId", "dbo.Post");
            DropIndex("dbo.Like", new[] { "Liker_UserId" });
            DropIndex("dbo.Like", new[] { "PostId" });
            AlterColumn("dbo.Like", "Liker_UserId", c => c.Guid(nullable: false));
            DropColumn("dbo.Like", "PostId");
            RenameColumn(table: "dbo.Like", name: "Liker_UserId", newName: "UserId");
            CreateIndex("dbo.Like", "UserId");
            AddForeignKey("dbo.Like", "UserId", "dbo.User", "UserId", cascadeDelete: true);
        }
    }
}
