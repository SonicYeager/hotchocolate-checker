using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotChocolate.Checker.Migrations
{
    /// <inheritdoc />
    public partial class AddGenreEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Genre",
                table: "BookEntity");

            migrationBuilder.CreateTable(
                name: "GenreEntity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenreEntity", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "GenreBooksConnectionEntity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    GenreId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenreBooksConnectionEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GenreBooksConnectionEntity_BookEntity_BookId",
                        column: x => x.BookId,
                        principalTable: "BookEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GenreBooksConnectionEntity_GenreEntity_GenreId",
                        column: x => x.GenreId,
                        principalTable: "GenreEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "3508472828551", "ADP", 6472, new DateTime(2023, 5, 20, 15, 29, 37, 889, DateTimeKind.Local).AddTicks(6018), "Kreiger - Abernathy" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "6509583864169", "Incredible", 8780, new DateTime(2023, 3, 5, 22, 8, 30, 245, DateTimeKind.Local).AddTicks(3607), "Wintheiser - Miller" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "4970010577914", "invoice", 1638, new DateTime(2023, 5, 2, 12, 4, 36, 848, DateTimeKind.Local).AddTicks(9679), "Johnson LLC" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "9336162113625", "Avon", 5925, new DateTime(2022, 12, 18, 2, 9, 17, 386, DateTimeKind.Local).AddTicks(9940), "Pacocha Inc" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "5736686165249", "Senior", 7389, new DateTime(2023, 6, 29, 11, 33, 7, 932, DateTimeKind.Local).AddTicks(2970), "Weimann, Langosh and McCullough" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "7522709389123", "logistical", 5452, new DateTime(2023, 1, 19, 3, 3, 45, 967, DateTimeKind.Local).AddTicks(7733), "Renner Group" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "4989958874337", "Bedfordshire", 7714, new DateTime(2023, 2, 25, 4, 23, 28, 628, DateTimeKind.Local).AddTicks(7433), "Hodkiewicz - Volkman" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "6063823056498", "web-readiness", 5268, new DateTime(2023, 3, 25, 22, 4, 29, 779, DateTimeKind.Local).AddTicks(8897), "Collier - MacGyver" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "8444163248480", "generating", 9066, new DateTime(2023, 3, 1, 8, 38, 28, 850, DateTimeKind.Local).AddTicks(6496), "Bode, Morar and McLaughlin" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "2275043239283", "Louisiana", 8039, new DateTime(2023, 3, 3, 6, 4, 52, 834, DateTimeKind.Local).AddTicks(9006), "Krajcik LLC" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "1920042043706", "Soft", 4626, new DateTime(2023, 4, 9, 3, 9, 8, 400, DateTimeKind.Local).AddTicks(3273), "Osinski and Sons" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "7019732649947", "Movies, Beauty & Shoes", 9574, new DateTime(2022, 7, 16, 2, 5, 23, 240, DateTimeKind.Local).AddTicks(2630), "Predovic - Barton" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "9123201510244", "Games & Computers", 9922, new DateTime(2022, 10, 23, 8, 54, 52, 519, DateTimeKind.Local).AddTicks(663), "Johns Inc" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "5537508118517", "engage", 2841, new DateTime(2022, 7, 22, 16, 42, 26, 240, DateTimeKind.Local).AddTicks(4434), "Torp - Schaefer" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "7652383596880", "protocol", 5400, new DateTime(2023, 2, 5, 18, 50, 19, 655, DateTimeKind.Local).AddTicks(7618), "Mayer, Simonis and DuBuque" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "1913220210250", "firmware", 7250, new DateTime(2023, 6, 29, 21, 12, 33, 470, DateTimeKind.Local).AddTicks(3181), "Grimes, Kilback and Koss" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "1875574921421", "reciprocal", 3296, new DateTime(2023, 3, 5, 4, 18, 24, 577, DateTimeKind.Local).AddTicks(8595), "Krajcik LLC" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "8697958197108", "implementation", 264, new DateTime(2023, 6, 16, 7, 13, 27, 999, DateTimeKind.Local).AddTicks(7489), "Spencer and Sons" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "7229529914978", "Practical Wooden Fish", 6001, new DateTime(2023, 6, 23, 20, 6, 15, 709, DateTimeKind.Local).AddTicks(1746), "Armstrong, Franecki and Collier" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "1627078464535", "fresh-thinking", 4147, new DateTime(2023, 6, 25, 13, 27, 50, 213, DateTimeKind.Local).AddTicks(2141), "Grady, Torphy and Dach" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "4961375238268", "hack", 7102, new DateTime(2023, 2, 24, 21, 23, 35, 692, DateTimeKind.Local).AddTicks(7219), "Wiegand, Cormier and Conn" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "0448718451200", "cultivate", 8405, new DateTime(2023, 2, 1, 4, 9, 13, 81, DateTimeKind.Local).AddTicks(3081), "Schinner - Ferry" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "6561754059941", "deposit", 1857, new DateTime(2022, 7, 19, 0, 10, 21, 990, DateTimeKind.Local).AddTicks(9019), "Lowe, Botsford and Brakus" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "6402399660140", "Delaware", 360, new DateTime(2023, 2, 15, 21, 51, 11, 679, DateTimeKind.Local).AddTicks(2756), "Dooley and Sons" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "1081432318290", "Ferry", 1869, new DateTime(2022, 12, 8, 8, 59, 51, 497, DateTimeKind.Local).AddTicks(8024), "Moen - Hauck" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "5242848340015", "TCP", 7480, new DateTime(2022, 9, 11, 13, 1, 0, 761, DateTimeKind.Local).AddTicks(6213), "Cummerata Group" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "0655725658663", "Practical Fresh Car", 3609, new DateTime(2022, 11, 30, 21, 27, 32, 774, DateTimeKind.Local).AddTicks(3148), "Powlowski - Emard" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "5813154829817", "national", 746, new DateTime(2022, 7, 20, 5, 38, 37, 119, DateTimeKind.Local).AddTicks(6268), "Rau and Sons" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "4979132417818", "Spring", 2431, new DateTime(2023, 1, 13, 2, 40, 55, 279, DateTimeKind.Local).AddTicks(2687), "Veum, Willms and McLaughlin" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "8231461100943", "program", 687, new DateTime(2022, 11, 21, 5, 45, 16, 106, DateTimeKind.Local).AddTicks(6998), "Hagenes - Robel" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "7161790853597", "silver", 6472, new DateTime(2023, 4, 12, 14, 56, 19, 148, DateTimeKind.Local).AddTicks(9501), "Wyman and Sons" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "1766118042033", "connecting", 4798, new DateTime(2022, 9, 27, 0, 46, 39, 331, DateTimeKind.Local).AddTicks(8039), "Kautzer - Kuvalis" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "3421696888012", "Producer", 3294, new DateTime(2022, 9, 10, 22, 10, 45, 411, DateTimeKind.Local).AddTicks(5540), "Haley and Sons" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "5814936253806", "Cotton", 6103, new DateTime(2023, 6, 7, 6, 33, 49, 287, DateTimeKind.Local).AddTicks(7413), "Williamson, Wolff and Labadie" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "2957643792503", "Union", 5913, new DateTime(2023, 6, 13, 2, 15, 44, 497, DateTimeKind.Local).AddTicks(5687), "Schmeler - Bogisich" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "1133790419796", "forecast", 8013, new DateTime(2022, 11, 2, 0, 2, 22, 945, DateTimeKind.Local).AddTicks(2755), "Fahey, Weissnat and Wolff" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "2756126043725", "tan", 2919, new DateTime(2022, 11, 21, 15, 16, 13, 957, DateTimeKind.Local).AddTicks(3057), "Parker - Hackett" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "0550609819140", "Roads", 6512, new DateTime(2023, 4, 19, 18, 13, 52, 662, DateTimeKind.Local).AddTicks(9684), "Howell Inc" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "1697566548443", "24/365", 6521, new DateTime(2022, 10, 25, 3, 59, 9, 187, DateTimeKind.Local).AddTicks(8954), "Kuvalis and Sons" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "7886570529102", "Representative", 3849, new DateTime(2022, 12, 14, 18, 6, 7, 430, DateTimeKind.Local).AddTicks(7914), "Jacobson and Sons" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "8206249232307", "concept", 5162, new DateTime(2023, 5, 8, 15, 41, 38, 27, DateTimeKind.Local).AddTicks(5645), "Nicolas - Langworth" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "5048968995797", "Unbranded", 9029, new DateTime(2022, 8, 29, 12, 25, 56, 248, DateTimeKind.Local).AddTicks(5047), "McLaughlin Group" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "2907240358695", "generating", 5020, new DateTime(2023, 2, 13, 15, 30, 42, 660, DateTimeKind.Local).AddTicks(8134), "Keeling - O'Conner" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "9794369142709", "Public-key", 6645, new DateTime(2022, 10, 11, 17, 28, 16, 293, DateTimeKind.Local).AddTicks(8717), "McDermott - Schmitt" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "9911074894383", "Colorado", 266, new DateTime(2022, 12, 21, 7, 17, 52, 732, DateTimeKind.Local).AddTicks(5061), "Abernathy - Blick" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "2396784117026", "mindshare", 2977, new DateTime(2023, 6, 9, 8, 46, 9, 521, DateTimeKind.Local).AddTicks(4532), "Reichert - Koepp" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "2619064213639", "Mall", 6673, new DateTime(2022, 12, 28, 3, 0, 29, 906, DateTimeKind.Local).AddTicks(7776), "Rau, Berge and Zemlak" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "1778130445525", "Ergonomic Granite Computer", 7545, new DateTime(2022, 11, 3, 16, 28, 6, 803, DateTimeKind.Local).AddTicks(1514), "Schiller, Fisher and Hauck" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "5654469990003", "Practical", 5167, new DateTime(2022, 11, 28, 22, 22, 41, 783, DateTimeKind.Local).AddTicks(9673), "Quigley and Sons" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "2223104075509", "Clothing", 7795, new DateTime(2022, 9, 14, 16, 48, 17, 701, DateTimeKind.Local).AddTicks(4126), "Lubowitz - Littel" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "1499444416192", "Personal Loan Account", 2007, new DateTime(2023, 3, 21, 14, 25, 33, 99, DateTimeKind.Local).AddTicks(9802), "Shields Group" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "7227181650739", "Corners", 8294, new DateTime(2022, 9, 16, 1, 16, 25, 473, DateTimeKind.Local).AddTicks(499), "Moore - Emard" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "4315879141409", "bypassing", 169, new DateTime(2023, 5, 9, 6, 53, 14, 711, DateTimeKind.Local).AddTicks(5453), "Kuvalis, Swift and Marquardt" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "1276265140884", "Rue", 3965, new DateTime(2022, 12, 19, 10, 37, 10, 220, DateTimeKind.Local).AddTicks(620), "Hackett, Reynolds and White" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "8344715759221", "engage", 2909, new DateTime(2023, 3, 17, 6, 52, 4, 44, DateTimeKind.Local).AddTicks(7715), "Gislason - Halvorson" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "7465570660956", "synthesizing", 9678, new DateTime(2022, 11, 19, 13, 28, 55, 661, DateTimeKind.Local).AddTicks(9204), "Weissnat, Baumbach and Ernser" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "7869769515759", "approach", 4536, new DateTime(2022, 11, 25, 13, 33, 2, 231, DateTimeKind.Local).AddTicks(1375), "Bahringer, Murazik and Tillman" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "0779185351008", "alliance", 3584, new DateTime(2023, 4, 28, 19, 11, 59, 250, DateTimeKind.Local).AddTicks(3945), "Schiller - Towne" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "4615459590499", "core", 6680, new DateTime(2023, 4, 27, 23, 44, 31, 761, DateTimeKind.Local).AddTicks(6513), "Farrell Inc" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "8614811437355", "Web", 1292, new DateTime(2023, 1, 22, 23, 48, 40, 357, DateTimeKind.Local).AddTicks(1567), "Rolfson - Little" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "4355973624132", "District", 8017, new DateTime(2022, 11, 24, 16, 56, 43, 134, DateTimeKind.Local).AddTicks(7917), "Pacocha LLC" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "9528415549255", "Lead", 7568, new DateTime(2023, 5, 22, 18, 16, 4, 271, DateTimeKind.Local).AddTicks(3497), "Rutherford - Wintheiser" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "3718217653618", "Intelligent Granite Chips", 5914, new DateTime(2023, 4, 5, 9, 8, 43, 810, DateTimeKind.Local).AddTicks(3555), "Funk, Rempel and Koch" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "4402318396312", "payment", 9892, new DateTime(2022, 11, 8, 19, 59, 25, 844, DateTimeKind.Local).AddTicks(8197), "Ward - Deckow" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "8966000262553", "Cambridgeshire", 8104, new DateTime(2022, 7, 27, 14, 15, 8, 747, DateTimeKind.Local).AddTicks(1320), "Kertzmann Inc" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "0032571553401", "deposit", 2842, new DateTime(2023, 6, 18, 3, 19, 49, 904, DateTimeKind.Local).AddTicks(1845), "Pacocha Inc" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "9877083532909", "calculate", 9057, new DateTime(2022, 10, 17, 2, 46, 53, 134, DateTimeKind.Local).AddTicks(1296), "Stoltenberg Inc" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "6799939312196", "Belize Dollar", 9463, new DateTime(2022, 8, 23, 22, 53, 27, 242, DateTimeKind.Local).AddTicks(9310), "Toy, Torp and Bednar" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "1867513513347", "invoice", 7747, new DateTime(2022, 10, 10, 8, 48, 17, 363, DateTimeKind.Local).AddTicks(5931), "Reilly - Jacobs" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "5713091109013", "directional", 2692, new DateTime(2022, 11, 28, 0, 10, 49, 540, DateTimeKind.Local).AddTicks(3594), "Armstrong - Kemmer" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "9497940038070", "Forks", 9609, new DateTime(2023, 1, 7, 11, 57, 43, 935, DateTimeKind.Local).AddTicks(673), "Runte - Moen" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "3514667028156", "Assurance", 833, new DateTime(2023, 3, 24, 5, 19, 7, 756, DateTimeKind.Local).AddTicks(1186), "Bradtke Group" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "6094997352086", "indigo", 5755, new DateTime(2022, 9, 4, 22, 21, 34, 696, DateTimeKind.Local).AddTicks(9111), "Braun - Morissette" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "4007586454339", "South Africa", 1062, new DateTime(2023, 5, 16, 21, 31, 18, 404, DateTimeKind.Local).AddTicks(70), "Tillman - Ryan" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "2296247731007", "withdrawal", 9665, new DateTime(2023, 3, 31, 15, 26, 59, 53, DateTimeKind.Local).AddTicks(9484), "Rempel - McDermott" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "5057869658687", "Unbranded", 5357, new DateTime(2023, 3, 31, 15, 39, 8, 606, DateTimeKind.Local).AddTicks(6941), "Hoppe, Lindgren and Koss" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "3506321494735", "monitor", 9871, new DateTime(2023, 5, 10, 16, 13, 54, 87, DateTimeKind.Local).AddTicks(1237), "Franecki Group" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "9270337192490", "incentivize", 3703, new DateTime(2022, 8, 20, 17, 55, 48, 558, DateTimeKind.Local).AddTicks(6919), "Reilly - Wiza" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "1273502431804", "ability", 7262, new DateTime(2023, 4, 2, 13, 18, 16, 772, DateTimeKind.Local).AddTicks(5456), "Kilback LLC" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "4600440706300", "THX", 5272, new DateTime(2023, 1, 31, 11, 16, 4, 317, DateTimeKind.Local).AddTicks(6212), "Bradtke, Kertzmann and Walsh" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "7244173613299", "Representative", 3583, new DateTime(2023, 6, 21, 4, 54, 26, 477, DateTimeKind.Local).AddTicks(7270), "Satterfield - Huel" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "4763682163604", "Grocery & Electronics", 2989, new DateTime(2022, 10, 30, 23, 16, 32, 555, DateTimeKind.Local).AddTicks(840), "VonRueden - Hilll" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "2744508188454", "Credit Card Account", 857, new DateTime(2022, 10, 5, 16, 26, 24, 78, DateTimeKind.Local).AddTicks(3433), "Bode Group" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "9635436531708", "New Caledonia", 5637, new DateTime(2022, 8, 20, 0, 43, 46, 273, DateTimeKind.Local).AddTicks(9994), "Williamson LLC" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "9479313412014", "Balboa", 4904, new DateTime(2022, 10, 29, 3, 14, 37, 584, DateTimeKind.Local).AddTicks(1675), "Lindgren, Howell and Walter" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "5676958236911", "deposit", 4566, new DateTime(2023, 1, 20, 8, 36, 32, 837, DateTimeKind.Local).AddTicks(3176), "Klein Group" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "0463738753707", "Central African Republic", 6474, new DateTime(2023, 2, 26, 13, 38, 58, 584, DateTimeKind.Local).AddTicks(6438), "Bechtelar Inc" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "9899889236461", "capacitor", 9735, new DateTime(2022, 12, 25, 19, 30, 33, 767, DateTimeKind.Local).AddTicks(1801), "Schuster, Schimmel and Gleichner" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "2651095991575", "Rupiah", 183, new DateTime(2022, 11, 18, 5, 58, 31, 684, DateTimeKind.Local).AddTicks(746), "Oberbrunner - Feeney" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "6870957025166", "actuating", 6881, new DateTime(2023, 1, 31, 23, 55, 17, 252, DateTimeKind.Local).AddTicks(2229), "Feest, Hoeger and Hickle" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "9568747895040", "teal", 2003, new DateTime(2022, 9, 17, 3, 57, 7, 165, DateTimeKind.Local).AddTicks(5199), "Beer - Metz" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "7376023793285", "Coordinator", 9312, new DateTime(2023, 5, 19, 23, 4, 46, 593, DateTimeKind.Local).AddTicks(9514), "Little, Zemlak and Beier" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "4427667211505", "Awesome Steel Pants", 4773, new DateTime(2022, 11, 21, 3, 36, 55, 221, DateTimeKind.Local).AddTicks(9580), "Bernhard - Bechtelar" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "9741525331767", "Mountain", 1440, new DateTime(2023, 5, 15, 13, 3, 35, 682, DateTimeKind.Local).AddTicks(7453), "Schmitt - O'Connell" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "3733841680359", "auxiliary", 5109, new DateTime(2023, 6, 9, 6, 32, 47, 914, DateTimeKind.Local).AddTicks(9004), "Ferry Group" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "2503474453016", "enterprise", 5023, new DateTime(2022, 12, 24, 2, 32, 40, 135, DateTimeKind.Local).AddTicks(9830), "Welch, Roob and Wisoky" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "9148689884618", "copying", 5319, new DateTime(2022, 8, 26, 23, 51, 9, 447, DateTimeKind.Local).AddTicks(9300), "Reichel, D'Amore and Beatty" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "8724639906725", "Marketing", 8532, new DateTime(2023, 5, 22, 11, 47, 0, 916, DateTimeKind.Local).AddTicks(6150), "Keebler, Bashirian and Yundt" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "8145918364379", "teal", 1585, new DateTime(2023, 5, 25, 15, 12, 36, 116, DateTimeKind.Local).AddTicks(1895), "Schulist and Sons" });

            migrationBuilder.InsertData(
                table: "GenreEntity",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Soul" },
                    { 2, "Rock" },
                    { 3, "Rock" },
                    { 4, "Blues" },
                    { 5, "Electronic" },
                    { 6, "Stage And Screen" },
                    { 7, "Rap" },
                    { 8, "Country" },
                    { 9, "Electronic" },
                    { 10, "Rap" },
                    { 11, "Hip Hop" },
                    { 12, "Latin" },
                    { 13, "Rock" },
                    { 14, "Funk" },
                    { 15, "Classical" },
                    { 16, "World" },
                    { 17, "Country" },
                    { 18, "Rap" },
                    { 19, "Reggae" },
                    { 20, "Non Music" },
                    { 21, "World" },
                    { 22, "Soul" },
                    { 23, "Funk" },
                    { 24, "Reggae" },
                    { 25, "Jazz" },
                    { 26, "Electronic" },
                    { 27, "Metal" },
                    { 28, "Folk" },
                    { 29, "Soul" },
                    { 30, "Stage And Screen" },
                    { 31, "Blues" },
                    { 32, "Rap" },
                    { 33, "Blues" },
                    { 34, "Blues" },
                    { 35, "World" },
                    { 36, "World" },
                    { 37, "Latin" },
                    { 38, "Classical" },
                    { 39, "Hip Hop" },
                    { 40, "Country" },
                    { 41, "Country" },
                    { 42, "Folk" },
                    { 43, "Pop" },
                    { 44, "Rap" },
                    { 45, "Folk" },
                    { 46, "Folk" },
                    { 47, "Hip Hop" },
                    { 48, "Folk" },
                    { 49, "Soul" },
                    { 50, "Electronic" },
                    { 51, "Rap" },
                    { 52, "Soul" },
                    { 53, "World" },
                    { 54, "Blues" },
                    { 55, "Blues" },
                    { 56, "Soul" },
                    { 57, "Funk" },
                    { 58, "Soul" },
                    { 59, "Hip Hop" },
                    { 60, "Latin" },
                    { 61, "Pop" },
                    { 62, "Hip Hop" },
                    { 63, "Blues" },
                    { 64, "Hip Hop" },
                    { 65, "Country" },
                    { 66, "Non Music" },
                    { 67, "Stage And Screen" },
                    { 68, "Rock" },
                    { 69, "Reggae" },
                    { 70, "Blues" },
                    { 71, "Pop" },
                    { 72, "Non Music" },
                    { 73, "Non Music" },
                    { 74, "Blues" },
                    { 75, "Pop" },
                    { 76, "Rap" },
                    { 77, "Pop" },
                    { 78, "Blues" },
                    { 79, "Soul" },
                    { 80, "Rock" },
                    { 81, "Stage And Screen" },
                    { 82, "World" },
                    { 83, "Folk" },
                    { 84, "Reggae" },
                    { 85, "Classical" },
                    { 86, "Reggae" },
                    { 87, "Metal" },
                    { 88, "Folk" },
                    { 89, "Rap" },
                    { 90, "World" },
                    { 91, "Soul" },
                    { 92, "Blues" },
                    { 93, "Rock" },
                    { 94, "Rap" },
                    { 95, "Blues" },
                    { 96, "Stage And Screen" },
                    { 97, "Rock" },
                    { 98, "Reggae" },
                    { 99, "Blues" }
                });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Marjorie", "Reynolds" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Bryant", "Kunde" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Damon", "Collins" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Jerald", "Denesik" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Brett", "Kohler" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Jill", "Nitzsche" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Douglas", "Schowalter" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Randall", "Hilpert" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Pete", "Windler" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Elena", "Wolf" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Jean", "Sipes" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Sophia", "Carter" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Lana", "Hilll" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Vicky", "Balistreri" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Andrew", "Kemmer" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Hope", "Krajcik" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Ervin", "Hyatt" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Christopher", "Kuvalis" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Carroll", "Hane" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Philip", "Stark" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Frederick", "Raynor" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Blanche", "Zboncak" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Ramon", "Schiller" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Max", "Pagac" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Vincent", "Jacobs" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Lorraine", "Waelchi" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Jasmine", "Abbott" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Jacqueline", "Dach" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Clifton", "Powlowski" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Darrel", "Rutherford" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Wendell", "Fay" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Charlene", "Williamson" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Ruth", "Shields" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Heather", "Hauck" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Minnie", "Torphy" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Donna", "Nicolas" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Roberta", "Muller" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Daryl", "Zulauf" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Ernesto", "Mayert" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Spencer", "Hagenes" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Nelson", "Hahn" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Rickey", "Waters" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Penny", "Kemmer" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Marlene", "Runolfsson" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Herman", "Satterfield" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Austin", "Kling" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Michele", "Dooley" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Harry", "Robel" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Angie", "Russel" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Brittany", "Bogisich" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Margarita", "Reichel" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Roy", "King" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Christy", "Schneider" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Mack", "Simonis" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Alton", "Bartoletti" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Bradley", "Schowalter" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Curtis", "Cole" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Everett", "Reichel" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Jonathon", "MacGyver" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Angelina", "Auer" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Yvette", "Walter" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Vernon", "Flatley" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Shane", "Keebler" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Noah", "Hahn" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Claude", "Gibson" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Wilbert", "Hilll" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Amanda", "Zboncak" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Edwin", "Pacocha" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Tim", "Hintz" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Hilda", "Daniel" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Rickey", "Purdy" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Maxine", "Nienow" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Reginald", "Schumm" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Kathy", "Kuhlman" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Pam", "Kunze" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Rolando", "Watsica" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Jessie", "Goyette" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Tasha", "Olson" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Michelle", "Marquardt" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Carrie", "Buckridge" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Ramiro", "Dietrich" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Dora", "Wiza" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Jack", "Deckow" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Wilson", "Schaden" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Alonzo", "Watsica" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Bob", "Wiza" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Miguel", "Hudson" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Mitchell", "Hegmann" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Judy", "Wilderman" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Dan", "Abernathy" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Lamar", "Monahan" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Dennis", "O'Connell" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Alice", "Heller" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Renee", "Bogisich" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Rhonda", "Skiles" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Renee", "Bernhard" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Kurt", "Wyman" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Rick", "Goodwin" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Jackie", "Harvey" });

            migrationBuilder.CreateIndex(
                name: "IX_GenreBooksConnectionEntity_BookId",
                table: "GenreBooksConnectionEntity",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_GenreBooksConnectionEntity_GenreId",
                table: "GenreBooksConnectionEntity",
                column: "GenreId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GenreBooksConnectionEntity");

            migrationBuilder.DropTable(
                name: "GenreEntity");

            migrationBuilder.AddColumn<string>(
                name: "Genre",
                table: "BookEntity",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Latin", "2578066949413", "Research", 8461, new DateTime(2022, 10, 22, 5, 50, 9, 98, DateTimeKind.Local).AddTicks(5870), "Koch Inc" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Blues", "6080081688483", "Wisconsin", 1678, new DateTime(2022, 12, 7, 16, 50, 27, 677, DateTimeKind.Local).AddTicks(7000), "Armstrong - Wolf" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Funk", "2198401616918", "back-end", 278, new DateTime(2022, 7, 27, 7, 0, 53, 163, DateTimeKind.Local).AddTicks(9715), "Sanford, Marquardt and Buckridge" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Pop", "9709776571240", "generate", 1360, new DateTime(2023, 6, 23, 22, 46, 44, 159, DateTimeKind.Local).AddTicks(5832), "Feil LLC" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Soul", "0706326643951", "Grass-roots", 7214, new DateTime(2022, 7, 12, 9, 27, 35, 728, DateTimeKind.Local).AddTicks(9573), "Lowe - Mann" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Stage And Screen", "8874111695644", "Mandatory", 8879, new DateTime(2023, 3, 4, 12, 54, 13, 562, DateTimeKind.Local).AddTicks(7074), "Ullrich Inc" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Rap", "3579108222142", "initiative", 5361, new DateTime(2023, 7, 4, 23, 18, 38, 552, DateTimeKind.Local).AddTicks(2257), "VonRueden Group" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Rock", "7557348716566", "Vatu", 2704, new DateTime(2023, 3, 7, 1, 22, 18, 597, DateTimeKind.Local).AddTicks(7827), "Wolf, Crona and Dickens" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Non Music", "9914130873537", "Identity", 1881, new DateTime(2022, 8, 28, 4, 35, 44, 22, DateTimeKind.Local).AddTicks(5784), "Block and Sons" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Blues", "2122528039480", "methodologies", 1350, new DateTime(2022, 12, 27, 23, 27, 55, 60, DateTimeKind.Local).AddTicks(8535), "Mueller LLC" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Pop", "5850767118907", "Handmade Wooden Towels", 7336, new DateTime(2022, 10, 26, 22, 57, 8, 146, DateTimeKind.Local).AddTicks(1247), "Bernhard, Ledner and Breitenberg" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Hip Hop", "7683554599805", "British Indian Ocean Territory (Chagos Archipelago)", 9709, new DateTime(2023, 1, 6, 22, 48, 15, 511, DateTimeKind.Local).AddTicks(9050), "Borer - Mayert" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Country", "0939926533128", "Trail", 5923, new DateTime(2023, 6, 5, 8, 41, 4, 578, DateTimeKind.Local).AddTicks(7377), "Simonis - Dickinson" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Non Music", "9803219960643", "Unbranded Frozen Hat", 7260, new DateTime(2022, 11, 12, 8, 45, 49, 427, DateTimeKind.Local).AddTicks(2315), "Wilkinson, Dicki and Blick" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Jazz", "0795044075762", "bypassing", 3498, new DateTime(2022, 9, 24, 3, 51, 50, 38, DateTimeKind.Local).AddTicks(2694), "Herman - MacGyver" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Non Music", "8808016471928", "sexy", 3660, new DateTime(2023, 1, 17, 7, 41, 6, 800, DateTimeKind.Local).AddTicks(7912), "Parisian Inc" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Non Music", "9156355425430", "Customer", 2037, new DateTime(2022, 8, 23, 22, 48, 36, 335, DateTimeKind.Local).AddTicks(9384), "Welch LLC" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Metal", "8755236184834", "Handcrafted Frozen Gloves", 1480, new DateTime(2023, 3, 11, 7, 48, 38, 727, DateTimeKind.Local).AddTicks(3702), "Aufderhar - Erdman" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Funk", "9688358714766", "grey", 2076, new DateTime(2022, 7, 23, 13, 58, 42, 459, DateTimeKind.Local).AddTicks(778), "Metz Group" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Rock", "5648646388356", "Canada", 6547, new DateTime(2023, 5, 1, 12, 11, 8, 70, DateTimeKind.Local).AddTicks(8560), "Emmerich LLC" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Stage And Screen", "8706719727499", "e-enable", 3277, new DateTime(2022, 8, 21, 0, 42, 24, 962, DateTimeKind.Local).AddTicks(6994), "Hackett - Gleason" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "World", "1093955065902", "Chief", 8551, new DateTime(2023, 2, 7, 0, 7, 35, 991, DateTimeKind.Local).AddTicks(4652), "Lind - Ward" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Folk", "4178294105643", "calculate", 8112, new DateTime(2022, 12, 31, 17, 2, 52, 806, DateTimeKind.Local).AddTicks(1927), "Murphy - Beahan" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Rap", "1521207064989", "Saint Kitts and Nevis", 6662, new DateTime(2023, 7, 2, 3, 40, 58, 391, DateTimeKind.Local).AddTicks(8509), "Prohaska, Murray and Nienow" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Pop", "7092145901611", "hack", 6825, new DateTime(2022, 7, 18, 6, 23, 47, 483, DateTimeKind.Local).AddTicks(9180), "Botsford - Will" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Country", "6162601546425", "integrate", 7293, new DateTime(2022, 11, 11, 19, 43, 0, 184, DateTimeKind.Local).AddTicks(4474), "Kutch and Sons" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Funk", "3526215834225", "Mobility", 3571, new DateTime(2023, 3, 27, 8, 1, 30, 262, DateTimeKind.Local).AddTicks(8732), "Fisher and Sons" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Latin", "5412671905280", "Peso Uruguayo", 7602, new DateTime(2023, 4, 9, 1, 37, 14, 679, DateTimeKind.Local).AddTicks(6298), "Swaniawski - Leffler" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Country", "1527854874377", "Electronics", 2221, new DateTime(2023, 6, 3, 19, 2, 36, 779, DateTimeKind.Local).AddTicks(1553), "Koch - DuBuque" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Hip Hop", "2301627798003", "Diverse", 3444, new DateTime(2023, 1, 20, 10, 18, 43, 280, DateTimeKind.Local).AddTicks(9874), "Larson - Feil" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Rock", "6073973844067", "hierarchy", 8458, new DateTime(2023, 2, 25, 22, 47, 34, 345, DateTimeKind.Local).AddTicks(2465), "Torphy and Sons" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Rock", "7202473762338", "back up", 5238, new DateTime(2022, 11, 28, 1, 12, 11, 126, DateTimeKind.Local).AddTicks(3484), "Jenkins, Cartwright and Wiegand" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Jazz", "5306490763704", "Generic Wooden Bacon", 3909, new DateTime(2023, 5, 1, 6, 12, 13, 848, DateTimeKind.Local).AddTicks(4824), "Spinka - Dare" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Funk", "9900681554810", "Serbian Dinar", 8663, new DateTime(2023, 2, 8, 9, 7, 47, 360, DateTimeKind.Local).AddTicks(8063), "Altenwerth and Sons" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Electronic", "3799817989154", "Texas", 801, new DateTime(2022, 10, 13, 11, 42, 42, 24, DateTimeKind.Local).AddTicks(4342), "Schmitt Group" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Non Music", "6409724237121", "back up", 9029, new DateTime(2023, 6, 26, 23, 9, 50, 565, DateTimeKind.Local).AddTicks(694), "Roberts Group" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Folk", "5440064373330", "Assistant", 873, new DateTime(2023, 3, 24, 3, 10, 56, 93, DateTimeKind.Local).AddTicks(726), "Bartoletti - Will" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Country", "5873924663416", "Money Market Account", 2248, new DateTime(2023, 3, 12, 11, 43, 29, 798, DateTimeKind.Local).AddTicks(4043), "Reilly, Dibbert and Wuckert" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Country", "5388238303922", "Jewelery & Books", 3259, new DateTime(2022, 10, 24, 10, 4, 1, 77, DateTimeKind.Local).AddTicks(8043), "Brown, Langosh and Gorczany" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Blues", "4574136044734", "Wall", 871, new DateTime(2023, 4, 11, 10, 34, 59, 497, DateTimeKind.Local).AddTicks(129), "Rogahn, Williamson and VonRueden" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Blues", "7181682455227", "pixel", 5181, new DateTime(2023, 5, 5, 3, 19, 17, 264, DateTimeKind.Local).AddTicks(8777), "Parisian, Reichel and Schmidt" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "World", "1791282010588", "Research", 9682, new DateTime(2023, 4, 14, 18, 32, 11, 837, DateTimeKind.Local).AddTicks(9325), "Kautzer - Doyle" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Reggae", "2162881148870", "Saint Helena Pound", 2811, new DateTime(2022, 7, 16, 22, 16, 2, 435, DateTimeKind.Local).AddTicks(1554), "Hartmann, Goldner and Labadie" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Electronic", "2982568282020", "Sleek Wooden Gloves", 2323, new DateTime(2023, 7, 6, 18, 22, 15, 485, DateTimeKind.Local).AddTicks(7910), "Hamill Inc" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Classical", "1346460913870", "Business-focused", 4345, new DateTime(2022, 11, 21, 5, 11, 17, 266, DateTimeKind.Local).AddTicks(4086), "Dooley, Kuhn and Schimmel" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Stage And Screen", "8073488447478", "neural", 1364, new DateTime(2023, 7, 2, 1, 59, 45, 905, DateTimeKind.Local).AddTicks(871), "Mayer - Daniel" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "World", "6021484205129", "help-desk", 8803, new DateTime(2022, 8, 24, 6, 31, 7, 159, DateTimeKind.Local).AddTicks(1179), "Denesik LLC" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Blues", "4840332721718", "deposit", 27, new DateTime(2023, 2, 13, 15, 43, 14, 47, DateTimeKind.Local).AddTicks(478), "Ratke LLC" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "World", "4995979972075", "Licensed", 4130, new DateTime(2022, 7, 29, 19, 27, 10, 907, DateTimeKind.Local).AddTicks(7282), "Hermann, Murphy and Stiedemann" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Rap", "3383695458828", "synthesizing", 7652, new DateTime(2023, 3, 14, 20, 37, 24, 359, DateTimeKind.Local).AddTicks(2720), "Emmerich - Kunde" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Jazz", "8707165386834", "overriding", 8154, new DateTime(2022, 10, 8, 21, 13, 5, 646, DateTimeKind.Local).AddTicks(7684), "Bahringer Inc" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Reggae", "4027091618835", "tan", 215, new DateTime(2022, 11, 16, 7, 31, 58, 871, DateTimeKind.Local).AddTicks(4347), "Strosin - Leffler" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Blues", "3845576527387", "Versatile", 8869, new DateTime(2022, 12, 20, 16, 13, 11, 941, DateTimeKind.Local).AddTicks(2188), "Lebsack - Torp" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Country", "1377072073928", "Japan", 4842, new DateTime(2022, 7, 28, 10, 29, 38, 862, DateTimeKind.Local).AddTicks(9574), "Monahan - O'Connell" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Metal", "3202417408692", "Licensed Wooden Towels", 3599, new DateTime(2022, 7, 23, 1, 17, 44, 197, DateTimeKind.Local).AddTicks(8732), "Green Group" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Classical", "6090464601596", "Afghanistan", 8511, new DateTime(2022, 11, 2, 12, 24, 36, 46, DateTimeKind.Local).AddTicks(7375), "Kassulke - Green" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Stage And Screen", "0247948950992", "Savings Account", 4008, new DateTime(2022, 12, 8, 11, 54, 21, 874, DateTimeKind.Local).AddTicks(8997), "Boyle and Sons" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Folk", "5762760748503", "calculate", 6514, new DateTime(2022, 9, 27, 15, 28, 39, 986, DateTimeKind.Local).AddTicks(6813), "Sporer, Wolf and Gulgowski" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Classical", "2100442614884", "Ergonomic", 2687, new DateTime(2023, 2, 14, 11, 35, 12, 455, DateTimeKind.Local).AddTicks(9531), "Watsica - Kozey" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Pop", "6482218023851", "Awesome Plastic Computer", 7130, new DateTime(2022, 10, 10, 4, 14, 2, 272, DateTimeKind.Local).AddTicks(6585), "Balistreri Group" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Metal", "2115697920369", "methodology", 1472, new DateTime(2023, 6, 20, 4, 3, 41, 434, DateTimeKind.Local).AddTicks(2634), "Stracke, Bauch and Cruickshank" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Country", "7543393522351", "Cambridgeshire", 3053, new DateTime(2023, 6, 20, 3, 38, 25, 858, DateTimeKind.Local).AddTicks(5257), "Carroll LLC" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Rap", "2690825257758", "SDR", 893, new DateTime(2022, 9, 27, 8, 38, 50, 243, DateTimeKind.Local).AddTicks(8376), "Heidenreich, Oberbrunner and Nicolas" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Stage And Screen", "2686358190402", "Clothing & Sports", 4638, new DateTime(2022, 11, 8, 15, 43, 12, 369, DateTimeKind.Local).AddTicks(6876), "Graham, Schmeler and Renner" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Stage And Screen", "9874281405486", "Delaware", 8357, new DateTime(2023, 1, 10, 21, 33, 44, 685, DateTimeKind.Local).AddTicks(1576), "Blanda, Bode and Ullrich" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Funk", "4875435097491", "South Carolina", 5878, new DateTime(2022, 7, 14, 21, 8, 21, 901, DateTimeKind.Local).AddTicks(2266), "Trantow, White and Emmerich" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Blues", "9773514420220", "Sleek", 687, new DateTime(2022, 11, 24, 19, 22, 32, 410, DateTimeKind.Local).AddTicks(233), "Sawayn - Wuckert" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Electronic", "5080240986062", "lime", 3681, new DateTime(2022, 11, 4, 15, 5, 57, 906, DateTimeKind.Local).AddTicks(8061), "Hintz LLC" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Blues", "4740892936402", "Security", 7727, new DateTime(2022, 10, 5, 15, 54, 56, 698, DateTimeKind.Local).AddTicks(1357), "Metz LLC" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Soul", "1149036496353", "withdrawal", 1585, new DateTime(2023, 4, 16, 22, 39, 34, 211, DateTimeKind.Local).AddTicks(9390), "Cronin Group" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Classical", "0113923503081", "Innovative", 3025, new DateTime(2022, 12, 21, 12, 48, 37, 445, DateTimeKind.Local).AddTicks(4402), "Hills Group" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Electronic", "4576473011493", "communities", 2537, new DateTime(2022, 11, 1, 21, 48, 10, 982, DateTimeKind.Local).AddTicks(8708), "Jakubowski and Sons" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Rap", "8881564747783", "USB", 4654, new DateTime(2022, 10, 4, 2, 8, 24, 243, DateTimeKind.Local).AddTicks(4162), "West, Gutkowski and Mante" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Folk", "9139825520484", "National", 735, new DateTime(2023, 5, 25, 20, 53, 53, 679, DateTimeKind.Local).AddTicks(511), "Grant and Sons" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Blues", "2195335476069", "Pataca", 1500, new DateTime(2022, 9, 3, 0, 20, 32, 213, DateTimeKind.Local).AddTicks(916), "Rogahn - Schaefer" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "World", "8448597927485", "Interactions", 3459, new DateTime(2023, 1, 30, 6, 52, 3, 9, DateTimeKind.Local).AddTicks(7469), "Treutel - Strosin" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Electronic", "2228869250499", "metrics", 6657, new DateTime(2022, 12, 6, 0, 23, 56, 663, DateTimeKind.Local).AddTicks(9749), "Schaden, Monahan and Predovic" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Soul", "4566293708857", "panel", 1803, new DateTime(2022, 9, 14, 8, 14, 17, 877, DateTimeKind.Local).AddTicks(702), "Zemlak - Kuvalis" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Classical", "8529985825443", "Bahrain", 3737, new DateTime(2022, 9, 11, 9, 1, 1, 746, DateTimeKind.Local).AddTicks(761), "Simonis, Effertz and Koss" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Hip Hop", "7948214038859", "Lead", 2298, new DateTime(2023, 7, 4, 2, 31, 2, 97, DateTimeKind.Local).AddTicks(9663), "Beier Inc" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Non Music", "8728938629330", "framework", 2847, new DateTime(2022, 8, 7, 16, 52, 29, 153, DateTimeKind.Local).AddTicks(5675), "Ruecker - Kris" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Jazz", "0053848008141", "Missouri", 5998, new DateTime(2023, 1, 24, 1, 11, 40, 551, DateTimeKind.Local).AddTicks(6948), "D'Amore, Moen and Simonis" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Jazz", "2418523165744", "indexing", 2172, new DateTime(2023, 1, 25, 12, 53, 47, 383, DateTimeKind.Local).AddTicks(8139), "McKenzie, Zulauf and Zemlak" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Classical", "5385929872606", "Rial Omani", 3083, new DateTime(2022, 12, 7, 11, 6, 10, 264, DateTimeKind.Local).AddTicks(8020), "Vandervort, Predovic and Stracke" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "World", "4701884611424", "Handmade Steel Computer", 4773, new DateTime(2023, 4, 26, 23, 9, 21, 652, DateTimeKind.Local).AddTicks(1641), "Ryan - Ziemann" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Funk", "5293177636119", "matrix", 5871, new DateTime(2022, 11, 19, 3, 29, 0, 436, DateTimeKind.Local).AddTicks(5972), "Hand Inc" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Blues", "2218983210868", "regional", 4278, new DateTime(2022, 9, 26, 2, 59, 30, 965, DateTimeKind.Local).AddTicks(4885), "Schmidt - Dare" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Rap", "3347637828636", "Gorgeous Rubber Car", 7019, new DateTime(2023, 4, 23, 9, 32, 25, 829, DateTimeKind.Local).AddTicks(6492), "Hammes - Boehm" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Reggae", "0309745353328", "cohesive", 3585, new DateTime(2023, 5, 23, 4, 3, 54, 643, DateTimeKind.Local).AddTicks(7537), "Stoltenberg, Kuhic and Ullrich" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Hip Hop", "6002379349050", "Unbranded Fresh Car", 5630, new DateTime(2023, 6, 1, 20, 18, 41, 345, DateTimeKind.Local).AddTicks(4264), "Conn, Lemke and Keebler" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Electronic", "4527669005369", "Program", 2903, new DateTime(2023, 4, 3, 5, 24, 34, 569, DateTimeKind.Local).AddTicks(8138), "Hammes and Sons" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Jazz", "3879695395251", "program", 2849, new DateTime(2022, 10, 8, 3, 21, 28, 314, DateTimeKind.Local).AddTicks(309), "Yost - Hahn" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Latin", "6340258017530", "Clothing", 3880, new DateTime(2023, 1, 21, 9, 43, 9, 417, DateTimeKind.Local).AddTicks(4182), "Langworth and Sons" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Soul", "8902974037582", "array", 4729, new DateTime(2023, 1, 11, 4, 33, 51, 725, DateTimeKind.Local).AddTicks(6266), "Luettgen, Kovacek and Mante" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Folk", "2400117416479", "Landing", 561, new DateTime(2022, 11, 28, 5, 58, 51, 576, DateTimeKind.Local).AddTicks(1287), "Cremin - Abbott" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Blues", "9044968505871", "Persistent", 5190, new DateTime(2023, 1, 31, 11, 7, 52, 617, DateTimeKind.Local).AddTicks(2656), "Ward Group" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Metal", "6098011764367", "Practical Granite Towels", 3372, new DateTime(2022, 7, 17, 13, 55, 13, 574, DateTimeKind.Local).AddTicks(8438), "Kerluke - Renner" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "World", "3358325895984", "Islands", 9145, new DateTime(2022, 12, 20, 22, 13, 27, 384, DateTimeKind.Local).AddTicks(830), "Kub Inc" });

            migrationBuilder.UpdateData(
                table: "BookEntity",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Genre", "ISBN", "Language", "PageCount", "PublicationDate", "Title" },
                values: new object[] { "Electronic", "2705952741701", "Outdoors & Automotive", 7785, new DateTime(2022, 12, 4, 3, 53, 21, 496, DateTimeKind.Local).AddTicks(475), "Purdy, Deckow and Yost" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Janis", "Hermann" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Tanya", "Hartmann" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Kenny", "Okuneva" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Ken", "Koch" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Kerry", "Brekke" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Ida", "Torp" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Candace", "Heller" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Veronica", "Schmitt" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Debbie", "Kessler" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Wallace", "Deckow" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Kimberly", "Wiza" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Cesar", "Schinner" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Ebony", "Gislason" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Mindy", "Bergstrom" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Carrie", "Gorczany" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Maxine", "Kshlerin" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Crystal", "Durgan" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Denise", "Waters" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Roger", "Simonis" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Nina", "Littel" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Corey", "Schultz" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Tim", "Fay" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Dave", "O'Reilly" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Matt", "Spinka" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Jean", "Kunze" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Loren", "Crist" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Stephanie", "Armstrong" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Timmy", "Halvorson" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Tami", "Reilly" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Lynn", "Keebler" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Lindsey", "Toy" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Maxine", "Hermiston" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Jonathan", "Jacobs" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Enrique", "Bartoletti" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Ismael", "Herzog" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Donald", "Hartmann" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Erma", "Hane" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Karla", "Kutch" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Matt", "Mertz" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Lewis", "Schiller" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Lamar", "Koch" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Nora", "Lindgren" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Tammy", "Graham" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Jeannie", "Baumbach" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Peter", "Ledner" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Don", "Waelchi" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Jamie", "Turcotte" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Derrick", "Jenkins" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Freddie", "Adams" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Kristen", "Roob" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Becky", "Stamm" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Frank", "Johnston" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Joy", "Beahan" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Eduardo", "Nitzsche" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Jason", "Predovic" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Rufus", "Bradtke" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Lawrence", "Hauck" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Olivia", "Bruen" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Cedric", "Yost" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Jimmie", "Vandervort" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Camille", "Bergnaum" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Lee", "Kris" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Diane", "Witting" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Daisy", "Graham" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Wallace", "Rohan" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Mandy", "Powlowski" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Jody", "Stehr" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Carlton", "Kutch" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Jennie", "Miller" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Jessie", "Powlowski" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Domingo", "Raynor" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Johnnie", "O'Conner" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Tracy", "Beer" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Nellie", "Sawayn" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Ernest", "Grady" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Della", "Jones" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Constance", "Flatley" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Terry", "Greenfelder" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Bertha", "Schneider" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Tracy", "Wolf" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Della", "Douglas" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Jesse", "Dicki" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Greg", "Greenholt" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Hattie", "Kiehn" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Levi", "Beier" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Leslie", "Pagac" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Lawrence", "Bailey" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Bernadette", "Olson" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Sheri", "Heller" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Wanda", "Tillman" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Suzanne", "Kulas" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Claire", "Lehner" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Shawn", "Kerluke" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Norma", "Witting" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Lauren", "Murazik" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Elaine", "Adams" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Nichole", "Bruen" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Jeanette", "Corwin" });

            migrationBuilder.UpdateData(
                table: "UserEntity",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Name", "SurName" },
                values: new object[] { "Marshall", "Abshire" });
        }
    }
}
