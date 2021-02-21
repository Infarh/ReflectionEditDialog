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
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
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
                    { 2, "Отдел 2" },
                    { 3, "Отдел 3" },
                    { 4, "Отдел 4" },
                    { 5, "Отдел 5" },
                    { 6, "Отдел 6" },
                    { 7, "Отдел 7" },
                    { 8, "Отдел 8" },
                    { 9, "Отдел 9" },
                    { 10, "Отдел 10" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Birthday", "DepartmentId", "LastName", "Name", "Patronymic" },
                values: new object[,]
                {
                    { 13, new DateTime(1996, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(7005), 1, "Фамилия 13", "Имя 13", "Отчество 13" },
                    { 9, new DateTime(1994, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(6988), 8, "Фамилия 9", "Имя 9", "Отчество 9" },
                    { 3, new DateTime(2003, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(6958), 8, "Фамилия 3", "Имя 3", "Отчество 3" },
                    { 96, new DateTime(1989, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(7464), 7, "Фамилия 96", "Имя 96", "Отчество 96" },
                    { 80, new DateTime(2002, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(7363), 7, "Фамилия 80", "Имя 80", "Отчество 80" },
                    { 75, new DateTime(2003, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(7343), 7, "Фамилия 75", "Имя 75", "Отчество 75" },
                    { 70, new DateTime(1990, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(7321), 7, "Фамилия 70", "Имя 70", "Отчество 70" },
                    { 54, new DateTime(1995, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(7219), 7, "Фамилия 54", "Имя 54", "Отчество 54" },
                    { 52, new DateTime(1991, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(7211), 7, "Фамилия 52", "Имя 52", "Отчество 52" },
                    { 46, new DateTime(1998, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(7186), 7, "Фамилия 46", "Имя 46", "Отчество 46" },
                    { 43, new DateTime(1988, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(7173), 7, "Фамилия 43", "Имя 43", "Отчество 43" },
                    { 26, new DateTime(1992, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(7062), 7, "Фамилия 26", "Имя 26", "Отчество 26" },
                    { 21, new DateTime(2000, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(7040), 7, "Фамилия 21", "Имя 21", "Отчество 21" },
                    { 15, new DateTime(2000, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(7014), 7, "Фамилия 15", "Имя 15", "Отчество 15" },
                    { 12, new DateTime(1988, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(7001), 7, "Фамилия 12", "Имя 12", "Отчество 12" },
                    { 11, new DateTime(1996, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(6997), 7, "Фамилия 11", "Имя 11", "Отчество 11" },
                    { 1, new DateTime(2003, 2, 21, 13, 35, 43, 0, DateTimeKind.Local).AddTicks(6165), 7, "Фамилия 1", "Имя 1", "Отчество 1" },
                    { 95, new DateTime(2001, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(7460), 6, "Фамилия 95", "Имя 95", "Отчество 95" },
                    { 90, new DateTime(1999, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(7440), 6, "Фамилия 90", "Имя 90", "Отчество 90" },
                    { 87, new DateTime(1988, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(7393), 6, "Фамилия 87", "Имя 87", "Отчество 87" },
                    { 84, new DateTime(2003, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(7380), 6, "Фамилия 84", "Имя 84", "Отчество 84" },
                    { 22, new DateTime(1995, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(7044), 6, "Фамилия 22", "Имя 22", "Отчество 22" },
                    { 20, new DateTime(1992, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(7036), 8, "Фамилия 20", "Имя 20", "Отчество 20" },
                    { 88, new DateTime(1991, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(7397), 5, "Фамилия 88", "Имя 88", "Отчество 88" },
                    { 31, new DateTime(2001, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(7121), 8, "Фамилия 31", "Имя 31", "Отчество 31" },
                    { 47, new DateTime(2001, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(7190), 8, "Фамилия 47", "Имя 47", "Отчество 47" },
                    { 67, new DateTime(1998, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(7309), 10, "Фамилия 67", "Имя 67", "Отчество 67" },
                    { 60, new DateTime(2001, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(7244), 10, "Фамилия 60", "Имя 60", "Отчество 60" },
                    { 58, new DateTime(1991, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(7236), 10, "Фамилия 58", "Имя 58", "Отчество 58" },
                    { 42, new DateTime(1995, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(7169), 10, "Фамилия 42", "Имя 42", "Отчество 42" },
                    { 30, new DateTime(2003, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(7079), 10, "Фамилия 30", "Имя 30", "Отчество 30" },
                    { 79, new DateTime(1995, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(7359), 9, "Фамилия 79", "Имя 79", "Отчество 79" },
                    { 69, new DateTime(1995, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(7317), 9, "Фамилия 69", "Имя 69", "Отчество 69" },
                    { 66, new DateTime(1992, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(7305), 9, "Фамилия 66", "Имя 66", "Отчество 66" },
                    { 62, new DateTime(1999, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(7288), 9, "Фамилия 62", "Имя 62", "Отчество 62" },
                    { 61, new DateTime(1988, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(7284), 9, "Фамилия 61", "Имя 61", "Отчество 61" },
                    { 57, new DateTime(1994, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(7232), 9, "Фамилия 57", "Имя 57", "Отчество 57" },
                    { 51, new DateTime(1999, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(7207), 9, "Фамилия 51", "Имя 51", "Отчество 51" },
                    { 45, new DateTime(1990, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(7182), 9, "Фамилия 45", "Имя 45", "Отчество 45" },
                    { 35, new DateTime(1992, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(7140), 9, "Фамилия 35", "Имя 35", "Отчество 35" },
                    { 7, new DateTime(1997, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(6979), 9, "Фамилия 7", "Имя 7", "Отчество 7" },
                    { 5, new DateTime(1992, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(6970), 9, "Фамилия 5", "Имя 5", "Отчество 5" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Birthday", "DepartmentId", "LastName", "Name", "Patronymic" },
                values: new object[,]
                {
                    { 4, new DateTime(1990, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(6965), 9, "Фамилия 4", "Имя 4", "Отчество 4" },
                    { 65, new DateTime(1992, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(7301), 8, "Фамилия 65", "Имя 65", "Отчество 65" },
                    { 59, new DateTime(1999, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(7240), 8, "Фамилия 59", "Имя 59", "Отчество 59" },
                    { 55, new DateTime(1988, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(7223), 8, "Фамилия 55", "Имя 55", "Отчество 55" },
                    { 50, new DateTime(1987, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(7203), 8, "Фамилия 50", "Имя 50", "Отчество 50" },
                    { 38, new DateTime(2000, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(7152), 8, "Фамилия 38", "Имя 38", "Отчество 38" },
                    { 78, new DateTime(1989, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(7355), 5, "Фамилия 78", "Имя 78", "Отчество 78" },
                    { 71, new DateTime(2000, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(7326), 5, "Фамилия 71", "Имя 71", "Отчество 71" },
                    { 68, new DateTime(1987, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(7313), 5, "Фамилия 68", "Имя 68", "Отчество 68" },
                    { 17, new DateTime(1999, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(7023), 3, "Фамилия 17", "Имя 17", "Отчество 17" },
                    { 6, new DateTime(1999, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(6974), 3, "Фамилия 6", "Имя 6", "Отчество 6" },
                    { 97, new DateTime(1990, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(7469), 2, "Фамилия 97", "Имя 97", "Отчество 97" },
                    { 82, new DateTime(2003, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(7372), 2, "Фамилия 82", "Имя 82", "Отчество 82" },
                    { 81, new DateTime(2002, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(7367), 2, "Фамилия 81", "Имя 81", "Отчество 81" },
                    { 44, new DateTime(2000, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(7177), 2, "Фамилия 44", "Имя 44", "Отчество 44" },
                    { 40, new DateTime(1991, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(7161), 2, "Фамилия 40", "Имя 40", "Отчество 40" },
                    { 19, new DateTime(1987, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(7031), 2, "Фамилия 19", "Имя 19", "Отчество 19" },
                    { 16, new DateTime(1998, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(7018), 2, "Фамилия 16", "Имя 16", "Отчество 16" },
                    { 8, new DateTime(1989, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(6983), 2, "Фамилия 8", "Имя 8", "Отчество 8" },
                    { 99, new DateTime(1996, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(7477), 1, "Фамилия 99", "Имя 99", "Отчество 99" },
                    { 98, new DateTime(1994, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(7473), 1, "Фамилия 98", "Имя 98", "Отчество 98" },
                    { 92, new DateTime(1997, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(7448), 1, "Фамилия 92", "Имя 92", "Отчество 92" },
                    { 77, new DateTime(1999, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(7351), 1, "Фамилия 77", "Имя 77", "Отчество 77" },
                    { 72, new DateTime(1999, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(7330), 1, "Фамилия 72", "Имя 72", "Отчество 72" },
                    { 34, new DateTime(1987, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(7135), 1, "Фамилия 34", "Имя 34", "Отчество 34" },
                    { 33, new DateTime(1993, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(7131), 1, "Фамилия 33", "Имя 33", "Отчество 33" },
                    { 32, new DateTime(1993, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(7127), 1, "Фамилия 32", "Имя 32", "Отчество 32" },
                    { 27, new DateTime(1987, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(7066), 1, "Фамилия 27", "Имя 27", "Отчество 27" },
                    { 18, new DateTime(2000, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(7027), 1, "Фамилия 18", "Имя 18", "Отчество 18" },
                    { 14, new DateTime(1993, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(7010), 1, "Фамилия 14", "Имя 14", "Отчество 14" },
                    { 23, new DateTime(1989, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(7049), 3, "Фамилия 23", "Имя 23", "Отчество 23" },
                    { 25, new DateTime(1995, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(7058), 3, "Фамилия 25", "Имя 25", "Отчество 25" },
                    { 37, new DateTime(2002, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(7148), 3, "Фамилия 37", "Имя 37", "Отчество 37" },
                    { 41, new DateTime(2000, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(7165), 3, "Фамилия 41", "Имя 41", "Отчество 41" },
                    { 63, new DateTime(1994, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(7293), 5, "Фамилия 63", "Имя 63", "Отчество 63" },
                    { 48, new DateTime(1994, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(7195), 5, "Фамилия 48", "Имя 48", "Отчество 48" },
                    { 24, new DateTime(1988, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(7053), 5, "Фамилия 24", "Имя 24", "Отчество 24" },
                    { 2, new DateTime(1988, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(6932), 5, "Фамилия 2", "Имя 2", "Отчество 2" },
                    { 93, new DateTime(1994, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(7452), 4, "Фамилия 93", "Имя 93", "Отчество 93" },
                    { 86, new DateTime(1996, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(7389), 4, "Фамилия 86", "Имя 86", "Отчество 86" },
                    { 85, new DateTime(1988, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(7384), 4, "Фамилия 85", "Имя 85", "Отчество 85" },
                    { 83, new DateTime(2003, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(7376), 4, "Фамилия 83", "Имя 83", "Отчество 83" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Birthday", "DepartmentId", "LastName", "Name", "Patronymic" },
                values: new object[,]
                {
                    { 76, new DateTime(2000, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(7347), 4, "Фамилия 76", "Имя 76", "Отчество 76" },
                    { 74, new DateTime(2001, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(7339), 4, "Фамилия 74", "Имя 74", "Отчество 74" },
                    { 73, new DateTime(1993, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(7334), 10, "Фамилия 73", "Имя 73", "Отчество 73" },
                    { 64, new DateTime(1999, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(7297), 4, "Фамилия 64", "Имя 64", "Отчество 64" },
                    { 53, new DateTime(2001, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(7215), 4, "Фамилия 53", "Имя 53", "Отчество 53" },
                    { 49, new DateTime(2003, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(7199), 4, "Фамилия 49", "Имя 49", "Отчество 49" },
                    { 39, new DateTime(2000, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(7156), 4, "Фамилия 39", "Имя 39", "Отчество 39" },
                    { 36, new DateTime(2001, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(7144), 4, "Фамилия 36", "Имя 36", "Отчество 36" },
                    { 29, new DateTime(1992, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(7075), 4, "Фамилия 29", "Имя 29", "Отчество 29" },
                    { 28, new DateTime(1995, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(7070), 4, "Фамилия 28", "Имя 28", "Отчество 28" },
                    { 10, new DateTime(1987, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(6992), 4, "Фамилия 10", "Имя 10", "Отчество 10" },
                    { 100, new DateTime(2003, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(7482), 3, "Фамилия 100", "Имя 100", "Отчество 100" },
                    { 94, new DateTime(1994, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(7456), 3, "Фамилия 94", "Имя 94", "Отчество 94" },
                    { 89, new DateTime(1993, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(7401), 3, "Фамилия 89", "Имя 89", "Отчество 89" },
                    { 56, new DateTime(2000, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(7227), 4, "Фамилия 56", "Имя 56", "Отчество 56" },
                    { 91, new DateTime(1998, 2, 21, 13, 35, 43, 1, DateTimeKind.Local).AddTicks(7444), 10, "Фамилия 91", "Имя 91", "Отчество 91" }
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
