using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class init3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Faculties",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faculties", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MailLogs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    SentDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    From = table.Column<string>(type: "text", nullable: false),
                    To = table.Column<string>(type: "text", nullable: false),
                    Subject = table.Column<string>(type: "text", nullable: false),
                    Body = table.Column<string>(type: "text", nullable: false),
                    IsBodyHtml = table.Column<bool>(type: "boolean", nullable: false),
                    IsSentSuccessfully = table.Column<bool>(type: "boolean", nullable: false),
                    ErrorMessage = table.Column<string>(type: "text", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MailLogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OperationClaims",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserName = table.Column<string>(type: "text", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    IsEmailVerified = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "bytea", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "bytea", nullable: false),
                    AuthenticatorType = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    FacultyId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Departments_Faculties_FacultyId",
                        column: x => x.FacultyId,
                        principalTable: "Faculties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmailAuthenticators",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    ActivationKey = table.Column<string>(type: "text", nullable: true),
                    IsVerified = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailAuthenticators", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmailAuthenticators_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GraduationProcesses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    StudentUserId = table.Column<Guid>(type: "uuid", nullable: false),
                    AcademicTerm = table.Column<string>(type: "text", nullable: false),
                    InitiationDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Notes = table.Column<string>(type: "text", nullable: true),
                    AdvisorUserId = table.Column<Guid>(type: "uuid", nullable: true),
                    AdvisorReviewDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeptSecretaryUserId = table.Column<Guid>(type: "uuid", nullable: true),
                    DeptSecretaryReviewDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeansOfficeUserId = table.Column<Guid>(type: "uuid", nullable: true),
                    DeansOfficeReviewDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    StudentAffairsUserId = table.Column<Guid>(type: "uuid", nullable: true),
                    StudentAffairsReviewDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GraduationProcesses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GraduationProcesses_Users_AdvisorUserId",
                        column: x => x.AdvisorUserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GraduationProcesses_Users_DeansOfficeUserId",
                        column: x => x.DeansOfficeUserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GraduationProcesses_Users_DeptSecretaryUserId",
                        column: x => x.DeptSecretaryUserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GraduationProcesses_Users_StudentAffairsUserId",
                        column: x => x.StudentAffairsUserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GraduationProcesses_Users_StudentUserId",
                        column: x => x.StudentUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OtpAuthenticators",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    SecretKey = table.Column<byte[]>(type: "bytea", nullable: false),
                    IsVerified = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtpAuthenticators", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OtpAuthenticators_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RefreshTokens",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    Token = table.Column<string>(type: "text", nullable: false),
                    ExpiresDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedByIp = table.Column<string>(type: "text", nullable: false),
                    RevokedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    RevokedByIp = table.Column<string>(type: "text", nullable: true),
                    ReplacedByToken = table.Column<string>(type: "text", nullable: true),
                    ReasonRevoked = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshTokens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RefreshTokens_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserOperationClaims",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    OperationClaimId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserOperationClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserOperationClaims_OperationClaims_OperationClaimId",
                        column: x => x.OperationClaimId,
                        principalTable: "OperationClaims",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserOperationClaims_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ValidationCodes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: true),
                    Code = table.Column<string>(type: "text", nullable: false),
                    ExpireDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsUsed = table.Column<bool>(type: "boolean", nullable: false),
                    ValidationType = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ValidationCodes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ValidationCodes_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CourseCode = table.Column<string>(type: "text", nullable: false),
                    CourseName = table.Column<string>(type: "text", nullable: false),
                    DepartmentId = table.Column<Guid>(type: "uuid", nullable: true),
                    Ects = table.Column<int>(type: "integer", nullable: false),
                    CourseType = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Courses_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "GraduationRequirementSets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    DepartmentId = table.Column<Guid>(type: "uuid", nullable: false),
                    MinGpa = table.Column<decimal>(type: "numeric", nullable: false),
                    TotalMinEcts = table.Column<int>(type: "integer", nullable: false),
                    MinTechnicalElectiveCoursesCount = table.Column<int>(type: "integer", nullable: true),
                    MinNonTechnicalElectiveCoursesCount = table.Column<int>(type: "integer", nullable: true),
                    MinUniversityElectiveCoursesCount = table.Column<int>(type: "integer", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    CreatedByUserId = table.Column<Guid>(type: "uuid", nullable: false),
                    LastModifiedByUserId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModificationDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GraduationRequirementSets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GraduationRequirementSets_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GraduationRequirementSets_Users_CreatedByUserId",
                        column: x => x.CreatedByUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GraduationRequirementSets_Users_LastModifiedByUserId",
                        column: x => x.LastModifiedByUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RankingLists",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ListType = table.Column<int>(type: "integer", nullable: false),
                    ScopeDepartmentId = table.Column<Guid>(type: "uuid", nullable: true),
                    ScopeFacultyId = table.Column<Guid>(type: "uuid", nullable: true),
                    AcademicTerm = table.Column<string>(type: "text", nullable: false),
                    GenerationDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    GeneratedByUserId = table.Column<Guid>(type: "uuid", nullable: false),
                    PrimarySortField = table.Column<string>(type: "text", nullable: false),
                    SortOrder = table.Column<string>(type: "text", nullable: false),
                    MinGpaForInclusion = table.Column<decimal>(type: "numeric", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RankingLists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RankingLists_Departments_ScopeDepartmentId",
                        column: x => x.ScopeDepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RankingLists_Faculties_ScopeFacultyId",
                        column: x => x.ScopeFacultyId,
                        principalTable: "Faculties",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RankingLists_Users_GeneratedByUserId",
                        column: x => x.GeneratedByUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Staffs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    StaffIdentificationNumber = table.Column<string>(type: "text", nullable: true),
                    Title = table.Column<string>(type: "text", nullable: true),
                    DepartmentId = table.Column<Guid>(type: "uuid", nullable: true),
                    FacultyId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staffs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Staffs_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Staffs_Faculties_FacultyId",
                        column: x => x.FacultyId,
                        principalTable: "Faculties",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Staffs_Users_Id",
                        column: x => x.Id,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    StudentNumber = table.Column<string>(type: "text", nullable: false),
                    DepartmentId = table.Column<Guid>(type: "uuid", nullable: false),
                    ProgramName = table.Column<string>(type: "text", nullable: false),
                    EnrollDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CurrentGpa = table.Column<decimal>(type: "numeric", nullable: true),
                    CurrentEctsCompleted = table.Column<int>(type: "integer", nullable: true),
                    GraduationStatus = table.Column<int>(type: "integer", nullable: false),
                    AssignedAdvisorUserId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Students_Users_AssignedAdvisorUserId",
                        column: x => x.AssignedAdvisorUserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Students_Users_Id",
                        column: x => x.Id,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EligibilityCheckResults",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ProcessId = table.Column<Guid>(type: "uuid", nullable: false),
                    CheckType = table.Column<int>(type: "integer", nullable: false),
                    IsMet = table.Column<bool>(type: "boolean", nullable: false),
                    ActualValue = table.Column<string>(type: "text", nullable: false),
                    RequiredValue = table.Column<string>(type: "text", nullable: false),
                    NotesOrMissingItems = table.Column<string>(type: "text", nullable: true),
                    CheckDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    GraduationProcessId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EligibilityCheckResults", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EligibilityCheckResults_GraduationProcesses_GraduationProce~",
                        column: x => x.GraduationProcessId,
                        principalTable: "GraduationProcesses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FileAttachments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FileName = table.Column<string>(type: "text", nullable: false),
                    FilePath = table.Column<string>(type: "text", nullable: false),
                    StorageType = table.Column<int>(type: "integer", nullable: false),
                    FileSize = table.Column<long>(type: "bigint", nullable: false),
                    FileType = table.Column<int>(type: "integer", nullable: false),
                    MimeType = table.Column<string>(type: "text", nullable: false),
                    UploadDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UploaderUserId = table.Column<Guid>(type: "uuid", nullable: false),
                    StudentUserId = table.Column<Guid>(type: "uuid", nullable: true),
                    ProcessId = table.Column<Guid>(type: "uuid", nullable: true),
                    GraduationProcessId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileAttachments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FileAttachments_GraduationProcesses_GraduationProcessId",
                        column: x => x.GraduationProcessId,
                        principalTable: "GraduationProcesses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FileAttachments_Users_StudentUserId",
                        column: x => x.StudentUserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FileAttachments_Users_UploaderUserId",
                        column: x => x.UploaderUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    RecipientUserId = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Message = table.Column<string>(type: "text", nullable: false),
                    IsRead = table.Column<bool>(type: "boolean", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    RelatedProcessId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notifications_GraduationProcesses_RelatedProcessId",
                        column: x => x.RelatedProcessId,
                        principalTable: "GraduationProcesses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Notifications_Users_RecipientUserId",
                        column: x => x.RecipientUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CourseTakens",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    StudentUserId = table.Column<Guid>(type: "uuid", nullable: false),
                    CourseCodeInTranscript = table.Column<string>(type: "text", nullable: false),
                    CourseNameInTranscript = table.Column<string>(type: "text", nullable: false),
                    MatchedCourseId = table.Column<Guid>(type: "uuid", nullable: true),
                    Grade = table.Column<string>(type: "text", nullable: false),
                    SemesterTaken = table.Column<string>(type: "text", nullable: false),
                    CreditsEarned = table.Column<int>(type: "integer", nullable: false),
                    IsSuccessfullyCompleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseTakens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CourseTakens_Courses_MatchedCourseId",
                        column: x => x.MatchedCourseId,
                        principalTable: "Courses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CourseTakens_Users_StudentUserId",
                        column: x => x.StudentUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RequirementMandatoryCourses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    RequirementSetId = table.Column<Guid>(type: "uuid", nullable: false),
                    CourseId = table.Column<Guid>(type: "uuid", nullable: false),
                    GraduationRequirementSetId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequirementMandatoryCourses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RequirementMandatoryCourses_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RequirementMandatoryCourses_GraduationRequirementSets_Gradu~",
                        column: x => x.GraduationRequirementSetId,
                        principalTable: "GraduationRequirementSets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RankingListCriterias",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    RankingListId = table.Column<Guid>(type: "uuid", nullable: false),
                    CriteriaName = table.Column<string>(type: "text", nullable: false),
                    CriteriaValue = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RankingListCriterias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RankingListCriterias_RankingLists_RankingListId",
                        column: x => x.RankingListId,
                        principalTable: "RankingLists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RankingListEntries",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    RankingListId = table.Column<Guid>(type: "uuid", nullable: false),
                    StudentUserId = table.Column<Guid>(type: "uuid", nullable: false),
                    Rank = table.Column<int>(type: "integer", nullable: false),
                    GpaAtRanking = table.Column<decimal>(type: "numeric", nullable: false),
                    HonourStatus = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RankingListEntries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RankingListEntries_RankingLists_RankingListId",
                        column: x => x.RankingListId,
                        principalTable: "RankingLists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RankingListEntries_Users_StudentUserId",
                        column: x => x.StudentUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TranscriptDatas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    StudentUserId = table.Column<Guid>(type: "uuid", nullable: false),
                    SourceFileAttachmentId = table.Column<Guid>(type: "uuid", nullable: false),
                    ParsingDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ParsedGpa = table.Column<decimal>(type: "numeric", nullable: false),
                    ParsedEcts = table.Column<int>(type: "integer", nullable: false),
                    IsValidForProcessing = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TranscriptDatas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TranscriptDatas_FileAttachments_SourceFileAttachmentId",
                        column: x => x.SourceFileAttachmentId,
                        principalTable: "FileAttachments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TranscriptDatas_Users_StudentUserId",
                        column: x => x.StudentUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Faculties",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("10000000-0000-0000-0000-000000000001"), new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(3970), null, "Faculty of Engineering", null },
                    { new Guid("10000000-0000-0000-0000-000000000002"), new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4000), null, "Faculty of Science", null },
                    { new Guid("10000000-0000-0000-0000-000000000003"), new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4000), null, "Faculty of Architecture", null },
                    { new Guid("10000000-0000-0000-0000-000000000004"), new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4000), null, "School of Foreign Languages", null },
                    { new Guid("10000000-0000-0000-0000-000000000005"), new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4000), null, "Faculty of General Studies", null }
                });

            migrationBuilder.InsertData(
                table: "OperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "SYSTEM_ADMIN", null },
                    { new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "STUDENT", null },
                    { new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "STUDENT_AFFAIRS_STAFF", null },
                    { new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "ADVISOR", null },
                    { new Guid("00000000-0000-0000-0000-000000000005"), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "DEPARTMENT_SECRETARY", null },
                    { new Guid("00000000-0000-0000-0000-000000000006"), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "DEANS_OFFICE_STAFF", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "FirstName", "IsActive", "IsEmailVerified", "LastName", "PasswordHash", "PasswordSalt", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-11111111111a"), 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "systemadmin@university.edu", "System", true, false, "Admin", new byte[] { 113, 202, 15, 151, 31, 243, 89, 79, 69, 250, 196, 254, 240, 8, 166, 217, 224, 123, 170, 26, 170, 6, 220, 235, 189, 73, 191, 124, 243, 25, 43, 148, 178, 46, 180, 87, 11, 182, 215, 100, 166, 78, 213, 218, 144, 148, 249, 145, 43, 160, 246, 235, 53, 2, 253, 202, 52, 229, 86, 85, 189, 218, 118, 6 }, new byte[] { 23, 29, 117, 225, 167, 176, 239, 243, 54, 114, 183, 107, 126, 0, 177, 211, 62, 40, 50, 107, 181, 225, 124, 190, 3, 197, 104, 225, 164, 233, 110, 242, 103, 6, 91, 185, 99, 226, 152, 143, 38, 91, 106, 31, 69, 153, 11, 159, 76, 225, 149, 8, 48, 39, 132, 15, 250, 202, 236, 37, 216, 67, 156, 181, 24, 86, 147, 18, 102, 239, 216, 16, 213, 32, 110, 91, 98, 235, 119, 47, 56, 6, 175, 255, 101, 99, 124, 85, 15, 157, 101, 77, 175, 17, 245, 175, 217, 215, 77, 93, 144, 208, 241, 166, 198, 163, 63, 108, 212, 40, 177, 185, 242, 116, 47, 45, 176, 215, 202, 238, 191, 128, 1, 150, 9, 111, 54, 90 }, "1112223344", null, "systemadmin" },
                    { new Guid("22222222-2222-2222-2222-22222222222a"), 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "student@std.iyte.edu.tr", "Student", true, false, "User", new byte[] { 164, 216, 172, 206, 120, 91, 32, 66, 31, 19, 162, 6, 214, 127, 95, 220, 200, 74, 209, 52, 173, 61, 145, 207, 60, 236, 251, 246, 169, 42, 119, 91, 52, 9, 111, 236, 150, 115, 203, 184, 190, 0, 172, 30, 159, 184, 107, 53, 19, 110, 249, 44, 87, 106, 40, 168, 160, 65, 176, 83, 120, 83, 156, 192 }, new byte[] { 136, 116, 243, 65, 190, 108, 191, 197, 94, 2, 140, 245, 69, 58, 179, 30, 63, 133, 164, 98, 222, 171, 6, 186, 61, 221, 134, 241, 164, 75, 35, 110, 22, 125, 203, 43, 51, 22, 254, 221, 9, 157, 2, 15, 166, 235, 18, 219, 35, 77, 160, 132, 65, 155, 196, 66, 145, 218, 251, 50, 28, 3, 215, 160, 166, 236, 55, 178, 121, 166, 191, 138, 65, 221, 183, 9, 17, 40, 163, 174, 180, 43, 43, 114, 247, 2, 155, 58, 202, 201, 99, 120, 101, 104, 22, 175, 11, 117, 30, 113, 131, 149, 219, 140, 120, 141, 142, 10, 178, 144, 40, 134, 20, 153, 144, 211, 56, 16, 51, 62, 188, 78, 216, 175, 189, 208, 114, 81 }, "2223334455", null, "studentuser" },
                    { new Guid("33333333-3333-3333-3333-33333333333a"), 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "studentaffairs@iyte.edu.tr", "StudentAffairs", true, false, "Staff", new byte[] { 61, 186, 31, 145, 88, 222, 0, 157, 89, 126, 169, 119, 232, 103, 163, 165, 244, 14, 34, 149, 16, 223, 188, 136, 248, 221, 117, 226, 231, 207, 219, 15, 101, 163, 167, 82, 22, 168, 142, 148, 209, 32, 14, 242, 125, 179, 247, 43, 212, 46, 36, 93, 17, 136, 180, 191, 214, 144, 43, 54, 97, 39, 213, 35 }, new byte[] { 123, 169, 225, 151, 247, 64, 137, 16, 124, 29, 24, 213, 131, 163, 187, 25, 75, 39, 22, 73, 98, 94, 165, 195, 197, 72, 97, 207, 112, 91, 77, 98, 165, 137, 10, 189, 238, 204, 110, 62, 86, 228, 224, 145, 88, 250, 141, 108, 6, 65, 11, 254, 239, 16, 183, 8, 238, 17, 251, 106, 55, 63, 188, 238, 183, 16, 92, 41, 60, 88, 254, 14, 241, 74, 55, 114, 105, 113, 199, 10, 58, 250, 68, 71, 181, 179, 106, 179, 241, 103, 59, 205, 190, 188, 251, 125, 76, 108, 132, 19, 116, 43, 210, 191, 37, 3, 191, 116, 68, 107, 100, 51, 246, 220, 1, 140, 173, 23, 14, 173, 106, 123, 24, 128, 82, 97, 216, 239 }, "3334445566", null, "studentaffairs" },
                    { new Guid("40000000-0000-0000-0000-000000000001"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "deniz.yilmaz.s1@std.iyte.edu.tr", "Deniz", false, false, "Yılmaz", new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 }, null, null, "deniz.yilmaz.s1" },
                    { new Guid("40000000-0000-0000-0000-000000000002"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "veli.kaya.s2@std.iyte.edu.tr", "Veli", false, false, "Kaya", new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 }, null, null, "veli.kaya.s2" },
                    { new Guid("40000000-0000-0000-0000-000000000003"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "deniz.kaya.s3@std.iyte.edu.tr", "Deniz", false, false, "Kaya", new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 }, null, null, "deniz.kaya.s3" },
                    { new Guid("40000000-0000-0000-0000-000000000004"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "mehmet.aydin.s4@std.iyte.edu.tr", "Mehmet", false, false, "Aydın", new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 }, null, null, "mehmet.aydin.s4" },
                    { new Guid("40000000-0000-0000-0000-000000000005"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "ayse.dogan.s5@std.iyte.edu.tr", "Ayşe", false, false, "Doğan", new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 }, null, null, "ayse.dogan.s5" },
                    { new Guid("40000000-0000-0000-0000-000000000006"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "murat.celik.s6@std.iyte.edu.tr", "Murat", false, false, "Çelik", new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 }, null, null, "murat.celik.s6" },
                    { new Guid("40000000-0000-0000-0000-000000000007"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "hatice.yilmaz.s7@std.iyte.edu.tr", "Hatice", false, false, "Yılmaz", new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 }, null, null, "hatice.yilmaz.s7" },
                    { new Guid("40000000-0000-0000-0000-000000000008"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "murat.celik.s8@std.iyte.edu.tr", "Murat", false, false, "Çelik", new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 }, null, null, "murat.celik.s8" },
                    { new Guid("40000000-0000-0000-0000-000000000009"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "hatice.kaya.s9@std.iyte.edu.tr", "Hatice", false, false, "Kaya", new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 }, null, null, "hatice.kaya.s9" },
                    { new Guid("40000000-0000-0000-0000-000000000010"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "veli.dogan.s10@std.iyte.edu.tr", "Veli", false, false, "Doğan", new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 }, null, null, "veli.dogan.s10" },
                    { new Guid("40000000-0000-0000-0000-000000000011"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "hatice.demir.s11@std.iyte.edu.tr", "Hatice", false, false, "Demir", new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 }, null, null, "hatice.demir.s11" },
                    { new Guid("40000000-0000-0000-0000-000000000012"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "mustafa.arslan.s12@std.iyte.edu.tr", "Mustafa", false, false, "Arslan", new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 }, null, null, "mustafa.arslan.s12" },
                    { new Guid("40000000-0000-0000-0000-000000000013"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "fatma.sahin.s13@std.iyte.edu.tr", "Fatma", false, false, "Şahin", new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 }, null, null, "fatma.sahin.s13" },
                    { new Guid("40000000-0000-0000-0000-000000000014"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "huseyin.demir.s14@std.iyte.edu.tr", "Hüseyin", false, false, "Demir", new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 }, null, null, "huseyin.demir.s14" },
                    { new Guid("40000000-0000-0000-0000-000000000015"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "hatice.demir.s15@std.iyte.edu.tr", "Hatice", false, false, "Demir", new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 }, null, null, "hatice.demir.s15" },
                    { new Guid("40000000-0000-0000-0000-000000000016"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "murat.demir.s16@std.iyte.edu.tr", "Murat", false, false, "Demir", new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 }, null, null, "murat.demir.s16" },
                    { new Guid("40000000-0000-0000-0000-000000000017"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "ayse.celik.s17@std.iyte.edu.tr", "Ayşe", false, false, "Çelik", new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 }, null, null, "ayse.celik.s17" },
                    { new Guid("40000000-0000-0000-0000-000000000018"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "ali.celik.s18@std.iyte.edu.tr", "Ali", false, false, "Çelik", new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 }, null, null, "ali.celik.s18" },
                    { new Guid("40000000-0000-0000-0000-000000000019"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "hatice.dogan.s19@std.iyte.edu.tr", "Hatice", false, false, "Doğan", new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 }, null, null, "hatice.dogan.s19" },
                    { new Guid("40000000-0000-0000-0000-000000000020"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "veli.sahin.s20@std.iyte.edu.tr", "Veli", false, false, "Şahin", new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 }, null, null, "veli.sahin.s20" },
                    { new Guid("40000000-0000-0000-0000-000000000021"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "ebru.dogan.s21@std.iyte.edu.tr", "Ebru", false, false, "Doğan", new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 }, null, null, "ebru.dogan.s21" },
                    { new Guid("40000000-0000-0000-0000-000000000022"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "mehmet.kaya.s22@std.iyte.edu.tr", "Mehmet", false, false, "Kaya", new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 }, null, null, "mehmet.kaya.s22" },
                    { new Guid("40000000-0000-0000-0000-000000000023"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "fatma.yilmaz.s23@std.iyte.edu.tr", "Fatma", false, false, "Yılmaz", new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 }, null, null, "fatma.yilmaz.s23" },
                    { new Guid("40000000-0000-0000-0000-000000000024"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "mehmet.dogan.s24@std.iyte.edu.tr", "Mehmet", false, false, "Doğan", new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 }, null, null, "mehmet.dogan.s24" },
                    { new Guid("40000000-0000-0000-0000-000000000025"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "fatma.dogan.s25@std.iyte.edu.tr", "Fatma", false, false, "Doğan", new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 }, null, null, "fatma.dogan.s25" },
                    { new Guid("40000000-0000-0000-0000-000000000026"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "emre.dogan.s26@std.iyte.edu.tr", "Emre", false, false, "Doğan", new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 }, null, null, "emre.dogan.s26" },
                    { new Guid("40000000-0000-0000-0000-000000000027"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "ebru.arslan.s27@std.iyte.edu.tr", "Ebru", false, false, "Arslan", new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 }, null, null, "ebru.arslan.s27" },
                    { new Guid("40000000-0000-0000-0000-000000000028"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "mustafa.ozturk.s28@std.iyte.edu.tr", "Mustafa", false, false, "Öztürk", new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 }, null, null, "mustafa.ozturk.s28" },
                    { new Guid("40000000-0000-0000-0000-000000000029"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "ayse.sahin.s29@std.iyte.edu.tr", "Ayşe", false, false, "Şahin", new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 }, null, null, "ayse.sahin.s29" },
                    { new Guid("40000000-0000-0000-0000-000000000030"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "veli.aydin.s30@std.iyte.edu.tr", "Veli", false, false, "Aydın", new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 }, null, null, "veli.aydin.s30" },
                    { new Guid("40000000-0000-0000-0000-000000000031"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "ebru.yildiz.s31@std.iyte.edu.tr", "Ebru", false, false, "Yıldız", new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 }, null, null, "ebru.yildiz.s31" },
                    { new Guid("40000000-0000-0000-0000-000000000032"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "ali.celik.s32@std.iyte.edu.tr", "Ali", false, false, "Çelik", new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 }, null, null, "ali.celik.s32" },
                    { new Guid("40000000-0000-0000-0000-000000000033"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "selin.celik.s33@std.iyte.edu.tr", "Selin", false, false, "Çelik", new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 }, null, null, "selin.celik.s33" },
                    { new Guid("40000000-0000-0000-0000-000000000034"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "burak.aydin.s34@std.iyte.edu.tr", "Burak", false, false, "Aydın", new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 }, null, null, "burak.aydin.s34" },
                    { new Guid("40000000-0000-0000-0000-000000000035"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "ebru.demir.s35@std.iyte.edu.tr", "Ebru", false, false, "Demir", new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 }, null, null, "ebru.demir.s35" },
                    { new Guid("40000000-0000-0000-0000-000000000036"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "mehmet.demir.s36@std.iyte.edu.tr", "Mehmet", false, false, "Demir", new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 }, null, null, "mehmet.demir.s36" },
                    { new Guid("40000000-0000-0000-0000-000000000037"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "ebru.arslan.s37@std.iyte.edu.tr", "Ebru", false, false, "Arslan", new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 }, null, null, "ebru.arslan.s37" },
                    { new Guid("40000000-0000-0000-0000-000000000038"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "murat.celik.s38@std.iyte.edu.tr", "Murat", false, false, "Çelik", new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 }, null, null, "murat.celik.s38" },
                    { new Guid("40000000-0000-0000-0000-000000000039"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "hatice.yilmaz.s39@std.iyte.edu.tr", "Hatice", false, false, "Yılmaz", new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 }, null, null, "hatice.yilmaz.s39" },
                    { new Guid("40000000-0000-0000-0000-000000000040"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "emre.aydin.s40@std.iyte.edu.tr", "Emre", false, false, "Aydın", new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 }, null, null, "emre.aydin.s40" },
                    { new Guid("40000000-0000-0000-0000-000000000041"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "ayse.yilmaz.p1@iyte.edu.tr", "Ayşe", true, true, "Yılmaz", new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 }, null, null, "ayse.yilmaz.p1" },
                    { new Guid("40000000-0000-0000-0000-000000000042"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "mehmet.kaya.p2@iyte.edu.tr", "Mehmet", true, true, "Kaya", new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 }, null, null, "mehmet.kaya.p2" },
                    { new Guid("40000000-0000-0000-0000-000000000043"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "zeynep.demir.p3@iyte.edu.tr", "Zeynep", true, true, "Demir", new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 }, null, null, "zeynep.demir.p3" },
                    { new Guid("40000000-0000-0000-0000-000000000044"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "ahmet.celik.p4@iyte.edu.tr", "Ahmet", true, true, "Çelik", new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 }, null, null, "ahmet.celik.p4" },
                    { new Guid("40000000-0000-0000-0000-000000000045"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "mustafa.sahin.p5@iyte.edu.tr", "Mustafa", true, true, "Şahin", new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 }, null, null, "mustafa.sahin.p5" },
                    { new Guid("40000000-0000-0000-0000-000000000046"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "fatma.ozturk.p6@iyte.edu.tr", "Fatma", true, true, "Öztürk", new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 }, null, null, "fatma.ozturk.p6" },
                    { new Guid("40000000-0000-0000-0000-000000000047"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "ali.yildiz.p7@iyte.edu.tr", "Ali", true, true, "Yıldız", new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 }, null, null, "ali.yildiz.p7" },
                    { new Guid("40000000-0000-0000-0000-000000000048"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "huseyin.aydin.p8@iyte.edu.tr", "Hüseyin", true, true, "Aydın", new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 }, null, null, "huseyin.aydin.p8" },
                    { new Guid("40000000-0000-0000-0000-000000000049"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "elif.arslan.p9@iyte.edu.tr", "Elif", true, true, "Arslan", new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 }, null, null, "elif.arslan.p9" },
                    { new Guid("40000000-0000-0000-0000-000000000050"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "veli.dogan.p10@iyte.edu.tr", "Veli", true, true, "Doğan", new byte[] { 19, 100, 165, 111, 220, 36, 94, 66, 5, 105, 212, 218, 227, 91, 135, 72, 43, 164, 184, 22, 248, 153, 15, 94, 95, 169, 168, 102, 94, 196, 192, 118, 181, 53, 132, 192, 81, 67, 44, 241, 164, 78, 5, 214, 128, 66, 216, 198, 205, 122, 230, 216, 51, 59, 135, 30, 37, 179, 28, 121, 110, 48, 100, 38, 133, 58, 8, 86, 236, 152, 135, 173, 196, 18, 31, 138, 63, 186, 202, 255, 134, 88, 162, 15, 58, 114, 6, 182, 99, 105, 214, 53, 243, 5, 171, 183, 100, 175, 246, 75, 225, 177, 79, 186, 46, 227, 204, 12, 2, 90, 187, 102, 169, 71, 243, 58, 95, 60, 238, 142, 86, 37, 111, 60, 58, 185, 187, 59 }, new byte[] { 191, 43, 168, 94, 128, 229, 69, 68, 238, 123, 49, 148, 143, 36, 144, 185, 29, 132, 244, 124, 122, 237, 152, 85, 161, 207, 40, 97, 13, 116, 3, 31, 14, 10, 78, 156, 207, 70, 60, 66, 50, 46, 37, 255, 213, 191, 218, 93, 99, 65, 172, 80, 44, 158, 196, 207, 234, 156, 183, 106, 154, 235, 34, 130 }, null, null, "veli.dogan.p10" },
                    { new Guid("44444444-4444-4444-4444-44444444444a"), 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "advisor@iyte.edu.tr", "Advisor", true, false, "User", new byte[] { 86, 23, 214, 69, 159, 155, 79, 218, 61, 202, 124, 32, 101, 21, 59, 249, 71, 235, 162, 29, 134, 205, 157, 151, 24, 215, 67, 208, 149, 245, 127, 12, 147, 1, 27, 218, 117, 85, 224, 162, 160, 42, 123, 91, 34, 163, 76, 105, 74, 240, 197, 209, 56, 95, 98, 137, 217, 240, 65, 105, 42, 106, 77, 107 }, new byte[] { 119, 219, 234, 222, 199, 116, 88, 237, 232, 227, 221, 95, 94, 45, 169, 118, 179, 171, 74, 28, 118, 33, 254, 34, 211, 131, 206, 35, 220, 230, 1, 92, 157, 183, 136, 194, 134, 106, 205, 236, 96, 126, 152, 7, 48, 9, 55, 149, 95, 124, 32, 13, 107, 75, 11, 52, 12, 97, 64, 178, 1, 8, 45, 238, 30, 25, 185, 252, 81, 163, 231, 103, 40, 230, 8, 46, 17, 28, 218, 184, 158, 177, 26, 209, 216, 220, 132, 236, 137, 125, 140, 227, 218, 99, 132, 222, 121, 165, 188, 130, 176, 123, 203, 141, 166, 168, 144, 161, 35, 95, 150, 100, 97, 180, 192, 24, 15, 113, 28, 183, 58, 158, 153, 126, 18, 254, 243, 207 }, "4445556677", null, "advisoruser" },
                    { new Guid("55555555-5555-5555-5555-55555555555a"), 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "deptsecretary@iyte.edu.tr", "Department", true, false, "Secretary", new byte[] { 213, 17, 119, 212, 22, 232, 128, 83, 161, 47, 72, 235, 148, 47, 143, 201, 47, 43, 24, 190, 183, 47, 242, 172, 159, 16, 203, 146, 116, 164, 80, 239, 21, 1, 101, 81, 65, 105, 120, 79, 127, 10, 199, 7, 7, 164, 23, 76, 216, 85, 70, 47, 139, 180, 190, 115, 51, 174, 162, 132, 127, 248, 69, 180 }, new byte[] { 126, 250, 143, 208, 163, 177, 56, 82, 10, 125, 194, 236, 51, 245, 49, 182, 76, 58, 28, 2, 68, 21, 178, 211, 170, 205, 247, 163, 164, 164, 116, 68, 83, 121, 187, 174, 75, 139, 212, 190, 248, 212, 172, 231, 115, 182, 150, 226, 240, 224, 26, 198, 157, 117, 97, 196, 157, 127, 50, 144, 192, 250, 96, 140, 197, 105, 129, 173, 192, 42, 121, 111, 176, 7, 145, 27, 170, 48, 169, 38, 50, 78, 102, 237, 82, 196, 206, 53, 67, 20, 106, 228, 167, 184, 10, 21, 105, 125, 250, 72, 63, 213, 239, 6, 133, 231, 239, 141, 78, 134, 121, 63, 33, 209, 95, 129, 62, 216, 93, 155, 87, 164, 71, 109, 101, 25, 225, 235 }, "5556667788", null, "deptsecretary" },
                    { new Guid("66666666-6666-6666-6666-66666666666a"), 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "deansoffice@iyte.edu.tr", "DeansOffice", true, false, "Staff", new byte[] { 119, 50, 205, 132, 162, 134, 164, 96, 24, 158, 221, 130, 250, 242, 243, 105, 226, 86, 122, 13, 243, 250, 223, 182, 227, 136, 170, 9, 43, 60, 27, 146, 184, 151, 168, 149, 29, 133, 245, 153, 213, 126, 176, 64, 4, 254, 152, 16, 153, 150, 162, 81, 51, 175, 56, 15, 199, 232, 185, 232, 91, 165, 254, 80 }, new byte[] { 114, 11, 167, 235, 171, 40, 191, 118, 52, 148, 178, 186, 160, 217, 83, 187, 180, 252, 202, 32, 222, 146, 156, 197, 187, 150, 99, 48, 53, 197, 52, 106, 247, 156, 158, 208, 51, 19, 219, 33, 100, 158, 75, 49, 61, 197, 200, 149, 100, 97, 172, 170, 203, 165, 122, 128, 100, 179, 100, 174, 186, 25, 142, 168, 138, 96, 133, 195, 91, 137, 0, 94, 216, 21, 26, 184, 232, 58, 12, 44, 88, 187, 189, 172, 241, 101, 14, 91, 250, 212, 88, 150, 63, 244, 231, 85, 7, 31, 218, 195, 250, 154, 74, 112, 162, 174, 166, 45, 93, 182, 164, 33, 52, 106, 29, 225, 236, 142, 250, 17, 130, 184, 137, 196, 19, 111, 6, 147 }, "6667778899", null, "deansoffice" }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "FacultyId", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("20000000-0000-0000-0000-000000000001"), new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4030), null, new Guid("10000000-0000-0000-0000-000000000001"), "Computer Engineering", null },
                    { new Guid("20000000-0000-0000-0000-000000000002"), new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4030), null, new Guid("10000000-0000-0000-0000-000000000001"), "Electrical-Electronics Engineering", null },
                    { new Guid("20000000-0000-0000-0000-000000000003"), new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4040), null, new Guid("10000000-0000-0000-0000-000000000001"), "Mechanical Engineering", null },
                    { new Guid("20000000-0000-0000-0000-000000000004"), new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4040), null, new Guid("10000000-0000-0000-0000-000000000001"), "Civil Engineering", null },
                    { new Guid("20000000-0000-0000-0000-000000000005"), new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4040), null, new Guid("10000000-0000-0000-0000-000000000001"), "Environmental Engineering", null },
                    { new Guid("20000000-0000-0000-0000-000000000006"), new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4040), null, new Guid("10000000-0000-0000-0000-000000000001"), "Chemical Engineering", null },
                    { new Guid("20000000-0000-0000-0000-000000000007"), new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4040), null, new Guid("10000000-0000-0000-0000-000000000001"), "Food Engineering", null },
                    { new Guid("20000000-0000-0000-0000-000000000008"), new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4040), null, new Guid("10000000-0000-0000-0000-000000000001"), "Materials Science and Engineering", null },
                    { new Guid("20000000-0000-0000-0000-000000000009"), new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4050), null, new Guid("10000000-0000-0000-0000-000000000001"), "Bioengineering", null },
                    { new Guid("20000000-0000-0000-0000-000000000010"), new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4050), null, new Guid("10000000-0000-0000-0000-000000000001"), "Energy Systems Engineering", null },
                    { new Guid("20000000-0000-0000-0000-000000000011"), new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4050), null, new Guid("10000000-0000-0000-0000-000000000001"), "Photonics", null },
                    { new Guid("20000000-0000-0000-0000-000000000012"), new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4050), null, new Guid("10000000-0000-0000-0000-000000000002"), "Physics", null },
                    { new Guid("20000000-0000-0000-0000-000000000013"), new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4060), null, new Guid("10000000-0000-0000-0000-000000000002"), "Chemistry", null },
                    { new Guid("20000000-0000-0000-0000-000000000014"), new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4060), null, new Guid("10000000-0000-0000-0000-000000000002"), "Mathematics", null },
                    { new Guid("20000000-0000-0000-0000-000000000015"), new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4060), null, new Guid("10000000-0000-0000-0000-000000000002"), "Molecular Biology and Genetics", null },
                    { new Guid("20000000-0000-0000-0000-000000000016"), new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4060), null, new Guid("10000000-0000-0000-0000-000000000003"), "Architecture", null },
                    { new Guid("20000000-0000-0000-0000-000000000017"), new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4060), null, new Guid("10000000-0000-0000-0000-000000000003"), "Urban and Regional Planning", null },
                    { new Guid("20000000-0000-0000-0000-000000000018"), new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4070), null, new Guid("10000000-0000-0000-0000-000000000003"), "Industrial Design", null },
                    { new Guid("20000000-0000-0000-0000-000000000019"), new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4070), null, new Guid("10000000-0000-0000-0000-000000000004"), "Foreign Languages", null },
                    { new Guid("20000000-0000-0000-0000-000000000020"), new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4070), null, new Guid("10000000-0000-0000-0000-000000000005"), "General Culture Courses", null }
                });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "DepartmentId", "FacultyId", "StaffIdentificationNumber", "Title", "UpdatedDate" },
                values: new object[] { new Guid("40000000-0000-0000-0000-000000000044"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, null, new Guid("10000000-0000-0000-0000-000000000001"), "STAFF004", "Dean's Office Staff", null });

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
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, new Guid("00000000-0000-0000-0000-000000000001"), null, new Guid("11111111-1111-1111-1111-11111111111a") },
                    { new Guid("aca7b8f7-260e-49c5-a889-d9a16e44a7e6"), new DateTime(2025, 5, 19, 16, 47, 30, 866, DateTimeKind.Utc).AddTicks(2870), null, new Guid("00000000-0000-0000-0000-000000000004"), null, new Guid("40000000-0000-0000-0000-000000000050") },
                    { new Guid("b394b56f-9c21-4b18-845f-7692163fa8c8"), new DateTime(2025, 5, 19, 16, 47, 30, 866, DateTimeKind.Utc).AddTicks(2720), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000012") },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("22222222-2222-2222-2222-22222222222a") },
                    { new Guid("bf897ac2-5ecd-48c9-8ab7-b9aec7bb0640"), new DateTime(2025, 5, 19, 16, 47, 30, 866, DateTimeKind.Utc).AddTicks(2840), null, new Guid("00000000-0000-0000-0000-000000000004"), null, new Guid("40000000-0000-0000-0000-000000000042") },
                    { new Guid("c200d32b-1165-4a34-88c8-7ee20eecacdd"), new DateTime(2025, 5, 19, 16, 47, 30, 866, DateTimeKind.Utc).AddTicks(2690), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000003") },
                    { new Guid("c379c319-a5f5-46c7-b1e3-9d2105c3a755"), new DateTime(2025, 5, 19, 16, 47, 30, 866, DateTimeKind.Utc).AddTicks(2780), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000027") },
                    { new Guid("c42fc6f9-deff-4fd7-80c0-e3e0790b41cd"), new DateTime(2025, 5, 19, 16, 47, 30, 866, DateTimeKind.Utc).AddTicks(2760), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000022") },
                    { new Guid("ca8d4a29-a9a0-4cb2-bb3f-1eb260978c7b"), new DateTime(2025, 5, 19, 16, 47, 30, 866, DateTimeKind.Utc).AddTicks(2850), null, new Guid("00000000-0000-0000-0000-000000000006"), null, new Guid("40000000-0000-0000-0000-000000000044") },
                    { new Guid("cba642e5-5f07-46d9-954b-436b934ea7d5"), new DateTime(2025, 5, 19, 16, 47, 30, 866, DateTimeKind.Utc).AddTicks(2800), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000031") },
                    { new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, new Guid("00000000-0000-0000-0000-000000000003"), null, new Guid("33333333-3333-3333-3333-33333333333a") },
                    { new Guid("ccd1833b-70eb-4811-8d83-5de1179c9090"), new DateTime(2025, 5, 19, 16, 47, 30, 866, DateTimeKind.Utc).AddTicks(2740), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000015") },
                    { new Guid("d4e8f068-0a9c-4e92-b993-1eb36d52d77c"), new DateTime(2025, 5, 19, 16, 47, 30, 866, DateTimeKind.Utc).AddTicks(2700), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000006") },
                    { new Guid("d6214e85-39b5-4e49-a1d1-f110ade0413b"), new DateTime(2025, 5, 19, 16, 47, 30, 866, DateTimeKind.Utc).AddTicks(2840), null, new Guid("00000000-0000-0000-0000-000000000005"), null, new Guid("40000000-0000-0000-0000-000000000043") },
                    { new Guid("dddddddd-dddd-dddd-dddd-dddddddddddd"), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, new Guid("00000000-0000-0000-0000-000000000004"), null, new Guid("44444444-4444-4444-4444-44444444444a") },
                    { new Guid("e8a8bb91-eb00-4728-8609-b964ab9cb0d9"), new DateTime(2025, 5, 19, 16, 47, 30, 866, DateTimeKind.Utc).AddTicks(2690), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000002") },
                    { new Guid("eb200b6e-8ded-4632-9946-4d6b650c11d1"), new DateTime(2025, 5, 19, 16, 47, 30, 866, DateTimeKind.Utc).AddTicks(2750), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000018") },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, new Guid("00000000-0000-0000-0000-000000000005"), null, new Guid("55555555-5555-5555-5555-55555555555a") },
                    { new Guid("f43b6f6f-8e0f-4560-b89b-209803e15725"), new DateTime(2025, 5, 19, 16, 47, 30, 866, DateTimeKind.Utc).AddTicks(2780), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000026") },
                    { new Guid("f66ea9c5-cc96-42e7-b97e-2e622d2a7bbd"), new DateTime(2025, 5, 19, 16, 47, 30, 866, DateTimeKind.Utc).AddTicks(2700), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000005") },
                    { new Guid("f749eb0a-d870-4637-83e7-c137f77f9be3"), new DateTime(2025, 5, 19, 16, 47, 30, 866, DateTimeKind.Utc).AddTicks(2740), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000017") },
                    { new Guid("fbb112ef-3787-4572-b222-b0aa25d3e33b"), new DateTime(2025, 5, 19, 16, 47, 30, 866, DateTimeKind.Utc).AddTicks(2810), null, new Guid("00000000-0000-0000-0000-000000000002"), null, new Guid("40000000-0000-0000-0000-000000000035") },
                    { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, new Guid("00000000-0000-0000-0000-000000000006"), null, new Guid("66666666-6666-6666-6666-66666666666a") }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CourseCode", "CourseName", "CourseType", "CreatedDate", "DeletedDate", "DepartmentId", "Ects", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("30000000-0000-0000-0000-000000000001"), "MATH 141", "Calculus I", 1, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4720), null, new Guid("20000000-0000-0000-0000-000000000014"), 5, null },
                    { new Guid("30000000-0000-0000-0000-000000000002"), "PHYS 121", "Physics I", 1, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4730), null, new Guid("20000000-0000-0000-0000-000000000012"), 7, null },
                    { new Guid("30000000-0000-0000-0000-000000000003"), "CENG 111", "Introduction to Computer Engineering", 1, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4730), null, new Guid("20000000-0000-0000-0000-000000000001"), 5, null },
                    { new Guid("30000000-0000-0000-0000-000000000004"), "CENG 113", "Introduction to Programming", 1, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4730), null, new Guid("20000000-0000-0000-0000-000000000001"), 6, null },
                    { new Guid("30000000-0000-0000-0000-000000000005"), "CENG 115", "Discrete Structures", 1, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4730), null, new Guid("20000000-0000-0000-0000-000000000001"), 5, null },
                    { new Guid("30000000-0000-0000-0000-000000000006"), "ENG 101", "Academic English I", 1, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4740), null, new Guid("20000000-0000-0000-0000-000000000019"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000007"), "MATH 142", "Calculus II", 1, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4740), null, new Guid("20000000-0000-0000-0000-000000000014"), 6, null },
                    { new Guid("30000000-0000-0000-0000-000000000008"), "PHYS 122", "Physics II", 1, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4740), null, new Guid("20000000-0000-0000-0000-000000000012"), 8, null },
                    { new Guid("30000000-0000-0000-0000-000000000009"), "MATH 144", "Finite Mathematics", 1, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4740), null, new Guid("20000000-0000-0000-0000-000000000014"), 5, null },
                    { new Guid("30000000-0000-0000-0000-000000000010"), "CENG 112", "Data Structures", 1, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4750), null, new Guid("20000000-0000-0000-0000-000000000001"), 5, null },
                    { new Guid("30000000-0000-0000-0000-000000000011"), "ECON 106", "Principles of Economics", 1, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4750), null, new Guid("20000000-0000-0000-0000-000000000020"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000012"), "ENG 102", "Academic English II", 1, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4750), null, new Guid("20000000-0000-0000-0000-000000000019"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000013"), "GCC 101", "Career Planning and Development", 1, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4750), null, new Guid("20000000-0000-0000-0000-000000000020"), 0, null },
                    { new Guid("30000000-0000-0000-0000-000000000014"), "CENG 211", "Fundamentals of Programming", 1, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4760), null, new Guid("20000000-0000-0000-0000-000000000001"), 5, null },
                    { new Guid("30000000-0000-0000-0000-000000000015"), "CENG 213", "Theory of Computation", 1, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4760), null, new Guid("20000000-0000-0000-0000-000000000001"), 5, null },
                    { new Guid("30000000-0000-0000-0000-000000000016"), "CENG 215", "Circuits and Electronics", 1, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4760), null, new Guid("20000000-0000-0000-0000-000000000001"), 6, null },
                    { new Guid("30000000-0000-0000-0000-000000000017"), "MATH 255", "Differential Equations", 1, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4760), null, new Guid("20000000-0000-0000-0000-000000000014"), 6, null },
                    { new Guid("30000000-0000-0000-0000-000000000018"), "HIST 201", "History of Turkish Republic I", 1, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4770), null, new Guid("20000000-0000-0000-0000-000000000020"), 2, null },
                    { new Guid("30000000-0000-0000-0000-000000000019"), "TURK 201", "Turkish Language I", 1, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4770), null, new Guid("20000000-0000-0000-0000-000000000020"), 2, null },
                    { new Guid("30000000-0000-0000-0000-000000000020"), "HIST 203", "History of Turkish Revolution I", 1, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4770), null, new Guid("20000000-0000-0000-0000-000000000020"), 2, null },
                    { new Guid("30000000-0000-0000-0000-000000000021"), "TURK 203", "Turkish for International Students I", 1, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4770), null, new Guid("20000000-0000-0000-0000-000000000020"), 2, null },
                    { new Guid("30000000-0000-0000-0000-000000000022"), "CENG 212", "Programming Language Concepts", 1, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4780), null, new Guid("20000000-0000-0000-0000-000000000001"), 5, null },
                    { new Guid("30000000-0000-0000-0000-000000000023"), "CENG 214", "Logic Design", 1, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4780), null, new Guid("20000000-0000-0000-0000-000000000001"), 6, null },
                    { new Guid("30000000-0000-0000-0000-000000000024"), "CENG 216", "Numerical Computing", 1, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4780), null, new Guid("20000000-0000-0000-0000-000000000001"), 5, null },
                    { new Guid("30000000-0000-0000-0000-000000000025"), "CENG 218", "Analysis and Design of Algorithms", 1, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4780), null, new Guid("20000000-0000-0000-0000-000000000001"), 5, null },
                    { new Guid("30000000-0000-0000-0000-000000000026"), "CENG 222", "Probability and Statistics", 1, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4790), null, new Guid("20000000-0000-0000-0000-000000000001"), 5, null },
                    { new Guid("30000000-0000-0000-0000-000000000027"), "HIST 202", "History of Turkish Republic II", 1, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4790), null, new Guid("20000000-0000-0000-0000-000000000020"), 2, null },
                    { new Guid("30000000-0000-0000-0000-000000000028"), "TURK 202", "Turkish Language II", 1, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4790), null, new Guid("20000000-0000-0000-0000-000000000020"), 2, null },
                    { new Guid("30000000-0000-0000-0000-000000000029"), "HIST 204", "History of Turkish Revolution II", 1, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4790), null, new Guid("20000000-0000-0000-0000-000000000020"), 2, null },
                    { new Guid("30000000-0000-0000-0000-000000000030"), "TURK 204", "Turkish for International Students II", 1, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4800), null, new Guid("20000000-0000-0000-0000-000000000020"), 2, null },
                    { new Guid("30000000-0000-0000-0000-000000000031"), "CENG 311", "Computer Architecture", 1, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4800), null, new Guid("20000000-0000-0000-0000-000000000001"), 8, null },
                    { new Guid("30000000-0000-0000-0000-000000000032"), "CENG 315", "Information Management", 1, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4810), null, new Guid("20000000-0000-0000-0000-000000000001"), 6, null },
                    { new Guid("30000000-0000-0000-0000-000000000033"), "CENG 312", "Computer Networks", 1, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4810), null, new Guid("20000000-0000-0000-0000-000000000001"), 6, null },
                    { new Guid("30000000-0000-0000-0000-000000000034"), "CENG 316", "Software Engineering", 1, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4810), null, new Guid("20000000-0000-0000-0000-000000000001"), 6, null },
                    { new Guid("30000000-0000-0000-0000-000000000035"), "CENG 318", "Human-Computer Interaction", 1, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4820), null, new Guid("20000000-0000-0000-0000-000000000001"), 6, null },
                    { new Guid("30000000-0000-0000-0000-000000000036"), "CENG 322", "Operating Systems", 1, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4820), null, new Guid("20000000-0000-0000-0000-000000000001"), 8, null },
                    { new Guid("30000000-0000-0000-0000-000000000037"), "CENG 411", "Professionalism in Computer Engineering", 1, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4820), null, new Guid("20000000-0000-0000-0000-000000000001"), 6, null },
                    { new Guid("30000000-0000-0000-0000-000000000038"), "CENG 415", "Undergraduate Thesis and Seminar I", 1, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4820), null, new Guid("20000000-0000-0000-0000-000000000001"), 8, null },
                    { new Guid("30000000-0000-0000-0000-000000000039"), "CENG 416", "Undergraduate Thesis and Seminar II", 1, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4830), null, new Guid("20000000-0000-0000-0000-000000000001"), 8, null },
                    { new Guid("30000000-0000-0000-0000-000000000040"), "CENG 370", "Mainframe Computers", 2, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4830), null, new Guid("20000000-0000-0000-0000-000000000001"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000041"), "CENG 381", "Stochastic Processes", 2, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4830), null, new Guid("20000000-0000-0000-0000-000000000001"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000042"), "CENG 382", "Information Theory", 2, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4830), null, new Guid("20000000-0000-0000-0000-000000000001"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000043"), "CENG 383", "Real-Time Systems", 2, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4840), null, new Guid("20000000-0000-0000-0000-000000000001"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000044"), "CENG 384", "Microprocessors", 2, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4840), null, new Guid("20000000-0000-0000-0000-000000000001"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000045"), "CENG 385", "Mathematical Logic", 2, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4840), null, new Guid("20000000-0000-0000-0000-000000000001"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000046"), "CENG 386", "Fuzzy Logic Systems", 2, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4840), null, new Guid("20000000-0000-0000-0000-000000000001"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000047"), "CENG 388", "Web Programming", 2, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4840), null, new Guid("20000000-0000-0000-0000-000000000001"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000048"), "CENG 389", "Mobile Application Development", 2, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4850), null, new Guid("20000000-0000-0000-0000-000000000001"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000049"), "CENG 390", "Cloud Computing", 2, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4850), null, new Guid("20000000-0000-0000-0000-000000000001"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000050"), "CENG 391", "Introduction to Image Understanding", 2, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4850), null, new Guid("20000000-0000-0000-0000-000000000001"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000051"), "CENG 421", "Computer Network Programming", 2, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4850), null, new Guid("20000000-0000-0000-0000-000000000001"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000052"), "CENG 422", "Computer Network Design and Management", 2, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4860), null, new Guid("20000000-0000-0000-0000-000000000001"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000053"), "CENG 431", "Software Systems Development", 2, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4860), null, new Guid("20000000-0000-0000-0000-000000000001"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000054"), "CENG 432", "Fundamentals of Enterprise Application Development", 2, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4860), null, new Guid("20000000-0000-0000-0000-000000000001"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000055"), "CENG 433", "Scalable Software Development for the Internet", 2, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4870), null, new Guid("20000000-0000-0000-0000-000000000001"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000056"), "CENG 434", "Enterprise Application Integrations", 2, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4870), null, new Guid("20000000-0000-0000-0000-000000000001"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000057"), "CENG 435", "Database Management System Design and Implementation", 2, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4870), null, new Guid("20000000-0000-0000-0000-000000000001"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000058"), "CENG 436", "Distributed Information Management", 2, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4870), null, new Guid("20000000-0000-0000-0000-000000000001"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000059"), "CENG 437", "Software Quality Management", 2, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4870), null, new Guid("20000000-0000-0000-0000-000000000001"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000060"), "CENG 441", "Introduction to Parallel Programming", 2, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4880), null, new Guid("20000000-0000-0000-0000-000000000001"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000061"), "CENG 442", "Multi-Core Architectures and Operating Systems", 2, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4880), null, new Guid("20000000-0000-0000-0000-000000000001"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000062"), "CENG 443", "Heterogeneous Parallel Programming", 2, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4890), null, new Guid("20000000-0000-0000-0000-000000000001"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000063"), "CENG 444", "Parallel Programming Patterns", 2, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4890), null, new Guid("20000000-0000-0000-0000-000000000001"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000064"), "CENG 451", "Advanced Digital System Design", 2, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4890), null, new Guid("20000000-0000-0000-0000-000000000001"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000065"), "CENG 452", "Software Development for Embedded Systems", 2, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4890), null, new Guid("20000000-0000-0000-0000-000000000001"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000066"), "CENG 461", "Artificial Intelligence", 2, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4900), null, new Guid("20000000-0000-0000-0000-000000000001"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000067"), "CENG 462", "Soft Computing", 2, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4900), null, new Guid("20000000-0000-0000-0000-000000000001"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000068"), "CENG 463", "Introduction to Machine Learning", 2, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4900), null, new Guid("20000000-0000-0000-0000-000000000001"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000069"), "CENG 464", "Text Mining", 2, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4900), null, new Guid("20000000-0000-0000-0000-000000000001"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000070"), "CENG 465", "Principles of Data-Intensive Systems", 2, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4900), null, new Guid("20000000-0000-0000-0000-000000000001"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000071"), "CENG 471", "Cryptography", 2, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4910), null, new Guid("20000000-0000-0000-0000-000000000001"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000072"), "CENG 472", "Computer Network Security", 2, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4910), null, new Guid("20000000-0000-0000-0000-000000000001"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000073"), "CENG 473", "Information and Communication Technologies Security", 2, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4910), null, new Guid("20000000-0000-0000-0000-000000000001"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000074"), "CENG 481", "Theoretical Approaches in Computer Science", 2, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4910), null, new Guid("20000000-0000-0000-0000-000000000001"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000075"), "CENG 482", "Evolutionary Computation", 2, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4920), null, new Guid("20000000-0000-0000-0000-000000000001"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000076"), "CENG 483", "Behavioral Robotics", 2, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4920), null, new Guid("20000000-0000-0000-0000-000000000001"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000077"), "CENG 484", "Data Mining", 2, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4920), null, new Guid("20000000-0000-0000-0000-000000000001"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000078"), "CENG 485", "Entrepreneurship in Information Technologies", 2, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4920), null, new Guid("20000000-0000-0000-0000-000000000001"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000079"), "CENG 486", "Entrepreneurship for Smart Businesses", 2, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4930), null, new Guid("20000000-0000-0000-0000-000000000001"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000080"), "CENG 487", "Introduction to Computer Graphics", 2, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4930), null, new Guid("20000000-0000-0000-0000-000000000001"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000081"), "CENG 488", "Computer Graphics", 2, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4930), null, new Guid("20000000-0000-0000-0000-000000000001"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000082"), "ART 201", "Drawing-Sketch", 3, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4930), null, new Guid("20000000-0000-0000-0000-000000000020"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000083"), "ART 202", "Painting", 3, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4940), null, new Guid("20000000-0000-0000-0000-000000000020"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000084"), "ART 203", "Sculpture", 3, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4940), null, new Guid("20000000-0000-0000-0000-000000000020"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000085"), "ART 204", "Artistic Ceramics", 3, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4940), null, new Guid("20000000-0000-0000-0000-000000000020"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000086"), "ART 205", "Color Photography", 3, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4940), null, new Guid("20000000-0000-0000-0000-000000000020"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000087"), "ART 206", "Introduction to Sound Production and Design", 3, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4950), null, new Guid("20000000-0000-0000-0000-000000000020"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000088"), "ART 210", "Western Music and Aesthetics", 3, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4950), null, new Guid("20000000-0000-0000-0000-000000000020"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000089"), "ART 211", "Music Workshop", 3, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4950), null, new Guid("20000000-0000-0000-0000-000000000020"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000090"), "ART 212", "Introduction to Harmony", 3, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4950), null, new Guid("20000000-0000-0000-0000-000000000020"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000091"), "ART 230", "Dance Education", 3, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4960), null, new Guid("20000000-0000-0000-0000-000000000020"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000092"), "ART 231", "Traditional Folk Dances I", 3, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4960), null, new Guid("20000000-0000-0000-0000-000000000020"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000093"), "ART 232", "Traditional Folk Dances II", 3, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4960), null, new Guid("20000000-0000-0000-0000-000000000020"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000094"), "CHN 201", "Basic Chinese I", 3, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4970), null, new Guid("20000000-0000-0000-0000-000000000020"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000095"), "FREN 201", "Basic French I", 3, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4970), null, new Guid("20000000-0000-0000-0000-000000000020"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000096"), "FREN 202", "Basic French II", 3, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4970), null, new Guid("20000000-0000-0000-0000-000000000020"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000097"), "FREN 203", "Intermediate French I", 3, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4970), null, new Guid("20000000-0000-0000-0000-000000000020"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000098"), "GER 201", "Basic German I", 3, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4980), null, new Guid("20000000-0000-0000-0000-000000000020"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000099"), "GER 202", "Basic German II", 3, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4980), null, new Guid("20000000-0000-0000-0000-000000000020"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000100"), "GER 203", "Intermediate German I", 3, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4980), null, new Guid("20000000-0000-0000-0000-000000000020"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000101"), "GER 204", "Intermediate German II", 3, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4980), null, new Guid("20000000-0000-0000-0000-000000000020"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000102"), "HUM 203", "Introduction to Social Anthropology", 3, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4990), null, new Guid("20000000-0000-0000-0000-000000000020"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000103"), "HUM 205", "Current Issues in Turkish Language", 3, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4990), null, new Guid("20000000-0000-0000-0000-000000000020"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000104"), "HUM 206", "Comparative Cultures", 3, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4990), null, new Guid("20000000-0000-0000-0000-000000000020"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000105"), "HUM 207", "Ottoman History I", 3, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4990), null, new Guid("20000000-0000-0000-0000-000000000020"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000106"), "HUM 208", "Ottoman History II", 3, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4990), null, new Guid("20000000-0000-0000-0000-000000000020"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000107"), "HUM 211", "Introduction to Russian Culture", 3, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5000), null, new Guid("20000000-0000-0000-0000-000000000020"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000108"), "HUM 213", "History of Western Civilizations I", 3, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5000), null, new Guid("20000000-0000-0000-0000-000000000020"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000109"), "HUM 214", "History of Western Civilizations II", 3, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5000), null, new Guid("20000000-0000-0000-0000-000000000020"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000110"), "HUM 215", "Mythology", 3, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5010), null, new Guid("20000000-0000-0000-0000-000000000020"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000111"), "HUM 216", "Analysis of Folklore Texts", 3, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5010), null, new Guid("20000000-0000-0000-0000-000000000020"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000112"), "HUM 217", "Art History I", 3, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5010), null, new Guid("20000000-0000-0000-0000-000000000020"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000113"), "HUM 218", "Art History II", 3, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5010), null, new Guid("20000000-0000-0000-0000-000000000020"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000114"), "HUM 219", "Art History III", 3, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5010), null, new Guid("20000000-0000-0000-0000-000000000020"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000115"), "HUM 220", "Introduction to Japanese Culture", 3, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5020), null, new Guid("20000000-0000-0000-0000-000000000020"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000116"), "HUM 223", "Introduction to French Culture", 3, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5020), null, new Guid("20000000-0000-0000-0000-000000000020"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000117"), "HUM 226", "Textual Analysis of Contemporary Turkish Literature", 3, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5020), null, new Guid("20000000-0000-0000-0000-000000000020"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000118"), "HUM 227", "Turkish Language Reform", 3, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5020), null, new Guid("20000000-0000-0000-0000-000000000020"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000119"), "HUM 230", "Group Dynamics", 3, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5030), null, new Guid("20000000-0000-0000-0000-000000000020"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000120"), "HUM 231", "Sociology of Work", 3, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5030), null, new Guid("20000000-0000-0000-0000-000000000020"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000121"), "HUM 232", "Visual Communication Symbols in Art and Daily Life", 3, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5030), null, new Guid("20000000-0000-0000-0000-000000000020"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000122"), "HUM 233", "Visual Perception in Art", 3, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5040), null, new Guid("20000000-0000-0000-0000-000000000020"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000123"), "HUM 240", "Introduction to Spanish Culture", 3, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5040), null, new Guid("20000000-0000-0000-0000-000000000020"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000124"), "HUM 251", "Ottoman Turkish I", 3, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5040), null, new Guid("20000000-0000-0000-0000-000000000020"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000125"), "HUM 252", "Ottoman Turkish II", 3, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5050), null, new Guid("20000000-0000-0000-0000-000000000020"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000126"), "HUM 255", "Latin I", 3, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5050), null, new Guid("20000000-0000-0000-0000-000000000020"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000127"), "HUM 256", "Latin II", 3, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5050), null, new Guid("20000000-0000-0000-0000-000000000020"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000128"), "JAP 201", "Basic Japanese I", 3, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5050), null, new Guid("20000000-0000-0000-0000-000000000020"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000129"), "JAP 202", "Basic Japanese II", 3, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5050), null, new Guid("20000000-0000-0000-0000-000000000020"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000130"), "JAP 203", "Intermediate Japanese I", 3, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5060), null, new Guid("20000000-0000-0000-0000-000000000020"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000131"), "MAN 203", "Project Management", 3, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5060), null, new Guid("20000000-0000-0000-0000-000000000020"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000132"), "MAN 205", "Innovation Management", 3, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5060), null, new Guid("20000000-0000-0000-0000-000000000020"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000133"), "MAN 206", "Businesses and Business Life", 3, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5070), null, new Guid("20000000-0000-0000-0000-000000000020"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000134"), "MAN 210", "Corporate Communication and Management Skills", 3, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5070), null, new Guid("20000000-0000-0000-0000-000000000020"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000135"), "MAN 211", "Communication and Management Skills for Engineers", 3, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5070), null, new Guid("20000000-0000-0000-0000-000000000020"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000136"), "MAN 215", "Engineering Economy", 3, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5070), null, new Guid("20000000-0000-0000-0000-000000000020"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000137"), "MAN 216", "Introduction to Marketing", 3, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5080), null, new Guid("20000000-0000-0000-0000-000000000020"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000138"), "MAN 217", "Fundamentals of Management", 3, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5080), null, new Guid("20000000-0000-0000-0000-000000000020"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000139"), "MAN 218", "Entrepreneurship", 3, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5080), null, new Guid("20000000-0000-0000-0000-000000000020"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000140"), "MAN 220", "Leadership", 3, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5080), null, new Guid("20000000-0000-0000-0000-000000000020"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000141"), "MAN 221", "Organizational and Personal Career Management", 3, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5080), null, new Guid("20000000-0000-0000-0000-000000000020"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000142"), "MAN 230", "Law in Business Life", 3, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5090), null, new Guid("20000000-0000-0000-0000-000000000020"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000143"), "MAN 231", "Intellectual and Industrial Property Law", 3, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5090), null, new Guid("20000000-0000-0000-0000-000000000020"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000144"), "RUS 201", "Basic Russian I", 3, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5090), null, new Guid("20000000-0000-0000-0000-000000000020"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000145"), "RUS 202", "Basic Russian II", 3, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5090), null, new Guid("20000000-0000-0000-0000-000000000020"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000146"), "RUS 203", "Intermediate Russian I", 3, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5100), null, new Guid("20000000-0000-0000-0000-000000000020"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000147"), "RUS 204", "Intermediate Russian II", 3, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5100), null, new Guid("20000000-0000-0000-0000-000000000020"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000148"), "RUS 205", "Advanced Russian I", 3, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5100), null, new Guid("20000000-0000-0000-0000-000000000020"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000149"), "RUS 206", "Advanced Russian II", 3, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5100), null, new Guid("20000000-0000-0000-0000-000000000020"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000150"), "SPAN 203", "Intermediate Spanish I", 3, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5100), null, new Guid("20000000-0000-0000-0000-000000000020"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000151"), "SPAN 204", "Intermediate Spanish II", 3, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5110), null, new Guid("20000000-0000-0000-0000-000000000020"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000152"), "SPRT 201", "Tennis I", 3, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5110), null, new Guid("20000000-0000-0000-0000-000000000020"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000153"), "SPRT 202", "Tennis II", 3, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5110), null, new Guid("20000000-0000-0000-0000-000000000020"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000154"), "SPRT 203", "Badminton", 3, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5110), null, new Guid("20000000-0000-0000-0000-000000000020"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000155"), "SPRT 204", "Basketball", 3, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5120), null, new Guid("20000000-0000-0000-0000-000000000020"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000156"), "SPRT 206", "Table Tennis", 3, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5120), null, new Guid("20000000-0000-0000-0000-000000000020"), 3, null },
                    { new Guid("30000000-0000-0000-0000-000000000157"), "SPRT 208", "Basic Fitness Techniques", 3, new DateTime(2025, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(5120), null, new Guid("20000000-0000-0000-0000-000000000020"), 3, null }
                });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "DepartmentId", "FacultyId", "StaffIdentificationNumber", "Title", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("40000000-0000-0000-0000-000000000041"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, new Guid("20000000-0000-0000-0000-000000000001"), new Guid("10000000-0000-0000-0000-000000000001"), "STAFF001", "Advisor", null },
                    { new Guid("40000000-0000-0000-0000-000000000042"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, new Guid("20000000-0000-0000-0000-000000000002"), new Guid("10000000-0000-0000-0000-000000000001"), "STAFF002", "Advisor", null },
                    { new Guid("40000000-0000-0000-0000-000000000043"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, new Guid("20000000-0000-0000-0000-000000000001"), new Guid("10000000-0000-0000-0000-000000000001"), "STAFF003", "Department Secretary", null },
                    { new Guid("40000000-0000-0000-0000-000000000045"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, new Guid("20000000-0000-0000-0000-000000000014"), new Guid("10000000-0000-0000-0000-000000000002"), "STAFF005", "Advisor", null },
                    { new Guid("40000000-0000-0000-0000-000000000046"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, new Guid("20000000-0000-0000-0000-000000000012"), new Guid("10000000-0000-0000-0000-000000000002"), "STAFF006", "Academic Staff", null },
                    { new Guid("40000000-0000-0000-0000-000000000047"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, new Guid("20000000-0000-0000-0000-000000000016"), new Guid("10000000-0000-0000-0000-000000000003"), "STAFF007", "Advisor", null },
                    { new Guid("40000000-0000-0000-0000-000000000048"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, new Guid("20000000-0000-0000-0000-000000000019"), new Guid("10000000-0000-0000-0000-000000000004"), "STAFF008", "Instructor", null },
                    { new Guid("40000000-0000-0000-0000-000000000049"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, new Guid("20000000-0000-0000-0000-000000000020"), new Guid("10000000-0000-0000-0000-000000000005"), "STAFF009", "Coordinator", null },
                    { new Guid("40000000-0000-0000-0000-000000000050"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, new Guid("20000000-0000-0000-0000-000000000001"), new Guid("10000000-0000-0000-0000-000000000001"), "STAFF010", "Advisor", null }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "AssignedAdvisorUserId", "CreatedDate", "CurrentEctsCompleted", "CurrentGpa", "DeletedDate", "DepartmentId", "EnrollDate", "GraduationStatus", "ProgramName", "StudentNumber", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("40000000-0000-0000-0000-000000000001"), new Guid("40000000-0000-0000-0000-000000000041"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, null, null, new Guid("20000000-0000-0000-0000-000000000001"), new DateTime(2021, 11, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4490), 9, "Undergraduate Program", "202400001", null },
                    { new Guid("40000000-0000-0000-0000-000000000002"), new Guid("40000000-0000-0000-0000-000000000050"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, null, null, new Guid("20000000-0000-0000-0000-000000000001"), new DateTime(2023, 2, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4500), 9, "Undergraduate Program", "202400002", null },
                    { new Guid("40000000-0000-0000-0000-000000000003"), new Guid("40000000-0000-0000-0000-000000000041"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, null, null, new Guid("20000000-0000-0000-0000-000000000001"), new DateTime(2023, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4510), 9, "Undergraduate Program", "202400003", null },
                    { new Guid("40000000-0000-0000-0000-000000000004"), new Guid("40000000-0000-0000-0000-000000000050"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, null, null, new Guid("20000000-0000-0000-0000-000000000001"), new DateTime(2022, 7, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4510), 9, "Undergraduate Program", "202400004", null },
                    { new Guid("40000000-0000-0000-0000-000000000005"), new Guid("40000000-0000-0000-0000-000000000041"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, null, null, new Guid("20000000-0000-0000-0000-000000000001"), new DateTime(2022, 2, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4510), 9, "Undergraduate Program", "202400005", null },
                    { new Guid("40000000-0000-0000-0000-000000000006"), new Guid("40000000-0000-0000-0000-000000000050"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, null, null, new Guid("20000000-0000-0000-0000-000000000001"), new DateTime(2022, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4510), 9, "Undergraduate Program", "202400006", null },
                    { new Guid("40000000-0000-0000-0000-000000000007"), new Guid("40000000-0000-0000-0000-000000000041"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, null, null, new Guid("20000000-0000-0000-0000-000000000001"), new DateTime(2020, 11, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4510), 9, "Undergraduate Program", "202400007", null },
                    { new Guid("40000000-0000-0000-0000-000000000008"), new Guid("40000000-0000-0000-0000-000000000050"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, null, null, new Guid("20000000-0000-0000-0000-000000000001"), new DateTime(2024, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4520), 9, "Undergraduate Program", "202400008", null },
                    { new Guid("40000000-0000-0000-0000-000000000009"), new Guid("40000000-0000-0000-0000-000000000041"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, null, null, new Guid("20000000-0000-0000-0000-000000000001"), new DateTime(2020, 10, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4520), 9, "Undergraduate Program", "202400009", null },
                    { new Guid("40000000-0000-0000-0000-000000000010"), new Guid("40000000-0000-0000-0000-000000000050"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, null, null, new Guid("20000000-0000-0000-0000-000000000001"), new DateTime(2024, 4, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4520), 9, "Undergraduate Program", "202400010", null },
                    { new Guid("40000000-0000-0000-0000-000000000011"), new Guid("40000000-0000-0000-0000-000000000041"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, null, null, new Guid("20000000-0000-0000-0000-000000000001"), new DateTime(2020, 7, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4520), 9, "Undergraduate Program", "202400011", null },
                    { new Guid("40000000-0000-0000-0000-000000000012"), new Guid("40000000-0000-0000-0000-000000000050"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, null, null, new Guid("20000000-0000-0000-0000-000000000001"), new DateTime(2023, 7, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4530), 9, "Undergraduate Program", "202400012", null },
                    { new Guid("40000000-0000-0000-0000-000000000013"), new Guid("40000000-0000-0000-0000-000000000041"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, null, null, new Guid("20000000-0000-0000-0000-000000000001"), new DateTime(2021, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4530), 9, "Undergraduate Program", "202400013", null },
                    { new Guid("40000000-0000-0000-0000-000000000014"), new Guid("40000000-0000-0000-0000-000000000050"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, null, null, new Guid("20000000-0000-0000-0000-000000000001"), new DateTime(2024, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4530), 9, "Undergraduate Program", "202400014", null },
                    { new Guid("40000000-0000-0000-0000-000000000015"), new Guid("40000000-0000-0000-0000-000000000041"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, null, null, new Guid("20000000-0000-0000-0000-000000000001"), new DateTime(2024, 4, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4530), 9, "Undergraduate Program", "202400015", null },
                    { new Guid("40000000-0000-0000-0000-000000000016"), new Guid("40000000-0000-0000-0000-000000000050"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, null, null, new Guid("20000000-0000-0000-0000-000000000001"), new DateTime(2024, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4530), 9, "Undergraduate Program", "202400016", null },
                    { new Guid("40000000-0000-0000-0000-000000000017"), new Guid("40000000-0000-0000-0000-000000000041"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, null, null, new Guid("20000000-0000-0000-0000-000000000001"), new DateTime(2024, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4540), 9, "Undergraduate Program", "202400017", null },
                    { new Guid("40000000-0000-0000-0000-000000000018"), new Guid("40000000-0000-0000-0000-000000000050"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, null, null, new Guid("20000000-0000-0000-0000-000000000001"), new DateTime(2024, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4540), 9, "Undergraduate Program", "202400018", null },
                    { new Guid("40000000-0000-0000-0000-000000000019"), new Guid("40000000-0000-0000-0000-000000000041"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, null, null, new Guid("20000000-0000-0000-0000-000000000001"), new DateTime(2021, 12, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4540), 9, "Undergraduate Program", "202400019", null },
                    { new Guid("40000000-0000-0000-0000-000000000020"), new Guid("40000000-0000-0000-0000-000000000050"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, null, null, new Guid("20000000-0000-0000-0000-000000000001"), new DateTime(2024, 5, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4540), 9, "Undergraduate Program", "202400020", null },
                    { new Guid("40000000-0000-0000-0000-000000000021"), new Guid("40000000-0000-0000-0000-000000000041"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, null, null, new Guid("20000000-0000-0000-0000-000000000001"), new DateTime(2021, 12, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4550), 9, "Undergraduate Program", "202400021", null },
                    { new Guid("40000000-0000-0000-0000-000000000022"), new Guid("40000000-0000-0000-0000-000000000050"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, null, null, new Guid("20000000-0000-0000-0000-000000000001"), new DateTime(2022, 4, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4550), 9, "Undergraduate Program", "202400022", null },
                    { new Guid("40000000-0000-0000-0000-000000000023"), new Guid("40000000-0000-0000-0000-000000000041"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, null, null, new Guid("20000000-0000-0000-0000-000000000001"), new DateTime(2021, 12, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4550), 9, "Undergraduate Program", "202400023", null },
                    { new Guid("40000000-0000-0000-0000-000000000024"), new Guid("40000000-0000-0000-0000-000000000050"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, null, null, new Guid("20000000-0000-0000-0000-000000000001"), new DateTime(2022, 10, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4550), 9, "Undergraduate Program", "202400024", null },
                    { new Guid("40000000-0000-0000-0000-000000000025"), new Guid("40000000-0000-0000-0000-000000000041"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, null, null, new Guid("20000000-0000-0000-0000-000000000001"), new DateTime(2023, 10, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4550), 9, "Undergraduate Program", "202400025", null },
                    { new Guid("40000000-0000-0000-0000-000000000026"), new Guid("40000000-0000-0000-0000-000000000050"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, null, null, new Guid("20000000-0000-0000-0000-000000000001"), new DateTime(2024, 1, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4560), 9, "Undergraduate Program", "202400026", null },
                    { new Guid("40000000-0000-0000-0000-000000000027"), new Guid("40000000-0000-0000-0000-000000000041"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, null, null, new Guid("20000000-0000-0000-0000-000000000001"), new DateTime(2021, 3, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4560), 9, "Undergraduate Program", "202400027", null },
                    { new Guid("40000000-0000-0000-0000-000000000028"), new Guid("40000000-0000-0000-0000-000000000050"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, null, null, new Guid("20000000-0000-0000-0000-000000000001"), new DateTime(2024, 4, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4560), 9, "Undergraduate Program", "202400028", null },
                    { new Guid("40000000-0000-0000-0000-000000000029"), new Guid("40000000-0000-0000-0000-000000000041"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, null, null, new Guid("20000000-0000-0000-0000-000000000001"), new DateTime(2022, 11, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4560), 9, "Undergraduate Program", "202400029", null },
                    { new Guid("40000000-0000-0000-0000-000000000030"), new Guid("40000000-0000-0000-0000-000000000050"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, null, null, new Guid("20000000-0000-0000-0000-000000000001"), new DateTime(2022, 9, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4560), 9, "Undergraduate Program", "202400030", null },
                    { new Guid("40000000-0000-0000-0000-000000000031"), new Guid("40000000-0000-0000-0000-000000000041"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, null, null, new Guid("20000000-0000-0000-0000-000000000001"), new DateTime(2023, 11, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4570), 9, "Undergraduate Program", "202400031", null },
                    { new Guid("40000000-0000-0000-0000-000000000032"), new Guid("40000000-0000-0000-0000-000000000050"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, null, null, new Guid("20000000-0000-0000-0000-000000000001"), new DateTime(2022, 11, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4570), 9, "Undergraduate Program", "202400032", null },
                    { new Guid("40000000-0000-0000-0000-000000000033"), new Guid("40000000-0000-0000-0000-000000000041"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, null, null, new Guid("20000000-0000-0000-0000-000000000001"), new DateTime(2022, 1, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4570), 9, "Undergraduate Program", "202400033", null },
                    { new Guid("40000000-0000-0000-0000-000000000034"), new Guid("40000000-0000-0000-0000-000000000050"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, null, null, new Guid("20000000-0000-0000-0000-000000000001"), new DateTime(2021, 9, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4570), 9, "Undergraduate Program", "202400034", null },
                    { new Guid("40000000-0000-0000-0000-000000000035"), new Guid("40000000-0000-0000-0000-000000000041"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, null, null, new Guid("20000000-0000-0000-0000-000000000001"), new DateTime(2021, 2, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4570), 9, "Undergraduate Program", "202400035", null },
                    { new Guid("40000000-0000-0000-0000-000000000036"), new Guid("40000000-0000-0000-0000-000000000050"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, null, null, new Guid("20000000-0000-0000-0000-000000000001"), new DateTime(2021, 12, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4580), 9, "Undergraduate Program", "202400036", null },
                    { new Guid("40000000-0000-0000-0000-000000000037"), new Guid("40000000-0000-0000-0000-000000000041"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, null, null, new Guid("20000000-0000-0000-0000-000000000001"), new DateTime(2021, 8, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4580), 9, "Undergraduate Program", "202400037", null },
                    { new Guid("40000000-0000-0000-0000-000000000038"), new Guid("40000000-0000-0000-0000-000000000050"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, null, null, new Guid("20000000-0000-0000-0000-000000000001"), new DateTime(2021, 8, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4580), 9, "Undergraduate Program", "202400038", null },
                    { new Guid("40000000-0000-0000-0000-000000000039"), new Guid("40000000-0000-0000-0000-000000000041"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, null, null, new Guid("20000000-0000-0000-0000-000000000001"), new DateTime(2020, 12, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4580), 9, "Undergraduate Program", "202400039", null },
                    { new Guid("40000000-0000-0000-0000-000000000040"), new Guid("40000000-0000-0000-0000-000000000050"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, null, null, new Guid("20000000-0000-0000-0000-000000000001"), new DateTime(2022, 6, 19, 19, 47, 30, 866, DateTimeKind.Utc).AddTicks(4580), 9, "Undergraduate Program", "202400040", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_DepartmentId",
                table: "Courses",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseTakens_MatchedCourseId",
                table: "CourseTakens",
                column: "MatchedCourseId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseTakens_StudentUserId",
                table: "CourseTakens",
                column: "StudentUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_FacultyId",
                table: "Departments",
                column: "FacultyId");

            migrationBuilder.CreateIndex(
                name: "IX_EligibilityCheckResults_GraduationProcessId",
                table: "EligibilityCheckResults",
                column: "GraduationProcessId");

            migrationBuilder.CreateIndex(
                name: "IX_EmailAuthenticators_UserId",
                table: "EmailAuthenticators",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_FileAttachments_GraduationProcessId",
                table: "FileAttachments",
                column: "GraduationProcessId");

            migrationBuilder.CreateIndex(
                name: "IX_FileAttachments_StudentUserId",
                table: "FileAttachments",
                column: "StudentUserId");

            migrationBuilder.CreateIndex(
                name: "IX_FileAttachments_UploaderUserId",
                table: "FileAttachments",
                column: "UploaderUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GraduationProcesses_AdvisorUserId",
                table: "GraduationProcesses",
                column: "AdvisorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GraduationProcesses_DeansOfficeUserId",
                table: "GraduationProcesses",
                column: "DeansOfficeUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GraduationProcesses_DeptSecretaryUserId",
                table: "GraduationProcesses",
                column: "DeptSecretaryUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GraduationProcesses_StudentAffairsUserId",
                table: "GraduationProcesses",
                column: "StudentAffairsUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GraduationProcesses_StudentUserId",
                table: "GraduationProcesses",
                column: "StudentUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GraduationRequirementSets_CreatedByUserId",
                table: "GraduationRequirementSets",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GraduationRequirementSets_DepartmentId",
                table: "GraduationRequirementSets",
                column: "DepartmentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GraduationRequirementSets_LastModifiedByUserId",
                table: "GraduationRequirementSets",
                column: "LastModifiedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_RecipientUserId",
                table: "Notifications",
                column: "RecipientUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_RelatedProcessId",
                table: "Notifications",
                column: "RelatedProcessId");

            migrationBuilder.CreateIndex(
                name: "IX_OtpAuthenticators_UserId",
                table: "OtpAuthenticators",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_RankingListCriterias_RankingListId",
                table: "RankingListCriterias",
                column: "RankingListId");

            migrationBuilder.CreateIndex(
                name: "IX_RankingListEntries_RankingListId",
                table: "RankingListEntries",
                column: "RankingListId");

            migrationBuilder.CreateIndex(
                name: "IX_RankingListEntries_StudentUserId",
                table: "RankingListEntries",
                column: "StudentUserId");

            migrationBuilder.CreateIndex(
                name: "IX_RankingLists_GeneratedByUserId",
                table: "RankingLists",
                column: "GeneratedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_RankingLists_ScopeDepartmentId",
                table: "RankingLists",
                column: "ScopeDepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_RankingLists_ScopeFacultyId",
                table: "RankingLists",
                column: "ScopeFacultyId");

            migrationBuilder.CreateIndex(
                name: "IX_RefreshTokens_UserId",
                table: "RefreshTokens",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_RequirementMandatoryCourses_CourseId",
                table: "RequirementMandatoryCourses",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_RequirementMandatoryCourses_GraduationRequirementSetId",
                table: "RequirementMandatoryCourses",
                column: "GraduationRequirementSetId");

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_DepartmentId",
                table: "Staffs",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_FacultyId",
                table: "Staffs",
                column: "FacultyId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_AssignedAdvisorUserId",
                table: "Students",
                column: "AssignedAdvisorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_DepartmentId",
                table: "Students",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_TranscriptDatas_SourceFileAttachmentId",
                table: "TranscriptDatas",
                column: "SourceFileAttachmentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TranscriptDatas_StudentUserId",
                table: "TranscriptDatas",
                column: "StudentUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserOperationClaims_OperationClaimId",
                table: "UserOperationClaims",
                column: "OperationClaimId");

            migrationBuilder.CreateIndex(
                name: "IX_UserOperationClaims_UserId",
                table: "UserOperationClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ValidationCodes_UserId",
                table: "ValidationCodes",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseTakens");

            migrationBuilder.DropTable(
                name: "EligibilityCheckResults");

            migrationBuilder.DropTable(
                name: "EmailAuthenticators");

            migrationBuilder.DropTable(
                name: "MailLogs");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "OtpAuthenticators");

            migrationBuilder.DropTable(
                name: "RankingListCriterias");

            migrationBuilder.DropTable(
                name: "RankingListEntries");

            migrationBuilder.DropTable(
                name: "RefreshTokens");

            migrationBuilder.DropTable(
                name: "RequirementMandatoryCourses");

            migrationBuilder.DropTable(
                name: "Staffs");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "TranscriptDatas");

            migrationBuilder.DropTable(
                name: "UserOperationClaims");

            migrationBuilder.DropTable(
                name: "ValidationCodes");

            migrationBuilder.DropTable(
                name: "RankingLists");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "GraduationRequirementSets");

            migrationBuilder.DropTable(
                name: "FileAttachments");

            migrationBuilder.DropTable(
                name: "OperationClaims");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "GraduationProcesses");

            migrationBuilder.DropTable(
                name: "Faculties");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
