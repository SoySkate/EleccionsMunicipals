using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EleccionsMunicipals.Migrations
{
    /// <inheritdoc />
    public partial class _2test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Candidat_PartitMunicipi_PartitMunicipiID",
                table: "Candidat");

            migrationBuilder.DropForeignKey(
                name: "FK_PartitMunicipi_Municipis_MunicipiID",
                table: "PartitMunicipi");

            migrationBuilder.DropForeignKey(
                name: "FK_TaulaElectoral_Municipis_MunicipiID",
                table: "TaulaElectoral");

            migrationBuilder.DropForeignKey(
                name: "FK_TaulaElectoral_ResultatsTaula_resultatsTaulaID",
                table: "TaulaElectoral");

            migrationBuilder.DropForeignKey(
                name: "FK_VotsPerLlista_ResultatsTaula_ResultatsTaulaID",
                table: "VotsPerLlista");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TaulaElectoral",
                table: "TaulaElectoral");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ResultatsTaula",
                table: "ResultatsTaula");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PartitMunicipi",
                table: "PartitMunicipi");

            migrationBuilder.RenameTable(
                name: "TaulaElectoral",
                newName: "TaulesElectorals");

            migrationBuilder.RenameTable(
                name: "ResultatsTaula",
                newName: "ResultatsTaules");

            migrationBuilder.RenameTable(
                name: "PartitMunicipi",
                newName: "PartitsPolitics");

            migrationBuilder.RenameIndex(
                name: "IX_TaulaElectoral_resultatsTaulaID",
                table: "TaulesElectorals",
                newName: "IX_TaulesElectorals_resultatsTaulaID");

            migrationBuilder.RenameIndex(
                name: "IX_TaulaElectoral_MunicipiID",
                table: "TaulesElectorals",
                newName: "IX_TaulesElectorals_MunicipiID");

            migrationBuilder.RenameIndex(
                name: "IX_PartitMunicipi_MunicipiID",
                table: "PartitsPolitics",
                newName: "IX_PartitsPolitics_MunicipiID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TaulesElectorals",
                table: "TaulesElectorals",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ResultatsTaules",
                table: "ResultatsTaules",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PartitsPolitics",
                table: "PartitsPolitics",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Candidat_PartitsPolitics_PartitMunicipiID",
                table: "Candidat",
                column: "PartitMunicipiID",
                principalTable: "PartitsPolitics",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_PartitsPolitics_Municipis_MunicipiID",
                table: "PartitsPolitics",
                column: "MunicipiID",
                principalTable: "Municipis",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Candidat_PartitsPolitics_PartitMunicipiID",
                table: "Candidat");

            migrationBuilder.DropForeignKey(
                name: "FK_PartitsPolitics_Municipis_MunicipiID",
                table: "PartitsPolitics");

            migrationBuilder.DropForeignKey(
                name: "FK_TaulesElectorals_Municipis_MunicipiID",
                table: "TaulesElectorals");

            migrationBuilder.DropForeignKey(
                name: "FK_TaulesElectorals_ResultatsTaules_resultatsTaulaID",
                table: "TaulesElectorals");

            migrationBuilder.DropForeignKey(
                name: "FK_VotsPerLlista_ResultatsTaules_ResultatsTaulaID",
                table: "VotsPerLlista");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TaulesElectorals",
                table: "TaulesElectorals");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ResultatsTaules",
                table: "ResultatsTaules");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PartitsPolitics",
                table: "PartitsPolitics");

            migrationBuilder.RenameTable(
                name: "TaulesElectorals",
                newName: "TaulaElectoral");

            migrationBuilder.RenameTable(
                name: "ResultatsTaules",
                newName: "ResultatsTaula");

            migrationBuilder.RenameTable(
                name: "PartitsPolitics",
                newName: "PartitMunicipi");

            migrationBuilder.RenameIndex(
                name: "IX_TaulesElectorals_resultatsTaulaID",
                table: "TaulaElectoral",
                newName: "IX_TaulaElectoral_resultatsTaulaID");

            migrationBuilder.RenameIndex(
                name: "IX_TaulesElectorals_MunicipiID",
                table: "TaulaElectoral",
                newName: "IX_TaulaElectoral_MunicipiID");

            migrationBuilder.RenameIndex(
                name: "IX_PartitsPolitics_MunicipiID",
                table: "PartitMunicipi",
                newName: "IX_PartitMunicipi_MunicipiID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TaulaElectoral",
                table: "TaulaElectoral",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ResultatsTaula",
                table: "ResultatsTaula",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PartitMunicipi",
                table: "PartitMunicipi",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Candidat_PartitMunicipi_PartitMunicipiID",
                table: "Candidat",
                column: "PartitMunicipiID",
                principalTable: "PartitMunicipi",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_PartitMunicipi_Municipis_MunicipiID",
                table: "PartitMunicipi",
                column: "MunicipiID",
                principalTable: "Municipis",
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
    }
}
