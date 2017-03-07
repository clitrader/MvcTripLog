namespace MvcTripLog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _201703062238537_initial : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Trips", "TravelDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Trips", "TravelTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Trips", "TravelTime", c => c.DateTime(nullable: false));
            DropColumn("dbo.Trips", "TravelDate");
        }
    }
}
