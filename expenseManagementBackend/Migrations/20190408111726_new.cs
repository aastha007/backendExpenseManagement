using Microsoft.EntityFrameworkCore.Migrations;

namespace expenseManagementBackend.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Expense_user_User_Id",
                table: "Expense");

            migrationBuilder.DropForeignKey(
                name: "FK_ExpenseCategory_user_User_Id",
                table: "ExpenseCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_Income_user_User_Id",
                table: "Income");

            migrationBuilder.DropForeignKey(
                name: "FK_IncomeCategory_user_User_Id",
                table: "IncomeCategory");

            migrationBuilder.DropIndex(
                name: "IX_IncomeCategory_User_Id",
                table: "IncomeCategory");

            migrationBuilder.DropIndex(
                name: "IX_Income_User_Id",
                table: "Income");

            migrationBuilder.DropIndex(
                name: "IX_ExpenseCategory_User_Id",
                table: "ExpenseCategory");

            migrationBuilder.DropIndex(
                name: "IX_Expense_User_Id",
                table: "Expense");

            migrationBuilder.AlterColumn<string>(
                name: "User_Id",
                table: "IncomeCategory",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "User_Id",
                table: "Income",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "User_Id",
                table: "ExpenseCategory",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "User_Id",
                table: "Expense",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "User_Id",
                table: "IncomeCategory",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "User_Id",
                table: "Income",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "User_Id",
                table: "ExpenseCategory",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "User_Id",
                table: "Expense",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_IncomeCategory_User_Id",
                table: "IncomeCategory",
                column: "User_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Income_User_Id",
                table: "Income",
                column: "User_Id");

            migrationBuilder.CreateIndex(
                name: "IX_ExpenseCategory_User_Id",
                table: "ExpenseCategory",
                column: "User_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Expense_User_Id",
                table: "Expense",
                column: "User_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Expense_user_User_Id",
                table: "Expense",
                column: "User_Id",
                principalTable: "user",
                principalColumn: "User_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExpenseCategory_user_User_Id",
                table: "ExpenseCategory",
                column: "User_Id",
                principalTable: "user",
                principalColumn: "User_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Income_user_User_Id",
                table: "Income",
                column: "User_Id",
                principalTable: "user",
                principalColumn: "User_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IncomeCategory_user_User_Id",
                table: "IncomeCategory",
                column: "User_Id",
                principalTable: "user",
                principalColumn: "User_Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
