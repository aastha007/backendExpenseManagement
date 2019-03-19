using Microsoft.EntityFrameworkCore.Migrations;

namespace expenseManagementBackend.Migrations
{
    public partial class migration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Expense_ExpenseCategory_EC_ID",
                table: "Expense");

            migrationBuilder.DropIndex(
                name: "IX_Expense_EC_ID",
                table: "Expense");

            migrationBuilder.DropColumn(
                name: "EC_ID",
                table: "Expense");

            migrationBuilder.AddColumn<int>(
                name: "User_Id",
                table: "ExpenseCategory",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ExpenseCategory_User_Id",
                table: "ExpenseCategory",
                column: "User_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ExpenseCategory_user_User_Id",
                table: "ExpenseCategory",
                column: "User_Id",
                principalTable: "user",
                principalColumn: "User_Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExpenseCategory_user_User_Id",
                table: "ExpenseCategory");

            migrationBuilder.DropIndex(
                name: "IX_ExpenseCategory_User_Id",
                table: "ExpenseCategory");

            migrationBuilder.DropColumn(
                name: "User_Id",
                table: "ExpenseCategory");

            migrationBuilder.AddColumn<int>(
                name: "EC_ID",
                table: "Expense",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Expense_EC_ID",
                table: "Expense",
                column: "EC_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Expense_ExpenseCategory_EC_ID",
                table: "Expense",
                column: "EC_ID",
                principalTable: "ExpenseCategory",
                principalColumn: "EC_Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
