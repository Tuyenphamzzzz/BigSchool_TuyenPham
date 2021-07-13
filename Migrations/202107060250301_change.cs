namespace LAB4_5_6.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class change : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Courses", "Lectuer_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Courses", new[] { "Lectuer_Id" });
            DropColumn("dbo.Courses", "LecturerId");
            RenameColumn(table: "dbo.Courses", name: "Lectuer_Id", newName: "LecturerId");
            AlterColumn("dbo.Courses", "LecturerId", c => c.String(nullable: true, maxLength: 128));
            AlterColumn("dbo.Courses", "LecturerId", c => c.String(nullable: true, maxLength: 128));
            CreateIndex("dbo.Courses", "LecturerId");
            AddForeignKey("dbo.Courses", "LecturerId", "dbo.AspNetUsers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "LecturerId", "dbo.AspNetUsers");
            DropIndex("dbo.Courses", new[] { "LecturerId" });
            AlterColumn("dbo.Courses", "LecturerId", c => c.String(maxLength: 128));
            AlterColumn("dbo.Courses", "LecturerId", c => c.String(nullable: false));
            RenameColumn(table: "dbo.Courses", name: "LecturerId", newName: "Lectuer_Id");
            AddColumn("dbo.Courses", "LecturerId", c => c.String(nullable: false));
            CreateIndex("dbo.Courses", "Lectuer_Id");
            AddForeignKey("dbo.Courses", "Lectuer_Id", "dbo.AspNetUsers", "Id");
        }
    }
}
