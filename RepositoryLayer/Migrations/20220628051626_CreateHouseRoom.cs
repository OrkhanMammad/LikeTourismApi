using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class CreateHouseRoom : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Slider",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 28, 9, 16, 25, 776, DateTimeKind.Local).AddTicks(5887),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 28, 8, 22, 2, 148, DateTimeKind.Local).AddTicks(8133));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "RoomImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 28, 9, 16, 25, 783, DateTimeKind.Local).AddTicks(5184),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 28, 8, 22, 2, 161, DateTimeKind.Local).AddTicks(4978));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Reservation",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 28, 9, 16, 25, 777, DateTimeKind.Local).AddTicks(4150),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 28, 8, 22, 2, 150, DateTimeKind.Local).AddTicks(3292));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Order",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 28, 9, 16, 25, 786, DateTimeKind.Local).AddTicks(9507),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 28, 8, 22, 2, 165, DateTimeKind.Local).AddTicks(2845));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "HouseImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 28, 9, 16, 25, 787, DateTimeKind.Local).AddTicks(5127),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 28, 8, 22, 2, 165, DateTimeKind.Local).AddTicks(8894));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "House",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 28, 9, 16, 25, 781, DateTimeKind.Local).AddTicks(8707),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 28, 8, 22, 2, 159, DateTimeKind.Local).AddTicks(5529));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "HotelListImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 28, 9, 16, 25, 784, DateTimeKind.Local).AddTicks(217),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 28, 8, 22, 2, 162, DateTimeKind.Local).AddTicks(749));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "HotelList",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 28, 9, 16, 25, 775, DateTimeKind.Local).AddTicks(1112),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 28, 8, 22, 2, 146, DateTimeKind.Local).AddTicks(2408));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "HotelDescription",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 28, 9, 16, 25, 784, DateTimeKind.Local).AddTicks(8083),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 28, 8, 22, 2, 162, DateTimeKind.Local).AddTicks(9954));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "FamousCity",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 28, 9, 16, 25, 770, DateTimeKind.Local).AddTicks(725),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 28, 8, 22, 2, 137, DateTimeKind.Local).AddTicks(4007));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Category",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 28, 9, 16, 25, 782, DateTimeKind.Local).AddTicks(9923),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 28, 8, 22, 2, 160, DateTimeKind.Local).AddTicks(9344));

            migrationBuilder.CreateTable(
                name: "HouseRoom",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    RoomType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoomPrise = table.Column<int>(type: "int", nullable: false),
                    Remained = table.Column<int>(type: "int", nullable: false),
                    HouseId = table.Column<int>(type: "int", nullable: false),
                    SoftDelete = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 6, 28, 9, 16, 25, 789, DateTimeKind.Local).AddTicks(6518))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HouseRoom", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HouseRoom_House_HouseId",
                        column: x => x.HouseId,
                        principalTable: "House",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HouseRoom_HouseId",
                table: "HouseRoom",
                column: "HouseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HouseRoom");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Slider",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 28, 8, 22, 2, 148, DateTimeKind.Local).AddTicks(8133),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 28, 9, 16, 25, 776, DateTimeKind.Local).AddTicks(5887));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "RoomImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 28, 8, 22, 2, 161, DateTimeKind.Local).AddTicks(4978),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 28, 9, 16, 25, 783, DateTimeKind.Local).AddTicks(5184));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Reservation",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 28, 8, 22, 2, 150, DateTimeKind.Local).AddTicks(3292),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 28, 9, 16, 25, 777, DateTimeKind.Local).AddTicks(4150));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Order",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 28, 8, 22, 2, 165, DateTimeKind.Local).AddTicks(2845),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 28, 9, 16, 25, 786, DateTimeKind.Local).AddTicks(9507));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "HouseImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 28, 8, 22, 2, 165, DateTimeKind.Local).AddTicks(8894),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 28, 9, 16, 25, 787, DateTimeKind.Local).AddTicks(5127));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "House",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 28, 8, 22, 2, 159, DateTimeKind.Local).AddTicks(5529),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 28, 9, 16, 25, 781, DateTimeKind.Local).AddTicks(8707));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "HotelListImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 28, 8, 22, 2, 162, DateTimeKind.Local).AddTicks(749),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 28, 9, 16, 25, 784, DateTimeKind.Local).AddTicks(217));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "HotelList",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 28, 8, 22, 2, 146, DateTimeKind.Local).AddTicks(2408),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 28, 9, 16, 25, 775, DateTimeKind.Local).AddTicks(1112));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "HotelDescription",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 28, 8, 22, 2, 162, DateTimeKind.Local).AddTicks(9954),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 28, 9, 16, 25, 784, DateTimeKind.Local).AddTicks(8083));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "FamousCity",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 28, 8, 22, 2, 137, DateTimeKind.Local).AddTicks(4007),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 28, 9, 16, 25, 770, DateTimeKind.Local).AddTicks(725));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Category",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 28, 8, 22, 2, 160, DateTimeKind.Local).AddTicks(9344),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 28, 9, 16, 25, 782, DateTimeKind.Local).AddTicks(9923));
        }
    }
}
