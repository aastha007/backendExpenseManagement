﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using expenseManagementBackend.Models;

namespace expenseManagementBackend.Migrations
{
    [DbContext(typeof(dbContext))]
    [Migration("20190322074913_m1")]
    partial class m1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("expenseManagementBackend.Models.Expense", b =>
                {
                    b.Property<int>("Expense_Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("User_Id");

                    b.HasKey("Expense_Id");

                    b.HasIndex("User_Id");

                    b.ToTable("Expense");
                });

            modelBuilder.Entity("expenseManagementBackend.Models.ExpenseCategory", b =>
                {
                    b.Property<int>("EC_Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount");

                    b.Property<string>("Date");

                    b.Property<string>("Description");

                    b.Property<string>("Expense_Category");

                    b.Property<int>("User_Id");

                    b.HasKey("EC_Id");

                    b.HasIndex("User_Id");

                    b.ToTable("ExpenseCategory");
                });

            modelBuilder.Entity("expenseManagementBackend.Models.Income", b =>
                {
                    b.Property<int>("Income_Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("User_Id");

                    b.HasKey("Income_Id");

                    b.HasIndex("User_Id");

                    b.ToTable("Income");
                });

            modelBuilder.Entity("expenseManagementBackend.Models.IncomeCategory", b =>
                {
                    b.Property<int>("IC_Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount");

                    b.Property<string>("Date");

                    b.Property<string>("Description");

                    b.Property<string>("Income_Category");

                    b.Property<int>("User_Id");

                    b.HasKey("IC_Id");

                    b.HasIndex("User_Id");

                    b.ToTable("IncomeCategory");
                });

            modelBuilder.Entity("expenseManagementBackend.Models.user", b =>
                {
                    b.Property<int>("User_Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("First_name");

                    b.Property<string>("Last_name");

                    b.Property<string>("Password");

                    b.HasKey("User_Id");

                    b.ToTable("user");
                });

            modelBuilder.Entity("expenseManagementBackend.Models.Expense", b =>
                {
                    b.HasOne("expenseManagementBackend.Models.user", "User")
                        .WithMany()
                        .HasForeignKey("User_Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("expenseManagementBackend.Models.ExpenseCategory", b =>
                {
                    b.HasOne("expenseManagementBackend.Models.user", "User")
                        .WithMany()
                        .HasForeignKey("User_Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("expenseManagementBackend.Models.Income", b =>
                {
                    b.HasOne("expenseManagementBackend.Models.user", "user")
                        .WithMany()
                        .HasForeignKey("User_Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("expenseManagementBackend.Models.IncomeCategory", b =>
                {
                    b.HasOne("expenseManagementBackend.Models.user", "user")
                        .WithMany()
                        .HasForeignKey("User_Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
