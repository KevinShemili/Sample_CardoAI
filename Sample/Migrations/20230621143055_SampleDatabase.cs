using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sample.Migrations
{
    /// <inheritdoc />
    public partial class SampleDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    LoadStatusId = table.Column<int>(type: "int", nullable: false),
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
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Loans");
        }
    }
}
