namespace TestV1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initV1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BookDetails",
                c => new
                    {
                        BID = c.Int(nullable: false, identity: true),
                        SID = c.Int(nullable: false),
                        Title = c.String(),
                        Price = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.BID)
                .ForeignKey("dbo.StudentMasters", t => t.SID, cascadeDelete: true)
                .Index(t => t.SID);
            
            CreateTable(
                "dbo.StudentMasters",
                c => new
                    {
                        SID = c.Int(nullable: false, identity: true),
                        SName = c.String(nullable: false),
                        SAge = c.Int(),
                        SDate = c.DateTime(),
                        SPhoto = c.String(),
                    })
                .PrimaryKey(t => t.SID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BookDetails", "SID", "dbo.StudentMasters");
            DropIndex("dbo.BookDetails", new[] { "SID" });
            DropTable("dbo.StudentMasters");
            DropTable("dbo.BookDetails");
        }
    }
}
