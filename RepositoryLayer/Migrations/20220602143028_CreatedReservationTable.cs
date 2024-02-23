using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace RepositoryLayer.Migrations
{
    public partial class CreatedReservationTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Slider",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 2, 18, 30, 27, 797, DateTimeKind.Local).AddTicks(3579),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 28, 15, 32, 54, 855, DateTimeKind.Local).AddTicks(6640));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "HotelList",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 2, 18, 30, 27, 796, DateTimeKind.Local).AddTicks(3740),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 28, 15, 32, 54, 854, DateTimeKind.Local).AddTicks(3211));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "FamousCity",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 2, 18, 30, 27, 786, DateTimeKind.Local).AddTicks(318),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 28, 15, 32, 54, 836, DateTimeKind.Local).AddTicks(9402));

            migrationBuilder.CreateTable(
                name: "Reservation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoomPrise = table.Column<int>(type: "int", nullable: false),
                    Breakfast = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoftDelete = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 6, 2, 18, 30, 27, 798, DateTimeKind.Local).AddTicks(5670))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservation", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reservation");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Slider",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 28, 15, 32, 54, 855, DateTimeKind.Local).AddTicks(6640),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 2, 18, 30, 27, 797, DateTimeKind.Local).AddTicks(3579));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "HotelList",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 28, 15, 32, 54, 854, DateTimeKind.Local).AddTicks(3211),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 2, 18, 30, 27, 796, DateTimeKind.Local).AddTicks(3740));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "FamousCity",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 28, 15, 32, 54, 836, DateTimeKind.Local).AddTicks(9402),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 2, 18, 30, 27, 786, DateTimeKind.Local).AddTicks(318));
        }
    }
}
