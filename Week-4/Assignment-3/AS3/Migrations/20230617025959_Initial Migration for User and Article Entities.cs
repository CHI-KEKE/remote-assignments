using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AS3.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigrationforUserandArticleEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Article",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Article", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Article_Users_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Password" },
                values: new object[,]
                {
                    { 1, "Bernie.Waters@gmail.com", "t11ol4c_VT" },
                    { 2, "Lucienne.Bergnaum@gmail.com", "378eJq5Dvo" },
                    { 3, "Krista.Thiel21@gmail.com", "oik1Bf74Nz" },
                    { 4, "Gregory91@yahoo.com", "g1i17Qnbrl" },
                    { 5, "Delfina32@hotmail.com", "ja3pBSt3Yo" },
                    { 6, "Velma_Waelchi44@yahoo.com", "Hs1QfJwTzT" },
                    { 7, "Rosalyn.Beatty23@hotmail.com", "wkOMnEP4RA" },
                    { 8, "Maximilian7@yahoo.com", "yqlHNtIrQ1" },
                    { 9, "Jena71@gmail.com", "QDtU2XTHHV" },
                    { 10, "Jovanny.Cremin@yahoo.com", "EATNLE4nZj" }
                });

            migrationBuilder.InsertData(
                table: "Article",
                columns: new[] { "Id", "AuthorId", "Content", "Title" },
                values: new object[,]
                {
                    { 1, 4, "Aliquid nesciunt eos dolores occaecati earum temporibus. Dolores et eveniet perferendis doloribus animi temporibus. Ipsa non quasi ut dolores dolorum. Velit officia dolorum. Facilis sunt ducimus inventore fugiat.", "Provident totam eos mollitia quo libero." },
                    { 2, 9, "Saepe deleniti ducimus aliquid delectus perspiciatis consequatur deserunt explicabo ipsam. Sed cumque voluptatem. Quia quaerat veniam quasi aut aspernatur eius ipsum possimus. Porro perferendis sit vel.", "Voluptas nesciunt ratione nobis aut." },
                    { 3, 3, "Et in quaerat similique in sunt suscipit. Earum sit et quos enim laboriosam. Natus itaque repellat odit suscipit. Delectus autem itaque et nisi. Quia vero quidem rerum aliquid sequi fugiat a.", "Eius perspiciatis nesciunt adipisci ut vero quidem saepe eos." },
                    { 4, 9, "Voluptatem tenetur qui unde ratione. Aut iusto incidunt quae accusamus autem nam quo. Velit dolores praesentium est accusantium a.", "Ducimus nemo ab doloremque." },
                    { 5, 10, "Ex praesentium voluptas quis vel. Ipsa aut id. Quo quis accusamus mollitia. Tempora officiis sed enim impedit pariatur accusamus non harum sunt.", "Porro ea neque." },
                    { 6, 8, "Sit molestiae et mollitia esse eligendi est odit est sunt. Quia id alias asperiores cupiditate qui voluptates. Expedita officia nostrum dicta commodi sit libero.", "Ipsam repellendus eius omnis sunt iste harum." },
                    { 7, 1, "Sed provident ut quo. Minima sunt quaerat tempora. Provident perferendis ea.", "Incidunt consequatur dolorum quo a molestias magnam." },
                    { 8, 9, "Necessitatibus est omnis qui totam id iste. Quod illum sit quisquam. Iure earum quae velit. Ea ullam voluptas ratione quam porro recusandae sit.", "Assumenda harum incidunt cupiditate inventore quos quis." },
                    { 9, 7, "Aperiam quas mollitia enim debitis magni. Nisi vero quo nulla voluptatem veniam tempore expedita sint omnis. Aut rerum est ipsam consequatur labore eum sequi. Consequatur laboriosam fugit nihil.", "Est explicabo rem perferendis consequatur nostrum." },
                    { 10, 9, "Vel et aut iure ut. Corporis voluptate nulla vel qui debitis officia velit eius. Et quo aspernatur aliquid eveniet aliquam molestiae mollitia voluptates. Suscipit laborum sunt laudantium molestiae. Eum facilis similique quaerat. Dicta tempore similique quasi quod aut.", "Et aliquam consequatur dolorem rerum consequuntur." },
                    { 11, 10, "In eos dicta sapiente sunt dolores nemo amet. Culpa iste quis tempore aut minus qui nostrum maxime magni. Et distinctio repellat officia. Suscipit quod a culpa modi incidunt velit perferendis voluptatum cum.", "At nihil omnis eius quidem omnis adipisci est vel omnis." },
                    { 12, 1, "Quibusdam deleniti ab cumque fugit sapiente. Nam nostrum necessitatibus minima accusantium aut non libero repudiandae. Et eveniet ex. Odit aliquam provident aut cupiditate. Quia accusamus quasi recusandae incidunt recusandae soluta. Hic ut aspernatur.", "Natus magnam voluptas ex molestiae culpa voluptas provident voluptas praesentium." },
                    { 13, 4, "Consequuntur qui at sit facere facilis et illo tenetur. Sit omnis nam similique doloremque earum autem incidunt. Repellendus accusamus dolorum. Laudantium eos dignissimos sed. Officiis in quo.", "Sit impedit ipsum perferendis quas ab quia adipisci quia." },
                    { 14, 7, "Consectetur similique nostrum iste voluptatem iusto perferendis nulla praesentium ad. Nulla praesentium sequi est nam omnis mollitia. Quos quidem magnam distinctio assumenda dolorem est ad. Qui minus dicta voluptatibus et at amet aut rerum aut. Voluptatem sapiente quisquam error praesentium voluptate a.", "Velit rerum et." },
                    { 15, 9, "Quasi consequatur occaecati expedita voluptas et dolorem culpa. Ut illo ut. Vel tempore eos et asperiores commodi aut. Occaecati ut eaque esse voluptatem eos blanditiis nostrum consequatur illum.", "Adipisci quis doloribus nostrum voluptas quas accusamus quia." },
                    { 16, 7, "Corporis tenetur quis eos adipisci nihil quod sunt rerum. Voluptatem velit est cupiditate harum cupiditate autem veniam. Nobis aut explicabo id itaque rerum pariatur ut perferendis. Non odio molestias vero harum placeat vero. Accusamus iure necessitatibus quis qui sit dolores. Quas quidem et qui consectetur expedita.", "Perferendis numquam ut occaecati et culpa suscipit veniam." },
                    { 17, 9, "Ea sed nisi aut inventore. Cupiditate qui praesentium optio id id. Possimus quis aut voluptas qui quo. Molestiae sit ut. Molestias et sint consequatur. Accusantium est dolore sed molestias perspiciatis est libero.", "Qui consequatur dignissimos dolores necessitatibus doloremque maxime qui a quisquam." },
                    { 18, 2, "Ducimus eius ut numquam. Sit quasi voluptatem quia ut porro nam. Vitae quia qui. Incidunt esse neque dolorum voluptatem necessitatibus qui.", "Et nam tempora aliquam aut cum voluptate ducimus sit." },
                    { 19, 1, "Atque rem et vel accusamus. Quas quia laudantium reprehenderit ducimus. Commodi assumenda voluptatibus blanditiis enim ducimus ab et placeat. Aliquam illum totam rerum amet dolor quam qui ratione voluptas. Dolores commodi mollitia beatae voluptas debitis sunt autem vel expedita. Dolorum totam sapiente aut placeat doloremque autem sint velit.", "Eveniet repellendus distinctio molestiae inventore esse vero hic aut velit." },
                    { 20, 2, "Adipisci qui et soluta. Dolores magnam sed aut impedit ut ipsa. Esse animi nihil nobis. Impedit numquam reprehenderit iusto rerum ut. Laudantium consequatur ipsum consectetur est sed. Nostrum molestias nemo doloremque.", "Natus occaecati ipsa quos." },
                    { 21, 1, "Eum assumenda tenetur consectetur voluptatem ipsum. Sapiente ex impedit omnis. At nostrum mollitia.", "Perferendis consequuntur quidem." },
                    { 22, 9, "Sit et mollitia dicta mollitia. Ducimus assumenda libero aut quia voluptatem eaque. Quidem atque voluptatem eveniet molestiae tenetur aperiam quam possimus inventore.", "Laborum eaque a quia laborum maiores harum impedit repellendus." },
                    { 23, 1, "Quis itaque ex voluptate nemo beatae natus aut odit dolorem. Voluptatibus rerum delectus consequatur voluptas laborum earum commodi sint quia. Eligendi sed exercitationem illo ea iusto. Ad facilis exercitationem.", "Nihil accusamus quae at." },
                    { 24, 5, "Dolorem voluptas voluptatem quis voluptatem fugiat eum eaque eos iusto. Sit quia qui similique. Nihil vero nesciunt maiores blanditiis ut et laborum quisquam vitae. Rerum quod enim repellat praesentium. Corrupti nihil voluptas labore repellat.", "Reprehenderit delectus architecto." },
                    { 25, 4, "Sint eum voluptas recusandae accusantium tempora ratione. Et a sed voluptate ut fuga. Ullam accusantium optio rerum saepe iste quae incidunt quo. Omnis aut dicta soluta ea quisquam. Maiores sit voluptatem est aut nihil.", "Aut quo fugit necessitatibus voluptates ea odio occaecati." },
                    { 26, 4, "Assumenda quidem vitae nobis dolorem quia. Sed odit optio et corrupti qui nobis id. Ut tempora tempore et sit id praesentium sed debitis.", "Inventore autem beatae et." },
                    { 27, 8, "Animi commodi sapiente. Voluptatibus architecto laboriosam quam nulla corporis quisquam soluta. Sint aliquid nam tempore ipsa aliquid voluptatem laboriosam.", "Occaecati eius adipisci voluptatem voluptas provident." },
                    { 28, 10, "Omnis consequuntur est quis nisi assumenda. Est in dolorum. Consequatur sed quibusdam cupiditate quia at quae in. Hic in et ipsum eos.", "Numquam similique itaque voluptates." },
                    { 29, 8, "Maxime dolor sapiente dolores soluta autem tempore velit ut consequuntur. Voluptas ducimus minus et hic illo possimus. Minima molestiae aspernatur dolorem quia fugiat cum. Aliquid autem minus est.", "Aliquam natus qui." },
                    { 30, 6, "Occaecati veritatis recusandae consequatur. Dicta dolor assumenda et molestias dolorem. Aut quae necessitatibus repellendus hic vero facilis. Necessitatibus eveniet voluptatum unde ut qui.", "Ut est ut aut ducimus non perferendis rerum sit." }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Article_AuthorId",
                table: "Article",
                column: "AuthorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Article");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
