using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DogsAdoptionService.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cuteness = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FavFood = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FavToy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Temperament = table.Column<int>(type: "int", nullable: false),
                    IsAdopted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dogs", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "Id", "Cuteness", "FavFood", "FavToy", "Image", "IsAdopted", "Name", "Temperament" },
                values: new object[,]
                {
                    { 1, 10, "Barkoni", "Barkle", "BarkTwain1.jpg", false, "Bark Twain", 7 },
                    { 2, 10, "Pawsta", "Fetch Stick", "SirWaggington2.jpg", false, "Sir Waggington", 6 },
                    { 3, 10, "Bone Appetit", "Squeaky Ball", "Furball3.jpg", false, "Furball", 8 },
                    { 4, 10, "Royal Canin", "Diamond Collar", "PrincessPaws4.jpg", false, "Princess Paws", 6 },
                    { 5, 10, "Pupcakes", "Chewy Bone", "Biscuit5.jpg", false, "Biscuit", 9 },
                    { 6, 10, "Doggie Delight", "Plush Squirrel", "Daisy6.jpg", false, "Daisy", 6 },
                    { 7, 10, "Fish 'n Chips", "Nautical Rope", "CaptainWoof7.jpg", false, "Captain Woof", 8 },
                    { 8, 10, "Cuddle Crunchies", "Soft Blanket", "SnugglePaws8.jpg", false, "Snuggle Paws", 7 },
                    { 9, 10, "Steak Bites", "Tennis Ball", "Rocky9.jpg", false, "Rocky", 7 },
                    { 10, 10, "Treat Tower", "Squeaky Duck", "Lola10.jpg", false, "Lola", 6 },
                    { 11, 10, "Beefy Bites", "Tug Rope", "Maximus11.jpg", false, "Maximus", 9 },
                    { 12, 10, "Chicken Chewies", "Frisbee", "Roxy12.jpg", false, "Roxy", 7 },
                    { 13, 10, "Carrot Crunch", "Plush Bunny", "Teddy13.jpg", false, "Teddy", 6 },
                    { 14, 10, "Coconut Chew", "Ball Launcher", "Coco14.jpg", false, "Coco", 8 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dogs");
        }
    }
}
