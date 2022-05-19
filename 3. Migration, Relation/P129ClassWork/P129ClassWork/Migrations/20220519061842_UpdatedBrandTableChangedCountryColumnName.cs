﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace P129ClassWork.Migrations
{
    public partial class UpdatedBrandTableChangedCountryColumnName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Country",
                table: "Brands");

            migrationBuilder.AddColumn<string>(
                name: "Olkesi",
                table: "Brands",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Olkesi",
                table: "Brands");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Brands",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
