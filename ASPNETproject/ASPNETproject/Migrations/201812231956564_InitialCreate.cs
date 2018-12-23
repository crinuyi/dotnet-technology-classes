namespace ASPNETproject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Classifications",
                c => new
                    {
                        ClassificationID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ClassificationID);
            
            CreateTable(
                "dbo.Figures",
                c => new
                    {
                        FigureID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Scale = c.String(),
                        ReleaseDate = c.DateTime(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Classification_ClassificationID = c.Int(),
                        Series_SeriesID = c.Int(),
                    })
                .PrimaryKey(t => t.FigureID)
                .ForeignKey("dbo.Classifications", t => t.Classification_ClassificationID)
                .ForeignKey("dbo.Series", t => t.Series_SeriesID)
                .Index(t => t.Classification_ClassificationID)
                .Index(t => t.Series_SeriesID);
            
            CreateTable(
                "dbo.Materials",
                c => new
                    {
                        MaterialID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Figure_FigureID = c.Int(),
                    })
                .PrimaryKey(t => t.MaterialID)
                .ForeignKey("dbo.Figures", t => t.Figure_FigureID)
                .Index(t => t.Figure_FigureID);
            
            CreateTable(
                "dbo.Producents",
                c => new
                    {
                        ProducentID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Figure_FigureID = c.Int(),
                    })
                .PrimaryKey(t => t.ProducentID)
                .ForeignKey("dbo.Figures", t => t.Figure_FigureID)
                .Index(t => t.Figure_FigureID);
            
            CreateTable(
                "dbo.Series",
                c => new
                    {
                        SeriesID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.SeriesID);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.Figures", "Series_SeriesID", "dbo.Series");
            DropForeignKey("dbo.Producents", "Figure_FigureID", "dbo.Figures");
            DropForeignKey("dbo.Materials", "Figure_FigureID", "dbo.Figures");
            DropForeignKey("dbo.Figures", "Classification_ClassificationID", "dbo.Classifications");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.Producents", new[] { "Figure_FigureID" });
            DropIndex("dbo.Materials", new[] { "Figure_FigureID" });
            DropIndex("dbo.Figures", new[] { "Series_SeriesID" });
            DropIndex("dbo.Figures", new[] { "Classification_ClassificationID" });
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.Series");
            DropTable("dbo.Producents");
            DropTable("dbo.Materials");
            DropTable("dbo.Figures");
            DropTable("dbo.Classifications");
        }
    }
}
