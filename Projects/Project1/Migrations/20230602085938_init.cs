using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project1.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "plans",
                columns: table => new
                {
                    PlanId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlanDays = table.Column<int>(type: "int", nullable: false),
                    PlanAmount = table.Column<int>(type: "int", nullable: false),
                    PlanCv = table.Column<int>(type: "int", nullable: false),
                    PlanEmails = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_plans", x => x.PlanId);
                });

            migrationBuilder.CreateTable(
                name: "roles",
                columns: table => new
                {
                    Roleid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_roles", x => x.Roleid);
                });

            migrationBuilder.CreateTable(
                name: "Companys",
                columns: table => new
                {
                    CompanyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlanId = table.Column<int>(type: "int", nullable: true),
                    CompanyCreateId = table.Column<int>(type: "int", nullable: true),
                    CompanyCreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CompanyModifyId = table.Column<int>(type: "int", nullable: true),
                    CompanymodifyDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companys", x => x.CompanyId);
                    table.ForeignKey(
                        name: "FK_Companys_plans_PlanId",
                        column: x => x.PlanId,
                        principalTable: "plans",
                        principalColumn: "PlanId");
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserMobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserCreateId = table.Column<int>(type: "int", nullable: true),
                    UserCreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserModifyId = table.Column<int>(type: "int", nullable: true),
                    UsermodifyDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Users_roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "roles",
                        principalColumn: "Roleid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Jobs",
                columns: table => new
                {
                    JobId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobDesignation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobVacany = table.Column<int>(type: "int", nullable: false),
                    JobDetail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobHrName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobStatus = table.Column<bool>(type: "bit", nullable: false),
                    JobCreateId = table.Column<int>(type: "int", nullable: true),
                    JobCreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    JobModifyId = table.Column<int>(type: "int", nullable: true),
                    JobmodifyDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jobs", x => x.JobId);
                    table.ForeignKey(
                        name: "FK_Jobs_Companys_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companys",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserProfiles",
                columns: table => new
                {
                    UserProfileId = table.Column<int>(type: "int", nullable: false),
                    UserProfileskills = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    EducationsscId = table.Column<int>(type: "int", nullable: false),
                    EducationhscId = table.Column<int>(type: "int", nullable: false),
                    EducationdegreeId = table.Column<int>(type: "int", nullable: false),
                    UserLocationId = table.Column<int>(type: "int", nullable: false),
                    UserProfileResume = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProfiles", x => x.UserProfileId);
                    table.ForeignKey(
                        name: "FK_UserProfiles_Users_UserProfileId",
                        column: x => x.UserProfileId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "JobsApply",
                columns: table => new
                {
                    JobapplyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobsApply", x => x.JobapplyId);
                    table.ForeignKey(
                        name: "FK_JobsApply_Jobs_JobId",
                        column: x => x.JobId,
                        principalTable: "Jobs",
                        principalColumn: "JobId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobsApply_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "educationdegrees",
                columns: table => new
                {
                    EducationdegreeId = table.Column<int>(type: "int", nullable: false),
                    EducationdegreeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EducationdegreeUniversityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EducationdegreeStartYear = table.Column<int>(type: "int", nullable: false),
                    EducationdegreeEndYear = table.Column<int>(type: "int", nullable: false),
                    Educationdegreemarks = table.Column<int>(type: "int", nullable: false),
                    UserProfileId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_educationdegrees", x => x.EducationdegreeId);
                    table.ForeignKey(
                        name: "FK_educationdegrees_UserProfiles_EducationdegreeId",
                        column: x => x.EducationdegreeId,
                        principalTable: "UserProfiles",
                        principalColumn: "UserProfileId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "educationhscs",
                columns: table => new
                {
                    EducationhscId = table.Column<int>(type: "int", nullable: false),
                    EducationhscName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EducationhscUniversityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EducationhscStartYear = table.Column<int>(type: "int", nullable: false),
                    EducationhscEndYear = table.Column<int>(type: "int", nullable: false),
                    Educationhscmarks = table.Column<int>(type: "int", nullable: false),
                    UserProfileId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_educationhscs", x => x.EducationhscId);
                    table.ForeignKey(
                        name: "FK_educationhscs_UserProfiles_EducationhscId",
                        column: x => x.EducationhscId,
                        principalTable: "UserProfiles",
                        principalColumn: "UserProfileId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "educationsscs",
                columns: table => new
                {
                    EducationsscId = table.Column<int>(type: "int", nullable: false),
                    EducationsscName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EducationsscUniversityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EducationsscStartYear = table.Column<int>(type: "int", nullable: false),
                    EducationsscEndYear = table.Column<int>(type: "int", nullable: false),
                    Educationsscmarks = table.Column<int>(type: "int", nullable: false),
                    UserProfileId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_educationsscs", x => x.EducationsscId);
                    table.ForeignKey(
                        name: "FK_educationsscs_UserProfiles_EducationsscId",
                        column: x => x.EducationsscId,
                        principalTable: "UserProfiles",
                        principalColumn: "UserProfileId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserCompanyExperiences",
                columns: table => new
                {
                    UserCompanyExperienceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserCompanyExperienceCompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserCompanyExperienceYear = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserCompanyExperienceMonth = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserCompanyExperiencejobprofile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserCompanyExperiencedesignation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserCompanyExperiencejoiningDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserProfileId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserCompanyExperiences", x => x.UserCompanyExperienceId);
                    table.ForeignKey(
                        name: "FK_UserCompanyExperiences_UserProfiles_UserProfileId",
                        column: x => x.UserProfileId,
                        principalTable: "UserProfiles",
                        principalColumn: "UserProfileId");
                });

            migrationBuilder.CreateTable(
                name: "userLocations",
                columns: table => new
                {
                    UserLocationId = table.Column<int>(type: "int", nullable: false),
                    UserLocationCityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserLocationStateName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserLocationCountryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserProfileId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userLocations", x => x.UserLocationId);
                    table.ForeignKey(
                        name: "FK_userLocations_UserProfiles_UserLocationId",
                        column: x => x.UserLocationId,
                        principalTable: "UserProfiles",
                        principalColumn: "UserProfileId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "userProjects",
                columns: table => new
                {
                    UserProjectId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserProjectName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserProjectRole = table.Column<int>(type: "int", nullable: false),
                    UserProjectRoleDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserProjectSkills = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserProfileId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userProjects", x => x.UserProjectId);
                    table.ForeignKey(
                        name: "FK_userProjects_UserProfiles_UserProfileId",
                        column: x => x.UserProfileId,
                        principalTable: "UserProfiles",
                        principalColumn: "UserProfileId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Companys_PlanId",
                table: "Companys",
                column: "PlanId");

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_CompanyId",
                table: "Jobs",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_JobsApply_JobId",
                table: "JobsApply",
                column: "JobId");

            migrationBuilder.CreateIndex(
                name: "IX_JobsApply_UserId",
                table: "JobsApply",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserCompanyExperiences_UserProfileId",
                table: "UserCompanyExperiences",
                column: "UserProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_userProjects_UserProfileId",
                table: "userProjects",
                column: "UserProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "educationdegrees");

            migrationBuilder.DropTable(
                name: "educationhscs");

            migrationBuilder.DropTable(
                name: "educationsscs");

            migrationBuilder.DropTable(
                name: "JobsApply");

            migrationBuilder.DropTable(
                name: "UserCompanyExperiences");

            migrationBuilder.DropTable(
                name: "userLocations");

            migrationBuilder.DropTable(
                name: "userProjects");

            migrationBuilder.DropTable(
                name: "Jobs");

            migrationBuilder.DropTable(
                name: "UserProfiles");

            migrationBuilder.DropTable(
                name: "Companys");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "plans");

            migrationBuilder.DropTable(
                name: "roles");
        }
    }
}
