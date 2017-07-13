namespace Rahbaran_Andishe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class step2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Forms", "OtherfieldsCategory_Id", "dbo.OtherfieldsCategories");
            DropIndex("dbo.Forms", new[] { "OtherfieldsCategory_Id" });
            RenameColumn(table: "dbo.Forms", name: "OtherfieldsCategory_Id", newName: "OtherfieldID");
            AlterColumn("dbo.Forms", "OtherfieldID", c => c.Int(nullable: false));
            CreateIndex("dbo.Forms", "OtherfieldID");
            AddForeignKey("dbo.Forms", "OtherfieldID", "dbo.OtherfieldsCategories", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Forms", "OtherfieldID", "dbo.OtherfieldsCategories");
            DropIndex("dbo.Forms", new[] { "OtherfieldID" });
            AlterColumn("dbo.Forms", "OtherfieldID", c => c.Int());
            RenameColumn(table: "dbo.Forms", name: "OtherfieldID", newName: "OtherfieldsCategory_Id");
            CreateIndex("dbo.Forms", "OtherfieldsCategory_Id");
            AddForeignKey("dbo.Forms", "OtherfieldsCategory_Id", "dbo.OtherfieldsCategories", "Id");
        }
    }
}
