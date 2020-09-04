using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class addReturningDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "Cost",
                table: "DelegationItems",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ReturningData",
                table: "DelegationItems",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cost",
                table: "DelegationItems");

            migrationBuilder.DropColumn(
                name: "ReturningData",
                table: "DelegationItems");
        }
    }
}
