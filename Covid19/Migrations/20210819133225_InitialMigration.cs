using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Covid19.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vaccines",
                columns: table => new
                {
                    VaccineId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    FirstDate = table.Column<string>(nullable: true),
                    FirstSerialNumber = table.Column<string>(nullable: true),
                    SecondDate = table.Column<string>(nullable: true),
                    SecondSerialNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vaccines", x => x.VaccineId);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    PatientId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<int>(nullable: false),
                    Mail = table.Column<string>(nullable: true),
                    VaccinatedInBiH = table.Column<bool>(nullable: false),
                    VaccineId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.PatientId);
                    table.ForeignKey(
                        name: "FK_Patients_Vaccines_VaccineId",
                        column: x => x.VaccineId,
                        principalTable: "Vaccines",
                        principalColumn: "VaccineId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "PatientId", "FirstName", "LastName", "Mail", "PhoneNumber", "VaccinatedInBiH", "VaccineId" },
                values: new object[] { 1, "firstName1", "lastName1", "sad@gadada.com", 123456789, true, 0 });

            migrationBuilder.InsertData(
                table: "Vaccines",
                columns: new[] { "VaccineId", "FirstDate", "FirstSerialNumber", "Name", "SecondDate", "SecondSerialNumber" },
                values: new object[] { 1, null, null, null, null, null });

            migrationBuilder.CreateIndex(
                name: "IX_Patients_VaccineId",
                table: "Patients",
                column: "VaccineId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "Vaccines");
        }
    }
}
