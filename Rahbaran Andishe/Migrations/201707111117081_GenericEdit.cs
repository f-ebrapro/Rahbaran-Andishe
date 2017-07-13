namespace Rahbaran_Andishe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GenericEdit : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Forms", "Generic", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Forms", "Generic", c => c.Boolean(nullable: false));
        }
    }
}
