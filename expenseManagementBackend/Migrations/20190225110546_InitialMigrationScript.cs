using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace expenseManagementBackend.Migrations
{
    public partial class InitialMigrationScript : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ExpenseCategory",
                columns: table => new
                {
                    EC_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Expense_Category = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpenseCategory", x => x.EC_Id);
                });

            migrationBuilder.CreateTable(
                name: "IncomeCategory",
                columns: table => new
                {
                    IC_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Income_Category = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncomeCategory", x => x.IC_Id);
                });

            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    User_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    First_name = table.Column<string>(nullable: true),
                    Last_name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user", x => x.User_Id);
                });

            migrationBuilder.CreateTable(
                name: "Expense",
                columns: table => new
                {
                    Expense_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    User_Id = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Amount = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    EC_ID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expense", x => x.Expense_Id);
                    table.ForeignKey(
                        name: "FK_Expense_ExpenseCategory_EC_ID",
                        column: x => x.EC_ID,
                        principalTable: "ExpenseCategory",
                        principalColumn: "EC_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Expense_user_User_Id",
                        column: x => x.User_Id,
                        principalTable: "user",
                        principalColumn: "User_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Income",
                columns: table => new
                {
                    Income_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    User_Id = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Amount = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    IC_ID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Income", x => x.Income_Id);
                    table.ForeignKey(
                        name: "FK_Income_IncomeCategory_IC_ID",
                        column: x => x.IC_ID,
                        principalTable: "IncomeCategory",
                        principalColumn: "IC_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Income_user_User_Id",
                        column: x => x.User_Id,
                        principalTable: "user",
                        principalColumn: "User_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Expense_EC_ID",
                table: "Expense",
                column: "EC_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Expense_User_Id",
                table: "Expense",
                column: "User_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Income_IC_ID",
                table: "Income",
                column: "IC_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Income_User_Id",
                table: "Income",
                column: "User_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Expense");

            migrationBuilder.DropTable(
                name: "Income");

            migrationBuilder.DropTable(
                name: "ExpenseCategory");

            migrationBuilder.DropTable(
                name: "IncomeCategory");

            migrationBuilder.DropTable(
                name: "user");
        }
    }
}
