using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class OrderHotel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Slider",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 25, 18, 50, 2, 534, DateTimeKind.Local).AddTicks(5348),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 25, 18, 47, 34, 420, DateTimeKind.Local).AddTicks(1497));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "RoomImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 25, 18, 50, 2, 546, DateTimeKind.Local).AddTicks(9048),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 25, 18, 47, 34, 430, DateTimeKind.Local).AddTicks(9497));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Reservation",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 25, 18, 50, 2, 536, DateTimeKind.Local).AddTicks(102),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 25, 18, 47, 34, 421, DateTimeKind.Local).AddTicks(7157));

            migrationBuilder.AddColumn<int>(
                name: "HotelListId",
                table: "Order",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "House",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 25, 18, 50, 2, 543, DateTimeKind.Local).AddTicks(6599),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 25, 18, 47, 34, 427, DateTimeKind.Local).AddTicks(7073));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "HotelListImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 25, 18, 50, 2, 547, DateTimeKind.Local).AddTicks(9043),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 25, 18, 47, 34, 431, DateTimeKind.Local).AddTicks(7216));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "HotelList",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 25, 18, 50, 2, 532, DateTimeKind.Local).AddTicks(5226),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 25, 18, 47, 34, 417, DateTimeKind.Local).AddTicks(5328));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "HotelDescription",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 25, 18, 50, 2, 549, DateTimeKind.Local).AddTicks(3233),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 25, 18, 47, 34, 433, DateTimeKind.Local).AddTicks(1864));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "FamousCity",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 25, 18, 50, 2, 524, DateTimeKind.Local).AddTicks(8205),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 25, 18, 47, 34, 408, DateTimeKind.Local).AddTicks(1122));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Category",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 25, 18, 50, 2, 545, DateTimeKind.Local).AddTicks(8261),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 25, 18, 47, 34, 430, DateTimeKind.Local).AddTicks(749));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HotelListId",
                table: "Order");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Slider",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 25, 18, 47, 34, 420, DateTimeKind.Local).AddTicks(1497),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 25, 18, 50, 2, 534, DateTimeKind.Local).AddTicks(5348));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "RoomImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 25, 18, 47, 34, 430, DateTimeKind.Local).AddTicks(9497),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 25, 18, 50, 2, 546, DateTimeKind.Local).AddTicks(9048));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Reservation",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 25, 18, 47, 34, 421, DateTimeKind.Local).AddTicks(7157),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 25, 18, 50, 2, 536, DateTimeKind.Local).AddTicks(102));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "House",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 25, 18, 47, 34, 427, DateTimeKind.Local).AddTicks(7073),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 25, 18, 50, 2, 543, DateTimeKind.Local).AddTicks(6599));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "HotelListImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 25, 18, 47, 34, 431, DateTimeKind.Local).AddTicks(7216),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 25, 18, 50, 2, 547, DateTimeKind.Local).AddTicks(9043));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "HotelList",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 25, 18, 47, 34, 417, DateTimeKind.Local).AddTicks(5328),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 25, 18, 50, 2, 532, DateTimeKind.Local).AddTicks(5226));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "HotelDescription",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 25, 18, 47, 34, 433, DateTimeKind.Local).AddTicks(1864),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 25, 18, 50, 2, 549, DateTimeKind.Local).AddTicks(3233));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "FamousCity",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 25, 18, 47, 34, 408, DateTimeKind.Local).AddTicks(1122),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 25, 18, 50, 2, 524, DateTimeKind.Local).AddTicks(8205));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Category",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 25, 18, 47, 34, 430, DateTimeKind.Local).AddTicks(749),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 25, 18, 50, 2, 545, DateTimeKind.Local).AddTicks(8261));
        }
    }
}
