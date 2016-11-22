using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MvcMovie.Migrations
{
    public partial class alteri2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "key",
                table: "Movie",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "Movie",
                nullable: false)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "key",
                table: "Movie");

            migrationBuilder.AlterColumn<string>(
                name: "ID",
                table: "Movie",
                nullable: false);
        }
    }
}
