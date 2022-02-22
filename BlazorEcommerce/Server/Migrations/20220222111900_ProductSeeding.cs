using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorEcommerce.Server.Migrations
{
    public partial class ProductSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "Based on the classic novel by Murasaki Shikibu, written over 1000 years ago. Genji, the son of the emperor, has gained renown among the nobility of Kyoto for his charm and good looks, yet he cannot stop himself from pursuing the one object of desire he must never obtain: his father's young and beautiful bride. Following the tragic consequences of his obsession, Genji wanders from one affair to another, always seeking some sort of completion to his life. —Jean-Marc Rocher", "https://img.yts.mx/assets/images/movies/genji_monogatari_1966/medium-cover.jpg", 99.25m, "Genji monogatari" },
                    { 2, "Ted K lives a life of almost complete seclusion in a simple wooden cabin in the mountains of Montana. But then this former university professor, who despises modern society and its faith in technology, becomes radicalized. What begins with local acts of sabotage, ends with deadly bomb attacks. To the outside world, Ted K becomes known as the Unabomber. Based on Ted Kaczynski's diaries and writings, Tony Stone's film is a kaleidoscopic true crime journey into the life of one of America's most complex and eccentric killers. It features a tour-de-force performance from Sharlto Copley who portrays the complexity of this unique outsider, raging at the forces of both the inescapable technological society that plagues him and his own inner demons", "https://img.yts.mx/assets/images/movies/ted_k_2021/medium-cover.jpg", 56.25m, "Ted K" },
                    { 3, "Twenty-five years after the original series of murders in Woodsboro, a new Ghostface emerges, and Sidney Prescott must return to uncover the truth.", "https://img.yts.mx/assets/images/movies/scream_2022/medium-cover.jpg", 54.12m, "Scream" },
                    { 4, "Maria Fux is a 90 years old Argentinian dancer. In her studio in Buenos Aires she is dancing, teaching and conserving the elegance and the energy of a young performer. She gives to people in her classes the possibility to develop their own way of expressing themselves. After a period of training with her, a lot of them spring out, as if something new is waking up. They take part in one of the most ancient human struggles: the battle of human beings against their limits. Maria Fux is not an exception. She is pushing her old body to the limits, but there's an unknown force coming from inside, that makes her still dancing. This film wants to tell the power of that force.", "https://img.yts.mx/assets/images/movies/dancing_with_maria_2014/medium-cover.jpg", 54.12m, "Dancing with Maria" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
