using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace RepositoryLayer.Migrations
{
    public partial class CreatedRoomImagesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Slider",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 12, 17, 46, 42, 947, DateTimeKind.Local).AddTicks(7456),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 12, 15, 33, 39, 713, DateTimeKind.Local).AddTicks(8215));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Reservation",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 12, 17, 46, 42, 948, DateTimeKind.Local).AddTicks(9580),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 12, 15, 33, 39, 714, DateTimeKind.Local).AddTicks(9523));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "House",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 12, 17, 46, 42, 952, DateTimeKind.Local).AddTicks(1559),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 12, 15, 33, 39, 717, DateTimeKind.Local).AddTicks(8506));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "HotelList",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 12, 17, 46, 42, 946, DateTimeKind.Local).AddTicks(5005),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 12, 15, 33, 39, 712, DateTimeKind.Local).AddTicks(6385));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "FamousCity",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 12, 17, 46, 42, 934, DateTimeKind.Local).AddTicks(4666),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 12, 15, 33, 39, 703, DateTimeKind.Local).AddTicks(9186));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Category",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 12, 17, 46, 42, 953, DateTimeKind.Local).AddTicks(1897),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 12, 15, 33, 39, 718, DateTimeKind.Local).AddTicks(6925));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Slider",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 12, 15, 33, 39, 713, DateTimeKind.Local).AddTicks(8215),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 12, 17, 46, 42, 947, DateTimeKind.Local).AddTicks(7456));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Reservation",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 12, 15, 33, 39, 714, DateTimeKind.Local).AddTicks(9523),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 12, 17, 46, 42, 948, DateTimeKind.Local).AddTicks(9580));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "House",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 12, 15, 33, 39, 717, DateTimeKind.Local).AddTicks(8506),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 12, 17, 46, 42, 952, DateTimeKind.Local).AddTicks(1559));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "HotelList",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 12, 15, 33, 39, 712, DateTimeKind.Local).AddTicks(6385),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 12, 17, 46, 42, 946, DateTimeKind.Local).AddTicks(5005));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "FamousCity",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 12, 15, 33, 39, 703, DateTimeKind.Local).AddTicks(9186),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 12, 17, 46, 42, 934, DateTimeKind.Local).AddTicks(4666));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Category",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 12, 15, 33, 39, 718, DateTimeKind.Local).AddTicks(6925),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 12, 17, 46, 42, 953, DateTimeKind.Local).AddTicks(1897));
        }
    }
}
