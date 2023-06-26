﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository.Concrete;

#nullable disable

namespace Sample.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20230626085713_migration2")]
    partial class migration2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.Lender", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CodiceSoggetoEnte")
                        .HasMaxLength(50)
                        .HasColumnType("int")
                        .HasColumnName("CodiceSoggetoEnte");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2(7)")
                        .HasColumnName("DateCreated");

                    b.Property<DateTime?>("DateUpdated")
                        .IsRequired()
                        .HasColumnType("datetime2(7)")
                        .HasColumnName("DateUpdated");

                    b.Property<int?>("FundManagerId")
                        .HasColumnType("int")
                        .HasColumnName("FundManagerId");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasColumnName("IsDeleted");

                    b.Property<int>("LenderTypeId")
                        .HasColumnType("int")
                        .HasColumnName("LenderTypeId");

                    b.Property<string>("Name")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasColumnName("Name");

                    b.Property<Guid>("TenantId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("TenantId");

                    b.HasKey("Id");

                    b.HasIndex("LenderTypeId");

                    b.ToTable("Lenders");
                });

            modelBuilder.Entity("Domain.Entities.LenderType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2(7)")
                        .HasColumnName("DateCreated");

                    b.Property<DateTime?>("DateUpdated")
                        .IsRequired()
                        .HasColumnType("datetime2(7)")
                        .HasColumnName("DateUpdated");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasColumnName("IsDeleted");

                    b.Property<bool>("IsPredefined")
                        .HasColumnType("bit")
                        .HasColumnName("IsPredefined");

                    b.HasKey("Id");

                    b.ToTable("LenderTypes");
                });

            modelBuilder.Entity("Domain.Entities.LenderTypeLocalization", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    b.Property<int>("CultureId")
                        .HasColumnType("int")
                        .HasColumnName("CultureId");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasColumnName("IsDeleted");

                    b.Property<int>("LenderTypeId")
                        .HasColumnType("int")
                        .HasColumnName("LenderTypeId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasColumnName("Name");

                    b.HasKey("Id", "CultureId");

                    b.HasIndex("LenderTypeId");

                    b.ToTable("LenderTypeLocalizations");
                });

            modelBuilder.Entity("Domain.Entities.Loan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("APR")
                        .HasColumnType("decimal(18, 4)")
                        .HasColumnName("APR");

                    b.Property<int>("AmortizationPeriod")
                        .HasColumnType("int")
                        .HasColumnName("AmortizationPeriod");

                    b.Property<decimal>("BrokerageFee")
                        .HasColumnType("decimal(18, 4)")
                        .HasColumnName("BrokerageFee");

                    b.Property<int?>("CreatedById")
                        .HasColumnType("int")
                        .HasColumnName("CreatedById");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2")
                        .HasColumnName("DateCreated");

                    b.Property<DateTime?>("DateDisbursed")
                        .HasColumnType("datetime2(7)")
                        .HasColumnName("DateDisbursed");

                    b.Property<decimal?>("DisbursedAmount")
                        .HasColumnType("decimal(18, 2)")
                        .HasColumnName("DisbursedAmount");

                    b.Property<int?>("FDGGuaranteeId")
                        .HasColumnType("int")
                        .HasColumnName("FDGGuaranteeId");

                    b.Property<decimal>("FinancedAmount")
                        .HasColumnType("decimal(18, 2)")
                        .HasColumnName("FinancedAmount");

                    b.Property<decimal>("InitialExpenses")
                        .HasColumnType("decimal(18, 4)")
                        .HasColumnName("InitialExpenses");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasColumnName("IsDeleted");

                    b.Property<int>("LenderId")
                        .HasColumnType("int")
                        .HasColumnName("LenderId");

                    b.Property<int>("LoanStatusId")
                        .HasColumnType("int")
                        .HasColumnName("LoanStatusId");

                    b.Property<decimal>("OutstandingAmount")
                        .HasColumnType("decimal(18, 2)")
                        .HasColumnName("OutstandingAmount");

                    b.Property<int>("PreAmortizationPeriod")
                        .HasColumnType("int")
                        .HasColumnName("PreAmortizationPeriod");

                    b.Property<int>("RemainingPreAmortizationPeriod")
                        .HasColumnType("int")
                        .HasColumnName("RemainingPreAmortizationPeriod");

                    b.Property<decimal>("RequestedAmount")
                        .HasColumnType("decimal(18, 2)")
                        .HasColumnName("RequestedAmount");

                    b.Property<DateTime>("StatusChangingTime")
                        .HasColumnType("datetime2(7)")
                        .HasColumnName("StatusChangingTime");

                    b.Property<int?>("StatusUpdateUserId")
                        .HasColumnType("int")
                        .HasColumnName("StatusUpdateUserId");

                    b.Property<Guid>("TenantId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("TenantId");

                    b.Property<int?>("UpdatedById")
                        .HasColumnType("int")
                        .HasColumnName("UpdatedById");

                    b.HasKey("Id");

                    b.HasIndex("LenderId");

                    b.HasIndex("LoanStatusId")
                        .IsUnique();

                    b.ToTable("Loans");
                });

            modelBuilder.Entity("Domain.Entities.LoanStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2(7)")
                        .HasColumnName("DateCreated");

                    b.Property<DateTime?>("DateUpdated")
                        .IsRequired()
                        .HasColumnType("datetime2(7)")
                        .HasColumnName("DateUpdated");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasColumnName("IsDeleted");

                    b.Property<bool>("IsPredefined")
                        .HasColumnType("bit")
                        .HasColumnName("IsPredefined");

                    b.Property<Guid>("TenantId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("TenantId");

                    b.HasKey("Id");

                    b.ToTable("LoanStatuses");
                });

            modelBuilder.Entity("Domain.Entities.LoanStatusLocalization", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    b.Property<int>("CultureId")
                        .HasColumnType("int")
                        .HasColumnName("CultureId");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Description");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasColumnName("IsDeleted");

                    b.Property<int>("LoanStatusId")
                        .HasColumnType("int")
                        .HasColumnName("LoanStatusId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasColumnName("Name");

                    b.Property<Guid>("TenantId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("TenantId");

                    b.HasKey("Id", "CultureId");

                    b.HasIndex("LoanStatusId");

                    b.ToTable("LoanStatusLocalizations");
                });

            modelBuilder.Entity("Domain.Entities.Lender", b =>
                {
                    b.HasOne("Domain.Entities.LenderType", "LenderType")
                        .WithMany("Lenders")
                        .HasForeignKey("LenderTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LenderType");
                });

            modelBuilder.Entity("Domain.Entities.LenderTypeLocalization", b =>
                {
                    b.HasOne("Domain.Entities.LenderType", "LenderType")
                        .WithMany("LenderTypeLocalizations")
                        .HasForeignKey("LenderTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LenderType");
                });

            modelBuilder.Entity("Domain.Entities.Loan", b =>
                {
                    b.HasOne("Domain.Entities.Lender", "Lender")
                        .WithMany("Loans")
                        .HasForeignKey("LenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.LoanStatus", "LoanStatus")
                        .WithOne("Loan")
                        .HasForeignKey("Domain.Entities.Loan", "LoanStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lender");

                    b.Navigation("LoanStatus");
                });

            modelBuilder.Entity("Domain.Entities.LoanStatusLocalization", b =>
                {
                    b.HasOne("Domain.Entities.LoanStatus", "LoanStatus")
                        .WithMany("LoanStatusLocalizations")
                        .HasForeignKey("LoanStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LoanStatus");
                });

            modelBuilder.Entity("Domain.Entities.Lender", b =>
                {
                    b.Navigation("Loans");
                });

            modelBuilder.Entity("Domain.Entities.LenderType", b =>
                {
                    b.Navigation("LenderTypeLocalizations");

                    b.Navigation("Lenders");
                });

            modelBuilder.Entity("Domain.Entities.LoanStatus", b =>
                {
                    b.Navigation("Loan")
                        .IsRequired();

                    b.Navigation("LoanStatusLocalizations");
                });
#pragma warning restore 612, 618
        }
    }
}
