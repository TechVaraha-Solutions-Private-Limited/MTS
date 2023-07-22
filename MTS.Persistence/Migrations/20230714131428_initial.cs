using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MTS.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TblUsermasters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Plantcode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Createdon = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    LastLogin = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Logins = table.Column<int>(type: "int", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserRights = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsAdmin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Expiry = table.Column<int>(type: "int", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EditedInf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserFullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Did = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblUsermasters", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TblUsermasters");
        }
    }
}
