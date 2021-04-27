using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NewsWebsite.Data.Migrations
{
    public partial class UpdateAppUserTableMillisecond : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "PublishDateTime",
                table: "Videos",
                nullable: true,
                defaultValueSql: "CONVERT(DATETIME, CONVERT(VARCHAR(20),GetDate(),120))",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValueSql: "CONVERT(datetime,GetDate())");

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisterDateTime",
                table: "AppUsers",
                nullable: true,
                defaultValueSql: "CONVERT(DATETIME, CONVERT(VARCHAR(20),GetDate(),120))",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValueSql: "CONVERT(datetime,GetDate())");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "PublishDateTime",
                table: "Videos",
                type: "datetime2",
                nullable: true,
                defaultValueSql: "CONVERT(datetime,GetDate())",
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValueSql: "CONVERT(DATETIME, CONVERT(VARCHAR(20),GetDate(),120))");

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisterDateTime",
                table: "AppUsers",
                type: "datetime2",
                nullable: true,
                defaultValueSql: "CONVERT(datetime,GetDate())",
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValueSql: "CONVERT(DATETIME, CONVERT(VARCHAR(20),GetDate(),120))");
        }
    }
}
