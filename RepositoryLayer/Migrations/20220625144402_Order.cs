using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class Order : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Slider",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 25, 18, 44, 2, 131, DateTimeKind.Local).AddTicks(2368),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 25, 18, 39, 34, 106, DateTimeKind.Local).AddTicks(91));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "RoomImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 25, 18, 44, 2, 137, DateTimeKind.Local).AddTicks(3425),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 25, 18, 39, 34, 111, DateTimeKind.Local).AddTicks(7878));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Reservation",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 25, 18, 44, 2, 132, DateTimeKind.Local).AddTicks(1305),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 25, 18, 39, 34, 106, DateTimeKind.Local).AddTicks(8680));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "House",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 25, 18, 44, 2, 135, DateTimeKind.Local).AddTicks(5600),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 25, 18, 39, 34, 110, DateTimeKind.Local).AddTicks(1017));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "HotelListImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 25, 18, 44, 2, 137, DateTimeKind.Local).AddTicks(9243),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 25, 18, 39, 34, 112, DateTimeKind.Local).AddTicks(3252));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "HotelList",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 25, 18, 44, 2, 129, DateTimeKind.Local).AddTicks(6392),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 25, 18, 39, 34, 104, DateTimeKind.Local).AddTicks(5160));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "HotelDescription",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 25, 18, 44, 2, 138, DateTimeKind.Local).AddTicks(8347),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 25, 18, 39, 34, 113, DateTimeKind.Local).AddTicks(1302));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "FamousCity",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 25, 18, 44, 2, 123, DateTimeKind.Local).AddTicks(5070),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 25, 18, 39, 34, 99, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Category",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 25, 18, 44, 2, 136, DateTimeKind.Local).AddTicks(7752),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 25, 18, 39, 34, 111, DateTimeKind.Local).AddTicks(2701));

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoftDelete = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Slider",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 25, 18, 39, 34, 106, DateTimeKind.Local).AddTicks(91),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 25, 18, 44, 2, 131, DateTimeKind.Local).AddTicks(2368));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "RoomImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 25, 18, 39, 34, 111, DateTimeKind.Local).AddTicks(7878),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 25, 18, 44, 2, 137, DateTimeKind.Local).AddTicks(3425));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Reservation",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 25, 18, 39, 34, 106, DateTimeKind.Local).AddTicks(8680),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 25, 18, 44, 2, 132, DateTimeKind.Local).AddTicks(1305));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "House",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 25, 18, 39, 34, 110, DateTimeKind.Local).AddTicks(1017),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 25, 18, 44, 2, 135, DateTimeKind.Local).AddTicks(5600));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "HotelListImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 25, 18, 39, 34, 112, DateTimeKind.Local).AddTicks(3252),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 25, 18, 44, 2, 137, DateTimeKind.Local).AddTicks(9243));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "HotelList",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 25, 18, 39, 34, 104, DateTimeKind.Local).AddTicks(5160),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 25, 18, 44, 2, 129, DateTimeKind.Local).AddTicks(6392));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "HotelDescription",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 25, 18, 39, 34, 113, DateTimeKind.Local).AddTicks(1302),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 25, 18, 44, 2, 138, DateTimeKind.Local).AddTicks(8347));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "FamousCity",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 25, 18, 39, 34, 99, DateTimeKind.Local).AddTicks(4609),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 25, 18, 44, 2, 123, DateTimeKind.Local).AddTicks(5070));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Category",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 25, 18, 39, 34, 111, DateTimeKind.Local).AddTicks(2701),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 25, 18, 44, 2, 136, DateTimeKind.Local).AddTicks(7752));
        }
    }
}
