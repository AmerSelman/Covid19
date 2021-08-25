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
                    VaccineName = table.Column<string>(nullable: true)
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
                    JMBG = table.Column<string>(maxLength: 13, nullable: false),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(maxLength: 20, nullable: false),
                    Mail = table.Column<string>(maxLength: 50, nullable: false),
                    FirstDateV = table.Column<string>(maxLength: 20, nullable: false),
                    SecondDateV = table.Column<string>(maxLength: 20, nullable: false),
                    FirstSerialNumber = table.Column<string>(maxLength: 50, nullable: false),
                    SecondSerialNumber = table.Column<string>(maxLength: 50, nullable: false),
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
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Vaccines",
                columns: new[] { "VaccineId", "VaccineName" },
                values: new object[] { 1, "AstraZeneca" });

            migrationBuilder.InsertData(
                table: "Vaccines",
                columns: new[] { "VaccineId", "VaccineName" },
                values: new object[] { 2, "Pfizer-BioNTech" });

            migrationBuilder.InsertData(
                table: "Vaccines",
                columns: new[] { "VaccineId", "VaccineName" },
                values: new object[] { 3, "Moderna" });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "PatientId", "FirstDateV", "FirstName", "FirstSerialNumber", "JMBG", "LastName", "Mail", "PhoneNumber", "SecondDateV", "SecondSerialNumber", "VaccinatedInBiH", "VaccineId" },
                values: new object[,]
                {
                    { 1, "10.02.2021.", "Omer", "100551", "123456789", "Hodžić", "omer.h@gmail.com", "069874123144", "03.03.2021", "101221", true, 1 },
                    { 5, "20.02.2021.", "Katka", "100951", "567891234", "Burnić", "katka.b@gmail.com", "061874123474", "13.03.2021", "101521", false, 1 },
                    { 2, "15.02.2021.", "Omera", "100620", "234567891", "Hadžić", "omera.h@gmail.com", "06987441321134", "08.03.2021", "101451", true, 2 },
                    { 3, "20.02.2021.", "Elvis", "100951", "345678912", "Džeko", "elvis.dž@gmail.com", "061874123474", "13.03.2021", "101521", false, 3 },
                    { 4, "20.02.2021.", "Elvina", "100951", "456789123", "Grgić", "elvina.g@gmail.com", "06187123474", "13.03.2021", "101521", true, 3 },
                    { 6, "20.02.2021.", "Miralem", "100951", "678912345", "Pjanić", "miralem.p@gmail.com", "061874123474", "13.03.2021", "101521", false, 3 },
                    { 7, "20.02.2021.", "Marko", "100951", "789123456", "Marić", "marko.m@gmail.com", "061874123474", "13.03.2021", "101521", true, 3 },
                    { 8, "20.02.2021.", "Kasim", "100951", "891234567", "Rahić", "kasim.l@gmail.com", "061874123474", "13.03.2021", "101521", false, 3 },
                    { 9, "20.02.2021.", "Luka", "100951", "912345678", "Marković", "elvis.dž@gmail.com", "061874123474", "13.03.2021", "101521", true, 3 }
                });

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
