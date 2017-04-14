namespace Magazine.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addednameforstoreentity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Store", "Name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Store", "Name");
        }
    }
}
