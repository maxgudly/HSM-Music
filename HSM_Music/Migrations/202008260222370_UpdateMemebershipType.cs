namespace HSM_Music.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMemebershipType : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET   Name = 'Pay as You GO', DiscountRate = 0, SignUpFee = 0, DurationInMonths = 0");
            Sql("UPDATE MembershipTypes SET  Name = 'Monthly', DiscountRate = 10, SignUpFee = 30, DurationInMonths = 1");
            Sql("UPDATE MembershipTypes SET  Name = 'Quartly', DiscountRate = 15, SignUpFee = 0, DurationInMonths = 3");
            Sql("UPDATE MembershipTypes SET Name = 'Yearly', DiscountRate = 20, SignUpFee = 0, DurationInMonths = 12");
        }
        
        public override void Down()
        {
        }
    }
}
