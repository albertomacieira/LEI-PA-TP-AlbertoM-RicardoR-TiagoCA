using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ticket2Help.DAL.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAfterSeedFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "fMNR7sWD3no=:hLb5tqjyrXCrTwAmKCS51rCrD8AD9KznOX3kW9JdS+I=");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "ToK23QYbnW4=:vdwhOqlnkUkKGeY7NsMa1pKj+N7ml8DAjFqlb6KUPLY=");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "9bRde+gs79I=:PM1DbUvdJ66PX91yf4sjzJrACt7VrFS7gpb1hw4X6V8=");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "jJSqP8TDCTk=:F6wF94Wbf6m6Gm94C3Ba0+T+jljMoDhQ7pNlTVoRI6s=");
        }
    }
}
