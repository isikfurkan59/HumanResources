using Microsoft.EntityFrameworkCore.Migrations;

namespace HumanResources.Infrastructure.Migrations
{
    public partial class ArchitectUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personnelles_Directors_DirectorId",
                table: "Personnelles");

            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Personnelles");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Personnelles");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Personnelles");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Personnelles");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Personnelles");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Personnelles");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Directors");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Directors");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Directors");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Directors");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Directors");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Directors");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Personnelles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Directors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DirectorId",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PersonnelleId",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_DirectorId",
                table: "AspNetUsers",
                column: "DirectorId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_PersonnelleId",
                table: "AspNetUsers",
                column: "PersonnelleId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Directors_DirectorId",
                table: "AspNetUsers",
                column: "DirectorId",
                principalTable: "Directors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Personnelles_PersonnelleId",
                table: "AspNetUsers",
                column: "PersonnelleId",
                principalTable: "Personnelles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Personnelles_Directors_DirectorId",
                table: "Personnelles",
                column: "DirectorId",
                principalTable: "Directors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Directors_DirectorId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Personnelles_PersonnelleId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Personnelles_Directors_DirectorId",
                table: "Personnelles");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_DirectorId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_PersonnelleId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Personnelles");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Directors");

            migrationBuilder.DropColumn(
                name: "DirectorId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PersonnelleId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Personnelles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Personnelles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Personnelles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Personnelles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "Gender",
                table: "Personnelles",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Personnelles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Directors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Directors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Directors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Directors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Gender",
                table: "Directors",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Directors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<bool>(type: "bit", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "Address", "City", "Country", "Email", "FirstName", "Gender", "LastName", "Password" },
                values: new object[] { 1, "Admin", "Admin", "Admin", "Admin", "Admin", true, "Admin", "123456789" });

            migrationBuilder.AddForeignKey(
                name: "FK_Personnelles_Directors_DirectorId",
                table: "Personnelles",
                column: "DirectorId",
                principalTable: "Directors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
