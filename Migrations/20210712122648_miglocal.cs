using Microsoft.EntityFrameworkCore.Migrations;

namespace InsuranceClaim_Microservice.Migrations
{
    public partial class miglocal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InsurerDetails",
                columns: table => new
                {
                    InsurerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InsurerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InsurerPackageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InsuranceAmountLimit = table.Column<double>(type: "float", nullable: false),
                    DisbursementDuration = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InsurerDetails", x => x.InsurerId);
                });

            migrationBuilder.CreateTable(
                name: "InitiateClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InsurerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InsurerId = table.Column<int>(type: "int", nullable: false),
                    PatientName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ailment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TreatmentPlanId = table.Column<int>(type: "int", nullable: false),
                    TreatmentPackageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cost = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InitiateClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InitiateClaims_InsurerDetails_InsurerId",
                        column: x => x.InsurerId,
                        principalTable: "InsurerDetails",
                        principalColumn: "InsurerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InitiateClaims_InsurerId",
                table: "InitiateClaims",
                column: "InsurerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InitiateClaims");

            migrationBuilder.DropTable(
                name: "InsurerDetails");
        }
    }
}
