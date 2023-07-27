using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.web.Data.Migrations
{
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "f7f396b1-b817-4497-acc4-6f497f5d964a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "566740df-6f10-433c-a046-52aea8c567d4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "18ed46cc-d9ea-45a5-a4a8-1d3489935a26", "AQAAAAEAACcQAAAAECA1WNBwKkz0ZAddrNJLqGj+Sf0gfci1RqS96uK2vFo15J5Q7gCdFZIvGzQorYFGfw==", "f18e1be3-8002-4b9a-aa00-8148e483b898" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "348c3521-a2e9-4204-9c42-531d0daf2ed8", "AQAAAAEAACcQAAAAEPToL/kZ9WCtVUhkrJ6iHs7hneql9CpC1WZAXB91+04oIiYmKbedg5qmmkZg67cgfg==", "ea8e56d6-48fd-4044-ae7e-a4bf8748e557" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "60c3a3cc-e58e-46cd-ae79-eb53e55eff4a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "2118d3c6-c38b-48cf-81fe-8fe94dd87171");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2281219d-9c52-4f58-a697-1196431e0ac6", "AQAAAAEAACcQAAAAECVc+A/dhWIrMBhV4E22MKT2bLP9XY1T3JucwVBLzEmMPOZcyMaguyiuhjUZrAVdXA==", "5b99223e-6581-4950-8934-7de95fac2d8c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f557805-2c72-416b-9cb7-a5d89a95b2d5", "AQAAAAEAACcQAAAAEMndtSJVN8dFtzXRdmcFZIBGD+C0OElMdIUasDTSjK2XPbF1Thy5Mp65+Nh4oq0Y0A==", "e16317c3-81f8-414b-8dde-c746cdd141f2" });
        }
    }
}
