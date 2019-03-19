using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace expenseManagementBackend.Migrations
{
    public partial class migration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "Income");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Income");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Expense");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Expense");

            migrationBuilder.RenameColumn(
                name: "Amount",
                table: "Income",
                newName: "TotalAmount");

            migrationBuilder.RenameColumn(
                name: "Amount",
                table: "Expense",
                newName: "TotalAmount");

            migrationBuilder.AddColumn<int>(
                name: "Amount",
                table: "IncomeCategory",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "IncomeCategory",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "IncomeCategory",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Amount",
                table: "ExpenseCategory",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "ExpenseCategory",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "ExpenseCategory",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Amount",
                table: "IncomeCategory");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "IncomeCategory");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "IncomeCategory");

            migrationBuilder.DropColumn(
                name: "Amount",
                table: "ExpenseCategory");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "ExpenseCategory");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "ExpenseCategory");

            migrationBuilder.RenameColumn(
                name: "TotalAmount",
                table: "Income",
                newName: "Amount");

            migrationBuilder.RenameColumn(
                name: "TotalAmount",
                table: "Expense",
                newName: "Amount");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Income",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Income",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Expense",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Expense",
                nullable: true);
        }
    }
}
