using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ERCOFAS.Infrastructure.Migrations
{
    public partial class initialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Page",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PageName = table.Column<string>(maxLength: 150, nullable: false),
                    Description = table.Column<string>(maxLength: 250, nullable: false),
                    UrlPath = table.Column<string>(maxLength: 150, nullable: false),
                    ParentMenu = table.Column<int>(maxLength: 50, nullable: true),
                    Icon = table.Column<string>(maxLength: 50, nullable: true),
                    Order = table.Column<int>(nullable: false),
                    IsParent = table.Column<bool>(nullable: true),
                    IsVisible = table.Column<bool>(nullable: false),
                    AccessibleByAll = table.Column<bool>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Page", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PageAccess",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PageId = table.Column<int>(nullable: false),
                    RoleId = table.Column<int>(nullable: false),
                    CanCreate = table.Column<bool>(nullable: false),
                    CanRead = table.Column<bool>(nullable: false),
                    CanUpdate = table.Column<bool>(nullable: false),
                    CanDelete = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<int>(nullable: true),
                    DateUpdated = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PageAccess", x => new { x.Id, x.PageId, x.RoleId });
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(maxLength: 150, nullable: false),
                    Description = table.Column<string>(maxLength: 250, nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<int>(nullable: true),
                    DateUpdated = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(maxLength: 200, nullable: false),
                    EmailAddress = table.Column<string>(maxLength: 150, nullable: false),
                    PhoneNumber = table.Column<string>(maxLength: 100, nullable: false),
                    MobileNumber = table.Column<string>(maxLength: 100, nullable: false),
                    Address = table.Column<string>(maxLength: 350, nullable: false),
                    AboutUs = table.Column<string>(nullable: true),
                    Website = table.Column<string>(maxLength: 150, nullable: true),
                    ERNumberPrefix = table.Column<string>(maxLength: 25, nullable: false),
                    SMTPFromEmail = table.Column<string>(maxLength: 150, nullable: false),
                    SMTPFromName = table.Column<string>(maxLength: 200, nullable: false),
                    SMTPUsername = table.Column<string>(maxLength: 150, nullable: false),
                    SMTPPassword = table.Column<string>(maxLength: 150, nullable: false),
                    SMTPServerName = table.Column<string>(maxLength: 100, nullable: false),
                    SMTPPort = table.Column<int>(nullable: false),
                    EnableSSL = table.Column<bool>(nullable: true),
                    OTPAPIKey = table.Column<string>(maxLength: 150, nullable: false),
                    OTPClientID = table.Column<string>(maxLength: 150, nullable: false),
                    OTPUsername = table.Column<string>(maxLength: 150, nullable: true),
                    OTPPassword = table.Column<string>(maxLength: 150, nullable: true),
                    MinPasswordLength = table.Column<int>(nullable: false),
                    MinSpecialCharacters = table.Column<int>(nullable: false),
                    MaxSignOnAttempts = table.Column<int>(nullable: false),
                    EnforcePasswordHistory = table.Column<int>(nullable: false),
                    ActivationLinkExpiresIn = table.Column<int>(maxLength: 150, nullable: true),
                    BaseUrl = table.Column<string>(maxLength: 150, nullable: true),
                    CreatedBy = table.Column<int>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<int>(nullable: true),
                    DateUpdated = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserRole",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    RoleId = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<int>(nullable: true),
                    DateUpdated = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRole", x => new { x.Id, x.UserId, x.RoleId });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Page");

            migrationBuilder.DropTable(
                name: "PageAccess");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "Settings");

            migrationBuilder.DropTable(
                name: "UserRole");
        }
    }
}
