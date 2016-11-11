namespace SuggestionBox1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SuggestionModels", "UserName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.SuggestionModels", "UserName");
        }
    }
}
