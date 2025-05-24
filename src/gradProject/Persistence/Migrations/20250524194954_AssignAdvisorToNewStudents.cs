using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AssignAdvisorToNewStudents : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("005aed1b-5617-4f3a-838c-127dbff47c9a"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("05ef412e-7e1b-45cd-89ac-fd3148b7a76b"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("14ebcfa8-6f50-487e-9fc5-4ee6adf2875d"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("1aba9247-4951-448d-95d5-30db0e37d7ca"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("1b0e9aea-36cc-4050-902d-53c8f358072e"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("1d71e479-c6ad-44c4-b200-c733ff2c5cce"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("24b94413-3062-4740-ae52-3c0863413336"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("2851c695-95e8-492f-abbe-89a7ea62ce78"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("2a88f382-2b82-4bc2-888b-8dc28d1dd8eb"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("342b782b-38a6-4a51-bedf-455380c8878c"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("35d9b1f9-b193-4952-b002-0d92bc323eb0"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("3e777aa2-b92c-4c63-9753-61cc600f1dbf"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("3e9e052a-b4aa-4213-8415-a5828ef145c7"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("41f249c1-10d2-4750-8d84-c2bb448d4e59"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("429c0519-0191-48c0-a434-aa66104a3028"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("47285169-82cd-4a01-b814-a4b2c7fe79a1"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("482f5882-f2cd-48b8-a5eb-359bc40514b8"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("4a190ff1-54a6-4328-8e80-c9043c3d2b5d"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("4a438305-5393-4142-a0d9-b1438bf87387"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("522f6698-0ba6-4c1c-8917-a2e7f9f78cdd"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("5c620bd0-a28e-43f0-be39-b188a35d862a"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("5fb528a7-d613-4347-9af4-d34fd3f00eeb"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("646b7274-b190-4b43-a1f9-b39357b45843"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("6a2ddd3a-5f45-4968-9dd1-43e41c13217c"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("6ca87bef-607e-40bd-aeb8-082ee7649f0c"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("795e8e84-1dc5-4d77-b14c-7bdf87c96c6c"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("7a27708c-9690-4356-9276-cabfad53e099"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("7cb3566b-756a-4739-bef5-10bcae56dfb7"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("7cfcf7ad-f15c-4993-8dc9-02d18f8abb85"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("8184078f-6bc2-4aae-a4c1-036318daf72a"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("83281092-8939-45e5-bb47-48bb86ea48c7"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("8a381204-7787-452b-a5c8-5a3b8c825893"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("8c764947-2aaa-45c6-b244-70e803b2f601"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("95092453-8c0d-4493-b1f6-99f624fc4a0b"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("95f7fe08-e133-420f-92e0-2d2b91990e29"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("9de8765d-dfd0-40e2-9658-1b02c0c296c6"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("9f0d21d9-d260-47a2-9eb2-d04a8e0bdd46"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("a48ad84d-ac8c-47fe-99dc-7d129050ae9e"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("ac6c9576-853b-4bc5-acd4-38adc40f438c"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("b4ef5c86-427f-4e1b-84a3-8b00c573c151"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("bd8f3747-fc50-45e8-b771-b9b0a6ad2530"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("c061f6a8-4698-4fb5-8b5f-01554a02d589"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("c857396b-d92a-4bc8-b599-2adcd5496741"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("cf8a5ffa-c632-4a27-b8c7-a90f654fd570"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("d044e1cf-0ba8-4939-9591-5b5cfafdf363"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("d2b19d73-3207-45c2-b5fe-ab3e531e3b81"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("d96756c5-ccd8-4414-968d-4a67f2eff231"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("f1cb18ba-20ee-497f-acc5-fc66e54d0a0e"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("f82db4e9-5865-4895-b6ae-8ba536f97c16"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("fc260b22-f4a9-4434-81f8-db73f4e295b0"));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000001"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000002"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9600));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000003"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9600));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000004"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9600));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000005"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9600));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000006"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9610));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000007"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9610));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000008"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9610));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000009"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9610));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000010"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000011"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000012"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000013"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000014"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9630));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000015"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9630));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000016"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9640));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000017"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9640));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000018"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9640));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000019"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9650));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000020"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9650));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000021"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9650));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000022"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9650));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000023"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9660));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000024"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9660));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000025"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9660));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000026"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000027"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000028"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000029"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000030"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000031"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9680));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000032"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9680));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000033"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9680));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000034"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9690));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000035"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9690));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000036"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9690));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000037"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9690));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000038"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9690));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000039"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9700));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000040"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9700));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000041"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9700));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000042"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9700));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000043"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9710));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000044"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9710));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000045"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9710));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000046"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9720));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000047"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9720));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000048"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9730));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000049"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9730));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000050"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9730));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000051"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9730));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000052"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9740));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000053"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9750));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000054"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9750));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000055"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9760));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000056"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9760));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000057"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9760));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000058"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9760));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000059"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9760));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000060"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9770));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000061"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9770));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000062"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9770));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000063"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9770));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000064"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9780));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000065"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9780));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000066"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9780));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000067"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9780));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000068"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9790));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000069"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9790));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000070"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9790));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000071"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9790));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000072"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9800));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000073"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9800));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000074"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9800));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000075"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9800));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000076"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9810));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000077"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9810));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000078"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9820));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000079"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9820));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000080"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9820));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000081"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9830));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000082"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9830));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000083"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9830));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000084"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9830));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000085"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9830));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000086"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9840));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000087"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9840));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000088"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9840));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000089"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9840));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000090"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9850));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000091"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9850));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000092"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9850));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000093"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9850));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000094"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9860));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000095"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9860));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000096"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9860));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000097"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9860));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000098"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9870));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000099"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9870));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000100"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9870));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000101"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9870));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000102"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9880));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000103"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9880));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000104"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9880));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000105"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9880));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000106"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9880));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000107"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9890));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000108"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9900));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000109"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9900));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000110"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9910));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000111"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9910));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000112"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9910));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000113"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9910));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000114"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9920));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000115"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9920));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000116"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9920));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000117"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9920));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000118"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9930));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000119"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9930));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000120"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9930));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000121"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9930));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000122"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9930));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000123"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9940));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000124"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9940));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000125"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9940));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000126"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9940));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000127"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9950));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000128"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9950));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000129"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9950));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000130"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9950));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000131"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9970));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000132"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9970));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000133"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9980));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000134"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9980));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000135"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9980));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000136"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9980));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000137"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9990));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000138"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9990));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000139"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9990));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000140"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9990));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000141"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 154, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000142"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 154, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000143"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 154, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000144"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 154, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000145"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 154, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000146"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 154, DateTimeKind.Utc).AddTicks(10));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000147"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 154, DateTimeKind.Utc).AddTicks(10));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000148"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 154, DateTimeKind.Utc).AddTicks(10));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000149"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 154, DateTimeKind.Utc).AddTicks(10));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000150"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 154, DateTimeKind.Utc).AddTicks(20));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000151"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 154, DateTimeKind.Utc).AddTicks(20));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000152"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 154, DateTimeKind.Utc).AddTicks(20));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000153"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 154, DateTimeKind.Utc).AddTicks(20));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000154"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 154, DateTimeKind.Utc).AddTicks(30));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000155"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 154, DateTimeKind.Utc).AddTicks(30));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000156"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 154, DateTimeKind.Utc).AddTicks(30));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000157"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 154, DateTimeKind.Utc).AddTicks(30));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000158"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 154, DateTimeKind.Utc).AddTicks(40));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000159"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 154, DateTimeKind.Utc).AddTicks(40));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000160"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 154, DateTimeKind.Utc).AddTicks(40));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000161"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 154, DateTimeKind.Utc).AddTicks(50));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000162"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 154, DateTimeKind.Utc).AddTicks(50));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000163"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 154, DateTimeKind.Utc).AddTicks(50));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000164"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 154, DateTimeKind.Utc).AddTicks(60));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000165"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 154, DateTimeKind.Utc).AddTicks(60));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000166"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 154, DateTimeKind.Utc).AddTicks(60));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000001"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(8340));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000002"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(8340));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000003"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(8340));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000004"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(8350));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000005"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(8350));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000006"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(8350));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000007"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(8350));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000008"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(8360));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000009"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(8360));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000010"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(8360));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000011"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(8360));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000012"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(8360));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000013"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(8370));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000014"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(8370));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000015"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(8370));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000016"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(8370));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000017"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(8370));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000018"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(8380));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000019"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(8380));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000020"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(8380));

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(8250));

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(8300));

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(8300));

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(8300));

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000005"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(8300));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000001"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000084"), new DateTime(2020, 11, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9190) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000002"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000084"), new DateTime(2023, 9, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9200) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000003"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000084"), new DateTime(2024, 1, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9210) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000004"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000084"), new DateTime(2023, 9, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9210) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000005"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000084"), new DateTime(2021, 1, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9210) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000006"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000084"), new DateTime(2022, 9, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9220) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000007"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000084"), new DateTime(2021, 9, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9220) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000008"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000084"), new DateTime(2022, 3, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9220) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000009"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000084"), new DateTime(2022, 8, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9220) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000010"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000084"), new DateTime(2022, 12, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9230) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000011"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000084"), new DateTime(2023, 2, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9230) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000012"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000084"), new DateTime(2022, 7, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9230) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000013"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000084"), new DateTime(2021, 10, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9240) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000014"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000084"), new DateTime(2023, 11, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9240) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000015"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000084"), new DateTime(2021, 3, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9240) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000016"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000084"), new DateTime(2023, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9240) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000017"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000084"), new DateTime(2020, 9, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9250) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000018"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000084"), new DateTime(2021, 9, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9250) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000019"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000084"), new DateTime(2021, 10, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9250) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000020"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000084"), new DateTime(2024, 2, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9250) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000021"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000084"), new DateTime(2021, 11, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9260) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000022"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000084"), new DateTime(2021, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9260) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000023"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000084"), new DateTime(2023, 6, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9260) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000024"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000084"), new DateTime(2023, 2, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9260) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000025"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000084"), new DateTime(2022, 10, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9270) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000026"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000084"), new DateTime(2023, 8, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9270) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000027"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000084"), new DateTime(2024, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9270) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000028"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000084"), new DateTime(2022, 10, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9290) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000029"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000084"), new DateTime(2021, 3, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9290) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000030"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000084"), new DateTime(2022, 9, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9290) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000031"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000084"), new DateTime(2023, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9290) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000032"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000084"), new DateTime(2024, 3, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9300) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000033"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000084"), new DateTime(2022, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9300) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000034"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000084"), new DateTime(2020, 10, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9300) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000035"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000084"), new DateTime(2022, 9, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9310) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000036"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000084"), new DateTime(2024, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9310) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000037"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000084"), new DateTime(2020, 7, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9310) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000038"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000084"), new DateTime(2023, 2, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9310) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000039"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000084"), new DateTime(2022, 11, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9320) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000040"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000084"), new DateTime(2022, 2, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9320) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000041"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000084"), new DateTime(2023, 12, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9320) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000042"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000084"), new DateTime(2023, 11, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9320) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000043"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000084"), new DateTime(2023, 4, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9330) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000044"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000084"), new DateTime(2020, 11, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9330) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000045"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000084"), new DateTime(2021, 7, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9330) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000046"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000084"), new DateTime(2020, 8, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9330) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000047"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000084"), new DateTime(2023, 7, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9340) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000048"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000084"), new DateTime(2023, 8, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9340) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000049"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000084"), new DateTime(2020, 7, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9340) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000050"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000084"), new DateTime(2024, 4, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9340) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000051"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000084"), new DateTime(2024, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9350) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000052"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000084"), new DateTime(2021, 4, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9350) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000053"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000084"), new DateTime(2021, 4, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9350) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000054"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000084"), new DateTime(2022, 11, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9360) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000055"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000084"), new DateTime(2021, 10, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9360) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000056"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000084"), new DateTime(2022, 11, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9360) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000057"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000084"), new DateTime(2021, 3, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9360) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000058"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000084"), new DateTime(2021, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9370) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000059"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000084"), new DateTime(2022, 12, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9370) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000060"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000084"), new DateTime(2023, 11, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9370) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000061"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000084"), new DateTime(2024, 2, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9380) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000062"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000084"), new DateTime(2022, 10, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9380) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000063"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000084"), new DateTime(2022, 1, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9380) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000064"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000084"), new DateTime(2024, 2, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9380) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000065"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000084"), new DateTime(2021, 4, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9390) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000066"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000084"), new DateTime(2023, 7, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9390) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000067"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000084"), new DateTime(2023, 6, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9390) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000068"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000084"), new DateTime(2023, 1, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9390) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000069"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000084"), new DateTime(2023, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9400) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000070"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000084"), new DateTime(2023, 6, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9400) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000071"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000084"), new DateTime(2021, 12, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9400) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000072"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000084"), new DateTime(2021, 2, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9400) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000073"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000084"), new DateTime(2021, 11, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9410) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000074"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000084"), new DateTime(2023, 11, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9410) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000075"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000084"), new DateTime(2022, 12, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9410) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000076"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000084"), new DateTime(2022, 9, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9420) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000077"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000084"), new DateTime(2024, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9420) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000078"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000084"), new DateTime(2023, 8, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9420) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000079"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000084"), new DateTime(2021, 2, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9420) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000080"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000084"), new DateTime(2022, 2, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9430) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000081"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000084"), new DateTime(2021, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9430) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000082"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000084"), new DateTime(2021, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9430) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000083"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000084"), new DateTime(2021, 5, 24, 22, 49, 52, 153, DateTimeKind.Utc).AddTicks(9440) });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { new Guid("05bdb34e-0699-4076-b705-2b36865c2257"), new DateTime(2025, 5, 24, 19, 49, 52, 153, DateTimeKind.Utc).AddTicks(6350), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000031") },
                    { new Guid("119e615c-0ac9-49e0-ac3a-d9d0fc870d30"), new DateTime(2025, 5, 24, 19, 49, 52, 153, DateTimeKind.Utc).AddTicks(6290), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000020") },
                    { new Guid("12846d03-7dbe-440d-9f54-1ef68b32f1e5"), new DateTime(2025, 5, 24, 19, 49, 52, 153, DateTimeKind.Utc).AddTicks(6280), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000016") },
                    { new Guid("1a30f77d-7bca-4ce4-84bd-5f53cc358c4c"), new DateTime(2025, 5, 24, 19, 49, 52, 153, DateTimeKind.Utc).AddTicks(6230), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000004") },
                    { new Guid("1ac2b916-5d38-4712-932b-a45beaa0212e"), new DateTime(2025, 5, 24, 19, 49, 52, 153, DateTimeKind.Utc).AddTicks(6210), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000001") },
                    { new Guid("1f700357-cb93-4fa1-bb04-dc703f92b2f7"), new DateTime(2025, 5, 24, 19, 49, 52, 153, DateTimeKind.Utc).AddTicks(6390), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000040") },
                    { new Guid("203ecd13-fb3a-4f0c-b295-980a63088140"), new DateTime(2025, 5, 24, 19, 49, 52, 153, DateTimeKind.Utc).AddTicks(6400), null, new Guid("00000000-0000-0000-0000-000000000004"), null, new Guid("40000000-0000-0000-0000-000000000084") },
                    { new Guid("207e99bb-4eec-4fd7-90de-3bc739d27e4a"), new DateTime(2025, 5, 24, 19, 49, 52, 153, DateTimeKind.Utc).AddTicks(6300), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000021") },
                    { new Guid("22e2d114-f380-4616-a4a5-7b85d5a193f3"), new DateTime(2025, 5, 24, 19, 49, 52, 153, DateTimeKind.Utc).AddTicks(6350), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000030") },
                    { new Guid("253c55b5-eb6b-4e64-8cf5-b8ba8c85677b"), new DateTime(2025, 5, 24, 19, 49, 52, 153, DateTimeKind.Utc).AddTicks(6310), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000024") },
                    { new Guid("2783d43e-917b-48ec-a287-6d5a478c6eb6"), new DateTime(2025, 5, 24, 19, 49, 52, 153, DateTimeKind.Utc).AddTicks(6310), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000025") },
                    { new Guid("2825b3e7-9a56-4e78-8a9f-b68a175995a6"), new DateTime(2025, 5, 24, 19, 49, 52, 153, DateTimeKind.Utc).AddTicks(6420), null, new Guid("00000000-0000-0000-0000-000000000004"), null, new Guid("40000000-0000-0000-0000-000000000090") },
                    { new Guid("2fa59b60-ec40-4a5d-803b-4e8ea022e96b"), new DateTime(2025, 5, 24, 19, 49, 52, 153, DateTimeKind.Utc).AddTicks(6270), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000014") },
                    { new Guid("434fdc49-a577-486d-8a00-a43e5db35a29"), new DateTime(2025, 5, 24, 19, 49, 52, 153, DateTimeKind.Utc).AddTicks(6380), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000037") },
                    { new Guid("46e6cb7b-5289-4175-9ab2-1068d522ffc0"), new DateTime(2025, 5, 24, 19, 49, 52, 153, DateTimeKind.Utc).AddTicks(6280), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000018") },
                    { new Guid("497d27e9-7bbd-419e-a7e9-bc2856a95aa8"), new DateTime(2025, 5, 24, 19, 49, 52, 153, DateTimeKind.Utc).AddTicks(6260), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000013") },
                    { new Guid("4b63098d-6e73-4eb6-9208-2a686a7d759f"), new DateTime(2025, 5, 24, 19, 49, 52, 153, DateTimeKind.Utc).AddTicks(6230), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000005") },
                    { new Guid("55ccac63-6bfb-434a-8449-3fbde96afa39"), new DateTime(2025, 5, 24, 19, 49, 52, 153, DateTimeKind.Utc).AddTicks(6380), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000038") },
                    { new Guid("583b332b-42d0-4cd4-881e-81314248791d"), new DateTime(2025, 5, 24, 19, 49, 52, 153, DateTimeKind.Utc).AddTicks(6220), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000003") },
                    { new Guid("58a3bf77-810c-4d63-9b07-51d343e31386"), new DateTime(2025, 5, 24, 19, 49, 52, 153, DateTimeKind.Utc).AddTicks(6430), null, new Guid("00000000-0000-0000-0000-000000000003"), null, new Guid("40000000-0000-0000-0000-000000000091") },
                    { new Guid("6361b667-eb1b-45e3-ac7d-e5fbbab0f6f2"), new DateTime(2025, 5, 24, 19, 49, 52, 153, DateTimeKind.Utc).AddTicks(6360), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000033") },
                    { new Guid("64e5e66e-40a4-4309-8a8d-d742d204d9ef"), new DateTime(2025, 5, 24, 19, 49, 52, 153, DateTimeKind.Utc).AddTicks(6300), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000022") },
                    { new Guid("68d99487-7b22-4eaa-8c78-ece1b3cf00d3"), new DateTime(2025, 5, 24, 19, 49, 52, 153, DateTimeKind.Utc).AddTicks(6390), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000039") },
                    { new Guid("6d6ffd65-96dd-48f6-acb4-db1ed871aba4"), new DateTime(2025, 5, 24, 19, 49, 52, 153, DateTimeKind.Utc).AddTicks(6260), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000011") },
                    { new Guid("7223f587-8545-4e29-9359-93c5ddbea95f"), new DateTime(2025, 5, 24, 19, 49, 52, 153, DateTimeKind.Utc).AddTicks(6320), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000027") },
                    { new Guid("75564030-d25c-4325-b681-b56083733290"), new DateTime(2025, 5, 24, 19, 49, 52, 153, DateTimeKind.Utc).AddTicks(6410), null, new Guid("00000000-0000-0000-0000-000000000005"), null, new Guid("40000000-0000-0000-0000-000000000086") },
                    { new Guid("801fda4c-568f-4ab8-8500-c5fddaaef54d"), new DateTime(2025, 5, 24, 19, 49, 52, 153, DateTimeKind.Utc).AddTicks(6340), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000029") },
                    { new Guid("8384087f-bb7e-4dfd-bdab-728ba32013b7"), new DateTime(2025, 5, 24, 19, 49, 52, 153, DateTimeKind.Utc).AddTicks(6420), null, new Guid("00000000-0000-0000-0000-000000000004"), null, new Guid("40000000-0000-0000-0000-000000000088") },
                    { new Guid("86548a57-8ca6-435f-a070-694c377aa0e7"), new DateTime(2025, 5, 24, 19, 49, 52, 153, DateTimeKind.Utc).AddTicks(6240), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000007") },
                    { new Guid("8ace4d04-4408-44f2-b87e-5d44143410cd"), new DateTime(2025, 5, 24, 19, 49, 52, 153, DateTimeKind.Utc).AddTicks(6270), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000015") },
                    { new Guid("94a4a127-4584-4c86-8dae-04f3459a3502"), new DateTime(2025, 5, 24, 19, 49, 52, 153, DateTimeKind.Utc).AddTicks(6220), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000002") },
                    { new Guid("ac39d7c8-7c2e-40a1-865f-8baee06518c6"), new DateTime(2025, 5, 24, 19, 49, 52, 153, DateTimeKind.Utc).AddTicks(6370), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000035") },
                    { new Guid("b4b01a14-33bd-4700-a8ac-8d162d3c3ab7"), new DateTime(2025, 5, 24, 19, 49, 52, 153, DateTimeKind.Utc).AddTicks(6240), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000006") },
                    { new Guid("b72fbb96-0e1e-40e3-b48d-7cff0649828a"), new DateTime(2025, 5, 24, 19, 49, 52, 153, DateTimeKind.Utc).AddTicks(6440), null, new Guid("00000000-0000-0000-0000-000000000004"), null, new Guid("40000000-0000-0000-0000-000000000093") },
                    { new Guid("b99faeef-6c97-4c1c-87ec-2777a6c2b330"), new DateTime(2025, 5, 24, 19, 49, 52, 153, DateTimeKind.Utc).AddTicks(6440), null, new Guid("00000000-0000-0000-0000-000000000003"), null, new Guid("40000000-0000-0000-0000-000000000092") },
                    { new Guid("c2f27f8d-5d8d-4dc3-bd39-e41a11c12092"), new DateTime(2025, 5, 24, 19, 49, 52, 153, DateTimeKind.Utc).AddTicks(6260), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000012") },
                    { new Guid("c552ec86-7988-4386-8acc-7bf782c9fa76"), new DateTime(2025, 5, 24, 19, 49, 52, 153, DateTimeKind.Utc).AddTicks(6250), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000009") },
                    { new Guid("c6262bf0-d657-4d74-9c22-63429d544ec2"), new DateTime(2025, 5, 24, 19, 49, 52, 153, DateTimeKind.Utc).AddTicks(6410), null, new Guid("00000000-0000-0000-0000-000000000006"), null, new Guid("40000000-0000-0000-0000-000000000087") },
                    { new Guid("c6ca87f7-b4dd-4581-8698-051b5141b98c"), new DateTime(2025, 5, 24, 19, 49, 52, 153, DateTimeKind.Utc).AddTicks(6370), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000034") },
                    { new Guid("d65d963a-5764-4404-a920-a8ccd70fd972"), new DateTime(2025, 5, 24, 19, 49, 52, 153, DateTimeKind.Utc).AddTicks(6280), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000017") },
                    { new Guid("d9a4a1e9-5ce5-461c-b20f-b09113fc835d"), new DateTime(2025, 5, 24, 19, 49, 52, 153, DateTimeKind.Utc).AddTicks(6290), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000019") },
                    { new Guid("dc0fb208-3e6d-49e6-bf34-8ed8fa0c52f6"), new DateTime(2025, 5, 24, 19, 49, 52, 153, DateTimeKind.Utc).AddTicks(6300), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000023") },
                    { new Guid("e3881b74-3246-4a83-b958-61e11b4cc44a"), new DateTime(2025, 5, 24, 19, 49, 52, 153, DateTimeKind.Utc).AddTicks(6420), null, new Guid("00000000-0000-0000-0000-000000000003"), null, new Guid("40000000-0000-0000-0000-000000000089") },
                    { new Guid("e795bf07-6888-4bae-9527-10a98b31b789"), new DateTime(2025, 5, 24, 19, 49, 52, 153, DateTimeKind.Utc).AddTicks(6400), null, new Guid("00000000-0000-0000-0000-000000000004"), null, new Guid("40000000-0000-0000-0000-000000000085") },
                    { new Guid("eb760689-6980-4721-8e18-c987bf2fce32"), new DateTime(2025, 5, 24, 19, 49, 52, 153, DateTimeKind.Utc).AddTicks(6250), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000010") },
                    { new Guid("edc00a36-e626-4690-bd6f-4a17c2913e4b"), new DateTime(2025, 5, 24, 19, 49, 52, 153, DateTimeKind.Utc).AddTicks(6240), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000008") },
                    { new Guid("ee44fb6a-4e0e-4fd3-93da-49c3050f9bf4"), new DateTime(2025, 5, 24, 19, 49, 52, 153, DateTimeKind.Utc).AddTicks(6310), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000026") },
                    { new Guid("f3c1f06f-41e4-4262-ab6c-df7526a1a365"), new DateTime(2025, 5, 24, 19, 49, 52, 153, DateTimeKind.Utc).AddTicks(6380), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000036") },
                    { new Guid("f5e8f90d-897c-45d3-9d49-8f8495c11344"), new DateTime(2025, 5, 24, 19, 49, 52, 153, DateTimeKind.Utc).AddTicks(6360), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000032") },
                    { new Guid("f89e4d5f-16d5-4955-8190-6ef983658268"), new DateTime(2025, 5, 24, 19, 49, 52, 153, DateTimeKind.Utc).AddTicks(6320), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000028") }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-11111111111a"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 205, 207, 37, 39, 90, 26, 162, 143, 202, 145, 79, 204, 55, 1, 209, 109, 172, 96, 9, 182, 151, 45, 169, 186, 143, 16, 126, 126, 174, 93, 79, 182, 43, 58, 91, 97, 160, 132, 24, 139, 185, 8, 85, 68, 89, 114, 153, 10, 23, 65, 72, 131, 182, 164, 176, 31, 48, 199, 60, 153, 167, 181, 100, 232 }, new byte[] { 172, 7, 3, 154, 224, 100, 153, 97, 8, 231, 123, 210, 76, 169, 46, 145, 186, 98, 37, 161, 13, 126, 69, 189, 253, 246, 41, 177, 163, 78, 105, 17, 90, 225, 138, 206, 39, 250, 138, 219, 185, 188, 138, 103, 29, 13, 51, 121, 215, 89, 132, 23, 35, 26, 165, 57, 66, 252, 127, 236, 206, 154, 49, 66, 249, 36, 218, 17, 118, 35, 100, 243, 194, 169, 103, 156, 83, 246, 199, 61, 231, 73, 208, 19, 139, 101, 20, 99, 23, 237, 228, 4, 207, 16, 111, 3, 197, 0, 65, 134, 4, 81, 71, 224, 66, 16, 238, 143, 134, 231, 180, 67, 130, 65, 194, 103, 39, 26, 24, 15, 44, 85, 25, 234, 87, 134, 99, 130 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-22222222222a"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 115, 27, 162, 122, 170, 80, 24, 102, 9, 126, 52, 107, 126, 247, 32, 227, 58, 25, 59, 71, 148, 60, 21, 60, 86, 239, 40, 248, 172, 203, 181, 26, 113, 177, 191, 226, 120, 208, 96, 172, 116, 149, 164, 79, 19, 1, 138, 107, 57, 3, 7, 252, 209, 254, 180, 254, 37, 174, 79, 202, 241, 65 }, new byte[] { 97, 199, 199, 53, 145, 175, 31, 186, 0, 227, 11, 151, 180, 209, 237, 133, 131, 255, 156, 140, 141, 202, 248, 26, 132, 110, 232, 209, 255, 167, 69, 180, 109, 230, 88, 31, 128, 5, 170, 141, 58, 50, 174, 244, 115, 101, 199, 116, 57, 195, 91, 184, 64, 123, 112, 155, 99, 196, 47, 139, 8, 102, 180, 68, 77, 36, 46, 95, 149, 191, 34, 209, 6, 32, 109, 159, 65, 34, 127, 101, 148, 56, 210, 146, 132, 203, 183, 116, 18, 25, 38, 224, 124, 225, 174, 15, 68, 199, 168, 233, 167, 63, 165, 233, 125, 42, 169, 133, 19, 112, 187, 9, 30, 52, 251, 119, 105, 114, 154, 145, 213, 96, 34, 84, 30, 105, 70, 171 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-33333333333a"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 220, 45, 222, 86, 105, 183, 17, 84, 132, 3, 176, 244, 90, 235, 96, 252, 232, 242, 38, 120, 89, 55, 123, 91, 159, 246, 137, 153, 19, 244, 182, 36, 64, 250, 252, 93, 60, 232, 107, 219, 210, 118, 174, 83, 83, 102, 65, 168, 151, 86, 165, 99, 243, 95, 153, 87, 55, 144, 69, 217, 226, 13, 198, 104 }, new byte[] { 132, 66, 188, 151, 41, 107, 254, 201, 97, 100, 238, 36, 146, 226, 187, 21, 165, 87, 58, 152, 38, 170, 110, 244, 183, 180, 161, 85, 220, 105, 89, 200, 15, 21, 128, 215, 51, 234, 28, 165, 223, 124, 122, 63, 132, 214, 119, 83, 201, 201, 250, 100, 246, 15, 170, 103, 37, 231, 95, 50, 123, 126, 3, 10, 240, 109, 218, 10, 106, 198, 250, 192, 155, 96, 128, 22, 244, 175, 132, 92, 201, 170, 242, 132, 0, 215, 110, 42, 29, 240, 128, 254, 109, 217, 152, 14, 236, 173, 28, 201, 90, 53, 12, 93, 116, 176, 162, 35, 3, 12, 151, 48, 76, 5, 116, 215, 230, 175, 227, 136, 50, 48, 139, 136, 163, 124, 100, 190 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000001"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000002"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000003"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000004"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000005"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000006"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000007"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000008"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000009"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000010"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000011"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000012"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000013"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000014"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000015"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000016"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000017"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000018"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000019"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000020"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000021"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000022"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000023"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000024"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000025"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000026"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000027"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000028"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000029"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000030"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000031"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000032"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000033"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000034"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000035"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000036"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000037"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000038"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000039"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000040"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000041"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000042"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000043"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000044"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000045"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000046"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000047"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000048"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000049"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000050"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000051"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000052"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000053"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000054"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000055"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000056"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000057"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000058"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000059"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000060"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000061"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000062"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000063"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000064"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000065"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000066"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000067"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000068"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000069"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000070"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000071"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000072"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000073"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000074"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000075"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000076"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000077"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000078"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000079"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000080"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000081"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000082"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000083"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000084"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000085"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000086"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000087"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000088"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000089"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000090"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000091"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000092"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000093"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 23, 135, 135, 156, 43, 11, 175, 9, 24, 130, 40, 145, 136, 94, 178, 205, 90, 177, 176, 210, 199, 107, 81, 61, 206, 210, 25, 79, 218, 237, 115, 54, 10, 222, 157, 191, 10, 39, 147, 151, 250, 65, 138, 127, 31, 117, 138, 14, 138, 138, 120, 120, 206, 110, 46, 28, 199, 227, 23, 135, 242, 170, 34, 3 }, new byte[] { 247, 21, 39, 238, 104, 176, 162, 45, 11, 41, 184, 36, 109, 224, 199, 252, 42, 224, 148, 182, 255, 172, 154, 48, 162, 86, 59, 58, 140, 59, 68, 188, 214, 157, 77, 147, 45, 229, 52, 167, 144, 122, 49, 224, 172, 31, 240, 87, 181, 46, 52, 193, 221, 196, 34, 115, 69, 228, 220, 241, 32, 49, 65, 57, 20, 213, 49, 176, 216, 224, 40, 61, 87, 110, 26, 150, 232, 104, 44, 146, 131, 191, 33, 243, 155, 234, 238, 173, 63, 135, 133, 204, 181, 70, 81, 28, 0, 191, 8, 18, 213, 61, 162, 160, 152, 26, 208, 53, 228, 241, 231, 68, 84, 5, 140, 226, 109, 151, 11, 47, 205, 176, 106, 216, 151, 166, 201, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-44444444444a"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 40, 7, 234, 95, 219, 2, 209, 227, 230, 26, 178, 213, 187, 23, 47, 204, 80, 94, 110, 69, 246, 48, 236, 242, 254, 21, 173, 202, 203, 238, 230, 44, 33, 181, 69, 73, 203, 182, 113, 104, 69, 59, 29, 131, 240, 124, 44, 154, 220, 219, 185, 57, 119, 18, 213, 93, 79, 201, 111, 215, 251, 177, 108, 251 }, new byte[] { 156, 148, 230, 162, 250, 194, 232, 120, 166, 169, 238, 113, 143, 142, 24, 125, 110, 143, 194, 195, 19, 178, 33, 244, 73, 82, 38, 130, 76, 79, 218, 145, 226, 80, 224, 177, 41, 106, 95, 219, 237, 249, 218, 227, 151, 163, 214, 9, 36, 104, 74, 108, 178, 218, 173, 82, 247, 97, 205, 0, 96, 194, 112, 207, 24, 129, 11, 58, 118, 115, 180, 96, 89, 210, 245, 170, 155, 203, 248, 199, 50, 40, 223, 217, 129, 102, 74, 151, 112, 97, 38, 252, 62, 34, 99, 153, 108, 121, 158, 38, 14, 57, 219, 148, 217, 249, 172, 1, 162, 93, 15, 22, 60, 37, 61, 163, 185, 153, 28, 71, 193, 223, 206, 180, 110, 70, 250, 128 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-55555555555a"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 211, 240, 151, 64, 65, 84, 131, 150, 0, 102, 185, 132, 166, 203, 46, 227, 199, 203, 60, 175, 45, 179, 159, 122, 235, 73, 125, 73, 177, 207, 232, 52, 71, 252, 33, 69, 253, 161, 77, 222, 172, 56, 212, 168, 225, 226, 48, 42, 65, 253, 254, 136, 42, 238, 139, 109, 95, 176, 30, 83, 201, 203, 21, 64 }, new byte[] { 28, 131, 70, 192, 77, 106, 151, 241, 59, 85, 191, 97, 63, 223, 64, 108, 252, 152, 39, 180, 102, 254, 45, 93, 128, 126, 53, 50, 179, 116, 32, 237, 147, 245, 22, 39, 155, 92, 157, 133, 125, 55, 142, 235, 165, 243, 123, 136, 203, 3, 54, 240, 189, 49, 240, 39, 124, 15, 95, 89, 217, 20, 35, 138, 13, 216, 233, 255, 52, 207, 223, 73, 251, 76, 255, 157, 124, 70, 22, 151, 27, 245, 140, 252, 206, 23, 186, 85, 101, 23, 104, 146, 85, 185, 189, 37, 218, 123, 43, 145, 5, 208, 67, 178, 19, 20, 81, 152, 75, 17, 75, 131, 235, 173, 125, 186, 202, 195, 190, 119, 85, 236, 222, 124, 71, 4, 85, 84 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-66666666666a"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 4, 84, 107, 41, 178, 105, 190, 230, 228, 165, 135, 152, 97, 189, 183, 189, 108, 71, 94, 223, 198, 134, 240, 197, 200, 86, 120, 228, 249, 152, 58, 150, 89, 212, 77, 77, 146, 137, 219, 216, 254, 5, 72, 42, 163, 54, 186, 138, 255, 84, 151, 148, 46, 224, 12, 11, 99, 25, 35, 18, 62, 82, 175, 103 }, new byte[] { 241, 165, 195, 150, 227, 166, 66, 136, 150, 148, 127, 85, 96, 80, 18, 74, 153, 138, 198, 156, 7, 94, 179, 27, 232, 158, 219, 65, 250, 35, 185, 173, 2, 107, 24, 77, 128, 225, 0, 108, 207, 197, 239, 148, 203, 199, 230, 180, 5, 9, 95, 117, 70, 236, 204, 119, 16, 217, 52, 20, 47, 24, 194, 219, 196, 124, 234, 108, 40, 151, 131, 187, 113, 59, 223, 160, 212, 16, 155, 183, 57, 45, 30, 32, 56, 237, 225, 237, 79, 112, 252, 215, 182, 160, 25, 116, 218, 103, 204, 198, 169, 76, 144, 61, 201, 252, 127, 196, 147, 177, 51, 126, 12, 160, 159, 233, 74, 118, 104, 237, 87, 130, 30, 36, 120, 3, 203, 163 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("05bdb34e-0699-4076-b705-2b36865c2257"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("119e615c-0ac9-49e0-ac3a-d9d0fc870d30"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("12846d03-7dbe-440d-9f54-1ef68b32f1e5"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("1a30f77d-7bca-4ce4-84bd-5f53cc358c4c"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("1ac2b916-5d38-4712-932b-a45beaa0212e"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("1f700357-cb93-4fa1-bb04-dc703f92b2f7"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("203ecd13-fb3a-4f0c-b295-980a63088140"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("207e99bb-4eec-4fd7-90de-3bc739d27e4a"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("22e2d114-f380-4616-a4a5-7b85d5a193f3"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("253c55b5-eb6b-4e64-8cf5-b8ba8c85677b"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("2783d43e-917b-48ec-a287-6d5a478c6eb6"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("2825b3e7-9a56-4e78-8a9f-b68a175995a6"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("2fa59b60-ec40-4a5d-803b-4e8ea022e96b"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("434fdc49-a577-486d-8a00-a43e5db35a29"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("46e6cb7b-5289-4175-9ab2-1068d522ffc0"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("497d27e9-7bbd-419e-a7e9-bc2856a95aa8"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("4b63098d-6e73-4eb6-9208-2a686a7d759f"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("55ccac63-6bfb-434a-8449-3fbde96afa39"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("583b332b-42d0-4cd4-881e-81314248791d"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("58a3bf77-810c-4d63-9b07-51d343e31386"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("6361b667-eb1b-45e3-ac7d-e5fbbab0f6f2"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("64e5e66e-40a4-4309-8a8d-d742d204d9ef"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("68d99487-7b22-4eaa-8c78-ece1b3cf00d3"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("6d6ffd65-96dd-48f6-acb4-db1ed871aba4"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("7223f587-8545-4e29-9359-93c5ddbea95f"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("75564030-d25c-4325-b681-b56083733290"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("801fda4c-568f-4ab8-8500-c5fddaaef54d"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("8384087f-bb7e-4dfd-bdab-728ba32013b7"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("86548a57-8ca6-435f-a070-694c377aa0e7"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("8ace4d04-4408-44f2-b87e-5d44143410cd"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("94a4a127-4584-4c86-8dae-04f3459a3502"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("ac39d7c8-7c2e-40a1-865f-8baee06518c6"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("b4b01a14-33bd-4700-a8ac-8d162d3c3ab7"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("b72fbb96-0e1e-40e3-b48d-7cff0649828a"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("b99faeef-6c97-4c1c-87ec-2777a6c2b330"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("c2f27f8d-5d8d-4dc3-bd39-e41a11c12092"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("c552ec86-7988-4386-8acc-7bf782c9fa76"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("c6262bf0-d657-4d74-9c22-63429d544ec2"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("c6ca87f7-b4dd-4581-8698-051b5141b98c"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("d65d963a-5764-4404-a920-a8ccd70fd972"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("d9a4a1e9-5ce5-461c-b20f-b09113fc835d"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("dc0fb208-3e6d-49e6-bf34-8ed8fa0c52f6"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("e3881b74-3246-4a83-b958-61e11b4cc44a"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("e795bf07-6888-4bae-9527-10a98b31b789"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("eb760689-6980-4721-8e18-c987bf2fce32"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("edc00a36-e626-4690-bd6f-4a17c2913e4b"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("ee44fb6a-4e0e-4fd3-93da-49c3050f9bf4"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("f3c1f06f-41e4-4262-ab6c-df7526a1a365"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("f5e8f90d-897c-45d3-9d49-8f8495c11344"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("f89e4d5f-16d5-4955-8190-6ef983658268"));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000001"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6620));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000002"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6630));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000003"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6630));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000004"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6630));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000005"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6630));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000006"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6640));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000007"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6640));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000008"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6640));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000009"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6640));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000010"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6650));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000011"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6650));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000012"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6650));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000013"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6670));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000014"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6670));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000015"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6670));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000016"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6670));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000017"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6680));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000018"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6680));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000019"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6680));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000020"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6690));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000021"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6690));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000022"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6700));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000023"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6700));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000024"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6700));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000025"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6700));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000026"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6700));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000027"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6710));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000028"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6710));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000029"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6710));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000030"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6710));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000031"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6720));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000032"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6720));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000033"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6720));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000034"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6720));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000035"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6730));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000036"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6730));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000037"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6730));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000038"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6730));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000039"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6740));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000040"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6740));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000041"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6740));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000042"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6750));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000043"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6750));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000044"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6750));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000045"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6750));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000046"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6760));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000047"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6760));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000048"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6760));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000049"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6760));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000050"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6770));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000051"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6780));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000052"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6780));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000053"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6780));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000054"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6780));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000055"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6780));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000056"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6790));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000057"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6790));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000058"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6790));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000059"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6790));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000060"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6800));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000061"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6800));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000062"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6800));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000063"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6800));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000064"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6800));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000065"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6810));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000066"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6820));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000067"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6820));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000068"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6830));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000069"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6830));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000070"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6830));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000071"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6830));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000072"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6840));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000073"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6840));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000074"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6840));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000075"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6840));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000076"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6840));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000077"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6850));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000078"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6850));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000079"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6850));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000080"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6860));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000081"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6860));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000082"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6870));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000083"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6870));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000084"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6870));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000085"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6870));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000086"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6870));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000087"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6880));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000088"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6880));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000089"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6880));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000090"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6880));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000091"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000092"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000093"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000094"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000095"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000096"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6900));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000097"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6900));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000098"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6900));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000099"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6910));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000100"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6910));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000101"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6910));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000102"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6910));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000103"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6920));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000104"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6920));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000105"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6920));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000106"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6920));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000107"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6930));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000108"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6930));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000109"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6930));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000110"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6930));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000111"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6950));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000112"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6950));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000113"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6950));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000114"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6960));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000115"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6960));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000116"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6960));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000117"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6960));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000118"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6960));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000119"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6970));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000120"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6970));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000121"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6970));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000122"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6970));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000123"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6980));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000124"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6980));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000125"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6980));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000126"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6980));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000127"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(7000));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000128"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(7000));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000129"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(7000));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000130"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(7000));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000131"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(7010));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000132"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(7010));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000133"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(7010));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000134"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(7010));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000135"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(7020));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000136"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(7020));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000137"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(7020));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000138"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(7020));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000139"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(7020));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000140"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(7030));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000141"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(7030));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000142"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(7030));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000143"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(7030));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000144"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(7040));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000145"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(7040));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000146"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(7040));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000147"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(7040));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000148"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(7050));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000149"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(7050));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000150"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(7050));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000151"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(7050));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000152"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(7060));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000153"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(7060));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000154"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(7060));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000155"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(7060));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000156"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(7070));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000157"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(7070));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000158"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(7070));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000159"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(7070));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000160"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(7080));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000161"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(7080));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000162"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(7080));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000163"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(7080));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000164"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(7080));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000165"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(7090));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000166"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(7090));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000001"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(5400));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000002"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(5410));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000003"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(5410));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000004"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(5410));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000005"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(5410));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000006"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(5410));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000007"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(5420));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000008"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(5420));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000009"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(5420));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000010"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(5420));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000011"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(5420));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000012"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(5430));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000013"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(5430));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000014"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(5430));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000015"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(5430));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000016"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(5430));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000017"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(5440));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000018"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(5440));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000019"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(5440));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000020"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(5460));

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(5310));

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(5360));

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(5370));

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(5370));

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000005"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(5370));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000001"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { null, new DateTime(2020, 11, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6290) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000002"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { null, new DateTime(2023, 9, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6300) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000003"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { null, new DateTime(2024, 1, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6300) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000004"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { null, new DateTime(2023, 9, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6310) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000005"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { null, new DateTime(2021, 1, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6310) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000006"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { null, new DateTime(2022, 9, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6310) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000007"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { null, new DateTime(2021, 9, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6310) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000008"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { null, new DateTime(2022, 3, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6320) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000009"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { null, new DateTime(2022, 8, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6320) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000010"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { null, new DateTime(2022, 12, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6320) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000011"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { null, new DateTime(2023, 2, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6330) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000012"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { null, new DateTime(2022, 7, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6330) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000013"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { null, new DateTime(2021, 10, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6330) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000014"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { null, new DateTime(2023, 11, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6340) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000015"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { null, new DateTime(2021, 3, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6340) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000016"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { null, new DateTime(2023, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6340) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000017"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { null, new DateTime(2020, 9, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6350) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000018"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { null, new DateTime(2021, 9, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6350) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000019"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { null, new DateTime(2021, 10, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6350) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000020"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { null, new DateTime(2024, 2, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6350) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000021"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { null, new DateTime(2021, 11, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6360) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000022"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { null, new DateTime(2021, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6360) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000023"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { null, new DateTime(2023, 6, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6360) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000024"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { null, new DateTime(2023, 2, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6370) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000025"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { null, new DateTime(2022, 10, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6370) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000026"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { null, new DateTime(2023, 8, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6370) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000027"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { null, new DateTime(2024, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6370) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000028"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { null, new DateTime(2022, 10, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6380) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000029"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { null, new DateTime(2021, 3, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6380) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000030"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { null, new DateTime(2022, 9, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6380) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000031"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { null, new DateTime(2023, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6380) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000032"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { null, new DateTime(2024, 3, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6390) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000033"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { null, new DateTime(2022, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6390) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000034"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { null, new DateTime(2020, 10, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6390) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000035"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { null, new DateTime(2022, 9, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6390) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000036"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { null, new DateTime(2024, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6400) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000037"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { null, new DateTime(2020, 7, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6400) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000038"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { null, new DateTime(2023, 2, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6400) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000039"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { null, new DateTime(2022, 11, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6400) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000040"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { null, new DateTime(2022, 2, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6410) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000041"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { null, new DateTime(2023, 12, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6410) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000042"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { null, new DateTime(2023, 11, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6410) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000043"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { null, new DateTime(2023, 4, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6420) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000044"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { null, new DateTime(2020, 11, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6420) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000045"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { null, new DateTime(2021, 7, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6440) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000046"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { null, new DateTime(2020, 8, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6450) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000047"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { null, new DateTime(2023, 7, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6450) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000048"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { null, new DateTime(2023, 8, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6450) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000049"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { null, new DateTime(2020, 7, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6450) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000050"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { null, new DateTime(2024, 4, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6460) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000051"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { null, new DateTime(2024, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6460) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000052"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { null, new DateTime(2021, 4, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6460) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000053"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { null, new DateTime(2021, 4, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6470) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000054"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { null, new DateTime(2022, 11, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6470) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000055"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { null, new DateTime(2021, 10, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6470) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000056"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { null, new DateTime(2022, 11, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6470) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000057"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { null, new DateTime(2021, 3, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6480) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000058"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { null, new DateTime(2021, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6480) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000059"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { null, new DateTime(2022, 12, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6480) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000060"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { null, new DateTime(2023, 11, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6480) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000061"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { null, new DateTime(2024, 2, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6480) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000062"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { null, new DateTime(2022, 10, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6490) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000063"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { null, new DateTime(2022, 1, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6490) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000064"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { null, new DateTime(2024, 2, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6490) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000065"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { null, new DateTime(2021, 4, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6500) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000066"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { null, new DateTime(2023, 7, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6500) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000067"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { null, new DateTime(2023, 6, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6500) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000068"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { null, new DateTime(2023, 1, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6500) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000069"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { null, new DateTime(2023, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6510) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000070"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { null, new DateTime(2023, 6, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6510) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000071"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { null, new DateTime(2021, 12, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6510) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000072"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { null, new DateTime(2021, 2, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6510) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000073"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { null, new DateTime(2021, 11, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6520) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000074"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { null, new DateTime(2023, 11, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6520) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000075"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { null, new DateTime(2022, 12, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6520) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000076"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { null, new DateTime(2022, 9, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6530) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000077"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { null, new DateTime(2024, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6530) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000078"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { null, new DateTime(2023, 8, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6530) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000079"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { null, new DateTime(2021, 2, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6530) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000080"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { null, new DateTime(2022, 2, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6540) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000081"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { null, new DateTime(2021, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6540) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000082"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { null, new DateTime(2021, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6540) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000083"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { null, new DateTime(2021, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6550) });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { new Guid("005aed1b-5617-4f3a-838c-127dbff47c9a"), new DateTime(2025, 5, 24, 19, 48, 46, 236, DateTimeKind.Utc).AddTicks(4130), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000010") },
                    { new Guid("05ef412e-7e1b-45cd-89ac-fd3148b7a76b"), new DateTime(2025, 5, 24, 19, 48, 46, 236, DateTimeKind.Utc).AddTicks(4190), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000022") },
                    { new Guid("14ebcfa8-6f50-487e-9fc5-4ee6adf2875d"), new DateTime(2025, 5, 24, 19, 48, 46, 236, DateTimeKind.Utc).AddTicks(4210), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000027") },
                    { new Guid("1aba9247-4951-448d-95d5-30db0e37d7ca"), new DateTime(2025, 5, 24, 19, 48, 46, 236, DateTimeKind.Utc).AddTicks(4220), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000028") },
                    { new Guid("1b0e9aea-36cc-4050-902d-53c8f358072e"), new DateTime(2025, 5, 24, 19, 48, 46, 236, DateTimeKind.Utc).AddTicks(4290), null, new Guid("00000000-0000-0000-0000-000000000003"), null, new Guid("40000000-0000-0000-0000-000000000092") },
                    { new Guid("1d71e479-c6ad-44c4-b200-c733ff2c5cce"), new DateTime(2025, 5, 24, 19, 48, 46, 236, DateTimeKind.Utc).AddTicks(4130), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000011") },
                    { new Guid("24b94413-3062-4740-ae52-3c0863413336"), new DateTime(2025, 5, 24, 19, 48, 46, 236, DateTimeKind.Utc).AddTicks(4120), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000006") },
                    { new Guid("2851c695-95e8-492f-abbe-89a7ea62ce78"), new DateTime(2025, 5, 24, 19, 48, 46, 236, DateTimeKind.Utc).AddTicks(4220), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000030") },
                    { new Guid("2a88f382-2b82-4bc2-888b-8dc28d1dd8eb"), new DateTime(2025, 5, 24, 19, 48, 46, 236, DateTimeKind.Utc).AddTicks(4280), null, new Guid("00000000-0000-0000-0000-000000000003"), null, new Guid("40000000-0000-0000-0000-000000000089") },
                    { new Guid("342b782b-38a6-4a51-bedf-455380c8878c"), new DateTime(2025, 5, 24, 19, 48, 46, 236, DateTimeKind.Utc).AddTicks(4280), null, new Guid("00000000-0000-0000-0000-000000000004"), null, new Guid("40000000-0000-0000-0000-000000000088") },
                    { new Guid("35d9b1f9-b193-4952-b002-0d92bc323eb0"), new DateTime(2025, 5, 24, 19, 48, 46, 236, DateTimeKind.Utc).AddTicks(4250), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000037") },
                    { new Guid("3e777aa2-b92c-4c63-9753-61cc600f1dbf"), new DateTime(2025, 5, 24, 19, 48, 46, 236, DateTimeKind.Utc).AddTicks(4110), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000005") },
                    { new Guid("3e9e052a-b4aa-4213-8415-a5828ef145c7"), new DateTime(2025, 5, 24, 19, 48, 46, 236, DateTimeKind.Utc).AddTicks(4280), null, new Guid("00000000-0000-0000-0000-000000000004"), null, new Guid("40000000-0000-0000-0000-000000000090") },
                    { new Guid("41f249c1-10d2-4750-8d84-c2bb448d4e59"), new DateTime(2025, 5, 24, 19, 48, 46, 236, DateTimeKind.Utc).AddTicks(4150), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000014") },
                    { new Guid("429c0519-0191-48c0-a434-aa66104a3028"), new DateTime(2025, 5, 24, 19, 48, 46, 236, DateTimeKind.Utc).AddTicks(4170), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000016") },
                    { new Guid("47285169-82cd-4a01-b814-a4b2c7fe79a1"), new DateTime(2025, 5, 24, 19, 48, 46, 236, DateTimeKind.Utc).AddTicks(4260), null, new Guid("00000000-0000-0000-0000-000000000004"), null, new Guid("40000000-0000-0000-0000-000000000084") },
                    { new Guid("482f5882-f2cd-48b8-a5eb-359bc40514b8"), new DateTime(2025, 5, 24, 19, 48, 46, 236, DateTimeKind.Utc).AddTicks(4270), null, new Guid("00000000-0000-0000-0000-000000000004"), null, new Guid("40000000-0000-0000-0000-000000000085") },
                    { new Guid("4a190ff1-54a6-4328-8e80-c9043c3d2b5d"), new DateTime(2025, 5, 24, 19, 48, 46, 236, DateTimeKind.Utc).AddTicks(4230), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000031") },
                    { new Guid("4a438305-5393-4142-a0d9-b1438bf87387"), new DateTime(2025, 5, 24, 19, 48, 46, 236, DateTimeKind.Utc).AddTicks(4230), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000033") },
                    { new Guid("522f6698-0ba6-4c1c-8917-a2e7f9f78cdd"), new DateTime(2025, 5, 24, 19, 48, 46, 236, DateTimeKind.Utc).AddTicks(4260), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000039") },
                    { new Guid("5c620bd0-a28e-43f0-be39-b188a35d862a"), new DateTime(2025, 5, 24, 19, 48, 46, 236, DateTimeKind.Utc).AddTicks(4270), null, new Guid("00000000-0000-0000-0000-000000000005"), null, new Guid("40000000-0000-0000-0000-000000000086") },
                    { new Guid("5fb528a7-d613-4347-9af4-d34fd3f00eeb"), new DateTime(2025, 5, 24, 19, 48, 46, 236, DateTimeKind.Utc).AddTicks(4290), null, new Guid("00000000-0000-0000-0000-000000000004"), null, new Guid("40000000-0000-0000-0000-000000000093") },
                    { new Guid("646b7274-b190-4b43-a1f9-b39357b45843"), new DateTime(2025, 5, 24, 19, 48, 46, 236, DateTimeKind.Utc).AddTicks(4210), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000026") },
                    { new Guid("6a2ddd3a-5f45-4968-9dd1-43e41c13217c"), new DateTime(2025, 5, 24, 19, 48, 46, 236, DateTimeKind.Utc).AddTicks(4200), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000025") },
                    { new Guid("6ca87bef-607e-40bd-aeb8-082ee7649f0c"), new DateTime(2025, 5, 24, 19, 48, 46, 236, DateTimeKind.Utc).AddTicks(4140), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000013") },
                    { new Guid("795e8e84-1dc5-4d77-b14c-7bdf87c96c6c"), new DateTime(2025, 5, 24, 19, 48, 46, 236, DateTimeKind.Utc).AddTicks(4220), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000029") },
                    { new Guid("7a27708c-9690-4356-9276-cabfad53e099"), new DateTime(2025, 5, 24, 19, 48, 46, 236, DateTimeKind.Utc).AddTicks(4190), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000021") },
                    { new Guid("7cb3566b-756a-4739-bef5-10bcae56dfb7"), new DateTime(2025, 5, 24, 19, 48, 46, 236, DateTimeKind.Utc).AddTicks(4180), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000019") },
                    { new Guid("7cfcf7ad-f15c-4993-8dc9-02d18f8abb85"), new DateTime(2025, 5, 24, 19, 48, 46, 236, DateTimeKind.Utc).AddTicks(4090), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000001") },
                    { new Guid("8184078f-6bc2-4aae-a4c1-036318daf72a"), new DateTime(2025, 5, 24, 19, 48, 46, 236, DateTimeKind.Utc).AddTicks(4230), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000032") },
                    { new Guid("83281092-8939-45e5-bb47-48bb86ea48c7"), new DateTime(2025, 5, 24, 19, 48, 46, 236, DateTimeKind.Utc).AddTicks(4100), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000002") },
                    { new Guid("8a381204-7787-452b-a5c8-5a3b8c825893"), new DateTime(2025, 5, 24, 19, 48, 46, 236, DateTimeKind.Utc).AddTicks(4100), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000003") },
                    { new Guid("8c764947-2aaa-45c6-b244-70e803b2f601"), new DateTime(2025, 5, 24, 19, 48, 46, 236, DateTimeKind.Utc).AddTicks(4140), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000012") },
                    { new Guid("95092453-8c0d-4493-b1f6-99f624fc4a0b"), new DateTime(2025, 5, 24, 19, 48, 46, 236, DateTimeKind.Utc).AddTicks(4120), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000008") },
                    { new Guid("95f7fe08-e133-420f-92e0-2d2b91990e29"), new DateTime(2025, 5, 24, 19, 48, 46, 236, DateTimeKind.Utc).AddTicks(4200), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000023") },
                    { new Guid("9de8765d-dfd0-40e2-9658-1b02c0c296c6"), new DateTime(2025, 5, 24, 19, 48, 46, 236, DateTimeKind.Utc).AddTicks(4240), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000035") },
                    { new Guid("9f0d21d9-d260-47a2-9eb2-d04a8e0bdd46"), new DateTime(2025, 5, 24, 19, 48, 46, 236, DateTimeKind.Utc).AddTicks(4110), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000004") },
                    { new Guid("a48ad84d-ac8c-47fe-99dc-7d129050ae9e"), new DateTime(2025, 5, 24, 19, 48, 46, 236, DateTimeKind.Utc).AddTicks(4180), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000017") },
                    { new Guid("ac6c9576-853b-4bc5-acd4-38adc40f438c"), new DateTime(2025, 5, 24, 19, 48, 46, 236, DateTimeKind.Utc).AddTicks(4200), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000024") },
                    { new Guid("b4ef5c86-427f-4e1b-84a3-8b00c573c151"), new DateTime(2025, 5, 24, 19, 48, 46, 236, DateTimeKind.Utc).AddTicks(4290), null, new Guid("00000000-0000-0000-0000-000000000003"), null, new Guid("40000000-0000-0000-0000-000000000091") },
                    { new Guid("bd8f3747-fc50-45e8-b771-b9b0a6ad2530"), new DateTime(2025, 5, 24, 19, 48, 46, 236, DateTimeKind.Utc).AddTicks(4170), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000015") },
                    { new Guid("c061f6a8-4698-4fb5-8b5f-01554a02d589"), new DateTime(2025, 5, 24, 19, 48, 46, 236, DateTimeKind.Utc).AddTicks(4180), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000018") },
                    { new Guid("c857396b-d92a-4bc8-b599-2adcd5496741"), new DateTime(2025, 5, 24, 19, 48, 46, 236, DateTimeKind.Utc).AddTicks(4240), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000034") },
                    { new Guid("cf8a5ffa-c632-4a27-b8c7-a90f654fd570"), new DateTime(2025, 5, 24, 19, 48, 46, 236, DateTimeKind.Utc).AddTicks(4270), null, new Guid("00000000-0000-0000-0000-000000000006"), null, new Guid("40000000-0000-0000-0000-000000000087") },
                    { new Guid("d044e1cf-0ba8-4939-9591-5b5cfafdf363"), new DateTime(2025, 5, 24, 19, 48, 46, 236, DateTimeKind.Utc).AddTicks(4240), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000036") },
                    { new Guid("d2b19d73-3207-45c2-b5fe-ab3e531e3b81"), new DateTime(2025, 5, 24, 19, 48, 46, 236, DateTimeKind.Utc).AddTicks(4130), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000009") },
                    { new Guid("d96756c5-ccd8-4414-968d-4a67f2eff231"), new DateTime(2025, 5, 24, 19, 48, 46, 236, DateTimeKind.Utc).AddTicks(4260), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000040") },
                    { new Guid("f1cb18ba-20ee-497f-acc5-fc66e54d0a0e"), new DateTime(2025, 5, 24, 19, 48, 46, 236, DateTimeKind.Utc).AddTicks(4250), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000038") },
                    { new Guid("f82db4e9-5865-4895-b6ae-8ba536f97c16"), new DateTime(2025, 5, 24, 19, 48, 46, 236, DateTimeKind.Utc).AddTicks(4120), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000007") },
                    { new Guid("fc260b22-f4a9-4434-81f8-db73f4e295b0"), new DateTime(2025, 5, 24, 19, 48, 46, 236, DateTimeKind.Utc).AddTicks(4190), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000020") }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-11111111111a"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 253, 176, 149, 244, 249, 89, 71, 25, 106, 146, 151, 137, 235, 94, 127, 71, 108, 216, 81, 128, 75, 224, 87, 200, 102, 4, 200, 30, 111, 137, 94, 50, 160, 184, 133, 236, 43, 30, 180, 235, 212, 136, 25, 83, 59, 129, 131, 168, 109, 152, 107, 157, 151, 50, 159, 118, 90, 181, 20, 167, 180, 195, 185, 192 }, new byte[] { 249, 50, 214, 29, 157, 46, 153, 57, 199, 109, 43, 50, 77, 161, 136, 186, 16, 192, 186, 154, 250, 129, 119, 177, 127, 69, 192, 186, 129, 245, 183, 148, 226, 3, 51, 169, 75, 176, 19, 94, 87, 225, 29, 90, 171, 163, 158, 169, 81, 85, 179, 117, 47, 98, 9, 106, 229, 237, 233, 56, 66, 166, 66, 4, 129, 182, 66, 122, 128, 46, 151, 91, 194, 122, 38, 220, 236, 119, 210, 53, 2, 228, 14, 168, 180, 30, 49, 70, 178, 224, 138, 125, 125, 52, 42, 180, 11, 178, 8, 190, 110, 160, 227, 139, 34, 59, 200, 0, 167, 131, 130, 158, 77, 233, 209, 74, 169, 109, 204, 105, 97, 179, 140, 140, 14, 46, 164, 32 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-22222222222a"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 231, 69, 224, 137, 37, 124, 139, 30, 134, 30, 232, 254, 228, 205, 190, 13, 17, 115, 225, 5, 113, 152, 26, 110, 216, 173, 186, 11, 79, 113, 25, 45, 237, 5, 242, 25, 148, 203, 6, 56, 204, 246, 224, 58, 116, 104, 70, 32, 111, 164, 8, 141, 16, 57, 9, 39, 56, 101, 58, 78, 48, 28, 129, 91 }, new byte[] { 164, 46, 245, 112, 255, 237, 94, 219, 185, 213, 69, 57, 73, 79, 115, 157, 45, 244, 11, 234, 216, 10, 172, 131, 179, 39, 203, 239, 152, 13, 186, 25, 228, 133, 231, 108, 52, 34, 98, 29, 235, 232, 17, 186, 115, 55, 85, 241, 144, 206, 159, 168, 139, 197, 104, 63, 64, 121, 186, 208, 10, 148, 157, 58, 195, 189, 0, 15, 242, 158, 114, 243, 79, 107, 160, 236, 207, 195, 197, 190, 59, 166, 0, 116, 219, 237, 17, 112, 241, 41, 179, 15, 228, 8, 36, 125, 166, 106, 187, 150, 47, 210, 101, 60, 25, 11, 149, 95, 112, 185, 88, 86, 143, 93, 239, 109, 101, 252, 98, 211, 1, 115, 231, 221, 93, 186, 101, 208 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-33333333333a"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 122, 153, 68, 220, 227, 52, 130, 77, 48, 13, 201, 156, 166, 127, 158, 104, 86, 113, 182, 201, 150, 218, 74, 133, 163, 103, 26, 215, 93, 82, 71, 171, 68, 246, 166, 151, 44, 175, 15, 191, 16, 240, 255, 169, 195, 24, 113, 74, 22, 201, 251, 121, 52, 106, 56, 228, 193, 173, 126, 157, 129, 81, 239, 43 }, new byte[] { 141, 199, 9, 24, 81, 120, 148, 215, 46, 141, 217, 45, 90, 9, 241, 109, 91, 249, 16, 107, 88, 170, 132, 182, 98, 20, 14, 48, 40, 213, 227, 102, 7, 111, 35, 217, 22, 90, 210, 203, 16, 238, 61, 115, 80, 29, 124, 176, 199, 125, 106, 169, 245, 106, 231, 107, 100, 201, 235, 130, 11, 144, 118, 13, 21, 111, 185, 176, 54, 191, 170, 80, 84, 214, 104, 252, 171, 28, 134, 138, 105, 86, 127, 67, 252, 46, 190, 3, 176, 163, 238, 198, 53, 182, 12, 43, 85, 152, 52, 243, 34, 228, 222, 184, 77, 203, 183, 19, 26, 115, 240, 40, 132, 234, 161, 31, 223, 32, 70, 171, 41, 160, 112, 97, 81, 192, 102, 103 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000001"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000002"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000003"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000004"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000005"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000006"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000007"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000008"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000009"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000010"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000011"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000012"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000013"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000014"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000015"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000016"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000017"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000018"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000019"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000020"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000021"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000022"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000023"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000024"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000025"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000026"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000027"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000028"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000029"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000030"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000031"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000032"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000033"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000034"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000035"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000036"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000037"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000038"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000039"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000040"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000041"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000042"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000043"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000044"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000045"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000046"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000047"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000048"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000049"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000050"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000051"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000052"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000053"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000054"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000055"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000056"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000057"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000058"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000059"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000060"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000061"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000062"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000063"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000064"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000065"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000066"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000067"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000068"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000069"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000070"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000071"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000072"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000073"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000074"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000075"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000076"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000077"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000078"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000079"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000080"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000081"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000082"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000083"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000084"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000085"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000086"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000087"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000088"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000089"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000090"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000091"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000092"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000093"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-44444444444a"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 168, 104, 46, 124, 247, 71, 9, 86, 253, 225, 51, 93, 117, 183, 87, 118, 61, 79, 125, 221, 41, 58, 77, 73, 210, 71, 169, 190, 254, 75, 149, 204, 10, 137, 125, 95, 31, 140, 240, 210, 3, 130, 169, 171, 147, 44, 110, 59, 12, 77, 72, 163, 233, 7, 26, 42, 196, 89, 247, 224, 80, 0, 236, 232 }, new byte[] { 46, 233, 208, 17, 232, 59, 175, 23, 204, 178, 19, 45, 127, 75, 222, 179, 242, 190, 132, 132, 98, 114, 128, 140, 147, 7, 70, 43, 101, 181, 57, 129, 6, 15, 198, 150, 205, 255, 130, 184, 205, 153, 65, 213, 177, 214, 111, 223, 251, 171, 53, 159, 102, 247, 18, 111, 59, 208, 54, 217, 16, 15, 83, 247, 190, 41, 164, 222, 214, 132, 170, 253, 61, 203, 177, 103, 15, 109, 66, 70, 22, 20, 169, 28, 210, 41, 255, 134, 57, 240, 216, 182, 25, 240, 151, 47, 148, 254, 5, 6, 182, 145, 90, 160, 75, 105, 203, 63, 214, 195, 164, 214, 70, 169, 4, 165, 141, 90, 74, 252, 86, 252, 254, 158, 240, 253, 243, 28 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-55555555555a"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 185, 37, 227, 138, 243, 37, 64, 62, 161, 125, 146, 221, 82, 166, 247, 189, 95, 45, 242, 45, 221, 226, 170, 167, 215, 224, 112, 85, 93, 234, 20, 28, 75, 101, 4, 255, 35, 240, 53, 205, 83, 107, 194, 188, 131, 91, 3, 78, 141, 124, 63, 192, 31, 114, 42, 107, 169, 176, 135, 84, 192, 14, 67, 159 }, new byte[] { 102, 145, 228, 24, 142, 69, 99, 94, 25, 217, 52, 195, 236, 137, 52, 152, 141, 184, 171, 171, 238, 90, 19, 128, 32, 22, 209, 46, 218, 88, 250, 55, 66, 181, 38, 119, 182, 223, 152, 80, 68, 209, 209, 99, 170, 2, 144, 122, 101, 223, 193, 159, 61, 148, 55, 156, 46, 74, 133, 20, 55, 157, 230, 159, 133, 194, 153, 41, 22, 177, 204, 15, 140, 134, 196, 2, 106, 184, 106, 119, 209, 46, 164, 222, 143, 173, 46, 73, 96, 183, 175, 237, 18, 217, 118, 125, 253, 186, 125, 225, 27, 166, 73, 41, 214, 205, 225, 222, 217, 27, 20, 139, 222, 58, 253, 151, 181, 53, 238, 239, 29, 180, 99, 200, 23, 215, 69, 164 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-66666666666a"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 254, 250, 42, 238, 197, 11, 45, 166, 98, 161, 125, 16, 50, 135, 88, 36, 179, 95, 17, 165, 165, 54, 233, 91, 248, 21, 251, 121, 220, 125, 250, 36, 147, 32, 232, 139, 90, 238, 11, 96, 34, 101, 58, 140, 23, 214, 4, 239, 163, 155, 175, 205, 65, 181, 250, 133, 235, 215, 124, 8, 209, 197, 130, 19 }, new byte[] { 113, 122, 136, 216, 45, 179, 148, 158, 173, 42, 195, 99, 239, 161, 121, 35, 233, 229, 89, 197, 153, 179, 235, 21, 20, 104, 22, 160, 36, 0, 94, 8, 118, 217, 207, 200, 38, 166, 250, 184, 64, 112, 187, 81, 58, 32, 95, 90, 190, 137, 243, 63, 150, 176, 87, 218, 147, 222, 72, 61, 21, 161, 224, 116, 196, 214, 210, 185, 223, 209, 7, 64, 82, 56, 135, 111, 195, 222, 53, 236, 81, 123, 111, 182, 101, 231, 138, 98, 218, 139, 150, 37, 159, 201, 13, 214, 150, 61, 136, 49, 65, 70, 231, 34, 198, 81, 4, 45, 58, 18, 193, 233, 122, 63, 249, 98, 55, 8, 139, 104, 250, 142, 17, 73, 176, 49, 58, 218 } });
        }
    }
}
