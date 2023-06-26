using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sample.Migrations
{
    /// <inheritdoc />
    public partial class migration1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LenderTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2(7)", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2(7)", nullable: false),
                    IsPredefined = table.Column<bool>(type: "bit", nullable: false),
                    LocalizationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LenderTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LoanStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2(7)", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2(7)", nullable: false),
                    IsPredefined = table.Column<bool>(type: "bit", nullable: false),
                    LocalizationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoanStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lenders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    TenantId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2(7)", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2(7)", nullable: false),
                    LenderTypeId = table.Column<int>(type: "int", nullable: false),
                    CodiceSoggetoEnte = table.Column<int>(type: "int", maxLength: 50, nullable: true),
                    FundManagerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lenders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lenders_LenderTypes_LenderTypeId",
                        column: x => x.LenderTypeId,
                        principalTable: "LenderTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LenderTypeLocalizations",
                columns: table => new
                {
                    LocalizationId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    CultureId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LenderTypeLocalizations", x => x.LocalizationId);
                    table.ForeignKey(
                        name: "FK_LenderTypeLocalizations_LenderTypes_LocalizationId",
                        column: x => x.LocalizationId,
                        principalTable: "LenderTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LoanStatusLocalizations",
                columns: table => new
                {
                    LocalizationId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    CultureId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    TenantId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoanStatusLocalizations", x => x.LocalizationId);
                    table.ForeignKey(
                        name: "FK_LoanStatusLocalizations_LoanStatuses_LocalizationId",
                        column: x => x.LocalizationId,
                        principalTable: "LoanStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Loans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestedAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FinancedAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DisbursedAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    OutstandingAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AmortizationPeriod = table.Column<int>(type: "int", nullable: false),
                    PreAmortizationPeriod = table.Column<int>(type: "int", nullable: false),
                    BrokerageFee = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    APR = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    LenderId = table.Column<int>(type: "int", nullable: false),
                    LoanStatusId = table.Column<int>(type: "int", nullable: false),
                    FDGGuaranteeId = table.Column<int>(type: "int", nullable: true),
                    StatusChangingTime = table.Column<DateTime>(type: "datetime2(7)", nullable: false),
                    StatusUpdateUserId = table.Column<int>(type: "int", nullable: true),
                    TenantId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InitialExpenses = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    RemainingPreAmortizationPeriod = table.Column<int>(type: "int", nullable: false),
                    DateDisbursed = table.Column<DateTime>(type: "datetime2(7)", nullable: true),
                    UpdatedById = table.Column<int>(type: "int", nullable: true),
                    CreatedById = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Loans_Lenders_LenderId",
                        column: x => x.LenderId,
                        principalTable: "Lenders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Loans_LoanStatuses_LoanStatusId",
                        column: x => x.LoanStatusId,
                        principalTable: "LoanStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lenders_LenderTypeId",
                table: "Lenders",
                column: "LenderTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Loans_LenderId",
                table: "Loans",
                column: "LenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Loans_LoanStatusId",
                table: "Loans",
                column: "LoanStatusId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LenderTypeLocalizations");

            migrationBuilder.DropTable(
                name: "Loans");

            migrationBuilder.DropTable(
                name: "LoanStatusLocalizations");

            migrationBuilder.DropTable(
                name: "Lenders");

            migrationBuilder.DropTable(
                name: "LoanStatuses");

            migrationBuilder.DropTable(
                name: "LenderTypes");
        }
    }
}
