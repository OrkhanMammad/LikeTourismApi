using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace RepositoryLayer.Migrations
{
    public partial class ReservationChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Slider",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 12, 18, 51, 22, 927, DateTimeKind.Local).AddTicks(7102),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 12, 18, 45, 32, 107, DateTimeKind.Local).AddTicks(4546));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "RoomImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 12, 18, 51, 22, 933, DateTimeKind.Local).AddTicks(7273),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 12, 18, 45, 32, 114, DateTimeKind.Local).AddTicks(6394));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Reservation",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 12, 18, 51, 22, 929, DateTimeKind.Local).AddTicks(9809),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 12, 18, 45, 32, 110, DateTimeKind.Local).AddTicks(4882));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "House",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 12, 18, 51, 22, 932, DateTimeKind.Local).AddTicks(4954),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 12, 18, 45, 32, 112, DateTimeKind.Local).AddTicks(8738));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "HotelList",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 12, 18, 51, 22, 926, DateTimeKind.Local).AddTicks(6179),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 12, 18, 45, 32, 105, DateTimeKind.Local).AddTicks(9649));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "FamousCity",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 12, 18, 51, 22, 918, DateTimeKind.Local).AddTicks(1687),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 12, 18, 45, 32, 95, DateTimeKind.Local).AddTicks(6124));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Category",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 12, 18, 51, 22, 933, DateTimeKind.Local).AddTicks(3355),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 12, 18, 45, 32, 114, DateTimeKind.Local).AddTicks(852));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Slider",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 12, 18, 45, 32, 107, DateTimeKind.Local).AddTicks(4546),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 12, 18, 51, 22, 927, DateTimeKind.Local).AddTicks(7102));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "RoomImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 12, 18, 45, 32, 114, DateTimeKind.Local).AddTicks(6394),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 12, 18, 51, 22, 933, DateTimeKind.Local).AddTicks(7273));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Reservation",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 12, 18, 45, 32, 110, DateTimeKind.Local).AddTicks(4882),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 12, 18, 51, 22, 929, DateTimeKind.Local).AddTicks(9809));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "House",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 12, 18, 45, 32, 112, DateTimeKind.Local).AddTicks(8738),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 12, 18, 51, 22, 932, DateTimeKind.Local).AddTicks(4954));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "HotelList",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 12, 18, 45, 32, 105, DateTimeKind.Local).AddTicks(9649),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 12, 18, 51, 22, 926, DateTimeKind.Local).AddTicks(6179));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "FamousCity",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 12, 18, 45, 32, 95, DateTimeKind.Local).AddTicks(6124),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 12, 18, 51, 22, 918, DateTimeKind.Local).AddTicks(1687));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Category",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 12, 18, 45, 32, 114, DateTimeKind.Local).AddTicks(852),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 12, 18, 51, 22, 933, DateTimeKind.Local).AddTicks(3355));
        }
    }
}
