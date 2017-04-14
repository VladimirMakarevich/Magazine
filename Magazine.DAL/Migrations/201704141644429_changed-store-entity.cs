namespace Magazine.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedstoreentity : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Store", "StartWorkTime", c => c.Double(nullable: false));
            AlterColumn("dbo.Store", "EndWorkTime", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Store", "EndWorkTime", c => c.Int(nullable: false));
            AlterColumn("dbo.Store", "StartWorkTime", c => c.Int(nullable: false));
        }
    }
}
