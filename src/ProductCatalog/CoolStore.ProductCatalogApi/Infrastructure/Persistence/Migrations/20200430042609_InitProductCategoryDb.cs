using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoolStore.ProductCatalogApi.Infrastructure.Persistence.Migrations
{
    public partial class InitProductCategoryDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "product");

            migrationBuilder.CreateTable(
                name: "Category",
                schema: "product",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    Updated = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rating",
                schema: "product",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    Updated = table.Column<DateTime>(nullable: true),
                    ProductId = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    Cost = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rating", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                schema: "product",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    Updated = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: false),
                    StoreId = table.Column<Guid>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CategoryId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalSchema: "product",
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "product",
                table: "Category",
                columns: new[] { "Id", "Created", "Name", "Updated" },
                values: new object[,]
                {
                    { new Guid("80287ef3-987f-4312-a0c6-ccc2239aeea3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Electronic Gadgets", null },
                    { new Guid("664690ee-a647-4b12-b87f-af5c511187eb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Food products", null },
                    { new Guid("1ebdd04f-a447-42a3-9e65-5697c1dacb09"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accessories", null },
                    { new Guid("77666aa8-682c-4047-b075-04839281630a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beverage products", null }
                });

            migrationBuilder.InsertData(
                schema: "product",
                table: "Product",
                columns: new[] { "Id", "CategoryId", "Created", "Description", "ImageUrl", "IsDeleted", "Name", "Price", "StoreId", "Updated" },
                values: new object[,]
                {
                    { new Guid("ba16da71-c7dd-4eac-9ead-5c2c2244e69f"), new Guid("80287ef3-987f-4312-a0c6-ccc2239aeea3"), new DateTime(2020, 4, 30, 4, 26, 9, 243, DateTimeKind.Utc).AddTicks(2831), "IPhone 8", "https://picsum.photos/1200/900?image=1", false, "IPhone 8", 900.0, new Guid("90c9479e-a11c-4d6d-aaaa-0405b6c0efcd"), null },
                    { new Guid("1adbc55a-4354-4205-b96d-c95e2dc806f4"), new Guid("77666aa8-682c-4047-b075-04839281630a"), new DateTime(2020, 4, 30, 4, 26, 9, 246, DateTimeKind.Utc).AddTicks(4887), "Interat ven retrn transp", "https://picsum.photos/1200/900?image=20", false, "Milk - Skim", 3310.0, new Guid("b8b62196-6369-409d-b709-11c112dd023f"), null },
                    { new Guid("f92bfa6a-2522-4234-a7f1-9004596a4a85"), new Guid("77666aa8-682c-4047-b075-04839281630a"), new DateTime(2020, 4, 30, 4, 26, 9, 246, DateTimeKind.Utc).AddTicks(4706), "Toxicology-endocrine", "https://picsum.photos/1200/900?image=13", false, "Godiva White Chocolate", 2067.0, new Guid("ec186ddf-f430-44ec-84e5-205c93d84f14"), null },
                    { new Guid("297c5959-4808-4f40-8d6a-4a899505e1f7"), new Guid("77666aa8-682c-4047-b075-04839281630a"), new DateTime(2020, 4, 30, 4, 26, 9, 246, DateTimeKind.Utc).AddTicks(4643), "Remove bladder stimulat", "https://picsum.photos/1200/900?image=10", false, "Oranges - Navel, 72", 1731.0, new Guid("b8b62196-6369-409d-b709-11c112dd023f"), null },
                    { new Guid("386b04c6-303a-4840-8a51-d92b1ea2d339"), new Guid("77666aa8-682c-4047-b075-04839281630a"), new DateTime(2020, 4, 30, 4, 26, 9, 246, DateTimeKind.Utc).AddTicks(4620), "Removal of FB NOS", "https://picsum.photos/1200/900?image=9", false, "Hersey Shakes", 2441.0, new Guid("ec186ddf-f430-44ec-84e5-205c93d84f14"), null },
                    { new Guid("fee1fc67-7469-4490-b418-47f4732de53f"), new Guid("1ebdd04f-a447-42a3-9e65-5697c1dacb09"), new DateTime(2020, 4, 30, 4, 26, 9, 246, DateTimeKind.Utc).AddTicks(4578), "Open periph nerve biopsy", "https://picsum.photos/1200/900?image=7", false, "Bag - Regular Kraft 20 Lb", 2147.0, new Guid("b8b62196-6369-409d-b709-11c112dd023f"), null },
                    { new Guid("4693520a-2b14-4d90-8b64-541575511382"), new Guid("664690ee-a647-4b12-b87f-af5c511187eb"), new DateTime(2020, 4, 30, 4, 26, 9, 246, DateTimeKind.Utc).AddTicks(5055), "Abdomen wall repair NEC", "https://picsum.photos/1200/900?image=27", false, "Prunes - Pitted", 1191.0, new Guid("b8b62196-6369-409d-b709-11c112dd023f"), null },
                    { new Guid("6e3ac253-517d-48e5-96ad-800451f8591c"), new Guid("664690ee-a647-4b12-b87f-af5c511187eb"), new DateTime(2020, 4, 30, 4, 26, 9, 246, DateTimeKind.Utc).AddTicks(5034), "Wound catheter irrigat", "https://picsum.photos/1200/900?image=26", false, "Longos - Penne With Pesto", 3639.0, new Guid("b8b62196-6369-409d-b709-11c112dd023f"), null },
                    { new Guid("b243a35d-120a-4db3-ad12-7b3fa80e6391"), new Guid("664690ee-a647-4b12-b87f-af5c511187eb"), new DateTime(2020, 4, 30, 4, 26, 9, 246, DateTimeKind.Utc).AddTicks(5014), "Implt/repl carddefib tot", "https://picsum.photos/1200/900?image=25", false, "Soup - Campbells Chili", 3294.0, new Guid("b8b62196-6369-409d-b709-11c112dd023f"), null },
                    { new Guid("e88e07f8-358d-48f7-b17c-8a16458f9c0a"), new Guid("664690ee-a647-4b12-b87f-af5c511187eb"), new DateTime(2020, 4, 30, 4, 26, 9, 246, DateTimeKind.Utc).AddTicks(4993), "Oth chest cage rep/plast", "https://picsum.photos/1200/900?image=24", false, "Lotus Leaves", 1504.0, new Guid("ec186ddf-f430-44ec-84e5-205c93d84f14"), null },
                    { new Guid("89b46ea8-b9a6-40e5-8df3-dba1095695f7"), new Guid("664690ee-a647-4b12-b87f-af5c511187eb"), new DateTime(2020, 4, 30, 4, 26, 9, 246, DateTimeKind.Utc).AddTicks(4972), "Excision of wrist NEC", "https://picsum.photos/1200/900?image=23", false, "Mushroom - Lg - Cello", 3318.0, new Guid("b8b62196-6369-409d-b709-11c112dd023f"), null },
                    { new Guid("c3770b10-dd0f-4b1c-83aa-d424c175c087"), new Guid("664690ee-a647-4b12-b87f-af5c511187eb"), new DateTime(2020, 4, 30, 4, 26, 9, 246, DateTimeKind.Utc).AddTicks(4907), "Hepatic lobectomy", "https://picsum.photos/1200/900?image=20", false, "Beef - Shank", 3196.0, new Guid("ec186ddf-f430-44ec-84e5-205c93d84f14"), null },
                    { new Guid("fac2ccc6-2c3f-4c1e-acbd-5354ba0873fb"), new Guid("664690ee-a647-4b12-b87f-af5c511187eb"), new DateTime(2020, 4, 30, 4, 26, 9, 246, DateTimeKind.Utc).AddTicks(4866), "Plastic rep ext ear NEC", "https://picsum.photos/1200/900?image=19", false, "Pasta - Cappellini, Dry", 3305.0, new Guid("ec186ddf-f430-44ec-84e5-205c93d84f14"), null },
                    { new Guid("cfc5cff8-ab2a-4c70-994d-5ab8ccb7cb0d"), new Guid("664690ee-a647-4b12-b87f-af5c511187eb"), new DateTime(2020, 4, 30, 4, 26, 9, 246, DateTimeKind.Utc).AddTicks(4845), "Chng hnd mus/ten lng NEC", "https://picsum.photos/1200/900?image=18", false, "Crab - Dungeness, Whole, live", 1665.0, new Guid("b8b62196-6369-409d-b709-11c112dd023f"), null },
                    { new Guid("97ad5bf4-d153-41c5-a6e0-6d0bfbbb4f67"), new Guid("664690ee-a647-4b12-b87f-af5c511187eb"), new DateTime(2020, 4, 30, 4, 26, 9, 246, DateTimeKind.Utc).AddTicks(4819), "Skull plate removal", "https://picsum.photos/1200/900?image=17", false, "Oil - Olive", 1124.0, new Guid("ec186ddf-f430-44ec-84e5-205c93d84f14"), null },
                    { new Guid("22112bb2-c324-4860-8eb9-9c78853a52a5"), new Guid("664690ee-a647-4b12-b87f-af5c511187eb"), new DateTime(2020, 4, 30, 4, 26, 9, 246, DateTimeKind.Utc).AddTicks(4769), "Vessel operation NEC", "https://picsum.photos/1200/900?image=16", false, "Beef - Tenderloin Tails", 967.0, new Guid("b8b62196-6369-409d-b709-11c112dd023f"), null },
                    { new Guid("85b9767c-1a09-4c33-8e77-faa25f1d69e1"), new Guid("664690ee-a647-4b12-b87f-af5c511187eb"), new DateTime(2020, 4, 30, 4, 26, 9, 246, DateTimeKind.Utc).AddTicks(4749), "Tendon excision for grft", "https://picsum.photos/1200/900?image=15", false, "Tarragon - Primerba, Paste", 642.0, new Guid("ec186ddf-f430-44ec-84e5-205c93d84f14"), null },
                    { new Guid("cbe43158-2010-4cb1-a8de-f00da16a7362"), new Guid("664690ee-a647-4b12-b87f-af5c511187eb"), new DateTime(2020, 4, 30, 4, 26, 9, 246, DateTimeKind.Utc).AddTicks(4727), "Opn/oth part gastrectomy", "https://picsum.photos/1200/900?image=14", false, "Ecolab - Balanced Fusion", 1769.0, new Guid("b8b62196-6369-409d-b709-11c112dd023f"), null },
                    { new Guid("71c46659-9560-4d6a-ac18-893477ed6662"), new Guid("664690ee-a647-4b12-b87f-af5c511187eb"), new DateTime(2020, 4, 30, 4, 26, 9, 246, DateTimeKind.Utc).AddTicks(4685), "Oth thorac op thymus NOS", "https://picsum.photos/1200/900?image=12", false, "Lettuce - Boston Bib", 3453.0, new Guid("ec186ddf-f430-44ec-84e5-205c93d84f14"), null },
                    { new Guid("3a0a0a89-9b3a-4046-bf2b-deee64a764d2"), new Guid("664690ee-a647-4b12-b87f-af5c511187eb"), new DateTime(2020, 4, 30, 4, 26, 9, 246, DateTimeKind.Utc).AddTicks(4664), "Other bone dx proc NEC", "https://picsum.photos/1200/900?image=11", false, "Cheese - Swiss", 975.0, new Guid("ec186ddf-f430-44ec-84e5-205c93d84f14"), null },
                    { new Guid("2d2245e4-213a-49de-93d3-79e9439400f5"), new Guid("664690ee-a647-4b12-b87f-af5c511187eb"), new DateTime(2020, 4, 30, 4, 26, 9, 246, DateTimeKind.Utc).AddTicks(4599), "Tibia/fibula inj op NOS", "https://picsum.photos/1200/900?image=8", false, "Wonton Wrappers", 2200.0, new Guid("b8b62196-6369-409d-b709-11c112dd023f"), null },
                    { new Guid("6a0e6d20-8bcc-450f-bc5c-b8f727083dcd"), new Guid("664690ee-a647-4b12-b87f-af5c511187eb"), new DateTime(2020, 4, 30, 4, 26, 9, 246, DateTimeKind.Utc).AddTicks(4556), "Fiber-optic bronchoscopy", "https://picsum.photos/1200/900?image=6", false, "Bread - White, Unsliced", 2809.0, new Guid("ec186ddf-f430-44ec-84e5-205c93d84f14"), null },
                    { new Guid("a4811778-5070-4d70-8a9c-e6cb70dfcca4"), new Guid("664690ee-a647-4b12-b87f-af5c511187eb"), new DateTime(2020, 4, 30, 4, 26, 9, 246, DateTimeKind.Utc).AddTicks(4526), "Mastoidectomy revision", "https://picsum.photos/1200/900?image=5", false, "Cheese - Camembert", 253.0, new Guid("b8b62196-6369-409d-b709-11c112dd023f"), null },
                    { new Guid("ffd60654-1802-48bd-b4c3-d49831a8ab2c"), new Guid("80287ef3-987f-4312-a0c6-ccc2239aeea3"), new DateTime(2020, 4, 30, 4, 26, 9, 246, DateTimeKind.Utc).AddTicks(4455), "Asus UX370U i7 8550U (C4217TS)", "https://picsum.photos/1200/900?image=4", false, "Asus UX370U i7 8550U (C4217TS)", 500.0, new Guid("90c9479e-a11c-4d6d-aaaa-0405b6c0efcd"), null },
                    { new Guid("b8f0a771-339f-4602-a862-f7a51afd5b79"), new Guid("80287ef3-987f-4312-a0c6-ccc2239aeea3"), new DateTime(2020, 4, 30, 4, 26, 9, 246, DateTimeKind.Utc).AddTicks(4426), "MacBook Pro 2019", "https://picsum.photos/1200/900?image=3", false, "MacBook Pro 2019", 4000.0, new Guid("90c9479e-a11c-4d6d-aaaa-0405b6c0efcd"), null },
                    { new Guid("13d02035-2286-4055-ad2d-6855a60efbbb"), new Guid("80287ef3-987f-4312-a0c6-ccc2239aeea3"), new DateTime(2020, 4, 30, 4, 26, 9, 246, DateTimeKind.Utc).AddTicks(4267), "IPhone X", "https://picsum.photos/1200/900?image=2", false, "IPhone X", 1000.0, new Guid("90c9479e-a11c-4d6d-aaaa-0405b6c0efcd"), null },
                    { new Guid("6b8d0110-e3e8-4727-a51e-06f38864e464"), new Guid("77666aa8-682c-4047-b075-04839281630a"), new DateTime(2020, 4, 30, 4, 26, 9, 246, DateTimeKind.Utc).AddTicks(4929), "Proximal gastrectomy", "https://picsum.photos/1200/900?image=21", false, "Ice Cream Bar - Oreo Cone", 2236.0, new Guid("b8b62196-6369-409d-b709-11c112dd023f"), null },
                    { new Guid("3b69e116-9dd6-400f-96ce-9911f4f6ac8b"), new Guid("77666aa8-682c-4047-b075-04839281630a"), new DateTime(2020, 4, 30, 4, 26, 9, 246, DateTimeKind.Utc).AddTicks(4949), "Appendiceal ops NEC", "https://picsum.photos/1200/900?image=22", false, "Mix - Cocktail Ice Cream", 232.0, new Guid("ec186ddf-f430-44ec-84e5-205c93d84f14"), null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryId",
                schema: "product",
                table: "Product",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product",
                schema: "product");

            migrationBuilder.DropTable(
                name: "Rating",
                schema: "product");

            migrationBuilder.DropTable(
                name: "Category",
                schema: "product");
        }
    }
}
