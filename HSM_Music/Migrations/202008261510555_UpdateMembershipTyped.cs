namespace HSM_Music.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMembershipTyped : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET   Name = 'Pay as You GO', DiscountRate = 0, DurationInMonths = 0,  SignUpFee = 0  WHERE Id = 0");
            Sql("UPDATE MembershipTypes SET  Name = 'Monthly', DiscountRate = 10, DurationInMonths = 1, SignUpFee = 30  WHERE Id = 1");
            Sql("UPDATE MembershipTypes SET  Name = 'Quartly', DiscountRate = 15,  DurationInMonths = 3, SignUpFee = 90  WHERE Id = 2");
            Sql("UPDATE MembershipTypes SET Name = 'Yearly', DiscountRate = 20,  DurationInMonths = 12, SignUpFee = 300  WHERE Id = 3");

        }

        public override void Down()
        {
        }
    }
}
