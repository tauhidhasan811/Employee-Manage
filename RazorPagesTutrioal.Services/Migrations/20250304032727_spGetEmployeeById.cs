using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RazorPagesTutrioal.Services.Migrations
{
    /// <inheritdoc />
    public partial class spGetEmployeeById : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string procedure = @"CREATE PROCEDURE spGetEmployeeById
                                @Id int
                                AS
                                BEGIN
                                    SELECT * FROM Employees WHERE Id = @Id
                                END";
            migrationBuilder.Sql(procedure);

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            string procedure = @"DROP PROCEDURE spGetEmployeeById";
            migrationBuilder.Sql(procedure);

        }
    }
}
