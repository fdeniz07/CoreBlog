using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog.DataAccessLayer.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abouts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Details1 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Details2 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Image1 = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Image2 = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    MapLocation = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Mail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Message = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Writers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    About = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Image = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Writers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Writers_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Content = table.Column<string>(type: "NVARCHAR(MAX)", nullable: false),
                    Thumbnail = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Image = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ViewCount = table.Column<int>(type: "int", nullable: false),
                    CommentCount = table.Column<int>(type: "int", nullable: false),
                    SeoAuthor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SeoDescription = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    SeoTags = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    WriterId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Articles_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Articles_Writers_WriterId",
                        column: x => x.WriterId,
                        principalTable: "Writers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "NVARCHAR(MAX)", nullable: false),
                    ArticleId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Name", "Note" },
                values: new object[,]
                {
                    { 1, "InitialCreate", new DateTime(2021, 12, 2, 3, 34, 57, 118, DateTimeKind.Local).AddTicks(1213), "C# Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "InitialCreate", new DateTime(2021, 12, 2, 3, 34, 57, 118, DateTimeKind.Local).AddTicks(1224), "C#", "C# Blog Kategorisi" },
                    { 2, "InitialCreate", new DateTime(2021, 12, 2, 3, 34, 57, 118, DateTimeKind.Local).AddTicks(1235), "C++ Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "InitialCreate", new DateTime(2021, 12, 2, 3, 34, 57, 118, DateTimeKind.Local).AddTicks(1237), "C++", "C++ Blog Kategorisi" },
                    { 3, "InitialCreate", new DateTime(2021, 12, 2, 3, 34, 57, 118, DateTimeKind.Local).AddTicks(1243), "JavaScript Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "InitialCreate", new DateTime(2021, 12, 2, 3, 34, 57, 118, DateTimeKind.Local).AddTicks(1245), "JavaScript", "JavaScript Blog Kategorisi" },
                    { 4, "InitialCreate", new DateTime(2021, 12, 2, 3, 34, 57, 118, DateTimeKind.Local).AddTicks(1251), "Typescript Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "InitialCreate", new DateTime(2021, 12, 2, 3, 34, 57, 118, DateTimeKind.Local).AddTicks(1253), "Typescript", "Typescript Blog Kategorisi" },
                    { 5, "InitialCreate", new DateTime(2021, 12, 2, 3, 34, 57, 118, DateTimeKind.Local).AddTicks(1258), "Java Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "InitialCreate", new DateTime(2021, 12, 2, 3, 34, 57, 118, DateTimeKind.Local).AddTicks(1261), "Java", "Java Blog Kategorisi" },
                    { 6, "InitialCreate", new DateTime(2021, 12, 2, 3, 34, 57, 118, DateTimeKind.Local).AddTicks(1266), "Python Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "InitialCreate", new DateTime(2021, 12, 2, 3, 34, 57, 118, DateTimeKind.Local).AddTicks(1269), "Python", "Python Blog Kategorisi" },
                    { 7, "InitialCreate", new DateTime(2021, 12, 2, 3, 34, 57, 118, DateTimeKind.Local).AddTicks(1274), "Php Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "InitialCreate", new DateTime(2021, 12, 2, 3, 34, 57, 118, DateTimeKind.Local).AddTicks(1276), "Php", "Php Blog Kategorisi" },
                    { 8, "InitialCreate", new DateTime(2021, 12, 2, 3, 34, 57, 118, DateTimeKind.Local).AddTicks(1282), "Kotlin Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "InitialCreate", new DateTime(2021, 12, 2, 3, 34, 57, 118, DateTimeKind.Local).AddTicks(1284), "Kotlin", "Kotlin Blog Kategorisi" },
                    { 9, "InitialCreate", new DateTime(2021, 12, 2, 3, 34, 57, 118, DateTimeKind.Local).AddTicks(1290), "Swift Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "InitialCreate", new DateTime(2021, 12, 2, 3, 34, 57, 118, DateTimeKind.Local).AddTicks(1292), "Swift", "Swift Blog Kategorisi" },
                    { 10, "InitialCreate", new DateTime(2021, 12, 2, 3, 34, 57, 118, DateTimeKind.Local).AddTicks(1298), "Ruby Programlama Dili ile İlgili En Güncel Bilgiler", true, false, "InitialCreate", new DateTime(2021, 12, 2, 3, 34, 57, 118, DateTimeKind.Local).AddTicks(1300), "Ruby", "Ruby Blog Kategorisi" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Name", "Note" },
                values: new object[] { 1, "InitialCreate", new DateTime(2021, 12, 2, 3, 34, 57, 122, DateTimeKind.Local).AddTicks(8835), "Admin Rolü, Tüm Haklara Sahiptir", true, false, "InitialCreate", new DateTime(2021, 12, 2, 3, 34, 57, 122, DateTimeKind.Local).AddTicks(8846), "Admin", "Admin Rolüdür." });

            migrationBuilder.InsertData(
                table: "Writers",
                columns: new[] { "Id", "About", "CreatedByName", "CreatedDate", "Email", "FirstName", "Image", "IsActive", "IsDeleted", "LastName", "ModifiedByName", "ModifiedDate", "Note", "PasswordHash", "RoleId" },
                values: new object[] { 1, "Blog Admin", "InitialCreate", new DateTime(2021, 12, 2, 3, 34, 57, 124, DateTimeKind.Local).AddTicks(3946), "admin@gmail.com", "Fatih", "default.jpg", true, false, "Deniz", "InitialCreate", new DateTime(2021, 12, 2, 3, 34, 57, 124, DateTimeKind.Local).AddTicks(3959), "Ilk Admin Kullanici", new byte[] { 48, 49, 57, 50, 48, 50, 51, 97, 55, 98, 98, 100, 55, 51, 50, 53, 48, 53, 49, 54, 102, 48, 54, 57, 100, 102, 49, 56, 98, 53, 48, 48 }, 1 });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "CommentCount", "Content", "CreatedByName", "CreatedDate", "Date", "Image", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "SeoAuthor", "SeoDescription", "SeoTags", "Thumbnail", "Title", "ViewCount", "WriterId" },
                values: new object[,]
                {
                    { 1, 1, 0, "Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur.", "InitialCreate", new DateTime(2021, 12, 2, 3, 34, 57, 115, DateTimeKind.Local).AddTicks(3097), new DateTime(2021, 12, 2, 3, 34, 57, 115, DateTimeKind.Local).AddTicks(2380), "default.jpg", true, false, "InitialCreate", new DateTime(2021, 12, 2, 3, 34, 57, 115, DateTimeKind.Local).AddTicks(3381), "C# 9.0 ve .NET 5 Yenilikleri", "Fatih Deniz", "C# 9.0 ve .NET 5 Yenilikleri", "C#, C# 9, .NET5, .NET Framework, .NET Core", "postImages/defaultThumbnail.jpg", "C# 9.0 ve .NET 5 Yenilikleri", 100, 1 },
                    { 2, 2, 0, "Yinelenen bir sayfa içeriğinin okuyucunun dikkatini dağıttığı bilinen bir gerçektir. Lorem Ipsum kullanmanın amacı, sürekli 'buraya metin gelecek, buraya metin gelecek' yazmaya kıyasla daha dengeli bir harf dağılımı sağlayarak okunurluğu artırmasıdır. Şu anda birçok masaüstü yayıncılık paketi ve web sayfa düzenleyicisi, varsayılan mıgır metinler olarak Lorem Ipsum kullanmaktadır. Ayrıca arama motorlarında 'lorem ipsum' anahtar sözcükleri ile arama yapıldığında henüz tasarım aşamasında olan çok sayıda site listelenir. Yıllar içinde, bazen kazara, bazen bilinçli olarak (örneğin mizah katılarak), çeşitli sürümleri geliştirilmiştir.", "InitialCreate", new DateTime(2021, 12, 2, 3, 34, 57, 115, DateTimeKind.Local).AddTicks(4035), new DateTime(2021, 12, 2, 3, 34, 57, 115, DateTimeKind.Local).AddTicks(4032), "default.jpg", true, false, "InitialCreate", new DateTime(2021, 12, 2, 3, 34, 57, 115, DateTimeKind.Local).AddTicks(4038), "C++ 11 ve 19 Yenilikleri", "Fatih Deniz", "C++ 11 ve 19 Yenilikleri", "C++ 11 ve 19 Yenilikleri", "postImages/defaultThumbnail.jpg", "C++ 11 ve 19 Yenilikleri", 295, 1 },
                    { 3, 3, 0, "Yaygın inancın tersine, Lorem Ipsum rastgele sözcüklerden oluşmaz. Kökleri M.Ö. 45 tarihinden bu yana klasik Latin edebiyatına kadar uzanan 2000 yıllık bir geçmişi vardır. Virginia'daki Hampden-Sydney College'dan Latince profesörü Richard McClintock, bir Lorem Ipsum pasajında geçen ve anlaşılması en güç sözcüklerden biri olan 'consectetur' sözcüğünün klasik edebiyattaki örneklerini incelediğinde kesin bir kaynağa ulaşmıştır. Lorm Ipsum, Çiçero tarafından M.Ö. 45 tarihinde kaleme alınan \"de Finibus Bonorum et Malorum\" (İyi ve Kötünün Uç Sınırları) eserinin 1.10.32 ve 1.10.33 sayılı bölümlerinden gelmektedir. Bu kitap, ahlak kuramı üzerine bir tezdir ve Rönesans döneminde çok popüler olmuştur. Lorem Ipsum pasajının ilk satırı olan \"Lorem ipsum dolor sit amet\" 1.10.32 sayılı bölümdeki bir satırdan gelmektedir. 1500'lerden beri kullanılmakta olan standard Lorem Ipsum metinleri ilgilenenler için yeniden üretilmiştir. Çiçero tarafından yazılan 1.10.32 ve 1.10.33 bölümleri de 1914 H. Rackham çevirisinden alınan İngilizce sürümleri eşliğinde özgün biçiminden yeniden üretilmiştir.", "InitialCreate", new DateTime(2021, 12, 2, 3, 34, 57, 115, DateTimeKind.Local).AddTicks(4047), new DateTime(2021, 12, 2, 3, 34, 57, 115, DateTimeKind.Local).AddTicks(4044), "default.jpg", true, false, "InitialCreate", new DateTime(2021, 12, 2, 3, 34, 57, 115, DateTimeKind.Local).AddTicks(4049), "JavaScript ES2019 ve ES2020 Yenilikleri", "Fatih Deniz", "JavaScript ES2019 ve ES2020 Yenilikleri", "JavaScript ES2019 ve ES2020 Yenilikleri", "postImages/defaultThumbnail.jpg", "JavaScript ES2019 ve ES2020 Yenilikleri", 12, 1 },
                    { 4, 4, 0, "É um facto estabelecido de que um leitor é distraído pelo conteúdo legível de uma página quando analisa a sua mancha gráfica. Logo, o uso de Lorem Ipsum leva a uma distribuição mais ou menos normal de letras, ao contrário do uso de 'Conteúdo aqui,conteúdo aqui'', tornando-o texto legível. Muitas ferramentas de publicação electrónica e editores de páginas web usam actualmente o Lorem Ipsum como o modelo de texto usado por omissão, e uma pesquisa por 'lorem ipsum' irá encontrar muitos websites ainda na sua infância. Várias versões têm evoluído ao longo dos anos, por vezes por acidente, por vezes propositadamente (como no caso do humor).", "InitialCreate", new DateTime(2021, 12, 2, 3, 34, 57, 115, DateTimeKind.Local).AddTicks(4057), new DateTime(2021, 12, 2, 3, 34, 57, 115, DateTimeKind.Local).AddTicks(4055), "default.jpg", true, false, "InitialCreate", new DateTime(2021, 12, 2, 3, 34, 57, 115, DateTimeKind.Local).AddTicks(4060), "Typescript 4.1 Yenilikleri", "Fatih Deniz", "Typescript 4.1, Typescript, TYPESCRIPT 2021", "Typescript 4.1 Güncellemeleri", "postImages/defaultThumbnail.jpg", "Typescript 4.1", 666, 1 },
                    { 5, 5, 0, "Yaygın inancın tersine, Lorem Ipsum rastgele sözcüklerden oluşmaz. Kökleri M.Ö. 45 tarihinden bu yana klasik Latin edebiyatına kadar uzanan 2000 yıllık bir geçmişi vardır. Virginia'daki Hampden-Sydney College'dan Latince profesörü Richard McClintock, bir Lorem Ipsum pasajında geçen ve anlaşılması en güç sözcüklerden biri olan 'consectetur' sözcüğünün klasik edebiyattaki örneklerini incelediğinde kesin bir kaynağa ulaşmıştır. Lorm Ipsum, Çiçero tarafından M.Ö. 45 tarihinde kaleme alınan \"de Finibus Bonorum et Malorum\" (İyi ve Kötünün Uç Sınırları) eserinin 1.10.32 ve 1.10.33 sayılı bölümlerinden gelmektedir. Bu kitap, ahlak kuramı üzerine bir tezdir ve Rönesans döneminde çok popüler olmuştur. Lorem Ipsum pasajının ilk satırı olan \"Lorem ipsum dolor sit amet\" 1.10.32 sayılı bölümdeki bir satırdan gelmektedir. 1500'lerden beri kullanılmakta olan standard Lorem Ipsum metinleri ilgilenenler için yeniden üretilmiştir. Çiçero tarafından yazılan 1.10.32 ve 1.10.33 bölümleri de 1914 H. Rackham çevirisinden alınan İngilizce sürümleri eşliğinde özgün biçiminden yeniden üretilmiştir.", "InitialCreate", new DateTime(2021, 12, 2, 3, 34, 57, 115, DateTimeKind.Local).AddTicks(4068), new DateTime(2021, 12, 2, 3, 34, 57, 115, DateTimeKind.Local).AddTicks(4066), "default.jpg", true, false, "InitialCreate", new DateTime(2021, 12, 2, 3, 34, 57, 115, DateTimeKind.Local).AddTicks(4071), "JAVA", "Fatih Deniz", "Java, Android, Mobile, Kotlin, Uygulama Geliştirme", "Java, Mobil, Kotlin, Android, IOS, SWIFT", "postImages/defaultThumbnail.jpg", "Java ve Android'in Geleceği | 2021", 3225, 1 },
                    { 6, 6, 0, "Le Lorem Ipsum est simplement du faux texte employé dans la composition et la mise en page avant impression. Le Lorem Ipsum est le faux texte standard de l'imprimerie depuis les années 1500, quand un imprimeur anonyme assembla ensemble des morceaux de texte pour réaliser un livre spécimen de polices de texte. Il n'a pas fait que survivre cinq siècles, mais s'est aussi adapté à la bureautique informatique, sans que son contenu n'en soit modifié. Il a été popularisé dans les années 1960 grâce à la vente de feuilles Letraset contenant des passages du Lorem Ipsum, et, plus récemment, par son inclusion dans des applications de mise en page de texte, comme Aldus PageMaker.", "InitialCreate", new DateTime(2021, 12, 2, 3, 34, 57, 115, DateTimeKind.Local).AddTicks(4079), new DateTime(2021, 12, 2, 3, 34, 57, 115, DateTimeKind.Local).AddTicks(4077), "default.jpg", true, false, "InitialCreate", new DateTime(2021, 12, 2, 3, 34, 57, 115, DateTimeKind.Local).AddTicks(4082), "Python", "Fatih Deniz", "Python ile Veri Madenciliği", "Python, Veri Madenciliği Nasıl Yapılır?", "postImages/defaultThumbnail.jpg", "Python ile Veri Madenciliği | 2021", 9999, 1 },
                    { 7, 7, 0, "Contrairement à une opinion répandue, le Lorem Ipsum n'est pas simplement du texte aléatoire. Il trouve ses racines dans une oeuvre de la littérature latine classique datant de 45 av. J.-C., le rendant vieux de 2000 ans. Un professeur du Hampden-Sydney College, en Virginie, s'est intéressé à un des mots latins les plus obscurs, consectetur, extrait d'un passage du Lorem Ipsum, et en étudiant tous les usages de ce mot dans la littérature classique, découvrit la source incontestable du Lorem Ipsum. Il provient en fait des sections 1.10.32 et 1.10.33 du 0De Finibus Bonorum et Malorum' (Des Suprêmes Biens et des Suprêmes Maux) de Cicéron. Cet ouvrage, très populaire pendant la Renaissance, est un traité sur la théorie de l'éthique. Les premières lignes du Lorem Ipsum, 'Lorem ipsum dolor sit amet...'', proviennent de la section 1.10.32", "InitialCreate", new DateTime(2021, 12, 2, 3, 34, 57, 115, DateTimeKind.Local).AddTicks(4090), new DateTime(2021, 12, 2, 3, 34, 57, 115, DateTimeKind.Local).AddTicks(4088), "default.jpg", true, false, "InitialCreate", new DateTime(2021, 12, 2, 3, 34, 57, 115, DateTimeKind.Local).AddTicks(4093), "PHP", "Fatih Deniz", "Php ile API Oluşturma Rehberi", "php, laravel, api, oop", "postImages/defaultThumbnail.jpg", "Php Laravel Başlangıç Rehberi | API", 4818, 1 },
                    { 8, 8, 0, "Plusieurs variations de Lorem Ipsum peuvent être trouvées ici ou là, mais la majeure partie d'entre elles a été altérée par l'addition d'humour ou de mots aléatoires qui ne ressemblent pas une seconde à du texte standard. Si vous voulez utiliser un passage du Lorem Ipsum, vous devez être sûr qu'il n'y a rien d'embarrassant caché dans le texte. Tous les générateurs de Lorem Ipsum sur Internet tendent à reproduire le même extrait sans fin, ce qui fait de lipsum.com le seul vrai générateur de Lorem Ipsum. Iil utilise un dictionnaire de plus de 200 mots latins, en combinaison de plusieurs structures de phrases, pour générer un Lorem Ipsum irréprochable. Le Lorem Ipsum ainsi obtenu ne contient aucune répétition, ni ne contient des mots farfelus, ou des touches d'humour.", "InitialCreate", new DateTime(2021, 12, 2, 3, 34, 57, 115, DateTimeKind.Local).AddTicks(4101), new DateTime(2021, 12, 2, 3, 34, 57, 115, DateTimeKind.Local).AddTicks(4098), "default.jpg", true, false, "InitialCreate", new DateTime(2021, 12, 2, 3, 34, 57, 115, DateTimeKind.Local).AddTicks(4103), "Kotlin", "Fatih Deniz", "Kotlin ile Mobil Programlama Baştan Sona Adım Adım", "kotlin, android, mobil, programlama", "postImages/defaultThumbnail.jpg", "Kotlin ile Mobil Programlama", 750, 1 },
                    { 9, 9, 0, "Al contrario di quanto si pensi, Lorem Ipsum non è semplicemente una sequenza casuale di caratteri. Risale ad un classico della letteratura latina del 45 AC, cosa che lo rende vecchio di 2000 anni. Richard McClintock, professore di latino al Hampden-Sydney College in Virginia, ha ricercato una delle più oscure parole latine, consectetur, da un passaggio del Lorem Ipsum e ha scoperto tra i vari testi in cui è citata, la fonte da cui è tratto il testo, le sezioni 1.10.32 and 1.10.33 del 'de Finibus Bonorum et Malorum' di Cicerone. Questo testo è un trattato su teorie di etica, molto popolare nel Rinascimento. La prima riga del Lorem Ipsum, 'Lorem ipsum dolor sit amet..'', è tratta da un passaggio della sezione 1.10.32.", "InitialCreate", new DateTime(2021, 12, 2, 3, 34, 57, 115, DateTimeKind.Local).AddTicks(4112), new DateTime(2021, 12, 2, 3, 34, 57, 115, DateTimeKind.Local).AddTicks(4109), "default.jpg", true, false, "InitialCreate", new DateTime(2021, 12, 2, 3, 34, 57, 115, DateTimeKind.Local).AddTicks(4114), "Swift", "Fatih Deniz", "Swift ile IOS Mobil Programlama Baştan Sona Adım Adım", "IOS, android, mobil, programlama", "postImages/defaultThumbnail.jpg", "Swift ile IOS Programlama", 14900, 1 },
                    { 10, 10, 0, "Esistono innumerevoli variazioni dei passaggi del Lorem Ipsum, ma la maggior parte hanno subito delle variazioni del tempo, a causa dell’inserimento di passaggi ironici, o di sequenze casuali di caratteri palesemente poco verosimili. Se si decide di utilizzare un passaggio del Lorem Ipsum, è bene essere certi che non contenga nulla di imbarazzante. In genere, i generatori di testo segnaposto disponibili su internet tendono a ripetere paragrafi predefiniti, rendendo questo il primo vero generatore automatico su intenet. Infatti utilizza un dizionario di oltre 200 vocaboli latini, combinati con un insieme di modelli di strutture di periodi, per generare passaggi di testo verosimili. Il testo così generato è sempre privo di ripetizioni, parole imbarazzanti o fuori luogo ecc.", "InitialCreate", new DateTime(2021, 12, 2, 3, 34, 57, 115, DateTimeKind.Local).AddTicks(4123), new DateTime(2021, 12, 2, 3, 34, 57, 115, DateTimeKind.Local).AddTicks(4120), "default.jpg", true, false, "InitialCreate", new DateTime(2021, 12, 2, 3, 34, 57, 115, DateTimeKind.Local).AddTicks(4125), "Ruby", "Fatih Deniz", "Ruby, Ruby on Rails Web Programlama, AirBnb Klon", "Ruby on Rails, Ruby, Web Programlama, AirBnb", "postImages/defaultThumbnail.jpg", "Ruby on Rails ile AirBnb Klon Kodlayalım", 26777, 1 }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "ArticleId", "Content", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "Title", "UserName" },
                values: new object[,]
                {
                    { 1, 1, "Lorem Ipsum pasajlarının birçok çeşitlemesi vardır. Ancak bunların büyük bir çoğunluğu mizah katılarak veya rastgele sözcükler eklenerek değiştirilmişlerdir. Eğer bir Lorem Ipsum pasajı kullanacaksanız, metin aralarına utandırıcı sözcükler gizlenmediğinden emin olmanız gerekir. İnternet'teki tüm Lorem Ipsum üreteçleri önceden belirlenmiş metin bloklarını yineler. Bu da, bu üreteci İnternet üzerindeki gerçek Lorem Ipsum üreteci yapar. Bu üreteç, 200'den fazla Latince sözcük ve onlara ait cümle yapılarını içeren bir sözlük kullanır. Bu nedenle, üretilen Lorem Ipsum metinleri yinelemelerden, mizahtan ve karakteristik olmayan sözcüklerden uzaktır.", "InitialCreate", new DateTime(2021, 12, 2, 3, 34, 57, 120, DateTimeKind.Local).AddTicks(4203), true, false, "InitialCreate", new DateTime(2021, 12, 2, 3, 34, 57, 120, DateTimeKind.Local).AddTicks(4214), "C# Makale Yorumu", "Harika bir makale olmus", "Admin" },
                    { 2, 2, "Lorem Ipsum jest tekstem stosowanym jako przykładowy wypełniacz w przemyśle poligraficznym. Został po raz pierwszy użyty w XV w. przez nieznanego drukarza do wypełnienia tekstem próbnej książki. Pięć wieków później zaczął być używany przemyśle elektronicznym, pozostając praktycznie niezmienionym. Spopularyzował się w latach 60. XX w. wraz z publikacją arkuszy Letrasetu, zawierających fragmenty Lorem Ipsum, a ostatnio z zawierającym różne wersje Lorem Ipsum oprogramowaniem przeznaczonym do realizacji druków na komputerach osobistych, jak Aldus PageMaker", "InitialCreate", new DateTime(2021, 12, 2, 3, 34, 57, 120, DateTimeKind.Local).AddTicks(4225), true, false, "InitialCreate", new DateTime(2021, 12, 2, 3, 34, 57, 120, DateTimeKind.Local).AddTicks(4228), "C++ Makale Yorumu", "Harika bir makale olmus", "Admin" },
                    { 3, 3, "Ang Lorem Ipsum ay ginagamit na modelo ng industriya ng pagpriprint at pagtytypeset. Ang Lorem Ipsum ang naging regular na modelo simula pa noong 1500s, noong may isang di kilalang manlilimbag and kumuha ng galley ng type at ginulo ang pagkaka-ayos nito upang makagawa ng libro ng mga type specimen. Nalagpasan nito hindi lang limang siglo, kundi nalagpasan din nito ang paglaganap ng electronic typesetting at nanatiling parehas. Sumikat ito noong 1960s kasabay ng pag labas ng Letraset sheets na mayroong mga talata ng Lorem Ipsum, at kamakailan lang sa mga desktop publishing software tulad ng Aldus Pagemaker ginamit ang mga bersyon ng Lorem Ipsum.", "InitialCreate", new DateTime(2021, 12, 2, 3, 34, 57, 120, DateTimeKind.Local).AddTicks(4234), true, false, "InitialCreate", new DateTime(2021, 12, 2, 3, 34, 57, 120, DateTimeKind.Local).AddTicks(4236), "JavaScript Makale Yorumu", "Harika bir makale olmus", "Admin" },
                    { 4, 4, "Lorem Ipsum er rett og slett dummytekst fra og for trykkeindustrien. Lorem Ipsum har vært bransjens standard for dummytekst helt siden 1500-tallet, da en ukjent boktrykker stokket en mengde bokstaver for å lage et prøveeksemplar av en bok. Lorem Ipsum har tålt tidens tann usedvanlig godt, og har i tillegg til å bestå gjennom fem århundrer også tålt spranget over til elektronisk typografi uten vesentlige endringer. Lorem Ipsum ble gjort allment kjent i 1960-årene ved lanseringen av Letraset-ark med avsnitt fra Lorem Ipsum, og senere med sideombrekkingsprogrammet Aldus PageMaker som tok i bruk nettopp Lorem Ipsum for dummytekst.", "InitialCreate", new DateTime(2021, 12, 2, 3, 34, 57, 120, DateTimeKind.Local).AddTicks(4242), true, false, "InitialCreate", new DateTime(2021, 12, 2, 3, 34, 57, 120, DateTimeKind.Local).AddTicks(4244), "Typescript Makale Yorumu", "Harika bir makale olmus", "Admin" },
                    { 5, 5, "Lorem Ipsum este pur şi simplu o machetă pentru Content a industriei tipografice. Lorem Ipsum a fost macheta standard a industriei încă din secolul al XVI-lea, când un tipograf anonim a luat o planşetă de litere şi le-a amestecat pentru a crea o carte demonstrativă pentru literele respective. Nu doar că a supravieţuit timp de cinci secole, dar şi a facut saltul în tipografia electronică practic neschimbată. A fost popularizată în anii '60 odată cu ieşirea colilor Letraset care conţineau pasaje Lorem Ipsum, iar mai recent, prin programele de publicare pentru calculator, ca Aldus PageMaker care includeau versiuni de Lorem Ipsum.", "InitialCreate", new DateTime(2021, 12, 2, 3, 34, 57, 120, DateTimeKind.Local).AddTicks(4250), true, false, "InitialCreate", new DateTime(2021, 12, 2, 3, 34, 57, 120, DateTimeKind.Local).AddTicks(4252), "Java Makale Yorumu", "Harika bir makale olmus", "Admin" },
                    { 6, 6, "Lorem Ipsum je jednostavno probni tekst koji se koristi u tiskarskoj i slovoslagarskoj industriji. Lorem Ipsum postoji kao industrijski standard još od 16-og stoljeća, kada je nepoznati tiskar uzeo tiskarsku galiju slova i posložio ih da bi napravio knjigu s uzorkom tiska. Taj je tekst ne samo preživio pet stoljeća, već se i vinuo u svijet elektronskog slovoslagarstva, ostajući u suštini nepromijenjen. Postao je popularan tijekom 1960-ih s pojavom Letraset listova s odlomcima Lorem Ipsum-a, a u skorije vrijeme sa software-om za stolno izdavaštvo kao što je Aldus PageMaker koji također sadrži varijante Lorem Ipsum-a.", "InitialCreate", new DateTime(2021, 12, 2, 3, 34, 57, 120, DateTimeKind.Local).AddTicks(4258), true, false, "InitialCreate", new DateTime(2021, 12, 2, 3, 34, 57, 120, DateTimeKind.Local).AddTicks(4261), "Python Makale Yorumu", "Harika bir makale olmus", "Admin" },
                    { 7, 7, "Lorem Ipsum – tas ir teksta salikums, kuru izmanto poligrāfijā un maketēšanas darbos. Lorem Ipsum ir kļuvis par vispārpieņemtu teksta aizvietotāju kopš 16. gadsimta sākuma. Tajā laikā kāds nezināms iespiedējs izveidoja teksta fragmentu, lai nodrukātu grāmatu ar burtu paraugiem. Tas ir ne tikai pārdzīvojis piecus gadsimtus, bet bez ievērojamām izmaiņām saglabājies arī mūsdienās, pārejot uz datorizētu teksta apstrādi. Tā popularizēšanai 60-tajos gados kalpoja Letraset burtu paraugu publicēšana ar Lorem Ipsum teksta fragmentiem un, nesenā pagātnē, tādas maketēšanas programmas kā Aldus PageMaker, kuras šablonu paraugos ir izmantots Lorem Ipsum teksts.", "InitialCreate", new DateTime(2021, 12, 2, 3, 34, 57, 120, DateTimeKind.Local).AddTicks(4266), true, false, "InitialCreate", new DateTime(2021, 12, 2, 3, 34, 57, 120, DateTimeKind.Local).AddTicks(4269), "Php Makale Yorumu", "Harika bir makale olmus", "Admin" },
                    { 8, 8, "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model Content, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).", "InitialCreate", new DateTime(2021, 12, 2, 3, 34, 57, 120, DateTimeKind.Local).AddTicks(4274), true, false, "InitialCreate", new DateTime(2021, 12, 2, 3, 34, 57, 120, DateTimeKind.Local).AddTicks(4277), "Kotlin Makale Yorumu", "Harika bir makale olmus", "Admin" },
                    { 9, 9, "هنالك العديد من الأنواع المتوفرة لنصوص لوريم إيبسوم، ولكن الغالبية تم تعديلها بشكل ما عبر إدخال بعض النوادر أو الكلمات العشوائية إلى النص. إن كنت تريد أن تستخدم نص لوريم إيبسوم ما، عليك أن تتحقق أولاً أن ليس هناك أي كلمات أو عبارات محرجة أو غير لائقة مخبأة في هذا النص. بينما تعمل جميع مولّدات نصوص لوريم إيبسوم على الإنترنت على إعادة تكرار مقاطع من نص لوريم إيبسوم نفسه عدة مرات بما تتطلبه الحاجة، يقوم مولّدنا هذا باستخدام كلمات من قاموس يحوي على أكثر من 200 كلمة لا تينية، مضاف إليها مجموعة من الجمل النموذجية، لتكوين نص لوريم إيبسوم ذو شكل منطقي قريب إلى النص الحقيقي. وبالتالي يكون النص الناتح خالي من التكرار، أو أي كلمات أو عبارات غير لائقة أو ما شابه. وهذا ما يجعله أول مولّد نص لوريم إيبسوم حقيقي على الإنترنت.", "InitialCreate", new DateTime(2021, 12, 2, 3, 34, 57, 120, DateTimeKind.Local).AddTicks(4283), true, false, "InitialCreate", new DateTime(2021, 12, 2, 3, 34, 57, 120, DateTimeKind.Local).AddTicks(4285), "Swift Makale Yorumu", "Harika bir makale olmus", "Admin" },
                    { 10, 10, "Lorem Ipsum，也称乱数假文或者哑元文本， 是印刷及排版领域所常用的虚拟文字。由于曾经一台匿名的打印机刻意打乱了一盒印刷字体从而造出一本字体样品书，Lorem Ipsum从西元15世纪起就被作为此领域的标准文本使用。它不仅延续了五个世纪，还通过了电子排版的挑战，其雏形却依然保存至今。在1960年代，”Leatraset”公司发布了印刷着Lorem Ipsum段落的纸张，从而广泛普及了它的使用。最近，计算机桌面出版软件”Aldus PageMaker”也通过同样的方式使Lorem Ipsum落入大众的视野。", "InitialCreate", new DateTime(2021, 12, 2, 3, 34, 57, 120, DateTimeKind.Local).AddTicks(4291), true, false, "InitialCreate", new DateTime(2021, 12, 2, 3, 34, 57, 120, DateTimeKind.Local).AddTicks(4293), "Ruby Makale Yorumu", "Harika bir makale olmus", "Admin" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Articles_CategoryId",
                table: "Articles",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_WriterId",
                table: "Articles",
                column: "WriterId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ArticleId",
                table: "Comments",
                column: "ArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_Writers_RoleId",
                table: "Writers",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abouts");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Writers");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
