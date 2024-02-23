using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class CreateHouseImagess : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Slider",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 28, 8, 22, 2, 148, DateTimeKind.Local).AddTicks(8133),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 28, 8, 15, 51, 469, DateTimeKind.Local).AddTicks(9223));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "RoomImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 28, 8, 22, 2, 161, DateTimeKind.Local).AddTicks(4978),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 28, 8, 15, 51, 477, DateTimeKind.Local).AddTicks(8590));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Reservation",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 28, 8, 22, 2, 150, DateTimeKind.Local).AddTicks(3292),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 28, 8, 15, 51, 471, DateTimeKind.Local).AddTicks(5629));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Order",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 28, 8, 22, 2, 165, DateTimeKind.Local).AddTicks(2845),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 28, 8, 15, 51, 483, DateTimeKind.Local).AddTicks(2165));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "HouseImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 28, 8, 22, 2, 165, DateTimeKind.Local).AddTicks(8894),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 28, 8, 15, 51, 485, DateTimeKind.Local).AddTicks(6615));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "House",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 28, 8, 22, 2, 159, DateTimeKind.Local).AddTicks(5529),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 28, 8, 15, 51, 475, DateTimeKind.Local).AddTicks(3714));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "HotelListImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 28, 8, 22, 2, 162, DateTimeKind.Local).AddTicks(749),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 28, 8, 15, 51, 478, DateTimeKind.Local).AddTicks(6892));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "HotelList",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 28, 8, 22, 2, 146, DateTimeKind.Local).AddTicks(2408),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 28, 8, 15, 51, 468, DateTimeKind.Local).AddTicks(2876));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "HotelDescription",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 28, 8, 22, 2, 162, DateTimeKind.Local).AddTicks(9954),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 28, 8, 15, 51, 480, DateTimeKind.Local).AddTicks(1039));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "FamousCity",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 28, 8, 22, 2, 137, DateTimeKind.Local).AddTicks(4007),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 28, 8, 15, 51, 462, DateTimeKind.Local).AddTicks(2807));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Category",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 28, 8, 22, 2, 160, DateTimeKind.Local).AddTicks(9344),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 28, 8, 15, 51, 477, DateTimeKind.Local).AddTicks(86));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Slider",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 28, 8, 15, 51, 469, DateTimeKind.Local).AddTicks(9223),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 28, 8, 22, 2, 148, DateTimeKind.Local).AddTicks(8133));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "RoomImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 28, 8, 15, 51, 477, DateTimeKind.Local).AddTicks(8590),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 28, 8, 22, 2, 161, DateTimeKind.Local).AddTicks(4978));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Reservation",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 28, 8, 15, 51, 471, DateTimeKind.Local).AddTicks(5629),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 28, 8, 22, 2, 150, DateTimeKind.Local).AddTicks(3292));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Order",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 28, 8, 15, 51, 483, DateTimeKind.Local).AddTicks(2165),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 28, 8, 22, 2, 165, DateTimeKind.Local).AddTicks(2845));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "HouseImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 28, 8, 15, 51, 485, DateTimeKind.Local).AddTicks(6615),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 28, 8, 22, 2, 165, DateTimeKind.Local).AddTicks(8894));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "House",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 28, 8, 15, 51, 475, DateTimeKind.Local).AddTicks(3714),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 28, 8, 22, 2, 159, DateTimeKind.Local).AddTicks(5529));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "HotelListImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 28, 8, 15, 51, 478, DateTimeKind.Local).AddTicks(6892),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 28, 8, 22, 2, 162, DateTimeKind.Local).AddTicks(749));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "HotelList",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 28, 8, 15, 51, 468, DateTimeKind.Local).AddTicks(2876),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 28, 8, 22, 2, 146, DateTimeKind.Local).AddTicks(2408));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "HotelDescription",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 28, 8, 15, 51, 480, DateTimeKind.Local).AddTicks(1039),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 28, 8, 22, 2, 162, DateTimeKind.Local).AddTicks(9954));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "FamousCity",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 28, 8, 15, 51, 462, DateTimeKind.Local).AddTicks(2807),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 28, 8, 22, 2, 137, DateTimeKind.Local).AddTicks(4007));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Category",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 28, 8, 15, 51, 477, DateTimeKind.Local).AddTicks(86),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 28, 8, 22, 2, 160, DateTimeKind.Local).AddTicks(9344));
        }
    }
}
