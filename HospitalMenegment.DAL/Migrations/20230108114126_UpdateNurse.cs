using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalMenegment.DAL.Migrations
{
    public partial class UpdateNurse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_appointments_nurses_NurseId",
                table: "appointments");

            migrationBuilder.DropIndex(
                name: "IX_appointments_NurseId",
                table: "appointments");

            migrationBuilder.DropColumn(
                name: "NurseId",
                table: "appointments");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NurseId",
                table: "appointments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_appointments_NurseId",
                table: "appointments",
                column: "NurseId");

            migrationBuilder.AddForeignKey(
                name: "FK_appointments_nurses_NurseId",
                table: "appointments",
                column: "NurseId",
                principalTable: "nurses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
