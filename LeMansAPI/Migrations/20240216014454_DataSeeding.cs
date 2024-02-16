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
                { "Nissan", "GT-R Nismo", 2019, 447, 1752 },
                { "Polonez", "Caro", 1994, 800, 850 },
                { "Fiat", "125p", 1990, 900, 800 }
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
                {11, 1, 6_652_136 },
                {4, 2, 6_727_421 },
                {12, 3, 6_722_573 },
                {10, 1, 4_987_654 },
                {8, 2, 4_960_034 },
                {5, 3, 5_132_400 },
                {6, 1, 4_777_234 },
                {3, 2, 4_589_543 },
                {1, 3, 5_021_123 },
                {7, 1, 4_855_123 },
                {6, 2, 4_909_812 },
                {9, 3, 5_150_005 },
                {10, 1, 5_098_765 },
                {5, 2, 4_999_999 },
                {2, 3, 5_200_034 },
                {1, 1, 4_901_234 },
                {9, 2, 5_005_001 },
                {7, 3, 5_078_901 },
                {3, 1, 4_999_999 },
                {6, 2, 4_990_065 },
                {3, 3, 5_266_666 },
                {8, 1, 4_812_345 },
                {9, 2, 5_111_234 },
                {10, 3, 5_300_034 },
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
                {6, "Jacek", "Soplica" },
                {6, "Waldemar", "Kiepski" },
                {6, "Grzegorz", "Brzęczyszczykiewicz" },
                {7, "Arnold", "Boczek" },
                {7, "Włodzimierz", "Biały" },
                {7, "Tadeusz", "Norek" },
                {8, "Marian", "Paździoch" },
                {8, "Kazimierz", "Wielki" },
                {8, "Władysław", "Jagiełło" },
                {9, "Gizmo", "Buttercup" },
                {9, "Jellybean", "Sugarplum" },
                {9, "Wiggles", "Squishyface" },
                {10, "Peanut", "Poptart" },
                {10, "Nugget", "Doodlebug" },
                {10, "Squiggles", "Gumdrop" },
                {11, "Biscuit", "Marshmallow" },
                {11, "Fluffy", "Popcorn" },
                {11, "Sprinkles", "Cheeseball" },
                {12, "Cinnamon", "Sugarplum" },
                {12, "Pickle", "Butterball" },
                {12, "Gummy", "Bearhug" },
                {13, "Butterscotch", "Cupcake" },
                {13, "Marshmallow", "Sprinkles" },
                {13, "Sugar", "Puffball" },
                {14, "Jelly", "Beanstalk" },
                {14, "Bubblegum", "Twinkletoes" },
                {14, "Snickers", "Doodlebug" },
                {15, "Cupcake", "Muffintop" },
                {15, "Buttercup", "Snoozletoes" },
                {15, "Snickerdoodle", "Giggles" },
                {16, "Sprinkle", "Sunshine" },
                {16, "Fluffernutter", "Peanut" },
                {16, "Cherry", "Cheesecake" },
                {17, "Cookie", "Doughboy" },
                {17, "Chocolate", "Chipmunk" },
                {17, "Sugarplum", "Fairy" },
                {18, "Tootsie", "Roll" },
                {18, "Fruitcake", "McGuffin" },
                {18, "Honey", "Bunny" },
                {19, "Caramel", "Apple" },
                {19, "Gingerbread", "Man" },
                {19, "Lollipop", "Rainbow" },
                {20, "Blueberry", "Pancake" },
                {20, "Pumpkin", "Pie" },
                {20, "Vanilla", "Bean" },
                {21, "Maple", "Syrup" },
                {21, "Taffy", "Twist" },
                {21, "Cotton", "Candy" },
                {22, "Rocky", "Road" },
                {22, "Peppermint", "Stick" },
                {22, "Hazelnut", "Dream" },
                {23, "Butter", "Pecan" },
                {23, "Almond", "Joy" },
                {23, "Fudge", "Ripple" },
                {24, "Pineapple", "Upside-down" },
                {24, "Coconut", "Cream" },
                {24, "Key", "Lime" },
                {25, "Chocolate", "Fudge" },
                {25, "Red", "Velvet" },
                {25, "Carrot", "Cake" },
                {26, "Strawberry", "Shortcake" },
                {26, "Blackberry", "Cobbler" },
                {26, "Raspberry", "Swirl" },
                {27, "Peach", "Melba" },
                {27, "Plum", "Pudding" },
                {27, "Banana", "Split" },
                {28, "Cherry", "Cobbler" },
                {28, "Apple", "Turnover" },
                {28, "Blueberry", "Crumble" },
                {29, "Pumpkin", "Roll" },
                {29, "Ginger", "Snap" },
                {29, "Cranberry", "Sauce" }
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

        for (int i = 1; i <= 99; i++)
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