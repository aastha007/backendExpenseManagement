using Microsoft.EntityFrameworkCore.Migrations;

namespace expenseManagementBackend.Migrations
{
    public partial class migration6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Balance",
                table: "user");

            migrationBuilder.DropColumn(
                name: "TotalAmount",
                table: "Income");

            migrationBuilder.DropColumn(
                name: "TotalAmount",
                table: "Expense");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "Balance",
                table: "user",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<int>(
                name: "TotalAmount",
                table: "Income",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalAmount",
                table: "Expense",
                nullable: false,
                defaultValue: 0);
        }
    }
}
