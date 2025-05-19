using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class init332 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TranscriptDatas_FileAttachments_SourceFileAttachmentId",
                table: "TranscriptDatas");

            migrationBuilder.DropIndex(
                name: "IX_TranscriptDatas_SourceFileAttachmentId",
                table: "TranscriptDatas");

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("00a8e380-0784-4161-9c6b-c7f4bf2b5812"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("0d538fe7-2138-41c8-ac0f-cafeac2b457a"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("14ddcbde-efbc-4484-8a53-da0ac6de7382"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("161b3248-5457-4a65-bdd6-a4c73d84ed24"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("207a6718-42b2-49be-b077-e7f13654a2e0"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("22138332-8af8-4f2a-921b-08d7b6e08276"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("2b9c988e-a180-4b9a-8257-17745101ff22"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("2e202f4e-791a-49a7-a3a1-951abebedde3"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("315e8219-1bea-4d4e-957f-ff8feb4207af"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("362f230a-140c-40f2-b70a-471c5832f6a0"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("394f81e4-fa7c-42f6-b794-a9dbbbf84773"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("3a5fb049-9b84-4c8a-9e42-f012b2780515"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("3d12c4d2-0624-4694-92bc-65df6bba9a8a"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("3fbb46cf-503e-4118-8a3b-18dc728662a5"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("561eae80-a1dd-40a1-b653-564794706097"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("5ae8e903-b9d6-4dc6-9ac2-c61e8d678c97"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("5d5815a7-e868-463d-b8cc-fb761617e172"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("657f8cd5-0101-44f1-a431-4ad82c7be4d5"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("6e2173f7-e1c5-4047-b181-585fe9ede51b"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("7f5dffd6-8240-453c-a0a6-97f92e200a4f"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("83183995-9ed2-45da-ac4e-70dbf1464c09"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("83f6e832-95d9-4829-91f3-6db15b924e4e"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("8640fae5-ec8c-4099-934e-2aab5a0da027"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("866ac58f-40c4-4d97-a24f-4be73803d792"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("8729e819-bdff-44ea-8a7d-c97bfe70ce44"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("8a30d6fe-7684-42d3-b6bb-5b72be60c20f"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("9540d197-59ef-4fe7-9e03-56e0d0b75868"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("9e912019-841f-4607-a381-3069a8eb0cd2"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("9f112cfe-183a-4450-b818-a8204a709424"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("a363217d-5606-4456-9abd-de9696de7ed2"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("a5b4d40c-5b2b-467a-a335-edf2999443fe"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("a70d3679-533d-4ec7-9755-e62f466ca777"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("a79249e2-a2de-4e29-aebe-058002bd2827"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("aca7b8f7-260e-49c5-a889-d9a16e44a7e6"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("b394b56f-9c21-4b18-845f-7692163fa8c8"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("bf897ac2-5ecd-48c9-8ab7-b9aec7bb0640"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("c200d32b-1165-4a34-88c8-7ee20eecacdd"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("c379c319-a5f5-46c7-b1e3-9d2105c3a755"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("c42fc6f9-deff-4fd7-80c0-e3e0790b41cd"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("ca8d4a29-a9a0-4cb2-bb3f-1eb260978c7b"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("cba642e5-5f07-46d9-954b-436b934ea7d5"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("ccd1833b-70eb-4811-8d83-5de1179c9090"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("d4e8f068-0a9c-4e92-b993-1eb36d52d77c"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("d6214e85-39b5-4e49-a1d1-f110ade0413b"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("e8a8bb91-eb00-4728-8609-b964ab9cb0d9"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("eb200b6e-8ded-4632-9946-4d6b650c11d1"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("f43b6f6f-8e0f-4560-b89b-209803e15725"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("f66ea9c5-cc96-42e7-b97e-2e622d2a7bbd"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("f749eb0a-d870-4637-83e7-c137f77f9be3"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("fbb112ef-3787-4572-b222-b0aa25d3e33b"));

            migrationBuilder.DropColumn(
                name: "SourceFileAttachmentId",
                table: "TranscriptDatas");

            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "GraduationRequirementSets");

            migrationBuilder.DropColumn(
                name: "LastModificationDate",
                table: "GraduationRequirementSets");

            migrationBuilder.AddColumn<string>(
                name: "AcademicTerm",
                table: "GraduationRequirementSets",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "TranscriptDataId",
                table: "FileAttachments",
                type: "uuid",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000001"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3380));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000002"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3390));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000003"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3390));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000004"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3390));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000005"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3400));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000006"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3400));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000007"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3400));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000008"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3400));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000009"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3410));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000010"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3410));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000011"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3410));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000012"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3420));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000013"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3420));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000014"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3420));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000015"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3420));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000016"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3430));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000017"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3430));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000018"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3430));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000019"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3430));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000020"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3440));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000021"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3440));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000022"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3450));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000023"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3450));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000024"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3450));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000025"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3450));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000026"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3460));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000027"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3460));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000028"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3460));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000029"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3460));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000030"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3510));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000031"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3510));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000032"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3510));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000033"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3520));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000034"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3520));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000035"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3520));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000036"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3520));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000037"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3530));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000038"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3530));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000039"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3530));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000040"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3530));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000041"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3540));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000042"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3540));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000043"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3540));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000044"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3540));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000045"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3550));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000046"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3550));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000047"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3550));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000048"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3550));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000049"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3560));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000050"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3560));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000051"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3560));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000052"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3560));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000053"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3570));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000054"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3570));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000055"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3570));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000056"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3570));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000057"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3580));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000058"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3580));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000059"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3580));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000060"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3580));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000061"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3590));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000062"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3600));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000063"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3600));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000064"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3600));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000065"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3600));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000066"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3610));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000067"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3610));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000068"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3610));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000069"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3610));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000070"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3620));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000071"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3620));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000072"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3620));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000073"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3620));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000074"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3630));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000075"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3630));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000076"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3630));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000077"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3630));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000078"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3640));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000079"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3640));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000080"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3640));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000081"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3640));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000082"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3650));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000083"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3650));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000084"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3650));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000085"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3650));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000086"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3660));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000087"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3660));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000088"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3660));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000089"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3660));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000090"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3670));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000091"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3680));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000092"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3680));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000093"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3680));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000094"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3680));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000095"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3690));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000096"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3690));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000097"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3690));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000098"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3690));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000099"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3700));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000100"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3700));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000101"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3700));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000102"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3700));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000103"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3710));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000104"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3710));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000105"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3710));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000106"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3710));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000107"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3720));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000108"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3720));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000109"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3720));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000110"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3720));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000111"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3730));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000112"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3730));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000113"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3730));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000114"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3730));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000115"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3740));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000116"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3740));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000117"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3740));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000118"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3740));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000119"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3750));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000120"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3750));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000121"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3750));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000122"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3760));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000123"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3760));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000124"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3760));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000125"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3770));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000126"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3770));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000127"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3770));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000128"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3770));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000129"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3780));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000130"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3780));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000131"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3780));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000132"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3780));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000133"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3790));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000134"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3790));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000135"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3790));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000136"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3790));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000137"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3800));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000138"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3800));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000139"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3800));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000140"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3810));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000141"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3810));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000142"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3810));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000143"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3810));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000144"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3820));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000145"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3820));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000146"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3820));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000147"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3820));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000148"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3830));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000149"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3830));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000150"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3830));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000151"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3830));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000152"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3830));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000153"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3840));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000154"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3840));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000155"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3840));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000156"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3850));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000157"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3850));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000001"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(2710));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000002"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(2720));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000003"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(2720));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000004"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(2720));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000005"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(2720));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000006"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(2730));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000007"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(2730));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000008"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(2730));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000009"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(2730));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000010"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(2730));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000011"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(2740));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000012"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(2740));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000013"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(2740));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000014"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(2740));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000015"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(2740));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000016"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(2750));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000017"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(2750));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000018"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(2750));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000019"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(2750));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000020"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(2760));

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(2630));

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(2670));

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(2670));

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(2670));

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000005"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(2680));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000001"),
                column: "EnrollDate",
                value: new DateTime(2020, 9, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3170));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000002"),
                column: "EnrollDate",
                value: new DateTime(2024, 1, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3180));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000003"),
                column: "EnrollDate",
                value: new DateTime(2023, 4, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3190));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000004"),
                column: "EnrollDate",
                value: new DateTime(2023, 2, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3190));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000005"),
                column: "EnrollDate",
                value: new DateTime(2021, 6, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3190));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000006"),
                column: "EnrollDate",
                value: new DateTime(2021, 2, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3190));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000007"),
                column: "EnrollDate",
                value: new DateTime(2021, 4, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3200));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000008"),
                column: "EnrollDate",
                value: new DateTime(2024, 2, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3200));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000009"),
                column: "EnrollDate",
                value: new DateTime(2023, 8, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3200));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000010"),
                column: "EnrollDate",
                value: new DateTime(2022, 11, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3200));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000011"),
                column: "EnrollDate",
                value: new DateTime(2023, 6, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3200));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000012"),
                column: "EnrollDate",
                value: new DateTime(2024, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3210));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000013"),
                column: "EnrollDate",
                value: new DateTime(2020, 10, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3210));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000014"),
                column: "EnrollDate",
                value: new DateTime(2021, 6, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3210));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000015"),
                column: "EnrollDate",
                value: new DateTime(2024, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3210));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000016"),
                column: "EnrollDate",
                value: new DateTime(2022, 4, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3210));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000017"),
                column: "EnrollDate",
                value: new DateTime(2023, 9, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3220));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000018"),
                column: "EnrollDate",
                value: new DateTime(2021, 5, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3220));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000019"),
                column: "EnrollDate",
                value: new DateTime(2020, 12, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3220));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000020"),
                column: "EnrollDate",
                value: new DateTime(2020, 12, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3220));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000021"),
                column: "EnrollDate",
                value: new DateTime(2020, 7, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3230));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000022"),
                column: "EnrollDate",
                value: new DateTime(2021, 7, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3230));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000023"),
                column: "EnrollDate",
                value: new DateTime(2021, 11, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3230));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000024"),
                column: "EnrollDate",
                value: new DateTime(2023, 10, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3230));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000025"),
                column: "EnrollDate",
                value: new DateTime(2023, 12, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3230));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000026"),
                column: "EnrollDate",
                value: new DateTime(2020, 7, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3240));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000027"),
                column: "EnrollDate",
                value: new DateTime(2021, 2, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3240));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000028"),
                column: "EnrollDate",
                value: new DateTime(2023, 7, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3240));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000029"),
                column: "EnrollDate",
                value: new DateTime(2020, 11, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3240));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000030"),
                column: "EnrollDate",
                value: new DateTime(2021, 6, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3250));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000031"),
                column: "EnrollDate",
                value: new DateTime(2021, 10, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3250));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000032"),
                column: "EnrollDate",
                value: new DateTime(2020, 12, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3250));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000033"),
                column: "EnrollDate",
                value: new DateTime(2023, 4, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3250));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000034"),
                column: "EnrollDate",
                value: new DateTime(2022, 2, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3260));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000035"),
                column: "EnrollDate",
                value: new DateTime(2023, 11, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3260));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000036"),
                column: "EnrollDate",
                value: new DateTime(2021, 7, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3260));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000037"),
                column: "EnrollDate",
                value: new DateTime(2020, 9, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3260));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000038"),
                column: "EnrollDate",
                value: new DateTime(2024, 1, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3260));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000039"),
                column: "EnrollDate",
                value: new DateTime(2022, 12, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3270));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000040"),
                column: "EnrollDate",
                value: new DateTime(2022, 7, 19, 23, 25, 13, 39, DateTimeKind.Utc).AddTicks(3270));

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { new Guid("050d01d2-00e5-4709-b552-66fc316968ce"), new DateTime(2025, 5, 19, 20, 25, 13, 39, DateTimeKind.Utc).AddTicks(1370), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000028") },
                    { new Guid("0aef782a-212f-4880-9f7c-e394483a1891"), new DateTime(2025, 5, 19, 20, 25, 13, 39, DateTimeKind.Utc).AddTicks(1280), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000004") },
                    { new Guid("11f59b39-3492-4778-a7a4-963926b3174c"), new DateTime(2025, 5, 19, 20, 25, 13, 39, DateTimeKind.Utc).AddTicks(1390), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000031") },
                    { new Guid("1371e713-1e37-44f9-86a9-35be0fe256a1"), new DateTime(2025, 5, 19, 20, 25, 13, 39, DateTimeKind.Utc).AddTicks(1330), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000016") },
                    { new Guid("13df70f9-4a5a-495e-a9a2-c3cc429041b5"), new DateTime(2025, 5, 19, 20, 25, 13, 39, DateTimeKind.Utc).AddTicks(1330), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000018") },
                    { new Guid("1406423d-2788-4d18-8a46-bab6e39a0341"), new DateTime(2025, 5, 19, 20, 25, 13, 39, DateTimeKind.Utc).AddTicks(1430), null, new Guid("00000000-0000-0000-0000-000000000006"), null, new Guid("40000000-0000-0000-0000-000000000044") },
                    { new Guid("2664ac79-a25d-436e-96ff-5f7677cf3f87"), new DateTime(2025, 5, 19, 20, 25, 13, 39, DateTimeKind.Utc).AddTicks(1360), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000024") },
                    { new Guid("27381cdc-f3fc-4683-9f8d-aaac6e7359d3"), new DateTime(2025, 5, 19, 20, 25, 13, 39, DateTimeKind.Utc).AddTicks(1420), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000040") },
                    { new Guid("293bf890-19b9-41a3-8a2a-d4921ffe5b3e"), new DateTime(2025, 5, 19, 20, 25, 13, 39, DateTimeKind.Utc).AddTicks(1370), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000027") },
                    { new Guid("2faaf5fa-c30b-4a46-9f62-c55b48502c05"), new DateTime(2025, 5, 19, 20, 25, 13, 39, DateTimeKind.Utc).AddTicks(1410), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000038") },
                    { new Guid("308e74c2-3a92-4a3d-ad99-b6a353bc3193"), new DateTime(2025, 5, 19, 20, 25, 13, 39, DateTimeKind.Utc).AddTicks(1280), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000006") },
                    { new Guid("35ce5818-f2b9-4538-b91c-6dca8033bf56"), new DateTime(2025, 5, 19, 20, 25, 13, 39, DateTimeKind.Utc).AddTicks(1340), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000020") },
                    { new Guid("43079861-4acb-4bf9-bac1-98b67a96bd98"), new DateTime(2025, 5, 19, 20, 25, 13, 39, DateTimeKind.Utc).AddTicks(1260), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000001") },
                    { new Guid("45f6b574-1ea3-4350-b6f5-b3b7ab6c68a6"), new DateTime(2025, 5, 19, 20, 25, 13, 39, DateTimeKind.Utc).AddTicks(1400), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000036") },
                    { new Guid("47d31d97-81e3-4d67-b584-83c28497641c"), new DateTime(2025, 5, 19, 20, 25, 13, 39, DateTimeKind.Utc).AddTicks(1350), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000023") },
                    { new Guid("483f4b01-6391-456d-975b-472d910e7d56"), new DateTime(2025, 5, 19, 20, 25, 13, 39, DateTimeKind.Utc).AddTicks(1330), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000017") },
                    { new Guid("4b8f9331-36da-4daa-90fa-9bc70b6f3a13"), new DateTime(2025, 5, 19, 20, 25, 13, 39, DateTimeKind.Utc).AddTicks(1290), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000008") },
                    { new Guid("4d97eaaa-ffd9-4f76-b1b3-8bb60385d3c3"), new DateTime(2025, 5, 19, 20, 25, 13, 39, DateTimeKind.Utc).AddTicks(1280), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000005") },
                    { new Guid("505fae94-5ab0-4034-bdc6-a53a1f5e9576"), new DateTime(2025, 5, 19, 20, 25, 13, 39, DateTimeKind.Utc).AddTicks(1350), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000022") },
                    { new Guid("50b7f8c8-a66d-4e14-8ea6-fe89684e7f6a"), new DateTime(2025, 5, 19, 20, 25, 13, 39, DateTimeKind.Utc).AddTicks(1350), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000021") },
                    { new Guid("58755760-5c7c-425d-9743-f339fa06bb71"), new DateTime(2025, 5, 19, 20, 25, 13, 39, DateTimeKind.Utc).AddTicks(1420), null, new Guid("00000000-0000-0000-0000-000000000004"), null, new Guid("40000000-0000-0000-0000-000000000041") },
                    { new Guid("59cff48c-b703-4dbc-9210-8b1801baf76e"), new DateTime(2025, 5, 19, 20, 25, 13, 39, DateTimeKind.Utc).AddTicks(1310), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000013") },
                    { new Guid("63a4f5ff-e02f-440d-9908-b0c8b7dcf78a"), new DateTime(2025, 5, 19, 20, 25, 13, 39, DateTimeKind.Utc).AddTicks(1360), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000025") },
                    { new Guid("6c57f9b1-3874-424b-a751-ed6fad656917"), new DateTime(2025, 5, 19, 20, 25, 13, 39, DateTimeKind.Utc).AddTicks(1400), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000035") },
                    { new Guid("6c88a122-439f-473b-92ea-dda9a3ca2b0c"), new DateTime(2025, 5, 19, 20, 25, 13, 39, DateTimeKind.Utc).AddTicks(1270), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000002") },
                    { new Guid("77f4cc1f-ff26-4cfd-8ffe-6784e34c052f"), new DateTime(2025, 5, 19, 20, 25, 13, 39, DateTimeKind.Utc).AddTicks(1340), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000019") },
                    { new Guid("7c031eb6-8513-4798-8ab6-3dbd7125401d"), new DateTime(2025, 5, 19, 20, 25, 13, 39, DateTimeKind.Utc).AddTicks(1400), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000034") },
                    { new Guid("7d9e66ab-ea84-4469-85a7-40c93bdb54cb"), new DateTime(2025, 5, 19, 20, 25, 13, 39, DateTimeKind.Utc).AddTicks(1450), null, new Guid("00000000-0000-0000-0000-000000000003"), null, new Guid("40000000-0000-0000-0000-000000000048") },
                    { new Guid("81c8e5a5-e00c-4488-96c5-54e866cd7601"), new DateTime(2025, 5, 19, 20, 25, 13, 39, DateTimeKind.Utc).AddTicks(1440), null, new Guid("00000000-0000-0000-0000-000000000004"), null, new Guid("40000000-0000-0000-0000-000000000047") },
                    { new Guid("89a675fe-baf0-458c-a7f3-971d8841f86b"), new DateTime(2025, 5, 19, 20, 25, 13, 39, DateTimeKind.Utc).AddTicks(1300), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000010") },
                    { new Guid("a9d51763-4007-465b-b2a8-cd99a8c219f5"), new DateTime(2025, 5, 19, 20, 25, 13, 39, DateTimeKind.Utc).AddTicks(1270), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000003") },
                    { new Guid("b4afb151-4bcd-4860-894d-523a4caa65d7"), new DateTime(2025, 5, 19, 20, 25, 13, 39, DateTimeKind.Utc).AddTicks(1310), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000012") },
                    { new Guid("bd2d581c-13ad-4600-9c40-b9c00a6e1394"), new DateTime(2025, 5, 19, 20, 25, 13, 39, DateTimeKind.Utc).AddTicks(1450), null, new Guid("00000000-0000-0000-0000-000000000004"), null, new Guid("40000000-0000-0000-0000-000000000050") },
                    { new Guid("bfdf011d-2e12-4e6a-960a-cf2b0e4e0685"), new DateTime(2025, 5, 19, 20, 25, 13, 39, DateTimeKind.Utc).AddTicks(1410), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000037") },
                    { new Guid("c3c70585-9dba-468c-bebc-97021fd3e3ad"), new DateTime(2025, 5, 19, 20, 25, 13, 39, DateTimeKind.Utc).AddTicks(1320), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000014") },
                    { new Guid("c49e4a6d-1f5d-4d09-abe6-f7090a6e8c0c"), new DateTime(2025, 5, 19, 20, 25, 13, 39, DateTimeKind.Utc).AddTicks(1290), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000007") },
                    { new Guid("c5e16f3b-2edb-4872-88b3-009fac97a259"), new DateTime(2025, 5, 19, 20, 25, 13, 39, DateTimeKind.Utc).AddTicks(1440), null, new Guid("00000000-0000-0000-0000-000000000003"), null, new Guid("40000000-0000-0000-0000-000000000046") },
                    { new Guid("c827babd-a3a2-4f44-9b98-0526a1100d9c"), new DateTime(2025, 5, 19, 20, 25, 13, 39, DateTimeKind.Utc).AddTicks(1320), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000015") },
                    { new Guid("cd1d6e86-4ea9-43dc-a3ad-c63e3c8f45e2"), new DateTime(2025, 5, 19, 20, 25, 13, 39, DateTimeKind.Utc).AddTicks(1380), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000030") },
                    { new Guid("cee75c8c-c381-4bea-9495-04087850c8e7"), new DateTime(2025, 5, 19, 20, 25, 13, 39, DateTimeKind.Utc).AddTicks(1450), null, new Guid("00000000-0000-0000-0000-000000000003"), null, new Guid("40000000-0000-0000-0000-000000000049") },
                    { new Guid("d02b19ce-21bd-414c-af6c-59ad4241f503"), new DateTime(2025, 5, 19, 20, 25, 13, 39, DateTimeKind.Utc).AddTicks(1300), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000011") },
                    { new Guid("d06914d2-b6ca-4002-b0d2-a6d195053404"), new DateTime(2025, 5, 19, 20, 25, 13, 39, DateTimeKind.Utc).AddTicks(1380), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000029") },
                    { new Guid("d4f7ebca-43ee-4d0e-b34b-0773f8364525"), new DateTime(2025, 5, 19, 20, 25, 13, 39, DateTimeKind.Utc).AddTicks(1390), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000032") },
                    { new Guid("d7cb460d-a330-4cff-b338-9cfb1f47c63f"), new DateTime(2025, 5, 19, 20, 25, 13, 39, DateTimeKind.Utc).AddTicks(1430), null, new Guid("00000000-0000-0000-0000-000000000005"), null, new Guid("40000000-0000-0000-0000-000000000043") },
                    { new Guid("e3a52061-57e6-487b-be12-e5d40d313cf1"), new DateTime(2025, 5, 19, 20, 25, 13, 39, DateTimeKind.Utc).AddTicks(1300), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000009") },
                    { new Guid("e3d110bd-1951-4db3-a201-c6e2fabe9d8c"), new DateTime(2025, 5, 19, 20, 25, 13, 39, DateTimeKind.Utc).AddTicks(1390), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000033") },
                    { new Guid("e74ba1d6-5eea-424c-a1b1-d46e4c8cfde7"), new DateTime(2025, 5, 19, 20, 25, 13, 39, DateTimeKind.Utc).AddTicks(1420), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000039") },
                    { new Guid("efc08299-efd8-4593-baaf-b844435de7c6"), new DateTime(2025, 5, 19, 20, 25, 13, 39, DateTimeKind.Utc).AddTicks(1370), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000026") },
                    { new Guid("f1b9d626-4b04-4037-a804-3541cccbc39f"), new DateTime(2025, 5, 19, 20, 25, 13, 39, DateTimeKind.Utc).AddTicks(1430), null, new Guid("00000000-0000-0000-0000-000000000004"), null, new Guid("40000000-0000-0000-0000-000000000042") },
                    { new Guid("f92f4643-b5ae-450e-b09c-73660d807260"), new DateTime(2025, 5, 19, 20, 25, 13, 39, DateTimeKind.Utc).AddTicks(1440), null, new Guid("00000000-0000-0000-0000-000000000004"), null, new Guid("40000000-0000-0000-0000-000000000045") }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-11111111111a"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 43, 20, 251, 160, 236, 203, 84, 28, 4, 172, 112, 201, 229, 43, 10, 212, 36, 139, 38, 185, 30, 166, 153, 42, 232, 236, 247, 92, 250, 185, 139, 145, 127, 244, 189, 206, 221, 160, 100, 221, 30, 220, 187, 130, 179, 124, 29, 95, 110, 183, 104, 61, 120, 37, 3, 50, 161, 125, 18, 214, 124, 151, 167, 216 }, new byte[] { 203, 69, 4, 240, 139, 13, 42, 224, 247, 110, 251, 156, 96, 219, 93, 184, 240, 112, 43, 207, 226, 155, 118, 103, 176, 166, 80, 150, 222, 100, 93, 226, 125, 177, 12, 20, 162, 246, 149, 184, 21, 60, 182, 181, 105, 163, 199, 148, 237, 152, 180, 166, 219, 201, 206, 66, 20, 137, 20, 51, 43, 5, 70, 207, 47, 245, 173, 145, 77, 33, 182, 197, 49, 52, 151, 82, 219, 228, 48, 194, 59, 57, 33, 182, 182, 116, 151, 218, 57, 110, 103, 212, 210, 83, 85, 232, 67, 89, 221, 237, 235, 142, 227, 225, 14, 57, 254, 100, 124, 217, 84, 208, 59, 210, 230, 126, 78, 239, 169, 37, 83, 41, 55, 132, 22, 91, 200, 166 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-22222222222a"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 199, 235, 255, 9, 30, 225, 246, 67, 66, 162, 155, 51, 165, 253, 104, 199, 159, 150, 212, 110, 110, 46, 128, 4, 183, 5, 165, 182, 119, 247, 166, 163, 128, 206, 81, 127, 79, 205, 62, 93, 247, 227, 42, 107, 13, 26, 112, 218, 226, 211, 44, 13, 126, 201, 124, 170, 198, 51, 77, 172, 150, 254, 124, 177 }, new byte[] { 105, 124, 119, 131, 169, 225, 115, 220, 57, 214, 140, 14, 236, 103, 195, 248, 141, 132, 228, 51, 211, 15, 110, 75, 180, 1, 24, 205, 36, 143, 59, 222, 158, 112, 244, 66, 127, 219, 240, 146, 215, 67, 67, 3, 111, 110, 92, 144, 194, 201, 164, 120, 252, 181, 153, 126, 20, 192, 83, 56, 111, 48, 241, 187, 77, 155, 191, 21, 97, 51, 173, 94, 33, 24, 15, 170, 146, 214, 74, 192, 68, 148, 138, 162, 205, 11, 191, 159, 248, 203, 238, 46, 45, 131, 47, 34, 25, 61, 201, 30, 168, 153, 215, 0, 17, 1, 153, 223, 5, 148, 255, 96, 220, 184, 215, 195, 19, 56, 239, 251, 31, 165, 182, 246, 46, 119, 71, 65 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-33333333333a"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 226, 55, 138, 21, 52, 17, 16, 227, 147, 45, 101, 5, 56, 10, 154, 240, 116, 199, 123, 107, 155, 179, 153, 89, 73, 204, 18, 239, 156, 245, 136, 99, 186, 121, 74, 126, 98, 83, 111, 116, 149, 86, 127, 211, 32, 7, 87, 29, 91, 228, 201, 69, 224, 1, 66, 191, 155, 8, 217, 147, 95, 104, 56, 175 }, new byte[] { 35, 40, 216, 224, 180, 244, 1, 62, 6, 245, 183, 210, 25, 155, 103, 68, 12, 87, 174, 165, 84, 93, 234, 5, 10, 28, 56, 206, 204, 242, 102, 176, 97, 109, 15, 141, 221, 116, 249, 159, 134, 134, 12, 82, 151, 208, 66, 107, 191, 233, 130, 21, 91, 217, 78, 230, 240, 160, 35, 94, 135, 213, 52, 23, 64, 186, 68, 92, 147, 8, 49, 200, 159, 124, 132, 54, 251, 214, 32, 54, 237, 243, 205, 60, 190, 250, 86, 55, 224, 9, 197, 245, 195, 99, 240, 102, 59, 3, 89, 130, 24, 167, 163, 6, 7, 57, 244, 57, 59, 91, 124, 22, 40, 180, 222, 250, 55, 158, 242, 96, 89, 111, 191, 218, 241, 151, 82, 15 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000001"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 136, 200, 208, 34, 27, 98, 120, 207, 137, 231, 180, 88, 76, 107, 74, 134, 96, 238, 91, 209, 180, 212, 186, 15, 32, 106, 10, 63, 83, 77, 145, 93, 69, 211, 117, 78, 76, 178, 253, 236, 212, 172, 217, 50, 89, 243, 117, 129, 55, 177, 225, 113, 128, 135, 53, 30, 98, 62, 184, 140, 113, 246, 245, 9, 246, 26, 170, 201, 253, 62, 105, 193, 2, 63, 74, 249, 108, 196, 187, 131, 226, 203, 164, 161, 246, 255, 150, 42, 209, 157, 137, 227, 97, 120, 139, 9, 6, 145, 79, 98, 156, 22, 104, 88, 50, 78, 246, 242, 160, 75, 204, 252, 252, 235, 98, 104, 156, 50, 110, 102, 179, 99, 48, 244, 133, 138, 230, 232 }, new byte[] { 79, 123, 167, 226, 176, 119, 29, 119, 218, 38, 228, 252, 240, 15, 123, 106, 254, 154, 178, 204, 166, 136, 205, 253, 75, 215, 15, 220, 143, 13, 159, 150, 241, 53, 234, 209, 150, 67, 163, 119, 216, 134, 191, 134, 215, 128, 94, 186, 91, 87, 79, 51, 19, 89, 178, 222, 185, 230, 69, 228, 192, 185, 86, 252 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000002"),
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "huseyin.demir.s2@std.iyte.edu.tr", "Hüseyin", "Demir", new byte[] { 136, 200, 208, 34, 27, 98, 120, 207, 137, 231, 180, 88, 76, 107, 74, 134, 96, 238, 91, 209, 180, 212, 186, 15, 32, 106, 10, 63, 83, 77, 145, 93, 69, 211, 117, 78, 76, 178, 253, 236, 212, 172, 217, 50, 89, 243, 117, 129, 55, 177, 225, 113, 128, 135, 53, 30, 98, 62, 184, 140, 113, 246, 245, 9, 246, 26, 170, 201, 253, 62, 105, 193, 2, 63, 74, 249, 108, 196, 187, 131, 226, 203, 164, 161, 246, 255, 150, 42, 209, 157, 137, 227, 97, 120, 139, 9, 6, 145, 79, 98, 156, 22, 104, 88, 50, 78, 246, 242, 160, 75, 204, 252, 252, 235, 98, 104, 156, 50, 110, 102, 179, 99, 48, 244, 133, 138, 230, 232 }, new byte[] { 79, 123, 167, 226, 176, 119, 29, 119, 218, 38, 228, 252, 240, 15, 123, 106, 254, 154, 178, 204, 166, 136, 205, 253, 75, 215, 15, 220, 143, 13, 159, 150, 241, 53, 234, 209, 150, 67, 163, 119, 216, 134, 191, 134, 215, 128, 94, 186, 91, 87, 79, 51, 19, 89, 178, 222, 185, 230, 69, 228, 192, 185, 86, 252 }, "huseyin.demir.s2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000003"),
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "merve.dogan.s3@std.iyte.edu.tr", "Merve", "Doğan", new byte[] { 136, 200, 208, 34, 27, 98, 120, 207, 137, 231, 180, 88, 76, 107, 74, 134, 96, 238, 91, 209, 180, 212, 186, 15, 32, 106, 10, 63, 83, 77, 145, 93, 69, 211, 117, 78, 76, 178, 253, 236, 212, 172, 217, 50, 89, 243, 117, 129, 55, 177, 225, 113, 128, 135, 53, 30, 98, 62, 184, 140, 113, 246, 245, 9, 246, 26, 170, 201, 253, 62, 105, 193, 2, 63, 74, 249, 108, 196, 187, 131, 226, 203, 164, 161, 246, 255, 150, 42, 209, 157, 137, 227, 97, 120, 139, 9, 6, 145, 79, 98, 156, 22, 104, 88, 50, 78, 246, 242, 160, 75, 204, 252, 252, 235, 98, 104, 156, 50, 110, 102, 179, 99, 48, 244, 133, 138, 230, 232 }, new byte[] { 79, 123, 167, 226, 176, 119, 29, 119, 218, 38, 228, 252, 240, 15, 123, 106, 254, 154, 178, 204, 166, 136, 205, 253, 75, 215, 15, 220, 143, 13, 159, 150, 241, 53, 234, 209, 150, 67, 163, 119, 216, 134, 191, 134, 215, 128, 94, 186, 91, 87, 79, 51, 19, 89, 178, 222, 185, 230, 69, 228, 192, 185, 86, 252 }, "merve.dogan.s3" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000004"),
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "huseyin.kaya.s4@std.iyte.edu.tr", "Hüseyin", "Kaya", new byte[] { 136, 200, 208, 34, 27, 98, 120, 207, 137, 231, 180, 88, 76, 107, 74, 134, 96, 238, 91, 209, 180, 212, 186, 15, 32, 106, 10, 63, 83, 77, 145, 93, 69, 211, 117, 78, 76, 178, 253, 236, 212, 172, 217, 50, 89, 243, 117, 129, 55, 177, 225, 113, 128, 135, 53, 30, 98, 62, 184, 140, 113, 246, 245, 9, 246, 26, 170, 201, 253, 62, 105, 193, 2, 63, 74, 249, 108, 196, 187, 131, 226, 203, 164, 161, 246, 255, 150, 42, 209, 157, 137, 227, 97, 120, 139, 9, 6, 145, 79, 98, 156, 22, 104, 88, 50, 78, 246, 242, 160, 75, 204, 252, 252, 235, 98, 104, 156, 50, 110, 102, 179, 99, 48, 244, 133, 138, 230, 232 }, new byte[] { 79, 123, 167, 226, 176, 119, 29, 119, 218, 38, 228, 252, 240, 15, 123, 106, 254, 154, 178, 204, 166, 136, 205, 253, 75, 215, 15, 220, 143, 13, 159, 150, 241, 53, 234, 209, 150, 67, 163, 119, 216, 134, 191, 134, 215, 128, 94, 186, 91, 87, 79, 51, 19, 89, 178, 222, 185, 230, 69, 228, 192, 185, 86, 252 }, "huseyin.kaya.s4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000005"),
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "hatice.yildiz.s5@std.iyte.edu.tr", "Hatice", "Yıldız", new byte[] { 136, 200, 208, 34, 27, 98, 120, 207, 137, 231, 180, 88, 76, 107, 74, 134, 96, 238, 91, 209, 180, 212, 186, 15, 32, 106, 10, 63, 83, 77, 145, 93, 69, 211, 117, 78, 76, 178, 253, 236, 212, 172, 217, 50, 89, 243, 117, 129, 55, 177, 225, 113, 128, 135, 53, 30, 98, 62, 184, 140, 113, 246, 245, 9, 246, 26, 170, 201, 253, 62, 105, 193, 2, 63, 74, 249, 108, 196, 187, 131, 226, 203, 164, 161, 246, 255, 150, 42, 209, 157, 137, 227, 97, 120, 139, 9, 6, 145, 79, 98, 156, 22, 104, 88, 50, 78, 246, 242, 160, 75, 204, 252, 252, 235, 98, 104, 156, 50, 110, 102, 179, 99, 48, 244, 133, 138, 230, 232 }, new byte[] { 79, 123, 167, 226, 176, 119, 29, 119, 218, 38, 228, 252, 240, 15, 123, 106, 254, 154, 178, 204, 166, 136, 205, 253, 75, 215, 15, 220, 143, 13, 159, 150, 241, 53, 234, 209, 150, 67, 163, 119, 216, 134, 191, 134, 215, 128, 94, 186, 91, 87, 79, 51, 19, 89, 178, 222, 185, 230, 69, 228, 192, 185, 86, 252 }, "hatice.yildiz.s5" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000006"),
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "huseyin.ozturk.s6@std.iyte.edu.tr", "Hüseyin", "Öztürk", new byte[] { 136, 200, 208, 34, 27, 98, 120, 207, 137, 231, 180, 88, 76, 107, 74, 134, 96, 238, 91, 209, 180, 212, 186, 15, 32, 106, 10, 63, 83, 77, 145, 93, 69, 211, 117, 78, 76, 178, 253, 236, 212, 172, 217, 50, 89, 243, 117, 129, 55, 177, 225, 113, 128, 135, 53, 30, 98, 62, 184, 140, 113, 246, 245, 9, 246, 26, 170, 201, 253, 62, 105, 193, 2, 63, 74, 249, 108, 196, 187, 131, 226, 203, 164, 161, 246, 255, 150, 42, 209, 157, 137, 227, 97, 120, 139, 9, 6, 145, 79, 98, 156, 22, 104, 88, 50, 78, 246, 242, 160, 75, 204, 252, 252, 235, 98, 104, 156, 50, 110, 102, 179, 99, 48, 244, 133, 138, 230, 232 }, new byte[] { 79, 123, 167, 226, 176, 119, 29, 119, 218, 38, 228, 252, 240, 15, 123, 106, 254, 154, 178, 204, 166, 136, 205, 253, 75, 215, 15, 220, 143, 13, 159, 150, 241, 53, 234, 209, 150, 67, 163, 119, 216, 134, 191, 134, 215, 128, 94, 186, 91, 87, 79, 51, 19, 89, 178, 222, 185, 230, 69, 228, 192, 185, 86, 252 }, "huseyin.ozturk.s6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000007"),
                columns: new[] { "Email", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "hatice.sahin.s7@std.iyte.edu.tr", "Şahin", new byte[] { 136, 200, 208, 34, 27, 98, 120, 207, 137, 231, 180, 88, 76, 107, 74, 134, 96, 238, 91, 209, 180, 212, 186, 15, 32, 106, 10, 63, 83, 77, 145, 93, 69, 211, 117, 78, 76, 178, 253, 236, 212, 172, 217, 50, 89, 243, 117, 129, 55, 177, 225, 113, 128, 135, 53, 30, 98, 62, 184, 140, 113, 246, 245, 9, 246, 26, 170, 201, 253, 62, 105, 193, 2, 63, 74, 249, 108, 196, 187, 131, 226, 203, 164, 161, 246, 255, 150, 42, 209, 157, 137, 227, 97, 120, 139, 9, 6, 145, 79, 98, 156, 22, 104, 88, 50, 78, 246, 242, 160, 75, 204, 252, 252, 235, 98, 104, 156, 50, 110, 102, 179, 99, 48, 244, 133, 138, 230, 232 }, new byte[] { 79, 123, 167, 226, 176, 119, 29, 119, 218, 38, 228, 252, 240, 15, 123, 106, 254, 154, 178, 204, 166, 136, 205, 253, 75, 215, 15, 220, 143, 13, 159, 150, 241, 53, 234, 209, 150, 67, 163, 119, 216, 134, 191, 134, 215, 128, 94, 186, 91, 87, 79, 51, 19, 89, 178, 222, 185, 230, 69, 228, 192, 185, 86, 252 }, "hatice.sahin.s7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000008"),
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "ali.kaya.s8@std.iyte.edu.tr", "Ali", "Kaya", new byte[] { 136, 200, 208, 34, 27, 98, 120, 207, 137, 231, 180, 88, 76, 107, 74, 134, 96, 238, 91, 209, 180, 212, 186, 15, 32, 106, 10, 63, 83, 77, 145, 93, 69, 211, 117, 78, 76, 178, 253, 236, 212, 172, 217, 50, 89, 243, 117, 129, 55, 177, 225, 113, 128, 135, 53, 30, 98, 62, 184, 140, 113, 246, 245, 9, 246, 26, 170, 201, 253, 62, 105, 193, 2, 63, 74, 249, 108, 196, 187, 131, 226, 203, 164, 161, 246, 255, 150, 42, 209, 157, 137, 227, 97, 120, 139, 9, 6, 145, 79, 98, 156, 22, 104, 88, 50, 78, 246, 242, 160, 75, 204, 252, 252, 235, 98, 104, 156, 50, 110, 102, 179, 99, 48, 244, 133, 138, 230, 232 }, new byte[] { 79, 123, 167, 226, 176, 119, 29, 119, 218, 38, 228, 252, 240, 15, 123, 106, 254, 154, 178, 204, 166, 136, 205, 253, 75, 215, 15, 220, 143, 13, 159, 150, 241, 53, 234, 209, 150, 67, 163, 119, 216, 134, 191, 134, 215, 128, 94, 186, 91, 87, 79, 51, 19, 89, 178, 222, 185, 230, 69, 228, 192, 185, 86, 252 }, "ali.kaya.s8" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000009"),
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "merve.yilmaz.s9@std.iyte.edu.tr", "Merve", "Yılmaz", new byte[] { 136, 200, 208, 34, 27, 98, 120, 207, 137, 231, 180, 88, 76, 107, 74, 134, 96, 238, 91, 209, 180, 212, 186, 15, 32, 106, 10, 63, 83, 77, 145, 93, 69, 211, 117, 78, 76, 178, 253, 236, 212, 172, 217, 50, 89, 243, 117, 129, 55, 177, 225, 113, 128, 135, 53, 30, 98, 62, 184, 140, 113, 246, 245, 9, 246, 26, 170, 201, 253, 62, 105, 193, 2, 63, 74, 249, 108, 196, 187, 131, 226, 203, 164, 161, 246, 255, 150, 42, 209, 157, 137, 227, 97, 120, 139, 9, 6, 145, 79, 98, 156, 22, 104, 88, 50, 78, 246, 242, 160, 75, 204, 252, 252, 235, 98, 104, 156, 50, 110, 102, 179, 99, 48, 244, 133, 138, 230, 232 }, new byte[] { 79, 123, 167, 226, 176, 119, 29, 119, 218, 38, 228, 252, 240, 15, 123, 106, 254, 154, 178, 204, 166, 136, 205, 253, 75, 215, 15, 220, 143, 13, 159, 150, 241, 53, 234, 209, 150, 67, 163, 119, 216, 134, 191, 134, 215, 128, 94, 186, 91, 87, 79, 51, 19, 89, 178, 222, 185, 230, 69, 228, 192, 185, 86, 252 }, "merve.yilmaz.s9" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000010"),
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "ali.yilmaz.s10@std.iyte.edu.tr", "Ali", "Yılmaz", new byte[] { 136, 200, 208, 34, 27, 98, 120, 207, 137, 231, 180, 88, 76, 107, 74, 134, 96, 238, 91, 209, 180, 212, 186, 15, 32, 106, 10, 63, 83, 77, 145, 93, 69, 211, 117, 78, 76, 178, 253, 236, 212, 172, 217, 50, 89, 243, 117, 129, 55, 177, 225, 113, 128, 135, 53, 30, 98, 62, 184, 140, 113, 246, 245, 9, 246, 26, 170, 201, 253, 62, 105, 193, 2, 63, 74, 249, 108, 196, 187, 131, 226, 203, 164, 161, 246, 255, 150, 42, 209, 157, 137, 227, 97, 120, 139, 9, 6, 145, 79, 98, 156, 22, 104, 88, 50, 78, 246, 242, 160, 75, 204, 252, 252, 235, 98, 104, 156, 50, 110, 102, 179, 99, 48, 244, 133, 138, 230, 232 }, new byte[] { 79, 123, 167, 226, 176, 119, 29, 119, 218, 38, 228, 252, 240, 15, 123, 106, 254, 154, 178, 204, 166, 136, 205, 253, 75, 215, 15, 220, 143, 13, 159, 150, 241, 53, 234, 209, 150, 67, 163, 119, 216, 134, 191, 134, 215, 128, 94, 186, 91, 87, 79, 51, 19, 89, 178, 222, 185, 230, 69, 228, 192, 185, 86, 252 }, "ali.yilmaz.s10" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000011"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 136, 200, 208, 34, 27, 98, 120, 207, 137, 231, 180, 88, 76, 107, 74, 134, 96, 238, 91, 209, 180, 212, 186, 15, 32, 106, 10, 63, 83, 77, 145, 93, 69, 211, 117, 78, 76, 178, 253, 236, 212, 172, 217, 50, 89, 243, 117, 129, 55, 177, 225, 113, 128, 135, 53, 30, 98, 62, 184, 140, 113, 246, 245, 9, 246, 26, 170, 201, 253, 62, 105, 193, 2, 63, 74, 249, 108, 196, 187, 131, 226, 203, 164, 161, 246, 255, 150, 42, 209, 157, 137, 227, 97, 120, 139, 9, 6, 145, 79, 98, 156, 22, 104, 88, 50, 78, 246, 242, 160, 75, 204, 252, 252, 235, 98, 104, 156, 50, 110, 102, 179, 99, 48, 244, 133, 138, 230, 232 }, new byte[] { 79, 123, 167, 226, 176, 119, 29, 119, 218, 38, 228, 252, 240, 15, 123, 106, 254, 154, 178, 204, 166, 136, 205, 253, 75, 215, 15, 220, 143, 13, 159, 150, 241, 53, 234, 209, 150, 67, 163, 119, 216, 134, 191, 134, 215, 128, 94, 186, 91, 87, 79, 51, 19, 89, 178, 222, 185, 230, 69, 228, 192, 185, 86, 252 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000012"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 136, 200, 208, 34, 27, 98, 120, 207, 137, 231, 180, 88, 76, 107, 74, 134, 96, 238, 91, 209, 180, 212, 186, 15, 32, 106, 10, 63, 83, 77, 145, 93, 69, 211, 117, 78, 76, 178, 253, 236, 212, 172, 217, 50, 89, 243, 117, 129, 55, 177, 225, 113, 128, 135, 53, 30, 98, 62, 184, 140, 113, 246, 245, 9, 246, 26, 170, 201, 253, 62, 105, 193, 2, 63, 74, 249, 108, 196, 187, 131, 226, 203, 164, 161, 246, 255, 150, 42, 209, 157, 137, 227, 97, 120, 139, 9, 6, 145, 79, 98, 156, 22, 104, 88, 50, 78, 246, 242, 160, 75, 204, 252, 252, 235, 98, 104, 156, 50, 110, 102, 179, 99, 48, 244, 133, 138, 230, 232 }, new byte[] { 79, 123, 167, 226, 176, 119, 29, 119, 218, 38, 228, 252, 240, 15, 123, 106, 254, 154, 178, 204, 166, 136, 205, 253, 75, 215, 15, 220, 143, 13, 159, 150, 241, 53, 234, 209, 150, 67, 163, 119, 216, 134, 191, 134, 215, 128, 94, 186, 91, 87, 79, 51, 19, 89, 178, 222, 185, 230, 69, 228, 192, 185, 86, 252 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000013"),
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "ayse.yildiz.s13@std.iyte.edu.tr", "Ayşe", "Yıldız", new byte[] { 136, 200, 208, 34, 27, 98, 120, 207, 137, 231, 180, 88, 76, 107, 74, 134, 96, 238, 91, 209, 180, 212, 186, 15, 32, 106, 10, 63, 83, 77, 145, 93, 69, 211, 117, 78, 76, 178, 253, 236, 212, 172, 217, 50, 89, 243, 117, 129, 55, 177, 225, 113, 128, 135, 53, 30, 98, 62, 184, 140, 113, 246, 245, 9, 246, 26, 170, 201, 253, 62, 105, 193, 2, 63, 74, 249, 108, 196, 187, 131, 226, 203, 164, 161, 246, 255, 150, 42, 209, 157, 137, 227, 97, 120, 139, 9, 6, 145, 79, 98, 156, 22, 104, 88, 50, 78, 246, 242, 160, 75, 204, 252, 252, 235, 98, 104, 156, 50, 110, 102, 179, 99, 48, 244, 133, 138, 230, 232 }, new byte[] { 79, 123, 167, 226, 176, 119, 29, 119, 218, 38, 228, 252, 240, 15, 123, 106, 254, 154, 178, 204, 166, 136, 205, 253, 75, 215, 15, 220, 143, 13, 159, 150, 241, 53, 234, 209, 150, 67, 163, 119, 216, 134, 191, 134, 215, 128, 94, 186, 91, 87, 79, 51, 19, 89, 178, 222, 185, 230, 69, 228, 192, 185, 86, 252 }, "ayse.yildiz.s13" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000014"),
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "murat.arslan.s14@std.iyte.edu.tr", "Murat", "Arslan", new byte[] { 136, 200, 208, 34, 27, 98, 120, 207, 137, 231, 180, 88, 76, 107, 74, 134, 96, 238, 91, 209, 180, 212, 186, 15, 32, 106, 10, 63, 83, 77, 145, 93, 69, 211, 117, 78, 76, 178, 253, 236, 212, 172, 217, 50, 89, 243, 117, 129, 55, 177, 225, 113, 128, 135, 53, 30, 98, 62, 184, 140, 113, 246, 245, 9, 246, 26, 170, 201, 253, 62, 105, 193, 2, 63, 74, 249, 108, 196, 187, 131, 226, 203, 164, 161, 246, 255, 150, 42, 209, 157, 137, 227, 97, 120, 139, 9, 6, 145, 79, 98, 156, 22, 104, 88, 50, 78, 246, 242, 160, 75, 204, 252, 252, 235, 98, 104, 156, 50, 110, 102, 179, 99, 48, 244, 133, 138, 230, 232 }, new byte[] { 79, 123, 167, 226, 176, 119, 29, 119, 218, 38, 228, 252, 240, 15, 123, 106, 254, 154, 178, 204, 166, 136, 205, 253, 75, 215, 15, 220, 143, 13, 159, 150, 241, 53, 234, 209, 150, 67, 163, 119, 216, 134, 191, 134, 215, 128, 94, 186, 91, 87, 79, 51, 19, 89, 178, 222, 185, 230, 69, 228, 192, 185, 86, 252 }, "murat.arslan.s14" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000015"),
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "merve.celik.s15@std.iyte.edu.tr", "Merve", "Çelik", new byte[] { 136, 200, 208, 34, 27, 98, 120, 207, 137, 231, 180, 88, 76, 107, 74, 134, 96, 238, 91, 209, 180, 212, 186, 15, 32, 106, 10, 63, 83, 77, 145, 93, 69, 211, 117, 78, 76, 178, 253, 236, 212, 172, 217, 50, 89, 243, 117, 129, 55, 177, 225, 113, 128, 135, 53, 30, 98, 62, 184, 140, 113, 246, 245, 9, 246, 26, 170, 201, 253, 62, 105, 193, 2, 63, 74, 249, 108, 196, 187, 131, 226, 203, 164, 161, 246, 255, 150, 42, 209, 157, 137, 227, 97, 120, 139, 9, 6, 145, 79, 98, 156, 22, 104, 88, 50, 78, 246, 242, 160, 75, 204, 252, 252, 235, 98, 104, 156, 50, 110, 102, 179, 99, 48, 244, 133, 138, 230, 232 }, new byte[] { 79, 123, 167, 226, 176, 119, 29, 119, 218, 38, 228, 252, 240, 15, 123, 106, 254, 154, 178, 204, 166, 136, 205, 253, 75, 215, 15, 220, 143, 13, 159, 150, 241, 53, 234, 209, 150, 67, 163, 119, 216, 134, 191, 134, 215, 128, 94, 186, 91, 87, 79, 51, 19, 89, 178, 222, 185, 230, 69, 228, 192, 185, 86, 252 }, "merve.celik.s15" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000016"),
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "mehmet.kaya.s16@std.iyte.edu.tr", "Mehmet", "Kaya", new byte[] { 136, 200, 208, 34, 27, 98, 120, 207, 137, 231, 180, 88, 76, 107, 74, 134, 96, 238, 91, 209, 180, 212, 186, 15, 32, 106, 10, 63, 83, 77, 145, 93, 69, 211, 117, 78, 76, 178, 253, 236, 212, 172, 217, 50, 89, 243, 117, 129, 55, 177, 225, 113, 128, 135, 53, 30, 98, 62, 184, 140, 113, 246, 245, 9, 246, 26, 170, 201, 253, 62, 105, 193, 2, 63, 74, 249, 108, 196, 187, 131, 226, 203, 164, 161, 246, 255, 150, 42, 209, 157, 137, 227, 97, 120, 139, 9, 6, 145, 79, 98, 156, 22, 104, 88, 50, 78, 246, 242, 160, 75, 204, 252, 252, 235, 98, 104, 156, 50, 110, 102, 179, 99, 48, 244, 133, 138, 230, 232 }, new byte[] { 79, 123, 167, 226, 176, 119, 29, 119, 218, 38, 228, 252, 240, 15, 123, 106, 254, 154, 178, 204, 166, 136, 205, 253, 75, 215, 15, 220, 143, 13, 159, 150, 241, 53, 234, 209, 150, 67, 163, 119, 216, 134, 191, 134, 215, 128, 94, 186, 91, 87, 79, 51, 19, 89, 178, 222, 185, 230, 69, 228, 192, 185, 86, 252 }, "mehmet.kaya.s16" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000017"),
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "hatice.yildiz.s17@std.iyte.edu.tr", "Hatice", "Yıldız", new byte[] { 136, 200, 208, 34, 27, 98, 120, 207, 137, 231, 180, 88, 76, 107, 74, 134, 96, 238, 91, 209, 180, 212, 186, 15, 32, 106, 10, 63, 83, 77, 145, 93, 69, 211, 117, 78, 76, 178, 253, 236, 212, 172, 217, 50, 89, 243, 117, 129, 55, 177, 225, 113, 128, 135, 53, 30, 98, 62, 184, 140, 113, 246, 245, 9, 246, 26, 170, 201, 253, 62, 105, 193, 2, 63, 74, 249, 108, 196, 187, 131, 226, 203, 164, 161, 246, 255, 150, 42, 209, 157, 137, 227, 97, 120, 139, 9, 6, 145, 79, 98, 156, 22, 104, 88, 50, 78, 246, 242, 160, 75, 204, 252, 252, 235, 98, 104, 156, 50, 110, 102, 179, 99, 48, 244, 133, 138, 230, 232 }, new byte[] { 79, 123, 167, 226, 176, 119, 29, 119, 218, 38, 228, 252, 240, 15, 123, 106, 254, 154, 178, 204, 166, 136, 205, 253, 75, 215, 15, 220, 143, 13, 159, 150, 241, 53, 234, 209, 150, 67, 163, 119, 216, 134, 191, 134, 215, 128, 94, 186, 91, 87, 79, 51, 19, 89, 178, 222, 185, 230, 69, 228, 192, 185, 86, 252 }, "hatice.yildiz.s17" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000018"),
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "emre.demir.s18@std.iyte.edu.tr", "Emre", "Demir", new byte[] { 136, 200, 208, 34, 27, 98, 120, 207, 137, 231, 180, 88, 76, 107, 74, 134, 96, 238, 91, 209, 180, 212, 186, 15, 32, 106, 10, 63, 83, 77, 145, 93, 69, 211, 117, 78, 76, 178, 253, 236, 212, 172, 217, 50, 89, 243, 117, 129, 55, 177, 225, 113, 128, 135, 53, 30, 98, 62, 184, 140, 113, 246, 245, 9, 246, 26, 170, 201, 253, 62, 105, 193, 2, 63, 74, 249, 108, 196, 187, 131, 226, 203, 164, 161, 246, 255, 150, 42, 209, 157, 137, 227, 97, 120, 139, 9, 6, 145, 79, 98, 156, 22, 104, 88, 50, 78, 246, 242, 160, 75, 204, 252, 252, 235, 98, 104, 156, 50, 110, 102, 179, 99, 48, 244, 133, 138, 230, 232 }, new byte[] { 79, 123, 167, 226, 176, 119, 29, 119, 218, 38, 228, 252, 240, 15, 123, 106, 254, 154, 178, 204, 166, 136, 205, 253, 75, 215, 15, 220, 143, 13, 159, 150, 241, 53, 234, 209, 150, 67, 163, 119, 216, 134, 191, 134, 215, 128, 94, 186, 91, 87, 79, 51, 19, 89, 178, 222, 185, 230, 69, 228, 192, 185, 86, 252 }, "emre.demir.s18" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000019"),
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "selin.yildiz.s19@std.iyte.edu.tr", "Selin", "Yıldız", new byte[] { 136, 200, 208, 34, 27, 98, 120, 207, 137, 231, 180, 88, 76, 107, 74, 134, 96, 238, 91, 209, 180, 212, 186, 15, 32, 106, 10, 63, 83, 77, 145, 93, 69, 211, 117, 78, 76, 178, 253, 236, 212, 172, 217, 50, 89, 243, 117, 129, 55, 177, 225, 113, 128, 135, 53, 30, 98, 62, 184, 140, 113, 246, 245, 9, 246, 26, 170, 201, 253, 62, 105, 193, 2, 63, 74, 249, 108, 196, 187, 131, 226, 203, 164, 161, 246, 255, 150, 42, 209, 157, 137, 227, 97, 120, 139, 9, 6, 145, 79, 98, 156, 22, 104, 88, 50, 78, 246, 242, 160, 75, 204, 252, 252, 235, 98, 104, 156, 50, 110, 102, 179, 99, 48, 244, 133, 138, 230, 232 }, new byte[] { 79, 123, 167, 226, 176, 119, 29, 119, 218, 38, 228, 252, 240, 15, 123, 106, 254, 154, 178, 204, 166, 136, 205, 253, 75, 215, 15, 220, 143, 13, 159, 150, 241, 53, 234, 209, 150, 67, 163, 119, 216, 134, 191, 134, 215, 128, 94, 186, 91, 87, 79, 51, 19, 89, 178, 222, 185, 230, 69, 228, 192, 185, 86, 252 }, "selin.yildiz.s19" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000020"),
                columns: new[] { "Email", "FirstName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "emre.sahin.s20@std.iyte.edu.tr", "Emre", new byte[] { 136, 200, 208, 34, 27, 98, 120, 207, 137, 231, 180, 88, 76, 107, 74, 134, 96, 238, 91, 209, 180, 212, 186, 15, 32, 106, 10, 63, 83, 77, 145, 93, 69, 211, 117, 78, 76, 178, 253, 236, 212, 172, 217, 50, 89, 243, 117, 129, 55, 177, 225, 113, 128, 135, 53, 30, 98, 62, 184, 140, 113, 246, 245, 9, 246, 26, 170, 201, 253, 62, 105, 193, 2, 63, 74, 249, 108, 196, 187, 131, 226, 203, 164, 161, 246, 255, 150, 42, 209, 157, 137, 227, 97, 120, 139, 9, 6, 145, 79, 98, 156, 22, 104, 88, 50, 78, 246, 242, 160, 75, 204, 252, 252, 235, 98, 104, 156, 50, 110, 102, 179, 99, 48, 244, 133, 138, 230, 232 }, new byte[] { 79, 123, 167, 226, 176, 119, 29, 119, 218, 38, 228, 252, 240, 15, 123, 106, 254, 154, 178, 204, 166, 136, 205, 253, 75, 215, 15, 220, 143, 13, 159, 150, 241, 53, 234, 209, 150, 67, 163, 119, 216, 134, 191, 134, 215, 128, 94, 186, 91, 87, 79, 51, 19, 89, 178, 222, 185, 230, 69, 228, 192, 185, 86, 252 }, "emre.sahin.s20" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000021"),
                columns: new[] { "Email", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "ebru.kaya.s21@std.iyte.edu.tr", "Kaya", new byte[] { 136, 200, 208, 34, 27, 98, 120, 207, 137, 231, 180, 88, 76, 107, 74, 134, 96, 238, 91, 209, 180, 212, 186, 15, 32, 106, 10, 63, 83, 77, 145, 93, 69, 211, 117, 78, 76, 178, 253, 236, 212, 172, 217, 50, 89, 243, 117, 129, 55, 177, 225, 113, 128, 135, 53, 30, 98, 62, 184, 140, 113, 246, 245, 9, 246, 26, 170, 201, 253, 62, 105, 193, 2, 63, 74, 249, 108, 196, 187, 131, 226, 203, 164, 161, 246, 255, 150, 42, 209, 157, 137, 227, 97, 120, 139, 9, 6, 145, 79, 98, 156, 22, 104, 88, 50, 78, 246, 242, 160, 75, 204, 252, 252, 235, 98, 104, 156, 50, 110, 102, 179, 99, 48, 244, 133, 138, 230, 232 }, new byte[] { 79, 123, 167, 226, 176, 119, 29, 119, 218, 38, 228, 252, 240, 15, 123, 106, 254, 154, 178, 204, 166, 136, 205, 253, 75, 215, 15, 220, 143, 13, 159, 150, 241, 53, 234, 209, 150, 67, 163, 119, 216, 134, 191, 134, 215, 128, 94, 186, 91, 87, 79, 51, 19, 89, 178, 222, 185, 230, 69, 228, 192, 185, 86, 252 }, "ebru.kaya.s21" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000022"),
                columns: new[] { "Email", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "mehmet.aydin.s22@std.iyte.edu.tr", "Aydın", new byte[] { 136, 200, 208, 34, 27, 98, 120, 207, 137, 231, 180, 88, 76, 107, 74, 134, 96, 238, 91, 209, 180, 212, 186, 15, 32, 106, 10, 63, 83, 77, 145, 93, 69, 211, 117, 78, 76, 178, 253, 236, 212, 172, 217, 50, 89, 243, 117, 129, 55, 177, 225, 113, 128, 135, 53, 30, 98, 62, 184, 140, 113, 246, 245, 9, 246, 26, 170, 201, 253, 62, 105, 193, 2, 63, 74, 249, 108, 196, 187, 131, 226, 203, 164, 161, 246, 255, 150, 42, 209, 157, 137, 227, 97, 120, 139, 9, 6, 145, 79, 98, 156, 22, 104, 88, 50, 78, 246, 242, 160, 75, 204, 252, 252, 235, 98, 104, 156, 50, 110, 102, 179, 99, 48, 244, 133, 138, 230, 232 }, new byte[] { 79, 123, 167, 226, 176, 119, 29, 119, 218, 38, 228, 252, 240, 15, 123, 106, 254, 154, 178, 204, 166, 136, 205, 253, 75, 215, 15, 220, 143, 13, 159, 150, 241, 53, 234, 209, 150, 67, 163, 119, 216, 134, 191, 134, 215, 128, 94, 186, 91, 87, 79, 51, 19, 89, 178, 222, 185, 230, 69, 228, 192, 185, 86, 252 }, "mehmet.aydin.s22" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000023"),
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "hatice.sahin.s23@std.iyte.edu.tr", "Hatice", "Şahin", new byte[] { 136, 200, 208, 34, 27, 98, 120, 207, 137, 231, 180, 88, 76, 107, 74, 134, 96, 238, 91, 209, 180, 212, 186, 15, 32, 106, 10, 63, 83, 77, 145, 93, 69, 211, 117, 78, 76, 178, 253, 236, 212, 172, 217, 50, 89, 243, 117, 129, 55, 177, 225, 113, 128, 135, 53, 30, 98, 62, 184, 140, 113, 246, 245, 9, 246, 26, 170, 201, 253, 62, 105, 193, 2, 63, 74, 249, 108, 196, 187, 131, 226, 203, 164, 161, 246, 255, 150, 42, 209, 157, 137, 227, 97, 120, 139, 9, 6, 145, 79, 98, 156, 22, 104, 88, 50, 78, 246, 242, 160, 75, 204, 252, 252, 235, 98, 104, 156, 50, 110, 102, 179, 99, 48, 244, 133, 138, 230, 232 }, new byte[] { 79, 123, 167, 226, 176, 119, 29, 119, 218, 38, 228, 252, 240, 15, 123, 106, 254, 154, 178, 204, 166, 136, 205, 253, 75, 215, 15, 220, 143, 13, 159, 150, 241, 53, 234, 209, 150, 67, 163, 119, 216, 134, 191, 134, 215, 128, 94, 186, 91, 87, 79, 51, 19, 89, 178, 222, 185, 230, 69, 228, 192, 185, 86, 252 }, "hatice.sahin.s23" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000024"),
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "veli.kaya.s24@std.iyte.edu.tr", "Veli", "Kaya", new byte[] { 136, 200, 208, 34, 27, 98, 120, 207, 137, 231, 180, 88, 76, 107, 74, 134, 96, 238, 91, 209, 180, 212, 186, 15, 32, 106, 10, 63, 83, 77, 145, 93, 69, 211, 117, 78, 76, 178, 253, 236, 212, 172, 217, 50, 89, 243, 117, 129, 55, 177, 225, 113, 128, 135, 53, 30, 98, 62, 184, 140, 113, 246, 245, 9, 246, 26, 170, 201, 253, 62, 105, 193, 2, 63, 74, 249, 108, 196, 187, 131, 226, 203, 164, 161, 246, 255, 150, 42, 209, 157, 137, 227, 97, 120, 139, 9, 6, 145, 79, 98, 156, 22, 104, 88, 50, 78, 246, 242, 160, 75, 204, 252, 252, 235, 98, 104, 156, 50, 110, 102, 179, 99, 48, 244, 133, 138, 230, 232 }, new byte[] { 79, 123, 167, 226, 176, 119, 29, 119, 218, 38, 228, 252, 240, 15, 123, 106, 254, 154, 178, 204, 166, 136, 205, 253, 75, 215, 15, 220, 143, 13, 159, 150, 241, 53, 234, 209, 150, 67, 163, 119, 216, 134, 191, 134, 215, 128, 94, 186, 91, 87, 79, 51, 19, 89, 178, 222, 185, 230, 69, 228, 192, 185, 86, 252 }, "veli.kaya.s24" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000025"),
                columns: new[] { "Email", "FirstName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "merve.dogan.s25@std.iyte.edu.tr", "Merve", new byte[] { 136, 200, 208, 34, 27, 98, 120, 207, 137, 231, 180, 88, 76, 107, 74, 134, 96, 238, 91, 209, 180, 212, 186, 15, 32, 106, 10, 63, 83, 77, 145, 93, 69, 211, 117, 78, 76, 178, 253, 236, 212, 172, 217, 50, 89, 243, 117, 129, 55, 177, 225, 113, 128, 135, 53, 30, 98, 62, 184, 140, 113, 246, 245, 9, 246, 26, 170, 201, 253, 62, 105, 193, 2, 63, 74, 249, 108, 196, 187, 131, 226, 203, 164, 161, 246, 255, 150, 42, 209, 157, 137, 227, 97, 120, 139, 9, 6, 145, 79, 98, 156, 22, 104, 88, 50, 78, 246, 242, 160, 75, 204, 252, 252, 235, 98, 104, 156, 50, 110, 102, 179, 99, 48, 244, 133, 138, 230, 232 }, new byte[] { 79, 123, 167, 226, 176, 119, 29, 119, 218, 38, 228, 252, 240, 15, 123, 106, 254, 154, 178, 204, 166, 136, 205, 253, 75, 215, 15, 220, 143, 13, 159, 150, 241, 53, 234, 209, 150, 67, 163, 119, 216, 134, 191, 134, 215, 128, 94, 186, 91, 87, 79, 51, 19, 89, 178, 222, 185, 230, 69, 228, 192, 185, 86, 252 }, "merve.dogan.s25" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000026"),
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "ahmet.arslan.s26@std.iyte.edu.tr", "Ahmet", "Arslan", new byte[] { 136, 200, 208, 34, 27, 98, 120, 207, 137, 231, 180, 88, 76, 107, 74, 134, 96, 238, 91, 209, 180, 212, 186, 15, 32, 106, 10, 63, 83, 77, 145, 93, 69, 211, 117, 78, 76, 178, 253, 236, 212, 172, 217, 50, 89, 243, 117, 129, 55, 177, 225, 113, 128, 135, 53, 30, 98, 62, 184, 140, 113, 246, 245, 9, 246, 26, 170, 201, 253, 62, 105, 193, 2, 63, 74, 249, 108, 196, 187, 131, 226, 203, 164, 161, 246, 255, 150, 42, 209, 157, 137, 227, 97, 120, 139, 9, 6, 145, 79, 98, 156, 22, 104, 88, 50, 78, 246, 242, 160, 75, 204, 252, 252, 235, 98, 104, 156, 50, 110, 102, 179, 99, 48, 244, 133, 138, 230, 232 }, new byte[] { 79, 123, 167, 226, 176, 119, 29, 119, 218, 38, 228, 252, 240, 15, 123, 106, 254, 154, 178, 204, 166, 136, 205, 253, 75, 215, 15, 220, 143, 13, 159, 150, 241, 53, 234, 209, 150, 67, 163, 119, 216, 134, 191, 134, 215, 128, 94, 186, 91, 87, 79, 51, 19, 89, 178, 222, 185, 230, 69, 228, 192, 185, 86, 252 }, "ahmet.arslan.s26" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000027"),
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "selin.ozturk.s27@std.iyte.edu.tr", "Selin", "Öztürk", new byte[] { 136, 200, 208, 34, 27, 98, 120, 207, 137, 231, 180, 88, 76, 107, 74, 134, 96, 238, 91, 209, 180, 212, 186, 15, 32, 106, 10, 63, 83, 77, 145, 93, 69, 211, 117, 78, 76, 178, 253, 236, 212, 172, 217, 50, 89, 243, 117, 129, 55, 177, 225, 113, 128, 135, 53, 30, 98, 62, 184, 140, 113, 246, 245, 9, 246, 26, 170, 201, 253, 62, 105, 193, 2, 63, 74, 249, 108, 196, 187, 131, 226, 203, 164, 161, 246, 255, 150, 42, 209, 157, 137, 227, 97, 120, 139, 9, 6, 145, 79, 98, 156, 22, 104, 88, 50, 78, 246, 242, 160, 75, 204, 252, 252, 235, 98, 104, 156, 50, 110, 102, 179, 99, 48, 244, 133, 138, 230, 232 }, new byte[] { 79, 123, 167, 226, 176, 119, 29, 119, 218, 38, 228, 252, 240, 15, 123, 106, 254, 154, 178, 204, 166, 136, 205, 253, 75, 215, 15, 220, 143, 13, 159, 150, 241, 53, 234, 209, 150, 67, 163, 119, 216, 134, 191, 134, 215, 128, 94, 186, 91, 87, 79, 51, 19, 89, 178, 222, 185, 230, 69, 228, 192, 185, 86, 252 }, "selin.ozturk.s27" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000028"),
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "can.celik.s28@std.iyte.edu.tr", "Can", "Çelik", new byte[] { 136, 200, 208, 34, 27, 98, 120, 207, 137, 231, 180, 88, 76, 107, 74, 134, 96, 238, 91, 209, 180, 212, 186, 15, 32, 106, 10, 63, 83, 77, 145, 93, 69, 211, 117, 78, 76, 178, 253, 236, 212, 172, 217, 50, 89, 243, 117, 129, 55, 177, 225, 113, 128, 135, 53, 30, 98, 62, 184, 140, 113, 246, 245, 9, 246, 26, 170, 201, 253, 62, 105, 193, 2, 63, 74, 249, 108, 196, 187, 131, 226, 203, 164, 161, 246, 255, 150, 42, 209, 157, 137, 227, 97, 120, 139, 9, 6, 145, 79, 98, 156, 22, 104, 88, 50, 78, 246, 242, 160, 75, 204, 252, 252, 235, 98, 104, 156, 50, 110, 102, 179, 99, 48, 244, 133, 138, 230, 232 }, new byte[] { 79, 123, 167, 226, 176, 119, 29, 119, 218, 38, 228, 252, 240, 15, 123, 106, 254, 154, 178, 204, 166, 136, 205, 253, 75, 215, 15, 220, 143, 13, 159, 150, 241, 53, 234, 209, 150, 67, 163, 119, 216, 134, 191, 134, 215, 128, 94, 186, 91, 87, 79, 51, 19, 89, 178, 222, 185, 230, 69, 228, 192, 185, 86, 252 }, "can.celik.s28" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000029"),
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "gamze.yildiz.s29@std.iyte.edu.tr", "Gamze", "Yıldız", new byte[] { 136, 200, 208, 34, 27, 98, 120, 207, 137, 231, 180, 88, 76, 107, 74, 134, 96, 238, 91, 209, 180, 212, 186, 15, 32, 106, 10, 63, 83, 77, 145, 93, 69, 211, 117, 78, 76, 178, 253, 236, 212, 172, 217, 50, 89, 243, 117, 129, 55, 177, 225, 113, 128, 135, 53, 30, 98, 62, 184, 140, 113, 246, 245, 9, 246, 26, 170, 201, 253, 62, 105, 193, 2, 63, 74, 249, 108, 196, 187, 131, 226, 203, 164, 161, 246, 255, 150, 42, 209, 157, 137, 227, 97, 120, 139, 9, 6, 145, 79, 98, 156, 22, 104, 88, 50, 78, 246, 242, 160, 75, 204, 252, 252, 235, 98, 104, 156, 50, 110, 102, 179, 99, 48, 244, 133, 138, 230, 232 }, new byte[] { 79, 123, 167, 226, 176, 119, 29, 119, 218, 38, 228, 252, 240, 15, 123, 106, 254, 154, 178, 204, 166, 136, 205, 253, 75, 215, 15, 220, 143, 13, 159, 150, 241, 53, 234, 209, 150, 67, 163, 119, 216, 134, 191, 134, 215, 128, 94, 186, 91, 87, 79, 51, 19, 89, 178, 222, 185, 230, 69, 228, 192, 185, 86, 252 }, "gamze.yildiz.s29" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000030"),
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "murat.demir.s30@std.iyte.edu.tr", "Murat", "Demir", new byte[] { 136, 200, 208, 34, 27, 98, 120, 207, 137, 231, 180, 88, 76, 107, 74, 134, 96, 238, 91, 209, 180, 212, 186, 15, 32, 106, 10, 63, 83, 77, 145, 93, 69, 211, 117, 78, 76, 178, 253, 236, 212, 172, 217, 50, 89, 243, 117, 129, 55, 177, 225, 113, 128, 135, 53, 30, 98, 62, 184, 140, 113, 246, 245, 9, 246, 26, 170, 201, 253, 62, 105, 193, 2, 63, 74, 249, 108, 196, 187, 131, 226, 203, 164, 161, 246, 255, 150, 42, 209, 157, 137, 227, 97, 120, 139, 9, 6, 145, 79, 98, 156, 22, 104, 88, 50, 78, 246, 242, 160, 75, 204, 252, 252, 235, 98, 104, 156, 50, 110, 102, 179, 99, 48, 244, 133, 138, 230, 232 }, new byte[] { 79, 123, 167, 226, 176, 119, 29, 119, 218, 38, 228, 252, 240, 15, 123, 106, 254, 154, 178, 204, 166, 136, 205, 253, 75, 215, 15, 220, 143, 13, 159, 150, 241, 53, 234, 209, 150, 67, 163, 119, 216, 134, 191, 134, 215, 128, 94, 186, 91, 87, 79, 51, 19, 89, 178, 222, 185, 230, 69, 228, 192, 185, 86, 252 }, "murat.demir.s30" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000031"),
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "elif.ozturk.s31@std.iyte.edu.tr", "Elif", "Öztürk", new byte[] { 136, 200, 208, 34, 27, 98, 120, 207, 137, 231, 180, 88, 76, 107, 74, 134, 96, 238, 91, 209, 180, 212, 186, 15, 32, 106, 10, 63, 83, 77, 145, 93, 69, 211, 117, 78, 76, 178, 253, 236, 212, 172, 217, 50, 89, 243, 117, 129, 55, 177, 225, 113, 128, 135, 53, 30, 98, 62, 184, 140, 113, 246, 245, 9, 246, 26, 170, 201, 253, 62, 105, 193, 2, 63, 74, 249, 108, 196, 187, 131, 226, 203, 164, 161, 246, 255, 150, 42, 209, 157, 137, 227, 97, 120, 139, 9, 6, 145, 79, 98, 156, 22, 104, 88, 50, 78, 246, 242, 160, 75, 204, 252, 252, 235, 98, 104, 156, 50, 110, 102, 179, 99, 48, 244, 133, 138, 230, 232 }, new byte[] { 79, 123, 167, 226, 176, 119, 29, 119, 218, 38, 228, 252, 240, 15, 123, 106, 254, 154, 178, 204, 166, 136, 205, 253, 75, 215, 15, 220, 143, 13, 159, 150, 241, 53, 234, 209, 150, 67, 163, 119, 216, 134, 191, 134, 215, 128, 94, 186, 91, 87, 79, 51, 19, 89, 178, 222, 185, 230, 69, 228, 192, 185, 86, 252 }, "elif.ozturk.s31" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000032"),
                columns: new[] { "Email", "FirstName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "mustafa.celik.s32@std.iyte.edu.tr", "Mustafa", new byte[] { 136, 200, 208, 34, 27, 98, 120, 207, 137, 231, 180, 88, 76, 107, 74, 134, 96, 238, 91, 209, 180, 212, 186, 15, 32, 106, 10, 63, 83, 77, 145, 93, 69, 211, 117, 78, 76, 178, 253, 236, 212, 172, 217, 50, 89, 243, 117, 129, 55, 177, 225, 113, 128, 135, 53, 30, 98, 62, 184, 140, 113, 246, 245, 9, 246, 26, 170, 201, 253, 62, 105, 193, 2, 63, 74, 249, 108, 196, 187, 131, 226, 203, 164, 161, 246, 255, 150, 42, 209, 157, 137, 227, 97, 120, 139, 9, 6, 145, 79, 98, 156, 22, 104, 88, 50, 78, 246, 242, 160, 75, 204, 252, 252, 235, 98, 104, 156, 50, 110, 102, 179, 99, 48, 244, 133, 138, 230, 232 }, new byte[] { 79, 123, 167, 226, 176, 119, 29, 119, 218, 38, 228, 252, 240, 15, 123, 106, 254, 154, 178, 204, 166, 136, 205, 253, 75, 215, 15, 220, 143, 13, 159, 150, 241, 53, 234, 209, 150, 67, 163, 119, 216, 134, 191, 134, 215, 128, 94, 186, 91, 87, 79, 51, 19, 89, 178, 222, 185, 230, 69, 228, 192, 185, 86, 252 }, "mustafa.celik.s32" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000033"),
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "gamze.ozturk.s33@std.iyte.edu.tr", "Gamze", "Öztürk", new byte[] { 136, 200, 208, 34, 27, 98, 120, 207, 137, 231, 180, 88, 76, 107, 74, 134, 96, 238, 91, 209, 180, 212, 186, 15, 32, 106, 10, 63, 83, 77, 145, 93, 69, 211, 117, 78, 76, 178, 253, 236, 212, 172, 217, 50, 89, 243, 117, 129, 55, 177, 225, 113, 128, 135, 53, 30, 98, 62, 184, 140, 113, 246, 245, 9, 246, 26, 170, 201, 253, 62, 105, 193, 2, 63, 74, 249, 108, 196, 187, 131, 226, 203, 164, 161, 246, 255, 150, 42, 209, 157, 137, 227, 97, 120, 139, 9, 6, 145, 79, 98, 156, 22, 104, 88, 50, 78, 246, 242, 160, 75, 204, 252, 252, 235, 98, 104, 156, 50, 110, 102, 179, 99, 48, 244, 133, 138, 230, 232 }, new byte[] { 79, 123, 167, 226, 176, 119, 29, 119, 218, 38, 228, 252, 240, 15, 123, 106, 254, 154, 178, 204, 166, 136, 205, 253, 75, 215, 15, 220, 143, 13, 159, 150, 241, 53, 234, 209, 150, 67, 163, 119, 216, 134, 191, 134, 215, 128, 94, 186, 91, 87, 79, 51, 19, 89, 178, 222, 185, 230, 69, 228, 192, 185, 86, 252 }, "gamze.ozturk.s33" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000034"),
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "ali.demir.s34@std.iyte.edu.tr", "Ali", "Demir", new byte[] { 136, 200, 208, 34, 27, 98, 120, 207, 137, 231, 180, 88, 76, 107, 74, 134, 96, 238, 91, 209, 180, 212, 186, 15, 32, 106, 10, 63, 83, 77, 145, 93, 69, 211, 117, 78, 76, 178, 253, 236, 212, 172, 217, 50, 89, 243, 117, 129, 55, 177, 225, 113, 128, 135, 53, 30, 98, 62, 184, 140, 113, 246, 245, 9, 246, 26, 170, 201, 253, 62, 105, 193, 2, 63, 74, 249, 108, 196, 187, 131, 226, 203, 164, 161, 246, 255, 150, 42, 209, 157, 137, 227, 97, 120, 139, 9, 6, 145, 79, 98, 156, 22, 104, 88, 50, 78, 246, 242, 160, 75, 204, 252, 252, 235, 98, 104, 156, 50, 110, 102, 179, 99, 48, 244, 133, 138, 230, 232 }, new byte[] { 79, 123, 167, 226, 176, 119, 29, 119, 218, 38, 228, 252, 240, 15, 123, 106, 254, 154, 178, 204, 166, 136, 205, 253, 75, 215, 15, 220, 143, 13, 159, 150, 241, 53, 234, 209, 150, 67, 163, 119, 216, 134, 191, 134, 215, 128, 94, 186, 91, 87, 79, 51, 19, 89, 178, 222, 185, 230, 69, 228, 192, 185, 86, 252 }, "ali.demir.s34" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000035"),
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "hatice.celik.s35@std.iyte.edu.tr", "Hatice", "Çelik", new byte[] { 136, 200, 208, 34, 27, 98, 120, 207, 137, 231, 180, 88, 76, 107, 74, 134, 96, 238, 91, 209, 180, 212, 186, 15, 32, 106, 10, 63, 83, 77, 145, 93, 69, 211, 117, 78, 76, 178, 253, 236, 212, 172, 217, 50, 89, 243, 117, 129, 55, 177, 225, 113, 128, 135, 53, 30, 98, 62, 184, 140, 113, 246, 245, 9, 246, 26, 170, 201, 253, 62, 105, 193, 2, 63, 74, 249, 108, 196, 187, 131, 226, 203, 164, 161, 246, 255, 150, 42, 209, 157, 137, 227, 97, 120, 139, 9, 6, 145, 79, 98, 156, 22, 104, 88, 50, 78, 246, 242, 160, 75, 204, 252, 252, 235, 98, 104, 156, 50, 110, 102, 179, 99, 48, 244, 133, 138, 230, 232 }, new byte[] { 79, 123, 167, 226, 176, 119, 29, 119, 218, 38, 228, 252, 240, 15, 123, 106, 254, 154, 178, 204, 166, 136, 205, 253, 75, 215, 15, 220, 143, 13, 159, 150, 241, 53, 234, 209, 150, 67, 163, 119, 216, 134, 191, 134, 215, 128, 94, 186, 91, 87, 79, 51, 19, 89, 178, 222, 185, 230, 69, 228, 192, 185, 86, 252 }, "hatice.celik.s35" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000036"),
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "ali.celik.s36@std.iyte.edu.tr", "Ali", "Çelik", new byte[] { 136, 200, 208, 34, 27, 98, 120, 207, 137, 231, 180, 88, 76, 107, 74, 134, 96, 238, 91, 209, 180, 212, 186, 15, 32, 106, 10, 63, 83, 77, 145, 93, 69, 211, 117, 78, 76, 178, 253, 236, 212, 172, 217, 50, 89, 243, 117, 129, 55, 177, 225, 113, 128, 135, 53, 30, 98, 62, 184, 140, 113, 246, 245, 9, 246, 26, 170, 201, 253, 62, 105, 193, 2, 63, 74, 249, 108, 196, 187, 131, 226, 203, 164, 161, 246, 255, 150, 42, 209, 157, 137, 227, 97, 120, 139, 9, 6, 145, 79, 98, 156, 22, 104, 88, 50, 78, 246, 242, 160, 75, 204, 252, 252, 235, 98, 104, 156, 50, 110, 102, 179, 99, 48, 244, 133, 138, 230, 232 }, new byte[] { 79, 123, 167, 226, 176, 119, 29, 119, 218, 38, 228, 252, 240, 15, 123, 106, 254, 154, 178, 204, 166, 136, 205, 253, 75, 215, 15, 220, 143, 13, 159, 150, 241, 53, 234, 209, 150, 67, 163, 119, 216, 134, 191, 134, 215, 128, 94, 186, 91, 87, 79, 51, 19, 89, 178, 222, 185, 230, 69, 228, 192, 185, 86, 252 }, "ali.celik.s36" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000037"),
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "merve.celik.s37@std.iyte.edu.tr", "Merve", "Çelik", new byte[] { 136, 200, 208, 34, 27, 98, 120, 207, 137, 231, 180, 88, 76, 107, 74, 134, 96, 238, 91, 209, 180, 212, 186, 15, 32, 106, 10, 63, 83, 77, 145, 93, 69, 211, 117, 78, 76, 178, 253, 236, 212, 172, 217, 50, 89, 243, 117, 129, 55, 177, 225, 113, 128, 135, 53, 30, 98, 62, 184, 140, 113, 246, 245, 9, 246, 26, 170, 201, 253, 62, 105, 193, 2, 63, 74, 249, 108, 196, 187, 131, 226, 203, 164, 161, 246, 255, 150, 42, 209, 157, 137, 227, 97, 120, 139, 9, 6, 145, 79, 98, 156, 22, 104, 88, 50, 78, 246, 242, 160, 75, 204, 252, 252, 235, 98, 104, 156, 50, 110, 102, 179, 99, 48, 244, 133, 138, 230, 232 }, new byte[] { 79, 123, 167, 226, 176, 119, 29, 119, 218, 38, 228, 252, 240, 15, 123, 106, 254, 154, 178, 204, 166, 136, 205, 253, 75, 215, 15, 220, 143, 13, 159, 150, 241, 53, 234, 209, 150, 67, 163, 119, 216, 134, 191, 134, 215, 128, 94, 186, 91, 87, 79, 51, 19, 89, 178, 222, 185, 230, 69, 228, 192, 185, 86, 252 }, "merve.celik.s37" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000038"),
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "emre.aydin.s38@std.iyte.edu.tr", "Emre", "Aydın", new byte[] { 136, 200, 208, 34, 27, 98, 120, 207, 137, 231, 180, 88, 76, 107, 74, 134, 96, 238, 91, 209, 180, 212, 186, 15, 32, 106, 10, 63, 83, 77, 145, 93, 69, 211, 117, 78, 76, 178, 253, 236, 212, 172, 217, 50, 89, 243, 117, 129, 55, 177, 225, 113, 128, 135, 53, 30, 98, 62, 184, 140, 113, 246, 245, 9, 246, 26, 170, 201, 253, 62, 105, 193, 2, 63, 74, 249, 108, 196, 187, 131, 226, 203, 164, 161, 246, 255, 150, 42, 209, 157, 137, 227, 97, 120, 139, 9, 6, 145, 79, 98, 156, 22, 104, 88, 50, 78, 246, 242, 160, 75, 204, 252, 252, 235, 98, 104, 156, 50, 110, 102, 179, 99, 48, 244, 133, 138, 230, 232 }, new byte[] { 79, 123, 167, 226, 176, 119, 29, 119, 218, 38, 228, 252, 240, 15, 123, 106, 254, 154, 178, 204, 166, 136, 205, 253, 75, 215, 15, 220, 143, 13, 159, 150, 241, 53, 234, 209, 150, 67, 163, 119, 216, 134, 191, 134, 215, 128, 94, 186, 91, 87, 79, 51, 19, 89, 178, 222, 185, 230, 69, 228, 192, 185, 86, 252 }, "emre.aydin.s38" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000039"),
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "fatma.arslan.s39@std.iyte.edu.tr", "Fatma", "Arslan", new byte[] { 136, 200, 208, 34, 27, 98, 120, 207, 137, 231, 180, 88, 76, 107, 74, 134, 96, 238, 91, 209, 180, 212, 186, 15, 32, 106, 10, 63, 83, 77, 145, 93, 69, 211, 117, 78, 76, 178, 253, 236, 212, 172, 217, 50, 89, 243, 117, 129, 55, 177, 225, 113, 128, 135, 53, 30, 98, 62, 184, 140, 113, 246, 245, 9, 246, 26, 170, 201, 253, 62, 105, 193, 2, 63, 74, 249, 108, 196, 187, 131, 226, 203, 164, 161, 246, 255, 150, 42, 209, 157, 137, 227, 97, 120, 139, 9, 6, 145, 79, 98, 156, 22, 104, 88, 50, 78, 246, 242, 160, 75, 204, 252, 252, 235, 98, 104, 156, 50, 110, 102, 179, 99, 48, 244, 133, 138, 230, 232 }, new byte[] { 79, 123, 167, 226, 176, 119, 29, 119, 218, 38, 228, 252, 240, 15, 123, 106, 254, 154, 178, 204, 166, 136, 205, 253, 75, 215, 15, 220, 143, 13, 159, 150, 241, 53, 234, 209, 150, 67, 163, 119, 216, 134, 191, 134, 215, 128, 94, 186, 91, 87, 79, 51, 19, 89, 178, 222, 185, 230, 69, 228, 192, 185, 86, 252 }, "fatma.arslan.s39" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000040"),
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "veli.yildiz.s40@std.iyte.edu.tr", "Veli", "Yıldız", new byte[] { 136, 200, 208, 34, 27, 98, 120, 207, 137, 231, 180, 88, 76, 107, 74, 134, 96, 238, 91, 209, 180, 212, 186, 15, 32, 106, 10, 63, 83, 77, 145, 93, 69, 211, 117, 78, 76, 178, 253, 236, 212, 172, 217, 50, 89, 243, 117, 129, 55, 177, 225, 113, 128, 135, 53, 30, 98, 62, 184, 140, 113, 246, 245, 9, 246, 26, 170, 201, 253, 62, 105, 193, 2, 63, 74, 249, 108, 196, 187, 131, 226, 203, 164, 161, 246, 255, 150, 42, 209, 157, 137, 227, 97, 120, 139, 9, 6, 145, 79, 98, 156, 22, 104, 88, 50, 78, 246, 242, 160, 75, 204, 252, 252, 235, 98, 104, 156, 50, 110, 102, 179, 99, 48, 244, 133, 138, 230, 232 }, new byte[] { 79, 123, 167, 226, 176, 119, 29, 119, 218, 38, 228, 252, 240, 15, 123, 106, 254, 154, 178, 204, 166, 136, 205, 253, 75, 215, 15, 220, 143, 13, 159, 150, 241, 53, 234, 209, 150, 67, 163, 119, 216, 134, 191, 134, 215, 128, 94, 186, 91, 87, 79, 51, 19, 89, 178, 222, 185, 230, 69, 228, 192, 185, 86, 252 }, "veli.yildiz.s40" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000041"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 136, 200, 208, 34, 27, 98, 120, 207, 137, 231, 180, 88, 76, 107, 74, 134, 96, 238, 91, 209, 180, 212, 186, 15, 32, 106, 10, 63, 83, 77, 145, 93, 69, 211, 117, 78, 76, 178, 253, 236, 212, 172, 217, 50, 89, 243, 117, 129, 55, 177, 225, 113, 128, 135, 53, 30, 98, 62, 184, 140, 113, 246, 245, 9, 246, 26, 170, 201, 253, 62, 105, 193, 2, 63, 74, 249, 108, 196, 187, 131, 226, 203, 164, 161, 246, 255, 150, 42, 209, 157, 137, 227, 97, 120, 139, 9, 6, 145, 79, 98, 156, 22, 104, 88, 50, 78, 246, 242, 160, 75, 204, 252, 252, 235, 98, 104, 156, 50, 110, 102, 179, 99, 48, 244, 133, 138, 230, 232 }, new byte[] { 79, 123, 167, 226, 176, 119, 29, 119, 218, 38, 228, 252, 240, 15, 123, 106, 254, 154, 178, 204, 166, 136, 205, 253, 75, 215, 15, 220, 143, 13, 159, 150, 241, 53, 234, 209, 150, 67, 163, 119, 216, 134, 191, 134, 215, 128, 94, 186, 91, 87, 79, 51, 19, 89, 178, 222, 185, 230, 69, 228, 192, 185, 86, 252 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000042"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 136, 200, 208, 34, 27, 98, 120, 207, 137, 231, 180, 88, 76, 107, 74, 134, 96, 238, 91, 209, 180, 212, 186, 15, 32, 106, 10, 63, 83, 77, 145, 93, 69, 211, 117, 78, 76, 178, 253, 236, 212, 172, 217, 50, 89, 243, 117, 129, 55, 177, 225, 113, 128, 135, 53, 30, 98, 62, 184, 140, 113, 246, 245, 9, 246, 26, 170, 201, 253, 62, 105, 193, 2, 63, 74, 249, 108, 196, 187, 131, 226, 203, 164, 161, 246, 255, 150, 42, 209, 157, 137, 227, 97, 120, 139, 9, 6, 145, 79, 98, 156, 22, 104, 88, 50, 78, 246, 242, 160, 75, 204, 252, 252, 235, 98, 104, 156, 50, 110, 102, 179, 99, 48, 244, 133, 138, 230, 232 }, new byte[] { 79, 123, 167, 226, 176, 119, 29, 119, 218, 38, 228, 252, 240, 15, 123, 106, 254, 154, 178, 204, 166, 136, 205, 253, 75, 215, 15, 220, 143, 13, 159, 150, 241, 53, 234, 209, 150, 67, 163, 119, 216, 134, 191, 134, 215, 128, 94, 186, 91, 87, 79, 51, 19, 89, 178, 222, 185, 230, 69, 228, 192, 185, 86, 252 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000043"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 136, 200, 208, 34, 27, 98, 120, 207, 137, 231, 180, 88, 76, 107, 74, 134, 96, 238, 91, 209, 180, 212, 186, 15, 32, 106, 10, 63, 83, 77, 145, 93, 69, 211, 117, 78, 76, 178, 253, 236, 212, 172, 217, 50, 89, 243, 117, 129, 55, 177, 225, 113, 128, 135, 53, 30, 98, 62, 184, 140, 113, 246, 245, 9, 246, 26, 170, 201, 253, 62, 105, 193, 2, 63, 74, 249, 108, 196, 187, 131, 226, 203, 164, 161, 246, 255, 150, 42, 209, 157, 137, 227, 97, 120, 139, 9, 6, 145, 79, 98, 156, 22, 104, 88, 50, 78, 246, 242, 160, 75, 204, 252, 252, 235, 98, 104, 156, 50, 110, 102, 179, 99, 48, 244, 133, 138, 230, 232 }, new byte[] { 79, 123, 167, 226, 176, 119, 29, 119, 218, 38, 228, 252, 240, 15, 123, 106, 254, 154, 178, 204, 166, 136, 205, 253, 75, 215, 15, 220, 143, 13, 159, 150, 241, 53, 234, 209, 150, 67, 163, 119, 216, 134, 191, 134, 215, 128, 94, 186, 91, 87, 79, 51, 19, 89, 178, 222, 185, 230, 69, 228, 192, 185, 86, 252 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000044"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 136, 200, 208, 34, 27, 98, 120, 207, 137, 231, 180, 88, 76, 107, 74, 134, 96, 238, 91, 209, 180, 212, 186, 15, 32, 106, 10, 63, 83, 77, 145, 93, 69, 211, 117, 78, 76, 178, 253, 236, 212, 172, 217, 50, 89, 243, 117, 129, 55, 177, 225, 113, 128, 135, 53, 30, 98, 62, 184, 140, 113, 246, 245, 9, 246, 26, 170, 201, 253, 62, 105, 193, 2, 63, 74, 249, 108, 196, 187, 131, 226, 203, 164, 161, 246, 255, 150, 42, 209, 157, 137, 227, 97, 120, 139, 9, 6, 145, 79, 98, 156, 22, 104, 88, 50, 78, 246, 242, 160, 75, 204, 252, 252, 235, 98, 104, 156, 50, 110, 102, 179, 99, 48, 244, 133, 138, 230, 232 }, new byte[] { 79, 123, 167, 226, 176, 119, 29, 119, 218, 38, 228, 252, 240, 15, 123, 106, 254, 154, 178, 204, 166, 136, 205, 253, 75, 215, 15, 220, 143, 13, 159, 150, 241, 53, 234, 209, 150, 67, 163, 119, 216, 134, 191, 134, 215, 128, 94, 186, 91, 87, 79, 51, 19, 89, 178, 222, 185, 230, 69, 228, 192, 185, 86, 252 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000045"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 136, 200, 208, 34, 27, 98, 120, 207, 137, 231, 180, 88, 76, 107, 74, 134, 96, 238, 91, 209, 180, 212, 186, 15, 32, 106, 10, 63, 83, 77, 145, 93, 69, 211, 117, 78, 76, 178, 253, 236, 212, 172, 217, 50, 89, 243, 117, 129, 55, 177, 225, 113, 128, 135, 53, 30, 98, 62, 184, 140, 113, 246, 245, 9, 246, 26, 170, 201, 253, 62, 105, 193, 2, 63, 74, 249, 108, 196, 187, 131, 226, 203, 164, 161, 246, 255, 150, 42, 209, 157, 137, 227, 97, 120, 139, 9, 6, 145, 79, 98, 156, 22, 104, 88, 50, 78, 246, 242, 160, 75, 204, 252, 252, 235, 98, 104, 156, 50, 110, 102, 179, 99, 48, 244, 133, 138, 230, 232 }, new byte[] { 79, 123, 167, 226, 176, 119, 29, 119, 218, 38, 228, 252, 240, 15, 123, 106, 254, 154, 178, 204, 166, 136, 205, 253, 75, 215, 15, 220, 143, 13, 159, 150, 241, 53, 234, 209, 150, 67, 163, 119, 216, 134, 191, 134, 215, 128, 94, 186, 91, 87, 79, 51, 19, 89, 178, 222, 185, 230, 69, 228, 192, 185, 86, 252 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000046"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 136, 200, 208, 34, 27, 98, 120, 207, 137, 231, 180, 88, 76, 107, 74, 134, 96, 238, 91, 209, 180, 212, 186, 15, 32, 106, 10, 63, 83, 77, 145, 93, 69, 211, 117, 78, 76, 178, 253, 236, 212, 172, 217, 50, 89, 243, 117, 129, 55, 177, 225, 113, 128, 135, 53, 30, 98, 62, 184, 140, 113, 246, 245, 9, 246, 26, 170, 201, 253, 62, 105, 193, 2, 63, 74, 249, 108, 196, 187, 131, 226, 203, 164, 161, 246, 255, 150, 42, 209, 157, 137, 227, 97, 120, 139, 9, 6, 145, 79, 98, 156, 22, 104, 88, 50, 78, 246, 242, 160, 75, 204, 252, 252, 235, 98, 104, 156, 50, 110, 102, 179, 99, 48, 244, 133, 138, 230, 232 }, new byte[] { 79, 123, 167, 226, 176, 119, 29, 119, 218, 38, 228, 252, 240, 15, 123, 106, 254, 154, 178, 204, 166, 136, 205, 253, 75, 215, 15, 220, 143, 13, 159, 150, 241, 53, 234, 209, 150, 67, 163, 119, 216, 134, 191, 134, 215, 128, 94, 186, 91, 87, 79, 51, 19, 89, 178, 222, 185, 230, 69, 228, 192, 185, 86, 252 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000047"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 136, 200, 208, 34, 27, 98, 120, 207, 137, 231, 180, 88, 76, 107, 74, 134, 96, 238, 91, 209, 180, 212, 186, 15, 32, 106, 10, 63, 83, 77, 145, 93, 69, 211, 117, 78, 76, 178, 253, 236, 212, 172, 217, 50, 89, 243, 117, 129, 55, 177, 225, 113, 128, 135, 53, 30, 98, 62, 184, 140, 113, 246, 245, 9, 246, 26, 170, 201, 253, 62, 105, 193, 2, 63, 74, 249, 108, 196, 187, 131, 226, 203, 164, 161, 246, 255, 150, 42, 209, 157, 137, 227, 97, 120, 139, 9, 6, 145, 79, 98, 156, 22, 104, 88, 50, 78, 246, 242, 160, 75, 204, 252, 252, 235, 98, 104, 156, 50, 110, 102, 179, 99, 48, 244, 133, 138, 230, 232 }, new byte[] { 79, 123, 167, 226, 176, 119, 29, 119, 218, 38, 228, 252, 240, 15, 123, 106, 254, 154, 178, 204, 166, 136, 205, 253, 75, 215, 15, 220, 143, 13, 159, 150, 241, 53, 234, 209, 150, 67, 163, 119, 216, 134, 191, 134, 215, 128, 94, 186, 91, 87, 79, 51, 19, 89, 178, 222, 185, 230, 69, 228, 192, 185, 86, 252 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000048"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 136, 200, 208, 34, 27, 98, 120, 207, 137, 231, 180, 88, 76, 107, 74, 134, 96, 238, 91, 209, 180, 212, 186, 15, 32, 106, 10, 63, 83, 77, 145, 93, 69, 211, 117, 78, 76, 178, 253, 236, 212, 172, 217, 50, 89, 243, 117, 129, 55, 177, 225, 113, 128, 135, 53, 30, 98, 62, 184, 140, 113, 246, 245, 9, 246, 26, 170, 201, 253, 62, 105, 193, 2, 63, 74, 249, 108, 196, 187, 131, 226, 203, 164, 161, 246, 255, 150, 42, 209, 157, 137, 227, 97, 120, 139, 9, 6, 145, 79, 98, 156, 22, 104, 88, 50, 78, 246, 242, 160, 75, 204, 252, 252, 235, 98, 104, 156, 50, 110, 102, 179, 99, 48, 244, 133, 138, 230, 232 }, new byte[] { 79, 123, 167, 226, 176, 119, 29, 119, 218, 38, 228, 252, 240, 15, 123, 106, 254, 154, 178, 204, 166, 136, 205, 253, 75, 215, 15, 220, 143, 13, 159, 150, 241, 53, 234, 209, 150, 67, 163, 119, 216, 134, 191, 134, 215, 128, 94, 186, 91, 87, 79, 51, 19, 89, 178, 222, 185, 230, 69, 228, 192, 185, 86, 252 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000049"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 136, 200, 208, 34, 27, 98, 120, 207, 137, 231, 180, 88, 76, 107, 74, 134, 96, 238, 91, 209, 180, 212, 186, 15, 32, 106, 10, 63, 83, 77, 145, 93, 69, 211, 117, 78, 76, 178, 253, 236, 212, 172, 217, 50, 89, 243, 117, 129, 55, 177, 225, 113, 128, 135, 53, 30, 98, 62, 184, 140, 113, 246, 245, 9, 246, 26, 170, 201, 253, 62, 105, 193, 2, 63, 74, 249, 108, 196, 187, 131, 226, 203, 164, 161, 246, 255, 150, 42, 209, 157, 137, 227, 97, 120, 139, 9, 6, 145, 79, 98, 156, 22, 104, 88, 50, 78, 246, 242, 160, 75, 204, 252, 252, 235, 98, 104, 156, 50, 110, 102, 179, 99, 48, 244, 133, 138, 230, 232 }, new byte[] { 79, 123, 167, 226, 176, 119, 29, 119, 218, 38, 228, 252, 240, 15, 123, 106, 254, 154, 178, 204, 166, 136, 205, 253, 75, 215, 15, 220, 143, 13, 159, 150, 241, 53, 234, 209, 150, 67, 163, 119, 216, 134, 191, 134, 215, 128, 94, 186, 91, 87, 79, 51, 19, 89, 178, 222, 185, 230, 69, 228, 192, 185, 86, 252 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000050"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 136, 200, 208, 34, 27, 98, 120, 207, 137, 231, 180, 88, 76, 107, 74, 134, 96, 238, 91, 209, 180, 212, 186, 15, 32, 106, 10, 63, 83, 77, 145, 93, 69, 211, 117, 78, 76, 178, 253, 236, 212, 172, 217, 50, 89, 243, 117, 129, 55, 177, 225, 113, 128, 135, 53, 30, 98, 62, 184, 140, 113, 246, 245, 9, 246, 26, 170, 201, 253, 62, 105, 193, 2, 63, 74, 249, 108, 196, 187, 131, 226, 203, 164, 161, 246, 255, 150, 42, 209, 157, 137, 227, 97, 120, 139, 9, 6, 145, 79, 98, 156, 22, 104, 88, 50, 78, 246, 242, 160, 75, 204, 252, 252, 235, 98, 104, 156, 50, 110, 102, 179, 99, 48, 244, 133, 138, 230, 232 }, new byte[] { 79, 123, 167, 226, 176, 119, 29, 119, 218, 38, 228, 252, 240, 15, 123, 106, 254, 154, 178, 204, 166, 136, 205, 253, 75, 215, 15, 220, 143, 13, 159, 150, 241, 53, 234, 209, 150, 67, 163, 119, 216, 134, 191, 134, 215, 128, 94, 186, 91, 87, 79, 51, 19, 89, 178, 222, 185, 230, 69, 228, 192, 185, 86, 252 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-44444444444a"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 61, 13, 224, 76, 93, 83, 163, 84, 255, 254, 239, 184, 160, 132, 44, 127, 142, 85, 16, 179, 179, 111, 105, 204, 45, 168, 87, 253, 69, 2, 22, 168, 128, 202, 47, 130, 244, 104, 18, 1, 135, 131, 42, 191, 255, 105, 155, 116, 209, 236, 198, 48, 175, 166, 35, 145, 12, 207, 251, 5, 87, 250, 108, 166 }, new byte[] { 255, 168, 35, 170, 187, 52, 122, 192, 127, 122, 16, 157, 27, 159, 87, 141, 83, 40, 142, 61, 119, 195, 71, 75, 197, 17, 92, 99, 134, 122, 205, 234, 114, 83, 61, 224, 214, 111, 54, 208, 84, 142, 218, 229, 11, 150, 21, 65, 47, 95, 71, 110, 76, 187, 139, 38, 152, 38, 109, 154, 227, 118, 23, 187, 254, 44, 184, 156, 34, 132, 18, 22, 27, 117, 208, 172, 121, 1, 110, 109, 93, 37, 146, 207, 40, 204, 27, 90, 139, 114, 231, 228, 52, 78, 86, 204, 187, 89, 93, 225, 100, 235, 8, 27, 104, 84, 54, 144, 127, 109, 140, 23, 81, 150, 212, 132, 16, 45, 203, 119, 128, 131, 243, 239, 3, 243, 136, 38 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-55555555555a"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 77, 196, 240, 73, 252, 43, 210, 183, 184, 135, 90, 188, 235, 249, 195, 185, 190, 172, 185, 190, 200, 165, 184, 0, 175, 92, 151, 248, 31, 25, 174, 57, 167, 186, 67, 183, 244, 241, 142, 66, 129, 15, 168, 49, 49, 83, 223, 69, 176, 177, 207, 206, 47, 152, 150, 87, 121, 235, 216, 139, 219, 216, 245, 172 }, new byte[] { 162, 210, 143, 159, 215, 146, 70, 55, 55, 93, 55, 219, 236, 124, 204, 208, 93, 134, 165, 233, 58, 135, 232, 18, 1, 100, 23, 93, 1, 29, 100, 190, 9, 110, 230, 79, 61, 215, 182, 67, 33, 34, 28, 190, 229, 176, 84, 118, 100, 2, 13, 45, 39, 47, 71, 108, 108, 83, 180, 137, 59, 5, 127, 48, 55, 82, 238, 75, 42, 14, 220, 82, 0, 211, 229, 236, 127, 34, 69, 250, 70, 177, 243, 234, 219, 167, 132, 198, 92, 131, 186, 191, 195, 225, 160, 100, 213, 10, 32, 29, 24, 242, 185, 216, 110, 141, 75, 196, 72, 196, 160, 177, 98, 74, 122, 174, 10, 99, 53, 138, 35, 255, 55, 70, 143, 244, 121, 155 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-66666666666a"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 45, 52, 133, 188, 204, 98, 213, 125, 168, 188, 113, 153, 12, 221, 3, 200, 183, 91, 226, 134, 184, 93, 143, 29, 116, 9, 195, 93, 163, 127, 62, 164, 124, 200, 31, 108, 101, 190, 187, 211, 115, 72, 248, 80, 175, 221, 226, 188, 220, 89, 76, 198, 172, 141, 114, 30, 189, 128, 152, 201, 248, 180, 33, 101 }, new byte[] { 52, 183, 43, 242, 24, 20, 231, 57, 132, 245, 51, 121, 60, 207, 44, 93, 178, 161, 86, 245, 193, 253, 144, 0, 94, 193, 230, 0, 108, 223, 90, 97, 16, 131, 151, 17, 132, 112, 79, 58, 190, 129, 103, 81, 30, 161, 32, 37, 30, 210, 132, 192, 242, 173, 74, 198, 202, 124, 96, 14, 2, 73, 133, 44, 58, 193, 7, 94, 229, 117, 152, 31, 63, 214, 120, 106, 246, 49, 112, 22, 230, 239, 225, 27, 132, 31, 219, 159, 167, 230, 164, 190, 93, 172, 142, 138, 144, 85, 80, 48, 135, 57, 70, 178, 129, 230, 206, 79, 124, 196, 244, 88, 28, 43, 0, 25, 240, 214, 195, 15, 12, 231, 162, 65, 226, 61, 233, 26 } });

            migrationBuilder.CreateIndex(
                name: "IX_FileAttachments_TranscriptDataId",
                table: "FileAttachments",
                column: "TranscriptDataId");

            migrationBuilder.AddForeignKey(
                name: "FK_FileAttachments_TranscriptDatas_TranscriptDataId",
                table: "FileAttachments",
                column: "TranscriptDataId",
                principalTable: "TranscriptDatas",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FileAttachments_TranscriptDatas_TranscriptDataId",
                table: "FileAttachments");

            migrationBuilder.DropIndex(
                name: "IX_FileAttachments_TranscriptDataId",
                table: "FileAttachments");

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("050d01d2-00e5-4709-b552-66fc316968ce"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("0aef782a-212f-4880-9f7c-e394483a1891"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("11f59b39-3492-4778-a7a4-963926b3174c"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("1371e713-1e37-44f9-86a9-35be0fe256a1"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("13df70f9-4a5a-495e-a9a2-c3cc429041b5"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("1406423d-2788-4d18-8a46-bab6e39a0341"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("2664ac79-a25d-436e-96ff-5f7677cf3f87"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("27381cdc-f3fc-4683-9f8d-aaac6e7359d3"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("293bf890-19b9-41a3-8a2a-d4921ffe5b3e"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("2faaf5fa-c30b-4a46-9f62-c55b48502c05"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("308e74c2-3a92-4a3d-ad99-b6a353bc3193"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("35ce5818-f2b9-4538-b91c-6dca8033bf56"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("43079861-4acb-4bf9-bac1-98b67a96bd98"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("45f6b574-1ea3-4350-b6f5-b3b7ab6c68a6"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("47d31d97-81e3-4d67-b584-83c28497641c"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("483f4b01-6391-456d-975b-472d910e7d56"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("4b8f9331-36da-4daa-90fa-9bc70b6f3a13"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("4d97eaaa-ffd9-4f76-b1b3-8bb60385d3c3"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("505fae94-5ab0-4034-bdc6-a53a1f5e9576"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("50b7f8c8-a66d-4e14-8ea6-fe89684e7f6a"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("58755760-5c7c-425d-9743-f339fa06bb71"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("59cff48c-b703-4dbc-9210-8b1801baf76e"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("63a4f5ff-e02f-440d-9908-b0c8b7dcf78a"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("6c57f9b1-3874-424b-a751-ed6fad656917"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("6c88a122-439f-473b-92ea-dda9a3ca2b0c"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("77f4cc1f-ff26-4cfd-8ffe-6784e34c052f"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("7c031eb6-8513-4798-8ab6-3dbd7125401d"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("7d9e66ab-ea84-4469-85a7-40c93bdb54cb"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("81c8e5a5-e00c-4488-96c5-54e866cd7601"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("89a675fe-baf0-458c-a7f3-971d8841f86b"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("a9d51763-4007-465b-b2a8-cd99a8c219f5"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("b4afb151-4bcd-4860-894d-523a4caa65d7"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("bd2d581c-13ad-4600-9c40-b9c00a6e1394"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("bfdf011d-2e12-4e6a-960a-cf2b0e4e0685"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("c3c70585-9dba-468c-bebc-97021fd3e3ad"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("c49e4a6d-1f5d-4d09-abe6-f7090a6e8c0c"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("c5e16f3b-2edb-4872-88b3-009fac97a259"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("c827babd-a3a2-4f44-9b98-0526a1100d9c"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("cd1d6e86-4ea9-43dc-a3ad-c63e3c8f45e2"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("cee75c8c-c381-4bea-9495-04087850c8e7"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("d02b19ce-21bd-414c-af6c-59ad4241f503"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("d06914d2-b6ca-4002-b0d2-a6d195053404"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("d4f7ebca-43ee-4d0e-b34b-0773f8364525"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("d7cb460d-a330-4cff-b338-9cfb1f47c63f"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("e3a52061-57e6-487b-be12-e5d40d313cf1"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("e3d110bd-1951-4db3-a201-c6e2fabe9d8c"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("e74ba1d6-5eea-424c-a1b1-d46e4c8cfde7"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("efc08299-efd8-4593-baaf-b844435de7c6"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("f1b9d626-4b04-4037-a804-3541cccbc39f"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("f92f4643-b5ae-450e-b09c-73660d807260"));

            migrationBuilder.DropColumn(
                name: "AcademicTerm",
                table: "GraduationRequirementSets");

            migrationBuilder.DropColumn(
                name: "TranscriptDataId",
                table: "FileAttachments");

            migrationBuilder.AddColumn<Guid>(
                name: "SourceFileAttachmentId",
                table: "TranscriptDatas",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "GraduationRequirementSets",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationDate",
                table: "GraduationRequirementSets",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000001"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4720));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000002"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4730));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000003"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4730));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000004"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4730));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000005"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4730));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000006"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4740));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000007"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4740));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000008"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4740));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000009"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4740));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000010"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4750));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000011"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4750));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000012"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4750));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000013"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4750));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000014"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4760));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000015"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4760));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000016"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4760));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000017"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4760));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000018"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4770));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000019"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4770));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000020"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4770));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000021"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4770));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000022"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4780));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000023"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4780));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000024"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4780));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000025"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4780));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000026"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4790));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000027"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4790));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000028"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4790));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000029"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4790));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000030"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000031"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000032"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4810));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000033"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4810));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000034"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4810));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000035"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4820));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000036"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4820));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000037"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4820));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000038"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4820));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000039"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4830));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000040"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4830));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000041"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4830));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000042"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4830));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000043"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4840));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000044"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4840));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000045"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4840));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000046"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4840));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000047"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4840));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000048"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4850));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000049"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4850));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000050"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4850));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000051"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4850));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000052"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4860));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000053"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4860));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000054"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4860));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000055"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4870));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000056"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4870));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000057"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4870));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000058"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4870));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000059"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4870));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000060"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4880));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000061"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4880));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000062"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4890));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000063"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4890));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000064"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4890));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000065"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4890));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000066"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4900));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000067"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4900));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000068"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4900));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000069"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4900));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000070"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4900));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000071"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4910));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000072"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4910));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000073"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4910));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000074"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4910));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000075"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4920));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000076"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4920));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000077"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4920));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000078"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4920));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000079"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4930));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000080"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4930));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000081"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4930));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000082"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4930));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000083"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4940));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000084"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4940));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000085"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4940));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000086"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4940));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000087"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4950));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000088"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4950));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000089"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4950));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000090"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4950));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000091"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4960));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000092"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4960));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000093"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4960));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000094"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4970));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000095"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4970));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000096"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4970));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000097"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4970));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000098"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4980));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000099"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4980));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000100"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4980));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000101"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4980));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000102"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4990));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000103"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4990));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000104"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4990));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000105"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4990));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000106"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4990));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000107"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5000));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000108"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5000));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000109"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5000));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000110"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5010));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000111"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5010));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000112"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5010));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000113"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5010));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000114"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5010));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000115"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5020));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000116"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5020));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000117"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5020));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000118"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5020));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000119"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5030));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000120"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5030));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000121"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5030));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000122"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5040));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000123"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5040));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000124"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5040));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000125"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5050));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000126"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5050));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000127"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5050));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000128"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5050));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000129"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5050));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000130"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5060));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000131"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5060));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000132"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5060));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000133"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5070));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000134"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5070));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000135"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5070));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000136"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5070));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000137"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5080));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000138"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5080));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000139"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5080));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000140"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5080));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000141"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5080));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000142"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5090));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000143"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5090));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000144"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5090));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000145"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5090));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000146"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5100));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000147"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5100));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000148"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5100));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000149"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5100));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000150"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5100));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000151"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000152"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000153"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000154"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000155"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5120));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000156"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5120));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000157"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5120));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000001"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4030));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000002"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4030));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000003"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4040));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000004"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4040));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000005"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4040));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000006"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4040));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000007"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4040));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000008"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4040));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000009"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4050));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000010"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4050));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000011"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4050));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000012"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4050));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000013"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4060));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000014"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4060));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000015"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4060));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000016"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4060));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000017"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4060));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000018"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4070));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000019"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4070));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000020"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4070));

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(3970));

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4000));

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4000));

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4000));

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000005"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4000));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000001"),
                column: "EnrollDate",
                value: new DateTime(2021, 11, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4490));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000002"),
                column: "EnrollDate",
                value: new DateTime(2023, 2, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4500));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000003"),
                column: "EnrollDate",
                value: new DateTime(2023, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4510));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000004"),
                column: "EnrollDate",
                value: new DateTime(2022, 7, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4510));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000005"),
                column: "EnrollDate",
                value: new DateTime(2022, 2, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4510));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000006"),
                column: "EnrollDate",
                value: new DateTime(2022, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4510));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000007"),
                column: "EnrollDate",
                value: new DateTime(2020, 11, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4510));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000008"),
                column: "EnrollDate",
                value: new DateTime(2024, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4520));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000009"),
                column: "EnrollDate",
                value: new DateTime(2020, 10, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4520));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000010"),
                column: "EnrollDate",
                value: new DateTime(2024, 4, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4520));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000011"),
                column: "EnrollDate",
                value: new DateTime(2020, 7, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4520));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000012"),
                column: "EnrollDate",
                value: new DateTime(2023, 7, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4530));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000013"),
                column: "EnrollDate",
                value: new DateTime(2021, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4530));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000014"),
                column: "EnrollDate",
                value: new DateTime(2024, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4530));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000015"),
                column: "EnrollDate",
                value: new DateTime(2024, 4, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4530));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000016"),
                column: "EnrollDate",
                value: new DateTime(2024, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4530));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000017"),
                column: "EnrollDate",
                value: new DateTime(2024, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4540));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000018"),
                column: "EnrollDate",
                value: new DateTime(2024, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4540));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000019"),
                column: "EnrollDate",
                value: new DateTime(2021, 12, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4540));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000020"),
                column: "EnrollDate",
                value: new DateTime(2024, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4540));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000021"),
                column: "EnrollDate",
                value: new DateTime(2021, 12, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4550));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000022"),
                column: "EnrollDate",
                value: new DateTime(2022, 4, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4550));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000023"),
                column: "EnrollDate",
                value: new DateTime(2021, 12, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4550));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000024"),
                column: "EnrollDate",
                value: new DateTime(2022, 10, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4550));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000025"),
                column: "EnrollDate",
                value: new DateTime(2023, 10, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4550));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000026"),
                column: "EnrollDate",
                value: new DateTime(2024, 1, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4560));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000027"),
                column: "EnrollDate",
                value: new DateTime(2021, 3, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4560));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000028"),
                column: "EnrollDate",
                value: new DateTime(2024, 4, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4560));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000029"),
                column: "EnrollDate",
                value: new DateTime(2022, 11, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4560));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000030"),
                column: "EnrollDate",
                value: new DateTime(2022, 9, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4560));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000031"),
                column: "EnrollDate",
                value: new DateTime(2023, 11, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4570));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000032"),
                column: "EnrollDate",
                value: new DateTime(2022, 11, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4570));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000033"),
                column: "EnrollDate",
                value: new DateTime(2022, 1, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4570));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000034"),
                column: "EnrollDate",
                value: new DateTime(2021, 9, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4570));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000035"),
                column: "EnrollDate",
                value: new DateTime(2021, 2, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4570));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000036"),
                column: "EnrollDate",
                value: new DateTime(2021, 12, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4580));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000037"),
                column: "EnrollDate",
                value: new DateTime(2021, 8, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4580));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000038"),
                column: "EnrollDate",
                value: new DateTime(2021, 8, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4580));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000039"),
                column: "EnrollDate",
                value: new DateTime(2020, 12, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4580));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000040"),
                column: "EnrollDate",
                value: new DateTime(2022, 6, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4580));

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { new Guid("00a8e380-0784-4161-9c6b-c7f4bf2b5812"), new DateTime(2025, 5, 19, 16, 47, 30, 866, DateTimeKind.Utc).AddTicks(2830), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000039") },
                    { new Guid("0d538fe7-2138-41c8-ac0f-cafeac2b457a"), new DateTime(2025, 5, 19, 16, 47, 30, 866, DateTimeKind.Utc).AddTicks(2750), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000019") },
                    { new Guid("14ddcbde-efbc-4484-8a53-da0ac6de7382"), new DateTime(2025, 5, 19, 16, 47, 30, 866, DateTimeKind.Utc).AddTicks(2720), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000010") },
                    { new Guid("161b3248-5457-4a65-bdd6-a4c73d84ed24"), new DateTime(2025, 5, 19, 16, 47, 30, 866, DateTimeKind.Utc).AddTicks(2840), null, new Guid("00000000-0000-0000-0000-000000000004"), null, new Guid("40000000-0000-0000-0000-000000000041") },
                    { new Guid("207a6718-42b2-49be-b077-e7f13654a2e0"), new DateTime(2025, 5, 19, 16, 47, 30, 866, DateTimeKind.Utc).AddTicks(2800), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000032") },
                    { new Guid("22138332-8af8-4f2a-921b-08d7b6e08276"), new DateTime(2025, 5, 19, 16, 47, 30, 866, DateTimeKind.Utc).AddTicks(2740), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000016") },
                    { new Guid("2b9c988e-a180-4b9a-8257-17745101ff22"), new DateTime(2025, 5, 19, 16, 47, 30, 866, DateTimeKind.Utc).AddTicks(2710), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000007") },
                    { new Guid("2e202f4e-791a-49a7-a3a1-951abebedde3"), new DateTime(2025, 5, 19, 16, 47, 30, 866, DateTimeKind.Utc).AddTicks(2690), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000004") },
                    { new Guid("315e8219-1bea-4d4e-957f-ff8feb4207af"), new DateTime(2025, 5, 19, 16, 47, 30, 866, DateTimeKind.Utc).AddTicks(2730), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000013") },
                    { new Guid("362f230a-140c-40f2-b70a-471c5832f6a0"), new DateTime(2025, 5, 19, 16, 47, 30, 866, DateTimeKind.Utc).AddTicks(2780), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000028") },
                    { new Guid("394f81e4-fa7c-42f6-b794-a9dbbbf84773"), new DateTime(2025, 5, 19, 16, 47, 30, 866, DateTimeKind.Utc).AddTicks(2770), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000024") },
                    { new Guid("3a5fb049-9b84-4c8a-9e42-f012b2780515"), new DateTime(2025, 5, 19, 16, 47, 30, 866, DateTimeKind.Utc).AddTicks(2820), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000036") },
                    { new Guid("3d12c4d2-0624-4694-92bc-65df6bba9a8a"), new DateTime(2025, 5, 19, 16, 47, 30, 866, DateTimeKind.Utc).AddTicks(2860), null, new Guid("00000000-0000-0000-0000-000000000003"), null, new Guid("40000000-0000-0000-0000-000000000048") },
                    { new Guid("3fbb46cf-503e-4118-8a3b-18dc728662a5"), new DateTime(2025, 5, 19, 16, 47, 30, 866, DateTimeKind.Utc).AddTicks(2790), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000029") },
                    { new Guid("561eae80-a1dd-40a1-b653-564794706097"), new DateTime(2025, 5, 19, 16, 47, 30, 866, DateTimeKind.Utc).AddTicks(2850), null, new Guid("00000000-0000-0000-0000-000000000004"), null, new Guid("40000000-0000-0000-0000-000000000045") },
                    { new Guid("5ae8e903-b9d6-4dc6-9ac2-c61e8d678c97"), new DateTime(2025, 5, 19, 16, 47, 30, 866, DateTimeKind.Utc).AddTicks(2860), null, new Guid("00000000-0000-0000-0000-000000000004"), null, new Guid("40000000-0000-0000-0000-000000000047") },
                    { new Guid("5d5815a7-e868-463d-b8cc-fb761617e172"), new DateTime(2025, 5, 19, 16, 47, 30, 866, DateTimeKind.Utc).AddTicks(2810), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000034") },
                    { new Guid("657f8cd5-0101-44f1-a431-4ad82c7be4d5"), new DateTime(2025, 5, 19, 16, 47, 30, 866, DateTimeKind.Utc).AddTicks(2730), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000014") },
                    { new Guid("6e2173f7-e1c5-4047-b181-585fe9ede51b"), new DateTime(2025, 5, 19, 16, 47, 30, 866, DateTimeKind.Utc).AddTicks(2860), null, new Guid("00000000-0000-0000-0000-000000000003"), null, new Guid("40000000-0000-0000-0000-000000000049") },
                    { new Guid("7f5dffd6-8240-453c-a0a6-97f92e200a4f"), new DateTime(2025, 5, 19, 16, 47, 30, 866, DateTimeKind.Utc).AddTicks(2830), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000040") },
                    { new Guid("83183995-9ed2-45da-ac4e-70dbf1464c09"), new DateTime(2025, 5, 19, 16, 47, 30, 866, DateTimeKind.Utc).AddTicks(2800), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000030") },
                    { new Guid("83f6e832-95d9-4829-91f3-6db15b924e4e"), new DateTime(2025, 5, 19, 16, 47, 30, 866, DateTimeKind.Utc).AddTicks(2850), null, new Guid("00000000-0000-0000-0000-000000000003"), null, new Guid("40000000-0000-0000-0000-000000000046") },
                    { new Guid("8640fae5-ec8c-4099-934e-2aab5a0da027"), new DateTime(2025, 5, 19, 16, 47, 30, 866, DateTimeKind.Utc).AddTicks(2770), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000023") },
                    { new Guid("866ac58f-40c4-4d97-a24f-4be73803d792"), new DateTime(2025, 5, 19, 16, 47, 30, 866, DateTimeKind.Utc).AddTicks(2710), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000008") },
                    { new Guid("8729e819-bdff-44ea-8a7d-c97bfe70ce44"), new DateTime(2025, 5, 19, 16, 47, 30, 866, DateTimeKind.Utc).AddTicks(2750), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000020") },
                    { new Guid("8a30d6fe-7684-42d3-b6bb-5b72be60c20f"), new DateTime(2025, 5, 19, 16, 47, 30, 866, DateTimeKind.Utc).AddTicks(2760), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000021") },
                    { new Guid("9540d197-59ef-4fe7-9e03-56e0d0b75868"), new DateTime(2025, 5, 19, 16, 47, 30, 866, DateTimeKind.Utc).AddTicks(2720), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000011") },
                    { new Guid("9e912019-841f-4607-a381-3069a8eb0cd2"), new DateTime(2025, 5, 19, 16, 47, 30, 866, DateTimeKind.Utc).AddTicks(2820), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000038") },
                    { new Guid("9f112cfe-183a-4450-b818-a8204a709424"), new DateTime(2025, 5, 19, 16, 47, 30, 866, DateTimeKind.Utc).AddTicks(2770), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000025") },
                    { new Guid("a363217d-5606-4456-9abd-de9696de7ed2"), new DateTime(2025, 5, 19, 16, 47, 30, 866, DateTimeKind.Utc).AddTicks(2820), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000037") },
                    { new Guid("a5b4d40c-5b2b-467a-a335-edf2999443fe"), new DateTime(2025, 5, 19, 16, 47, 30, 866, DateTimeKind.Utc).AddTicks(2680), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000001") },
                    { new Guid("a70d3679-533d-4ec7-9755-e62f466ca777"), new DateTime(2025, 5, 19, 16, 47, 30, 866, DateTimeKind.Utc).AddTicks(2710), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000009") },
                    { new Guid("a79249e2-a2de-4e29-aebe-058002bd2827"), new DateTime(2025, 5, 19, 16, 47, 30, 866, DateTimeKind.Utc).AddTicks(2810), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000033") },
                    { new Guid("aca7b8f7-260e-49c5-a889-d9a16e44a7e6"), new DateTime(2025, 5, 19, 16, 47, 30, 866, DateTimeKind.Utc).AddTicks(2870), null, new Guid("00000000-0000-0000-0000-000000000004"), null, new Guid("40000000-0000-0000-0000-000000000050") },
                    { new Guid("b394b56f-9c21-4b18-845f-7692163fa8c8"), new DateTime(2025, 5, 19, 16, 47, 30, 866, DateTimeKind.Utc).AddTicks(2720), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000012") },
                    { new Guid("bf897ac2-5ecd-48c9-8ab7-b9aec7bb0640"), new DateTime(2025, 5, 19, 16, 47, 30, 866, DateTimeKind.Utc).AddTicks(2840), null, new Guid("00000000-0000-0000-0000-000000000004"), null, new Guid("40000000-0000-0000-0000-000000000042") },
                    { new Guid("c200d32b-1165-4a34-88c8-7ee20eecacdd"), new DateTime(2025, 5, 19, 16, 47, 30, 866, DateTimeKind.Utc).AddTicks(2690), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000003") },
                    { new Guid("c379c319-a5f5-46c7-b1e3-9d2105c3a755"), new DateTime(2025, 5, 19, 16, 47, 30, 866, DateTimeKind.Utc).AddTicks(2780), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000027") },
                    { new Guid("c42fc6f9-deff-4fd7-80c0-e3e0790b41cd"), new DateTime(2025, 5, 19, 16, 47, 30, 866, DateTimeKind.Utc).AddTicks(2760), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000022") },
                    { new Guid("ca8d4a29-a9a0-4cb2-bb3f-1eb260978c7b"), new DateTime(2025, 5, 19, 16, 47, 30, 866, DateTimeKind.Utc).AddTicks(2850), null, new Guid("00000000-0000-0000-0000-000000000006"), null, new Guid("40000000-0000-0000-0000-000000000044") },
                    { new Guid("cba642e5-5f07-46d9-954b-436b934ea7d5"), new DateTime(2025, 5, 19, 16, 47, 30, 866, DateTimeKind.Utc).AddTicks(2800), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000031") },
                    { new Guid("ccd1833b-70eb-4811-8d83-5de1179c9090"), new DateTime(2025, 5, 19, 16, 47, 30, 866, DateTimeKind.Utc).AddTicks(2740), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000015") },
                    { new Guid("d4e8f068-0a9c-4e92-b993-1eb36d52d77c"), new DateTime(2025, 5, 19, 16, 47, 30, 866, DateTimeKind.Utc).AddTicks(2700), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000006") },
                    { new Guid("d6214e85-39b5-4e49-a1d1-f110ade0413b"), new DateTime(2025, 5, 19, 16, 47, 30, 866, DateTimeKind.Utc).AddTicks(2840), null, new Guid("00000000-0000-0000-0000-000000000005"), null, new Guid("40000000-0000-0000-0000-000000000043") },
                    { new Guid("e8a8bb91-eb00-4728-8609-b964ab9cb0d9"), new DateTime(2025, 5, 19, 16, 47, 30, 866, DateTimeKind.Utc).AddTicks(2690), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000002") },
                    { new Guid("eb200b6e-8ded-4632-9946-4d6b650c11d1"), new DateTime(2025, 5, 19, 16, 47, 30, 866, DateTimeKind.Utc).AddTicks(2750), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000018") },
                    { new Guid("f43b6f6f-8e0f-4560-b89b-209803e15725"), new DateTime(2025, 5, 19, 16, 47, 30, 866, DateTimeKind.Utc).AddTicks(2780), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000026") },
                    { new Guid("f66ea9c5-cc96-42e7-b97e-2e622d2a7bbd"), new DateTime(2025, 5, 19, 16, 47, 30, 866, DateTimeKind.Utc).AddTicks(2700), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000005") },
                    { new Guid("f749eb0a-d870-4637-83e7-c137f77f9be3"), new DateTime(2025, 5, 19, 16, 47, 30, 866, DateTimeKind.Utc).AddTicks(2740), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000017") },
                    { new Guid("fbb112ef-3787-4572-b222-b0aa25d3e33b"), new DateTime(2025, 5, 19, 16, 47, 30, 866, DateTimeKind.Utc).AddTicks(2810), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000035") }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-11111111111a"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 113, 202, 15, 151, 31, 243, 89, 79, 69, 250, 196, 254, 240, 8, 166, 217, 224, 123, 170, 26, 170, 6, 220, 235, 189, 73, 191, 124, 243, 25, 43, 148, 178, 46, 180, 87, 11, 182, 215, 100, 166, 78, 213, 218, 144, 148, 249, 145, 43, 160, 246, 235, 53, 2, 253, 202, 52, 229, 86, 85, 189, 218, 118, 6 }, new byte[] { 23, 29, 117, 225, 167, 176, 239, 243, 54, 114, 183, 107, 126, 0, 177, 211, 62, 40, 50, 107, 181, 225, 124, 190, 3, 197, 104, 225, 164, 233, 110, 242, 103, 6, 91, 185, 99, 226, 152, 143, 38, 91, 106, 31, 69, 153, 11, 159, 76, 225, 149, 8, 48, 39, 132, 15, 250, 202, 236, 37, 216, 67, 156, 181, 24, 86, 147, 18, 102, 239, 216, 16, 213, 32, 110, 91, 98, 235, 119, 47, 56, 6, 175, 255, 101, 99, 124, 85, 15, 157, 101, 77, 175, 17, 245, 175, 217, 215, 77, 93, 144, 208, 241, 166, 198, 163, 63, 108, 212, 40, 177, 185, 242, 116, 47, 45, 176, 215, 202, 238, 191, 128, 1, 150, 9, 111, 54, 90 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-22222222222a"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 164, 216, 172, 206, 120, 91, 32, 66, 31, 19, 162, 6, 214, 127, 95, 220, 200, 74, 209, 52, 173, 61, 145, 207, 60, 236, 251, 246, 169, 42, 119, 91, 52, 9, 111, 236, 150, 115, 203, 184, 190, 0, 172, 30, 159, 184, 107, 53, 19, 110, 249, 44, 87, 106, 40, 168, 160, 65, 176, 83, 120, 83, 156, 192 }, new byte[] { 136, 116, 243, 65, 190, 108, 191, 197, 94, 2, 140, 245, 69, 58, 179, 30, 63, 133, 164, 98, 222, 171, 6, 186, 61, 221, 134, 241, 164, 75, 35, 110, 22, 125, 203, 43, 51, 22, 254, 221, 9, 157, 2, 15, 166, 235, 18, 219, 35, 77, 160, 132, 65, 155, 196, 66, 145, 218, 251, 50, 28, 3, 215, 160, 166, 236, 55, 178, 121, 166, 191, 138, 65, 221, 183, 9, 17, 40, 163, 174, 180, 43, 43, 114, 247, 2, 155, 58, 202, 201, 99, 120, 101, 104, 22, 175, 11, 117, 30, 113, 131, 149, 219, 140, 120, 141, 142, 10, 178, 144, 40, 134, 20, 153, 144, 211, 56, 16, 51, 62, 188, 78, 216, 175, 189, 208, 114, 81 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-33333333333a"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 61, 186, 31, 145, 88, 222, 0, 157, 89, 126, 169, 119, 232, 103, 163, 165, 244, 14, 34, 149, 16, 223, 188, 136, 248, 221, 117, 226, 231, 207, 219, 15, 101, 163, 167, 82, 22, 168, 142, 148, 209, 32, 14, 242, 125, 179, 247, 43, 212, 46, 36, 93, 17, 136, 180, 191, 214, 144, 43, 54, 97, 39, 213, 35 }, new byte[] { 123, 169, 225, 151, 247, 64, 137, 16, 124, 29, 24, 213, 131, 163, 187, 25, 75, 39, 22, 73, 98, 94, 165, 195, 197, 72, 97, 207, 112, 91, 77, 98, 165, 137, 10, 189, 238, 204, 110, 62, 86, 228, 224, 145, 88, 250, 141, 108, 6, 65, 11, 254, 239, 16, 183, 8, 238, 17, 251, 106, 55, 63, 188, 238, 183, 16, 92, 41, 60, 88, 254, 14, 241, 74, 55, 114, 105, 113, 199, 10, 58, 250, 68, 71, 181, 179, 106, 179, 241, 103, 59, 205, 190, 188, 251, 125, 76, 108, 132, 19, 116, 43, 210, 191, 37, 3, 191, 116, 68, 107, 100, 51, 246, 220, 1, 140, 173, 23, 14, 173, 106, 123, 24, 128, 82, 97, 216, 239 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000001"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000002"),
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "veli.kaya.s2@std.iyte.edu.tr", "Veli", "Kaya", new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 }, "veli.kaya.s2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000003"),
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "deniz.kaya.s3@std.iyte.edu.tr", "Deniz", "Kaya", new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 }, "deniz.kaya.s3" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000004"),
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "mehmet.aydin.s4@std.iyte.edu.tr", "Mehmet", "Aydın", new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 }, "mehmet.aydin.s4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000005"),
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "ayse.dogan.s5@std.iyte.edu.tr", "Ayşe", "Doğan", new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 }, "ayse.dogan.s5" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000006"),
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "murat.celik.s6@std.iyte.edu.tr", "Murat", "Çelik", new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 }, "murat.celik.s6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000007"),
                columns: new[] { "Email", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "hatice.yilmaz.s7@std.iyte.edu.tr", "Yılmaz", new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 }, "hatice.yilmaz.s7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000008"),
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "murat.celik.s8@std.iyte.edu.tr", "Murat", "Çelik", new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 }, "murat.celik.s8" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000009"),
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "hatice.kaya.s9@std.iyte.edu.tr", "Hatice", "Kaya", new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 }, "hatice.kaya.s9" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000010"),
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "veli.dogan.s10@std.iyte.edu.tr", "Veli", "Doğan", new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 }, "veli.dogan.s10" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000011"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000012"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000013"),
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "fatma.sahin.s13@std.iyte.edu.tr", "Fatma", "Şahin", new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 }, "fatma.sahin.s13" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000014"),
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "huseyin.demir.s14@std.iyte.edu.tr", "Hüseyin", "Demir", new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 }, "huseyin.demir.s14" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000015"),
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "hatice.demir.s15@std.iyte.edu.tr", "Hatice", "Demir", new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 }, "hatice.demir.s15" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000016"),
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "murat.demir.s16@std.iyte.edu.tr", "Murat", "Demir", new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 }, "murat.demir.s16" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000017"),
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "ayse.celik.s17@std.iyte.edu.tr", "Ayşe", "Çelik", new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 }, "ayse.celik.s17" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000018"),
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "ali.celik.s18@std.iyte.edu.tr", "Ali", "Çelik", new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 }, "ali.celik.s18" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000019"),
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "hatice.dogan.s19@std.iyte.edu.tr", "Hatice", "Doğan", new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 }, "hatice.dogan.s19" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000020"),
                columns: new[] { "Email", "FirstName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "veli.sahin.s20@std.iyte.edu.tr", "Veli", new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 }, "veli.sahin.s20" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000021"),
                columns: new[] { "Email", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "ebru.dogan.s21@std.iyte.edu.tr", "Doğan", new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 }, "ebru.dogan.s21" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000022"),
                columns: new[] { "Email", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "mehmet.kaya.s22@std.iyte.edu.tr", "Kaya", new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 }, "mehmet.kaya.s22" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000023"),
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "fatma.yilmaz.s23@std.iyte.edu.tr", "Fatma", "Yılmaz", new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 }, "fatma.yilmaz.s23" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000024"),
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "mehmet.dogan.s24@std.iyte.edu.tr", "Mehmet", "Doğan", new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 }, "mehmet.dogan.s24" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000025"),
                columns: new[] { "Email", "FirstName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "fatma.dogan.s25@std.iyte.edu.tr", "Fatma", new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 }, "fatma.dogan.s25" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000026"),
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "emre.dogan.s26@std.iyte.edu.tr", "Emre", "Doğan", new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 }, "emre.dogan.s26" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000027"),
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "ebru.arslan.s27@std.iyte.edu.tr", "Ebru", "Arslan", new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 }, "ebru.arslan.s27" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000028"),
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "mustafa.ozturk.s28@std.iyte.edu.tr", "Mustafa", "Öztürk", new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 }, "mustafa.ozturk.s28" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000029"),
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "ayse.sahin.s29@std.iyte.edu.tr", "Ayşe", "Şahin", new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 }, "ayse.sahin.s29" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000030"),
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "veli.aydin.s30@std.iyte.edu.tr", "Veli", "Aydın", new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 }, "veli.aydin.s30" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000031"),
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "ebru.yildiz.s31@std.iyte.edu.tr", "Ebru", "Yıldız", new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 }, "ebru.yildiz.s31" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000032"),
                columns: new[] { "Email", "FirstName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "ali.celik.s32@std.iyte.edu.tr", "Ali", new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 }, "ali.celik.s32" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000033"),
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "selin.celik.s33@std.iyte.edu.tr", "Selin", "Çelik", new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 }, "selin.celik.s33" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000034"),
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "burak.aydin.s34@std.iyte.edu.tr", "Burak", "Aydın", new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 }, "burak.aydin.s34" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000035"),
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "ebru.demir.s35@std.iyte.edu.tr", "Ebru", "Demir", new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 }, "ebru.demir.s35" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000036"),
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "mehmet.demir.s36@std.iyte.edu.tr", "Mehmet", "Demir", new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 }, "mehmet.demir.s36" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000037"),
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "ebru.arslan.s37@std.iyte.edu.tr", "Ebru", "Arslan", new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 }, "ebru.arslan.s37" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000038"),
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "murat.celik.s38@std.iyte.edu.tr", "Murat", "Çelik", new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 }, "murat.celik.s38" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000039"),
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "hatice.yilmaz.s39@std.iyte.edu.tr", "Hatice", "Yılmaz", new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 }, "hatice.yilmaz.s39" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000040"),
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "emre.aydin.s40@std.iyte.edu.tr", "Emre", "Aydın", new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 }, "emre.aydin.s40" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000041"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000042"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000043"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000044"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000045"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000046"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000047"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000048"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000049"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000050"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-44444444444a"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 86, 23, 214, 69, 159, 155, 79, 218, 61, 202, 124, 32, 101, 21, 59, 249, 71, 235, 162, 29, 134, 205, 157, 151, 24, 215, 67, 208, 149, 245, 127, 12, 147, 1, 27, 218, 117, 85, 224, 162, 160, 42, 123, 91, 34, 163, 76, 105, 74, 240, 197, 209, 56, 95, 98, 137, 217, 240, 65, 105, 42, 106, 77, 107 }, new byte[] { 119, 219, 234, 222, 199, 116, 88, 237, 232, 227, 221, 95, 94, 45, 169, 118, 179, 171, 74, 28, 118, 33, 254, 34, 211, 131, 206, 35, 220, 230, 1, 92, 157, 183, 136, 194, 134, 106, 205, 236, 96, 126, 152, 7, 48, 9, 55, 149, 95, 124, 32, 13, 107, 75, 11, 52, 12, 97, 64, 178, 1, 8, 45, 238, 30, 25, 185, 252, 81, 163, 231, 103, 40, 230, 8, 46, 17, 28, 218, 184, 158, 177, 26, 209, 216, 220, 132, 236, 137, 125, 140, 227, 218, 99, 132, 222, 121, 165, 188, 130, 176, 123, 203, 141, 166, 168, 144, 161, 35, 95, 150, 100, 97, 180, 192, 24, 15, 113, 28, 183, 58, 158, 153, 126, 18, 254, 243, 207 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-55555555555a"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 213, 17, 119, 212, 22, 232, 128, 83, 161, 47, 72, 235, 148, 47, 143, 201, 47, 43, 24, 190, 183, 47, 242, 172, 159, 16, 203, 146, 116, 164, 80, 239, 21, 1, 101, 81, 65, 105, 120, 79, 127, 10, 199, 7, 7, 164, 23, 76, 216, 85, 70, 47, 139, 180, 190, 115, 51, 174, 162, 132, 127, 248, 69, 180 }, new byte[] { 126, 250, 143, 208, 163, 177, 56, 82, 10, 125, 194, 236, 51, 245, 49, 182, 76, 58, 28, 2, 68, 21, 178, 211, 170, 205, 247, 163, 164, 164, 116, 68, 83, 121, 187, 174, 75, 139, 212, 190, 248, 212, 172, 231, 115, 182, 150, 226, 240, 224, 26, 198, 157, 117, 97, 196, 157, 127, 50, 144, 192, 250, 96, 140, 197, 105, 129, 173, 192, 42, 121, 111, 176, 7, 145, 27, 170, 48, 169, 38, 50, 78, 102, 237, 82, 196, 206, 53, 67, 20, 106, 228, 167, 184, 10, 21, 105, 125, 250, 72, 63, 213, 239, 6, 133, 231, 239, 141, 78, 134, 121, 63, 33, 209, 95, 129, 62, 216, 93, 155, 87, 164, 71, 109, 101, 25, 225, 235 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-66666666666a"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 119, 50, 205, 132, 162, 134, 164, 96, 24, 158, 221, 130, 250, 242, 243, 105, 226, 86, 122, 13, 243, 250, 223, 182, 227, 136, 170, 9, 43, 60, 27, 146, 184, 151, 168, 149, 29, 133, 245, 153, 213, 126, 176, 64, 4, 254, 152, 16, 153, 150, 162, 81, 51, 175, 56, 15, 199, 232, 185, 232, 91, 165, 254, 80 }, new byte[] { 114, 11, 167, 235, 171, 40, 191, 118, 52, 148, 178, 186, 160, 217, 83, 187, 180, 252, 202, 32, 222, 146, 156, 197, 187, 150, 99, 48, 53, 197, 52, 106, 247, 156, 158, 208, 51, 19, 219, 33, 100, 158, 75, 49, 61, 197, 200, 149, 100, 97, 172, 170, 203, 165, 122, 128, 100, 179, 100, 174, 186, 25, 142, 168, 138, 96, 133, 195, 91, 137, 0, 94, 216, 21, 26, 184, 232, 58, 12, 44, 88, 187, 189, 172, 241, 101, 14, 91, 250, 212, 88, 150, 63, 244, 231, 85, 7, 31, 218, 195, 250, 154, 74, 112, 162, 174, 166, 45, 93, 182, 164, 33, 52, 106, 29, 225, 236, 142, 250, 17, 130, 184, 137, 196, 19, 111, 6, 147 } });

            migrationBuilder.CreateIndex(
                name: "IX_TranscriptDatas_SourceFileAttachmentId",
                table: "TranscriptDatas",
                column: "SourceFileAttachmentId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TranscriptDatas_FileAttachments_SourceFileAttachmentId",
                table: "TranscriptDatas",
                column: "SourceFileAttachmentId",
                principalTable: "FileAttachments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
