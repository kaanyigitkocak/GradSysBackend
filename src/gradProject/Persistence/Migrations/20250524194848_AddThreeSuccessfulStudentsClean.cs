using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddThreeSuccessfulStudentsClean : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000081"));

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000082"));

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000083"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("02fdbb2e-2fb4-4027-a7fe-4eeb2ad85917"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("057485b0-b76c-4751-8da0-4a0802b25769"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("0cde453e-cc1e-407e-840c-b7b04b6a30f4"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("12e44783-b939-476c-a595-9c419d5e9189"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("130b8458-7d62-4ad8-9135-a615852b7d42"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("1e82ba93-adf3-49b6-bfb5-967b159a6917"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("1fa2cd18-2a41-450f-a5c0-9fd92eaa56c3"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("25ea79aa-6f54-4c7c-8198-53884b0497d0"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("268288e3-fb11-4ac0-b4d3-1ef34c299e77"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("27482b89-20fa-44f8-b5aa-ed82a18af717"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("294c9065-ed90-411f-bc9b-9452ae6bdfcf"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("31998013-c1a4-49a9-bd69-577f7c74d19a"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("3bb2b31e-649b-4bee-bf89-771abb820585"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("3ce68ba8-9001-431f-b8bd-b76ac0ba6220"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("47841661-de5f-4cc0-916d-1dd933908138"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("48a21386-af9e-4e6a-8f2d-880ee8010f95"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("4ae05145-1c72-4714-b068-130e3e543355"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("4ca91565-312e-46eb-a442-edae0be4f526"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("4f5cc30c-d6d7-4c97-8ea6-537931713f8c"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("58ae7f08-ac69-471c-b13f-4109608d99b8"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("62b320c3-af5f-4ed4-bf65-70170b656301"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("66dfc8c8-8aef-4fed-8346-a3ac40e7f97c"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("6b58321d-8743-473b-9f02-e8687f07436c"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("6fccd1c4-3414-448c-884e-b3840b9c0ae4"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("70838eb4-7ecf-43e8-b8d3-161847ea7426"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("751bf3bc-c2c9-428f-b141-bf1f7c3d4b51"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("778e7a3c-8676-477a-8b34-c9311a42a420"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("79d64ec0-baae-458b-b8a3-c4d6439f5dc7"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("7c8306ee-7843-4f4d-9fb3-7476140560ef"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("7d9a6b05-ae4b-4c12-96a9-849db1be2cfe"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("80d01e65-7263-40a6-b243-e44ba9c9994b"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("87f5c42f-cff4-4fd6-83d0-c259a8c59560"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("8eb10d57-ed82-4989-b7ac-31ab6ea41574"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("9906b76c-e22b-4d6f-afef-c21e56ac6f38"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("9db26e8e-ed44-4da4-97fb-663fe04dc9ee"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("9edbbeea-1978-4d25-80bd-2dabdc73e663"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("a685b572-90e7-41ac-8554-6820ead39af9"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("a7bebcfa-b6cd-4ebe-9dda-308f043a0198"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("ac612cb3-dc61-42f2-8c8c-8ab77d598e6a"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("ad468fe3-398e-4f1d-b4a5-b11371ba1683"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("ae703d06-c3fa-428f-888a-df4344116f43"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("b1314655-5f4d-4a5d-843f-05c1ff02b676"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("b7a67f3b-7b42-4df3-ade1-36cb6c164a03"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("d3072146-48e9-4b64-b516-1e6dc7a0dd71"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("de76eb73-6b21-4ab5-b2bf-6e381e2151e9"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("eeefcca8-d63d-4d69-9bb0-74a4a293779d"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("f085dcd2-c5ae-471f-a4d2-c31b9898bb5e"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("f4bc7abf-33a4-4de4-a2f7-48ce188a0b65"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("fd8b5768-78cd-4e78-8228-4dec539138d9"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("fdcbf010-91b0-461c-ba49-d3b299e77131"));

            migrationBuilder.InsertData(
                table: "CourseTakens",
                columns: new[] { "Id", "CourseCodeInTranscript", "CourseNameInTranscript", "CreatedDate", "CreditsEarned", "DeletedDate", "Grade", "IsSuccessfullyCompleted", "MatchedCourseId", "SemesterTaken", "StudentUserId", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("50000000-0000-0000-0000-000000004557"), "MATH 141", "Calculus I", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 5, null, "BA", true, new Guid("30000000-0000-0000-0000-000000000001"), "2023-2024 Fall", new Guid("40000000-0000-0000-0000-000000000081"), null },
                    { new Guid("50000000-0000-0000-0000-000000004558"), "PHYS 121", "Physics I", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 7, null, "BA", true, new Guid("30000000-0000-0000-0000-000000000002"), "2023-2024 Spring", new Guid("40000000-0000-0000-0000-000000000081"), null },
                    { new Guid("50000000-0000-0000-0000-000000004559"), "CENG 111", "Introduction to Computer Engineering", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 5, null, "BB", true, new Guid("30000000-0000-0000-0000-000000000003"), "2020-2021 Spring", new Guid("40000000-0000-0000-0000-000000000081"), null },
                    { new Guid("50000000-0000-0000-0000-000000004560"), "CENG 113", "Introduction to Programming", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 6, null, "BA", true, new Guid("30000000-0000-0000-0000-000000000004"), "2023-2024 Spring", new Guid("40000000-0000-0000-0000-000000000081"), null },
                    { new Guid("50000000-0000-0000-0000-000000004561"), "CENG 115", "Discrete Structures", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 5, null, "BA", true, new Guid("30000000-0000-0000-0000-000000000005"), "2020-2021 Spring", new Guid("40000000-0000-0000-0000-000000000081"), null },
                    { new Guid("50000000-0000-0000-0000-000000004562"), "ENG 101", "Academic English I", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, null, "BA", true, new Guid("30000000-0000-0000-0000-000000000006"), "2020-2021 Fall", new Guid("40000000-0000-0000-0000-000000000081"), null },
                    { new Guid("50000000-0000-0000-0000-000000004563"), "MATH 142", "Calculus II", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 6, null, "AA", true, new Guid("30000000-0000-0000-0000-000000000007"), "2023-2024 Spring", new Guid("40000000-0000-0000-0000-000000000081"), null },
                    { new Guid("50000000-0000-0000-0000-000000004564"), "PHYS 122", "Physics II", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 8, null, "BB", true, new Guid("30000000-0000-0000-0000-000000000008"), "2022-2023 Fall", new Guid("40000000-0000-0000-0000-000000000081"), null },
                    { new Guid("50000000-0000-0000-0000-000000004565"), "MATH 144", "Finite Mathematics", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 5, null, "BB", true, new Guid("30000000-0000-0000-0000-000000000009"), "2022-2023 Fall", new Guid("40000000-0000-0000-0000-000000000081"), null },
                    { new Guid("50000000-0000-0000-0000-000000004566"), "CENG 112", "Data Structures", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 5, null, "BA", true, new Guid("30000000-0000-0000-0000-000000000010"), "2020-2021 Fall", new Guid("40000000-0000-0000-0000-000000000081"), null },
                    { new Guid("50000000-0000-0000-0000-000000004567"), "ECON 106", "Principles of Economics", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, null, "BB", true, new Guid("30000000-0000-0000-0000-000000000011"), "2021-2022 Fall", new Guid("40000000-0000-0000-0000-000000000081"), null },
                    { new Guid("50000000-0000-0000-0000-000000004568"), "ENG 102", "Academic English II", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, null, "AA", true, new Guid("30000000-0000-0000-0000-000000000012"), "2021-2022 Spring", new Guid("40000000-0000-0000-0000-000000000081"), null },
                    { new Guid("50000000-0000-0000-0000-000000004569"), "GCC 101", "Career Planning and Development", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 0, null, "AA", true, new Guid("30000000-0000-0000-0000-000000000013"), "2023-2024 Fall", new Guid("40000000-0000-0000-0000-000000000081"), null },
                    { new Guid("50000000-0000-0000-0000-000000004570"), "CENG 211", "Fundamentals of Programming", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 5, null, "BA", true, new Guid("30000000-0000-0000-0000-000000000014"), "2022-2023 Fall", new Guid("40000000-0000-0000-0000-000000000081"), null },
                    { new Guid("50000000-0000-0000-0000-000000004571"), "CENG 213", "Theory of Computation", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 5, null, "BA", true, new Guid("30000000-0000-0000-0000-000000000015"), "2023-2024 Fall", new Guid("40000000-0000-0000-0000-000000000081"), null },
                    { new Guid("50000000-0000-0000-0000-000000004572"), "CENG 215", "Circuits and Electronics", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 6, null, "AA", true, new Guid("30000000-0000-0000-0000-000000000016"), "2020-2021 Spring", new Guid("40000000-0000-0000-0000-000000000081"), null },
                    { new Guid("50000000-0000-0000-0000-000000004573"), "MATH 255", "Differential Equations", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 6, null, "AA", true, new Guid("30000000-0000-0000-0000-000000000017"), "2022-2023 Fall", new Guid("40000000-0000-0000-0000-000000000081"), null },
                    { new Guid("50000000-0000-0000-0000-000000004574"), "HIST 201", "History of Turkish Republic I", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2, null, "BA", true, new Guid("30000000-0000-0000-0000-000000000018"), "2024-2025 Fall", new Guid("40000000-0000-0000-0000-000000000081"), null },
                    { new Guid("50000000-0000-0000-0000-000000004575"), "TURK 201", "Turkish Language I", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2, null, "BB", true, new Guid("30000000-0000-0000-0000-000000000019"), "2024-2025 Fall", new Guid("40000000-0000-0000-0000-000000000081"), null },
                    { new Guid("50000000-0000-0000-0000-000000004576"), "HIST 203", "History of Turkish Revolution I", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2, null, "BA", true, new Guid("30000000-0000-0000-0000-000000000020"), "2023-2024 Fall", new Guid("40000000-0000-0000-0000-000000000081"), null },
                    { new Guid("50000000-0000-0000-0000-000000004577"), "TURK 203", "Turkish for International Students I", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2, null, "AA", true, new Guid("30000000-0000-0000-0000-000000000021"), "2020-2021 Spring", new Guid("40000000-0000-0000-0000-000000000081"), null },
                    { new Guid("50000000-0000-0000-0000-000000004578"), "CENG 212", "Programming Language Concepts", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 5, null, "AA", true, new Guid("30000000-0000-0000-0000-000000000022"), "2020-2021 Spring", new Guid("40000000-0000-0000-0000-000000000081"), null },
                    { new Guid("50000000-0000-0000-0000-000000004579"), "CENG 214", "Logic Design", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 6, null, "BA", true, new Guid("30000000-0000-0000-0000-000000000023"), "2021-2022 Spring", new Guid("40000000-0000-0000-0000-000000000081"), null },
                    { new Guid("50000000-0000-0000-0000-000000004580"), "CENG 216", "Numerical Computing", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 5, null, "AA", true, new Guid("30000000-0000-0000-0000-000000000024"), "2023-2024 Spring", new Guid("40000000-0000-0000-0000-000000000081"), null },
                    { new Guid("50000000-0000-0000-0000-000000004581"), "CENG 218", "Analysis and Design of Algorithms", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 5, null, "AA", true, new Guid("30000000-0000-0000-0000-000000000025"), "2023-2024 Spring", new Guid("40000000-0000-0000-0000-000000000081"), null },
                    { new Guid("50000000-0000-0000-0000-000000004582"), "CENG 222", "Probability and Statistics", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 5, null, "AA", true, new Guid("30000000-0000-0000-0000-000000000026"), "2023-2024 Spring", new Guid("40000000-0000-0000-0000-000000000081"), null },
                    { new Guid("50000000-0000-0000-0000-000000004583"), "HIST 202", "History of Turkish Republic II", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2, null, "BA", true, new Guid("30000000-0000-0000-0000-000000000027"), "2024-2025 Fall", new Guid("40000000-0000-0000-0000-000000000081"), null },
                    { new Guid("50000000-0000-0000-0000-000000004584"), "TURK 202", "Turkish Language II", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2, null, "AA", true, new Guid("30000000-0000-0000-0000-000000000028"), "2020-2021 Spring", new Guid("40000000-0000-0000-0000-000000000081"), null },
                    { new Guid("50000000-0000-0000-0000-000000004585"), "HIST 204", "History of Turkish Revolution II", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2, null, "AA", true, new Guid("30000000-0000-0000-0000-000000000029"), "2020-2021 Spring", new Guid("40000000-0000-0000-0000-000000000081"), null },
                    { new Guid("50000000-0000-0000-0000-000000004586"), "TURK 204", "Turkish for International Students II", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2, null, "BA", true, new Guid("30000000-0000-0000-0000-000000000030"), "2024-2025 Fall", new Guid("40000000-0000-0000-0000-000000000081"), null },
                    { new Guid("50000000-0000-0000-0000-000000004587"), "CENG 311", "Computer Architecture", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 8, null, "BA", true, new Guid("30000000-0000-0000-0000-000000000031"), "2024-2025 Fall", new Guid("40000000-0000-0000-0000-000000000081"), null },
                    { new Guid("50000000-0000-0000-0000-000000004588"), "CENG 315", "Information Management", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 6, null, "AA", true, new Guid("30000000-0000-0000-0000-000000000032"), "2023-2024 Fall", new Guid("40000000-0000-0000-0000-000000000081"), null },
                    { new Guid("50000000-0000-0000-0000-000000004589"), "CENG 312", "Computer Networks", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 6, null, "BB", true, new Guid("30000000-0000-0000-0000-000000000033"), "2022-2023 Fall", new Guid("40000000-0000-0000-0000-000000000081"), null },
                    { new Guid("50000000-0000-0000-0000-000000004590"), "CENG 316", "Software Engineering", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 6, null, "AA", true, new Guid("30000000-0000-0000-0000-000000000034"), "2023-2024 Spring", new Guid("40000000-0000-0000-0000-000000000081"), null },
                    { new Guid("50000000-0000-0000-0000-000000004591"), "CENG 318", "Human-Computer Interaction", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 6, null, "AA", true, new Guid("30000000-0000-0000-0000-000000000035"), "2023-2024 Spring", new Guid("40000000-0000-0000-0000-000000000081"), null },
                    { new Guid("50000000-0000-0000-0000-000000004592"), "CENG 322", "Operating Systems", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 8, null, "BA", true, new Guid("30000000-0000-0000-0000-000000000036"), "2024-2025 Fall", new Guid("40000000-0000-0000-0000-000000000081"), null },
                    { new Guid("50000000-0000-0000-0000-000000004593"), "CENG 411", "Professionalism in Computer Engineering", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 6, null, "BB", true, new Guid("30000000-0000-0000-0000-000000000037"), "2023-2024 Spring", new Guid("40000000-0000-0000-0000-000000000081"), null },
                    { new Guid("50000000-0000-0000-0000-000000004594"), "CENG 415", "Undergraduate Thesis and Seminar I", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 8, null, "BB", true, new Guid("30000000-0000-0000-0000-000000000038"), "2023-2024 Fall", new Guid("40000000-0000-0000-0000-000000000081"), null },
                    { new Guid("50000000-0000-0000-0000-000000004595"), "CENG 416", "Undergraduate Thesis and Seminar II", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 8, null, "AA", true, new Guid("30000000-0000-0000-0000-000000000039"), "2021-2022 Fall", new Guid("40000000-0000-0000-0000-000000000081"), null },
                    { new Guid("50000000-0000-0000-0000-000000004596"), "ECON 205", "Principles of Economics", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, null, "BB", true, new Guid("30000000-0000-0000-0000-000000000158"), "2024-2025 Fall", new Guid("40000000-0000-0000-0000-000000000081"), null },
                    { new Guid("50000000-0000-0000-0000-000000004597"), "CENG 246", "Numerical Computing", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 5, null, "BA", true, new Guid("30000000-0000-0000-0000-000000000159"), "2022-2023 Spring", new Guid("40000000-0000-0000-0000-000000000081"), null },
                    { new Guid("50000000-0000-0000-0000-000000004598"), "CENG 400", "Summer Internship", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 0, null, "AA", true, new Guid("30000000-0000-0000-0000-000000000162"), "2022-2023 Spring", new Guid("40000000-0000-0000-0000-000000000081"), null },
                    { new Guid("50000000-0000-0000-0000-000000004599"), "CENG 382", "Information Theory", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, null, "BB", true, new Guid("30000000-0000-0000-0000-000000000042"), "2020-2021 Fall", new Guid("40000000-0000-0000-0000-000000000081"), null },
                    { new Guid("50000000-0000-0000-0000-000000004600"), "CENG 487", "Introduction to Computer Graphics", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, null, "BB", true, new Guid("30000000-0000-0000-0000-000000000080"), "2022-2023 Spring", new Guid("40000000-0000-0000-0000-000000000081"), null },
                    { new Guid("50000000-0000-0000-0000-000000004601"), "CENG 452", "Software Development for Embedded Systems", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, null, "AA", true, new Guid("30000000-0000-0000-0000-000000000065"), "2024-2025 Fall", new Guid("40000000-0000-0000-0000-000000000081"), null },
                    { new Guid("50000000-0000-0000-0000-000000004602"), "CENG 390", "Cloud Computing", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, null, "AA", true, new Guid("30000000-0000-0000-0000-000000000049"), "2022-2023 Fall", new Guid("40000000-0000-0000-0000-000000000081"), null },
                    { new Guid("50000000-0000-0000-0000-000000004603"), "CENG 483", "Behavioral Robotics", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, null, "AA", true, new Guid("30000000-0000-0000-0000-000000000076"), "2022-2023 Fall", new Guid("40000000-0000-0000-0000-000000000081"), null },
                    { new Guid("50000000-0000-0000-0000-000000004604"), "CENG 432", "Fundamentals of Enterprise Application Development", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, null, "BB", true, new Guid("30000000-0000-0000-0000-000000000054"), "2023-2024 Fall", new Guid("40000000-0000-0000-0000-000000000081"), null },
                    { new Guid("50000000-0000-0000-0000-000000004605"), "CENG 461", "Artificial Intelligence", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, null, "BB", true, new Guid("30000000-0000-0000-0000-000000000066"), "2021-2022 Spring", new Guid("40000000-0000-0000-0000-000000000081"), null },
                    { new Guid("50000000-0000-0000-0000-000000004606"), "CENG 431", "Software Systems Development", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, null, "AA", true, new Guid("30000000-0000-0000-0000-000000000053"), "2021-2022 Spring", new Guid("40000000-0000-0000-0000-000000000081"), null },
                    { new Guid("50000000-0000-0000-0000-000000004607"), "CENG 437", "Software Quality Management", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, null, "BB", true, new Guid("30000000-0000-0000-0000-000000000059"), "2020-2021 Spring", new Guid("40000000-0000-0000-0000-000000000081"), null },
                    { new Guid("50000000-0000-0000-0000-000000004608"), "MAN 211", "Communication and Management Skills for Engineers", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, null, "BA", true, new Guid("30000000-0000-0000-0000-000000000135"), "2021-2022 Fall", new Guid("40000000-0000-0000-0000-000000000081"), null },
                    { new Guid("50000000-0000-0000-0000-000000004609"), "MAN 216", "Introduction to Marketing", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, null, "BA", true, new Guid("30000000-0000-0000-0000-000000000137"), "2022-2023 Fall", new Guid("40000000-0000-0000-0000-000000000081"), null },
                    { new Guid("50000000-0000-0000-0000-000000004610"), "MAN 220", "Leadership", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, null, "BB", true, new Guid("30000000-0000-0000-0000-000000000140"), "2022-2023 Spring", new Guid("40000000-0000-0000-0000-000000000081"), null },
                    { new Guid("50000000-0000-0000-0000-000000004611"), "ART 202", "Painting", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, null, "BA", true, new Guid("30000000-0000-0000-0000-000000000083"), "2022-2023 Spring", new Guid("40000000-0000-0000-0000-000000000081"), null },
                    { new Guid("50000000-0000-0000-0000-000000004612"), "MAN 206", "Businesses and Business Life", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, null, "AA", true, new Guid("30000000-0000-0000-0000-000000000133"), "2020-2021 Spring", new Guid("40000000-0000-0000-0000-000000000081"), null },
                    { new Guid("50000000-0000-0000-0000-000000004613"), "MATH 141", "Calculus I", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 5, null, "BB", true, new Guid("30000000-0000-0000-0000-000000000001"), "2020-2021 Spring", new Guid("40000000-0000-0000-0000-000000000082"), null },
                    { new Guid("50000000-0000-0000-0000-000000004614"), "PHYS 121", "Physics I", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 7, null, "AA", true, new Guid("30000000-0000-0000-0000-000000000002"), "2021-2022 Spring", new Guid("40000000-0000-0000-0000-000000000082"), null },
                    { new Guid("50000000-0000-0000-0000-000000004615"), "CENG 111", "Introduction to Computer Engineering", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 5, null, "AA", true, new Guid("30000000-0000-0000-0000-000000000003"), "2024-2025 Fall", new Guid("40000000-0000-0000-0000-000000000082"), null },
                    { new Guid("50000000-0000-0000-0000-000000004616"), "CENG 113", "Introduction to Programming", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 6, null, "BB", true, new Guid("30000000-0000-0000-0000-000000000004"), "2022-2023 Fall", new Guid("40000000-0000-0000-0000-000000000082"), null },
                    { new Guid("50000000-0000-0000-0000-000000004617"), "CENG 115", "Discrete Structures", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 5, null, "AA", true, new Guid("30000000-0000-0000-0000-000000000005"), "2021-2022 Fall", new Guid("40000000-0000-0000-0000-000000000082"), null },
                    { new Guid("50000000-0000-0000-0000-000000004618"), "ENG 101", "Academic English I", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, null, "BB", true, new Guid("30000000-0000-0000-0000-000000000006"), "2024-2025 Fall", new Guid("40000000-0000-0000-0000-000000000082"), null },
                    { new Guid("50000000-0000-0000-0000-000000004619"), "MATH 142", "Calculus II", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 6, null, "BB", true, new Guid("30000000-0000-0000-0000-000000000007"), "2020-2021 Fall", new Guid("40000000-0000-0000-0000-000000000082"), null },
                    { new Guid("50000000-0000-0000-0000-000000004620"), "PHYS 122", "Physics II", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 8, null, "BA", true, new Guid("30000000-0000-0000-0000-000000000008"), "2023-2024 Fall", new Guid("40000000-0000-0000-0000-000000000082"), null },
                    { new Guid("50000000-0000-0000-0000-000000004621"), "MATH 144", "Finite Mathematics", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 5, null, "AA", true, new Guid("30000000-0000-0000-0000-000000000009"), "2021-2022 Spring", new Guid("40000000-0000-0000-0000-000000000082"), null },
                    { new Guid("50000000-0000-0000-0000-000000004622"), "CENG 112", "Data Structures", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 5, null, "AA", true, new Guid("30000000-0000-0000-0000-000000000010"), "2024-2025 Fall", new Guid("40000000-0000-0000-0000-000000000082"), null },
                    { new Guid("50000000-0000-0000-0000-000000004623"), "ECON 106", "Principles of Economics", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, null, "BA", true, new Guid("30000000-0000-0000-0000-000000000011"), "2023-2024 Fall", new Guid("40000000-0000-0000-0000-000000000082"), null },
                    { new Guid("50000000-0000-0000-0000-000000004624"), "ENG 102", "Academic English II", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, null, "BB", true, new Guid("30000000-0000-0000-0000-000000000012"), "2022-2023 Fall", new Guid("40000000-0000-0000-0000-000000000082"), null },
                    { new Guid("50000000-0000-0000-0000-000000004625"), "GCC 101", "Career Planning and Development", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 0, null, "AA", true, new Guid("30000000-0000-0000-0000-000000000013"), "2020-2021 Spring", new Guid("40000000-0000-0000-0000-000000000082"), null },
                    { new Guid("50000000-0000-0000-0000-000000004626"), "CENG 211", "Fundamentals of Programming", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 5, null, "AA", true, new Guid("30000000-0000-0000-0000-000000000014"), "2022-2023 Fall", new Guid("40000000-0000-0000-0000-000000000082"), null },
                    { new Guid("50000000-0000-0000-0000-000000004627"), "CENG 213", "Theory of Computation", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 5, null, "BA", true, new Guid("30000000-0000-0000-0000-000000000015"), "2023-2024 Fall", new Guid("40000000-0000-0000-0000-000000000082"), null },
                    { new Guid("50000000-0000-0000-0000-000000004628"), "CENG 215", "Circuits and Electronics", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 6, null, "BA", true, new Guid("30000000-0000-0000-0000-000000000016"), "2024-2025 Fall", new Guid("40000000-0000-0000-0000-000000000082"), null },
                    { new Guid("50000000-0000-0000-0000-000000004629"), "MATH 255", "Differential Equations", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 6, null, "BB", true, new Guid("30000000-0000-0000-0000-000000000017"), "2020-2021 Spring", new Guid("40000000-0000-0000-0000-000000000082"), null },
                    { new Guid("50000000-0000-0000-0000-000000004630"), "HIST 201", "History of Turkish Republic I", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2, null, "AA", true, new Guid("30000000-0000-0000-0000-000000000018"), "2021-2022 Fall", new Guid("40000000-0000-0000-0000-000000000082"), null },
                    { new Guid("50000000-0000-0000-0000-000000004631"), "TURK 201", "Turkish Language I", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2, null, "BB", true, new Guid("30000000-0000-0000-0000-000000000019"), "2022-2023 Spring", new Guid("40000000-0000-0000-0000-000000000082"), null },
                    { new Guid("50000000-0000-0000-0000-000000004632"), "HIST 203", "History of Turkish Revolution I", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2, null, "AA", true, new Guid("30000000-0000-0000-0000-000000000020"), "2020-2021 Fall", new Guid("40000000-0000-0000-0000-000000000082"), null },
                    { new Guid("50000000-0000-0000-0000-000000004633"), "TURK 203", "Turkish for International Students I", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2, null, "BA", true, new Guid("30000000-0000-0000-0000-000000000021"), "2020-2021 Fall", new Guid("40000000-0000-0000-0000-000000000082"), null },
                    { new Guid("50000000-0000-0000-0000-000000004634"), "CENG 212", "Programming Language Concepts", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 5, null, "AA", true, new Guid("30000000-0000-0000-0000-000000000022"), "2022-2023 Spring", new Guid("40000000-0000-0000-0000-000000000082"), null },
                    { new Guid("50000000-0000-0000-0000-000000004635"), "CENG 214", "Logic Design", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 6, null, "BB", true, new Guid("30000000-0000-0000-0000-000000000023"), "2022-2023 Spring", new Guid("40000000-0000-0000-0000-000000000082"), null },
                    { new Guid("50000000-0000-0000-0000-000000004636"), "CENG 216", "Numerical Computing", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 5, null, "AA", true, new Guid("30000000-0000-0000-0000-000000000024"), "2022-2023 Spring", new Guid("40000000-0000-0000-0000-000000000082"), null },
                    { new Guid("50000000-0000-0000-0000-000000004637"), "CENG 218", "Analysis and Design of Algorithms", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 5, null, "BB", true, new Guid("30000000-0000-0000-0000-000000000025"), "2020-2021 Fall", new Guid("40000000-0000-0000-0000-000000000082"), null },
                    { new Guid("50000000-0000-0000-0000-000000004638"), "CENG 222", "Probability and Statistics", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 5, null, "AA", true, new Guid("30000000-0000-0000-0000-000000000026"), "2020-2021 Spring", new Guid("40000000-0000-0000-0000-000000000082"), null },
                    { new Guid("50000000-0000-0000-0000-000000004639"), "HIST 202", "History of Turkish Republic II", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2, null, "AA", true, new Guid("30000000-0000-0000-0000-000000000027"), "2021-2022 Fall", new Guid("40000000-0000-0000-0000-000000000082"), null },
                    { new Guid("50000000-0000-0000-0000-000000004640"), "TURK 202", "Turkish Language II", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2, null, "BA", true, new Guid("30000000-0000-0000-0000-000000000028"), "2020-2021 Spring", new Guid("40000000-0000-0000-0000-000000000082"), null },
                    { new Guid("50000000-0000-0000-0000-000000004641"), "HIST 204", "History of Turkish Revolution II", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2, null, "AA", true, new Guid("30000000-0000-0000-0000-000000000029"), "2023-2024 Spring", new Guid("40000000-0000-0000-0000-000000000082"), null },
                    { new Guid("50000000-0000-0000-0000-000000004642"), "TURK 204", "Turkish for International Students II", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2, null, "AA", true, new Guid("30000000-0000-0000-0000-000000000030"), "2024-2025 Fall", new Guid("40000000-0000-0000-0000-000000000082"), null },
                    { new Guid("50000000-0000-0000-0000-000000004643"), "CENG 311", "Computer Architecture", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 8, null, "BA", true, new Guid("30000000-0000-0000-0000-000000000031"), "2021-2022 Spring", new Guid("40000000-0000-0000-0000-000000000082"), null },
                    { new Guid("50000000-0000-0000-0000-000000004644"), "CENG 315", "Information Management", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 6, null, "BB", true, new Guid("30000000-0000-0000-0000-000000000032"), "2021-2022 Spring", new Guid("40000000-0000-0000-0000-000000000082"), null },
                    { new Guid("50000000-0000-0000-0000-000000004645"), "CENG 312", "Computer Networks", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 6, null, "BB", true, new Guid("30000000-0000-0000-0000-000000000033"), "2024-2025 Fall", new Guid("40000000-0000-0000-0000-000000000082"), null },
                    { new Guid("50000000-0000-0000-0000-000000004646"), "CENG 316", "Software Engineering", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 6, null, "AA", true, new Guid("30000000-0000-0000-0000-000000000034"), "2023-2024 Fall", new Guid("40000000-0000-0000-0000-000000000082"), null },
                    { new Guid("50000000-0000-0000-0000-000000004647"), "CENG 318", "Human-Computer Interaction", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 6, null, "AA", true, new Guid("30000000-0000-0000-0000-000000000035"), "2021-2022 Fall", new Guid("40000000-0000-0000-0000-000000000082"), null },
                    { new Guid("50000000-0000-0000-0000-000000004648"), "CENG 322", "Operating Systems", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 8, null, "BB", true, new Guid("30000000-0000-0000-0000-000000000036"), "2022-2023 Fall", new Guid("40000000-0000-0000-0000-000000000082"), null },
                    { new Guid("50000000-0000-0000-0000-000000004649"), "CENG 411", "Professionalism in Computer Engineering", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 6, null, "AA", true, new Guid("30000000-0000-0000-0000-000000000037"), "2020-2021 Spring", new Guid("40000000-0000-0000-0000-000000000082"), null },
                    { new Guid("50000000-0000-0000-0000-000000004650"), "CENG 415", "Undergraduate Thesis and Seminar I", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 8, null, "BA", true, new Guid("30000000-0000-0000-0000-000000000038"), "2022-2023 Fall", new Guid("40000000-0000-0000-0000-000000000082"), null },
                    { new Guid("50000000-0000-0000-0000-000000004651"), "CENG 416", "Undergraduate Thesis and Seminar II", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 8, null, "BA", true, new Guid("30000000-0000-0000-0000-000000000039"), "2021-2022 Spring", new Guid("40000000-0000-0000-0000-000000000082"), null },
                    { new Guid("50000000-0000-0000-0000-000000004652"), "ECON 205", "Principles of Economics", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, null, "BA", true, new Guid("30000000-0000-0000-0000-000000000158"), "2022-2023 Spring", new Guid("40000000-0000-0000-0000-000000000082"), null },
                    { new Guid("50000000-0000-0000-0000-000000004653"), "CENG 246", "Numerical Computing", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 5, null, "BB", true, new Guid("30000000-0000-0000-0000-000000000159"), "2022-2023 Spring", new Guid("40000000-0000-0000-0000-000000000082"), null },
                    { new Guid("50000000-0000-0000-0000-000000004654"), "CENG 400", "Summer Internship", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 0, null, "BA", true, new Guid("30000000-0000-0000-0000-000000000162"), "2022-2023 Spring", new Guid("40000000-0000-0000-0000-000000000082"), null },
                    { new Guid("50000000-0000-0000-0000-000000004655"), "CENG 488", "Computer Graphics", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, null, "BB", true, new Guid("30000000-0000-0000-0000-000000000081"), "2022-2023 Fall", new Guid("40000000-0000-0000-0000-000000000082"), null },
                    { new Guid("50000000-0000-0000-0000-000000004656"), "CENG 473", "Information and Communication Technologies Security", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, null, "BB", true, new Guid("30000000-0000-0000-0000-000000000073"), "2020-2021 Spring", new Guid("40000000-0000-0000-0000-000000000082"), null },
                    { new Guid("50000000-0000-0000-0000-000000004657"), "CENG 385", "Mathematical Logic", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, null, "AA", true, new Guid("30000000-0000-0000-0000-000000000045"), "2020-2021 Fall", new Guid("40000000-0000-0000-0000-000000000082"), null },
                    { new Guid("50000000-0000-0000-0000-000000004658"), "CENG 462", "Soft Computing", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, null, "BB", true, new Guid("30000000-0000-0000-0000-000000000067"), "2021-2022 Fall", new Guid("40000000-0000-0000-0000-000000000082"), null },
                    { new Guid("50000000-0000-0000-0000-000000004659"), "CENG 391", "Introduction to Image Understanding", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, null, "BA", true, new Guid("30000000-0000-0000-0000-000000000050"), "2022-2023 Spring", new Guid("40000000-0000-0000-0000-000000000082"), null },
                    { new Guid("50000000-0000-0000-0000-000000004660"), "CENG 464", "Text Mining", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, null, "AA", true, new Guid("30000000-0000-0000-0000-000000000069"), "2023-2024 Fall", new Guid("40000000-0000-0000-0000-000000000082"), null },
                    { new Guid("50000000-0000-0000-0000-000000004661"), "CENG 389", "Mobile Application Development", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, null, "AA", true, new Guid("30000000-0000-0000-0000-000000000048"), "2021-2022 Fall", new Guid("40000000-0000-0000-0000-000000000082"), null },
                    { new Guid("50000000-0000-0000-0000-000000004662"), "CENG 323", "Project Management", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, null, "AA", true, new Guid("30000000-0000-0000-0000-000000000160"), "2020-2021 Fall", new Guid("40000000-0000-0000-0000-000000000082"), null },
                    { new Guid("50000000-0000-0000-0000-000000004663"), "CENG 485", "Entrepreneurship in Information Technologies", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, null, "BB", true, new Guid("30000000-0000-0000-0000-000000000078"), "2020-2021 Fall", new Guid("40000000-0000-0000-0000-000000000082"), null },
                    { new Guid("50000000-0000-0000-0000-000000004664"), "MAN 223", "Creative Project Writing and Presentation", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, null, "AA", true, new Guid("30000000-0000-0000-0000-000000000161"), "2020-2021 Spring", new Guid("40000000-0000-0000-0000-000000000082"), null },
                    { new Guid("50000000-0000-0000-0000-000000004665"), "MAN 203", "Project Management", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, null, "AA", true, new Guid("30000000-0000-0000-0000-000000000131"), "2020-2021 Spring", new Guid("40000000-0000-0000-0000-000000000082"), null },
                    { new Guid("50000000-0000-0000-0000-000000004666"), "SPRT 202", "Tennis II", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, null, "AA", true, new Guid("30000000-0000-0000-0000-000000000153"), "2020-2021 Spring", new Guid("40000000-0000-0000-0000-000000000082"), null },
                    { new Guid("50000000-0000-0000-0000-000000004667"), "ART 202", "Painting", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, null, "AA", true, new Guid("30000000-0000-0000-0000-000000000083"), "2021-2022 Spring", new Guid("40000000-0000-0000-0000-000000000082"), null },
                    { new Guid("50000000-0000-0000-0000-000000004668"), "SPRT 201", "Tennis I", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, null, "AA", true, new Guid("30000000-0000-0000-0000-000000000152"), "2024-2025 Fall", new Guid("40000000-0000-0000-0000-000000000082"), null },
                    { new Guid("50000000-0000-0000-0000-000000004669"), "SPRT 203", "Badminton", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, null, "BA", true, new Guid("30000000-0000-0000-0000-000000000154"), "2020-2021 Spring", new Guid("40000000-0000-0000-0000-000000000082"), null },
                    { new Guid("50000000-0000-0000-0000-000000004670"), "MATH 141", "Calculus I", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 5, null, "BA", true, new Guid("30000000-0000-0000-0000-000000000001"), "2022-2023 Spring", new Guid("40000000-0000-0000-0000-000000000083"), null },
                    { new Guid("50000000-0000-0000-0000-000000004671"), "PHYS 121", "Physics I", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 7, null, "BB", true, new Guid("30000000-0000-0000-0000-000000000002"), "2023-2024 Spring", new Guid("40000000-0000-0000-0000-000000000083"), null },
                    { new Guid("50000000-0000-0000-0000-000000004672"), "CENG 111", "Introduction to Computer Engineering", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 5, null, "AA", true, new Guid("30000000-0000-0000-0000-000000000003"), "2020-2021 Spring", new Guid("40000000-0000-0000-0000-000000000083"), null },
                    { new Guid("50000000-0000-0000-0000-000000004673"), "CENG 113", "Introduction to Programming", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 6, null, "BA", true, new Guid("30000000-0000-0000-0000-000000000004"), "2023-2024 Spring", new Guid("40000000-0000-0000-0000-000000000083"), null },
                    { new Guid("50000000-0000-0000-0000-000000004674"), "CENG 115", "Discrete Structures", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 5, null, "BB", true, new Guid("30000000-0000-0000-0000-000000000005"), "2022-2023 Spring", new Guid("40000000-0000-0000-0000-000000000083"), null },
                    { new Guid("50000000-0000-0000-0000-000000004675"), "ENG 101", "Academic English I", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, null, "AA", true, new Guid("30000000-0000-0000-0000-000000000006"), "2022-2023 Fall", new Guid("40000000-0000-0000-0000-000000000083"), null },
                    { new Guid("50000000-0000-0000-0000-000000004676"), "MATH 142", "Calculus II", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 6, null, "AA", true, new Guid("30000000-0000-0000-0000-000000000007"), "2020-2021 Spring", new Guid("40000000-0000-0000-0000-000000000083"), null },
                    { new Guid("50000000-0000-0000-0000-000000004677"), "PHYS 122", "Physics II", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 8, null, "AA", true, new Guid("30000000-0000-0000-0000-000000000008"), "2023-2024 Fall", new Guid("40000000-0000-0000-0000-000000000083"), null },
                    { new Guid("50000000-0000-0000-0000-000000004678"), "MATH 144", "Finite Mathematics", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 5, null, "AA", true, new Guid("30000000-0000-0000-0000-000000000009"), "2023-2024 Fall", new Guid("40000000-0000-0000-0000-000000000083"), null },
                    { new Guid("50000000-0000-0000-0000-000000004679"), "CENG 112", "Data Structures", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 5, null, "AA", true, new Guid("30000000-0000-0000-0000-000000000010"), "2022-2023 Fall", new Guid("40000000-0000-0000-0000-000000000083"), null },
                    { new Guid("50000000-0000-0000-0000-000000004680"), "ECON 106", "Principles of Economics", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, null, "BA", true, new Guid("30000000-0000-0000-0000-000000000011"), "2020-2021 Spring", new Guid("40000000-0000-0000-0000-000000000083"), null },
                    { new Guid("50000000-0000-0000-0000-000000004681"), "ENG 102", "Academic English II", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, null, "BB", true, new Guid("30000000-0000-0000-0000-000000000012"), "2022-2023 Fall", new Guid("40000000-0000-0000-0000-000000000083"), null },
                    { new Guid("50000000-0000-0000-0000-000000004682"), "GCC 101", "Career Planning and Development", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 0, null, "AA", true, new Guid("30000000-0000-0000-0000-000000000013"), "2021-2022 Fall", new Guid("40000000-0000-0000-0000-000000000083"), null },
                    { new Guid("50000000-0000-0000-0000-000000004683"), "CENG 211", "Fundamentals of Programming", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 5, null, "BB", true, new Guid("30000000-0000-0000-0000-000000000014"), "2022-2023 Fall", new Guid("40000000-0000-0000-0000-000000000083"), null },
                    { new Guid("50000000-0000-0000-0000-000000004684"), "CENG 213", "Theory of Computation", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 5, null, "AA", true, new Guid("30000000-0000-0000-0000-000000000015"), "2023-2024 Spring", new Guid("40000000-0000-0000-0000-000000000083"), null },
                    { new Guid("50000000-0000-0000-0000-000000004685"), "CENG 215", "Circuits and Electronics", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 6, null, "AA", true, new Guid("30000000-0000-0000-0000-000000000016"), "2020-2021 Fall", new Guid("40000000-0000-0000-0000-000000000083"), null },
                    { new Guid("50000000-0000-0000-0000-000000004686"), "MATH 255", "Differential Equations", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 6, null, "AA", true, new Guid("30000000-0000-0000-0000-000000000017"), "2020-2021 Fall", new Guid("40000000-0000-0000-0000-000000000083"), null },
                    { new Guid("50000000-0000-0000-0000-000000004687"), "HIST 201", "History of Turkish Republic I", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2, null, "AA", true, new Guid("30000000-0000-0000-0000-000000000018"), "2024-2025 Fall", new Guid("40000000-0000-0000-0000-000000000083"), null },
                    { new Guid("50000000-0000-0000-0000-000000004688"), "TURK 201", "Turkish Language I", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2, null, "BB", true, new Guid("30000000-0000-0000-0000-000000000019"), "2020-2021 Spring", new Guid("40000000-0000-0000-0000-000000000083"), null },
                    { new Guid("50000000-0000-0000-0000-000000004689"), "HIST 203", "History of Turkish Revolution I", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2, null, "BB", true, new Guid("30000000-0000-0000-0000-000000000020"), "2024-2025 Fall", new Guid("40000000-0000-0000-0000-000000000083"), null },
                    { new Guid("50000000-0000-0000-0000-000000004690"), "TURK 203", "Turkish for International Students I", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2, null, "AA", true, new Guid("30000000-0000-0000-0000-000000000021"), "2020-2021 Spring", new Guid("40000000-0000-0000-0000-000000000083"), null },
                    { new Guid("50000000-0000-0000-0000-000000004691"), "CENG 212", "Programming Language Concepts", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 5, null, "BB", true, new Guid("30000000-0000-0000-0000-000000000022"), "2021-2022 Spring", new Guid("40000000-0000-0000-0000-000000000083"), null },
                    { new Guid("50000000-0000-0000-0000-000000004692"), "CENG 214", "Logic Design", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 6, null, "AA", true, new Guid("30000000-0000-0000-0000-000000000023"), "2023-2024 Fall", new Guid("40000000-0000-0000-0000-000000000083"), null },
                    { new Guid("50000000-0000-0000-0000-000000004693"), "CENG 216", "Numerical Computing", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 5, null, "AA", true, new Guid("30000000-0000-0000-0000-000000000024"), "2024-2025 Fall", new Guid("40000000-0000-0000-0000-000000000083"), null },
                    { new Guid("50000000-0000-0000-0000-000000004694"), "CENG 218", "Analysis and Design of Algorithms", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 5, null, "AA", true, new Guid("30000000-0000-0000-0000-000000000025"), "2021-2022 Spring", new Guid("40000000-0000-0000-0000-000000000083"), null },
                    { new Guid("50000000-0000-0000-0000-000000004695"), "CENG 222", "Probability and Statistics", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 5, null, "AA", true, new Guid("30000000-0000-0000-0000-000000000026"), "2022-2023 Spring", new Guid("40000000-0000-0000-0000-000000000083"), null },
                    { new Guid("50000000-0000-0000-0000-000000004696"), "HIST 202", "History of Turkish Republic II", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2, null, "BB", true, new Guid("30000000-0000-0000-0000-000000000027"), "2020-2021 Fall", new Guid("40000000-0000-0000-0000-000000000083"), null },
                    { new Guid("50000000-0000-0000-0000-000000004697"), "TURK 202", "Turkish Language II", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2, null, "BA", true, new Guid("30000000-0000-0000-0000-000000000028"), "2022-2023 Fall", new Guid("40000000-0000-0000-0000-000000000083"), null },
                    { new Guid("50000000-0000-0000-0000-000000004698"), "HIST 204", "History of Turkish Revolution II", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2, null, "BB", true, new Guid("30000000-0000-0000-0000-000000000029"), "2022-2023 Fall", new Guid("40000000-0000-0000-0000-000000000083"), null },
                    { new Guid("50000000-0000-0000-0000-000000004699"), "TURK 204", "Turkish for International Students II", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2, null, "BA", true, new Guid("30000000-0000-0000-0000-000000000030"), "2020-2021 Fall", new Guid("40000000-0000-0000-0000-000000000083"), null },
                    { new Guid("50000000-0000-0000-0000-000000004700"), "CENG 311", "Computer Architecture", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 8, null, "AA", true, new Guid("30000000-0000-0000-0000-000000000031"), "2020-2021 Spring", new Guid("40000000-0000-0000-0000-000000000083"), null },
                    { new Guid("50000000-0000-0000-0000-000000004701"), "CENG 315", "Information Management", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 6, null, "BA", true, new Guid("30000000-0000-0000-0000-000000000032"), "2024-2025 Fall", new Guid("40000000-0000-0000-0000-000000000083"), null },
                    { new Guid("50000000-0000-0000-0000-000000004702"), "CENG 312", "Computer Networks", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 6, null, "BA", true, new Guid("30000000-0000-0000-0000-000000000033"), "2024-2025 Fall", new Guid("40000000-0000-0000-0000-000000000083"), null },
                    { new Guid("50000000-0000-0000-0000-000000004703"), "CENG 316", "Software Engineering", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 6, null, "AA", true, new Guid("30000000-0000-0000-0000-000000000034"), "2020-2021 Fall", new Guid("40000000-0000-0000-0000-000000000083"), null },
                    { new Guid("50000000-0000-0000-0000-000000004704"), "CENG 318", "Human-Computer Interaction", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 6, null, "BB", true, new Guid("30000000-0000-0000-0000-000000000035"), "2021-2022 Fall", new Guid("40000000-0000-0000-0000-000000000083"), null },
                    { new Guid("50000000-0000-0000-0000-000000004705"), "CENG 322", "Operating Systems", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 8, null, "BB", true, new Guid("30000000-0000-0000-0000-000000000036"), "2020-2021 Spring", new Guid("40000000-0000-0000-0000-000000000083"), null },
                    { new Guid("50000000-0000-0000-0000-000000004706"), "CENG 411", "Professionalism in Computer Engineering", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 6, null, "BB", true, new Guid("30000000-0000-0000-0000-000000000037"), "2020-2021 Spring", new Guid("40000000-0000-0000-0000-000000000083"), null },
                    { new Guid("50000000-0000-0000-0000-000000004707"), "CENG 415", "Undergraduate Thesis and Seminar I", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 8, null, "AA", true, new Guid("30000000-0000-0000-0000-000000000038"), "2021-2022 Spring", new Guid("40000000-0000-0000-0000-000000000083"), null },
                    { new Guid("50000000-0000-0000-0000-000000004708"), "CENG 416", "Undergraduate Thesis and Seminar II", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 8, null, "AA", true, new Guid("30000000-0000-0000-0000-000000000039"), "2021-2022 Spring", new Guid("40000000-0000-0000-0000-000000000083"), null },
                    { new Guid("50000000-0000-0000-0000-000000004709"), "ECON 205", "Principles of Economics", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, null, "BA", true, new Guid("30000000-0000-0000-0000-000000000158"), "2021-2022 Spring", new Guid("40000000-0000-0000-0000-000000000083"), null },
                    { new Guid("50000000-0000-0000-0000-000000004710"), "CENG 246", "Numerical Computing", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 5, null, "AA", true, new Guid("30000000-0000-0000-0000-000000000159"), "2024-2025 Fall", new Guid("40000000-0000-0000-0000-000000000083"), null },
                    { new Guid("50000000-0000-0000-0000-000000004711"), "CENG 400", "Summer Internship", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 0, null, "BA", true, new Guid("30000000-0000-0000-0000-000000000162"), "2024-2025 Fall", new Guid("40000000-0000-0000-0000-000000000083"), null },
                    { new Guid("50000000-0000-0000-0000-000000004712"), "CENG 462", "Soft Computing", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, null, "BA", true, new Guid("30000000-0000-0000-0000-000000000067"), "2022-2023 Fall", new Guid("40000000-0000-0000-0000-000000000083"), null },
                    { new Guid("50000000-0000-0000-0000-000000004713"), "CENG 385", "Mathematical Logic", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, null, "AA", true, new Guid("30000000-0000-0000-0000-000000000045"), "2023-2024 Fall", new Guid("40000000-0000-0000-0000-000000000083"), null },
                    { new Guid("50000000-0000-0000-0000-000000004714"), "CENG 432", "Fundamentals of Enterprise Application Development", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, null, "AA", true, new Guid("30000000-0000-0000-0000-000000000054"), "2020-2021 Fall", new Guid("40000000-0000-0000-0000-000000000083"), null },
                    { new Guid("50000000-0000-0000-0000-000000004715"), "CENG 452", "Software Development for Embedded Systems", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, null, "BA", true, new Guid("30000000-0000-0000-0000-000000000065"), "2021-2022 Spring", new Guid("40000000-0000-0000-0000-000000000083"), null },
                    { new Guid("50000000-0000-0000-0000-000000004716"), "CENG 486", "Entrepreneurship for Smart Businesses", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, null, "BB", true, new Guid("30000000-0000-0000-0000-000000000079"), "2023-2024 Fall", new Guid("40000000-0000-0000-0000-000000000083"), null },
                    { new Guid("50000000-0000-0000-0000-000000004717"), "CENG 451", "Advanced Digital System Design", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, null, "BB", true, new Guid("30000000-0000-0000-0000-000000000064"), "2022-2023 Fall", new Guid("40000000-0000-0000-0000-000000000083"), null },
                    { new Guid("50000000-0000-0000-0000-000000004718"), "CENG 481", "Theoretical Approaches in Computer Science", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, null, "AA", true, new Guid("30000000-0000-0000-0000-000000000074"), "2022-2023 Fall", new Guid("40000000-0000-0000-0000-000000000083"), null },
                    { new Guid("50000000-0000-0000-0000-000000004719"), "CENG 391", "Introduction to Image Understanding", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, null, "BA", true, new Guid("30000000-0000-0000-0000-000000000050"), "2021-2022 Spring", new Guid("40000000-0000-0000-0000-000000000083"), null },
                    { new Guid("50000000-0000-0000-0000-000000004720"), "CENG 463", "Introduction to Machine Learning", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, null, "AA", true, new Guid("30000000-0000-0000-0000-000000000068"), "2023-2024 Spring", new Guid("40000000-0000-0000-0000-000000000083"), null },
                    { new Guid("50000000-0000-0000-0000-000000004721"), "CENG 473", "Information and Communication Technologies Security", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, null, "AA", true, new Guid("30000000-0000-0000-0000-000000000073"), "2022-2023 Fall", new Guid("40000000-0000-0000-0000-000000000083"), null },
                    { new Guid("50000000-0000-0000-0000-000000004722"), "MAN 215", "Engineering Economy", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, null, "AA", true, new Guid("30000000-0000-0000-0000-000000000136"), "2021-2022 Spring", new Guid("40000000-0000-0000-0000-000000000083"), null },
                    { new Guid("50000000-0000-0000-0000-000000004723"), "SPRT 204", "Basketball", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, null, "AA", true, new Guid("30000000-0000-0000-0000-000000000155"), "2020-2021 Spring", new Guid("40000000-0000-0000-0000-000000000083"), null },
                    { new Guid("50000000-0000-0000-0000-000000004724"), "MAN 221", "Organizational and Personal Career Management", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, null, "BB", true, new Guid("30000000-0000-0000-0000-000000000141"), "2024-2025 Fall", new Guid("40000000-0000-0000-0000-000000000083"), null },
                    { new Guid("50000000-0000-0000-0000-000000004725"), "MAN 211", "Communication and Management Skills for Engineers", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, null, "BB", true, new Guid("30000000-0000-0000-0000-000000000135"), "2024-2025 Fall", new Guid("40000000-0000-0000-0000-000000000083"), null },
                    { new Guid("50000000-0000-0000-0000-000000004726"), "MAN 216", "Introduction to Marketing", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, null, "BA", true, new Guid("30000000-0000-0000-0000-000000000137"), "2020-2021 Fall", new Guid("40000000-0000-0000-0000-000000000083"), null },
                    { new Guid("50000000-0000-0000-0000-000000004727"), "ART 205", "Color Photography", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, null, "BA", true, new Guid("30000000-0000-0000-0000-000000000086"), "2021-2022 Spring", new Guid("40000000-0000-0000-0000-000000000083"), null },
                    { new Guid("50000000-0000-0000-0000-000000004728"), "HUM 214", "History of Western Civilizations II", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3, null, "AA", true, new Guid("30000000-0000-0000-0000-000000000109"), "2023-2024 Fall", new Guid("40000000-0000-0000-0000-000000000083"), null }
                });

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
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000084"),
                columns: new[] { "DepartmentId", "StaffIdentificationNumber", "Title" },
                values: new object[] { new Guid("20000000-0000-0000-0000-000000000001"), "STAFF001", "Advisor" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000085"),
                columns: new[] { "DepartmentId", "FacultyId", "StaffIdentificationNumber" },
                values: new object[] { new Guid("20000000-0000-0000-0000-000000000002"), new Guid("10000000-0000-0000-0000-000000000001"), "STAFF002" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000086"),
                columns: new[] { "DepartmentId", "FacultyId", "StaffIdentificationNumber", "Title" },
                values: new object[] { new Guid("20000000-0000-0000-0000-000000000001"), new Guid("10000000-0000-0000-0000-000000000001"), "STAFF003", "Department Secretary" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000087"),
                columns: new[] { "DepartmentId", "FacultyId", "StaffIdentificationNumber", "Title" },
                values: new object[] { null, new Guid("10000000-0000-0000-0000-000000000001"), "STAFF004", "Dean's Office Staff" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000088"),
                columns: new[] { "DepartmentId", "FacultyId", "StaffIdentificationNumber", "Title" },
                values: new object[] { new Guid("20000000-0000-0000-0000-000000000014"), new Guid("10000000-0000-0000-0000-000000000002"), "STAFF005", "Advisor" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000089"),
                columns: new[] { "DepartmentId", "FacultyId", "StaffIdentificationNumber", "Title" },
                values: new object[] { new Guid("20000000-0000-0000-0000-000000000012"), new Guid("10000000-0000-0000-0000-000000000002"), "STAFF006", "Academic Staff" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000090"),
                columns: new[] { "DepartmentId", "FacultyId", "StaffIdentificationNumber" },
                values: new object[] { new Guid("20000000-0000-0000-0000-000000000016"), new Guid("10000000-0000-0000-0000-000000000003"), "STAFF007" });

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

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "AssignedAdvisorUserId", "CreatedDate", "CurrentEctsCompleted", "CurrentGpa", "DeletedDate", "DepartmentId", "EnrollDate", "GraduationStatus", "ProgramName", "StudentNumber", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("40000000-0000-0000-0000-000000000081"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 250, 3.5m, null, new Guid("20000000-0000-0000-0000-000000000001"), new DateTime(2021, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6540), 1, "Undergraduate Program", "202400081", null },
                    { new Guid("40000000-0000-0000-0000-000000000082"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 245, 3.8m, null, new Guid("20000000-0000-0000-0000-000000000001"), new DateTime(2021, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6540), 1, "Undergraduate Program", "202400082", null },
                    { new Guid("40000000-0000-0000-0000-000000000083"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 255, 3.7m, null, new Guid("20000000-0000-0000-0000-000000000001"), new DateTime(2021, 5, 24, 22, 48, 46, 236, DateTimeKind.Utc).AddTicks(6550), 1, "Undergraduate Program", "202400083", null }
                });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { new Guid("005aed1b-5617-4f3a-838c-127dbff47c9a"), new DateTime(2025, 5, 24, 19, 48, 46, 236, DateTimeKind.Utc).AddTicks(4130), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000010") },
                    { new Guid("05ef412e-7e1b-45cd-89ac-fd3148b7a76b"), new DateTime(2025, 5, 24, 19, 48, 46, 236, DateTimeKind.Utc).AddTicks(4190), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000022") },
                    { new Guid("14ebcfa8-6f50-487e-9fc5-4ee6adf2875d"), new DateTime(2025, 5, 24, 19, 48, 46, 236, DateTimeKind.Utc).AddTicks(4210), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000027") },
                    { new Guid("1aba9247-4951-448d-95d5-30db0e37d7ca"), new DateTime(2025, 5, 24, 19, 48, 46, 236, DateTimeKind.Utc).AddTicks(4220), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000028") },
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
                columns: new[] { "Email", "FirstName", "IsActive", "IsEmailVerified", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "yigitkocak@std.iyte.edu.tr", "Yiğit Kaan", false, false, "Koçak", new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 }, "yigit.kaan.kocak.s81" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000082"),
                columns: new[] { "Email", "FirstName", "IsActive", "IsEmailVerified", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "dogansengul@std.iyte.edu.tr", "Doğan", false, false, "Şengül", new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 }, "dogan.sengul.s82" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000083"),
                columns: new[] { "Email", "FirstName", "IsActive", "IsEmailVerified", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "beraterdogan@std.iyte.edu.tr", "Berat", false, false, "Erdoğan", new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 }, "berat.erdogan.s83" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000084"),
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "ayse.yilmaz.p1@iyte.edu.tr", "Ayşe", "Yılmaz", new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 }, "ayse.yilmaz.p1" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000085"),
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "mehmet.kaya.p2@iyte.edu.tr", "Mehmet", "Kaya", new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 }, "mehmet.kaya.p2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000086"),
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "zeynep.demir.p3@iyte.edu.tr", "Zeynep", "Demir", new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 }, "zeynep.demir.p3" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000087"),
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "ahmet.celik.p4@iyte.edu.tr", "Ahmet", "Çelik", new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 }, "ahmet.celik.p4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000088"),
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "mustafa.sahin.p5@iyte.edu.tr", "Mustafa", "Şahin", new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 }, "mustafa.sahin.p5" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000089"),
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "fatma.ozturk.p6@iyte.edu.tr", "Fatma", "Öztürk", new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 }, "fatma.ozturk.p6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000090"),
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "ali.yildiz.p7@iyte.edu.tr", "Ali", "Yıldız", new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 }, "ali.yildiz.p7" });

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

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "FirstName", "IsActive", "IsEmailVerified", "LastName", "PasswordHash", "PasswordSalt", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[,]
                {
                    { new Guid("40000000-0000-0000-0000-000000000091"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "huseyin.aydin.p8@iyte.edu.tr", "Hüseyin", true, true, "Aydın", new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 }, null, null, "huseyin.aydin.p8" },
                    { new Guid("40000000-0000-0000-0000-000000000092"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "elif.arslan.p9@iyte.edu.tr", "Elif", true, true, "Arslan", new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 }, null, null, "elif.arslan.p9" },
                    { new Guid("40000000-0000-0000-0000-000000000093"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "veli.dogan.p10@iyte.edu.tr", "Veli", true, true, "Doğan", new byte[] { 229, 17, 14, 215, 228, 58, 108, 20, 212, 95, 238, 75, 195, 186, 175, 94, 26, 38, 223, 225, 17, 98, 134, 46, 173, 245, 47, 22, 58, 246, 226, 177, 55, 144, 202, 35, 80, 61, 171, 72, 73, 243, 186, 159, 101, 4, 174, 20, 81, 65, 36, 252, 61, 29, 201, 205, 79, 59, 188, 182, 130, 178, 32, 222 }, new byte[] { 48, 210, 92, 145, 5, 212, 148, 15, 166, 68, 91, 175, 177, 8, 239, 4, 103, 51, 170, 127, 177, 243, 155, 148, 72, 91, 109, 111, 170, 231, 186, 54, 224, 30, 236, 211, 63, 157, 2, 146, 108, 103, 82, 252, 244, 242, 213, 240, 60, 7, 178, 243, 149, 137, 73, 182, 20, 254, 195, 127, 246, 137, 54, 93, 119, 70, 6, 179, 44, 99, 115, 237, 132, 178, 165, 95, 44, 161, 126, 109, 51, 178, 97, 73, 203, 198, 111, 106, 206, 94, 228, 64, 155, 134, 147, 122, 201, 81, 221, 100, 215, 27, 149, 238, 244, 104, 79, 10, 185, 119, 112, 56, 27, 189, 57, 128, 87, 60, 166, 115, 136, 18, 208, 245, 52, 120, 138, 174 }, null, null, "veli.dogan.p10" }
                });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "DepartmentId", "FacultyId", "StaffIdentificationNumber", "Title", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("40000000-0000-0000-0000-000000000091"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, new Guid("20000000-0000-0000-0000-000000000019"), new Guid("10000000-0000-0000-0000-000000000004"), "STAFF008", "Instructor", null },
                    { new Guid("40000000-0000-0000-0000-000000000092"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, new Guid("20000000-0000-0000-0000-000000000020"), new Guid("10000000-0000-0000-0000-000000000005"), "STAFF009", "Coordinator", null },
                    { new Guid("40000000-0000-0000-0000-000000000093"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, new Guid("20000000-0000-0000-0000-000000000001"), new Guid("10000000-0000-0000-0000-000000000001"), "STAFF010", "Advisor", null }
                });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { new Guid("1b0e9aea-36cc-4050-902d-53c8f358072e"), new DateTime(2025, 5, 24, 19, 48, 46, 236, DateTimeKind.Utc).AddTicks(4290), null, new Guid("00000000-0000-0000-0000-000000000003"), null, new Guid("40000000-0000-0000-0000-000000000092") },
                    { new Guid("5fb528a7-d613-4347-9af4-d34fd3f00eeb"), new DateTime(2025, 5, 24, 19, 48, 46, 236, DateTimeKind.Utc).AddTicks(4290), null, new Guid("00000000-0000-0000-0000-000000000004"), null, new Guid("40000000-0000-0000-0000-000000000093") },
                    { new Guid("b4ef5c86-427f-4e1b-84a3-8b00c573c151"), new DateTime(2025, 5, 24, 19, 48, 46, 236, DateTimeKind.Utc).AddTicks(4290), null, new Guid("00000000-0000-0000-0000-000000000003"), null, new Guid("40000000-0000-0000-0000-000000000091") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004557"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004558"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004559"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004560"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004561"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004562"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004563"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004564"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004565"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004566"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004567"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004568"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004569"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004570"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004571"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004572"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004573"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004574"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004575"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004576"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004577"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004578"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004579"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004580"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004581"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004582"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004583"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004584"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004585"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004586"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004587"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004588"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004589"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004590"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004591"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004592"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004593"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004594"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004595"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004596"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004597"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004598"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004599"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004600"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004601"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004602"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004603"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004604"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004605"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004606"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004607"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004608"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004609"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004610"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004611"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004612"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004613"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004614"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004615"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004616"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004617"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004618"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004619"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004620"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004621"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004622"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004623"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004624"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004625"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004626"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004627"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004628"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004629"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004630"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004631"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004632"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004633"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004634"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004635"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004636"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004637"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004638"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004639"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004640"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004641"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004642"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004643"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004644"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004645"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004646"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004647"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004648"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004649"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004650"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004651"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004652"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004653"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004654"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004655"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004656"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004657"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004658"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004659"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004660"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004661"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004662"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004663"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004664"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004665"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004666"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004667"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004668"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004669"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004670"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004671"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004672"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004673"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004674"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004675"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004676"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004677"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004678"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004679"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004680"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004681"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004682"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004683"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004684"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004685"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004686"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004687"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004688"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004689"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004690"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004691"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004692"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004693"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004694"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004695"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004696"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004697"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004698"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004699"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004700"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004701"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004702"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004703"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004704"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004705"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004706"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004707"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004708"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004709"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004710"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004711"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004712"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004713"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004714"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004715"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004716"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004717"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004718"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004719"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004720"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004721"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004722"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004723"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004724"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004725"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004726"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004727"));

            migrationBuilder.DeleteData(
                table: "CourseTakens",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000004728"));

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000091"));

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000092"));

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000093"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000081"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000082"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000083"));

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

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000091"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000092"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000093"));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000001"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1210));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000002"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1210));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000003"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1220));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000004"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1220));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000005"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1220));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000006"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1230));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000007"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1230));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000008"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1230));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000009"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1230));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000010"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1240));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000011"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1240));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000012"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1240));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000013"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1240));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000014"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1250));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000015"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1250));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000016"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1250));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000017"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1250));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000018"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1260));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000019"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1260));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000020"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1260));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000021"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1260));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000022"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1260));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000023"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1270));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000024"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1270));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000025"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1270));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000026"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1270));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000027"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1280));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000028"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1280));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000029"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1280));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000030"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1290));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000031"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1290));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000032"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1290));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000033"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1300));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000034"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1300));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000035"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1300));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000036"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1310));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000037"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1310));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000038"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1310));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000039"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1310));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000040"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1320));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000041"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1320));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000042"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1320));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000043"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1320));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000044"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1330));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000045"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1330));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000046"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1330));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000047"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1330));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000048"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1340));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000049"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1340));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000050"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1340));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000051"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1340));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000052"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1350));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000053"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1350));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000054"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1350));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000055"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1350));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000056"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1360));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000057"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1360));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000058"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1360));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000059"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1360));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000060"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1370));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000061"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1370));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000062"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1380));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000063"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1380));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000064"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1380));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000065"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1380));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000066"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1390));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000067"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1390));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000068"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1390));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000069"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1390));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000070"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1400));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000071"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1400));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000072"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1400));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000073"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1410));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000074"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1410));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000075"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1410));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000076"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1410));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000077"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1420));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000078"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1420));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000079"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1420));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000080"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1420));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000081"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1430));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000082"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1430));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000083"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1430));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000084"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1430));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000085"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1440));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000086"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1440));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000087"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1440));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000088"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1440));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000089"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1450));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000090"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1450));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000091"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1460));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000092"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1460));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000093"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1460));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000094"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1460));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000095"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1470));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000096"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1470));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000097"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1470));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000098"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1470));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000099"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1480));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000100"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1480));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000101"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1480));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000102"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1480));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000103"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1490));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000104"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1490));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000105"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1490));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000106"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1490));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000107"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1500));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000108"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1500));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000109"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1500));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000110"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1500));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000111"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1500));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000112"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1510));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000113"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1510));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000114"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1510));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000115"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1510));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000116"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1520));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000117"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1520));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000118"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1520));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000119"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1530));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000120"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1530));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000121"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1530));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000122"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1540));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000123"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1540));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000124"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1540));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000125"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1550));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000126"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1550));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000127"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1550));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000128"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1550));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000129"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1560));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000130"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1560));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000131"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1560));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000132"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1560));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000133"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1570));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000134"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1570));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000135"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1570));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000136"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1570));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000137"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1580));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000138"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1580));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000139"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1580));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000140"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1580));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000141"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1580));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000142"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1590));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000143"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1590));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000144"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1590));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000145"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1590));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000146"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1600));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000147"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1600));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000148"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1600));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000149"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1600));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000150"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1610));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000151"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1610));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000152"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1610));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000153"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1610));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000154"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1620));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000155"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1620));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000156"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1620));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000157"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1620));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000158"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1620));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000159"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1630));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000160"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1630));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000161"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1630));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000162"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1630));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000163"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1640));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000164"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1640));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000165"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1640));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000166"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1640));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000001"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(140));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000002"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(140));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000003"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(140));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000004"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(150));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000005"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(150));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000006"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(150));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000007"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(150));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000008"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(150));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000009"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(160));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000010"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(160));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000011"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(160));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000012"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(160));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000013"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(160));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000014"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(160));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000015"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(170));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000016"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(170));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000017"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(170));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000018"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(170));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000019"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(170));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000020"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(180));

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(20));

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(80));

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(90));

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(90));

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000005"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(90));

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000084"),
                columns: new[] { "DepartmentId", "StaffIdentificationNumber", "Title" },
                values: new object[] { null, "STAFF004", "Dean's Office Staff" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000085"),
                columns: new[] { "DepartmentId", "FacultyId", "StaffIdentificationNumber" },
                values: new object[] { new Guid("20000000-0000-0000-0000-000000000014"), new Guid("10000000-0000-0000-0000-000000000002"), "STAFF005" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000086"),
                columns: new[] { "DepartmentId", "FacultyId", "StaffIdentificationNumber", "Title" },
                values: new object[] { new Guid("20000000-0000-0000-0000-000000000012"), new Guid("10000000-0000-0000-0000-000000000002"), "STAFF006", "Academic Staff" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000087"),
                columns: new[] { "DepartmentId", "FacultyId", "StaffIdentificationNumber", "Title" },
                values: new object[] { new Guid("20000000-0000-0000-0000-000000000016"), new Guid("10000000-0000-0000-0000-000000000003"), "STAFF007", "Advisor" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000088"),
                columns: new[] { "DepartmentId", "FacultyId", "StaffIdentificationNumber", "Title" },
                values: new object[] { new Guid("20000000-0000-0000-0000-000000000019"), new Guid("10000000-0000-0000-0000-000000000004"), "STAFF008", "Instructor" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000089"),
                columns: new[] { "DepartmentId", "FacultyId", "StaffIdentificationNumber", "Title" },
                values: new object[] { new Guid("20000000-0000-0000-0000-000000000020"), new Guid("10000000-0000-0000-0000-000000000005"), "STAFF009", "Coordinator" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000090"),
                columns: new[] { "DepartmentId", "FacultyId", "StaffIdentificationNumber" },
                values: new object[] { new Guid("20000000-0000-0000-0000-000000000001"), new Guid("10000000-0000-0000-0000-000000000001"), "STAFF010" });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "DepartmentId", "FacultyId", "StaffIdentificationNumber", "Title", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("40000000-0000-0000-0000-000000000081"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, new Guid("20000000-0000-0000-0000-000000000001"), new Guid("10000000-0000-0000-0000-000000000001"), "STAFF001", "Advisor", null },
                    { new Guid("40000000-0000-0000-0000-000000000082"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, new Guid("20000000-0000-0000-0000-000000000002"), new Guid("10000000-0000-0000-0000-000000000001"), "STAFF002", "Advisor", null },
                    { new Guid("40000000-0000-0000-0000-000000000083"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, new Guid("20000000-0000-0000-0000-000000000001"), new Guid("10000000-0000-0000-0000-000000000001"), "STAFF003", "Department Secretary", null }
                });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000001"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000081"), new DateTime(2020, 11, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(850) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000002"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000090"), new DateTime(2023, 9, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(860) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000003"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000081"), new DateTime(2024, 1, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(870) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000004"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000090"), new DateTime(2023, 9, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(870) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000005"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000081"), new DateTime(2021, 1, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(870) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000006"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000090"), new DateTime(2022, 9, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(880) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000007"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000081"), new DateTime(2021, 9, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(880) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000008"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000090"), new DateTime(2022, 3, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(880) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000009"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000081"), new DateTime(2022, 8, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(890) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000010"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000090"), new DateTime(2022, 12, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(890) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000011"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000081"), new DateTime(2023, 2, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(890) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000012"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000090"), new DateTime(2022, 7, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(890) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000013"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000081"), new DateTime(2021, 10, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(900) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000014"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000090"), new DateTime(2023, 11, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(900) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000015"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000081"), new DateTime(2021, 3, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(900) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000016"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000090"), new DateTime(2023, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(910) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000017"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000081"), new DateTime(2020, 9, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(910) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000018"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000090"), new DateTime(2021, 9, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(910) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000019"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000081"), new DateTime(2021, 10, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(910) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000020"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000090"), new DateTime(2024, 2, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(920) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000021"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000081"), new DateTime(2021, 11, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(920) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000022"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000090"), new DateTime(2021, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(920) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000023"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000081"), new DateTime(2023, 6, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(920) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000024"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000090"), new DateTime(2023, 2, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(930) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000025"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000081"), new DateTime(2022, 10, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(930) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000026"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000090"), new DateTime(2023, 8, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(930) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000027"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000081"), new DateTime(2024, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(930) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000028"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000090"), new DateTime(2022, 10, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(940) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000029"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000081"), new DateTime(2021, 3, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(940) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000030"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000090"), new DateTime(2022, 9, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(940) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000031"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000081"), new DateTime(2023, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(940) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000032"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000090"), new DateTime(2024, 3, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(950) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000033"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000081"), new DateTime(2022, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(950) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000034"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000090"), new DateTime(2020, 10, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(950) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000035"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000081"), new DateTime(2022, 9, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(950) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000036"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000090"), new DateTime(2024, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(960) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000037"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000081"), new DateTime(2020, 7, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(960) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000038"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000090"), new DateTime(2023, 2, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(960) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000039"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000081"), new DateTime(2022, 11, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(970) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000040"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000090"), new DateTime(2022, 2, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(970) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000041"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000081"), new DateTime(2023, 12, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(970) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000042"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000090"), new DateTime(2023, 11, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(970) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000043"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000081"), new DateTime(2023, 4, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(980) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000044"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000090"), new DateTime(2020, 11, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(980) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000045"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000081"), new DateTime(2021, 7, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(980) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000046"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000090"), new DateTime(2020, 8, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(990) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000047"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000081"), new DateTime(2023, 7, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(990) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000048"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000090"), new DateTime(2023, 8, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(990) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000049"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000081"), new DateTime(2020, 7, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(990) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000050"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000090"), new DateTime(2024, 4, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1000) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000051"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000081"), new DateTime(2024, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1000) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000052"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000090"), new DateTime(2021, 4, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1000) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000053"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000081"), new DateTime(2021, 4, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1000) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000054"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000090"), new DateTime(2022, 11, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1010) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000055"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000081"), new DateTime(2021, 10, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1010) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000056"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000090"), new DateTime(2022, 11, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1010) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000057"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000081"), new DateTime(2021, 3, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1010) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000058"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000090"), new DateTime(2021, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1020) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000059"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000081"), new DateTime(2022, 12, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1020) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000060"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000090"), new DateTime(2023, 11, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1020) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000061"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000081"), new DateTime(2024, 2, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1020) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000062"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000090"), new DateTime(2022, 10, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1030) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000063"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000081"), new DateTime(2022, 1, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1030) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000064"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000090"), new DateTime(2024, 2, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1030) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000065"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000081"), new DateTime(2021, 4, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1030) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000066"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000090"), new DateTime(2023, 7, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1040) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000067"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000081"), new DateTime(2023, 6, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1040) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000068"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000090"), new DateTime(2023, 1, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1040) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000069"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000081"), new DateTime(2023, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1040) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000070"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000090"), new DateTime(2023, 6, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1050) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000071"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000081"), new DateTime(2021, 12, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1050) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000072"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000090"), new DateTime(2021, 2, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1050) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000073"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000081"), new DateTime(2021, 11, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1050) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000074"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000090"), new DateTime(2023, 11, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1060) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000075"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000081"), new DateTime(2022, 12, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1060) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000076"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000090"), new DateTime(2022, 9, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1060) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000077"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000081"), new DateTime(2024, 5, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1070) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000078"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000090"), new DateTime(2023, 8, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1070) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000079"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000081"), new DateTime(2021, 2, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1070) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000080"),
                columns: new[] { "AssignedAdvisorUserId", "EnrollDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000090"), new DateTime(2022, 2, 24, 1, 27, 12, 836, DateTimeKind.Utc).AddTicks(1080) });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { new Guid("02fdbb2e-2fb4-4027-a7fe-4eeb2ad85917"), new DateTime(2025, 5, 23, 22, 27, 12, 835, DateTimeKind.Utc).AddTicks(8880), null, new Guid("00000000-0000-0000-0000-000000000006"), null, new Guid("40000000-0000-0000-0000-000000000084") },
                    { new Guid("057485b0-b76c-4751-8da0-4a0802b25769"), new DateTime(2025, 5, 23, 22, 27, 12, 835, DateTimeKind.Utc).AddTicks(8860), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000038") },
                    { new Guid("0cde453e-cc1e-407e-840c-b7b04b6a30f4"), new DateTime(2025, 5, 23, 22, 27, 12, 835, DateTimeKind.Utc).AddTicks(8890), null, new Guid("00000000-0000-0000-0000-000000000004"), null, new Guid("40000000-0000-0000-0000-000000000085") },
                    { new Guid("12e44783-b939-476c-a595-9c419d5e9189"), new DateTime(2025, 5, 23, 22, 27, 12, 835, DateTimeKind.Utc).AddTicks(8860), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000039") },
                    { new Guid("130b8458-7d62-4ad8-9135-a615852b7d42"), new DateTime(2025, 5, 23, 22, 27, 12, 835, DateTimeKind.Utc).AddTicks(8730), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000003") },
                    { new Guid("1e82ba93-adf3-49b6-bfb5-967b159a6917"), new DateTime(2025, 5, 23, 22, 27, 12, 835, DateTimeKind.Utc).AddTicks(8750), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000009") },
                    { new Guid("1fa2cd18-2a41-450f-a5c0-9fd92eaa56c3"), new DateTime(2025, 5, 23, 22, 27, 12, 835, DateTimeKind.Utc).AddTicks(8810), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000023") },
                    { new Guid("25ea79aa-6f54-4c7c-8198-53884b0497d0"), new DateTime(2025, 5, 23, 22, 27, 12, 835, DateTimeKind.Utc).AddTicks(8850), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000035") },
                    { new Guid("268288e3-fb11-4ac0-b4d3-1ef34c299e77"), new DateTime(2025, 5, 23, 22, 27, 12, 835, DateTimeKind.Utc).AddTicks(8850), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000034") },
                    { new Guid("27482b89-20fa-44f8-b5aa-ed82a18af717"), new DateTime(2025, 5, 23, 22, 27, 12, 835, DateTimeKind.Utc).AddTicks(8890), null, new Guid("00000000-0000-0000-0000-000000000004"), null, new Guid("40000000-0000-0000-0000-000000000087") },
                    { new Guid("294c9065-ed90-411f-bc9b-9452ae6bdfcf"), new DateTime(2025, 5, 23, 22, 27, 12, 835, DateTimeKind.Utc).AddTicks(8780), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000018") },
                    { new Guid("31998013-c1a4-49a9-bd69-577f7c74d19a"), new DateTime(2025, 5, 23, 22, 27, 12, 835, DateTimeKind.Utc).AddTicks(8780), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000016") },
                    { new Guid("3bb2b31e-649b-4bee-bf89-771abb820585"), new DateTime(2025, 5, 23, 22, 27, 12, 835, DateTimeKind.Utc).AddTicks(8720), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000002") },
                    { new Guid("3ce68ba8-9001-431f-b8bd-b76ac0ba6220"), new DateTime(2025, 5, 23, 22, 27, 12, 835, DateTimeKind.Utc).AddTicks(8780), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000017") },
                    { new Guid("47841661-de5f-4cc0-916d-1dd933908138"), new DateTime(2025, 5, 23, 22, 27, 12, 835, DateTimeKind.Utc).AddTicks(8850), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000036") },
                    { new Guid("48a21386-af9e-4e6a-8f2d-880ee8010f95"), new DateTime(2025, 5, 23, 22, 27, 12, 835, DateTimeKind.Utc).AddTicks(8810), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000025") },
                    { new Guid("4ae05145-1c72-4714-b068-130e3e543355"), new DateTime(2025, 5, 23, 22, 27, 12, 835, DateTimeKind.Utc).AddTicks(8840), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000033") },
                    { new Guid("4ca91565-312e-46eb-a442-edae0be4f526"), new DateTime(2025, 5, 23, 22, 27, 12, 835, DateTimeKind.Utc).AddTicks(8840), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000032") },
                    { new Guid("4f5cc30c-d6d7-4c97-8ea6-537931713f8c"), new DateTime(2025, 5, 23, 22, 27, 12, 835, DateTimeKind.Utc).AddTicks(8750), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000008") },
                    { new Guid("58ae7f08-ac69-471c-b13f-4109608d99b8"), new DateTime(2025, 5, 23, 22, 27, 12, 835, DateTimeKind.Utc).AddTicks(8790), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000019") },
                    { new Guid("62b320c3-af5f-4ed4-bf65-70170b656301"), new DateTime(2025, 5, 23, 22, 27, 12, 835, DateTimeKind.Utc).AddTicks(8740), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000006") },
                    { new Guid("66dfc8c8-8aef-4fed-8346-a3ac40e7f97c"), new DateTime(2025, 5, 23, 22, 27, 12, 835, DateTimeKind.Utc).AddTicks(8820), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000028") },
                    { new Guid("6b58321d-8743-473b-9f02-e8687f07436c"), new DateTime(2025, 5, 23, 22, 27, 12, 835, DateTimeKind.Utc).AddTicks(8810), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000024") },
                    { new Guid("6fccd1c4-3414-448c-884e-b3840b9c0ae4"), new DateTime(2025, 5, 23, 22, 27, 12, 835, DateTimeKind.Utc).AddTicks(8880), null, new Guid("00000000-0000-0000-0000-000000000004"), null, new Guid("40000000-0000-0000-0000-000000000082") },
                    { new Guid("70838eb4-7ecf-43e8-b8d3-161847ea7426"), new DateTime(2025, 5, 23, 22, 27, 12, 835, DateTimeKind.Utc).AddTicks(8830), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000029") },
                    { new Guid("751bf3bc-c2c9-428f-b141-bf1f7c3d4b51"), new DateTime(2025, 5, 23, 22, 27, 12, 835, DateTimeKind.Utc).AddTicks(8870), null, new Guid("00000000-0000-0000-0000-000000000004"), null, new Guid("40000000-0000-0000-0000-000000000081") },
                    { new Guid("778e7a3c-8676-477a-8b34-c9311a42a420"), new DateTime(2025, 5, 23, 22, 27, 12, 835, DateTimeKind.Utc).AddTicks(8760), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000011") },
                    { new Guid("79d64ec0-baae-458b-b8a3-c4d6439f5dc7"), new DateTime(2025, 5, 23, 22, 27, 12, 835, DateTimeKind.Utc).AddTicks(8790), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000020") },
                    { new Guid("7c8306ee-7843-4f4d-9fb3-7476140560ef"), new DateTime(2025, 5, 23, 22, 27, 12, 835, DateTimeKind.Utc).AddTicks(8820), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000027") },
                    { new Guid("7d9a6b05-ae4b-4c12-96a9-849db1be2cfe"), new DateTime(2025, 5, 23, 22, 27, 12, 835, DateTimeKind.Utc).AddTicks(8770), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000015") },
                    { new Guid("80d01e65-7263-40a6-b243-e44ba9c9994b"), new DateTime(2025, 5, 23, 22, 27, 12, 835, DateTimeKind.Utc).AddTicks(8770), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000013") },
                    { new Guid("87f5c42f-cff4-4fd6-83d0-c259a8c59560"), new DateTime(2025, 5, 23, 22, 27, 12, 835, DateTimeKind.Utc).AddTicks(8860), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000037") },
                    { new Guid("8eb10d57-ed82-4989-b7ac-31ab6ea41574"), new DateTime(2025, 5, 23, 22, 27, 12, 835, DateTimeKind.Utc).AddTicks(8880), null, new Guid("00000000-0000-0000-0000-000000000005"), null, new Guid("40000000-0000-0000-0000-000000000083") },
                    { new Guid("9906b76c-e22b-4d6f-afef-c21e56ac6f38"), new DateTime(2025, 5, 23, 22, 27, 12, 835, DateTimeKind.Utc).AddTicks(8900), null, new Guid("00000000-0000-0000-0000-000000000003"), null, new Guid("40000000-0000-0000-0000-000000000088") },
                    { new Guid("9db26e8e-ed44-4da4-97fb-663fe04dc9ee"), new DateTime(2025, 5, 23, 22, 27, 12, 835, DateTimeKind.Utc).AddTicks(8890), null, new Guid("00000000-0000-0000-0000-000000000003"), null, new Guid("40000000-0000-0000-0000-000000000086") },
                    { new Guid("9edbbeea-1978-4d25-80bd-2dabdc73e663"), new DateTime(2025, 5, 23, 22, 27, 12, 835, DateTimeKind.Utc).AddTicks(8770), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000014") },
                    { new Guid("a685b572-90e7-41ac-8554-6820ead39af9"), new DateTime(2025, 5, 23, 22, 27, 12, 835, DateTimeKind.Utc).AddTicks(8820), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000026") },
                    { new Guid("a7bebcfa-b6cd-4ebe-9dda-308f043a0198"), new DateTime(2025, 5, 23, 22, 27, 12, 835, DateTimeKind.Utc).AddTicks(8750), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000010") },
                    { new Guid("ac612cb3-dc61-42f2-8c8c-8ab77d598e6a"), new DateTime(2025, 5, 23, 22, 27, 12, 835, DateTimeKind.Utc).AddTicks(8870), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000040") },
                    { new Guid("ad468fe3-398e-4f1d-b4a5-b11371ba1683"), new DateTime(2025, 5, 23, 22, 27, 12, 835, DateTimeKind.Utc).AddTicks(8760), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000012") },
                    { new Guid("ae703d06-c3fa-428f-888a-df4344116f43"), new DateTime(2025, 5, 23, 22, 27, 12, 835, DateTimeKind.Utc).AddTicks(8730), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000004") },
                    { new Guid("b1314655-5f4d-4a5d-843f-05c1ff02b676"), new DateTime(2025, 5, 23, 22, 27, 12, 835, DateTimeKind.Utc).AddTicks(8740), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000007") },
                    { new Guid("b7a67f3b-7b42-4df3-ade1-36cb6c164a03"), new DateTime(2025, 5, 23, 22, 27, 12, 835, DateTimeKind.Utc).AddTicks(8910), null, new Guid("00000000-0000-0000-0000-000000000004"), null, new Guid("40000000-0000-0000-0000-000000000090") },
                    { new Guid("d3072146-48e9-4b64-b516-1e6dc7a0dd71"), new DateTime(2025, 5, 23, 22, 27, 12, 835, DateTimeKind.Utc).AddTicks(8740), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000005") },
                    { new Guid("de76eb73-6b21-4ab5-b2bf-6e381e2151e9"), new DateTime(2025, 5, 23, 22, 27, 12, 835, DateTimeKind.Utc).AddTicks(8900), null, new Guid("00000000-0000-0000-0000-000000000003"), null, new Guid("40000000-0000-0000-0000-000000000089") },
                    { new Guid("eeefcca8-d63d-4d69-9bb0-74a4a293779d"), new DateTime(2025, 5, 23, 22, 27, 12, 835, DateTimeKind.Utc).AddTicks(8840), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000031") },
                    { new Guid("f085dcd2-c5ae-471f-a4d2-c31b9898bb5e"), new DateTime(2025, 5, 23, 22, 27, 12, 835, DateTimeKind.Utc).AddTicks(8800), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000021") },
                    { new Guid("f4bc7abf-33a4-4de4-a2f7-48ce188a0b65"), new DateTime(2025, 5, 23, 22, 27, 12, 835, DateTimeKind.Utc).AddTicks(8720), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000001") },
                    { new Guid("fd8b5768-78cd-4e78-8228-4dec539138d9"), new DateTime(2025, 5, 23, 22, 27, 12, 835, DateTimeKind.Utc).AddTicks(8830), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000030") },
                    { new Guid("fdcbf010-91b0-461c-ba49-d3b299e77131"), new DateTime(2025, 5, 23, 22, 27, 12, 835, DateTimeKind.Utc).AddTicks(8800), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000022") }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-11111111111a"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 189, 243, 69, 134, 11, 26, 56, 6, 232, 251, 52, 192, 235, 35, 110, 91, 87, 28, 246, 65, 159, 252, 168, 239, 108, 113, 64, 215, 102, 219, 71, 0, 30, 177, 197, 10, 29, 51, 63, 148, 92, 193, 73, 93, 117, 75, 193, 9, 234, 101, 220, 18, 59, 125, 76, 85, 179, 232, 107, 216, 3, 6, 109, 70 }, new byte[] { 139, 202, 130, 63, 29, 85, 110, 131, 20, 218, 108, 219, 62, 46, 84, 172, 131, 246, 147, 201, 110, 131, 23, 209, 223, 137, 84, 16, 17, 79, 31, 145, 230, 11, 142, 96, 14, 75, 178, 129, 197, 200, 8, 133, 113, 74, 228, 125, 66, 55, 18, 112, 136, 9, 9, 154, 212, 161, 247, 172, 211, 155, 105, 152, 63, 132, 179, 99, 97, 244, 80, 28, 192, 84, 181, 168, 215, 248, 202, 184, 94, 66, 27, 68, 144, 174, 10, 35, 99, 91, 104, 60, 159, 117, 41, 213, 152, 195, 217, 17, 136, 61, 17, 168, 165, 179, 189, 29, 16, 121, 1, 148, 3, 80, 25, 224, 41, 213, 41, 26, 194, 166, 136, 215, 233, 212, 206, 227 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-22222222222a"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 35, 215, 134, 57, 148, 176, 123, 10, 9, 195, 14, 171, 62, 216, 173, 239, 209, 131, 217, 110, 167, 220, 41, 129, 90, 170, 111, 133, 180, 253, 199, 59, 51, 32, 11, 174, 115, 104, 247, 219, 116, 4, 114, 1, 193, 58, 101, 107, 153, 81, 188, 172, 77, 163, 20, 228, 203, 28, 91, 131, 124, 61, 31, 239 }, new byte[] { 243, 38, 52, 8, 7, 246, 5, 191, 186, 10, 80, 57, 168, 206, 210, 118, 136, 187, 251, 126, 88, 77, 40, 71, 89, 38, 68, 205, 148, 167, 16, 204, 155, 75, 43, 59, 136, 76, 193, 222, 42, 221, 92, 165, 224, 49, 9, 93, 22, 184, 68, 246, 25, 59, 39, 32, 15, 57, 32, 145, 235, 44, 54, 174, 216, 52, 96, 151, 13, 200, 193, 118, 131, 132, 151, 91, 164, 172, 228, 159, 225, 255, 240, 53, 21, 195, 65, 145, 175, 178, 254, 72, 56, 218, 101, 192, 94, 242, 181, 222, 248, 72, 94, 92, 4, 127, 81, 72, 115, 93, 99, 142, 218, 249, 185, 255, 40, 193, 40, 164, 211, 188, 138, 91, 237, 126, 44, 203 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-33333333333a"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 245, 254, 250, 170, 139, 187, 158, 136, 172, 251, 207, 95, 128, 44, 162, 149, 236, 172, 48, 83, 107, 68, 78, 90, 22, 210, 152, 210, 125, 149, 219, 96, 234, 73, 179, 112, 39, 154, 74, 220, 128, 179, 198, 29, 163, 67, 157, 130, 102, 224, 223, 145, 241, 145, 232, 52, 153, 124, 211, 28, 34, 194, 44, 155 }, new byte[] { 208, 17, 103, 68, 129, 130, 253, 172, 14, 51, 1, 255, 129, 120, 126, 242, 175, 137, 3, 125, 241, 246, 140, 150, 159, 110, 107, 205, 239, 201, 42, 205, 34, 124, 147, 39, 182, 91, 250, 205, 229, 118, 160, 166, 195, 20, 137, 190, 82, 108, 8, 200, 125, 22, 154, 161, 167, 62, 80, 18, 26, 131, 239, 44, 86, 87, 67, 154, 218, 18, 173, 150, 229, 191, 103, 233, 21, 240, 188, 54, 24, 77, 146, 138, 119, 123, 253, 19, 117, 15, 250, 185, 176, 184, 6, 167, 159, 205, 3, 217, 148, 137, 51, 173, 128, 117, 74, 74, 116, 238, 141, 89, 198, 245, 22, 47, 236, 101, 10, 207, 144, 205, 152, 75, 162, 102, 247, 21 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000001"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 124, 2, 5, 56, 70, 88, 112, 222, 206, 92, 121, 225, 206, 249, 199, 118, 116, 67, 131, 117, 60, 38, 87, 161, 22, 236, 54, 203, 9, 174, 169, 109, 211, 136, 150, 3, 44, 237, 36, 55, 238, 45, 255, 35, 244, 14, 74, 165, 93, 100, 42, 127, 14, 249, 146, 193, 92, 29, 227, 76, 178, 131, 26, 138 }, new byte[] { 18, 170, 192, 171, 86, 158, 207, 38, 115, 190, 202, 49, 29, 124, 25, 70, 24, 233, 243, 189, 152, 126, 225, 131, 254, 114, 235, 63, 82, 51, 160, 97, 160, 219, 23, 238, 68, 200, 165, 203, 198, 11, 30, 133, 176, 93, 66, 0, 103, 226, 59, 145, 101, 162, 214, 48, 188, 98, 224, 153, 160, 237, 222, 3, 194, 8, 40, 39, 251, 190, 92, 249, 213, 151, 20, 58, 57, 151, 71, 176, 130, 82, 38, 245, 248, 170, 78, 151, 15, 137, 100, 65, 138, 133, 153, 33, 68, 145, 186, 24, 216, 153, 41, 235, 22, 108, 50, 223, 110, 43, 26, 0, 229, 64, 244, 144, 3, 143, 102, 84, 18, 4, 75, 79, 10, 102, 36, 129 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000002"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 124, 2, 5, 56, 70, 88, 112, 222, 206, 92, 121, 225, 206, 249, 199, 118, 116, 67, 131, 117, 60, 38, 87, 161, 22, 236, 54, 203, 9, 174, 169, 109, 211, 136, 150, 3, 44, 237, 36, 55, 238, 45, 255, 35, 244, 14, 74, 165, 93, 100, 42, 127, 14, 249, 146, 193, 92, 29, 227, 76, 178, 131, 26, 138 }, new byte[] { 18, 170, 192, 171, 86, 158, 207, 38, 115, 190, 202, 49, 29, 124, 25, 70, 24, 233, 243, 189, 152, 126, 225, 131, 254, 114, 235, 63, 82, 51, 160, 97, 160, 219, 23, 238, 68, 200, 165, 203, 198, 11, 30, 133, 176, 93, 66, 0, 103, 226, 59, 145, 101, 162, 214, 48, 188, 98, 224, 153, 160, 237, 222, 3, 194, 8, 40, 39, 251, 190, 92, 249, 213, 151, 20, 58, 57, 151, 71, 176, 130, 82, 38, 245, 248, 170, 78, 151, 15, 137, 100, 65, 138, 133, 153, 33, 68, 145, 186, 24, 216, 153, 41, 235, 22, 108, 50, 223, 110, 43, 26, 0, 229, 64, 244, 144, 3, 143, 102, 84, 18, 4, 75, 79, 10, 102, 36, 129 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000003"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 124, 2, 5, 56, 70, 88, 112, 222, 206, 92, 121, 225, 206, 249, 199, 118, 116, 67, 131, 117, 60, 38, 87, 161, 22, 236, 54, 203, 9, 174, 169, 109, 211, 136, 150, 3, 44, 237, 36, 55, 238, 45, 255, 35, 244, 14, 74, 165, 93, 100, 42, 127, 14, 249, 146, 193, 92, 29, 227, 76, 178, 131, 26, 138 }, new byte[] { 18, 170, 192, 171, 86, 158, 207, 38, 115, 190, 202, 49, 29, 124, 25, 70, 24, 233, 243, 189, 152, 126, 225, 131, 254, 114, 235, 63, 82, 51, 160, 97, 160, 219, 23, 238, 68, 200, 165, 203, 198, 11, 30, 133, 176, 93, 66, 0, 103, 226, 59, 145, 101, 162, 214, 48, 188, 98, 224, 153, 160, 237, 222, 3, 194, 8, 40, 39, 251, 190, 92, 249, 213, 151, 20, 58, 57, 151, 71, 176, 130, 82, 38, 245, 248, 170, 78, 151, 15, 137, 100, 65, 138, 133, 153, 33, 68, 145, 186, 24, 216, 153, 41, 235, 22, 108, 50, 223, 110, 43, 26, 0, 229, 64, 244, 144, 3, 143, 102, 84, 18, 4, 75, 79, 10, 102, 36, 129 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000004"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 124, 2, 5, 56, 70, 88, 112, 222, 206, 92, 121, 225, 206, 249, 199, 118, 116, 67, 131, 117, 60, 38, 87, 161, 22, 236, 54, 203, 9, 174, 169, 109, 211, 136, 150, 3, 44, 237, 36, 55, 238, 45, 255, 35, 244, 14, 74, 165, 93, 100, 42, 127, 14, 249, 146, 193, 92, 29, 227, 76, 178, 131, 26, 138 }, new byte[] { 18, 170, 192, 171, 86, 158, 207, 38, 115, 190, 202, 49, 29, 124, 25, 70, 24, 233, 243, 189, 152, 126, 225, 131, 254, 114, 235, 63, 82, 51, 160, 97, 160, 219, 23, 238, 68, 200, 165, 203, 198, 11, 30, 133, 176, 93, 66, 0, 103, 226, 59, 145, 101, 162, 214, 48, 188, 98, 224, 153, 160, 237, 222, 3, 194, 8, 40, 39, 251, 190, 92, 249, 213, 151, 20, 58, 57, 151, 71, 176, 130, 82, 38, 245, 248, 170, 78, 151, 15, 137, 100, 65, 138, 133, 153, 33, 68, 145, 186, 24, 216, 153, 41, 235, 22, 108, 50, 223, 110, 43, 26, 0, 229, 64, 244, 144, 3, 143, 102, 84, 18, 4, 75, 79, 10, 102, 36, 129 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000005"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 124, 2, 5, 56, 70, 88, 112, 222, 206, 92, 121, 225, 206, 249, 199, 118, 116, 67, 131, 117, 60, 38, 87, 161, 22, 236, 54, 203, 9, 174, 169, 109, 211, 136, 150, 3, 44, 237, 36, 55, 238, 45, 255, 35, 244, 14, 74, 165, 93, 100, 42, 127, 14, 249, 146, 193, 92, 29, 227, 76, 178, 131, 26, 138 }, new byte[] { 18, 170, 192, 171, 86, 158, 207, 38, 115, 190, 202, 49, 29, 124, 25, 70, 24, 233, 243, 189, 152, 126, 225, 131, 254, 114, 235, 63, 82, 51, 160, 97, 160, 219, 23, 238, 68, 200, 165, 203, 198, 11, 30, 133, 176, 93, 66, 0, 103, 226, 59, 145, 101, 162, 214, 48, 188, 98, 224, 153, 160, 237, 222, 3, 194, 8, 40, 39, 251, 190, 92, 249, 213, 151, 20, 58, 57, 151, 71, 176, 130, 82, 38, 245, 248, 170, 78, 151, 15, 137, 100, 65, 138, 133, 153, 33, 68, 145, 186, 24, 216, 153, 41, 235, 22, 108, 50, 223, 110, 43, 26, 0, 229, 64, 244, 144, 3, 143, 102, 84, 18, 4, 75, 79, 10, 102, 36, 129 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000006"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 124, 2, 5, 56, 70, 88, 112, 222, 206, 92, 121, 225, 206, 249, 199, 118, 116, 67, 131, 117, 60, 38, 87, 161, 22, 236, 54, 203, 9, 174, 169, 109, 211, 136, 150, 3, 44, 237, 36, 55, 238, 45, 255, 35, 244, 14, 74, 165, 93, 100, 42, 127, 14, 249, 146, 193, 92, 29, 227, 76, 178, 131, 26, 138 }, new byte[] { 18, 170, 192, 171, 86, 158, 207, 38, 115, 190, 202, 49, 29, 124, 25, 70, 24, 233, 243, 189, 152, 126, 225, 131, 254, 114, 235, 63, 82, 51, 160, 97, 160, 219, 23, 238, 68, 200, 165, 203, 198, 11, 30, 133, 176, 93, 66, 0, 103, 226, 59, 145, 101, 162, 214, 48, 188, 98, 224, 153, 160, 237, 222, 3, 194, 8, 40, 39, 251, 190, 92, 249, 213, 151, 20, 58, 57, 151, 71, 176, 130, 82, 38, 245, 248, 170, 78, 151, 15, 137, 100, 65, 138, 133, 153, 33, 68, 145, 186, 24, 216, 153, 41, 235, 22, 108, 50, 223, 110, 43, 26, 0, 229, 64, 244, 144, 3, 143, 102, 84, 18, 4, 75, 79, 10, 102, 36, 129 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000007"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 124, 2, 5, 56, 70, 88, 112, 222, 206, 92, 121, 225, 206, 249, 199, 118, 116, 67, 131, 117, 60, 38, 87, 161, 22, 236, 54, 203, 9, 174, 169, 109, 211, 136, 150, 3, 44, 237, 36, 55, 238, 45, 255, 35, 244, 14, 74, 165, 93, 100, 42, 127, 14, 249, 146, 193, 92, 29, 227, 76, 178, 131, 26, 138 }, new byte[] { 18, 170, 192, 171, 86, 158, 207, 38, 115, 190, 202, 49, 29, 124, 25, 70, 24, 233, 243, 189, 152, 126, 225, 131, 254, 114, 235, 63, 82, 51, 160, 97, 160, 219, 23, 238, 68, 200, 165, 203, 198, 11, 30, 133, 176, 93, 66, 0, 103, 226, 59, 145, 101, 162, 214, 48, 188, 98, 224, 153, 160, 237, 222, 3, 194, 8, 40, 39, 251, 190, 92, 249, 213, 151, 20, 58, 57, 151, 71, 176, 130, 82, 38, 245, 248, 170, 78, 151, 15, 137, 100, 65, 138, 133, 153, 33, 68, 145, 186, 24, 216, 153, 41, 235, 22, 108, 50, 223, 110, 43, 26, 0, 229, 64, 244, 144, 3, 143, 102, 84, 18, 4, 75, 79, 10, 102, 36, 129 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000008"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 124, 2, 5, 56, 70, 88, 112, 222, 206, 92, 121, 225, 206, 249, 199, 118, 116, 67, 131, 117, 60, 38, 87, 161, 22, 236, 54, 203, 9, 174, 169, 109, 211, 136, 150, 3, 44, 237, 36, 55, 238, 45, 255, 35, 244, 14, 74, 165, 93, 100, 42, 127, 14, 249, 146, 193, 92, 29, 227, 76, 178, 131, 26, 138 }, new byte[] { 18, 170, 192, 171, 86, 158, 207, 38, 115, 190, 202, 49, 29, 124, 25, 70, 24, 233, 243, 189, 152, 126, 225, 131, 254, 114, 235, 63, 82, 51, 160, 97, 160, 219, 23, 238, 68, 200, 165, 203, 198, 11, 30, 133, 176, 93, 66, 0, 103, 226, 59, 145, 101, 162, 214, 48, 188, 98, 224, 153, 160, 237, 222, 3, 194, 8, 40, 39, 251, 190, 92, 249, 213, 151, 20, 58, 57, 151, 71, 176, 130, 82, 38, 245, 248, 170, 78, 151, 15, 137, 100, 65, 138, 133, 153, 33, 68, 145, 186, 24, 216, 153, 41, 235, 22, 108, 50, 223, 110, 43, 26, 0, 229, 64, 244, 144, 3, 143, 102, 84, 18, 4, 75, 79, 10, 102, 36, 129 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000009"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 124, 2, 5, 56, 70, 88, 112, 222, 206, 92, 121, 225, 206, 249, 199, 118, 116, 67, 131, 117, 60, 38, 87, 161, 22, 236, 54, 203, 9, 174, 169, 109, 211, 136, 150, 3, 44, 237, 36, 55, 238, 45, 255, 35, 244, 14, 74, 165, 93, 100, 42, 127, 14, 249, 146, 193, 92, 29, 227, 76, 178, 131, 26, 138 }, new byte[] { 18, 170, 192, 171, 86, 158, 207, 38, 115, 190, 202, 49, 29, 124, 25, 70, 24, 233, 243, 189, 152, 126, 225, 131, 254, 114, 235, 63, 82, 51, 160, 97, 160, 219, 23, 238, 68, 200, 165, 203, 198, 11, 30, 133, 176, 93, 66, 0, 103, 226, 59, 145, 101, 162, 214, 48, 188, 98, 224, 153, 160, 237, 222, 3, 194, 8, 40, 39, 251, 190, 92, 249, 213, 151, 20, 58, 57, 151, 71, 176, 130, 82, 38, 245, 248, 170, 78, 151, 15, 137, 100, 65, 138, 133, 153, 33, 68, 145, 186, 24, 216, 153, 41, 235, 22, 108, 50, 223, 110, 43, 26, 0, 229, 64, 244, 144, 3, 143, 102, 84, 18, 4, 75, 79, 10, 102, 36, 129 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000010"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 124, 2, 5, 56, 70, 88, 112, 222, 206, 92, 121, 225, 206, 249, 199, 118, 116, 67, 131, 117, 60, 38, 87, 161, 22, 236, 54, 203, 9, 174, 169, 109, 211, 136, 150, 3, 44, 237, 36, 55, 238, 45, 255, 35, 244, 14, 74, 165, 93, 100, 42, 127, 14, 249, 146, 193, 92, 29, 227, 76, 178, 131, 26, 138 }, new byte[] { 18, 170, 192, 171, 86, 158, 207, 38, 115, 190, 202, 49, 29, 124, 25, 70, 24, 233, 243, 189, 152, 126, 225, 131, 254, 114, 235, 63, 82, 51, 160, 97, 160, 219, 23, 238, 68, 200, 165, 203, 198, 11, 30, 133, 176, 93, 66, 0, 103, 226, 59, 145, 101, 162, 214, 48, 188, 98, 224, 153, 160, 237, 222, 3, 194, 8, 40, 39, 251, 190, 92, 249, 213, 151, 20, 58, 57, 151, 71, 176, 130, 82, 38, 245, 248, 170, 78, 151, 15, 137, 100, 65, 138, 133, 153, 33, 68, 145, 186, 24, 216, 153, 41, 235, 22, 108, 50, 223, 110, 43, 26, 0, 229, 64, 244, 144, 3, 143, 102, 84, 18, 4, 75, 79, 10, 102, 36, 129 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000011"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 124, 2, 5, 56, 70, 88, 112, 222, 206, 92, 121, 225, 206, 249, 199, 118, 116, 67, 131, 117, 60, 38, 87, 161, 22, 236, 54, 203, 9, 174, 169, 109, 211, 136, 150, 3, 44, 237, 36, 55, 238, 45, 255, 35, 244, 14, 74, 165, 93, 100, 42, 127, 14, 249, 146, 193, 92, 29, 227, 76, 178, 131, 26, 138 }, new byte[] { 18, 170, 192, 171, 86, 158, 207, 38, 115, 190, 202, 49, 29, 124, 25, 70, 24, 233, 243, 189, 152, 126, 225, 131, 254, 114, 235, 63, 82, 51, 160, 97, 160, 219, 23, 238, 68, 200, 165, 203, 198, 11, 30, 133, 176, 93, 66, 0, 103, 226, 59, 145, 101, 162, 214, 48, 188, 98, 224, 153, 160, 237, 222, 3, 194, 8, 40, 39, 251, 190, 92, 249, 213, 151, 20, 58, 57, 151, 71, 176, 130, 82, 38, 245, 248, 170, 78, 151, 15, 137, 100, 65, 138, 133, 153, 33, 68, 145, 186, 24, 216, 153, 41, 235, 22, 108, 50, 223, 110, 43, 26, 0, 229, 64, 244, 144, 3, 143, 102, 84, 18, 4, 75, 79, 10, 102, 36, 129 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000012"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 124, 2, 5, 56, 70, 88, 112, 222, 206, 92, 121, 225, 206, 249, 199, 118, 116, 67, 131, 117, 60, 38, 87, 161, 22, 236, 54, 203, 9, 174, 169, 109, 211, 136, 150, 3, 44, 237, 36, 55, 238, 45, 255, 35, 244, 14, 74, 165, 93, 100, 42, 127, 14, 249, 146, 193, 92, 29, 227, 76, 178, 131, 26, 138 }, new byte[] { 18, 170, 192, 171, 86, 158, 207, 38, 115, 190, 202, 49, 29, 124, 25, 70, 24, 233, 243, 189, 152, 126, 225, 131, 254, 114, 235, 63, 82, 51, 160, 97, 160, 219, 23, 238, 68, 200, 165, 203, 198, 11, 30, 133, 176, 93, 66, 0, 103, 226, 59, 145, 101, 162, 214, 48, 188, 98, 224, 153, 160, 237, 222, 3, 194, 8, 40, 39, 251, 190, 92, 249, 213, 151, 20, 58, 57, 151, 71, 176, 130, 82, 38, 245, 248, 170, 78, 151, 15, 137, 100, 65, 138, 133, 153, 33, 68, 145, 186, 24, 216, 153, 41, 235, 22, 108, 50, 223, 110, 43, 26, 0, 229, 64, 244, 144, 3, 143, 102, 84, 18, 4, 75, 79, 10, 102, 36, 129 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000013"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 124, 2, 5, 56, 70, 88, 112, 222, 206, 92, 121, 225, 206, 249, 199, 118, 116, 67, 131, 117, 60, 38, 87, 161, 22, 236, 54, 203, 9, 174, 169, 109, 211, 136, 150, 3, 44, 237, 36, 55, 238, 45, 255, 35, 244, 14, 74, 165, 93, 100, 42, 127, 14, 249, 146, 193, 92, 29, 227, 76, 178, 131, 26, 138 }, new byte[] { 18, 170, 192, 171, 86, 158, 207, 38, 115, 190, 202, 49, 29, 124, 25, 70, 24, 233, 243, 189, 152, 126, 225, 131, 254, 114, 235, 63, 82, 51, 160, 97, 160, 219, 23, 238, 68, 200, 165, 203, 198, 11, 30, 133, 176, 93, 66, 0, 103, 226, 59, 145, 101, 162, 214, 48, 188, 98, 224, 153, 160, 237, 222, 3, 194, 8, 40, 39, 251, 190, 92, 249, 213, 151, 20, 58, 57, 151, 71, 176, 130, 82, 38, 245, 248, 170, 78, 151, 15, 137, 100, 65, 138, 133, 153, 33, 68, 145, 186, 24, 216, 153, 41, 235, 22, 108, 50, 223, 110, 43, 26, 0, 229, 64, 244, 144, 3, 143, 102, 84, 18, 4, 75, 79, 10, 102, 36, 129 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000014"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 124, 2, 5, 56, 70, 88, 112, 222, 206, 92, 121, 225, 206, 249, 199, 118, 116, 67, 131, 117, 60, 38, 87, 161, 22, 236, 54, 203, 9, 174, 169, 109, 211, 136, 150, 3, 44, 237, 36, 55, 238, 45, 255, 35, 244, 14, 74, 165, 93, 100, 42, 127, 14, 249, 146, 193, 92, 29, 227, 76, 178, 131, 26, 138 }, new byte[] { 18, 170, 192, 171, 86, 158, 207, 38, 115, 190, 202, 49, 29, 124, 25, 70, 24, 233, 243, 189, 152, 126, 225, 131, 254, 114, 235, 63, 82, 51, 160, 97, 160, 219, 23, 238, 68, 200, 165, 203, 198, 11, 30, 133, 176, 93, 66, 0, 103, 226, 59, 145, 101, 162, 214, 48, 188, 98, 224, 153, 160, 237, 222, 3, 194, 8, 40, 39, 251, 190, 92, 249, 213, 151, 20, 58, 57, 151, 71, 176, 130, 82, 38, 245, 248, 170, 78, 151, 15, 137, 100, 65, 138, 133, 153, 33, 68, 145, 186, 24, 216, 153, 41, 235, 22, 108, 50, 223, 110, 43, 26, 0, 229, 64, 244, 144, 3, 143, 102, 84, 18, 4, 75, 79, 10, 102, 36, 129 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000015"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 124, 2, 5, 56, 70, 88, 112, 222, 206, 92, 121, 225, 206, 249, 199, 118, 116, 67, 131, 117, 60, 38, 87, 161, 22, 236, 54, 203, 9, 174, 169, 109, 211, 136, 150, 3, 44, 237, 36, 55, 238, 45, 255, 35, 244, 14, 74, 165, 93, 100, 42, 127, 14, 249, 146, 193, 92, 29, 227, 76, 178, 131, 26, 138 }, new byte[] { 18, 170, 192, 171, 86, 158, 207, 38, 115, 190, 202, 49, 29, 124, 25, 70, 24, 233, 243, 189, 152, 126, 225, 131, 254, 114, 235, 63, 82, 51, 160, 97, 160, 219, 23, 238, 68, 200, 165, 203, 198, 11, 30, 133, 176, 93, 66, 0, 103, 226, 59, 145, 101, 162, 214, 48, 188, 98, 224, 153, 160, 237, 222, 3, 194, 8, 40, 39, 251, 190, 92, 249, 213, 151, 20, 58, 57, 151, 71, 176, 130, 82, 38, 245, 248, 170, 78, 151, 15, 137, 100, 65, 138, 133, 153, 33, 68, 145, 186, 24, 216, 153, 41, 235, 22, 108, 50, 223, 110, 43, 26, 0, 229, 64, 244, 144, 3, 143, 102, 84, 18, 4, 75, 79, 10, 102, 36, 129 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000016"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 124, 2, 5, 56, 70, 88, 112, 222, 206, 92, 121, 225, 206, 249, 199, 118, 116, 67, 131, 117, 60, 38, 87, 161, 22, 236, 54, 203, 9, 174, 169, 109, 211, 136, 150, 3, 44, 237, 36, 55, 238, 45, 255, 35, 244, 14, 74, 165, 93, 100, 42, 127, 14, 249, 146, 193, 92, 29, 227, 76, 178, 131, 26, 138 }, new byte[] { 18, 170, 192, 171, 86, 158, 207, 38, 115, 190, 202, 49, 29, 124, 25, 70, 24, 233, 243, 189, 152, 126, 225, 131, 254, 114, 235, 63, 82, 51, 160, 97, 160, 219, 23, 238, 68, 200, 165, 203, 198, 11, 30, 133, 176, 93, 66, 0, 103, 226, 59, 145, 101, 162, 214, 48, 188, 98, 224, 153, 160, 237, 222, 3, 194, 8, 40, 39, 251, 190, 92, 249, 213, 151, 20, 58, 57, 151, 71, 176, 130, 82, 38, 245, 248, 170, 78, 151, 15, 137, 100, 65, 138, 133, 153, 33, 68, 145, 186, 24, 216, 153, 41, 235, 22, 108, 50, 223, 110, 43, 26, 0, 229, 64, 244, 144, 3, 143, 102, 84, 18, 4, 75, 79, 10, 102, 36, 129 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000017"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 124, 2, 5, 56, 70, 88, 112, 222, 206, 92, 121, 225, 206, 249, 199, 118, 116, 67, 131, 117, 60, 38, 87, 161, 22, 236, 54, 203, 9, 174, 169, 109, 211, 136, 150, 3, 44, 237, 36, 55, 238, 45, 255, 35, 244, 14, 74, 165, 93, 100, 42, 127, 14, 249, 146, 193, 92, 29, 227, 76, 178, 131, 26, 138 }, new byte[] { 18, 170, 192, 171, 86, 158, 207, 38, 115, 190, 202, 49, 29, 124, 25, 70, 24, 233, 243, 189, 152, 126, 225, 131, 254, 114, 235, 63, 82, 51, 160, 97, 160, 219, 23, 238, 68, 200, 165, 203, 198, 11, 30, 133, 176, 93, 66, 0, 103, 226, 59, 145, 101, 162, 214, 48, 188, 98, 224, 153, 160, 237, 222, 3, 194, 8, 40, 39, 251, 190, 92, 249, 213, 151, 20, 58, 57, 151, 71, 176, 130, 82, 38, 245, 248, 170, 78, 151, 15, 137, 100, 65, 138, 133, 153, 33, 68, 145, 186, 24, 216, 153, 41, 235, 22, 108, 50, 223, 110, 43, 26, 0, 229, 64, 244, 144, 3, 143, 102, 84, 18, 4, 75, 79, 10, 102, 36, 129 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000018"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 124, 2, 5, 56, 70, 88, 112, 222, 206, 92, 121, 225, 206, 249, 199, 118, 116, 67, 131, 117, 60, 38, 87, 161, 22, 236, 54, 203, 9, 174, 169, 109, 211, 136, 150, 3, 44, 237, 36, 55, 238, 45, 255, 35, 244, 14, 74, 165, 93, 100, 42, 127, 14, 249, 146, 193, 92, 29, 227, 76, 178, 131, 26, 138 }, new byte[] { 18, 170, 192, 171, 86, 158, 207, 38, 115, 190, 202, 49, 29, 124, 25, 70, 24, 233, 243, 189, 152, 126, 225, 131, 254, 114, 235, 63, 82, 51, 160, 97, 160, 219, 23, 238, 68, 200, 165, 203, 198, 11, 30, 133, 176, 93, 66, 0, 103, 226, 59, 145, 101, 162, 214, 48, 188, 98, 224, 153, 160, 237, 222, 3, 194, 8, 40, 39, 251, 190, 92, 249, 213, 151, 20, 58, 57, 151, 71, 176, 130, 82, 38, 245, 248, 170, 78, 151, 15, 137, 100, 65, 138, 133, 153, 33, 68, 145, 186, 24, 216, 153, 41, 235, 22, 108, 50, 223, 110, 43, 26, 0, 229, 64, 244, 144, 3, 143, 102, 84, 18, 4, 75, 79, 10, 102, 36, 129 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000019"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 124, 2, 5, 56, 70, 88, 112, 222, 206, 92, 121, 225, 206, 249, 199, 118, 116, 67, 131, 117, 60, 38, 87, 161, 22, 236, 54, 203, 9, 174, 169, 109, 211, 136, 150, 3, 44, 237, 36, 55, 238, 45, 255, 35, 244, 14, 74, 165, 93, 100, 42, 127, 14, 249, 146, 193, 92, 29, 227, 76, 178, 131, 26, 138 }, new byte[] { 18, 170, 192, 171, 86, 158, 207, 38, 115, 190, 202, 49, 29, 124, 25, 70, 24, 233, 243, 189, 152, 126, 225, 131, 254, 114, 235, 63, 82, 51, 160, 97, 160, 219, 23, 238, 68, 200, 165, 203, 198, 11, 30, 133, 176, 93, 66, 0, 103, 226, 59, 145, 101, 162, 214, 48, 188, 98, 224, 153, 160, 237, 222, 3, 194, 8, 40, 39, 251, 190, 92, 249, 213, 151, 20, 58, 57, 151, 71, 176, 130, 82, 38, 245, 248, 170, 78, 151, 15, 137, 100, 65, 138, 133, 153, 33, 68, 145, 186, 24, 216, 153, 41, 235, 22, 108, 50, 223, 110, 43, 26, 0, 229, 64, 244, 144, 3, 143, 102, 84, 18, 4, 75, 79, 10, 102, 36, 129 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000020"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 124, 2, 5, 56, 70, 88, 112, 222, 206, 92, 121, 225, 206, 249, 199, 118, 116, 67, 131, 117, 60, 38, 87, 161, 22, 236, 54, 203, 9, 174, 169, 109, 211, 136, 150, 3, 44, 237, 36, 55, 238, 45, 255, 35, 244, 14, 74, 165, 93, 100, 42, 127, 14, 249, 146, 193, 92, 29, 227, 76, 178, 131, 26, 138 }, new byte[] { 18, 170, 192, 171, 86, 158, 207, 38, 115, 190, 202, 49, 29, 124, 25, 70, 24, 233, 243, 189, 152, 126, 225, 131, 254, 114, 235, 63, 82, 51, 160, 97, 160, 219, 23, 238, 68, 200, 165, 203, 198, 11, 30, 133, 176, 93, 66, 0, 103, 226, 59, 145, 101, 162, 214, 48, 188, 98, 224, 153, 160, 237, 222, 3, 194, 8, 40, 39, 251, 190, 92, 249, 213, 151, 20, 58, 57, 151, 71, 176, 130, 82, 38, 245, 248, 170, 78, 151, 15, 137, 100, 65, 138, 133, 153, 33, 68, 145, 186, 24, 216, 153, 41, 235, 22, 108, 50, 223, 110, 43, 26, 0, 229, 64, 244, 144, 3, 143, 102, 84, 18, 4, 75, 79, 10, 102, 36, 129 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000021"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 124, 2, 5, 56, 70, 88, 112, 222, 206, 92, 121, 225, 206, 249, 199, 118, 116, 67, 131, 117, 60, 38, 87, 161, 22, 236, 54, 203, 9, 174, 169, 109, 211, 136, 150, 3, 44, 237, 36, 55, 238, 45, 255, 35, 244, 14, 74, 165, 93, 100, 42, 127, 14, 249, 146, 193, 92, 29, 227, 76, 178, 131, 26, 138 }, new byte[] { 18, 170, 192, 171, 86, 158, 207, 38, 115, 190, 202, 49, 29, 124, 25, 70, 24, 233, 243, 189, 152, 126, 225, 131, 254, 114, 235, 63, 82, 51, 160, 97, 160, 219, 23, 238, 68, 200, 165, 203, 198, 11, 30, 133, 176, 93, 66, 0, 103, 226, 59, 145, 101, 162, 214, 48, 188, 98, 224, 153, 160, 237, 222, 3, 194, 8, 40, 39, 251, 190, 92, 249, 213, 151, 20, 58, 57, 151, 71, 176, 130, 82, 38, 245, 248, 170, 78, 151, 15, 137, 100, 65, 138, 133, 153, 33, 68, 145, 186, 24, 216, 153, 41, 235, 22, 108, 50, 223, 110, 43, 26, 0, 229, 64, 244, 144, 3, 143, 102, 84, 18, 4, 75, 79, 10, 102, 36, 129 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000022"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 124, 2, 5, 56, 70, 88, 112, 222, 206, 92, 121, 225, 206, 249, 199, 118, 116, 67, 131, 117, 60, 38, 87, 161, 22, 236, 54, 203, 9, 174, 169, 109, 211, 136, 150, 3, 44, 237, 36, 55, 238, 45, 255, 35, 244, 14, 74, 165, 93, 100, 42, 127, 14, 249, 146, 193, 92, 29, 227, 76, 178, 131, 26, 138 }, new byte[] { 18, 170, 192, 171, 86, 158, 207, 38, 115, 190, 202, 49, 29, 124, 25, 70, 24, 233, 243, 189, 152, 126, 225, 131, 254, 114, 235, 63, 82, 51, 160, 97, 160, 219, 23, 238, 68, 200, 165, 203, 198, 11, 30, 133, 176, 93, 66, 0, 103, 226, 59, 145, 101, 162, 214, 48, 188, 98, 224, 153, 160, 237, 222, 3, 194, 8, 40, 39, 251, 190, 92, 249, 213, 151, 20, 58, 57, 151, 71, 176, 130, 82, 38, 245, 248, 170, 78, 151, 15, 137, 100, 65, 138, 133, 153, 33, 68, 145, 186, 24, 216, 153, 41, 235, 22, 108, 50, 223, 110, 43, 26, 0, 229, 64, 244, 144, 3, 143, 102, 84, 18, 4, 75, 79, 10, 102, 36, 129 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000023"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 124, 2, 5, 56, 70, 88, 112, 222, 206, 92, 121, 225, 206, 249, 199, 118, 116, 67, 131, 117, 60, 38, 87, 161, 22, 236, 54, 203, 9, 174, 169, 109, 211, 136, 150, 3, 44, 237, 36, 55, 238, 45, 255, 35, 244, 14, 74, 165, 93, 100, 42, 127, 14, 249, 146, 193, 92, 29, 227, 76, 178, 131, 26, 138 }, new byte[] { 18, 170, 192, 171, 86, 158, 207, 38, 115, 190, 202, 49, 29, 124, 25, 70, 24, 233, 243, 189, 152, 126, 225, 131, 254, 114, 235, 63, 82, 51, 160, 97, 160, 219, 23, 238, 68, 200, 165, 203, 198, 11, 30, 133, 176, 93, 66, 0, 103, 226, 59, 145, 101, 162, 214, 48, 188, 98, 224, 153, 160, 237, 222, 3, 194, 8, 40, 39, 251, 190, 92, 249, 213, 151, 20, 58, 57, 151, 71, 176, 130, 82, 38, 245, 248, 170, 78, 151, 15, 137, 100, 65, 138, 133, 153, 33, 68, 145, 186, 24, 216, 153, 41, 235, 22, 108, 50, 223, 110, 43, 26, 0, 229, 64, 244, 144, 3, 143, 102, 84, 18, 4, 75, 79, 10, 102, 36, 129 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000024"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 124, 2, 5, 56, 70, 88, 112, 222, 206, 92, 121, 225, 206, 249, 199, 118, 116, 67, 131, 117, 60, 38, 87, 161, 22, 236, 54, 203, 9, 174, 169, 109, 211, 136, 150, 3, 44, 237, 36, 55, 238, 45, 255, 35, 244, 14, 74, 165, 93, 100, 42, 127, 14, 249, 146, 193, 92, 29, 227, 76, 178, 131, 26, 138 }, new byte[] { 18, 170, 192, 171, 86, 158, 207, 38, 115, 190, 202, 49, 29, 124, 25, 70, 24, 233, 243, 189, 152, 126, 225, 131, 254, 114, 235, 63, 82, 51, 160, 97, 160, 219, 23, 238, 68, 200, 165, 203, 198, 11, 30, 133, 176, 93, 66, 0, 103, 226, 59, 145, 101, 162, 214, 48, 188, 98, 224, 153, 160, 237, 222, 3, 194, 8, 40, 39, 251, 190, 92, 249, 213, 151, 20, 58, 57, 151, 71, 176, 130, 82, 38, 245, 248, 170, 78, 151, 15, 137, 100, 65, 138, 133, 153, 33, 68, 145, 186, 24, 216, 153, 41, 235, 22, 108, 50, 223, 110, 43, 26, 0, 229, 64, 244, 144, 3, 143, 102, 84, 18, 4, 75, 79, 10, 102, 36, 129 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000025"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 124, 2, 5, 56, 70, 88, 112, 222, 206, 92, 121, 225, 206, 249, 199, 118, 116, 67, 131, 117, 60, 38, 87, 161, 22, 236, 54, 203, 9, 174, 169, 109, 211, 136, 150, 3, 44, 237, 36, 55, 238, 45, 255, 35, 244, 14, 74, 165, 93, 100, 42, 127, 14, 249, 146, 193, 92, 29, 227, 76, 178, 131, 26, 138 }, new byte[] { 18, 170, 192, 171, 86, 158, 207, 38, 115, 190, 202, 49, 29, 124, 25, 70, 24, 233, 243, 189, 152, 126, 225, 131, 254, 114, 235, 63, 82, 51, 160, 97, 160, 219, 23, 238, 68, 200, 165, 203, 198, 11, 30, 133, 176, 93, 66, 0, 103, 226, 59, 145, 101, 162, 214, 48, 188, 98, 224, 153, 160, 237, 222, 3, 194, 8, 40, 39, 251, 190, 92, 249, 213, 151, 20, 58, 57, 151, 71, 176, 130, 82, 38, 245, 248, 170, 78, 151, 15, 137, 100, 65, 138, 133, 153, 33, 68, 145, 186, 24, 216, 153, 41, 235, 22, 108, 50, 223, 110, 43, 26, 0, 229, 64, 244, 144, 3, 143, 102, 84, 18, 4, 75, 79, 10, 102, 36, 129 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000026"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 124, 2, 5, 56, 70, 88, 112, 222, 206, 92, 121, 225, 206, 249, 199, 118, 116, 67, 131, 117, 60, 38, 87, 161, 22, 236, 54, 203, 9, 174, 169, 109, 211, 136, 150, 3, 44, 237, 36, 55, 238, 45, 255, 35, 244, 14, 74, 165, 93, 100, 42, 127, 14, 249, 146, 193, 92, 29, 227, 76, 178, 131, 26, 138 }, new byte[] { 18, 170, 192, 171, 86, 158, 207, 38, 115, 190, 202, 49, 29, 124, 25, 70, 24, 233, 243, 189, 152, 126, 225, 131, 254, 114, 235, 63, 82, 51, 160, 97, 160, 219, 23, 238, 68, 200, 165, 203, 198, 11, 30, 133, 176, 93, 66, 0, 103, 226, 59, 145, 101, 162, 214, 48, 188, 98, 224, 153, 160, 237, 222, 3, 194, 8, 40, 39, 251, 190, 92, 249, 213, 151, 20, 58, 57, 151, 71, 176, 130, 82, 38, 245, 248, 170, 78, 151, 15, 137, 100, 65, 138, 133, 153, 33, 68, 145, 186, 24, 216, 153, 41, 235, 22, 108, 50, 223, 110, 43, 26, 0, 229, 64, 244, 144, 3, 143, 102, 84, 18, 4, 75, 79, 10, 102, 36, 129 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000027"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 124, 2, 5, 56, 70, 88, 112, 222, 206, 92, 121, 225, 206, 249, 199, 118, 116, 67, 131, 117, 60, 38, 87, 161, 22, 236, 54, 203, 9, 174, 169, 109, 211, 136, 150, 3, 44, 237, 36, 55, 238, 45, 255, 35, 244, 14, 74, 165, 93, 100, 42, 127, 14, 249, 146, 193, 92, 29, 227, 76, 178, 131, 26, 138 }, new byte[] { 18, 170, 192, 171, 86, 158, 207, 38, 115, 190, 202, 49, 29, 124, 25, 70, 24, 233, 243, 189, 152, 126, 225, 131, 254, 114, 235, 63, 82, 51, 160, 97, 160, 219, 23, 238, 68, 200, 165, 203, 198, 11, 30, 133, 176, 93, 66, 0, 103, 226, 59, 145, 101, 162, 214, 48, 188, 98, 224, 153, 160, 237, 222, 3, 194, 8, 40, 39, 251, 190, 92, 249, 213, 151, 20, 58, 57, 151, 71, 176, 130, 82, 38, 245, 248, 170, 78, 151, 15, 137, 100, 65, 138, 133, 153, 33, 68, 145, 186, 24, 216, 153, 41, 235, 22, 108, 50, 223, 110, 43, 26, 0, 229, 64, 244, 144, 3, 143, 102, 84, 18, 4, 75, 79, 10, 102, 36, 129 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000028"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 124, 2, 5, 56, 70, 88, 112, 222, 206, 92, 121, 225, 206, 249, 199, 118, 116, 67, 131, 117, 60, 38, 87, 161, 22, 236, 54, 203, 9, 174, 169, 109, 211, 136, 150, 3, 44, 237, 36, 55, 238, 45, 255, 35, 244, 14, 74, 165, 93, 100, 42, 127, 14, 249, 146, 193, 92, 29, 227, 76, 178, 131, 26, 138 }, new byte[] { 18, 170, 192, 171, 86, 158, 207, 38, 115, 190, 202, 49, 29, 124, 25, 70, 24, 233, 243, 189, 152, 126, 225, 131, 254, 114, 235, 63, 82, 51, 160, 97, 160, 219, 23, 238, 68, 200, 165, 203, 198, 11, 30, 133, 176, 93, 66, 0, 103, 226, 59, 145, 101, 162, 214, 48, 188, 98, 224, 153, 160, 237, 222, 3, 194, 8, 40, 39, 251, 190, 92, 249, 213, 151, 20, 58, 57, 151, 71, 176, 130, 82, 38, 245, 248, 170, 78, 151, 15, 137, 100, 65, 138, 133, 153, 33, 68, 145, 186, 24, 216, 153, 41, 235, 22, 108, 50, 223, 110, 43, 26, 0, 229, 64, 244, 144, 3, 143, 102, 84, 18, 4, 75, 79, 10, 102, 36, 129 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000029"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 124, 2, 5, 56, 70, 88, 112, 222, 206, 92, 121, 225, 206, 249, 199, 118, 116, 67, 131, 117, 60, 38, 87, 161, 22, 236, 54, 203, 9, 174, 169, 109, 211, 136, 150, 3, 44, 237, 36, 55, 238, 45, 255, 35, 244, 14, 74, 165, 93, 100, 42, 127, 14, 249, 146, 193, 92, 29, 227, 76, 178, 131, 26, 138 }, new byte[] { 18, 170, 192, 171, 86, 158, 207, 38, 115, 190, 202, 49, 29, 124, 25, 70, 24, 233, 243, 189, 152, 126, 225, 131, 254, 114, 235, 63, 82, 51, 160, 97, 160, 219, 23, 238, 68, 200, 165, 203, 198, 11, 30, 133, 176, 93, 66, 0, 103, 226, 59, 145, 101, 162, 214, 48, 188, 98, 224, 153, 160, 237, 222, 3, 194, 8, 40, 39, 251, 190, 92, 249, 213, 151, 20, 58, 57, 151, 71, 176, 130, 82, 38, 245, 248, 170, 78, 151, 15, 137, 100, 65, 138, 133, 153, 33, 68, 145, 186, 24, 216, 153, 41, 235, 22, 108, 50, 223, 110, 43, 26, 0, 229, 64, 244, 144, 3, 143, 102, 84, 18, 4, 75, 79, 10, 102, 36, 129 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000030"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 124, 2, 5, 56, 70, 88, 112, 222, 206, 92, 121, 225, 206, 249, 199, 118, 116, 67, 131, 117, 60, 38, 87, 161, 22, 236, 54, 203, 9, 174, 169, 109, 211, 136, 150, 3, 44, 237, 36, 55, 238, 45, 255, 35, 244, 14, 74, 165, 93, 100, 42, 127, 14, 249, 146, 193, 92, 29, 227, 76, 178, 131, 26, 138 }, new byte[] { 18, 170, 192, 171, 86, 158, 207, 38, 115, 190, 202, 49, 29, 124, 25, 70, 24, 233, 243, 189, 152, 126, 225, 131, 254, 114, 235, 63, 82, 51, 160, 97, 160, 219, 23, 238, 68, 200, 165, 203, 198, 11, 30, 133, 176, 93, 66, 0, 103, 226, 59, 145, 101, 162, 214, 48, 188, 98, 224, 153, 160, 237, 222, 3, 194, 8, 40, 39, 251, 190, 92, 249, 213, 151, 20, 58, 57, 151, 71, 176, 130, 82, 38, 245, 248, 170, 78, 151, 15, 137, 100, 65, 138, 133, 153, 33, 68, 145, 186, 24, 216, 153, 41, 235, 22, 108, 50, 223, 110, 43, 26, 0, 229, 64, 244, 144, 3, 143, 102, 84, 18, 4, 75, 79, 10, 102, 36, 129 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000031"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 124, 2, 5, 56, 70, 88, 112, 222, 206, 92, 121, 225, 206, 249, 199, 118, 116, 67, 131, 117, 60, 38, 87, 161, 22, 236, 54, 203, 9, 174, 169, 109, 211, 136, 150, 3, 44, 237, 36, 55, 238, 45, 255, 35, 244, 14, 74, 165, 93, 100, 42, 127, 14, 249, 146, 193, 92, 29, 227, 76, 178, 131, 26, 138 }, new byte[] { 18, 170, 192, 171, 86, 158, 207, 38, 115, 190, 202, 49, 29, 124, 25, 70, 24, 233, 243, 189, 152, 126, 225, 131, 254, 114, 235, 63, 82, 51, 160, 97, 160, 219, 23, 238, 68, 200, 165, 203, 198, 11, 30, 133, 176, 93, 66, 0, 103, 226, 59, 145, 101, 162, 214, 48, 188, 98, 224, 153, 160, 237, 222, 3, 194, 8, 40, 39, 251, 190, 92, 249, 213, 151, 20, 58, 57, 151, 71, 176, 130, 82, 38, 245, 248, 170, 78, 151, 15, 137, 100, 65, 138, 133, 153, 33, 68, 145, 186, 24, 216, 153, 41, 235, 22, 108, 50, 223, 110, 43, 26, 0, 229, 64, 244, 144, 3, 143, 102, 84, 18, 4, 75, 79, 10, 102, 36, 129 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000032"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 124, 2, 5, 56, 70, 88, 112, 222, 206, 92, 121, 225, 206, 249, 199, 118, 116, 67, 131, 117, 60, 38, 87, 161, 22, 236, 54, 203, 9, 174, 169, 109, 211, 136, 150, 3, 44, 237, 36, 55, 238, 45, 255, 35, 244, 14, 74, 165, 93, 100, 42, 127, 14, 249, 146, 193, 92, 29, 227, 76, 178, 131, 26, 138 }, new byte[] { 18, 170, 192, 171, 86, 158, 207, 38, 115, 190, 202, 49, 29, 124, 25, 70, 24, 233, 243, 189, 152, 126, 225, 131, 254, 114, 235, 63, 82, 51, 160, 97, 160, 219, 23, 238, 68, 200, 165, 203, 198, 11, 30, 133, 176, 93, 66, 0, 103, 226, 59, 145, 101, 162, 214, 48, 188, 98, 224, 153, 160, 237, 222, 3, 194, 8, 40, 39, 251, 190, 92, 249, 213, 151, 20, 58, 57, 151, 71, 176, 130, 82, 38, 245, 248, 170, 78, 151, 15, 137, 100, 65, 138, 133, 153, 33, 68, 145, 186, 24, 216, 153, 41, 235, 22, 108, 50, 223, 110, 43, 26, 0, 229, 64, 244, 144, 3, 143, 102, 84, 18, 4, 75, 79, 10, 102, 36, 129 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000033"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 124, 2, 5, 56, 70, 88, 112, 222, 206, 92, 121, 225, 206, 249, 199, 118, 116, 67, 131, 117, 60, 38, 87, 161, 22, 236, 54, 203, 9, 174, 169, 109, 211, 136, 150, 3, 44, 237, 36, 55, 238, 45, 255, 35, 244, 14, 74, 165, 93, 100, 42, 127, 14, 249, 146, 193, 92, 29, 227, 76, 178, 131, 26, 138 }, new byte[] { 18, 170, 192, 171, 86, 158, 207, 38, 115, 190, 202, 49, 29, 124, 25, 70, 24, 233, 243, 189, 152, 126, 225, 131, 254, 114, 235, 63, 82, 51, 160, 97, 160, 219, 23, 238, 68, 200, 165, 203, 198, 11, 30, 133, 176, 93, 66, 0, 103, 226, 59, 145, 101, 162, 214, 48, 188, 98, 224, 153, 160, 237, 222, 3, 194, 8, 40, 39, 251, 190, 92, 249, 213, 151, 20, 58, 57, 151, 71, 176, 130, 82, 38, 245, 248, 170, 78, 151, 15, 137, 100, 65, 138, 133, 153, 33, 68, 145, 186, 24, 216, 153, 41, 235, 22, 108, 50, 223, 110, 43, 26, 0, 229, 64, 244, 144, 3, 143, 102, 84, 18, 4, 75, 79, 10, 102, 36, 129 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000034"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 124, 2, 5, 56, 70, 88, 112, 222, 206, 92, 121, 225, 206, 249, 199, 118, 116, 67, 131, 117, 60, 38, 87, 161, 22, 236, 54, 203, 9, 174, 169, 109, 211, 136, 150, 3, 44, 237, 36, 55, 238, 45, 255, 35, 244, 14, 74, 165, 93, 100, 42, 127, 14, 249, 146, 193, 92, 29, 227, 76, 178, 131, 26, 138 }, new byte[] { 18, 170, 192, 171, 86, 158, 207, 38, 115, 190, 202, 49, 29, 124, 25, 70, 24, 233, 243, 189, 152, 126, 225, 131, 254, 114, 235, 63, 82, 51, 160, 97, 160, 219, 23, 238, 68, 200, 165, 203, 198, 11, 30, 133, 176, 93, 66, 0, 103, 226, 59, 145, 101, 162, 214, 48, 188, 98, 224, 153, 160, 237, 222, 3, 194, 8, 40, 39, 251, 190, 92, 249, 213, 151, 20, 58, 57, 151, 71, 176, 130, 82, 38, 245, 248, 170, 78, 151, 15, 137, 100, 65, 138, 133, 153, 33, 68, 145, 186, 24, 216, 153, 41, 235, 22, 108, 50, 223, 110, 43, 26, 0, 229, 64, 244, 144, 3, 143, 102, 84, 18, 4, 75, 79, 10, 102, 36, 129 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000035"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 124, 2, 5, 56, 70, 88, 112, 222, 206, 92, 121, 225, 206, 249, 199, 118, 116, 67, 131, 117, 60, 38, 87, 161, 22, 236, 54, 203, 9, 174, 169, 109, 211, 136, 150, 3, 44, 237, 36, 55, 238, 45, 255, 35, 244, 14, 74, 165, 93, 100, 42, 127, 14, 249, 146, 193, 92, 29, 227, 76, 178, 131, 26, 138 }, new byte[] { 18, 170, 192, 171, 86, 158, 207, 38, 115, 190, 202, 49, 29, 124, 25, 70, 24, 233, 243, 189, 152, 126, 225, 131, 254, 114, 235, 63, 82, 51, 160, 97, 160, 219, 23, 238, 68, 200, 165, 203, 198, 11, 30, 133, 176, 93, 66, 0, 103, 226, 59, 145, 101, 162, 214, 48, 188, 98, 224, 153, 160, 237, 222, 3, 194, 8, 40, 39, 251, 190, 92, 249, 213, 151, 20, 58, 57, 151, 71, 176, 130, 82, 38, 245, 248, 170, 78, 151, 15, 137, 100, 65, 138, 133, 153, 33, 68, 145, 186, 24, 216, 153, 41, 235, 22, 108, 50, 223, 110, 43, 26, 0, 229, 64, 244, 144, 3, 143, 102, 84, 18, 4, 75, 79, 10, 102, 36, 129 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000036"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 124, 2, 5, 56, 70, 88, 112, 222, 206, 92, 121, 225, 206, 249, 199, 118, 116, 67, 131, 117, 60, 38, 87, 161, 22, 236, 54, 203, 9, 174, 169, 109, 211, 136, 150, 3, 44, 237, 36, 55, 238, 45, 255, 35, 244, 14, 74, 165, 93, 100, 42, 127, 14, 249, 146, 193, 92, 29, 227, 76, 178, 131, 26, 138 }, new byte[] { 18, 170, 192, 171, 86, 158, 207, 38, 115, 190, 202, 49, 29, 124, 25, 70, 24, 233, 243, 189, 152, 126, 225, 131, 254, 114, 235, 63, 82, 51, 160, 97, 160, 219, 23, 238, 68, 200, 165, 203, 198, 11, 30, 133, 176, 93, 66, 0, 103, 226, 59, 145, 101, 162, 214, 48, 188, 98, 224, 153, 160, 237, 222, 3, 194, 8, 40, 39, 251, 190, 92, 249, 213, 151, 20, 58, 57, 151, 71, 176, 130, 82, 38, 245, 248, 170, 78, 151, 15, 137, 100, 65, 138, 133, 153, 33, 68, 145, 186, 24, 216, 153, 41, 235, 22, 108, 50, 223, 110, 43, 26, 0, 229, 64, 244, 144, 3, 143, 102, 84, 18, 4, 75, 79, 10, 102, 36, 129 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000037"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 124, 2, 5, 56, 70, 88, 112, 222, 206, 92, 121, 225, 206, 249, 199, 118, 116, 67, 131, 117, 60, 38, 87, 161, 22, 236, 54, 203, 9, 174, 169, 109, 211, 136, 150, 3, 44, 237, 36, 55, 238, 45, 255, 35, 244, 14, 74, 165, 93, 100, 42, 127, 14, 249, 146, 193, 92, 29, 227, 76, 178, 131, 26, 138 }, new byte[] { 18, 170, 192, 171, 86, 158, 207, 38, 115, 190, 202, 49, 29, 124, 25, 70, 24, 233, 243, 189, 152, 126, 225, 131, 254, 114, 235, 63, 82, 51, 160, 97, 160, 219, 23, 238, 68, 200, 165, 203, 198, 11, 30, 133, 176, 93, 66, 0, 103, 226, 59, 145, 101, 162, 214, 48, 188, 98, 224, 153, 160, 237, 222, 3, 194, 8, 40, 39, 251, 190, 92, 249, 213, 151, 20, 58, 57, 151, 71, 176, 130, 82, 38, 245, 248, 170, 78, 151, 15, 137, 100, 65, 138, 133, 153, 33, 68, 145, 186, 24, 216, 153, 41, 235, 22, 108, 50, 223, 110, 43, 26, 0, 229, 64, 244, 144, 3, 143, 102, 84, 18, 4, 75, 79, 10, 102, 36, 129 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000038"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 124, 2, 5, 56, 70, 88, 112, 222, 206, 92, 121, 225, 206, 249, 199, 118, 116, 67, 131, 117, 60, 38, 87, 161, 22, 236, 54, 203, 9, 174, 169, 109, 211, 136, 150, 3, 44, 237, 36, 55, 238, 45, 255, 35, 244, 14, 74, 165, 93, 100, 42, 127, 14, 249, 146, 193, 92, 29, 227, 76, 178, 131, 26, 138 }, new byte[] { 18, 170, 192, 171, 86, 158, 207, 38, 115, 190, 202, 49, 29, 124, 25, 70, 24, 233, 243, 189, 152, 126, 225, 131, 254, 114, 235, 63, 82, 51, 160, 97, 160, 219, 23, 238, 68, 200, 165, 203, 198, 11, 30, 133, 176, 93, 66, 0, 103, 226, 59, 145, 101, 162, 214, 48, 188, 98, 224, 153, 160, 237, 222, 3, 194, 8, 40, 39, 251, 190, 92, 249, 213, 151, 20, 58, 57, 151, 71, 176, 130, 82, 38, 245, 248, 170, 78, 151, 15, 137, 100, 65, 138, 133, 153, 33, 68, 145, 186, 24, 216, 153, 41, 235, 22, 108, 50, 223, 110, 43, 26, 0, 229, 64, 244, 144, 3, 143, 102, 84, 18, 4, 75, 79, 10, 102, 36, 129 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000039"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 124, 2, 5, 56, 70, 88, 112, 222, 206, 92, 121, 225, 206, 249, 199, 118, 116, 67, 131, 117, 60, 38, 87, 161, 22, 236, 54, 203, 9, 174, 169, 109, 211, 136, 150, 3, 44, 237, 36, 55, 238, 45, 255, 35, 244, 14, 74, 165, 93, 100, 42, 127, 14, 249, 146, 193, 92, 29, 227, 76, 178, 131, 26, 138 }, new byte[] { 18, 170, 192, 171, 86, 158, 207, 38, 115, 190, 202, 49, 29, 124, 25, 70, 24, 233, 243, 189, 152, 126, 225, 131, 254, 114, 235, 63, 82, 51, 160, 97, 160, 219, 23, 238, 68, 200, 165, 203, 198, 11, 30, 133, 176, 93, 66, 0, 103, 226, 59, 145, 101, 162, 214, 48, 188, 98, 224, 153, 160, 237, 222, 3, 194, 8, 40, 39, 251, 190, 92, 249, 213, 151, 20, 58, 57, 151, 71, 176, 130, 82, 38, 245, 248, 170, 78, 151, 15, 137, 100, 65, 138, 133, 153, 33, 68, 145, 186, 24, 216, 153, 41, 235, 22, 108, 50, 223, 110, 43, 26, 0, 229, 64, 244, 144, 3, 143, 102, 84, 18, 4, 75, 79, 10, 102, 36, 129 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000040"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 124, 2, 5, 56, 70, 88, 112, 222, 206, 92, 121, 225, 206, 249, 199, 118, 116, 67, 131, 117, 60, 38, 87, 161, 22, 236, 54, 203, 9, 174, 169, 109, 211, 136, 150, 3, 44, 237, 36, 55, 238, 45, 255, 35, 244, 14, 74, 165, 93, 100, 42, 127, 14, 249, 146, 193, 92, 29, 227, 76, 178, 131, 26, 138 }, new byte[] { 18, 170, 192, 171, 86, 158, 207, 38, 115, 190, 202, 49, 29, 124, 25, 70, 24, 233, 243, 189, 152, 126, 225, 131, 254, 114, 235, 63, 82, 51, 160, 97, 160, 219, 23, 238, 68, 200, 165, 203, 198, 11, 30, 133, 176, 93, 66, 0, 103, 226, 59, 145, 101, 162, 214, 48, 188, 98, 224, 153, 160, 237, 222, 3, 194, 8, 40, 39, 251, 190, 92, 249, 213, 151, 20, 58, 57, 151, 71, 176, 130, 82, 38, 245, 248, 170, 78, 151, 15, 137, 100, 65, 138, 133, 153, 33, 68, 145, 186, 24, 216, 153, 41, 235, 22, 108, 50, 223, 110, 43, 26, 0, 229, 64, 244, 144, 3, 143, 102, 84, 18, 4, 75, 79, 10, 102, 36, 129 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000041"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 124, 2, 5, 56, 70, 88, 112, 222, 206, 92, 121, 225, 206, 249, 199, 118, 116, 67, 131, 117, 60, 38, 87, 161, 22, 236, 54, 203, 9, 174, 169, 109, 211, 136, 150, 3, 44, 237, 36, 55, 238, 45, 255, 35, 244, 14, 74, 165, 93, 100, 42, 127, 14, 249, 146, 193, 92, 29, 227, 76, 178, 131, 26, 138 }, new byte[] { 18, 170, 192, 171, 86, 158, 207, 38, 115, 190, 202, 49, 29, 124, 25, 70, 24, 233, 243, 189, 152, 126, 225, 131, 254, 114, 235, 63, 82, 51, 160, 97, 160, 219, 23, 238, 68, 200, 165, 203, 198, 11, 30, 133, 176, 93, 66, 0, 103, 226, 59, 145, 101, 162, 214, 48, 188, 98, 224, 153, 160, 237, 222, 3, 194, 8, 40, 39, 251, 190, 92, 249, 213, 151, 20, 58, 57, 151, 71, 176, 130, 82, 38, 245, 248, 170, 78, 151, 15, 137, 100, 65, 138, 133, 153, 33, 68, 145, 186, 24, 216, 153, 41, 235, 22, 108, 50, 223, 110, 43, 26, 0, 229, 64, 244, 144, 3, 143, 102, 84, 18, 4, 75, 79, 10, 102, 36, 129 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000042"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 124, 2, 5, 56, 70, 88, 112, 222, 206, 92, 121, 225, 206, 249, 199, 118, 116, 67, 131, 117, 60, 38, 87, 161, 22, 236, 54, 203, 9, 174, 169, 109, 211, 136, 150, 3, 44, 237, 36, 55, 238, 45, 255, 35, 244, 14, 74, 165, 93, 100, 42, 127, 14, 249, 146, 193, 92, 29, 227, 76, 178, 131, 26, 138 }, new byte[] { 18, 170, 192, 171, 86, 158, 207, 38, 115, 190, 202, 49, 29, 124, 25, 70, 24, 233, 243, 189, 152, 126, 225, 131, 254, 114, 235, 63, 82, 51, 160, 97, 160, 219, 23, 238, 68, 200, 165, 203, 198, 11, 30, 133, 176, 93, 66, 0, 103, 226, 59, 145, 101, 162, 214, 48, 188, 98, 224, 153, 160, 237, 222, 3, 194, 8, 40, 39, 251, 190, 92, 249, 213, 151, 20, 58, 57, 151, 71, 176, 130, 82, 38, 245, 248, 170, 78, 151, 15, 137, 100, 65, 138, 133, 153, 33, 68, 145, 186, 24, 216, 153, 41, 235, 22, 108, 50, 223, 110, 43, 26, 0, 229, 64, 244, 144, 3, 143, 102, 84, 18, 4, 75, 79, 10, 102, 36, 129 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000043"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 124, 2, 5, 56, 70, 88, 112, 222, 206, 92, 121, 225, 206, 249, 199, 118, 116, 67, 131, 117, 60, 38, 87, 161, 22, 236, 54, 203, 9, 174, 169, 109, 211, 136, 150, 3, 44, 237, 36, 55, 238, 45, 255, 35, 244, 14, 74, 165, 93, 100, 42, 127, 14, 249, 146, 193, 92, 29, 227, 76, 178, 131, 26, 138 }, new byte[] { 18, 170, 192, 171, 86, 158, 207, 38, 115, 190, 202, 49, 29, 124, 25, 70, 24, 233, 243, 189, 152, 126, 225, 131, 254, 114, 235, 63, 82, 51, 160, 97, 160, 219, 23, 238, 68, 200, 165, 203, 198, 11, 30, 133, 176, 93, 66, 0, 103, 226, 59, 145, 101, 162, 214, 48, 188, 98, 224, 153, 160, 237, 222, 3, 194, 8, 40, 39, 251, 190, 92, 249, 213, 151, 20, 58, 57, 151, 71, 176, 130, 82, 38, 245, 248, 170, 78, 151, 15, 137, 100, 65, 138, 133, 153, 33, 68, 145, 186, 24, 216, 153, 41, 235, 22, 108, 50, 223, 110, 43, 26, 0, 229, 64, 244, 144, 3, 143, 102, 84, 18, 4, 75, 79, 10, 102, 36, 129 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000044"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 124, 2, 5, 56, 70, 88, 112, 222, 206, 92, 121, 225, 206, 249, 199, 118, 116, 67, 131, 117, 60, 38, 87, 161, 22, 236, 54, 203, 9, 174, 169, 109, 211, 136, 150, 3, 44, 237, 36, 55, 238, 45, 255, 35, 244, 14, 74, 165, 93, 100, 42, 127, 14, 249, 146, 193, 92, 29, 227, 76, 178, 131, 26, 138 }, new byte[] { 18, 170, 192, 171, 86, 158, 207, 38, 115, 190, 202, 49, 29, 124, 25, 70, 24, 233, 243, 189, 152, 126, 225, 131, 254, 114, 235, 63, 82, 51, 160, 97, 160, 219, 23, 238, 68, 200, 165, 203, 198, 11, 30, 133, 176, 93, 66, 0, 103, 226, 59, 145, 101, 162, 214, 48, 188, 98, 224, 153, 160, 237, 222, 3, 194, 8, 40, 39, 251, 190, 92, 249, 213, 151, 20, 58, 57, 151, 71, 176, 130, 82, 38, 245, 248, 170, 78, 151, 15, 137, 100, 65, 138, 133, 153, 33, 68, 145, 186, 24, 216, 153, 41, 235, 22, 108, 50, 223, 110, 43, 26, 0, 229, 64, 244, 144, 3, 143, 102, 84, 18, 4, 75, 79, 10, 102, 36, 129 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000045"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 124, 2, 5, 56, 70, 88, 112, 222, 206, 92, 121, 225, 206, 249, 199, 118, 116, 67, 131, 117, 60, 38, 87, 161, 22, 236, 54, 203, 9, 174, 169, 109, 211, 136, 150, 3, 44, 237, 36, 55, 238, 45, 255, 35, 244, 14, 74, 165, 93, 100, 42, 127, 14, 249, 146, 193, 92, 29, 227, 76, 178, 131, 26, 138 }, new byte[] { 18, 170, 192, 171, 86, 158, 207, 38, 115, 190, 202, 49, 29, 124, 25, 70, 24, 233, 243, 189, 152, 126, 225, 131, 254, 114, 235, 63, 82, 51, 160, 97, 160, 219, 23, 238, 68, 200, 165, 203, 198, 11, 30, 133, 176, 93, 66, 0, 103, 226, 59, 145, 101, 162, 214, 48, 188, 98, 224, 153, 160, 237, 222, 3, 194, 8, 40, 39, 251, 190, 92, 249, 213, 151, 20, 58, 57, 151, 71, 176, 130, 82, 38, 245, 248, 170, 78, 151, 15, 137, 100, 65, 138, 133, 153, 33, 68, 145, 186, 24, 216, 153, 41, 235, 22, 108, 50, 223, 110, 43, 26, 0, 229, 64, 244, 144, 3, 143, 102, 84, 18, 4, 75, 79, 10, 102, 36, 129 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000046"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 124, 2, 5, 56, 70, 88, 112, 222, 206, 92, 121, 225, 206, 249, 199, 118, 116, 67, 131, 117, 60, 38, 87, 161, 22, 236, 54, 203, 9, 174, 169, 109, 211, 136, 150, 3, 44, 237, 36, 55, 238, 45, 255, 35, 244, 14, 74, 165, 93, 100, 42, 127, 14, 249, 146, 193, 92, 29, 227, 76, 178, 131, 26, 138 }, new byte[] { 18, 170, 192, 171, 86, 158, 207, 38, 115, 190, 202, 49, 29, 124, 25, 70, 24, 233, 243, 189, 152, 126, 225, 131, 254, 114, 235, 63, 82, 51, 160, 97, 160, 219, 23, 238, 68, 200, 165, 203, 198, 11, 30, 133, 176, 93, 66, 0, 103, 226, 59, 145, 101, 162, 214, 48, 188, 98, 224, 153, 160, 237, 222, 3, 194, 8, 40, 39, 251, 190, 92, 249, 213, 151, 20, 58, 57, 151, 71, 176, 130, 82, 38, 245, 248, 170, 78, 151, 15, 137, 100, 65, 138, 133, 153, 33, 68, 145, 186, 24, 216, 153, 41, 235, 22, 108, 50, 223, 110, 43, 26, 0, 229, 64, 244, 144, 3, 143, 102, 84, 18, 4, 75, 79, 10, 102, 36, 129 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000047"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 124, 2, 5, 56, 70, 88, 112, 222, 206, 92, 121, 225, 206, 249, 199, 118, 116, 67, 131, 117, 60, 38, 87, 161, 22, 236, 54, 203, 9, 174, 169, 109, 211, 136, 150, 3, 44, 237, 36, 55, 238, 45, 255, 35, 244, 14, 74, 165, 93, 100, 42, 127, 14, 249, 146, 193, 92, 29, 227, 76, 178, 131, 26, 138 }, new byte[] { 18, 170, 192, 171, 86, 158, 207, 38, 115, 190, 202, 49, 29, 124, 25, 70, 24, 233, 243, 189, 152, 126, 225, 131, 254, 114, 235, 63, 82, 51, 160, 97, 160, 219, 23, 238, 68, 200, 165, 203, 198, 11, 30, 133, 176, 93, 66, 0, 103, 226, 59, 145, 101, 162, 214, 48, 188, 98, 224, 153, 160, 237, 222, 3, 194, 8, 40, 39, 251, 190, 92, 249, 213, 151, 20, 58, 57, 151, 71, 176, 130, 82, 38, 245, 248, 170, 78, 151, 15, 137, 100, 65, 138, 133, 153, 33, 68, 145, 186, 24, 216, 153, 41, 235, 22, 108, 50, 223, 110, 43, 26, 0, 229, 64, 244, 144, 3, 143, 102, 84, 18, 4, 75, 79, 10, 102, 36, 129 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000048"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 124, 2, 5, 56, 70, 88, 112, 222, 206, 92, 121, 225, 206, 249, 199, 118, 116, 67, 131, 117, 60, 38, 87, 161, 22, 236, 54, 203, 9, 174, 169, 109, 211, 136, 150, 3, 44, 237, 36, 55, 238, 45, 255, 35, 244, 14, 74, 165, 93, 100, 42, 127, 14, 249, 146, 193, 92, 29, 227, 76, 178, 131, 26, 138 }, new byte[] { 18, 170, 192, 171, 86, 158, 207, 38, 115, 190, 202, 49, 29, 124, 25, 70, 24, 233, 243, 189, 152, 126, 225, 131, 254, 114, 235, 63, 82, 51, 160, 97, 160, 219, 23, 238, 68, 200, 165, 203, 198, 11, 30, 133, 176, 93, 66, 0, 103, 226, 59, 145, 101, 162, 214, 48, 188, 98, 224, 153, 160, 237, 222, 3, 194, 8, 40, 39, 251, 190, 92, 249, 213, 151, 20, 58, 57, 151, 71, 176, 130, 82, 38, 245, 248, 170, 78, 151, 15, 137, 100, 65, 138, 133, 153, 33, 68, 145, 186, 24, 216, 153, 41, 235, 22, 108, 50, 223, 110, 43, 26, 0, 229, 64, 244, 144, 3, 143, 102, 84, 18, 4, 75, 79, 10, 102, 36, 129 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000049"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 124, 2, 5, 56, 70, 88, 112, 222, 206, 92, 121, 225, 206, 249, 199, 118, 116, 67, 131, 117, 60, 38, 87, 161, 22, 236, 54, 203, 9, 174, 169, 109, 211, 136, 150, 3, 44, 237, 36, 55, 238, 45, 255, 35, 244, 14, 74, 165, 93, 100, 42, 127, 14, 249, 146, 193, 92, 29, 227, 76, 178, 131, 26, 138 }, new byte[] { 18, 170, 192, 171, 86, 158, 207, 38, 115, 190, 202, 49, 29, 124, 25, 70, 24, 233, 243, 189, 152, 126, 225, 131, 254, 114, 235, 63, 82, 51, 160, 97, 160, 219, 23, 238, 68, 200, 165, 203, 198, 11, 30, 133, 176, 93, 66, 0, 103, 226, 59, 145, 101, 162, 214, 48, 188, 98, 224, 153, 160, 237, 222, 3, 194, 8, 40, 39, 251, 190, 92, 249, 213, 151, 20, 58, 57, 151, 71, 176, 130, 82, 38, 245, 248, 170, 78, 151, 15, 137, 100, 65, 138, 133, 153, 33, 68, 145, 186, 24, 216, 153, 41, 235, 22, 108, 50, 223, 110, 43, 26, 0, 229, 64, 244, 144, 3, 143, 102, 84, 18, 4, 75, 79, 10, 102, 36, 129 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000050"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 124, 2, 5, 56, 70, 88, 112, 222, 206, 92, 121, 225, 206, 249, 199, 118, 116, 67, 131, 117, 60, 38, 87, 161, 22, 236, 54, 203, 9, 174, 169, 109, 211, 136, 150, 3, 44, 237, 36, 55, 238, 45, 255, 35, 244, 14, 74, 165, 93, 100, 42, 127, 14, 249, 146, 193, 92, 29, 227, 76, 178, 131, 26, 138 }, new byte[] { 18, 170, 192, 171, 86, 158, 207, 38, 115, 190, 202, 49, 29, 124, 25, 70, 24, 233, 243, 189, 152, 126, 225, 131, 254, 114, 235, 63, 82, 51, 160, 97, 160, 219, 23, 238, 68, 200, 165, 203, 198, 11, 30, 133, 176, 93, 66, 0, 103, 226, 59, 145, 101, 162, 214, 48, 188, 98, 224, 153, 160, 237, 222, 3, 194, 8, 40, 39, 251, 190, 92, 249, 213, 151, 20, 58, 57, 151, 71, 176, 130, 82, 38, 245, 248, 170, 78, 151, 15, 137, 100, 65, 138, 133, 153, 33, 68, 145, 186, 24, 216, 153, 41, 235, 22, 108, 50, 223, 110, 43, 26, 0, 229, 64, 244, 144, 3, 143, 102, 84, 18, 4, 75, 79, 10, 102, 36, 129 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000051"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 124, 2, 5, 56, 70, 88, 112, 222, 206, 92, 121, 225, 206, 249, 199, 118, 116, 67, 131, 117, 60, 38, 87, 161, 22, 236, 54, 203, 9, 174, 169, 109, 211, 136, 150, 3, 44, 237, 36, 55, 238, 45, 255, 35, 244, 14, 74, 165, 93, 100, 42, 127, 14, 249, 146, 193, 92, 29, 227, 76, 178, 131, 26, 138 }, new byte[] { 18, 170, 192, 171, 86, 158, 207, 38, 115, 190, 202, 49, 29, 124, 25, 70, 24, 233, 243, 189, 152, 126, 225, 131, 254, 114, 235, 63, 82, 51, 160, 97, 160, 219, 23, 238, 68, 200, 165, 203, 198, 11, 30, 133, 176, 93, 66, 0, 103, 226, 59, 145, 101, 162, 214, 48, 188, 98, 224, 153, 160, 237, 222, 3, 194, 8, 40, 39, 251, 190, 92, 249, 213, 151, 20, 58, 57, 151, 71, 176, 130, 82, 38, 245, 248, 170, 78, 151, 15, 137, 100, 65, 138, 133, 153, 33, 68, 145, 186, 24, 216, 153, 41, 235, 22, 108, 50, 223, 110, 43, 26, 0, 229, 64, 244, 144, 3, 143, 102, 84, 18, 4, 75, 79, 10, 102, 36, 129 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000052"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 124, 2, 5, 56, 70, 88, 112, 222, 206, 92, 121, 225, 206, 249, 199, 118, 116, 67, 131, 117, 60, 38, 87, 161, 22, 236, 54, 203, 9, 174, 169, 109, 211, 136, 150, 3, 44, 237, 36, 55, 238, 45, 255, 35, 244, 14, 74, 165, 93, 100, 42, 127, 14, 249, 146, 193, 92, 29, 227, 76, 178, 131, 26, 138 }, new byte[] { 18, 170, 192, 171, 86, 158, 207, 38, 115, 190, 202, 49, 29, 124, 25, 70, 24, 233, 243, 189, 152, 126, 225, 131, 254, 114, 235, 63, 82, 51, 160, 97, 160, 219, 23, 238, 68, 200, 165, 203, 198, 11, 30, 133, 176, 93, 66, 0, 103, 226, 59, 145, 101, 162, 214, 48, 188, 98, 224, 153, 160, 237, 222, 3, 194, 8, 40, 39, 251, 190, 92, 249, 213, 151, 20, 58, 57, 151, 71, 176, 130, 82, 38, 245, 248, 170, 78, 151, 15, 137, 100, 65, 138, 133, 153, 33, 68, 145, 186, 24, 216, 153, 41, 235, 22, 108, 50, 223, 110, 43, 26, 0, 229, 64, 244, 144, 3, 143, 102, 84, 18, 4, 75, 79, 10, 102, 36, 129 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000053"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 124, 2, 5, 56, 70, 88, 112, 222, 206, 92, 121, 225, 206, 249, 199, 118, 116, 67, 131, 117, 60, 38, 87, 161, 22, 236, 54, 203, 9, 174, 169, 109, 211, 136, 150, 3, 44, 237, 36, 55, 238, 45, 255, 35, 244, 14, 74, 165, 93, 100, 42, 127, 14, 249, 146, 193, 92, 29, 227, 76, 178, 131, 26, 138 }, new byte[] { 18, 170, 192, 171, 86, 158, 207, 38, 115, 190, 202, 49, 29, 124, 25, 70, 24, 233, 243, 189, 152, 126, 225, 131, 254, 114, 235, 63, 82, 51, 160, 97, 160, 219, 23, 238, 68, 200, 165, 203, 198, 11, 30, 133, 176, 93, 66, 0, 103, 226, 59, 145, 101, 162, 214, 48, 188, 98, 224, 153, 160, 237, 222, 3, 194, 8, 40, 39, 251, 190, 92, 249, 213, 151, 20, 58, 57, 151, 71, 176, 130, 82, 38, 245, 248, 170, 78, 151, 15, 137, 100, 65, 138, 133, 153, 33, 68, 145, 186, 24, 216, 153, 41, 235, 22, 108, 50, 223, 110, 43, 26, 0, 229, 64, 244, 144, 3, 143, 102, 84, 18, 4, 75, 79, 10, 102, 36, 129 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000054"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 124, 2, 5, 56, 70, 88, 112, 222, 206, 92, 121, 225, 206, 249, 199, 118, 116, 67, 131, 117, 60, 38, 87, 161, 22, 236, 54, 203, 9, 174, 169, 109, 211, 136, 150, 3, 44, 237, 36, 55, 238, 45, 255, 35, 244, 14, 74, 165, 93, 100, 42, 127, 14, 249, 146, 193, 92, 29, 227, 76, 178, 131, 26, 138 }, new byte[] { 18, 170, 192, 171, 86, 158, 207, 38, 115, 190, 202, 49, 29, 124, 25, 70, 24, 233, 243, 189, 152, 126, 225, 131, 254, 114, 235, 63, 82, 51, 160, 97, 160, 219, 23, 238, 68, 200, 165, 203, 198, 11, 30, 133, 176, 93, 66, 0, 103, 226, 59, 145, 101, 162, 214, 48, 188, 98, 224, 153, 160, 237, 222, 3, 194, 8, 40, 39, 251, 190, 92, 249, 213, 151, 20, 58, 57, 151, 71, 176, 130, 82, 38, 245, 248, 170, 78, 151, 15, 137, 100, 65, 138, 133, 153, 33, 68, 145, 186, 24, 216, 153, 41, 235, 22, 108, 50, 223, 110, 43, 26, 0, 229, 64, 244, 144, 3, 143, 102, 84, 18, 4, 75, 79, 10, 102, 36, 129 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000055"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 124, 2, 5, 56, 70, 88, 112, 222, 206, 92, 121, 225, 206, 249, 199, 118, 116, 67, 131, 117, 60, 38, 87, 161, 22, 236, 54, 203, 9, 174, 169, 109, 211, 136, 150, 3, 44, 237, 36, 55, 238, 45, 255, 35, 244, 14, 74, 165, 93, 100, 42, 127, 14, 249, 146, 193, 92, 29, 227, 76, 178, 131, 26, 138 }, new byte[] { 18, 170, 192, 171, 86, 158, 207, 38, 115, 190, 202, 49, 29, 124, 25, 70, 24, 233, 243, 189, 152, 126, 225, 131, 254, 114, 235, 63, 82, 51, 160, 97, 160, 219, 23, 238, 68, 200, 165, 203, 198, 11, 30, 133, 176, 93, 66, 0, 103, 226, 59, 145, 101, 162, 214, 48, 188, 98, 224, 153, 160, 237, 222, 3, 194, 8, 40, 39, 251, 190, 92, 249, 213, 151, 20, 58, 57, 151, 71, 176, 130, 82, 38, 245, 248, 170, 78, 151, 15, 137, 100, 65, 138, 133, 153, 33, 68, 145, 186, 24, 216, 153, 41, 235, 22, 108, 50, 223, 110, 43, 26, 0, 229, 64, 244, 144, 3, 143, 102, 84, 18, 4, 75, 79, 10, 102, 36, 129 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000056"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 124, 2, 5, 56, 70, 88, 112, 222, 206, 92, 121, 225, 206, 249, 199, 118, 116, 67, 131, 117, 60, 38, 87, 161, 22, 236, 54, 203, 9, 174, 169, 109, 211, 136, 150, 3, 44, 237, 36, 55, 238, 45, 255, 35, 244, 14, 74, 165, 93, 100, 42, 127, 14, 249, 146, 193, 92, 29, 227, 76, 178, 131, 26, 138 }, new byte[] { 18, 170, 192, 171, 86, 158, 207, 38, 115, 190, 202, 49, 29, 124, 25, 70, 24, 233, 243, 189, 152, 126, 225, 131, 254, 114, 235, 63, 82, 51, 160, 97, 160, 219, 23, 238, 68, 200, 165, 203, 198, 11, 30, 133, 176, 93, 66, 0, 103, 226, 59, 145, 101, 162, 214, 48, 188, 98, 224, 153, 160, 237, 222, 3, 194, 8, 40, 39, 251, 190, 92, 249, 213, 151, 20, 58, 57, 151, 71, 176, 130, 82, 38, 245, 248, 170, 78, 151, 15, 137, 100, 65, 138, 133, 153, 33, 68, 145, 186, 24, 216, 153, 41, 235, 22, 108, 50, 223, 110, 43, 26, 0, 229, 64, 244, 144, 3, 143, 102, 84, 18, 4, 75, 79, 10, 102, 36, 129 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000057"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 124, 2, 5, 56, 70, 88, 112, 222, 206, 92, 121, 225, 206, 249, 199, 118, 116, 67, 131, 117, 60, 38, 87, 161, 22, 236, 54, 203, 9, 174, 169, 109, 211, 136, 150, 3, 44, 237, 36, 55, 238, 45, 255, 35, 244, 14, 74, 165, 93, 100, 42, 127, 14, 249, 146, 193, 92, 29, 227, 76, 178, 131, 26, 138 }, new byte[] { 18, 170, 192, 171, 86, 158, 207, 38, 115, 190, 202, 49, 29, 124, 25, 70, 24, 233, 243, 189, 152, 126, 225, 131, 254, 114, 235, 63, 82, 51, 160, 97, 160, 219, 23, 238, 68, 200, 165, 203, 198, 11, 30, 133, 176, 93, 66, 0, 103, 226, 59, 145, 101, 162, 214, 48, 188, 98, 224, 153, 160, 237, 222, 3, 194, 8, 40, 39, 251, 190, 92, 249, 213, 151, 20, 58, 57, 151, 71, 176, 130, 82, 38, 245, 248, 170, 78, 151, 15, 137, 100, 65, 138, 133, 153, 33, 68, 145, 186, 24, 216, 153, 41, 235, 22, 108, 50, 223, 110, 43, 26, 0, 229, 64, 244, 144, 3, 143, 102, 84, 18, 4, 75, 79, 10, 102, 36, 129 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000058"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 124, 2, 5, 56, 70, 88, 112, 222, 206, 92, 121, 225, 206, 249, 199, 118, 116, 67, 131, 117, 60, 38, 87, 161, 22, 236, 54, 203, 9, 174, 169, 109, 211, 136, 150, 3, 44, 237, 36, 55, 238, 45, 255, 35, 244, 14, 74, 165, 93, 100, 42, 127, 14, 249, 146, 193, 92, 29, 227, 76, 178, 131, 26, 138 }, new byte[] { 18, 170, 192, 171, 86, 158, 207, 38, 115, 190, 202, 49, 29, 124, 25, 70, 24, 233, 243, 189, 152, 126, 225, 131, 254, 114, 235, 63, 82, 51, 160, 97, 160, 219, 23, 238, 68, 200, 165, 203, 198, 11, 30, 133, 176, 93, 66, 0, 103, 226, 59, 145, 101, 162, 214, 48, 188, 98, 224, 153, 160, 237, 222, 3, 194, 8, 40, 39, 251, 190, 92, 249, 213, 151, 20, 58, 57, 151, 71, 176, 130, 82, 38, 245, 248, 170, 78, 151, 15, 137, 100, 65, 138, 133, 153, 33, 68, 145, 186, 24, 216, 153, 41, 235, 22, 108, 50, 223, 110, 43, 26, 0, 229, 64, 244, 144, 3, 143, 102, 84, 18, 4, 75, 79, 10, 102, 36, 129 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000059"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 124, 2, 5, 56, 70, 88, 112, 222, 206, 92, 121, 225, 206, 249, 199, 118, 116, 67, 131, 117, 60, 38, 87, 161, 22, 236, 54, 203, 9, 174, 169, 109, 211, 136, 150, 3, 44, 237, 36, 55, 238, 45, 255, 35, 244, 14, 74, 165, 93, 100, 42, 127, 14, 249, 146, 193, 92, 29, 227, 76, 178, 131, 26, 138 }, new byte[] { 18, 170, 192, 171, 86, 158, 207, 38, 115, 190, 202, 49, 29, 124, 25, 70, 24, 233, 243, 189, 152, 126, 225, 131, 254, 114, 235, 63, 82, 51, 160, 97, 160, 219, 23, 238, 68, 200, 165, 203, 198, 11, 30, 133, 176, 93, 66, 0, 103, 226, 59, 145, 101, 162, 214, 48, 188, 98, 224, 153, 160, 237, 222, 3, 194, 8, 40, 39, 251, 190, 92, 249, 213, 151, 20, 58, 57, 151, 71, 176, 130, 82, 38, 245, 248, 170, 78, 151, 15, 137, 100, 65, 138, 133, 153, 33, 68, 145, 186, 24, 216, 153, 41, 235, 22, 108, 50, 223, 110, 43, 26, 0, 229, 64, 244, 144, 3, 143, 102, 84, 18, 4, 75, 79, 10, 102, 36, 129 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000060"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 124, 2, 5, 56, 70, 88, 112, 222, 206, 92, 121, 225, 206, 249, 199, 118, 116, 67, 131, 117, 60, 38, 87, 161, 22, 236, 54, 203, 9, 174, 169, 109, 211, 136, 150, 3, 44, 237, 36, 55, 238, 45, 255, 35, 244, 14, 74, 165, 93, 100, 42, 127, 14, 249, 146, 193, 92, 29, 227, 76, 178, 131, 26, 138 }, new byte[] { 18, 170, 192, 171, 86, 158, 207, 38, 115, 190, 202, 49, 29, 124, 25, 70, 24, 233, 243, 189, 152, 126, 225, 131, 254, 114, 235, 63, 82, 51, 160, 97, 160, 219, 23, 238, 68, 200, 165, 203, 198, 11, 30, 133, 176, 93, 66, 0, 103, 226, 59, 145, 101, 162, 214, 48, 188, 98, 224, 153, 160, 237, 222, 3, 194, 8, 40, 39, 251, 190, 92, 249, 213, 151, 20, 58, 57, 151, 71, 176, 130, 82, 38, 245, 248, 170, 78, 151, 15, 137, 100, 65, 138, 133, 153, 33, 68, 145, 186, 24, 216, 153, 41, 235, 22, 108, 50, 223, 110, 43, 26, 0, 229, 64, 244, 144, 3, 143, 102, 84, 18, 4, 75, 79, 10, 102, 36, 129 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000061"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 124, 2, 5, 56, 70, 88, 112, 222, 206, 92, 121, 225, 206, 249, 199, 118, 116, 67, 131, 117, 60, 38, 87, 161, 22, 236, 54, 203, 9, 174, 169, 109, 211, 136, 150, 3, 44, 237, 36, 55, 238, 45, 255, 35, 244, 14, 74, 165, 93, 100, 42, 127, 14, 249, 146, 193, 92, 29, 227, 76, 178, 131, 26, 138 }, new byte[] { 18, 170, 192, 171, 86, 158, 207, 38, 115, 190, 202, 49, 29, 124, 25, 70, 24, 233, 243, 189, 152, 126, 225, 131, 254, 114, 235, 63, 82, 51, 160, 97, 160, 219, 23, 238, 68, 200, 165, 203, 198, 11, 30, 133, 176, 93, 66, 0, 103, 226, 59, 145, 101, 162, 214, 48, 188, 98, 224, 153, 160, 237, 222, 3, 194, 8, 40, 39, 251, 190, 92, 249, 213, 151, 20, 58, 57, 151, 71, 176, 130, 82, 38, 245, 248, 170, 78, 151, 15, 137, 100, 65, 138, 133, 153, 33, 68, 145, 186, 24, 216, 153, 41, 235, 22, 108, 50, 223, 110, 43, 26, 0, 229, 64, 244, 144, 3, 143, 102, 84, 18, 4, 75, 79, 10, 102, 36, 129 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000062"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 124, 2, 5, 56, 70, 88, 112, 222, 206, 92, 121, 225, 206, 249, 199, 118, 116, 67, 131, 117, 60, 38, 87, 161, 22, 236, 54, 203, 9, 174, 169, 109, 211, 136, 150, 3, 44, 237, 36, 55, 238, 45, 255, 35, 244, 14, 74, 165, 93, 100, 42, 127, 14, 249, 146, 193, 92, 29, 227, 76, 178, 131, 26, 138 }, new byte[] { 18, 170, 192, 171, 86, 158, 207, 38, 115, 190, 202, 49, 29, 124, 25, 70, 24, 233, 243, 189, 152, 126, 225, 131, 254, 114, 235, 63, 82, 51, 160, 97, 160, 219, 23, 238, 68, 200, 165, 203, 198, 11, 30, 133, 176, 93, 66, 0, 103, 226, 59, 145, 101, 162, 214, 48, 188, 98, 224, 153, 160, 237, 222, 3, 194, 8, 40, 39, 251, 190, 92, 249, 213, 151, 20, 58, 57, 151, 71, 176, 130, 82, 38, 245, 248, 170, 78, 151, 15, 137, 100, 65, 138, 133, 153, 33, 68, 145, 186, 24, 216, 153, 41, 235, 22, 108, 50, 223, 110, 43, 26, 0, 229, 64, 244, 144, 3, 143, 102, 84, 18, 4, 75, 79, 10, 102, 36, 129 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000063"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 124, 2, 5, 56, 70, 88, 112, 222, 206, 92, 121, 225, 206, 249, 199, 118, 116, 67, 131, 117, 60, 38, 87, 161, 22, 236, 54, 203, 9, 174, 169, 109, 211, 136, 150, 3, 44, 237, 36, 55, 238, 45, 255, 35, 244, 14, 74, 165, 93, 100, 42, 127, 14, 249, 146, 193, 92, 29, 227, 76, 178, 131, 26, 138 }, new byte[] { 18, 170, 192, 171, 86, 158, 207, 38, 115, 190, 202, 49, 29, 124, 25, 70, 24, 233, 243, 189, 152, 126, 225, 131, 254, 114, 235, 63, 82, 51, 160, 97, 160, 219, 23, 238, 68, 200, 165, 203, 198, 11, 30, 133, 176, 93, 66, 0, 103, 226, 59, 145, 101, 162, 214, 48, 188, 98, 224, 153, 160, 237, 222, 3, 194, 8, 40, 39, 251, 190, 92, 249, 213, 151, 20, 58, 57, 151, 71, 176, 130, 82, 38, 245, 248, 170, 78, 151, 15, 137, 100, 65, 138, 133, 153, 33, 68, 145, 186, 24, 216, 153, 41, 235, 22, 108, 50, 223, 110, 43, 26, 0, 229, 64, 244, 144, 3, 143, 102, 84, 18, 4, 75, 79, 10, 102, 36, 129 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000064"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 124, 2, 5, 56, 70, 88, 112, 222, 206, 92, 121, 225, 206, 249, 199, 118, 116, 67, 131, 117, 60, 38, 87, 161, 22, 236, 54, 203, 9, 174, 169, 109, 211, 136, 150, 3, 44, 237, 36, 55, 238, 45, 255, 35, 244, 14, 74, 165, 93, 100, 42, 127, 14, 249, 146, 193, 92, 29, 227, 76, 178, 131, 26, 138 }, new byte[] { 18, 170, 192, 171, 86, 158, 207, 38, 115, 190, 202, 49, 29, 124, 25, 70, 24, 233, 243, 189, 152, 126, 225, 131, 254, 114, 235, 63, 82, 51, 160, 97, 160, 219, 23, 238, 68, 200, 165, 203, 198, 11, 30, 133, 176, 93, 66, 0, 103, 226, 59, 145, 101, 162, 214, 48, 188, 98, 224, 153, 160, 237, 222, 3, 194, 8, 40, 39, 251, 190, 92, 249, 213, 151, 20, 58, 57, 151, 71, 176, 130, 82, 38, 245, 248, 170, 78, 151, 15, 137, 100, 65, 138, 133, 153, 33, 68, 145, 186, 24, 216, 153, 41, 235, 22, 108, 50, 223, 110, 43, 26, 0, 229, 64, 244, 144, 3, 143, 102, 84, 18, 4, 75, 79, 10, 102, 36, 129 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000065"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 124, 2, 5, 56, 70, 88, 112, 222, 206, 92, 121, 225, 206, 249, 199, 118, 116, 67, 131, 117, 60, 38, 87, 161, 22, 236, 54, 203, 9, 174, 169, 109, 211, 136, 150, 3, 44, 237, 36, 55, 238, 45, 255, 35, 244, 14, 74, 165, 93, 100, 42, 127, 14, 249, 146, 193, 92, 29, 227, 76, 178, 131, 26, 138 }, new byte[] { 18, 170, 192, 171, 86, 158, 207, 38, 115, 190, 202, 49, 29, 124, 25, 70, 24, 233, 243, 189, 152, 126, 225, 131, 254, 114, 235, 63, 82, 51, 160, 97, 160, 219, 23, 238, 68, 200, 165, 203, 198, 11, 30, 133, 176, 93, 66, 0, 103, 226, 59, 145, 101, 162, 214, 48, 188, 98, 224, 153, 160, 237, 222, 3, 194, 8, 40, 39, 251, 190, 92, 249, 213, 151, 20, 58, 57, 151, 71, 176, 130, 82, 38, 245, 248, 170, 78, 151, 15, 137, 100, 65, 138, 133, 153, 33, 68, 145, 186, 24, 216, 153, 41, 235, 22, 108, 50, 223, 110, 43, 26, 0, 229, 64, 244, 144, 3, 143, 102, 84, 18, 4, 75, 79, 10, 102, 36, 129 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000066"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 124, 2, 5, 56, 70, 88, 112, 222, 206, 92, 121, 225, 206, 249, 199, 118, 116, 67, 131, 117, 60, 38, 87, 161, 22, 236, 54, 203, 9, 174, 169, 109, 211, 136, 150, 3, 44, 237, 36, 55, 238, 45, 255, 35, 244, 14, 74, 165, 93, 100, 42, 127, 14, 249, 146, 193, 92, 29, 227, 76, 178, 131, 26, 138 }, new byte[] { 18, 170, 192, 171, 86, 158, 207, 38, 115, 190, 202, 49, 29, 124, 25, 70, 24, 233, 243, 189, 152, 126, 225, 131, 254, 114, 235, 63, 82, 51, 160, 97, 160, 219, 23, 238, 68, 200, 165, 203, 198, 11, 30, 133, 176, 93, 66, 0, 103, 226, 59, 145, 101, 162, 214, 48, 188, 98, 224, 153, 160, 237, 222, 3, 194, 8, 40, 39, 251, 190, 92, 249, 213, 151, 20, 58, 57, 151, 71, 176, 130, 82, 38, 245, 248, 170, 78, 151, 15, 137, 100, 65, 138, 133, 153, 33, 68, 145, 186, 24, 216, 153, 41, 235, 22, 108, 50, 223, 110, 43, 26, 0, 229, 64, 244, 144, 3, 143, 102, 84, 18, 4, 75, 79, 10, 102, 36, 129 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000067"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 124, 2, 5, 56, 70, 88, 112, 222, 206, 92, 121, 225, 206, 249, 199, 118, 116, 67, 131, 117, 60, 38, 87, 161, 22, 236, 54, 203, 9, 174, 169, 109, 211, 136, 150, 3, 44, 237, 36, 55, 238, 45, 255, 35, 244, 14, 74, 165, 93, 100, 42, 127, 14, 249, 146, 193, 92, 29, 227, 76, 178, 131, 26, 138 }, new byte[] { 18, 170, 192, 171, 86, 158, 207, 38, 115, 190, 202, 49, 29, 124, 25, 70, 24, 233, 243, 189, 152, 126, 225, 131, 254, 114, 235, 63, 82, 51, 160, 97, 160, 219, 23, 238, 68, 200, 165, 203, 198, 11, 30, 133, 176, 93, 66, 0, 103, 226, 59, 145, 101, 162, 214, 48, 188, 98, 224, 153, 160, 237, 222, 3, 194, 8, 40, 39, 251, 190, 92, 249, 213, 151, 20, 58, 57, 151, 71, 176, 130, 82, 38, 245, 248, 170, 78, 151, 15, 137, 100, 65, 138, 133, 153, 33, 68, 145, 186, 24, 216, 153, 41, 235, 22, 108, 50, 223, 110, 43, 26, 0, 229, 64, 244, 144, 3, 143, 102, 84, 18, 4, 75, 79, 10, 102, 36, 129 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000068"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 124, 2, 5, 56, 70, 88, 112, 222, 206, 92, 121, 225, 206, 249, 199, 118, 116, 67, 131, 117, 60, 38, 87, 161, 22, 236, 54, 203, 9, 174, 169, 109, 211, 136, 150, 3, 44, 237, 36, 55, 238, 45, 255, 35, 244, 14, 74, 165, 93, 100, 42, 127, 14, 249, 146, 193, 92, 29, 227, 76, 178, 131, 26, 138 }, new byte[] { 18, 170, 192, 171, 86, 158, 207, 38, 115, 190, 202, 49, 29, 124, 25, 70, 24, 233, 243, 189, 152, 126, 225, 131, 254, 114, 235, 63, 82, 51, 160, 97, 160, 219, 23, 238, 68, 200, 165, 203, 198, 11, 30, 133, 176, 93, 66, 0, 103, 226, 59, 145, 101, 162, 214, 48, 188, 98, 224, 153, 160, 237, 222, 3, 194, 8, 40, 39, 251, 190, 92, 249, 213, 151, 20, 58, 57, 151, 71, 176, 130, 82, 38, 245, 248, 170, 78, 151, 15, 137, 100, 65, 138, 133, 153, 33, 68, 145, 186, 24, 216, 153, 41, 235, 22, 108, 50, 223, 110, 43, 26, 0, 229, 64, 244, 144, 3, 143, 102, 84, 18, 4, 75, 79, 10, 102, 36, 129 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000069"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 124, 2, 5, 56, 70, 88, 112, 222, 206, 92, 121, 225, 206, 249, 199, 118, 116, 67, 131, 117, 60, 38, 87, 161, 22, 236, 54, 203, 9, 174, 169, 109, 211, 136, 150, 3, 44, 237, 36, 55, 238, 45, 255, 35, 244, 14, 74, 165, 93, 100, 42, 127, 14, 249, 146, 193, 92, 29, 227, 76, 178, 131, 26, 138 }, new byte[] { 18, 170, 192, 171, 86, 158, 207, 38, 115, 190, 202, 49, 29, 124, 25, 70, 24, 233, 243, 189, 152, 126, 225, 131, 254, 114, 235, 63, 82, 51, 160, 97, 160, 219, 23, 238, 68, 200, 165, 203, 198, 11, 30, 133, 176, 93, 66, 0, 103, 226, 59, 145, 101, 162, 214, 48, 188, 98, 224, 153, 160, 237, 222, 3, 194, 8, 40, 39, 251, 190, 92, 249, 213, 151, 20, 58, 57, 151, 71, 176, 130, 82, 38, 245, 248, 170, 78, 151, 15, 137, 100, 65, 138, 133, 153, 33, 68, 145, 186, 24, 216, 153, 41, 235, 22, 108, 50, 223, 110, 43, 26, 0, 229, 64, 244, 144, 3, 143, 102, 84, 18, 4, 75, 79, 10, 102, 36, 129 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000070"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 124, 2, 5, 56, 70, 88, 112, 222, 206, 92, 121, 225, 206, 249, 199, 118, 116, 67, 131, 117, 60, 38, 87, 161, 22, 236, 54, 203, 9, 174, 169, 109, 211, 136, 150, 3, 44, 237, 36, 55, 238, 45, 255, 35, 244, 14, 74, 165, 93, 100, 42, 127, 14, 249, 146, 193, 92, 29, 227, 76, 178, 131, 26, 138 }, new byte[] { 18, 170, 192, 171, 86, 158, 207, 38, 115, 190, 202, 49, 29, 124, 25, 70, 24, 233, 243, 189, 152, 126, 225, 131, 254, 114, 235, 63, 82, 51, 160, 97, 160, 219, 23, 238, 68, 200, 165, 203, 198, 11, 30, 133, 176, 93, 66, 0, 103, 226, 59, 145, 101, 162, 214, 48, 188, 98, 224, 153, 160, 237, 222, 3, 194, 8, 40, 39, 251, 190, 92, 249, 213, 151, 20, 58, 57, 151, 71, 176, 130, 82, 38, 245, 248, 170, 78, 151, 15, 137, 100, 65, 138, 133, 153, 33, 68, 145, 186, 24, 216, 153, 41, 235, 22, 108, 50, 223, 110, 43, 26, 0, 229, 64, 244, 144, 3, 143, 102, 84, 18, 4, 75, 79, 10, 102, 36, 129 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000071"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 124, 2, 5, 56, 70, 88, 112, 222, 206, 92, 121, 225, 206, 249, 199, 118, 116, 67, 131, 117, 60, 38, 87, 161, 22, 236, 54, 203, 9, 174, 169, 109, 211, 136, 150, 3, 44, 237, 36, 55, 238, 45, 255, 35, 244, 14, 74, 165, 93, 100, 42, 127, 14, 249, 146, 193, 92, 29, 227, 76, 178, 131, 26, 138 }, new byte[] { 18, 170, 192, 171, 86, 158, 207, 38, 115, 190, 202, 49, 29, 124, 25, 70, 24, 233, 243, 189, 152, 126, 225, 131, 254, 114, 235, 63, 82, 51, 160, 97, 160, 219, 23, 238, 68, 200, 165, 203, 198, 11, 30, 133, 176, 93, 66, 0, 103, 226, 59, 145, 101, 162, 214, 48, 188, 98, 224, 153, 160, 237, 222, 3, 194, 8, 40, 39, 251, 190, 92, 249, 213, 151, 20, 58, 57, 151, 71, 176, 130, 82, 38, 245, 248, 170, 78, 151, 15, 137, 100, 65, 138, 133, 153, 33, 68, 145, 186, 24, 216, 153, 41, 235, 22, 108, 50, 223, 110, 43, 26, 0, 229, 64, 244, 144, 3, 143, 102, 84, 18, 4, 75, 79, 10, 102, 36, 129 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000072"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 124, 2, 5, 56, 70, 88, 112, 222, 206, 92, 121, 225, 206, 249, 199, 118, 116, 67, 131, 117, 60, 38, 87, 161, 22, 236, 54, 203, 9, 174, 169, 109, 211, 136, 150, 3, 44, 237, 36, 55, 238, 45, 255, 35, 244, 14, 74, 165, 93, 100, 42, 127, 14, 249, 146, 193, 92, 29, 227, 76, 178, 131, 26, 138 }, new byte[] { 18, 170, 192, 171, 86, 158, 207, 38, 115, 190, 202, 49, 29, 124, 25, 70, 24, 233, 243, 189, 152, 126, 225, 131, 254, 114, 235, 63, 82, 51, 160, 97, 160, 219, 23, 238, 68, 200, 165, 203, 198, 11, 30, 133, 176, 93, 66, 0, 103, 226, 59, 145, 101, 162, 214, 48, 188, 98, 224, 153, 160, 237, 222, 3, 194, 8, 40, 39, 251, 190, 92, 249, 213, 151, 20, 58, 57, 151, 71, 176, 130, 82, 38, 245, 248, 170, 78, 151, 15, 137, 100, 65, 138, 133, 153, 33, 68, 145, 186, 24, 216, 153, 41, 235, 22, 108, 50, 223, 110, 43, 26, 0, 229, 64, 244, 144, 3, 143, 102, 84, 18, 4, 75, 79, 10, 102, 36, 129 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000073"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 124, 2, 5, 56, 70, 88, 112, 222, 206, 92, 121, 225, 206, 249, 199, 118, 116, 67, 131, 117, 60, 38, 87, 161, 22, 236, 54, 203, 9, 174, 169, 109, 211, 136, 150, 3, 44, 237, 36, 55, 238, 45, 255, 35, 244, 14, 74, 165, 93, 100, 42, 127, 14, 249, 146, 193, 92, 29, 227, 76, 178, 131, 26, 138 }, new byte[] { 18, 170, 192, 171, 86, 158, 207, 38, 115, 190, 202, 49, 29, 124, 25, 70, 24, 233, 243, 189, 152, 126, 225, 131, 254, 114, 235, 63, 82, 51, 160, 97, 160, 219, 23, 238, 68, 200, 165, 203, 198, 11, 30, 133, 176, 93, 66, 0, 103, 226, 59, 145, 101, 162, 214, 48, 188, 98, 224, 153, 160, 237, 222, 3, 194, 8, 40, 39, 251, 190, 92, 249, 213, 151, 20, 58, 57, 151, 71, 176, 130, 82, 38, 245, 248, 170, 78, 151, 15, 137, 100, 65, 138, 133, 153, 33, 68, 145, 186, 24, 216, 153, 41, 235, 22, 108, 50, 223, 110, 43, 26, 0, 229, 64, 244, 144, 3, 143, 102, 84, 18, 4, 75, 79, 10, 102, 36, 129 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000074"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 124, 2, 5, 56, 70, 88, 112, 222, 206, 92, 121, 225, 206, 249, 199, 118, 116, 67, 131, 117, 60, 38, 87, 161, 22, 236, 54, 203, 9, 174, 169, 109, 211, 136, 150, 3, 44, 237, 36, 55, 238, 45, 255, 35, 244, 14, 74, 165, 93, 100, 42, 127, 14, 249, 146, 193, 92, 29, 227, 76, 178, 131, 26, 138 }, new byte[] { 18, 170, 192, 171, 86, 158, 207, 38, 115, 190, 202, 49, 29, 124, 25, 70, 24, 233, 243, 189, 152, 126, 225, 131, 254, 114, 235, 63, 82, 51, 160, 97, 160, 219, 23, 238, 68, 200, 165, 203, 198, 11, 30, 133, 176, 93, 66, 0, 103, 226, 59, 145, 101, 162, 214, 48, 188, 98, 224, 153, 160, 237, 222, 3, 194, 8, 40, 39, 251, 190, 92, 249, 213, 151, 20, 58, 57, 151, 71, 176, 130, 82, 38, 245, 248, 170, 78, 151, 15, 137, 100, 65, 138, 133, 153, 33, 68, 145, 186, 24, 216, 153, 41, 235, 22, 108, 50, 223, 110, 43, 26, 0, 229, 64, 244, 144, 3, 143, 102, 84, 18, 4, 75, 79, 10, 102, 36, 129 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000075"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 124, 2, 5, 56, 70, 88, 112, 222, 206, 92, 121, 225, 206, 249, 199, 118, 116, 67, 131, 117, 60, 38, 87, 161, 22, 236, 54, 203, 9, 174, 169, 109, 211, 136, 150, 3, 44, 237, 36, 55, 238, 45, 255, 35, 244, 14, 74, 165, 93, 100, 42, 127, 14, 249, 146, 193, 92, 29, 227, 76, 178, 131, 26, 138 }, new byte[] { 18, 170, 192, 171, 86, 158, 207, 38, 115, 190, 202, 49, 29, 124, 25, 70, 24, 233, 243, 189, 152, 126, 225, 131, 254, 114, 235, 63, 82, 51, 160, 97, 160, 219, 23, 238, 68, 200, 165, 203, 198, 11, 30, 133, 176, 93, 66, 0, 103, 226, 59, 145, 101, 162, 214, 48, 188, 98, 224, 153, 160, 237, 222, 3, 194, 8, 40, 39, 251, 190, 92, 249, 213, 151, 20, 58, 57, 151, 71, 176, 130, 82, 38, 245, 248, 170, 78, 151, 15, 137, 100, 65, 138, 133, 153, 33, 68, 145, 186, 24, 216, 153, 41, 235, 22, 108, 50, 223, 110, 43, 26, 0, 229, 64, 244, 144, 3, 143, 102, 84, 18, 4, 75, 79, 10, 102, 36, 129 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000076"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 124, 2, 5, 56, 70, 88, 112, 222, 206, 92, 121, 225, 206, 249, 199, 118, 116, 67, 131, 117, 60, 38, 87, 161, 22, 236, 54, 203, 9, 174, 169, 109, 211, 136, 150, 3, 44, 237, 36, 55, 238, 45, 255, 35, 244, 14, 74, 165, 93, 100, 42, 127, 14, 249, 146, 193, 92, 29, 227, 76, 178, 131, 26, 138 }, new byte[] { 18, 170, 192, 171, 86, 158, 207, 38, 115, 190, 202, 49, 29, 124, 25, 70, 24, 233, 243, 189, 152, 126, 225, 131, 254, 114, 235, 63, 82, 51, 160, 97, 160, 219, 23, 238, 68, 200, 165, 203, 198, 11, 30, 133, 176, 93, 66, 0, 103, 226, 59, 145, 101, 162, 214, 48, 188, 98, 224, 153, 160, 237, 222, 3, 194, 8, 40, 39, 251, 190, 92, 249, 213, 151, 20, 58, 57, 151, 71, 176, 130, 82, 38, 245, 248, 170, 78, 151, 15, 137, 100, 65, 138, 133, 153, 33, 68, 145, 186, 24, 216, 153, 41, 235, 22, 108, 50, 223, 110, 43, 26, 0, 229, 64, 244, 144, 3, 143, 102, 84, 18, 4, 75, 79, 10, 102, 36, 129 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000077"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 124, 2, 5, 56, 70, 88, 112, 222, 206, 92, 121, 225, 206, 249, 199, 118, 116, 67, 131, 117, 60, 38, 87, 161, 22, 236, 54, 203, 9, 174, 169, 109, 211, 136, 150, 3, 44, 237, 36, 55, 238, 45, 255, 35, 244, 14, 74, 165, 93, 100, 42, 127, 14, 249, 146, 193, 92, 29, 227, 76, 178, 131, 26, 138 }, new byte[] { 18, 170, 192, 171, 86, 158, 207, 38, 115, 190, 202, 49, 29, 124, 25, 70, 24, 233, 243, 189, 152, 126, 225, 131, 254, 114, 235, 63, 82, 51, 160, 97, 160, 219, 23, 238, 68, 200, 165, 203, 198, 11, 30, 133, 176, 93, 66, 0, 103, 226, 59, 145, 101, 162, 214, 48, 188, 98, 224, 153, 160, 237, 222, 3, 194, 8, 40, 39, 251, 190, 92, 249, 213, 151, 20, 58, 57, 151, 71, 176, 130, 82, 38, 245, 248, 170, 78, 151, 15, 137, 100, 65, 138, 133, 153, 33, 68, 145, 186, 24, 216, 153, 41, 235, 22, 108, 50, 223, 110, 43, 26, 0, 229, 64, 244, 144, 3, 143, 102, 84, 18, 4, 75, 79, 10, 102, 36, 129 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000078"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 124, 2, 5, 56, 70, 88, 112, 222, 206, 92, 121, 225, 206, 249, 199, 118, 116, 67, 131, 117, 60, 38, 87, 161, 22, 236, 54, 203, 9, 174, 169, 109, 211, 136, 150, 3, 44, 237, 36, 55, 238, 45, 255, 35, 244, 14, 74, 165, 93, 100, 42, 127, 14, 249, 146, 193, 92, 29, 227, 76, 178, 131, 26, 138 }, new byte[] { 18, 170, 192, 171, 86, 158, 207, 38, 115, 190, 202, 49, 29, 124, 25, 70, 24, 233, 243, 189, 152, 126, 225, 131, 254, 114, 235, 63, 82, 51, 160, 97, 160, 219, 23, 238, 68, 200, 165, 203, 198, 11, 30, 133, 176, 93, 66, 0, 103, 226, 59, 145, 101, 162, 214, 48, 188, 98, 224, 153, 160, 237, 222, 3, 194, 8, 40, 39, 251, 190, 92, 249, 213, 151, 20, 58, 57, 151, 71, 176, 130, 82, 38, 245, 248, 170, 78, 151, 15, 137, 100, 65, 138, 133, 153, 33, 68, 145, 186, 24, 216, 153, 41, 235, 22, 108, 50, 223, 110, 43, 26, 0, 229, 64, 244, 144, 3, 143, 102, 84, 18, 4, 75, 79, 10, 102, 36, 129 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000079"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 124, 2, 5, 56, 70, 88, 112, 222, 206, 92, 121, 225, 206, 249, 199, 118, 116, 67, 131, 117, 60, 38, 87, 161, 22, 236, 54, 203, 9, 174, 169, 109, 211, 136, 150, 3, 44, 237, 36, 55, 238, 45, 255, 35, 244, 14, 74, 165, 93, 100, 42, 127, 14, 249, 146, 193, 92, 29, 227, 76, 178, 131, 26, 138 }, new byte[] { 18, 170, 192, 171, 86, 158, 207, 38, 115, 190, 202, 49, 29, 124, 25, 70, 24, 233, 243, 189, 152, 126, 225, 131, 254, 114, 235, 63, 82, 51, 160, 97, 160, 219, 23, 238, 68, 200, 165, 203, 198, 11, 30, 133, 176, 93, 66, 0, 103, 226, 59, 145, 101, 162, 214, 48, 188, 98, 224, 153, 160, 237, 222, 3, 194, 8, 40, 39, 251, 190, 92, 249, 213, 151, 20, 58, 57, 151, 71, 176, 130, 82, 38, 245, 248, 170, 78, 151, 15, 137, 100, 65, 138, 133, 153, 33, 68, 145, 186, 24, 216, 153, 41, 235, 22, 108, 50, 223, 110, 43, 26, 0, 229, 64, 244, 144, 3, 143, 102, 84, 18, 4, 75, 79, 10, 102, 36, 129 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000080"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 124, 2, 5, 56, 70, 88, 112, 222, 206, 92, 121, 225, 206, 249, 199, 118, 116, 67, 131, 117, 60, 38, 87, 161, 22, 236, 54, 203, 9, 174, 169, 109, 211, 136, 150, 3, 44, 237, 36, 55, 238, 45, 255, 35, 244, 14, 74, 165, 93, 100, 42, 127, 14, 249, 146, 193, 92, 29, 227, 76, 178, 131, 26, 138 }, new byte[] { 18, 170, 192, 171, 86, 158, 207, 38, 115, 190, 202, 49, 29, 124, 25, 70, 24, 233, 243, 189, 152, 126, 225, 131, 254, 114, 235, 63, 82, 51, 160, 97, 160, 219, 23, 238, 68, 200, 165, 203, 198, 11, 30, 133, 176, 93, 66, 0, 103, 226, 59, 145, 101, 162, 214, 48, 188, 98, 224, 153, 160, 237, 222, 3, 194, 8, 40, 39, 251, 190, 92, 249, 213, 151, 20, 58, 57, 151, 71, 176, 130, 82, 38, 245, 248, 170, 78, 151, 15, 137, 100, 65, 138, 133, 153, 33, 68, 145, 186, 24, 216, 153, 41, 235, 22, 108, 50, 223, 110, 43, 26, 0, 229, 64, 244, 144, 3, 143, 102, 84, 18, 4, 75, 79, 10, 102, 36, 129 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000081"),
                columns: new[] { "Email", "FirstName", "IsActive", "IsEmailVerified", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "ayse.yilmaz.p1@iyte.edu.tr", "Ayşe", true, true, "Yılmaz", new byte[] { 124, 2, 5, 56, 70, 88, 112, 222, 206, 92, 121, 225, 206, 249, 199, 118, 116, 67, 131, 117, 60, 38, 87, 161, 22, 236, 54, 203, 9, 174, 169, 109, 211, 136, 150, 3, 44, 237, 36, 55, 238, 45, 255, 35, 244, 14, 74, 165, 93, 100, 42, 127, 14, 249, 146, 193, 92, 29, 227, 76, 178, 131, 26, 138 }, new byte[] { 18, 170, 192, 171, 86, 158, 207, 38, 115, 190, 202, 49, 29, 124, 25, 70, 24, 233, 243, 189, 152, 126, 225, 131, 254, 114, 235, 63, 82, 51, 160, 97, 160, 219, 23, 238, 68, 200, 165, 203, 198, 11, 30, 133, 176, 93, 66, 0, 103, 226, 59, 145, 101, 162, 214, 48, 188, 98, 224, 153, 160, 237, 222, 3, 194, 8, 40, 39, 251, 190, 92, 249, 213, 151, 20, 58, 57, 151, 71, 176, 130, 82, 38, 245, 248, 170, 78, 151, 15, 137, 100, 65, 138, 133, 153, 33, 68, 145, 186, 24, 216, 153, 41, 235, 22, 108, 50, 223, 110, 43, 26, 0, 229, 64, 244, 144, 3, 143, 102, 84, 18, 4, 75, 79, 10, 102, 36, 129 }, "ayse.yilmaz.p1" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000082"),
                columns: new[] { "Email", "FirstName", "IsActive", "IsEmailVerified", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "mehmet.kaya.p2@iyte.edu.tr", "Mehmet", true, true, "Kaya", new byte[] { 124, 2, 5, 56, 70, 88, 112, 222, 206, 92, 121, 225, 206, 249, 199, 118, 116, 67, 131, 117, 60, 38, 87, 161, 22, 236, 54, 203, 9, 174, 169, 109, 211, 136, 150, 3, 44, 237, 36, 55, 238, 45, 255, 35, 244, 14, 74, 165, 93, 100, 42, 127, 14, 249, 146, 193, 92, 29, 227, 76, 178, 131, 26, 138 }, new byte[] { 18, 170, 192, 171, 86, 158, 207, 38, 115, 190, 202, 49, 29, 124, 25, 70, 24, 233, 243, 189, 152, 126, 225, 131, 254, 114, 235, 63, 82, 51, 160, 97, 160, 219, 23, 238, 68, 200, 165, 203, 198, 11, 30, 133, 176, 93, 66, 0, 103, 226, 59, 145, 101, 162, 214, 48, 188, 98, 224, 153, 160, 237, 222, 3, 194, 8, 40, 39, 251, 190, 92, 249, 213, 151, 20, 58, 57, 151, 71, 176, 130, 82, 38, 245, 248, 170, 78, 151, 15, 137, 100, 65, 138, 133, 153, 33, 68, 145, 186, 24, 216, 153, 41, 235, 22, 108, 50, 223, 110, 43, 26, 0, 229, 64, 244, 144, 3, 143, 102, 84, 18, 4, 75, 79, 10, 102, 36, 129 }, "mehmet.kaya.p2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000083"),
                columns: new[] { "Email", "FirstName", "IsActive", "IsEmailVerified", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "zeynep.demir.p3@iyte.edu.tr", "Zeynep", true, true, "Demir", new byte[] { 124, 2, 5, 56, 70, 88, 112, 222, 206, 92, 121, 225, 206, 249, 199, 118, 116, 67, 131, 117, 60, 38, 87, 161, 22, 236, 54, 203, 9, 174, 169, 109, 211, 136, 150, 3, 44, 237, 36, 55, 238, 45, 255, 35, 244, 14, 74, 165, 93, 100, 42, 127, 14, 249, 146, 193, 92, 29, 227, 76, 178, 131, 26, 138 }, new byte[] { 18, 170, 192, 171, 86, 158, 207, 38, 115, 190, 202, 49, 29, 124, 25, 70, 24, 233, 243, 189, 152, 126, 225, 131, 254, 114, 235, 63, 82, 51, 160, 97, 160, 219, 23, 238, 68, 200, 165, 203, 198, 11, 30, 133, 176, 93, 66, 0, 103, 226, 59, 145, 101, 162, 214, 48, 188, 98, 224, 153, 160, 237, 222, 3, 194, 8, 40, 39, 251, 190, 92, 249, 213, 151, 20, 58, 57, 151, 71, 176, 130, 82, 38, 245, 248, 170, 78, 151, 15, 137, 100, 65, 138, 133, 153, 33, 68, 145, 186, 24, 216, 153, 41, 235, 22, 108, 50, 223, 110, 43, 26, 0, 229, 64, 244, 144, 3, 143, 102, 84, 18, 4, 75, 79, 10, 102, 36, 129 }, "zeynep.demir.p3" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000084"),
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "ahmet.celik.p4@iyte.edu.tr", "Ahmet", "Çelik", new byte[] { 124, 2, 5, 56, 70, 88, 112, 222, 206, 92, 121, 225, 206, 249, 199, 118, 116, 67, 131, 117, 60, 38, 87, 161, 22, 236, 54, 203, 9, 174, 169, 109, 211, 136, 150, 3, 44, 237, 36, 55, 238, 45, 255, 35, 244, 14, 74, 165, 93, 100, 42, 127, 14, 249, 146, 193, 92, 29, 227, 76, 178, 131, 26, 138 }, new byte[] { 18, 170, 192, 171, 86, 158, 207, 38, 115, 190, 202, 49, 29, 124, 25, 70, 24, 233, 243, 189, 152, 126, 225, 131, 254, 114, 235, 63, 82, 51, 160, 97, 160, 219, 23, 238, 68, 200, 165, 203, 198, 11, 30, 133, 176, 93, 66, 0, 103, 226, 59, 145, 101, 162, 214, 48, 188, 98, 224, 153, 160, 237, 222, 3, 194, 8, 40, 39, 251, 190, 92, 249, 213, 151, 20, 58, 57, 151, 71, 176, 130, 82, 38, 245, 248, 170, 78, 151, 15, 137, 100, 65, 138, 133, 153, 33, 68, 145, 186, 24, 216, 153, 41, 235, 22, 108, 50, 223, 110, 43, 26, 0, 229, 64, 244, 144, 3, 143, 102, 84, 18, 4, 75, 79, 10, 102, 36, 129 }, "ahmet.celik.p4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000085"),
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "mustafa.sahin.p5@iyte.edu.tr", "Mustafa", "Şahin", new byte[] { 124, 2, 5, 56, 70, 88, 112, 222, 206, 92, 121, 225, 206, 249, 199, 118, 116, 67, 131, 117, 60, 38, 87, 161, 22, 236, 54, 203, 9, 174, 169, 109, 211, 136, 150, 3, 44, 237, 36, 55, 238, 45, 255, 35, 244, 14, 74, 165, 93, 100, 42, 127, 14, 249, 146, 193, 92, 29, 227, 76, 178, 131, 26, 138 }, new byte[] { 18, 170, 192, 171, 86, 158, 207, 38, 115, 190, 202, 49, 29, 124, 25, 70, 24, 233, 243, 189, 152, 126, 225, 131, 254, 114, 235, 63, 82, 51, 160, 97, 160, 219, 23, 238, 68, 200, 165, 203, 198, 11, 30, 133, 176, 93, 66, 0, 103, 226, 59, 145, 101, 162, 214, 48, 188, 98, 224, 153, 160, 237, 222, 3, 194, 8, 40, 39, 251, 190, 92, 249, 213, 151, 20, 58, 57, 151, 71, 176, 130, 82, 38, 245, 248, 170, 78, 151, 15, 137, 100, 65, 138, 133, 153, 33, 68, 145, 186, 24, 216, 153, 41, 235, 22, 108, 50, 223, 110, 43, 26, 0, 229, 64, 244, 144, 3, 143, 102, 84, 18, 4, 75, 79, 10, 102, 36, 129 }, "mustafa.sahin.p5" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000086"),
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "fatma.ozturk.p6@iyte.edu.tr", "Fatma", "Öztürk", new byte[] { 124, 2, 5, 56, 70, 88, 112, 222, 206, 92, 121, 225, 206, 249, 199, 118, 116, 67, 131, 117, 60, 38, 87, 161, 22, 236, 54, 203, 9, 174, 169, 109, 211, 136, 150, 3, 44, 237, 36, 55, 238, 45, 255, 35, 244, 14, 74, 165, 93, 100, 42, 127, 14, 249, 146, 193, 92, 29, 227, 76, 178, 131, 26, 138 }, new byte[] { 18, 170, 192, 171, 86, 158, 207, 38, 115, 190, 202, 49, 29, 124, 25, 70, 24, 233, 243, 189, 152, 126, 225, 131, 254, 114, 235, 63, 82, 51, 160, 97, 160, 219, 23, 238, 68, 200, 165, 203, 198, 11, 30, 133, 176, 93, 66, 0, 103, 226, 59, 145, 101, 162, 214, 48, 188, 98, 224, 153, 160, 237, 222, 3, 194, 8, 40, 39, 251, 190, 92, 249, 213, 151, 20, 58, 57, 151, 71, 176, 130, 82, 38, 245, 248, 170, 78, 151, 15, 137, 100, 65, 138, 133, 153, 33, 68, 145, 186, 24, 216, 153, 41, 235, 22, 108, 50, 223, 110, 43, 26, 0, 229, 64, 244, 144, 3, 143, 102, 84, 18, 4, 75, 79, 10, 102, 36, 129 }, "fatma.ozturk.p6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000087"),
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "ali.yildiz.p7@iyte.edu.tr", "Ali", "Yıldız", new byte[] { 124, 2, 5, 56, 70, 88, 112, 222, 206, 92, 121, 225, 206, 249, 199, 118, 116, 67, 131, 117, 60, 38, 87, 161, 22, 236, 54, 203, 9, 174, 169, 109, 211, 136, 150, 3, 44, 237, 36, 55, 238, 45, 255, 35, 244, 14, 74, 165, 93, 100, 42, 127, 14, 249, 146, 193, 92, 29, 227, 76, 178, 131, 26, 138 }, new byte[] { 18, 170, 192, 171, 86, 158, 207, 38, 115, 190, 202, 49, 29, 124, 25, 70, 24, 233, 243, 189, 152, 126, 225, 131, 254, 114, 235, 63, 82, 51, 160, 97, 160, 219, 23, 238, 68, 200, 165, 203, 198, 11, 30, 133, 176, 93, 66, 0, 103, 226, 59, 145, 101, 162, 214, 48, 188, 98, 224, 153, 160, 237, 222, 3, 194, 8, 40, 39, 251, 190, 92, 249, 213, 151, 20, 58, 57, 151, 71, 176, 130, 82, 38, 245, 248, 170, 78, 151, 15, 137, 100, 65, 138, 133, 153, 33, 68, 145, 186, 24, 216, 153, 41, 235, 22, 108, 50, 223, 110, 43, 26, 0, 229, 64, 244, 144, 3, 143, 102, 84, 18, 4, 75, 79, 10, 102, 36, 129 }, "ali.yildiz.p7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000088"),
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "huseyin.aydin.p8@iyte.edu.tr", "Hüseyin", "Aydın", new byte[] { 124, 2, 5, 56, 70, 88, 112, 222, 206, 92, 121, 225, 206, 249, 199, 118, 116, 67, 131, 117, 60, 38, 87, 161, 22, 236, 54, 203, 9, 174, 169, 109, 211, 136, 150, 3, 44, 237, 36, 55, 238, 45, 255, 35, 244, 14, 74, 165, 93, 100, 42, 127, 14, 249, 146, 193, 92, 29, 227, 76, 178, 131, 26, 138 }, new byte[] { 18, 170, 192, 171, 86, 158, 207, 38, 115, 190, 202, 49, 29, 124, 25, 70, 24, 233, 243, 189, 152, 126, 225, 131, 254, 114, 235, 63, 82, 51, 160, 97, 160, 219, 23, 238, 68, 200, 165, 203, 198, 11, 30, 133, 176, 93, 66, 0, 103, 226, 59, 145, 101, 162, 214, 48, 188, 98, 224, 153, 160, 237, 222, 3, 194, 8, 40, 39, 251, 190, 92, 249, 213, 151, 20, 58, 57, 151, 71, 176, 130, 82, 38, 245, 248, 170, 78, 151, 15, 137, 100, 65, 138, 133, 153, 33, 68, 145, 186, 24, 216, 153, 41, 235, 22, 108, 50, 223, 110, 43, 26, 0, 229, 64, 244, 144, 3, 143, 102, 84, 18, 4, 75, 79, 10, 102, 36, 129 }, "huseyin.aydin.p8" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000089"),
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "elif.arslan.p9@iyte.edu.tr", "Elif", "Arslan", new byte[] { 124, 2, 5, 56, 70, 88, 112, 222, 206, 92, 121, 225, 206, 249, 199, 118, 116, 67, 131, 117, 60, 38, 87, 161, 22, 236, 54, 203, 9, 174, 169, 109, 211, 136, 150, 3, 44, 237, 36, 55, 238, 45, 255, 35, 244, 14, 74, 165, 93, 100, 42, 127, 14, 249, 146, 193, 92, 29, 227, 76, 178, 131, 26, 138 }, new byte[] { 18, 170, 192, 171, 86, 158, 207, 38, 115, 190, 202, 49, 29, 124, 25, 70, 24, 233, 243, 189, 152, 126, 225, 131, 254, 114, 235, 63, 82, 51, 160, 97, 160, 219, 23, 238, 68, 200, 165, 203, 198, 11, 30, 133, 176, 93, 66, 0, 103, 226, 59, 145, 101, 162, 214, 48, 188, 98, 224, 153, 160, 237, 222, 3, 194, 8, 40, 39, 251, 190, 92, 249, 213, 151, 20, 58, 57, 151, 71, 176, 130, 82, 38, 245, 248, 170, 78, 151, 15, 137, 100, 65, 138, 133, 153, 33, 68, 145, 186, 24, 216, 153, 41, 235, 22, 108, 50, 223, 110, 43, 26, 0, 229, 64, 244, 144, 3, 143, 102, 84, 18, 4, 75, 79, 10, 102, 36, 129 }, "elif.arslan.p9" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000090"),
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { "veli.dogan.p10@iyte.edu.tr", "Veli", "Doğan", new byte[] { 124, 2, 5, 56, 70, 88, 112, 222, 206, 92, 121, 225, 206, 249, 199, 118, 116, 67, 131, 117, 60, 38, 87, 161, 22, 236, 54, 203, 9, 174, 169, 109, 211, 136, 150, 3, 44, 237, 36, 55, 238, 45, 255, 35, 244, 14, 74, 165, 93, 100, 42, 127, 14, 249, 146, 193, 92, 29, 227, 76, 178, 131, 26, 138 }, new byte[] { 18, 170, 192, 171, 86, 158, 207, 38, 115, 190, 202, 49, 29, 124, 25, 70, 24, 233, 243, 189, 152, 126, 225, 131, 254, 114, 235, 63, 82, 51, 160, 97, 160, 219, 23, 238, 68, 200, 165, 203, 198, 11, 30, 133, 176, 93, 66, 0, 103, 226, 59, 145, 101, 162, 214, 48, 188, 98, 224, 153, 160, 237, 222, 3, 194, 8, 40, 39, 251, 190, 92, 249, 213, 151, 20, 58, 57, 151, 71, 176, 130, 82, 38, 245, 248, 170, 78, 151, 15, 137, 100, 65, 138, 133, 153, 33, 68, 145, 186, 24, 216, 153, 41, 235, 22, 108, 50, 223, 110, 43, 26, 0, 229, 64, 244, 144, 3, 143, 102, 84, 18, 4, 75, 79, 10, 102, 36, 129 }, "veli.dogan.p10" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-44444444444a"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 160, 55, 244, 217, 218, 252, 96, 196, 146, 108, 89, 218, 65, 197, 13, 126, 48, 23, 213, 124, 37, 61, 58, 31, 57, 200, 129, 157, 40, 33, 46, 80, 0, 215, 68, 11, 161, 169, 229, 74, 238, 105, 137, 133, 178, 61, 211, 93, 82, 20, 60, 202, 225, 125, 249, 57, 193, 145, 232, 29, 1, 139, 99, 82 }, new byte[] { 246, 222, 234, 27, 196, 122, 165, 26, 46, 12, 167, 200, 242, 132, 212, 197, 48, 254, 177, 61, 31, 167, 107, 215, 128, 125, 243, 122, 165, 126, 191, 217, 84, 15, 165, 171, 89, 177, 126, 11, 90, 193, 81, 211, 101, 255, 84, 216, 85, 228, 193, 128, 153, 1, 10, 98, 198, 230, 15, 204, 58, 63, 97, 231, 53, 191, 242, 231, 21, 12, 186, 167, 239, 13, 182, 244, 220, 88, 70, 64, 219, 238, 133, 176, 132, 242, 62, 116, 8, 158, 16, 162, 59, 127, 22, 32, 103, 227, 144, 4, 111, 158, 72, 38, 218, 229, 212, 197, 214, 178, 95, 237, 107, 82, 127, 185, 68, 139, 192, 21, 227, 145, 56, 97, 70, 209, 69, 244 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-55555555555a"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 236, 22, 193, 83, 237, 12, 32, 44, 227, 226, 236, 0, 36, 43, 62, 157, 98, 173, 119, 217, 149, 85, 155, 240, 33, 116, 5, 147, 123, 182, 83, 141, 208, 99, 139, 15, 118, 153, 233, 183, 229, 130, 189, 90, 95, 140, 71, 247, 0, 222, 183, 219, 14, 211, 58, 142, 197, 70, 155, 5, 219, 130, 130, 176 }, new byte[] { 142, 115, 158, 57, 82, 237, 204, 212, 174, 229, 30, 181, 120, 175, 66, 209, 30, 149, 233, 107, 113, 90, 19, 80, 172, 5, 169, 118, 106, 52, 147, 86, 110, 131, 127, 55, 92, 56, 182, 202, 12, 24, 5, 202, 35, 198, 102, 245, 15, 165, 125, 213, 52, 130, 113, 184, 28, 10, 122, 113, 133, 129, 87, 210, 83, 196, 7, 151, 114, 143, 111, 82, 79, 67, 149, 221, 209, 27, 144, 152, 19, 198, 61, 181, 247, 220, 91, 87, 156, 84, 159, 117, 155, 210, 2, 212, 140, 213, 9, 22, 126, 148, 242, 98, 155, 243, 31, 63, 253, 178, 34, 116, 33, 32, 62, 111, 113, 104, 160, 45, 160, 206, 212, 216, 55, 20, 184, 178 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-66666666666a"),
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 130, 88, 171, 171, 68, 75, 95, 29, 221, 61, 78, 242, 221, 75, 102, 217, 14, 89, 116, 218, 58, 15, 128, 16, 44, 67, 201, 95, 152, 229, 201, 32, 17, 194, 70, 43, 16, 146, 21, 83, 206, 122, 71, 113, 98, 189, 46, 74, 30, 126, 44, 173, 132, 222, 241, 156, 208, 127, 103, 110, 155, 83, 193, 210 }, new byte[] { 74, 204, 120, 202, 65, 177, 223, 248, 238, 42, 36, 94, 198, 89, 103, 90, 63, 60, 42, 227, 228, 62, 136, 42, 246, 144, 229, 71, 44, 65, 40, 64, 64, 91, 44, 122, 98, 149, 147, 34, 204, 121, 15, 164, 169, 115, 94, 108, 11, 200, 240, 195, 47, 93, 224, 125, 79, 3, 33, 29, 183, 14, 13, 6, 233, 226, 94, 136, 212, 87, 21, 79, 215, 127, 94, 228, 84, 238, 200, 106, 3, 195, 126, 43, 143, 140, 85, 179, 124, 55, 135, 13, 152, 27, 58, 114, 114, 43, 42, 119, 84, 198, 135, 237, 161, 193, 216, 128, 163, 144, 248, 179, 52, 161, 114, 124, 101, 203, 93, 108, 178, 188, 102, 83, 64, 66, 11, 90 } });
        }
    }
}
