namespace MvcTripLog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Trips",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        TravelDate = c.DateTime(nullable: false),
                        Region = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TripDate = c.String(),
                        Attraction = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Trips");
        }
    }
}
