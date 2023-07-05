using System;
using Microsoft.EntityFrameworkCore.Migrations;
using NetTopologySuite.Geometries;

#nullable disable

namespace backend_vincent.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AnimalArchives",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AnimalArchiveType = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", maxLength: 30000, nullable: false),
                    PrimaryRace = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    SecondaryRace = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EarTag = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    AnimalGroupAmount = table.Column<int>(type: "int", nullable: false),
                    FatherEarTag = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    MotherEarTag = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimalArchives", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClaimType = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    ClaimValue = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ClaimText = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IdentificationCode = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Certifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Abbreviation = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Certifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CompanyNumber = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Street = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    StreetNumber = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    City = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", maxLength: 30000, nullable: true),
                    isFrozen = table.Column<bool>(type: "bit", nullable: false),
                    FreezeTS = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletionTS = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FK_Creator_Id = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeliveryNotes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    File = table.Column<byte[]>(type: "varbinary(max)", maxLength: 10485760, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TransactionType = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryNotes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    File = table.Column<byte[]>(type: "varbinary(max)", maxLength: 10485760, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Currency = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InvoiceCategory = table.Column<int>(type: "int", nullable: false),
                    TransactionType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Modules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PriceId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", maxLength: 30000, nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    BaseModule = table.Column<bool>(type: "bit", nullable: false),
                    Position = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modules", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NotificationTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotificationTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ResourceStocks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Unit = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResourceStocks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Species",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Species", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubscribedEmails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Seed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ts = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubscribedEmails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UnsubscribedEmails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Seed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ts = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnsubscribedEmails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleType = table.Column<int>(type: "int", nullable: false),
                    FK_Company_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoles_Companies_FK_Company_Id",
                        column: x => x.FK_Company_Id,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordSalt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FreeTrial = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Language = table.Column<int>(type: "int", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordResetCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordResetTS = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EmailVerificationSeed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailVerificationTS = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserStatus = table.Column<int>(type: "int", nullable: true),
                    ApplicationRole = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    Ts = table.Column<DateTime>(type: "datetime2", nullable: true),
                    InvitationPending = table.Column<bool>(type: "bit", nullable: true),
                    FirstLogin = table.Column<bool>(type: "bit", nullable: true),
                    FK_CreatorCompany_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FK_InvitedToCompany_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Companies_FK_CreatorCompany_Id",
                        column: x => x.FK_CreatorCompany_Id,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Companies_FK_InvitedToCompany_Id",
                        column: x => x.FK_InvitedToCompany_Id,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    State = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    City = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    FK_Company_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_Companies_FK_Company_Id",
                        column: x => x.FK_Company_Id,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AddressLine1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLine2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isActive = table.Column<bool>(type: "bit", nullable: false),
                    HeadQuarters = table.Column<bool>(type: "bit", nullable: false),
                    isFrozen = table.Column<bool>(type: "bit", nullable: false),
                    FreezeTS = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletionTS = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FK_Company_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Locations_Companies_FK_Company_Id",
                        column: x => x.FK_Company_Id,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    State = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    City = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    FK_Company_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Suppliers_Companies_FK_Company_Id",
                        column: x => x.FK_Company_Id,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", maxLength: 30000, nullable: false),
                    SendDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Interval = table.Column<int>(type: "int", nullable: false),
                    FK_Company_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FK_NotificationType_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notifications_Companies_FK_Company_Id",
                        column: x => x.FK_Company_Id,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Notifications_NotificationTypes_FK_NotificationType_Id",
                        column: x => x.FK_NotificationType_Id,
                        principalTable: "NotificationTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Unit = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FK_ResourceStock_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ingredients_ResourceStocks_FK_ResourceStock_Id",
                        column: x => x.FK_ResourceStock_Id,
                        principalTable: "ResourceStocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InternalUses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InternalUseType = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Unit = table.Column<int>(type: "int", nullable: false),
                    FK_ResourceStock_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InternalUses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InternalUses_ResourceStocks_FK_ResourceStock_Id",
                        column: x => x.FK_ResourceStock_Id,
                        principalTable: "ResourceStocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Races",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: false),
                    BreedingPurpose = table.Column<int>(type: "int", nullable: false),
                    GrowthRate = table.Column<int>(type: "int", nullable: false),
                    AverageWeightKg = table.Column<int>(type: "int", nullable: false),
                    FK_Species_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Races", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Races_Species_FK_Species_Id",
                        column: x => x.FK_Species_Id,
                        principalTable: "Species",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClaimId = table.Column<int>(type: "int", maxLength: 500, nullable: true),
                    ApplicationRoleId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetClaims_ClaimId",
                        column: x => x.ClaimId,
                        principalTable: "AspNetClaims",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_ApplicationRoleId",
                        column: x => x.ApplicationRoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FK_User_Id = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    FK_Company_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_AspNetUsers_FK_User_Id",
                        column: x => x.FK_User_Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Employees_Companies_FK_Company_Id",
                        column: x => x.FK_Company_Id,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Invitations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Seed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpirationTS = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FK_Company_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FK_Creator_Id = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    FK_Receiver_Id = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invitations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Invitations_AspNetUsers_FK_Creator_Id",
                        column: x => x.FK_Creator_Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Invitations_AspNetUsers_FK_Receiver_Id",
                        column: x => x.FK_Receiver_Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Invitations_Companies_FK_Company_Id",
                        column: x => x.FK_Company_Id,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RefreshTokens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TokenHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TokenSalt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ts = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshTokens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RefreshTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Subscriptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubscriptionId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CancelAtPeriodEnd = table.Column<bool>(type: "bit", nullable: false),
                    CurrentPeriodEnd = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    FK_User_Id = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscriptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subscriptions_AspNetUsers_FK_User_Id",
                        column: x => x.FK_User_Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DepositBoxes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", maxLength: 30000, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    FK_Customer_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepositBoxes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DepositBoxes_Customers_FK_Customer_Id",
                        column: x => x.FK_Customer_Id,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SaleType = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Unit = table.Column<int>(type: "int", nullable: false),
                    SalesDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrganicStatus = table.Column<int>(type: "int", nullable: false),
                    FK_Customer_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FK_ResourceStock_Id = table.Column<int>(type: "int", nullable: false),
                    FK_DeliveryNote_Id = table.Column<int>(type: "int", nullable: true),
                    FK_Invoice_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sales_Customers_FK_Customer_Id",
                        column: x => x.FK_Customer_Id,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Sales_DeliveryNotes_FK_DeliveryNote_Id",
                        column: x => x.FK_DeliveryNote_Id,
                        principalTable: "DeliveryNotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Sales_Invoices_FK_Invoice_Id",
                        column: x => x.FK_Invoice_Id,
                        principalTable: "Invoices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Sales_ResourceStocks_FK_ResourceStock_Id",
                        column: x => x.FK_ResourceStock_Id,
                        principalTable: "ResourceStocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Boards",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    FK_Location_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Boards_Locations_FK_Location_Id",
                        column: x => x.FK_Location_Id,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Fields",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Identifier = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GeoLocation = table.Column<Point>(type: "geography", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    FK_Location_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fields", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fields_Locations_FK_Location_Id",
                        column: x => x.FK_Location_Id,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LocationCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FK_Category_Id = table.Column<int>(type: "int", nullable: false),
                    FK_Location_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LocationCategories_Categories_FK_Category_Id",
                        column: x => x.FK_Category_Id,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LocationCategories_Locations_FK_Location_Id",
                        column: x => x.FK_Location_Id,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LocationCertifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FK_Certification_Id = table.Column<int>(type: "int", nullable: false),
                    FK_Location_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationCertifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LocationCertifications_Certifications_FK_Certification_Id",
                        column: x => x.FK_Certification_Id,
                        principalTable: "Certifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LocationCertifications_Locations_FK_Location_Id",
                        column: x => x.FK_Location_Id,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Machines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    PurchaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MachineStatus = table.Column<int>(type: "int", nullable: false),
                    FK_Location_Id = table.Column<int>(type: "int", nullable: false),
                    FK_Invoice_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Machines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Machines_Invoices_FK_Invoice_Id",
                        column: x => x.FK_Invoice_Id,
                        principalTable: "Invoices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Machines_Locations_FK_Location_Id",
                        column: x => x.FK_Location_Id,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PrimarySection = table.Column<bool>(type: "bit", nullable: false),
                    FK_Location_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sections_Locations_FK_Location_Id",
                        column: x => x.FK_Location_Id,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WildCollections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KGNr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GStkNr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CollectionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExternalArea = table.Column<bool>(type: "bit", nullable: false),
                    CollectionPlace = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Species = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Type = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    PlantPart = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    AnnualAmount = table.Column<int>(type: "int", nullable: false),
                    UsePurpose = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    LastBannedSubstanceType = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    LastBannedSubstanceUseDate = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", maxLength: 30000, nullable: false),
                    FK_Invoice_Id = table.Column<int>(type: "int", nullable: false),
                    FK_Location_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WildCollections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WildCollections_Invoices_FK_Invoice_Id",
                        column: x => x.FK_Invoice_Id,
                        principalTable: "Invoices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WildCollections_Locations_FK_Location_Id",
                        column: x => x.FK_Location_Id,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AnimalMovements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EarTag = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InventoryChangeType = table.Column<int>(type: "int", nullable: false),
                    InventoryActionType = table.Column<int>(type: "int", nullable: false),
                    CultivationMethod = table.Column<int>(type: "int", nullable: false),
                    AnimalGroupAmount = table.Column<int>(type: "int", nullable: false),
                    FK_DeliveryNote_Id = table.Column<int>(type: "int", nullable: true),
                    FK_Customer_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FK_Supplier_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FK_Invoice_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimalMovements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AnimalMovements_Customers_FK_Customer_Id",
                        column: x => x.FK_Customer_Id,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AnimalMovements_DeliveryNotes_FK_DeliveryNote_Id",
                        column: x => x.FK_DeliveryNote_Id,
                        principalTable: "DeliveryNotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AnimalMovements_Invoices_FK_Invoice_Id",
                        column: x => x.FK_Invoice_Id,
                        principalTable: "Invoices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AnimalMovements_Suppliers_FK_Supplier_Id",
                        column: x => x.FK_Supplier_Id,
                        principalTable: "Suppliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GMOCertifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", maxLength: 15000, nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    FK_Supplier_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GMOCertifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GMOCertifications_Suppliers_FK_Supplier_Id",
                        column: x => x.FK_Supplier_Id,
                        principalTable: "Suppliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CalendarEntries",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", maxLength: 30000, nullable: false),
                    Interval = table.Column<int>(type: "int", nullable: false),
                    Start = table.Column<DateTime>(type: "datetime2", nullable: false),
                    End = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AllDay = table.Column<bool>(type: "bit", nullable: false),
                    CreatorEmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalendarEntries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CalendarEntries_Employees_CreatorEmployeeId",
                        column: x => x.CreatorEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NotificationEmployeeMappings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FK_Notification_Id = table.Column<int>(type: "int", nullable: false),
                    FK_Employee_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotificationEmployeeMappings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NotificationEmployeeMappings_Employees_FK_Employee_Id",
                        column: x => x.FK_Employee_Id,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NotificationEmployeeMappings_Notifications_FK_Notification_Id",
                        column: x => x.FK_Notification_Id,
                        principalTable: "Notifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecipeType = table.Column<int>(type: "int", nullable: false),
                    Product = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", maxLength: 30000, nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Unit = table.Column<int>(type: "int", nullable: false),
                    Etiquette = table.Column<byte[]>(type: "varbinary(max)", maxLength: 10485760, nullable: true),
                    FK_Employee_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recipes_Employees_FK_Employee_Id",
                        column: x => x.FK_Employee_Id,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SubscriptionModuleMappings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CancelAtPeriodEnd = table.Column<bool>(type: "bit", nullable: false),
                    CurrentPeriodEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FK_Subscription_Id = table.Column<int>(type: "int", nullable: false),
                    FK_Module_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubscriptionModuleMappings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubscriptionModuleMappings_Modules_FK_Module_Id",
                        column: x => x.FK_Module_Id,
                        principalTable: "Modules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SubscriptionModuleMappings_Subscriptions_FK_Subscription_Id",
                        column: x => x.FK_Subscription_Id,
                        principalTable: "Subscriptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BoardEmployeeMappings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    FK_Board_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FK_Employee_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoardEmployeeMappings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BoardEmployeeMappings_Boards_FK_Board_Id",
                        column: x => x.FK_Board_Id,
                        principalTable: "Boards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BoardEmployeeMappings_Employees_FK_Employee_Id",
                        column: x => x.FK_Employee_Id,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Columns",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Position = table.Column<int>(type: "int", nullable: false),
                    FK_Board_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FK_Creator_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FK_Company_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Columns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Columns_Boards_FK_Board_Id",
                        column: x => x.FK_Board_Id,
                        principalTable: "Boards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Columns_Companies_FK_Company_Id",
                        column: x => x.FK_Company_Id,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Columns_Employees_CreatorId",
                        column: x => x.CreatorId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FieldRows",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RowNumber = table.Column<int>(type: "int", nullable: false),
                    FK_Field_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FieldRows", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FieldRows_Fields_FK_Field_Id",
                        column: x => x.FK_Field_Id,
                        principalTable: "Fields",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Harvests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CropType = table.Column<int>(type: "int", nullable: false),
                    OrganicStatus = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Unit = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsageType = table.Column<int>(type: "int", nullable: false),
                    UsageQuantity = table.Column<int>(type: "int", nullable: false),
                    FK_Field_Id = table.Column<int>(type: "int", nullable: true),
                    FK_Location_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Harvests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Harvests_Fields_FK_Field_Id",
                        column: x => x.FK_Field_Id,
                        principalTable: "Fields",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Harvests_Locations_FK_Location_Id",
                        column: x => x.FK_Location_Id,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Irrigations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IrrigationType = table.Column<int>(type: "int", nullable: false),
                    WaterVolumeL = table.Column<int>(type: "int", nullable: false),
                    WeatherConditions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DurationH = table.Column<int>(type: "int", nullable: false),
                    FK_Field_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Irrigations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Irrigations_Fields_FK_Field_Id",
                        column: x => x.FK_Field_Id,
                        principalTable: "Fields",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceType = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", maxLength: 30000, nullable: false),
                    PerformedBy = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Cost = table.Column<int>(type: "int", nullable: false),
                    NextMaintenanceDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FK_Machine_Id = table.Column<int>(type: "int", nullable: false),
                    FK_Invoice_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Services_Invoices_FK_Invoice_Id",
                        column: x => x.FK_Invoice_Id,
                        principalTable: "Invoices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Services_Machines_FK_Machine_Id",
                        column: x => x.FK_Machine_Id,
                        principalTable: "Machines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AnimalGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", maxLength: 30000, nullable: false),
                    AnimalCategory = table.Column<int>(type: "int", nullable: false),
                    FK_Section_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimalGroups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AnimalGroups_Sections_FK_Section_Id",
                        column: x => x.FK_Section_Id,
                        principalTable: "Sections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    EarTag = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Birthdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deathdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Stillbirth = table.Column<bool>(type: "bit", nullable: false),
                    OnFarm = table.Column<bool>(type: "bit", nullable: false),
                    SlaughterDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", maxLength: 30000, nullable: false),
                    FK_FatherAnimal_Id = table.Column<int>(type: "int", nullable: true),
                    FK_MotherAnimal_Id = table.Column<int>(type: "int", nullable: true),
                    FK_Section_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Animals_Animals_FK_FatherAnimal_Id",
                        column: x => x.FK_FatherAnimal_Id,
                        principalTable: "Animals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Animals_Animals_FK_MotherAnimal_Id",
                        column: x => x.FK_MotherAnimal_Id,
                        principalTable: "Animals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Animals_Sections_FK_Section_Id",
                        column: x => x.FK_Section_Id,
                        principalTable: "Sections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BoardedAnimals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnimalCategory = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    EarTag = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    EntryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExitDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OwnerSign = table.Column<byte[]>(type: "varbinary(max)", maxLength: 10485760, nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", maxLength: 30000, nullable: false),
                    FK_Customer_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FK_Section_Id = table.Column<int>(type: "int", nullable: false),
                    FK_Invoice_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoardedAnimals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BoardedAnimals_Customers_FK_Customer_Id",
                        column: x => x.FK_Customer_Id,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BoardedAnimals_Invoices_FK_Invoice_Id",
                        column: x => x.FK_Invoice_Id,
                        principalTable: "Invoices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BoardedAnimals_Sections_FK_Section_Id",
                        column: x => x.FK_Section_Id,
                        principalTable: "Sections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CleaningAndDesinfections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", maxLength: 30000, nullable: false),
                    FK_Section_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CleaningAndDesinfections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CleaningAndDesinfections_Sections_FK_Section_Id",
                        column: x => x.FK_Section_Id,
                        principalTable: "Sections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CalendarEntryEmployeeMappings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FK_CalendarEntry_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FK_Employee_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalendarEntryEmployeeMappings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CalendarEntryEmployeeMappings_CalendarEntries_FK_CalendarEntry_Id",
                        column: x => x.FK_CalendarEntry_Id,
                        principalTable: "CalendarEntries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CalendarEntryEmployeeMappings_Employees_FK_Employee_Id",
                        column: x => x.FK_Employee_Id,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Productions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", maxLength: 30000, nullable: false),
                    ProcessingStep = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    BatchNr = table.Column<int>(type: "int", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PreCleaning = table.Column<bool>(type: "bit", nullable: false),
                    PostCleaning = table.Column<bool>(type: "bit", nullable: false),
                    FK_Recipe_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Productions_Recipes_FK_Recipe_Id",
                        column: x => x.FK_Recipe_Id,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RecipeIngredientMappings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Percentage = table.Column<int>(type: "int", nullable: false),
                    FK_Recipe_Id = table.Column<int>(type: "int", nullable: false),
                    FK_Ingredient_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeIngredientMappings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RecipeIngredientMappings_Ingredients_FK_Ingredient_Id",
                        column: x => x.FK_Ingredient_Id,
                        principalTable: "Ingredients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RecipeIngredientMappings_Recipes_FK_Recipe_Id",
                        column: x => x.FK_Recipe_Id,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", maxLength: 30000, nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FromDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ToDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Completed = table.Column<bool>(type: "bit", nullable: false),
                    Position = table.Column<int>(type: "int", nullable: false),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    FK_Column_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FK_Company_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FK_Creator_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cards_Columns_FK_Column_Id",
                        column: x => x.FK_Column_Id,
                        principalTable: "Columns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cards_Companies_FK_Company_Id",
                        column: x => x.FK_Company_Id,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cards_Employees_CreatorId",
                        column: x => x.CreatorId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CropJournals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CropAction = table.Column<int>(type: "int", nullable: false),
                    SeedStatus = table.Column<int>(type: "int", nullable: false),
                    FertilizerType = table.Column<int>(type: "int", nullable: false),
                    TreatmentSubstance = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuantityPerHa = table.Column<int>(type: "int", nullable: false),
                    Unit = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FK_Field_Id = table.Column<int>(type: "int", nullable: false),
                    FK_FieldRow_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CropJournals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CropJournals_FieldRows_FK_FieldRow_Id",
                        column: x => x.FK_FieldRow_Id,
                        principalTable: "FieldRows",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CropJournals_Fields_FK_Field_Id",
                        column: x => x.FK_Field_Id,
                        principalTable: "Fields",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CropRotationPlans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Year = table.Column<int>(type: "int", nullable: false),
                    PrecedingCrop = table.Column<int>(type: "int", nullable: false),
                    PrecedingCropSeedVariety = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MainCrop = table.Column<int>(type: "int", nullable: false),
                    FollowingCrop = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", maxLength: 30000, nullable: false),
                    FK_Field_Id = table.Column<int>(type: "int", nullable: false),
                    FK_FieldRow_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CropRotationPlans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CropRotationPlans_FieldRows_FK_FieldRow_Id",
                        column: x => x.FK_FieldRow_Id,
                        principalTable: "FieldRows",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CropRotationPlans_Fields_FK_Field_Id",
                        column: x => x.FK_Field_Id,
                        principalTable: "Fields",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ResourceAccesses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResourceName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Unit = table.Column<int>(type: "int", nullable: false),
                    ResourceCategory = table.Column<int>(type: "int", nullable: false),
                    OrganicStatus = table.Column<int>(type: "int", nullable: false),
                    GMOFree = table.Column<bool>(type: "bit", nullable: false),
                    INCIName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ActiveIngredient = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FK_Invoice_Id = table.Column<int>(type: "int", nullable: true),
                    FK_Location_Id = table.Column<int>(type: "int", nullable: false),
                    FK_Supplier_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FK_Harvest_Id = table.Column<int>(type: "int", nullable: true),
                    FK_ResourceStock_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResourceAccesses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResourceAccesses_Harvests_FK_Harvest_Id",
                        column: x => x.FK_Harvest_Id,
                        principalTable: "Harvests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ResourceAccesses_Invoices_FK_Invoice_Id",
                        column: x => x.FK_Invoice_Id,
                        principalTable: "Invoices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ResourceAccesses_Locations_FK_Location_Id",
                        column: x => x.FK_Location_Id,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ResourceAccesses_ResourceStocks_FK_ResourceStock_Id",
                        column: x => x.FK_ResourceStock_Id,
                        principalTable: "ResourceStocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ResourceAccesses_Suppliers_FK_Supplier_Id",
                        column: x => x.FK_Supplier_Id,
                        principalTable: "Suppliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OutdoorLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    OutdoorAccessType = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FK_AnimalGroup_Id = table.Column<int>(type: "int", nullable: false),
                    FK_Field_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OutdoorLogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OutdoorLogs_AnimalGroups_FK_AnimalGroup_Id",
                        column: x => x.FK_AnimalGroup_Id,
                        principalTable: "AnimalGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OutdoorLogs_Fields_FK_Field_Id",
                        column: x => x.FK_Field_Id,
                        principalTable: "Fields",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AnimalGroupMappings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FK_Animal_Id = table.Column<int>(type: "int", nullable: false),
                    FK_AnimalGroup_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimalGroupMappings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AnimalGroupMappings_AnimalGroups_FK_AnimalGroup_Id",
                        column: x => x.FK_AnimalGroup_Id,
                        principalTable: "AnimalGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AnimalGroupMappings_Animals_FK_Animal_Id",
                        column: x => x.FK_Animal_Id,
                        principalTable: "Animals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AnimalRaceMappings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RaceType = table.Column<int>(type: "int", nullable: false),
                    FK_Race_Id = table.Column<int>(type: "int", nullable: false),
                    FK_Animal_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimalRaceMappings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AnimalRaceMappings_Animals_FK_Animal_Id",
                        column: x => x.FK_Animal_Id,
                        principalTable: "Animals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AnimalRaceMappings_Races_FK_Race_Id",
                        column: x => x.FK_Race_Id,
                        principalTable: "Races",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Treatments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Disease = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: false),
                    Action = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LegalWaitingPeriodDays = table.Column<int>(type: "int", nullable: false),
                    DoubleWaitingPeriodDays = table.Column<int>(type: "int", nullable: false),
                    FourtyEightHourDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FK_Invoice_Id = table.Column<int>(type: "int", nullable: true),
                    FK_Animal_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Treatments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Treatments_Animals_FK_Animal_Id",
                        column: x => x.FK_Animal_Id,
                        principalTable: "Animals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Treatments_Invoices_FK_Invoice_Id",
                        column: x => x.FK_Invoice_Id,
                        principalTable: "Invoices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CleaningAndDesinfectionResourceAccessMappings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Unit = table.Column<int>(type: "int", nullable: false),
                    FK_ResourceStock_Id = table.Column<int>(type: "int", nullable: false),
                    FK_CleaningAndDesinfection_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CleaningAndDesinfectionResourceAccessMappings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CleaningAndDesinfectionResourceAccessMappings_CleaningAndDesinfections_FK_CleaningAndDesinfection_Id",
                        column: x => x.FK_CleaningAndDesinfection_Id,
                        principalTable: "CleaningAndDesinfections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CleaningAndDesinfectionResourceAccessMappings_ResourceStocks_FK_ResourceStock_Id",
                        column: x => x.FK_ResourceStock_Id,
                        principalTable: "ResourceStocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ChecklistItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: false),
                    Position = table.Column<int>(type: "int", nullable: false),
                    Finished = table.Column<bool>(type: "bit", nullable: false),
                    FK_Card_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChecklistItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChecklistItems_Cards_FK_Card_Id",
                        column: x => x.FK_Card_Id,
                        principalTable: "Cards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Message = table.Column<string>(type: "nvarchar(max)", maxLength: 30000, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EditedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Edited = table.Column<bool>(type: "bit", nullable: true),
                    FK_Card_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FK_Employee_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Cards_FK_Card_Id",
                        column: x => x.FK_Card_Id,
                        principalTable: "Cards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comments_Employees_FK_Employee_Id",
                        column: x => x.FK_Employee_Id,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnimalGroupMappings_FK_Animal_Id",
                table: "AnimalGroupMappings",
                column: "FK_Animal_Id");

            migrationBuilder.CreateIndex(
                name: "IX_AnimalGroupMappings_FK_AnimalGroup_Id",
                table: "AnimalGroupMappings",
                column: "FK_AnimalGroup_Id");

            migrationBuilder.CreateIndex(
                name: "IX_AnimalGroups_FK_Section_Id",
                table: "AnimalGroups",
                column: "FK_Section_Id");

            migrationBuilder.CreateIndex(
                name: "IX_AnimalMovements_FK_Customer_Id",
                table: "AnimalMovements",
                column: "FK_Customer_Id");

            migrationBuilder.CreateIndex(
                name: "IX_AnimalMovements_FK_DeliveryNote_Id",
                table: "AnimalMovements",
                column: "FK_DeliveryNote_Id");

            migrationBuilder.CreateIndex(
                name: "IX_AnimalMovements_FK_Invoice_Id",
                table: "AnimalMovements",
                column: "FK_Invoice_Id");

            migrationBuilder.CreateIndex(
                name: "IX_AnimalMovements_FK_Supplier_Id",
                table: "AnimalMovements",
                column: "FK_Supplier_Id");

            migrationBuilder.CreateIndex(
                name: "IX_AnimalRaceMappings_FK_Animal_Id",
                table: "AnimalRaceMappings",
                column: "FK_Animal_Id");

            migrationBuilder.CreateIndex(
                name: "IX_AnimalRaceMappings_FK_Race_Id",
                table: "AnimalRaceMappings",
                column: "FK_Race_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Animals_FK_FatherAnimal_Id",
                table: "Animals",
                column: "FK_FatherAnimal_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Animals_FK_MotherAnimal_Id",
                table: "Animals",
                column: "FK_MotherAnimal_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Animals_FK_Section_Id",
                table: "Animals",
                column: "FK_Section_Id");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_ApplicationRoleId",
                table: "AspNetRoleClaims",
                column: "ApplicationRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_ClaimId",
                table: "AspNetRoleClaims",
                column: "ClaimId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoles_FK_Company_Id",
                table: "AspNetRoles",
                column: "FK_Company_Id");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_FK_CreatorCompany_Id",
                table: "AspNetUsers",
                column: "FK_CreatorCompany_Id",
                unique: true,
                filter: "[FK_CreatorCompany_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_FK_InvitedToCompany_Id",
                table: "AspNetUsers",
                column: "FK_InvitedToCompany_Id");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BoardedAnimals_FK_Customer_Id",
                table: "BoardedAnimals",
                column: "FK_Customer_Id");

            migrationBuilder.CreateIndex(
                name: "IX_BoardedAnimals_FK_Invoice_Id",
                table: "BoardedAnimals",
                column: "FK_Invoice_Id");

            migrationBuilder.CreateIndex(
                name: "IX_BoardedAnimals_FK_Section_Id",
                table: "BoardedAnimals",
                column: "FK_Section_Id");

            migrationBuilder.CreateIndex(
                name: "IX_BoardEmployeeMappings_FK_Board_Id",
                table: "BoardEmployeeMappings",
                column: "FK_Board_Id");

            migrationBuilder.CreateIndex(
                name: "IX_BoardEmployeeMappings_FK_Employee_Id",
                table: "BoardEmployeeMappings",
                column: "FK_Employee_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Boards_FK_Location_Id",
                table: "Boards",
                column: "FK_Location_Id");

            migrationBuilder.CreateIndex(
                name: "IX_CalendarEntries_CreatorEmployeeId",
                table: "CalendarEntries",
                column: "CreatorEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_CalendarEntryEmployeeMappings_FK_CalendarEntry_Id",
                table: "CalendarEntryEmployeeMappings",
                column: "FK_CalendarEntry_Id");

            migrationBuilder.CreateIndex(
                name: "IX_CalendarEntryEmployeeMappings_FK_Employee_Id",
                table: "CalendarEntryEmployeeMappings",
                column: "FK_Employee_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Cards_CreatorId",
                table: "Cards",
                column: "CreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_Cards_FK_Column_Id",
                table: "Cards",
                column: "FK_Column_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Cards_FK_Company_Id",
                table: "Cards",
                column: "FK_Company_Id");

            migrationBuilder.CreateIndex(
                name: "IX_ChecklistItems_FK_Card_Id",
                table: "ChecklistItems",
                column: "FK_Card_Id");

            migrationBuilder.CreateIndex(
                name: "IX_CleaningAndDesinfectionResourceAccessMappings_FK_CleaningAndDesinfection_Id",
                table: "CleaningAndDesinfectionResourceAccessMappings",
                column: "FK_CleaningAndDesinfection_Id");

            migrationBuilder.CreateIndex(
                name: "IX_CleaningAndDesinfectionResourceAccessMappings_FK_ResourceStock_Id",
                table: "CleaningAndDesinfectionResourceAccessMappings",
                column: "FK_ResourceStock_Id");

            migrationBuilder.CreateIndex(
                name: "IX_CleaningAndDesinfections_FK_Section_Id",
                table: "CleaningAndDesinfections",
                column: "FK_Section_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Columns_CreatorId",
                table: "Columns",
                column: "CreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_Columns_FK_Board_Id",
                table: "Columns",
                column: "FK_Board_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Columns_FK_Company_Id",
                table: "Columns",
                column: "FK_Company_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_FK_Card_Id",
                table: "Comments",
                column: "FK_Card_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_FK_Employee_Id",
                table: "Comments",
                column: "FK_Employee_Id");

            migrationBuilder.CreateIndex(
                name: "IX_CropJournals_FK_Field_Id",
                table: "CropJournals",
                column: "FK_Field_Id");

            migrationBuilder.CreateIndex(
                name: "IX_CropJournals_FK_FieldRow_Id",
                table: "CropJournals",
                column: "FK_FieldRow_Id");

            migrationBuilder.CreateIndex(
                name: "IX_CropRotationPlans_FK_Field_Id",
                table: "CropRotationPlans",
                column: "FK_Field_Id");

            migrationBuilder.CreateIndex(
                name: "IX_CropRotationPlans_FK_FieldRow_Id",
                table: "CropRotationPlans",
                column: "FK_FieldRow_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_FK_Company_Id",
                table: "Customers",
                column: "FK_Company_Id");

            migrationBuilder.CreateIndex(
                name: "IX_DepositBoxes_FK_Customer_Id",
                table: "DepositBoxes",
                column: "FK_Customer_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_FK_Company_Id",
                table: "Employees",
                column: "FK_Company_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_FK_User_Id",
                table: "Employees",
                column: "FK_User_Id",
                unique: true,
                filter: "[FK_User_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_FieldRows_FK_Field_Id",
                table: "FieldRows",
                column: "FK_Field_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Fields_FK_Location_Id",
                table: "Fields",
                column: "FK_Location_Id");

            migrationBuilder.CreateIndex(
                name: "IX_GMOCertifications_FK_Supplier_Id",
                table: "GMOCertifications",
                column: "FK_Supplier_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Harvests_FK_Field_Id",
                table: "Harvests",
                column: "FK_Field_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Harvests_FK_Location_Id",
                table: "Harvests",
                column: "FK_Location_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_FK_ResourceStock_Id",
                table: "Ingredients",
                column: "FK_ResourceStock_Id");

            migrationBuilder.CreateIndex(
                name: "IX_InternalUses_FK_ResourceStock_Id",
                table: "InternalUses",
                column: "FK_ResourceStock_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Invitations_FK_Company_Id",
                table: "Invitations",
                column: "FK_Company_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Invitations_FK_Creator_Id",
                table: "Invitations",
                column: "FK_Creator_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Invitations_FK_Receiver_Id",
                table: "Invitations",
                column: "FK_Receiver_Id",
                unique: true,
                filter: "[FK_Receiver_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Irrigations_FK_Field_Id",
                table: "Irrigations",
                column: "FK_Field_Id");

            migrationBuilder.CreateIndex(
                name: "IX_LocationCategories_FK_Category_Id",
                table: "LocationCategories",
                column: "FK_Category_Id");

            migrationBuilder.CreateIndex(
                name: "IX_LocationCategories_FK_Location_Id",
                table: "LocationCategories",
                column: "FK_Location_Id");

            migrationBuilder.CreateIndex(
                name: "IX_LocationCertifications_FK_Certification_Id",
                table: "LocationCertifications",
                column: "FK_Certification_Id");

            migrationBuilder.CreateIndex(
                name: "IX_LocationCertifications_FK_Location_Id",
                table: "LocationCertifications",
                column: "FK_Location_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_FK_Company_Id",
                table: "Locations",
                column: "FK_Company_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Machines_FK_Invoice_Id",
                table: "Machines",
                column: "FK_Invoice_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Machines_FK_Location_Id",
                table: "Machines",
                column: "FK_Location_Id");

            migrationBuilder.CreateIndex(
                name: "IX_NotificationEmployeeMappings_FK_Employee_Id",
                table: "NotificationEmployeeMappings",
                column: "FK_Employee_Id");

            migrationBuilder.CreateIndex(
                name: "IX_NotificationEmployeeMappings_FK_Notification_Id",
                table: "NotificationEmployeeMappings",
                column: "FK_Notification_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_FK_Company_Id",
                table: "Notifications",
                column: "FK_Company_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_FK_NotificationType_Id",
                table: "Notifications",
                column: "FK_NotificationType_Id");

            migrationBuilder.CreateIndex(
                name: "IX_OutdoorLogs_FK_AnimalGroup_Id",
                table: "OutdoorLogs",
                column: "FK_AnimalGroup_Id");

            migrationBuilder.CreateIndex(
                name: "IX_OutdoorLogs_FK_Field_Id",
                table: "OutdoorLogs",
                column: "FK_Field_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Productions_FK_Recipe_Id",
                table: "Productions",
                column: "FK_Recipe_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Races_FK_Species_Id",
                table: "Races",
                column: "FK_Species_Id");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeIngredientMappings_FK_Ingredient_Id",
                table: "RecipeIngredientMappings",
                column: "FK_Ingredient_Id");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeIngredientMappings_FK_Recipe_Id",
                table: "RecipeIngredientMappings",
                column: "FK_Recipe_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_FK_Employee_Id",
                table: "Recipes",
                column: "FK_Employee_Id");

            migrationBuilder.CreateIndex(
                name: "IX_RefreshTokens_UserId",
                table: "RefreshTokens",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ResourceAccesses_FK_Harvest_Id",
                table: "ResourceAccesses",
                column: "FK_Harvest_Id",
                unique: true,
                filter: "[FK_Harvest_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ResourceAccesses_FK_Invoice_Id",
                table: "ResourceAccesses",
                column: "FK_Invoice_Id");

            migrationBuilder.CreateIndex(
                name: "IX_ResourceAccesses_FK_Location_Id",
                table: "ResourceAccesses",
                column: "FK_Location_Id");

            migrationBuilder.CreateIndex(
                name: "IX_ResourceAccesses_FK_ResourceStock_Id",
                table: "ResourceAccesses",
                column: "FK_ResourceStock_Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ResourceAccesses_FK_Supplier_Id",
                table: "ResourceAccesses",
                column: "FK_Supplier_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_FK_Customer_Id",
                table: "Sales",
                column: "FK_Customer_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_FK_DeliveryNote_Id",
                table: "Sales",
                column: "FK_DeliveryNote_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_FK_Invoice_Id",
                table: "Sales",
                column: "FK_Invoice_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_FK_ResourceStock_Id",
                table: "Sales",
                column: "FK_ResourceStock_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Sections_FK_Location_Id",
                table: "Sections",
                column: "FK_Location_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Services_FK_Invoice_Id",
                table: "Services",
                column: "FK_Invoice_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Services_FK_Machine_Id",
                table: "Services",
                column: "FK_Machine_Id");

            migrationBuilder.CreateIndex(
                name: "IX_SubscriptionModuleMappings_FK_Module_Id",
                table: "SubscriptionModuleMappings",
                column: "FK_Module_Id");

            migrationBuilder.CreateIndex(
                name: "IX_SubscriptionModuleMappings_FK_Subscription_Id",
                table: "SubscriptionModuleMappings",
                column: "FK_Subscription_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Subscriptions_FK_User_Id",
                table: "Subscriptions",
                column: "FK_User_Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Suppliers_FK_Company_Id",
                table: "Suppliers",
                column: "FK_Company_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Treatments_FK_Animal_Id",
                table: "Treatments",
                column: "FK_Animal_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Treatments_FK_Invoice_Id",
                table: "Treatments",
                column: "FK_Invoice_Id");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_UserId",
                table: "UserRoles",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_WildCollections_FK_Invoice_Id",
                table: "WildCollections",
                column: "FK_Invoice_Id");

            migrationBuilder.CreateIndex(
                name: "IX_WildCollections_FK_Location_Id",
                table: "WildCollections",
                column: "FK_Location_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnimalArchives");

            migrationBuilder.DropTable(
                name: "AnimalGroupMappings");

            migrationBuilder.DropTable(
                name: "AnimalMovements");

            migrationBuilder.DropTable(
                name: "AnimalRaceMappings");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "BoardedAnimals");

            migrationBuilder.DropTable(
                name: "BoardEmployeeMappings");

            migrationBuilder.DropTable(
                name: "CalendarEntryEmployeeMappings");

            migrationBuilder.DropTable(
                name: "ChecklistItems");

            migrationBuilder.DropTable(
                name: "CleaningAndDesinfectionResourceAccessMappings");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "CropJournals");

            migrationBuilder.DropTable(
                name: "CropRotationPlans");

            migrationBuilder.DropTable(
                name: "DepositBoxes");

            migrationBuilder.DropTable(
                name: "GMOCertifications");

            migrationBuilder.DropTable(
                name: "InternalUses");

            migrationBuilder.DropTable(
                name: "Invitations");

            migrationBuilder.DropTable(
                name: "Irrigations");

            migrationBuilder.DropTable(
                name: "LocationCategories");

            migrationBuilder.DropTable(
                name: "LocationCertifications");

            migrationBuilder.DropTable(
                name: "NotificationEmployeeMappings");

            migrationBuilder.DropTable(
                name: "OutdoorLogs");

            migrationBuilder.DropTable(
                name: "Productions");

            migrationBuilder.DropTable(
                name: "RecipeIngredientMappings");

            migrationBuilder.DropTable(
                name: "RefreshTokens");

            migrationBuilder.DropTable(
                name: "ResourceAccesses");

            migrationBuilder.DropTable(
                name: "Sales");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "SubscribedEmails");

            migrationBuilder.DropTable(
                name: "SubscriptionModuleMappings");

            migrationBuilder.DropTable(
                name: "Treatments");

            migrationBuilder.DropTable(
                name: "UnsubscribedEmails");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "WildCollections");

            migrationBuilder.DropTable(
                name: "Races");

            migrationBuilder.DropTable(
                name: "AspNetClaims");

            migrationBuilder.DropTable(
                name: "CalendarEntries");

            migrationBuilder.DropTable(
                name: "CleaningAndDesinfections");

            migrationBuilder.DropTable(
                name: "Cards");

            migrationBuilder.DropTable(
                name: "FieldRows");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Certifications");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "AnimalGroups");

            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DropTable(
                name: "Recipes");

            migrationBuilder.DropTable(
                name: "Harvests");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "DeliveryNotes");

            migrationBuilder.DropTable(
                name: "Machines");

            migrationBuilder.DropTable(
                name: "Modules");

            migrationBuilder.DropTable(
                name: "Subscriptions");

            migrationBuilder.DropTable(
                name: "Animals");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Species");

            migrationBuilder.DropTable(
                name: "Columns");

            migrationBuilder.DropTable(
                name: "NotificationTypes");

            migrationBuilder.DropTable(
                name: "ResourceStocks");

            migrationBuilder.DropTable(
                name: "Fields");

            migrationBuilder.DropTable(
                name: "Invoices");

            migrationBuilder.DropTable(
                name: "Sections");

            migrationBuilder.DropTable(
                name: "Boards");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Companies");
        }
    }
}
