using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FolderProject.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Folder",
                columns: table => new
                {
                    FolderId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    ParentId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Folder", x => x.FolderId);
                    table.ForeignKey(
                        name: "FK_Folder_Folder_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Folder",
                        principalColumn: "FolderId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Folder_ParentId",
                table: "Folder",
                column: "ParentId");
            migrationBuilder.InsertData(
            table: "Folder",
            columns: new[] { "Name", "ParentId" },
            values: new object[,]
            {
                { "Creating Digital Images", null },
                { "Resources", 1 },
                { "Evidence", 1 },
                { "Graphic Product", 1 },
                { "Primary Sources", 2 },
                { "Secondary Sources", 2 },
                { "Process", 4 },
                { "Final Product", 4 },
            });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Folder");
        }
    }
}
