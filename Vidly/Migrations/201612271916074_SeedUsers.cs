namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'14c408a2-067b-4e75-8195-1c8e875b4a7f', N'guest@vidly.com', 0, N'AI64Jpq8zj8ictTF9adllSpwlrkTwFVlYYSYSc+DxOnktgJuaul2IqHSupTbZLBdYQ==', N'6dccb01c-1931-4e6f-9585-b7762d03c7f8', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'75cd6d2e-7f57-4d4e-a6cd-42ff85daa822', N'admin@vidly.com', 0, N'AFj0R5oq7blOkltrkZqlHPXa7MRE1Eqre1jozTwm4RvHKeCspsfWYPXlUDkrS1EGMw==', N'b1acd37e-1ec7-4674-8c58-89c00a7d44bf', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'e9cf23bd-efc8-47fd-bbef-5f0c5c1e9bac', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'75cd6d2e-7f57-4d4e-a6cd-42ff85daa822', N'e9cf23bd-efc8-47fd-bbef-5f0c5c1e9bac')

");
        }
        
        public override void Down()
        {
        }
    }
}
