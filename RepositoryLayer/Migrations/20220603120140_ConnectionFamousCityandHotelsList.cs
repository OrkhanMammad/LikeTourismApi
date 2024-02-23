using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace RepositoryLayer.Migrations
{
    public partial class ConnectionFamousCityandHotelsList : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Slider",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 3, 16, 1, 39, 906, DateTimeKind.Local).AddTicks(9179),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 2, 18, 30, 27, 797, DateTimeKind.Local).AddTicks(3579));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Reservation",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 3, 16, 1, 39, 908, DateTimeKind.Local).AddTicks(9334),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 2, 18, 30, 27, 798, DateTimeKind.Local).AddTicks(5670));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "HotelList",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 3, 16, 1, 39, 904, DateTimeKind.Local).AddTicks(4301),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 2, 18, 30, 27, 796, DateTimeKind.Local).AddTicks(3740));

            migrationBuilder.AddColumn<int>(
                name: "FamousCityId",
                table: "HotelList",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "FamousCity",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 3, 16, 1, 39, 887, DateTimeKind.Local).AddTicks(5725),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 2, 18, 30, 27, 786, DateTimeKind.Local).AddTicks(318));

            migrationBuilder.CreateIndex(
                name: "IX_HotelList_FamousCityId",
                table: "HotelList",
                column: "FamousCityId");

            migrationBuilder.AddForeignKey(
                name: "FK_HotelList_FamousCity_FamousCityId",
                table: "HotelList",
                column: "FamousCityId",
                principalTable: "FamousCity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HotelList_FamousCity_FamousCityId",
                table: "HotelList");

            migrationBuilder.DropIndex(
                name: "IX_HotelList_FamousCityId",
                table: "HotelList");

            migrationBuilder.DropColumn(
                name: "FamousCityId",
                table: "HotelList");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Slider",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 2, 18, 30, 27, 797, DateTimeKind.Local).AddTicks(3579),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 3, 16, 1, 39, 906, DateTimeKind.Local).AddTicks(9179));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Reservation",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 2, 18, 30, 27, 798, DateTimeKind.Local).AddTicks(5670),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 3, 16, 1, 39, 908, DateTimeKind.Local).AddTicks(9334));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "HotelList",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 2, 18, 30, 27, 796, DateTimeKind.Local).AddTicks(3740),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 3, 16, 1, 39, 904, DateTimeKind.Local).AddTicks(4301));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "FamousCity",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 2, 18, 30, 27, 786, DateTimeKind.Local).AddTicks(318),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 3, 16, 1, 39, 887, DateTimeKind.Local).AddTicks(5725));
        }
    }
}
