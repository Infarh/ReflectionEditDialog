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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Patronymic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DepartamentId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    { 7, new DateTime(1992, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(8885), 1, "Фамилия 7", "Имя 7", "Отчество 7" },
                    { 96, new DateTime(2003, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(9423), 7, "Фамилия 96", "Имя 96", "Отчество 96" },
                    { 82, new DateTime(1997, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(9365), 7, "Фамилия 82", "Имя 82", "Отчество 82" },
                    { 61, new DateTime(1988, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(9240), 7, "Фамилия 61", "Имя 61", "Отчество 61" },
                    { 55, new DateTime(2002, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(9215), 7, "Фамилия 55", "Имя 55", "Отчество 55" },
                    { 48, new DateTime(1988, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(9120), 7, "Фамилия 48", "Имя 48", "Отчество 48" },
                    { 43, new DateTime(1997, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(9099), 7, "Фамилия 43", "Имя 43", "Отчество 43" },
                    { 41, new DateTime(1998, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(9091), 7, "Фамилия 41", "Имя 41", "Отчество 41" },
                    { 36, new DateTime(1998, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(9070), 7, "Фамилия 36", "Имя 36", "Отчество 36" },
                    { 30, new DateTime(1996, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(9044), 7, "Фамилия 30", "Имя 30", "Отчество 30" },
                    { 28, new DateTime(1997, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(9036), 7, "Фамилия 28", "Имя 28", "Отчество 28" },
                    { 25, new DateTime(1989, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(9024), 7, "Фамилия 25", "Имя 25", "Отчество 25" },
                    { 15, new DateTime(2000, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(8921), 7, "Фамилия 15", "Имя 15", "Отчество 15" },
                    { 86, new DateTime(1989, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(9381), 6, "Фамилия 86", "Имя 86", "Отчество 86" },
                    { 60, new DateTime(1991, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(9236), 6, "Фамилия 60", "Имя 60", "Отчество 60" },
                    { 58, new DateTime(1997, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(9228), 6, "Фамилия 58", "Имя 58", "Отчество 58" },
                    { 53, new DateTime(1998, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(9207), 6, "Фамилия 53", "Имя 53", "Отчество 53" },
                    { 42, new DateTime(1992, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(9095), 6, "Фамилия 42", "Имя 42", "Отчество 42" },
                    { 14, new DateTime(1991, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(8917), 6, "Фамилия 14", "Имя 14", "Отчество 14" },
                    { 99, new DateTime(2002, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(9435), 5, "Фамилия 99", "Имя 99", "Отчество 99" },
                    { 98, new DateTime(2002, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(9431), 5, "Фамилия 98", "Имя 98", "Отчество 98" },
                    { 88, new DateTime(2003, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(9390), 5, "Фамилия 88", "Имя 88", "Отчество 88" },
                    { 5, new DateTime(1991, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(8874), 8, "Фамилия 5", "Имя 5", "Отчество 5" },
                    { 78, new DateTime(2003, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(9348), 5, "Фамилия 78", "Имя 78", "Отчество 78" },
                    { 8, new DateTime(2001, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(8890), 8, "Фамилия 8", "Имя 8", "Отчество 8" },
                    { 18, new DateTime(1988, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(8934), 8, "Фамилия 18", "Имя 18", "Отчество 18" },
                    { 87, new DateTime(1988, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(9385), 10, "Фамилия 87", "Имя 87", "Отчество 87" },
                    { 83, new DateTime(1995, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(9369), 10, "Фамилия 83", "Имя 83", "Отчество 83" },
                    { 67, new DateTime(1999, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(9266), 10, "Фамилия 67", "Имя 67", "Отчество 67" },
                    { 57, new DateTime(1999, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(9224), 10, "Фамилия 57", "Имя 57", "Отчество 57" },
                    { 50, new DateTime(1990, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(9195), 10, "Фамилия 50", "Имя 50", "Отчество 50" },
                    { 26, new DateTime(1999, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(9028), 10, "Фамилия 26", "Имя 26", "Отчество 26" },
                    { 17, new DateTime(1996, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(8929), 10, "Фамилия 17", "Имя 17", "Отчество 17" },
                    { 3, new DateTime(2003, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(8863), 10, "Фамилия 3", "Имя 3", "Отчество 3" },
                    { 93, new DateTime(1995, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(9411), 9, "Фамилия 93", "Имя 93", "Отчество 93" },
                    { 72, new DateTime(2001, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(9286), 9, "Фамилия 72", "Имя 72", "Отчество 72" },
                    { 62, new DateTime(2000, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(9245), 9, "Фамилия 62", "Имя 62", "Отчество 62" },
                    { 33, new DateTime(2000, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(9057), 9, "Фамилия 33", "Имя 33", "Отчество 33" },
                    { 23, new DateTime(1990, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(9015), 9, "Фамилия 23", "Имя 23", "Отчество 23" },
                    { 4, new DateTime(1987, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(8869), 9, "Фамилия 4", "Имя 4", "Отчество 4" },
                    { 2, new DateTime(1988, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(8830), 9, "Фамилия 2", "Имя 2", "Отчество 2" },
                    { 92, new DateTime(1992, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(9406), 8, "Фамилия 92", "Имя 92", "Отчество 92" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Birthday", "DepartamentId", "LastName", "Name", "Patronymic" },
                values: new object[,]
                {
                    { 74, new DateTime(2003, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(9295), 8, "Фамилия 74", "Имя 74", "Отчество 74" },
                    { 70, new DateTime(1999, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(9278), 8, "Фамилия 70", "Имя 70", "Отчество 70" },
                    { 47, new DateTime(1990, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(9116), 8, "Фамилия 47", "Имя 47", "Отчество 47" },
                    { 38, new DateTime(2002, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(9078), 8, "Фамилия 38", "Имя 38", "Отчество 38" },
                    { 34, new DateTime(1989, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(9061), 8, "Фамилия 34", "Имя 34", "Отчество 34" },
                    { 12, new DateTime(2001, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(8908), 8, "Фамилия 12", "Имя 12", "Отчество 12" },
                    { 71, new DateTime(1995, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(9282), 5, "Фамилия 71", "Имя 71", "Отчество 71" },
                    { 54, new DateTime(2001, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(9211), 5, "Фамилия 54", "Имя 54", "Отчество 54" },
                    { 52, new DateTime(1987, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(9203), 5, "Фамилия 52", "Имя 52", "Отчество 52" },
                    { 79, new DateTime(2003, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(9352), 2, "Фамилия 79", "Имя 79", "Отчество 79" },
                    { 59, new DateTime(1990, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(9232), 2, "Фамилия 59", "Имя 59", "Отчество 59" },
                    { 39, new DateTime(1997, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(9082), 2, "Фамилия 39", "Имя 39", "Отчество 39" },
                    { 32, new DateTime(1992, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(9053), 2, "Фамилия 32", "Имя 32", "Отчество 32" },
                    { 29, new DateTime(1997, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(9040), 2, "Фамилия 29", "Имя 29", "Отчество 29" },
                    { 27, new DateTime(1995, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(9032), 2, "Фамилия 27", "Имя 27", "Отчество 27" },
                    { 10, new DateTime(2002, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(8899), 2, "Фамилия 10", "Имя 10", "Отчество 10" },
                    { 95, new DateTime(1988, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(9419), 1, "Фамилия 95", "Имя 95", "Отчество 95" },
                    { 94, new DateTime(2002, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(9415), 1, "Фамилия 94", "Имя 94", "Отчество 94" },
                    { 91, new DateTime(2003, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(9402), 1, "Фамилия 91", "Имя 91", "Отчество 91" },
                    { 90, new DateTime(1988, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(9398), 1, "Фамилия 90", "Имя 90", "Отчество 90" },
                    { 81, new DateTime(1991, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(9360), 1, "Фамилия 81", "Имя 81", "Отчество 81" },
                    { 73, new DateTime(1988, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(9290), 1, "Фамилия 73", "Имя 73", "Отчество 73" },
                    { 68, new DateTime(1996, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(9270), 1, "Фамилия 68", "Имя 68", "Отчество 68" },
                    { 64, new DateTime(1988, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(9253), 1, "Фамилия 64", "Имя 64", "Отчество 64" },
                    { 63, new DateTime(2002, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(9249), 1, "Фамилия 63", "Имя 63", "Отчество 63" },
                    { 49, new DateTime(1995, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(9190), 1, "Фамилия 49", "Имя 49", "Отчество 49" },
                    { 37, new DateTime(1990, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(9074), 1, "Фамилия 37", "Имя 37", "Отчество 37" },
                    { 24, new DateTime(1987, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(9019), 1, "Фамилия 24", "Имя 24", "Отчество 24" },
                    { 22, new DateTime(2001, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(9011), 1, "Фамилия 22", "Имя 22", "Отчество 22" },
                    { 20, new DateTime(1996, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(9002), 1, "Фамилия 20", "Имя 20", "Отчество 20" },
                    { 6, new DateTime(1998, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(8880), 3, "Фамилия 6", "Имя 6", "Отчество 6" },
                    { 9, new DateTime(1988, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(8894), 3, "Фамилия 9", "Имя 9", "Отчество 9" },
                    { 19, new DateTime(1995, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(8938), 3, "Фамилия 19", "Имя 19", "Отчество 19" },
                    { 21, new DateTime(2001, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(9007), 3, "Фамилия 21", "Имя 21", "Отчество 21" },
                    { 40, new DateTime(1988, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(9086), 5, "Фамилия 40", "Имя 40", "Отчество 40" },
                    { 35, new DateTime(2002, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(9066), 5, "Фамилия 35", "Имя 35", "Отчество 35" },
                    { 31, new DateTime(2000, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(9049), 5, "Фамилия 31", "Имя 31", "Отчество 31" },
                    { 16, new DateTime(1994, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(8925), 5, "Фамилия 16", "Имя 16", "Отчество 16" },
                    { 11, new DateTime(1988, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(8904), 5, "Фамилия 11", "Имя 11", "Отчество 11" },
                    { 1, new DateTime(2000, 2, 21, 12, 11, 28, 318, DateTimeKind.Local).AddTicks(8335), 5, "Фамилия 1", "Имя 1", "Отчество 1" },
                    { 89, new DateTime(1996, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(9394), 4, "Фамилия 89", "Имя 89", "Отчество 89" },
                    { 80, new DateTime(1998, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(9356), 4, "Фамилия 80", "Имя 80", "Отчество 80" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Birthday", "DepartamentId", "LastName", "Name", "Patronymic" },
                values: new object[,]
                {
                    { 76, new DateTime(1989, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(9303), 4, "Фамилия 76", "Имя 76", "Отчество 76" },
                    { 75, new DateTime(1997, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(9299), 4, "Фамилия 75", "Имя 75", "Отчество 75" },
                    { 97, new DateTime(1988, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(9427), 10, "Фамилия 97", "Имя 97", "Отчество 97" },
                    { 66, new DateTime(2000, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(9262), 4, "Фамилия 66", "Имя 66", "Отчество 66" },
                    { 13, new DateTime(1997, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(8913), 4, "Фамилия 13", "Имя 13", "Отчество 13" },
                    { 85, new DateTime(1994, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(9377), 3, "Фамилия 85", "Имя 85", "Отчество 85" },
                    { 84, new DateTime(1987, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(9373), 3, "Фамилия 84", "Имя 84", "Отчество 84" },
                    { 77, new DateTime(1999, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(9307), 3, "Фамилия 77", "Имя 77", "Отчество 77" },
                    { 69, new DateTime(1991, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(9274), 3, "Фамилия 69", "Имя 69", "Отчество 69" },
                    { 56, new DateTime(1998, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(9219), 3, "Фамилия 56", "Имя 56", "Отчество 56" },
                    { 51, new DateTime(2003, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(9199), 3, "Фамилия 51", "Имя 51", "Отчество 51" },
                    { 46, new DateTime(1998, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(9112), 3, "Фамилия 46", "Имя 46", "Отчество 46" },
                    { 45, new DateTime(1994, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(9108), 3, "Фамилия 45", "Имя 45", "Отчество 45" },
                    { 44, new DateTime(1987, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(9104), 3, "Фамилия 44", "Имя 44", "Отчество 44" },
                    { 65, new DateTime(2001, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(9257), 4, "Фамилия 65", "Имя 65", "Отчество 65" },
                    { 100, new DateTime(1997, 2, 21, 12, 11, 28, 320, DateTimeKind.Local).AddTicks(9440), 10, "Фамилия 100", "Имя 100", "Отчество 100" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartamentId",
                table: "Employees",
                column: "DepartamentId");
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
