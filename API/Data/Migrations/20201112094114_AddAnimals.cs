﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Data.Migrations
{
    public partial class AddAnimals : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Breed = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    NickName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animals");
        }
    }
}
