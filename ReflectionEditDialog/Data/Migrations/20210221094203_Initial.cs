using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ReflectionEditDialog.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departaments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departaments", x => x.Id);
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
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Departaments_DepartamentId",
                        column: x => x.DepartamentId,
                        principalTable: "Departaments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Departaments",
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
                columns: new[] { "Id", "Birthday", "DepartamentId", "LastName", "Name", "Patronymic" },
                values: new object[,]
                {
                    { 15, new DateTime(1994, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(8830), 1, "Фамилия 15", "Имя 15", "Отчество 15" },
                    { 37, new DateTime(1997, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(8978), 8, "Фамилия 37", "Имя 37", "Отчество 37" },
                    { 4, new DateTime(1990, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(8781), 8, "Фамилия 4", "Имя 4", "Отчество 4" },
                    { 99, new DateTime(2001, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(9312), 7, "Фамилия 99", "Имя 99", "Отчество 99" },
                    { 89, new DateTime(1994, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(9270), 7, "Фамилия 89", "Имя 89", "Отчество 89" },
                    { 88, new DateTime(1999, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(9266), 7, "Фамилия 88", "Имя 88", "Отчество 88" },
                    { 86, new DateTime(2000, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(9257), 7, "Фамилия 86", "Имя 86", "Отчество 86" },
                    { 66, new DateTime(1998, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(9137), 7, "Фамилия 66", "Имя 66", "Отчество 66" },
                    { 49, new DateTime(1989, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(9029), 7, "Фамилия 49", "Имя 49", "Отчество 49" },
                    { 31, new DateTime(1990, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(8953), 7, "Фамилия 31", "Имя 31", "Отчество 31" },
                    { 27, new DateTime(1992, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(8937), 7, "Фамилия 27", "Имя 27", "Отчество 27" },
                    { 24, new DateTime(1994, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(8869), 7, "Фамилия 24", "Имя 24", "Отчество 24" },
                    { 12, new DateTime(1997, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(8818), 7, "Фамилия 12", "Имя 12", "Отчество 12" },
                    { 3, new DateTime(1991, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(8772), 7, "Фамилия 3", "Имя 3", "Отчество 3" },
                    { 100, new DateTime(1987, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(9317), 6, "Фамилия 100", "Имя 100", "Отчество 100" },
                    { 96, new DateTime(1992, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(9299), 6, "Фамилия 96", "Имя 96", "Отчество 96" },
                    { 85, new DateTime(1989, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(9253), 6, "Фамилия 85", "Имя 85", "Отчество 85" },
                    { 59, new DateTime(1994, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(9108), 6, "Фамилия 59", "Имя 59", "Отчество 59" },
                    { 58, new DateTime(1992, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(9103), 6, "Фамилия 58", "Имя 58", "Отчество 58" },
                    { 55, new DateTime(1990, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(9091), 6, "Фамилия 55", "Имя 55", "Отчество 55" },
                    { 47, new DateTime(1998, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(9020), 6, "Фамилия 47", "Имя 47", "Отчество 47" },
                    { 43, new DateTime(1995, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(9003), 6, "Фамилия 43", "Имя 43", "Отчество 43" },
                    { 46, new DateTime(1992, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(9016), 8, "Фамилия 46", "Имя 46", "Отчество 46" },
                    { 42, new DateTime(2002, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(8999), 6, "Фамилия 42", "Имя 42", "Отчество 42" },
                    { 60, new DateTime(2003, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(9112), 8, "Фамилия 60", "Имя 60", "Отчество 60" },
                    { 71, new DateTime(1996, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(9158), 8, "Фамилия 71", "Имя 71", "Отчество 71" },
                    { 87, new DateTime(2001, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(9262), 10, "Фамилия 87", "Имя 87", "Отчество 87" },
                    { 75, new DateTime(1988, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(9175), 10, "Фамилия 75", "Имя 75", "Отчество 75" },
                    { 69, new DateTime(1998, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(9149), 10, "Фамилия 69", "Имя 69", "Отчество 69" },
                    { 63, new DateTime(1998, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(9124), 10, "Фамилия 63", "Имя 63", "Отчество 63" },
                    { 50, new DateTime(1988, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(9033), 10, "Фамилия 50", "Имя 50", "Отчество 50" },
                    { 35, new DateTime(1993, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(8970), 10, "Фамилия 35", "Имя 35", "Отчество 35" },
                    { 33, new DateTime(1999, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(8962), 10, "Фамилия 33", "Имя 33", "Отчество 33" },
                    { 30, new DateTime(1993, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(8949), 10, "Фамилия 30", "Имя 30", "Отчество 30" },
                    { 29, new DateTime(1995, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(8945), 10, "Фамилия 29", "Имя 29", "Отчество 29" },
                    { 25, new DateTime(2002, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(8873), 10, "Фамилия 25", "Имя 25", "Отчество 25" },
                    { 19, new DateTime(1992, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(8847), 10, "Фамилия 19", "Имя 19", "Отчество 19" },
                    { 1, new DateTime(1992, 2, 21, 12, 42, 2, 740, DateTimeKind.Local).AddTicks(4457), 10, "Фамилия 1", "Имя 1", "Отчество 1" },
                    { 74, new DateTime(1993, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(9171), 9, "Фамилия 74", "Имя 74", "Отчество 74" },
                    { 67, new DateTime(1999, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(9141), 9, "Фамилия 67", "Имя 67", "Отчество 67" },
                    { 54, new DateTime(2001, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(9050), 9, "Фамилия 54", "Имя 54", "Отчество 54" },
                    { 48, new DateTime(1996, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(9024), 9, "Фамилия 48", "Имя 48", "Отчество 48" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Birthday", "DepartamentId", "LastName", "Name", "Patronymic" },
                values: new object[,]
                {
                    { 23, new DateTime(1988, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(8864), 9, "Фамилия 23", "Имя 23", "Отчество 23" },
                    { 13, new DateTime(1987, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(8822), 9, "Фамилия 13", "Имя 13", "Отчество 13" },
                    { 9, new DateTime(2002, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(8804), 9, "Фамилия 9", "Имя 9", "Отчество 9" },
                    { 82, new DateTime(1994, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(9204), 8, "Фамилия 82", "Имя 82", "Отчество 82" },
                    { 79, new DateTime(1997, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(9192), 8, "Фамилия 79", "Имя 79", "Отчество 79" },
                    { 64, new DateTime(1989, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(9128), 8, "Фамилия 64", "Имя 64", "Отчество 64" },
                    { 32, new DateTime(2001, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(8957), 6, "Фамилия 32", "Имя 32", "Отчество 32" },
                    { 11, new DateTime(1999, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(8813), 6, "Фамилия 11", "Имя 11", "Отчество 11" },
                    { 2, new DateTime(1993, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(8737), 6, "Фамилия 2", "Имя 2", "Отчество 2" },
                    { 98, new DateTime(1995, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(9307), 2, "Фамилия 98", "Имя 98", "Отчество 98" },
                    { 97, new DateTime(2000, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(9303), 2, "Фамилия 97", "Имя 97", "Отчество 97" },
                    { 95, new DateTime(1998, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(9295), 2, "Фамилия 95", "Имя 95", "Отчество 95" },
                    { 72, new DateTime(1995, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(9162), 2, "Фамилия 72", "Имя 72", "Отчество 72" },
                    { 52, new DateTime(1987, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(9041), 2, "Фамилия 52", "Имя 52", "Отчество 52" },
                    { 51, new DateTime(1994, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(9037), 2, "Фамилия 51", "Имя 51", "Отчество 51" },
                    { 40, new DateTime(1990, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(8991), 2, "Фамилия 40", "Имя 40", "Отчество 40" },
                    { 39, new DateTime(1998, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(8986), 2, "Фамилия 39", "Имя 39", "Отчество 39" },
                    { 36, new DateTime(1990, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(8974), 2, "Фамилия 36", "Имя 36", "Отчество 36" },
                    { 18, new DateTime(1996, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(8843), 2, "Фамилия 18", "Имя 18", "Отчество 18" },
                    { 14, new DateTime(1989, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(8826), 2, "Фамилия 14", "Имя 14", "Отчество 14" },
                    { 7, new DateTime(1990, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(8796), 2, "Фамилия 7", "Имя 7", "Отчество 7" },
                    { 94, new DateTime(1987, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(9291), 1, "Фамилия 94", "Имя 94", "Отчество 94" },
                    { 93, new DateTime(1991, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(9287), 1, "Фамилия 93", "Имя 93", "Отчество 93" },
                    { 83, new DateTime(2000, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(9208), 1, "Фамилия 83", "Имя 83", "Отчество 83" },
                    { 70, new DateTime(1997, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(9153), 1, "Фамилия 70", "Имя 70", "Отчество 70" },
                    { 68, new DateTime(1993, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(9145), 1, "Фамилия 68", "Имя 68", "Отчество 68" },
                    { 65, new DateTime(1998, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(9133), 1, "Фамилия 65", "Имя 65", "Отчество 65" },
                    { 61, new DateTime(1997, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(9116), 1, "Фамилия 61", "Имя 61", "Отчество 61" },
                    { 28, new DateTime(1991, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(8941), 1, "Фамилия 28", "Имя 28", "Отчество 28" },
                    { 21, new DateTime(1995, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(8856), 1, "Фамилия 21", "Имя 21", "Отчество 21" },
                    { 6, new DateTime(2000, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(8790), 3, "Фамилия 6", "Имя 6", "Отчество 6" },
                    { 16, new DateTime(2002, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(8835), 3, "Фамилия 16", "Имя 16", "Отчество 16" },
                    { 20, new DateTime(1995, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(8852), 3, "Фамилия 20", "Имя 20", "Отчество 20" },
                    { 22, new DateTime(1999, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(8860), 3, "Фамилия 22", "Имя 22", "Отчество 22" },
                    { 78, new DateTime(1994, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(9188), 5, "Фамилия 78", "Имя 78", "Отчество 78" },
                    { 57, new DateTime(2001, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(9099), 5, "Фамилия 57", "Имя 57", "Отчество 57" },
                    { 53, new DateTime(2000, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(9045), 5, "Фамилия 53", "Имя 53", "Отчество 53" },
                    { 34, new DateTime(1998, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(8966), 5, "Фамилия 34", "Имя 34", "Отчество 34" },
                    { 26, new DateTime(1994, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(8932), 5, "Фамилия 26", "Имя 26", "Отчество 26" },
                    { 8, new DateTime(2001, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(8800), 5, "Фамилия 8", "Имя 8", "Отчество 8" },
                    { 92, new DateTime(1989, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(9282), 4, "Фамилия 92", "Имя 92", "Отчество 92" },
                    { 81, new DateTime(1994, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(9200), 4, "Фамилия 81", "Имя 81", "Отчество 81" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Birthday", "DepartamentId", "LastName", "Name", "Patronymic" },
                values: new object[,]
                {
                    { 76, new DateTime(1999, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(9179), 4, "Фамилия 76", "Имя 76", "Отчество 76" },
                    { 73, new DateTime(1992, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(9166), 4, "Фамилия 73", "Имя 73", "Отчество 73" },
                    { 90, new DateTime(1993, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(9274), 10, "Фамилия 90", "Имя 90", "Отчество 90" },
                    { 56, new DateTime(1991, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(9095), 4, "Фамилия 56", "Имя 56", "Отчество 56" },
                    { 17, new DateTime(1988, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(8838), 4, "Фамилия 17", "Имя 17", "Отчество 17" },
                    { 10, new DateTime(2003, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(8809), 4, "Фамилия 10", "Имя 10", "Отчество 10" },
                    { 5, new DateTime(1993, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(8785), 4, "Фамилия 5", "Имя 5", "Отчество 5" },
                    { 84, new DateTime(2003, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(9249), 3, "Фамилия 84", "Имя 84", "Отчество 84" },
                    { 80, new DateTime(1990, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(9196), 3, "Фамилия 80", "Имя 80", "Отчество 80" },
                    { 77, new DateTime(1992, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(9183), 3, "Фамилия 77", "Имя 77", "Отчество 77" },
                    { 62, new DateTime(1991, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(9120), 3, "Фамилия 62", "Имя 62", "Отчество 62" },
                    { 44, new DateTime(1993, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(9007), 3, "Фамилия 44", "Имя 44", "Отчество 44" },
                    { 41, new DateTime(1999, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(8995), 3, "Фамилия 41", "Имя 41", "Отчество 41" },
                    { 38, new DateTime(1989, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(8982), 3, "Фамилия 38", "Имя 38", "Отчество 38" },
                    { 45, new DateTime(1993, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(9012), 4, "Фамилия 45", "Имя 45", "Отчество 45" },
                    { 91, new DateTime(1997, 2, 21, 12, 42, 2, 741, DateTimeKind.Local).AddTicks(9278), 10, "Фамилия 91", "Имя 91", "Отчество 91" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Departaments_Name",
                table: "Departaments",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartamentId",
                table: "Employees",
                column: "DepartamentId");

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
                name: "Departaments");
        }
    }
}
