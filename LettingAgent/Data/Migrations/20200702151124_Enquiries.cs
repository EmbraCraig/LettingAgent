using Microsoft.EntityFrameworkCore.Migrations;

namespace LettingAgent.Data.Migrations
{
    public partial class Enquiries : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Enquiry",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    PropertyId = table.Column<int>(nullable: false),
                    EnquiryText = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enquiry", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Enquiry_Property_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Property",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Enquiry_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Enquiry_PropertyId",
                table: "Enquiry",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_Enquiry_UserId",
                table: "Enquiry",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Enquiry");
        }
    }
}
