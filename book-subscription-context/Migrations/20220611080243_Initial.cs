using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace book_subscription_context.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    bookid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "varchar(max)", nullable: false),
                    text = table.Column<string>(type: "varchar(max)", nullable: false),
                    price = table.Column<float>(type: "real", nullable: false),
                    creationdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    modificationdate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.bookid);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    userid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    email = table.Column<string>(type: "varchar(max)", nullable: false),
                    name = table.Column<string>(type: "varchar(max)", nullable: false),
                    lastname = table.Column<string>(type: "varchar(max)", nullable: false),
                    reseller = table.Column<bool>(type: "bit", nullable: false),
                    creationdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    modificationdate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.userid);
                });

            migrationBuilder.CreateTable(
                name: "Balances",
                columns: table => new
                {
                    balanceid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    balance = table.Column<float>(type: "real", nullable: false),
                    creationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    modificationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    userid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Balances", x => x.balanceid);
                    table.ForeignKey(
                        name: "FK_Balances_Users_userid",
                        column: x => x.userid,
                        principalTable: "Users",
                        principalColumn: "userid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "usersubscriptions",
                columns: table => new
                {
                    UserSubscriptionid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    active = table.Column<bool>(type: "bit", nullable: false),
                    creationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    modificationdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    bookid = table.Column<int>(type: "int", nullable: false),
                    userid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usersubscriptions", x => x.UserSubscriptionid);
                    table.ForeignKey(
                        name: "FK_usersubscriptions_Books_bookid",
                        column: x => x.bookid,
                        principalTable: "Books",
                        principalColumn: "bookid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_usersubscriptions_Users_userid",
                        column: x => x.userid,
                        principalTable: "Users",
                        principalColumn: "userid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Balances_userid",
                table: "Balances",
                column: "userid");

            migrationBuilder.CreateIndex(
                name: "IX_usersubscriptions_bookid",
                table: "usersubscriptions",
                column: "bookid");

            migrationBuilder.CreateIndex(
                name: "IX_usersubscriptions_userid",
                table: "usersubscriptions",
                column: "userid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Balances");

            migrationBuilder.DropTable(
                name: "usersubscriptions");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
