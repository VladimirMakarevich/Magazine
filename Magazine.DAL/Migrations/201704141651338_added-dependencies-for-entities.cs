namespace Magazine.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addeddependenciesforentities : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Item", "StoreId", c => c.Int(nullable: false));
            CreateIndex("dbo.Item", "StoreId");
            AddForeignKey("dbo.Item", "StoreId", "dbo.Store", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Item", "StoreId", "dbo.Store");
            DropIndex("dbo.Item", new[] { "StoreId" });
            DropColumn("dbo.Item", "StoreId");
        }
    }
}
