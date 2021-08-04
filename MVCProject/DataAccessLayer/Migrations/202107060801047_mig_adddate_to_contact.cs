namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_adddate_to_contact : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contacts", "ContactDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Contacts", "dateTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Contacts", "dateTime", c => c.DateTime(nullable: false));
            DropColumn("dbo.Contacts", "ContactDate");
        }
    }
}
