using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EleccionsMunicipals.Migrations
{
    /// <inheritdoc />
    public partial class _1test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Candidat_PartitsPolitics_LlistaPartitMunicipiID",
                table: "Candidat");

            migrationBuilder.DropForeignKey(
                name: "FK_TaulesElectorals_Municipis_MunicipiID",
                table: "TaulesElectorals");

            migrationBuilder.DropForeignKey(
                name: "FK_TaulesElectorals_ResultatsTaules_resultatsTaulaID",
                table: "TaulesElectorals");

            migrationBuilder.DropForeignKey(
                name: "FK_VotsPerLlista_ResultatsTaules_ResultatsTaulaID",
                table: "VotsPerLlista");

            migrationBuilder.DropTable(
                name: "PartitsPolitics");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TaulesElectorals",
                table: "TaulesElectorals");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ResultatsTaules",
                table: "ResultatsTaules");

            migrationBuilder.RenameTable(
                name: "TaulesElectorals",
                newName: "TaulaElectoral");

            migrationBuilder.RenameTable(
                name: "ResultatsTaules",
                newName: "ResultatsTaula");

            migrationBuilder.RenameColumn(
                name: "LlistaPartitMunicipiID",
                table: "Candidat",
                newName: "PartitMunicipiID");

            migrationBuilder.RenameIndex(
                name: "IX_Candidat_LlistaPartitMunicipiID",
                table: "Candidat",
                newName: "IX_Candidat_PartitMunicipiID");

            migrationBuilder.RenameIndex(
                name: "IX_TaulesElectorals_resultatsTaulaID",
                table: "TaulaElectoral",
                newName: "IX_TaulaElectoral_resultatsTaulaID");

            migrationBuilder.RenameIndex(
                name: "IX_TaulesElectorals_MunicipiID",
                table: "TaulaElectoral",
                newName: "IX_TaulaElectoral_MunicipiID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TaulaElectoral",
                table: "TaulaElectoral",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ResultatsTaula",
                table: "ResultatsTaula",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "PartitMunicipi",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nomPartit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MunicipiID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartitMunicipi", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PartitMunicipi_Municipis_MunicipiID",
                        column: x => x.MunicipiID,
                        principalTable: "Municipis",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_PartitMunicipi_MunicipiID",
                table: "PartitMunicipi",
                column: "MunicipiID");

            migrationBuilder.AddForeignKey(
                name: "FK_Candidat_PartitMunicipi_PartitMunicipiID",
                table: "Candidat",
                column: "PartitMunicipiID",
                principalTable: "PartitMunicipi",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_TaulaElectoral_Municipis_MunicipiID",
                table: "TaulaElectoral",
                column: "MunicipiID",
                principalTable: "Municipis",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_TaulaElectoral_ResultatsTaula_resultatsTaulaID",
                table: "TaulaElectoral",
                column: "resultatsTaulaID",
                principalTable: "ResultatsTaula",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VotsPerLlista_ResultatsTaula_ResultatsTaulaID",
                table: "VotsPerLlista",
                column: "ResultatsTaulaID",
                principalTable: "ResultatsTaula",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Candidat_PartitMunicipi_PartitMunicipiID",
                table: "Candidat");

            migrationBuilder.DropForeignKey(
                name: "FK_TaulaElectoral_Municipis_MunicipiID",
                table: "TaulaElectoral");

            migrationBuilder.DropForeignKey(
                name: "FK_TaulaElectoral_ResultatsTaula_resultatsTaulaID",
                table: "TaulaElectoral");

            migrationBuilder.DropForeignKey(
                name: "FK_VotsPerLlista_ResultatsTaula_ResultatsTaulaID",
                table: "VotsPerLlista");

            migrationBuilder.DropTable(
                name: "PartitMunicipi");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TaulaElectoral",
                table: "TaulaElectoral");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ResultatsTaula",
                table: "ResultatsTaula");

            migrationBuilder.RenameTable(
                name: "TaulaElectoral",
                newName: "TaulesElectorals");

            migrationBuilder.RenameTable(
                name: "ResultatsTaula",
                newName: "ResultatsTaules");

            migrationBuilder.RenameColumn(
                name: "PartitMunicipiID",
                table: "Candidat",
                newName: "LlistaPartitMunicipiID");

            migrationBuilder.RenameIndex(
                name: "IX_Candidat_PartitMunicipiID",
                table: "Candidat",
                newName: "IX_Candidat_LlistaPartitMunicipiID");

            migrationBuilder.RenameIndex(
                name: "IX_TaulaElectoral_resultatsTaulaID",
                table: "TaulesElectorals",
                newName: "IX_TaulesElectorals_resultatsTaulaID");

            migrationBuilder.RenameIndex(
                name: "IX_TaulaElectoral_MunicipiID",
                table: "TaulesElectorals",
                newName: "IX_TaulesElectorals_MunicipiID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TaulesElectorals",
                table: "TaulesElectorals",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ResultatsTaules",
                table: "ResultatsTaules",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "PartitsPolitics",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MunicipiID = table.Column<long>(type: "bigint", nullable: true),
                    nomPartit = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartitsPolitics", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PartitsPolitics_Municipis_MunicipiID",
                        column: x => x.MunicipiID,
                        principalTable: "Municipis",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_PartitsPolitics_MunicipiID",
                table: "PartitsPolitics",
                column: "MunicipiID");

            migrationBuilder.AddForeignKey(
                name: "FK_Candidat_PartitsPolitics_LlistaPartitMunicipiID",
                table: "Candidat",
                column: "LlistaPartitMunicipiID",
                principalTable: "PartitsPolitics",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_TaulesElectorals_Municipis_MunicipiID",
                table: "TaulesElectorals",
                column: "MunicipiID",
                principalTable: "Municipis",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_TaulesElectorals_ResultatsTaules_resultatsTaulaID",
                table: "TaulesElectorals",
                column: "resultatsTaulaID",
                principalTable: "ResultatsTaules",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VotsPerLlista_ResultatsTaules_ResultatsTaulaID",
                table: "VotsPerLlista",
                column: "ResultatsTaulaID",
                principalTable: "ResultatsTaules",
                principalColumn: "ID");
        }
    }
}
