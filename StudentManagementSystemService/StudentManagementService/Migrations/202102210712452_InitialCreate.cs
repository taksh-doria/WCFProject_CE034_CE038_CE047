namespace MovieRatingSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Student_Id = c.Int(nullable: false, identity: true),
                        Student_Name = c.String(nullable: false),
                        Student_Branch = c.String(nullable: false),
                        Student_CPI = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Student_Id);
            
            CreateTable(
                "dbo.SystemUsers",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        User_Name = c.String(nullable: false),
                        User_Password = c.String(nullable: false),
                        User_Designation = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.UserId);
            
            CreateTable(
                "dbo.User_Rating",
                c => new
                    {
                        User_Rarting_Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        MovieName = c.String(nullable: false),
                        User_Provided_Rating = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.User_Rarting_Id)
                .ForeignKey("dbo.SystemUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.User_Rating", "UserId", "dbo.SystemUsers");
            DropIndex("dbo.User_Rating", new[] { "UserId" });
            DropTable("dbo.User_Rating");
            DropTable("dbo.SystemUsers");
            DropTable("dbo.Students");
        }
    }
}
