using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.web.Migrations
{
    public partial class addalldb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "DefaultDays",
                table: "LeaveTypes",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "b1f8ae0c-4a9a-44f3-9f40-a5a7b3fc0ce8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "5e3372f9-f0a0-4bfd-aebc-60a58ef2efc3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c94ff469-02a4-42b1-bdac-fde1bb69f0d4", "AQAAAAEAACcQAAAAEHSPh5GAivH7laQV+QsPc+iHeKjs5a8N2hpyLvsdcfCrLqw5X04rAG/TF1ClM9BkEQ==", "35af8071-d99c-47d2-b7db-69474c058198" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "73f9586e-1197-45e6-b110-89ebc5d730c5", "AQAAAAEAACcQAAAAEN9DREORhJan9IdjFA1eD9v/xTkiWFKn2Nm4OEvVmvHq9fQ4cv4RPJW6jnUzWU0U7A==", "4b2a44cd-46af-47c8-b698-d7f9ce6c7a72" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DefaultDays",
                table: "LeaveTypes",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "ba84196c-b5f0-443a-8c37-0cbfe172e8dd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "8223e49f-96c7-4852-a9e5-828b68206751");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6a728bd6-d59e-4c19-929b-f83e62ee7d4f", "AQAAAAEAACcQAAAAEAxGzRqHE507Z+I4eYSyZPy13RbS2FzzxnzSMDUGX4IaovJpTQZETNgMoLZpQUiuVA==", "f4d44255-463d-48f6-8aac-c259f2f26c1e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "17e1ffc9-c768-4e9e-9600-8e273f67f31a", "AQAAAAEAACcQAAAAEC8VA/Zh/ygmTVetfCa2vpI3tt8TQe8QLjokcV0wHBIdkOOG0sWOseUXkAtDXnoPAA==", "6a182cad-76b0-4c8b-8290-2d7e03834821" });
        }
    }
}
