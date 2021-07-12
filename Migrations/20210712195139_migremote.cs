using Microsoft.EntityFrameworkCore.Migrations;

namespace InsuranceClaim_Microservice.Migrations
{
    public partial class migremote : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InitiateClaims_InsurerDetails_InsurerId",
                table: "InitiateClaims");

            migrationBuilder.DropIndex(
                name: "IX_InitiateClaims_InsurerId",
                table: "InitiateClaims");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_InitiateClaims_InsurerId",
                table: "InitiateClaims",
                column: "InsurerId");

            migrationBuilder.AddForeignKey(
                name: "FK_InitiateClaims_InsurerDetails_InsurerId",
                table: "InitiateClaims",
                column: "InsurerId",
                principalTable: "InsurerDetails",
                principalColumn: "InsurerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
