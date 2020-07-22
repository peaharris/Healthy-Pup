﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace HealthyPUP.Migrations
{
    public partial class OneToRuleThemAll : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProfilePicture",
                table: "Dogs",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProfilePicture",
                table: "Dogs");
        }
    }
}
