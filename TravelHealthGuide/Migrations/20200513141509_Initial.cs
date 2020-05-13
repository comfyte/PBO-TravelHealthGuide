using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelHealthGuide.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Destinations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CountryName = table.Column<string>(nullable: false),
                    CountryCode = table.Column<string>(nullable: false),
                    DiseaseRisks = table.Column<string>(nullable: true),
                    VaccintionRequirements = table.Column<string>(nullable: true),
                    RecommendedActions = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destinations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Username = table.Column<string>(nullable: true),
                    HashedPassword = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                });

            migrationBuilder.InsertData(
                table: "Destinations",
                columns: new[] { "Id", "CountryCode", "CountryName", "DiseaseRisks", "RecommendedActions", "VaccintionRequirements" },
                values: new object[] { 1, "AF", "Afghanistan", @"Malaria
Malaria risk due to P. falciparum and P. vivax exists from May through November below 2000 m.", @"Malaria
Mosquito-bite prevention plus atovaquoneproguanil or doxycycline or mefloquine chemoprophylaxis.", @"Polio
Proof of polio vaccination is required for travellers coming from a polio-endemic country. For residents or travellers who stay in Afghanistan for more than 4 weeks, a proof of polio vaccination may be required when departing from Afghanistan. This vaccination should be received between 4 weeks and 12 months before the date of departure." });

            migrationBuilder.InsertData(
                table: "Destinations",
                columns: new[] { "Id", "CountryCode", "CountryName", "DiseaseRisks", "RecommendedActions", "VaccintionRequirements" },
                values: new object[] { 2, "AL", "Albania", null, null, @"Yellow Fever
A yellow fever vaccination certificate is required for travellers aged 1 year or over arriving from countries with risk of yellow fever transmission." });

            migrationBuilder.InsertData(
                table: "Destinations",
                columns: new[] { "Id", "CountryCode", "CountryName", "DiseaseRisks", "RecommendedActions", "VaccintionRequirements" },
                values: new object[] { 3, "ID", "Indonesia", @"Malaria
Malaria risk exists throughout the year in most areas of the five eastern provinces of East Nusa Tenggara, Maluku, North Maluku, Papua and West Papua. In other parts of the country, there is malaria risk in some districts, except in Jakarta municipality, in cities and urban areas, and in the areas of the main tourist resorts. P. vivax resistance to chloroquine has been reported. Human P. knowlesi infection has been reported in the province of Kalimantan.", @"Malaria
Mosquito-bite prevention plus atovaquoneproguanil or doxycycline or mefloquine chemoprophylaxis.", @"Yellow Fever
 a yellow fever vaccination certificate is required for travellers aged 9 months or over arriving from countries with risk of yellow fever transmission.||Meningitis
Proof of meningococcal (groups A, C, Y and W-135) meningitis vaccination is required for travellers departing to and arriving from Saudi Arabia" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Destinations");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
