using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AspNetMvcBlog.Migrations
{
    /// <inheritdoc />
    public partial class _1002 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "UserEmail", "UserName", "UserNick", "UserPassword", "UserSurname" },
                values: new object[] { "ozozoz@gmail.com", "Ozge", "ozoz", "1234", "Ozyurt" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "UserEmail", "UserName", "UserNick", "UserPassword", "UserSurname" },
                values: new object[] { "cemh@hotmail.com", "Cem", "Cemollokkko", "cem12", "Hossoz" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "UserEmail", "UserName", "UserNick", "UserPassword", "UserSurname" },
                values: new object[] { "KibisTokmak@gmail.com", "Kibariye", "Tokmakçı", "341582", "Tokmak" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "UserEmail", "UserName", "UserNick", "UserPassword", "UserSurname" },
                values: new object[] { "Zekis@hotmail.com", "Zeki", "UçaktanAtlayan", "319482", "Müren" });
        }
    }
}
