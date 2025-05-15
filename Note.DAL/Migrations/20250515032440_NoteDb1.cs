using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Note.DAL.Migrations
{
    /// <inheritdoc />
    public partial class NoteDb1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Notices",
                columns: table => new
                {
                    NoticeNo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NoticeTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NoticeContents = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NoticeWriteDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notices", x => x.NoticeNo);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notices");
        }
    }
}
