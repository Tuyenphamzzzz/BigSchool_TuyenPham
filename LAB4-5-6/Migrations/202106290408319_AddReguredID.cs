namespace LAB4_5_6.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddReguredID : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "LecturerId", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Courses", "LecturerId");
        }
    }
}
