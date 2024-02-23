using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class OrderReservation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Slider",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 25, 18, 47, 34, 420, DateTimeKind.Local).AddTicks(1497),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 25, 18, 44, 2, 131, DateTimeKind.Local).AddTicks(2368));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "RoomImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 25, 18, 47, 34, 430, DateTimeKind.Local).AddTicks(9497),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 25, 18, 44, 2, 137, DateTimeKind.Local).AddTicks(3425));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Reservation",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 25, 18, 47, 34, 421, DateTimeKind.Local).AddTicks(7157),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 25, 18, 44, 2, 132, DateTimeKind.Local).AddTicks(1305));

            migrationBuilder.AddColumn<int>(
                name: "ReservationId",
                table: "Order",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "House",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 25, 18, 47, 34, 427, DateTimeKind.Local).AddTicks(7073),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 25, 18, 44, 2, 135, DateTimeKind.Local).AddTicks(5600));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "HotelListImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 25, 18, 47, 34, 431, DateTimeKind.Local).AddTicks(7216),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 25, 18, 44, 2, 137, DateTimeKind.Local).AddTicks(9243));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "HotelList",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 25, 18, 47, 34, 417, DateTimeKind.Local).AddTicks(5328),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 25, 18, 44, 2, 129, DateTimeKind.Local).AddTicks(6392));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "HotelDescription",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 25, 18, 47, 34, 433, DateTimeKind.Local).AddTicks(1864),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 25, 18, 44, 2, 138, DateTimeKind.Local).AddTicks(8347));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "FamousCity",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 25, 18, 47, 34, 408, DateTimeKind.Local).AddTicks(1122),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 25, 18, 44, 2, 123, DateTimeKind.Local).AddTicks(5070));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Category",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 25, 18, 47, 34, 430, DateTimeKind.Local).AddTicks(749),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 25, 18, 44, 2, 136, DateTimeKind.Local).AddTicks(7752));

            migrationBuilder.CreateIndex(
                name: "IX_Order_ReservationId",
                table: "Order",
                column: "ReservationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Reservation_ReservationId",
                table: "Order",
                column: "ReservationId",
                principalTable: "Reservation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Reservation_ReservationId",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_ReservationId",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "ReservationId",
                table: "Order");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Slider",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 25, 18, 44, 2, 131, DateTimeKind.Local).AddTicks(2368),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 25, 18, 47, 34, 420, DateTimeKind.Local).AddTicks(1497));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "RoomImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 25, 18, 44, 2, 137, DateTimeKind.Local).AddTicks(3425),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 25, 18, 47, 34, 430, DateTimeKind.Local).AddTicks(9497));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Reservation",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 25, 18, 44, 2, 132, DateTimeKind.Local).AddTicks(1305),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 25, 18, 47, 34, 421, DateTimeKind.Local).AddTicks(7157));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "House",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 25, 18, 44, 2, 135, DateTimeKind.Local).AddTicks(5600),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 25, 18, 47, 34, 427, DateTimeKind.Local).AddTicks(7073));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "HotelListImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 25, 18, 44, 2, 137, DateTimeKind.Local).AddTicks(9243),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 25, 18, 47, 34, 431, DateTimeKind.Local).AddTicks(7216));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "HotelList",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 25, 18, 44, 2, 129, DateTimeKind.Local).AddTicks(6392),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 25, 18, 47, 34, 417, DateTimeKind.Local).AddTicks(5328));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "HotelDescription",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 25, 18, 44, 2, 138, DateTimeKind.Local).AddTicks(8347),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 25, 18, 47, 34, 433, DateTimeKind.Local).AddTicks(1864));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "FamousCity",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 25, 18, 44, 2, 123, DateTimeKind.Local).AddTicks(5070),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 25, 18, 47, 34, 408, DateTimeKind.Local).AddTicks(1122));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Category",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 25, 18, 44, 2, 136, DateTimeKind.Local).AddTicks(7752),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 25, 18, 47, 34, 430, DateTimeKind.Local).AddTicks(749));
        }
    }
}
