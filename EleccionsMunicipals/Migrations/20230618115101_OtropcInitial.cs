using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EleccionsMunicipals.Migrations
{
    /// <inheritdoc />
    public partial class OtropcInitial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Candidat_PartitsPolitics_PartitPoliticID",
                table: "Candidat");

            migrationBuilder.RenameColumn(
                name: "PartitPoliticID",
                table: "Candidat",
                newName: "LlistaPartitMunicipiID");

            migrationBuilder.RenameIndex(
                name: "IX_Candidat_PartitPoliticID",
                table: "Candidat",
                newName: "IX_Candidat_LlistaPartitMunicipiID");

            migrationBuilder.AddColumn<long>(
                name: "MunicipiID",
                table: "PartitsPolitics",
                type: "bigint",
                nullable: true);

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
                name: "FK_PartitsPolitics_Municipis_MunicipiID",
                table: "PartitsPolitics",
                column: "MunicipiID",
                principalTable: "Municipis",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Candidat_PartitsPolitics_LlistaPartitMunicipiID",
                table: "Candidat");

            migrationBuilder.DropForeignKey(
                name: "FK_PartitsPolitics_Municipis_MunicipiID",
                table: "PartitsPolitics");

            migrationBuilder.DropIndex(
                name: "IX_PartitsPolitics_MunicipiID",
                table: "PartitsPolitics");

            migrationBuilder.DropColumn(
                name: "MunicipiID",
                table: "PartitsPolitics");

            migrationBuilder.RenameColumn(
                name: "LlistaPartitMunicipiID",
                table: "Candidat",
                newName: "PartitPoliticID");

            migrationBuilder.RenameIndex(
                name: "IX_Candidat_LlistaPartitMunicipiID",
                table: "Candidat",
                newName: "IX_Candidat_PartitPoliticID");

            migrationBuilder.AddForeignKey(
                name: "FK_Candidat_PartitsPolitics_PartitPoliticID",
                table: "Candidat",
                column: "PartitPoliticID",
                principalTable: "PartitsPolitics",
                principalColumn: "ID");
        }
    }
}
