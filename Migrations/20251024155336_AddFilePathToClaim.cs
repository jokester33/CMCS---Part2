using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CMCS.Migrations
{
    /// <inheritdoc />
    public partial class AddFilePathToClaim : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Claims_Lecturers_LecturerId",
                table: "Claims");

            migrationBuilder.RenameColumn(
                name: "ClaimId",
                table: "Claims",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "Month",
                table: "Claims",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "LecturerId",
                table: "Claims",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<string>(
                name: "FilePath",
                table: "Claims",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "HourlyRate",
                table: "Claims",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "HoursWorked",
                table: "Claims",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "LecturerName",
                table: "Claims",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "Claims",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Claims_Lecturers_LecturerId",
                table: "Claims",
                column: "LecturerId",
                principalTable: "Lecturers",
                principalColumn: "LecturerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Claims_Lecturers_LecturerId",
                table: "Claims");

            migrationBuilder.DropColumn(
                name: "FilePath",
                table: "Claims");

            migrationBuilder.DropColumn(
                name: "HourlyRate",
                table: "Claims");

            migrationBuilder.DropColumn(
                name: "HoursWorked",
                table: "Claims");

            migrationBuilder.DropColumn(
                name: "LecturerName",
                table: "Claims");

            migrationBuilder.DropColumn(
                name: "Notes",
                table: "Claims");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Claims",
                newName: "ClaimId");

            migrationBuilder.AlterColumn<string>(
                name: "Month",
                table: "Claims",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LecturerId",
                table: "Claims",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Claims_Lecturers_LecturerId",
                table: "Claims",
                column: "LecturerId",
                principalTable: "Lecturers",
                principalColumn: "LecturerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
