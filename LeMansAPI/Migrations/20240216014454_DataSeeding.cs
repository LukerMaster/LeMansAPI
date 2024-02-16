using Microsoft.EntityFrameworkCore.Migrations;

namespace LeMansAPI.Migrations;

public partial class DataSeeding : Migration
{
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.InsertData(
            table: "Cars",
            columns: new[] { "Brand", "Model", "ProductionYear", "PeakPowerKw", "CurbWeightKg" },
            values: new object[,]
            {
                { "Ferrari", "488 GTB", 2015, 492, 1475 },
                { "Lamborghini", "Huracan", 2014, 449, 1422 },
                { "Porsche", "911 GT3 RS", 2015, 383, 1430 },
                { "BMW", "M3 GTR", 2005, 368, 1350 },
                { "Lamborghini", "Sesto Elemento", 2012, 419, 999 },
                { "Aston Martin", "DB11", 2016, 447, 1870 },
                { "McLaren", "720S", 2017, 529, 1419 },
                { "Bugatti", "Chiron", 2016, 1103, 1995 },
                { "Audi", "R8 V10 Plus", 2017, 449, 1600 },
                { "Nissan", "GT-R Nismo", 2019, 447, 1752 }
            });

        migrationBuilder.InsertData(
            table: "Races",
            columns: new[] { "StartTime", "EndTime", "Note" },
            values: new object[,]
            {
                { new DateTime(2024, 5, 15, 8, 0, 10).ToUniversalTime(), new DateTime(2024, 5, 16, 8, 6, 23).ToUniversalTime(), "Sunny weather, no incidents" },
                { new DateTime(2023, 5, 22, 8, 0, 20).ToUniversalTime(), new DateTime(2023, 5, 23, 8, 8, 14).ToUniversalTime(), "Rainy conditions, several accidents" },
                { new DateTime(2022, 5, 25, 9, 0, 17).ToUniversalTime(), new DateTime(2022, 5, 26, 9, 1, 51).ToUniversalTime(), "Foggy weather, delayed start" }
            });

        migrationBuilder.InsertData(
            table: "RaceEntryResults",
            columns: new[] { "CarId", "RaceId", "MetersDriven" },
            values: new object?[,]
            {
                {1, 1, 4_503_405 },
                {2, 2, 4_504_506 },
                {5, 3, 5_234_403 },
                {3, 2, 4_887_755 },
                {8, 3, 5_111_222 },
                {9, 1, 4_650_000 },
                {4, 2, 6_723_421 },
                {7, 3, 5_310_000 },
                {10, 1, 4_987_654 },
                {8, 2, 4_960_000 },
                {5, 3, 5_132_400 },
                {6, 1, 4_777_234 },
                {3, 2, 4_589_543 },
                {1, 3, 5_021_123 },
                {7, 1, 4_855_123 },
                {6, 2, 4_909_812 },
                {9, 3, 5_150_000 },
                {10, 1, 5_098_765 },
                {5, 2, 4_999_999 },
                {2, 3, 5_200_000 },
                {1, 1, 4_901_234 },
                {9, 2, 5_005_001 },
                {7, 3, 5_078_901 },
                {3, 1, 4_999_999 },
                {6, 2, 4_990_000 },
                {3, 3, 5_266_666 },
                {8, 1, 4_812_345 },
                {9, 2, 5_111_234 },
                {10, 3, 5_300_000 },
            });

        migrationBuilder.InsertData(
            table: "Drivers",
            columns: new[] { "RaceEntryResultId", "FirstName", "LastName" },
            values: new object[,]
            {
                {1, "Lewis", "Ham" },
                {1, "Sebastian", "Ventyl" },
                {1, "Max", "Ymilian" },
                {2, "Shybkipan", "Testovy" },
                {2, "Scooter", "McGee" },
                {2, "Bubbles", "Gigglesworth" },
                {3, "Freckles", "McNugget" },
                {3, "Snuggles", "Fluffypants" },
                {3, "Dizzy", "McGuffin" },
                {4, "Peaches", "Sparklebottom" },
                {4, "Tootsie", "Wafflestomp" },
                {4, "Buddy", "Snoozebutton" },
                {5, "Sassy", "McSneeze" },
                {5, "Pickles", "Whippersnapper" },
                {5, "Muffin", "Tickletoes" },
                {6, "Cupcake", "Bananafluff" },
                {6, "Nibbles", "Snugglebuns" },
                {6, "Bongo", "Bananapeel" },
                {7, "Twinkles", "Fuzzybritches" },
                {7, "Chuckles", "Wigglebottom" },
                {7, "Noodle", "Snickerdoodle" },
                {8, "Pudding", "Bumblebee" },
                {8, "Snoopy", "Sprinklepants" },
                {8, "Flapjack", "Pickleberry" },
                {9, "Gizmo", "Buttercup" },
                {9, "Jellybean", "Sugarplum" },
                {9, "Wiggles", "Squishyface" },
                {10, "Peanut", "Poptart" },
                {10, "Nugget", "Doodlebug" },
                {10, "Squiggles", "Gumdrop" },
                {11, "Biscuit", "Marshmallow" },
                {11, "Fluffy", "Popcorn" },
                {11, "Sprinkles", "Cheeseball" }
            });

        migrationBuilder.InsertData(
            table: "PitStops",
            columns: new[] { "RaceEntryResultId", "LitersRefueled", "NumOfTiresChanged", "NewDriverId", "NotesOfRepairs", "OtherNotes" },
            values: new object[,]
            {
                {4, 50.5f, 4, null, "", "" },
                {5, 45.2f, 0, null, "", "Rain started during the stop, changed strategy." },
                {22, 60.8f, 4, 2, "", "Driver change." },
                {9, 55.0f, 4, null, "Replaced damaged front wing.", "" },
                {13, 48.6f, 2, 3, "", "" },
                {10, 40.0f, 0, null, "", "Car stalled, lost significant time." },
                {8, 65.3f, 4, null, "", "" },
                {7, 70.0f, 4, null, "Replaced gearbox.", "" },
                {4, 42.5f, 0, 1, "", "" },
                {2, 58.2f, 4, null, "", "" }
            });

        

        
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
        for (int i = 1; i <= 10; i++)
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: i);

        for (int i = 1; i <= 33; i++)
            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: i);

        for (int i = 1; i <= 3; i++)
            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: i);
        for (int i = 1; i <= 33; i++)
            migrationBuilder.DeleteData(
                table: "RaceEntryResults",
                keyColumn: "Id",
                keyValue: i);
    }
}