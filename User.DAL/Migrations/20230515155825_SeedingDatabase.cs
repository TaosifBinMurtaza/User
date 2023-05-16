using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace User.DAL.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Author", "CategoryId", "CompanyId", "Description", "ISBN", "ImageUrl", "ListPrice", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN1", "\\images\\products\\Book.png", 84.189999999999998, 400.12, "BookTitle1" },
                    { 2, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN2", "\\images\\products\\Book.png", 28.039999999999999, 233.44, "BookTitle2" },
                    { 3, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN3", "\\images\\products\\Book.png", 10.57, 234.75, "BookTitle3" },
                    { 4, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN4", "\\images\\products\\Book.png", 52.960000000000001, 251.75, "BookTitle4" },
                    { 5, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN5", "\\images\\products\\Book.png", 33.32, 449.39999999999998, "BookTitle5" },
                    { 6, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN6", "\\images\\products\\Book.png", 149.19, 421.43000000000001, "BookTitle6" },
                    { 7, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN7", "\\images\\products\\Book.png", 71.540000000000006, 395.69, "BookTitle7" },
                    { 8, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN8", "\\images\\products\\Book.png", 20.59, 275.26999999999998, "BookTitle8" },
                    { 9, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN9", "\\images\\products\\Book.png", 41.789999999999999, 224.06, "BookTitle9" },
                    { 10, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN10", "\\images\\products\\Book.png", 40.990000000000002, 150.05000000000001, "BookTitle10" },
                    { 11, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN11", "\\images\\products\\Book.png", 85.519999999999996, 281.04000000000002, "BookTitle11" },
                    { 12, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN12", "\\images\\products\\Book.png", 80.260000000000005, 231.59999999999999, "BookTitle12" },
                    { 13, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN13", "\\images\\products\\Book.png", 139.43000000000001, 426.54000000000002, "BookTitle13" },
                    { 14, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN14", "\\images\\products\\Book.png", 109.23999999999999, 251.18000000000001, "BookTitle14" },
                    { 15, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN15", "\\images\\products\\Book.png", 22.199999999999999, 434.38999999999999, "BookTitle15" },
                    { 16, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN16", "\\images\\products\\Book.png", 141.46000000000001, 423.32999999999998, "BookTitle16" },
                    { 17, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN17", "\\images\\products\\Book.png", 134.31, 203.41, "BookTitle17" },
                    { 18, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN18", "\\images\\products\\Book.png", 35.899999999999999, 223.18000000000001, "BookTitle18" },
                    { 19, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN19", "\\images\\products\\Book.png", 52.990000000000002, 494.82999999999998, "BookTitle19" },
                    { 20, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN20", "\\images\\products\\Book.png", 114.44, 440.13999999999999, "BookTitle20" },
                    { 21, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN21", "\\images\\products\\Book.png", 132.83000000000001, 491.69, "BookTitle21" },
                    { 22, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN22", "\\images\\products\\Book.png", 24.359999999999999, 325.68000000000001, "BookTitle22" },
                    { 23, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN23", "\\images\\products\\Book.png", 45.030000000000001, 163.69, "BookTitle23" },
                    { 24, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN24", "\\images\\products\\Book.png", 11.84, 348.45999999999998, "BookTitle24" },
                    { 25, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN25", "\\images\\products\\Book.png", 120.45, 371.33999999999997, "BookTitle25" },
                    { 26, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN26", "\\images\\products\\Book.png", 79.849999999999994, 272.17000000000002, "BookTitle26" },
                    { 27, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN27", "\\images\\products\\Book.png", 82.659999999999997, 345.87, "BookTitle27" },
                    { 28, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN28", "\\images\\products\\Book.png", 103.41, 476.10000000000002, "BookTitle28" },
                    { 29, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN29", "\\images\\products\\Book.png", 108.98, 152.72, "BookTitle29" },
                    { 30, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN30", "\\images\\products\\Book.png", 83.219999999999999, 221.13, "BookTitle30" },
                    { 31, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN31", "\\images\\products\\Book.png", 143.78, 221.0, "BookTitle31" },
                    { 32, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN32", "\\images\\products\\Book.png", 38.990000000000002, 366.72000000000003, "BookTitle32" },
                    { 33, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN33", "\\images\\products\\Book.png", 122.75, 418.91000000000003, "BookTitle33" },
                    { 34, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN34", "\\images\\products\\Book.png", 20.739999999999998, 151.25, "BookTitle34" },
                    { 35, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN35", "\\images\\products\\Book.png", 99.019999999999996, 374.36000000000001, "BookTitle35" },
                    { 36, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN36", "\\images\\products\\Book.png", 114.28, 481.06, "BookTitle36" },
                    { 37, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN37", "\\images\\products\\Book.png", 111.37, 437.81999999999999, "BookTitle37" },
                    { 38, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN38", "\\images\\products\\Book.png", 16.57, 218.38, "BookTitle38" },
                    { 39, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN39", "\\images\\products\\Book.png", 35.93, 388.29000000000002, "BookTitle39" },
                    { 40, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN40", "\\images\\products\\Book.png", 144.47999999999999, 420.11000000000001, "BookTitle40" },
                    { 41, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN41", "\\images\\products\\Book.png", 51.450000000000003, 157.06, "BookTitle41" },
                    { 42, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN42", "\\images\\products\\Book.png", 77.189999999999998, 188.43000000000001, "BookTitle42" },
                    { 43, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN43", "\\images\\products\\Book.png", 128.49000000000001, 278.39999999999998, "BookTitle43" },
                    { 44, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN44", "\\images\\products\\Book.png", 10.449999999999999, 213.21000000000001, "BookTitle44" },
                    { 45, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN45", "\\images\\products\\Book.png", 58.140000000000001, 388.87, "BookTitle45" },
                    { 46, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN46", "\\images\\products\\Book.png", 100.88, 207.90000000000001, "BookTitle46" },
                    { 47, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN47", "\\images\\products\\Book.png", 114.06999999999999, 196.61000000000001, "BookTitle47" },
                    { 48, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN48", "\\images\\products\\Book.png", 19.789999999999999, 414.61000000000001, "BookTitle48" },
                    { 49, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN49", "\\images\\products\\Book.png", 131.25, 391.10000000000002, "BookTitle49" },
                    { 50, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN50", "\\images\\products\\Book.png", 56.280000000000001, 229.78999999999999, "BookTitle50" },
                    { 51, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN51", "\\images\\products\\Book.png", 71.829999999999998, 366.80000000000001, "BookTitle51" },
                    { 52, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN52", "\\images\\products\\Book.png", 143.43000000000001, 181.09999999999999, "BookTitle52" },
                    { 53, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN53", "\\images\\products\\Book.png", 34.939999999999998, 390.37, "BookTitle53" },
                    { 54, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN54", "\\images\\products\\Book.png", 108.08, 297.87, "BookTitle54" },
                    { 55, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN55", "\\images\\products\\Book.png", 12.300000000000001, 222.38999999999999, "BookTitle55" },
                    { 56, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN56", "\\images\\products\\Book.png", 83.579999999999998, 245.28, "BookTitle56" },
                    { 57, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN57", "\\images\\products\\Book.png", 20.370000000000001, 274.42000000000002, "BookTitle57" },
                    { 58, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN58", "\\images\\products\\Book.png", 25.579999999999998, 390.19, "BookTitle58" },
                    { 59, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN59", "\\images\\products\\Book.png", 35.420000000000002, 259.98000000000002, "BookTitle59" },
                    { 60, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN60", "\\images\\products\\Book.png", 123.48999999999999, 249.36000000000001, "BookTitle60" },
                    { 61, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN61", "\\images\\products\\Book.png", 112.7, 299.24000000000001, "BookTitle61" },
                    { 62, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN62", "\\images\\products\\Book.png", 48.530000000000001, 261.16000000000003, "BookTitle62" },
                    { 63, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN63", "\\images\\products\\Book.png", 52.240000000000002, 319.45999999999998, "BookTitle63" },
                    { 64, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN64", "\\images\\products\\Book.png", 125.16, 394.94, "BookTitle64" },
                    { 65, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN65", "\\images\\products\\Book.png", 11.550000000000001, 392.97000000000003, "BookTitle65" },
                    { 66, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN66", "\\images\\products\\Book.png", 140.87, 459.27999999999997, "BookTitle66" },
                    { 67, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN67", "\\images\\products\\Book.png", 148.13, 343.86000000000001, "BookTitle67" },
                    { 68, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN68", "\\images\\products\\Book.png", 74.0, 443.41000000000003, "BookTitle68" },
                    { 69, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN69", "\\images\\products\\Book.png", 121.38, 393.70999999999998, "BookTitle69" },
                    { 70, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN70", "\\images\\products\\Book.png", 84.930000000000007, 364.64999999999998, "BookTitle70" },
                    { 71, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN71", "\\images\\products\\Book.png", 98.989999999999995, 331.63, "BookTitle71" },
                    { 72, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN72", "\\images\\products\\Book.png", 42.920000000000002, 423.43000000000001, "BookTitle72" },
                    { 73, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN73", "\\images\\products\\Book.png", 34.579999999999998, 313.12, "BookTitle73" },
                    { 74, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN74", "\\images\\products\\Book.png", 47.810000000000002, 492.29000000000002, "BookTitle74" },
                    { 75, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN75", "\\images\\products\\Book.png", 116.43000000000001, 495.93000000000001, "BookTitle75" },
                    { 76, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN76", "\\images\\products\\Book.png", 97.599999999999994, 189.50999999999999, "BookTitle76" },
                    { 77, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN77", "\\images\\products\\Book.png", 133.52000000000001, 479.56999999999999, "BookTitle77" },
                    { 78, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN78", "\\images\\products\\Book.png", 106.84999999999999, 414.22000000000003, "BookTitle78" },
                    { 79, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN79", "\\images\\products\\Book.png", 75.540000000000006, 326.63, "BookTitle79" },
                    { 80, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN80", "\\images\\products\\Book.png", 25.0, 280.97000000000003, "BookTitle80" },
                    { 81, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN81", "\\images\\products\\Book.png", 34.979999999999997, 296.60000000000002, "BookTitle81" },
                    { 82, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN82", "\\images\\products\\Book.png", 59.710000000000001, 259.79000000000002, "BookTitle82" },
                    { 83, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN83", "\\images\\products\\Book.png", 19.649999999999999, 298.56999999999999, "BookTitle83" },
                    { 84, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN84", "\\images\\products\\Book.png", 25.23, 499.68000000000001, "BookTitle84" },
                    { 85, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN85", "\\images\\products\\Book.png", 132.68000000000001, 395.36000000000001, "BookTitle85" },
                    { 86, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN86", "\\images\\products\\Book.png", 126.91, 355.19999999999999, "BookTitle86" },
                    { 87, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN87", "\\images\\products\\Book.png", 149.97999999999999, 430.99000000000001, "BookTitle87" },
                    { 88, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN88", "\\images\\products\\Book.png", 50.210000000000001, 151.16, "BookTitle88" },
                    { 89, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN89", "\\images\\products\\Book.png", 41.770000000000003, 396.47000000000003, "BookTitle89" },
                    { 90, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN90", "\\images\\products\\Book.png", 139.94, 274.37, "BookTitle90" },
                    { 91, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN91", "\\images\\products\\Book.png", 93.439999999999998, 237.25999999999999, "BookTitle91" },
                    { 92, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN92", "\\images\\products\\Book.png", 52.130000000000003, 159.53, "BookTitle92" },
                    { 93, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN93", "\\images\\products\\Book.png", 136.58000000000001, 393.58999999999997, "BookTitle93" },
                    { 94, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN94", "\\images\\products\\Book.png", 111.20999999999999, 297.56999999999999, "BookTitle94" },
                    { 95, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN95", "\\images\\products\\Book.png", 149.81999999999999, 387.45999999999998, "BookTitle95" },
                    { 96, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN96", "\\images\\products\\Book.png", 100.08, 203.13, "BookTitle96" },
                    { 97, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN97", "\\images\\products\\Book.png", 69.329999999999998, 456.38999999999999, "BookTitle97" },
                    { 98, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN98", "\\images\\products\\Book.png", 96.730000000000004, 287.75, "BookTitle98" },
                    { 99, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN99", "\\images\\products\\Book.png", 128.52000000000001, 253.65000000000001, "BookTitle99" },
                    { 100, "Name1", 1, 1, "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.", "ISBN100", "\\images\\products\\Book.png", 108.25, 295.02999999999997, "BookTitle100" }
                });
        }

        /// <inheritdoc />
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

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100);
        }
    }
}
