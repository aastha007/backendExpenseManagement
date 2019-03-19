using Microsoft.EntityFrameworkCore.Migrations;

namespace expenseManagementBackend.Migrations
{
    public partial class migration4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Income_IncomeCategory_IC_ID",
                table: "Income");

            migrationBuilder.DropIndex(
                name: "IX_Income_IC_ID",
                table: "Income");

            migrationBuilder.DropColumn(
                name: "IC_ID",
                table: "Income");

            migrationBuilder.AddColumn<int>(
                name: "User_Id",
                table: "IncomeCategory",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_IncomeCategory_User_Id",
                table: "IncomeCategory",
                column: "User_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_IncomeCategory_user_User_Id",
                table: "IncomeCategory",
                column: "User_Id",
                principalTable: "user",
                principalColumn: "User_Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IncomeCategory_user_User_Id",
                table: "IncomeCategory");

            migrationBuilder.DropIndex(
                name: "IX_IncomeCategory_User_Id",
                table: "IncomeCategory");

            migrationBuilder.DropColumn(
                name: "User_Id",
                table: "IncomeCategory");

            migrationBuilder.AddColumn<int>(
                name: "IC_ID",
                table: "Income",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Income_IC_ID",
                table: "Income",
                column: "IC_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Income_IncomeCategory_IC_ID",
                table: "Income",
                column: "IC_ID",
                principalTable: "IncomeCategory",
                principalColumn: "IC_Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
