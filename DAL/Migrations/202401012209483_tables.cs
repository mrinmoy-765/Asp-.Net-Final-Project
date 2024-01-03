namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        admin_id = c.Int(nullable: false, identity: true),
                        admin_name = c.String(nullable: false, maxLength: 100),
                        email = c.String(nullable: false),
                        password = c.String(nullable: false),
                        contact = c.String(nullable: false),
                        user_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.admin_id)
                .ForeignKey("dbo.Users", t => t.user_id, cascadeDelete: true)
                .Index(t => t.user_id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        user_id = c.Int(nullable: false, identity: true),
                        user_name = c.String(),
                        password = c.String(),
                        role = c.String(),
                    })
                .PrimaryKey(t => t.user_id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        employee_id = c.Int(nullable: false, identity: true),
                        employee_name = c.String(nullable: false, maxLength: 100),
                        email = c.String(nullable: false),
                        password = c.String(nullable: false),
                        contact = c.String(nullable: false),
                        location = c.String(nullable: false),
                        salary = c.Int(nullable: false),
                        user_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.employee_id)
                .ForeignKey("dbo.Users", t => t.user_id, cascadeDelete: true)
                .Index(t => t.user_id);
            
            CreateTable(
                "dbo.Tokens",
                c => new
                    {
                        token_id = c.Int(nullable: false, identity: true),
                        user_id = c.Int(nullable: false),
                        token_key = c.String(),
                        created = c.DateTime(nullable: false),
                        expired = c.DateTime(),
                    })
                .PrimaryKey(t => t.token_id)
                .ForeignKey("dbo.Users", t => t.user_id, cascadeDelete: true)
                .Index(t => t.user_id);
            
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        book_id = c.Int(nullable: false, identity: true),
                        book_name = c.String(nullable: false),
                        stock = c.Int(nullable: false),
                        unit_price = c.Int(nullable: false),
                        store_date = c.DateTime(nullable: false),
                        stockout_date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.book_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Admins", "user_id", "dbo.Users");
            DropForeignKey("dbo.Tokens", "user_id", "dbo.Users");
            DropForeignKey("dbo.Employees", "user_id", "dbo.Users");
            DropIndex("dbo.Tokens", new[] { "user_id" });
            DropIndex("dbo.Employees", new[] { "user_id" });
            DropIndex("dbo.Admins", new[] { "user_id" });
            DropTable("dbo.Books");
            DropTable("dbo.Tokens");
            DropTable("dbo.Employees");
            DropTable("dbo.Users");
            DropTable("dbo.Admins");
        }
    }
}
