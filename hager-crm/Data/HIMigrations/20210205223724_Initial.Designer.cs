﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using hager_crm.Data;

namespace hager_crm.Data.HIMigrations
{
    [DbContext(typeof(HagerContext))]
    [Migration("20210205223724_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("HG")
                .HasAnnotation("ProductVersion", "3.1.11");

            modelBuilder.Entity("hager_crm.Models.BillingTerm", b =>
                {
                    b.Property<int>("BillingTermID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Terms")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.HasKey("BillingTermID");

                    b.ToTable("BillingTerms");
                });

            modelBuilder.Entity("hager_crm.Models.Categories", b =>
                {
                    b.Property<int>("CategoriesID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(40);

                    b.HasKey("CategoriesID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("hager_crm.Models.Company", b =>
                {
                    b.Property<int>("CompanyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Active")
                        .HasColumnType("INTEGER");

                    b.Property<string>("BillingAddress1")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(100);

                    b.Property<string>("BillingAddress2")
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<int>("BillingCountryID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("BillingPostalCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("BillingProvinceID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("BillingTermID")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Contractor")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ContractorTypeID")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("CreditCheck")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CurrencyID")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Customer")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CustomerTypeID")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateChecked")
                        .HasColumnType("TEXT");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT")
                        .HasMaxLength(200);

                    b.Property<long>("Phone")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ShippingAddress1")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(100);

                    b.Property<string>("ShippingAddress2")
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<int>("ShippingCountryID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ShippingPostalCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("ShippingProvinceID")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Vendor")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("VendorTypeID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Website")
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.HasKey("CompanyID");

                    b.HasIndex("BillingCountryID");

                    b.HasIndex("BillingProvinceID");

                    b.HasIndex("BillingTermID");

                    b.HasIndex("ContractorTypeID");

                    b.HasIndex("CurrencyID");

                    b.HasIndex("CustomerTypeID");

                    b.HasIndex("ShippingCountryID");

                    b.HasIndex("ShippingProvinceID");

                    b.HasIndex("VendorTypeID");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("hager_crm.Models.Contact", b =>
                {
                    b.Property<int>("ContactID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Active")
                        .HasColumnType("INTEGER");

                    b.Property<long>("CellPhone")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CompanyID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(255);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT")
                        .HasMaxLength(200);

                    b.Property<long>("WorkPhone")
                        .HasColumnType("INTEGER");

                    b.HasKey("ContactID");

                    b.HasIndex("CompanyID");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("hager_crm.Models.ContactCategories", b =>
                {
                    b.Property<int>("ContactCategoriesID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoriesID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ContactID")
                        .HasColumnType("INTEGER");

                    b.HasKey("ContactCategoriesID");

                    b.HasIndex("CategoriesID");

                    b.HasIndex("ContactID");

                    b.ToTable("ContactCategories");
                });

            modelBuilder.Entity("hager_crm.Models.ContractorType", b =>
                {
                    b.Property<int>("ContractorTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Type")
                        .HasColumnType("TEXT")
                        .HasMaxLength(40);

                    b.HasKey("ContractorTypeID");

                    b.ToTable("ContractorTypes");
                });

            modelBuilder.Entity("hager_crm.Models.Country", b =>
                {
                    b.Property<int>("CountryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(40);

                    b.HasKey("CountryID");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("hager_crm.Models.Currency", b =>
                {
                    b.Property<int>("CurrencyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CurrencyName")
                        .HasColumnType("TEXT")
                        .HasMaxLength(30);

                    b.HasKey("CurrencyID");

                    b.ToTable("Currencies");
                });

            modelBuilder.Entity("hager_crm.Models.CustomerType", b =>
                {
                    b.Property<int>("CustomerTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Type")
                        .HasColumnType("TEXT")
                        .HasMaxLength(40);

                    b.HasKey("CustomerTypeID");

                    b.ToTable("CustomerTypes");
                });

            modelBuilder.Entity("hager_crm.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Active")
                        .HasColumnType("INTEGER");

                    b.Property<long?>("CellPhone")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateJoined")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(255);

                    b.Property<string>("EmergencyContactName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<long>("EmergencyContactPhone")
                        .HasColumnType("INTEGER");

                    b.Property<string>("EmployeeAddress1")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(100);

                    b.Property<string>("EmployeeAddress2")
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<int>("EmployeeCountryID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("EmployeePostalCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("EmployeeProvinceID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("EmploymentTypeID")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Expense")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<int>("JobPositionID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("KeyFob")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT")
                        .HasMaxLength(200);

                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Wage")
                        .HasColumnType("TEXT");

                    b.Property<long>("WorkPhone")
                        .HasColumnType("INTEGER");

                    b.HasKey("EmployeeID");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("EmployeeCountryID");

                    b.HasIndex("EmployeeProvinceID");

                    b.HasIndex("EmploymentTypeID");

                    b.HasIndex("JobPositionID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("hager_crm.Models.EmploymentType", b =>
                {
                    b.Property<int>("EmploymentTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Type")
                        .HasColumnType("TEXT")
                        .HasMaxLength(40);

                    b.HasKey("EmploymentTypeID");

                    b.ToTable("EmploymentTypes");
                });

            modelBuilder.Entity("hager_crm.Models.JobPosition", b =>
                {
                    b.Property<int>("JobPositionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Position")
                        .HasColumnType("TEXT")
                        .HasMaxLength(40);

                    b.HasKey("JobPositionID");

                    b.ToTable("JobPositions");
                });

            modelBuilder.Entity("hager_crm.Models.Province", b =>
                {
                    b.Property<int>("ProvinceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CountryID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ProvinceName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(30);

                    b.HasKey("ProvinceID");

                    b.ToTable("Provinces");
                });

            modelBuilder.Entity("hager_crm.Models.VendorType", b =>
                {
                    b.Property<int>("VendorTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Type")
                        .HasColumnType("TEXT")
                        .HasMaxLength(40);

                    b.HasKey("VendorTypeID");

                    b.ToTable("VendorTypes");
                });

            modelBuilder.Entity("hager_crm.Models.Company", b =>
                {
                    b.HasOne("hager_crm.Models.Country", "BillingCountry")
                        .WithMany("Companies")
                        .HasForeignKey("BillingCountryID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("hager_crm.Models.Province", "BillingProvince")
                        .WithMany("Companies")
                        .HasForeignKey("BillingProvinceID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("hager_crm.Models.BillingTerm", "BillingTerm")
                        .WithMany("Companies")
                        .HasForeignKey("BillingTermID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("hager_crm.Models.ContractorType", "ContractorType")
                        .WithMany("Companies")
                        .HasForeignKey("ContractorTypeID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("hager_crm.Models.Currency", "Currency")
                        .WithMany("Companies")
                        .HasForeignKey("CurrencyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("hager_crm.Models.CustomerType", "CustomerType")
                        .WithMany("Companies")
                        .HasForeignKey("CustomerTypeID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("hager_crm.Models.Country", "ShippingCountry")
                        .WithMany()
                        .HasForeignKey("ShippingCountryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("hager_crm.Models.Province", "ShippingProvince")
                        .WithMany()
                        .HasForeignKey("ShippingProvinceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("hager_crm.Models.VendorType", "VendorType")
                        .WithMany("Companies")
                        .HasForeignKey("VendorTypeID")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("hager_crm.Models.Contact", b =>
                {
                    b.HasOne("hager_crm.Models.Company", "Company")
                        .WithMany("Contacts")
                        .HasForeignKey("CompanyID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("hager_crm.Models.ContactCategories", b =>
                {
                    b.HasOne("hager_crm.Models.Categories", "Categories")
                        .WithMany("ContactCategories")
                        .HasForeignKey("CategoriesID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("hager_crm.Models.Contact", "Contact")
                        .WithMany("ContactCategories")
                        .HasForeignKey("ContactID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("hager_crm.Models.Employee", b =>
                {
                    b.HasOne("hager_crm.Models.Country", "EmployeeCountry")
                        .WithMany("Employees")
                        .HasForeignKey("EmployeeCountryID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("hager_crm.Models.Province", "EmployeeProvince")
                        .WithMany("Employees")
                        .HasForeignKey("EmployeeProvinceID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("hager_crm.Models.EmploymentType", "EmploymentType")
                        .WithMany("Employees")
                        .HasForeignKey("EmploymentTypeID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("hager_crm.Models.JobPosition", "JobPosition")
                        .WithMany("Employees")
                        .HasForeignKey("JobPositionID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
