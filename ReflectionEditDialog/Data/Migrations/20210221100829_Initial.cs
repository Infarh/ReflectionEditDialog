using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ReflectionEditDialog.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastName = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Patronymic = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DepartamentId = table.Column<int>(type: "int", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Отдел 1" },
                    { 9, "Отдел 9" },
                    { 8, "Отдел 8" },
                    { 7, "Отдел 7" },
                    { 6, "Отдел 6" },
                    { 10, "Отдел 10" },
                    { 4, "Отдел 4" },
                    { 3, "Отдел 3" },
                    { 2, "Отдел 2" },
                    { 5, "Отдел 5" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Birthday", "DepartamentId", "DepartmentId", "LastName", "Name", "Patronymic" },
                values: new object[,]
                {
                    { 64, new DateTime(1994, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6487), 5, null, "Фамилия 64", "Имя 64", "Отчество 64" },
                    { 72, new DateTime(1991, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6521), 6, null, "Фамилия 72", "Имя 72", "Отчество 72" },
                    { 71, new DateTime(2001, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6517), 10, null, "Фамилия 71", "Имя 71", "Отчество 71" },
                    { 70, new DateTime(1988, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6512), 1, null, "Фамилия 70", "Имя 70", "Отчество 70" },
                    { 69, new DateTime(2001, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6508), 9, null, "Фамилия 69", "Имя 69", "Отчество 69" },
                    { 68, new DateTime(1995, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6504), 2, null, "Фамилия 68", "Имя 68", "Отчество 68" },
                    { 67, new DateTime(1998, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6500), 7, null, "Фамилия 67", "Имя 67", "Отчество 67" },
                    { 66, new DateTime(1994, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6496), 6, null, "Фамилия 66", "Имя 66", "Отчество 66" },
                    { 65, new DateTime(1995, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6492), 4, null, "Фамилия 65", "Имя 65", "Отчество 65" },
                    { 63, new DateTime(1987, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6483), 1, null, "Фамилия 63", "Имя 63", "Отчество 63" },
                    { 58, new DateTime(1995, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6462), 8, null, "Фамилия 58", "Имя 58", "Отчество 58" },
                    { 61, new DateTime(2002, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6475), 3, null, "Фамилия 61", "Имя 61", "Отчество 61" },
                    { 60, new DateTime(1991, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6471), 7, null, "Фамилия 60", "Имя 60", "Отчество 60" },
                    { 59, new DateTime(1997, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6466), 6, null, "Фамилия 59", "Имя 59", "Отчество 59" },
                    { 73, new DateTime(2001, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6525), 1, null, "Фамилия 73", "Имя 73", "Отчество 73" },
                    { 57, new DateTime(1988, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6457), 8, null, "Фамилия 57", "Имя 57", "Отчество 57" },
                    { 56, new DateTime(1998, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6364), 10, null, "Фамилия 56", "Имя 56", "Отчество 56" },
                    { 55, new DateTime(1992, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6359), 5, null, "Фамилия 55", "Имя 55", "Отчество 55" },
                    { 54, new DateTime(1993, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6355), 10, null, "Фамилия 54", "Имя 54", "Отчество 54" },
                    { 53, new DateTime(1998, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6351), 6, null, "Фамилия 53", "Имя 53", "Отчество 53" },
                    { 52, new DateTime(1998, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6347), 6, null, "Фамилия 52", "Имя 52", "Отчество 52" },
                    { 62, new DateTime(1994, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6479), 1, null, "Фамилия 62", "Имя 62", "Отчество 62" },
                    { 74, new DateTime(1988, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6530), 9, null, "Фамилия 74", "Имя 74", "Отчество 74" },
                    { 79, new DateTime(2002, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6550), 4, null, "Фамилия 79", "Имя 79", "Отчество 79" },
                    { 76, new DateTime(1987, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6538), 6, null, "Фамилия 76", "Имя 76", "Отчество 76" },
                    { 98, new DateTime(2003, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6667), 10, null, "Фамилия 98", "Имя 98", "Отчество 98" },
                    { 97, new DateTime(1999, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6663), 7, null, "Фамилия 97", "Имя 97", "Отчество 97" },
                    { 96, new DateTime(2001, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6658), 9, null, "Фамилия 96", "Имя 96", "Отчество 96" },
                    { 95, new DateTime(2003, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6654), 6, null, "Фамилия 95", "Имя 95", "Отчество 95" },
                    { 94, new DateTime(1994, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6650), 4, null, "Фамилия 94", "Имя 94", "Отчество 94" },
                    { 93, new DateTime(1997, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6646), 10, null, "Фамилия 93", "Имя 93", "Отчество 93" },
                    { 92, new DateTime(2000, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6641), 4, null, "Фамилия 92", "Имя 92", "Отчество 92" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Birthday", "DepartamentId", "DepartmentId", "LastName", "Name", "Patronymic" },
                values: new object[,]
                {
                    { 91, new DateTime(2001, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6637), 8, null, "Фамилия 91", "Имя 91", "Отчество 91" },
                    { 90, new DateTime(1989, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6633), 10, null, "Фамилия 90", "Имя 90", "Отчество 90" },
                    { 89, new DateTime(1995, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6629), 1, null, "Фамилия 89", "Имя 89", "Отчество 89" },
                    { 75, new DateTime(2000, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6534), 3, null, "Фамилия 75", "Имя 75", "Отчество 75" },
                    { 88, new DateTime(1995, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6625), 1, null, "Фамилия 88", "Имя 88", "Отчество 88" },
                    { 86, new DateTime(1994, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6616), 6, null, "Фамилия 86", "Имя 86", "Отчество 86" },
                    { 85, new DateTime(1999, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6575), 4, null, "Фамилия 85", "Имя 85", "Отчество 85" },
                    { 84, new DateTime(1993, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6571), 4, null, "Фамилия 84", "Имя 84", "Отчество 84" },
                    { 83, new DateTime(1988, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6567), 8, null, "Фамилия 83", "Имя 83", "Отчество 83" },
                    { 82, new DateTime(1997, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6563), 4, null, "Фамилия 82", "Имя 82", "Отчество 82" },
                    { 81, new DateTime(2003, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6559), 2, null, "Фамилия 81", "Имя 81", "Отчество 81" },
                    { 80, new DateTime(1993, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6555), 3, null, "Фамилия 80", "Имя 80", "Отчество 80" },
                    { 51, new DateTime(2001, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6343), 7, null, "Фамилия 51", "Имя 51", "Отчество 51" },
                    { 78, new DateTime(1993, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6546), 10, null, "Фамилия 78", "Имя 78", "Отчество 78" },
                    { 77, new DateTime(2003, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6542), 1, null, "Фамилия 77", "Имя 77", "Отчество 77" },
                    { 87, new DateTime(1993, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6620), 7, null, "Фамилия 87", "Имя 87", "Отчество 87" },
                    { 50, new DateTime(1992, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6338), 7, null, "Фамилия 50", "Имя 50", "Отчество 50" },
                    { 45, new DateTime(2003, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6318), 5, null, "Фамилия 45", "Имя 45", "Отчество 45" },
                    { 48, new DateTime(1988, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6330), 4, null, "Фамилия 48", "Имя 48", "Отчество 48" },
                    { 21, new DateTime(2000, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6165), 9, null, "Фамилия 21", "Имя 21", "Отчество 21" },
                    { 20, new DateTime(2003, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6161), 2, null, "Фамилия 20", "Имя 20", "Отчество 20" },
                    { 19, new DateTime(2002, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6156), 10, null, "Фамилия 19", "Имя 19", "Отчество 19" },
                    { 18, new DateTime(2001, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6152), 1, null, "Фамилия 18", "Имя 18", "Отчество 18" },
                    { 17, new DateTime(1989, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6148), 1, null, "Фамилия 17", "Имя 17", "Отчество 17" },
                    { 16, new DateTime(1995, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6144), 3, null, "Фамилия 16", "Имя 16", "Отчество 16" },
                    { 15, new DateTime(1994, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6139), 3, null, "Фамилия 15", "Имя 15", "Отчество 15" },
                    { 14, new DateTime(1999, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6135), 1, null, "Фамилия 14", "Имя 14", "Отчество 14" },
                    { 13, new DateTime(1996, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6130), 10, null, "Фамилия 13", "Имя 13", "Отчество 13" },
                    { 12, new DateTime(2002, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6125), 10, null, "Фамилия 12", "Имя 12", "Отчество 12" },
                    { 11, new DateTime(1996, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6121), 5, null, "Фамилия 11", "Имя 11", "Отчество 11" },
                    { 10, new DateTime(1994, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6116), 10, null, "Фамилия 10", "Имя 10", "Отчество 10" },
                    { 9, new DateTime(2003, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6112), 2, null, "Фамилия 9", "Имя 9", "Отчество 9" },
                    { 8, new DateTime(2003, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6107), 1, null, "Фамилия 8", "Имя 8", "Отчество 8" },
                    { 7, new DateTime(1992, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6102), 7, null, "Фамилия 7", "Имя 7", "Отчество 7" },
                    { 6, new DateTime(1999, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6097), 5, null, "Фамилия 6", "Имя 6", "Отчество 6" },
                    { 5, new DateTime(1993, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6093), 10, null, "Фамилия 5", "Имя 5", "Отчество 5" },
                    { 4, new DateTime(1989, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6089), 4, null, "Фамилия 4", "Имя 4", "Отчество 4" },
                    { 3, new DateTime(1999, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6083), 5, null, "Фамилия 3", "Имя 3", "Отчество 3" },
                    { 2, new DateTime(2000, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6059), 9, null, "Фамилия 2", "Имя 2", "Отчество 2" },
                    { 1, new DateTime(2001, 2, 21, 13, 8, 28, 590, DateTimeKind.Local).AddTicks(5049), 1, null, "Фамилия 1", "Имя 1", "Отчество 1" },
                    { 22, new DateTime(2001, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6170), 1, null, "Фамилия 22", "Имя 22", "Отчество 22" },
                    { 23, new DateTime(1992, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6174), 9, null, "Фамилия 23", "Имя 23", "Отчество 23" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Birthday", "DepartamentId", "DepartmentId", "LastName", "Name", "Patronymic" },
                values: new object[,]
                {
                    { 24, new DateTime(2001, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6178), 9, null, "Фамилия 24", "Имя 24", "Отчество 24" },
                    { 25, new DateTime(1993, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6183), 4, null, "Фамилия 25", "Имя 25", "Отчество 25" },
                    { 47, new DateTime(1994, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6326), 7, null, "Фамилия 47", "Имя 47", "Отчество 47" },
                    { 46, new DateTime(2003, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6322), 9, null, "Фамилия 46", "Имя 46", "Отчество 46" },
                    { 99, new DateTime(1994, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6671), 4, null, "Фамилия 99", "Имя 99", "Отчество 99" },
                    { 44, new DateTime(1988, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6314), 5, null, "Фамилия 44", "Имя 44", "Отчество 44" },
                    { 43, new DateTime(1993, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6309), 8, null, "Фамилия 43", "Имя 43", "Отчество 43" },
                    { 42, new DateTime(1996, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6305), 3, null, "Фамилия 42", "Имя 42", "Отчество 42" },
                    { 41, new DateTime(1990, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6301), 5, null, "Фамилия 41", "Имя 41", "Отчество 41" },
                    { 40, new DateTime(1998, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6296), 7, null, "Фамилия 40", "Имя 40", "Отчество 40" },
                    { 39, new DateTime(1997, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6292), 1, null, "Фамилия 39", "Имя 39", "Отчество 39" },
                    { 38, new DateTime(1991, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6288), 7, null, "Фамилия 38", "Имя 38", "Отчество 38" },
                    { 49, new DateTime(2002, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6335), 8, null, "Фамилия 49", "Имя 49", "Отчество 49" },
                    { 37, new DateTime(2001, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6284), 5, null, "Фамилия 37", "Имя 37", "Отчество 37" },
                    { 35, new DateTime(1995, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6275), 1, null, "Фамилия 35", "Имя 35", "Отчество 35" },
                    { 34, new DateTime(1993, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6271), 6, null, "Фамилия 34", "Имя 34", "Отчество 34" },
                    { 33, new DateTime(1997, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6267), 10, null, "Фамилия 33", "Имя 33", "Отчество 33" },
                    { 32, new DateTime(1990, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6262), 4, null, "Фамилия 32", "Имя 32", "Отчество 32" },
                    { 31, new DateTime(2000, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6258), 9, null, "Фамилия 31", "Имя 31", "Отчество 31" },
                    { 30, new DateTime(1997, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6254), 4, null, "Фамилия 30", "Имя 30", "Отчество 30" },
                    { 29, new DateTime(1987, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6249), 3, null, "Фамилия 29", "Имя 29", "Отчество 29" },
                    { 28, new DateTime(2002, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6245), 7, null, "Фамилия 28", "Имя 28", "Отчество 28" },
                    { 27, new DateTime(1997, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6191), 5, null, "Фамилия 27", "Имя 27", "Отчество 27" },
                    { 26, new DateTime(1992, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6187), 8, null, "Фамилия 26", "Имя 26", "Отчество 26" },
                    { 36, new DateTime(1987, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6280), 2, null, "Фамилия 36", "Имя 36", "Отчество 36" },
                    { 100, new DateTime(1993, 2, 21, 13, 8, 28, 591, DateTimeKind.Local).AddTicks(6676), 5, null, "Фамилия 100", "Имя 100", "Отчество 100" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Departments_Name",
                table: "Departments",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentId",
                table: "Employees",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_Name_LastName_Patronymic_Birthday",
                table: "Employees",
                columns: new[] { "Name", "LastName", "Patronymic", "Birthday" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
