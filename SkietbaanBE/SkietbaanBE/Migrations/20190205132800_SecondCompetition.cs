﻿using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SkietbaanBE.Migrations
{
    public partial class SecondCompetition : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
               name: "Competition",
               columns: table => new {
                   Id = table.Column<int>(nullable: false)
                       .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                   Name = table.Column<string>(nullable: true),
                   Status = table.Column<bool>(nullable: false)
               },
               constraints: table => {
                   table.PrimaryKey("PK_Competition", x => x.Id);
               });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
               name: "Competition");
        }
    }
}