namespace LAB4_5_6.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateCourseCategory : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        name = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Place = c.String(nullable: false, maxLength: 255),
                        Datetime = c.DateTime(nullable: false),
                        CategoryId = c.Byte(nullable: false),
                        Lectuer_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.Lectuer_Id)
                .Index(t => t.CategoryId)
                .Index(t => t.Lectuer_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "Lectuer_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Courses", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Courses", new[] { "Lectuer_Id" });
            DropIndex("dbo.Courses", new[] { "CategoryId" });
            DropTable("dbo.Courses");
            DropTable("dbo.Categories");
        }
    }
}
