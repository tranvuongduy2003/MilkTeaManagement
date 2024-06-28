namespace MilkTeaManagement.Application.Common.Models.Employees
{
    public record Workday
    (
        string Time,
        bool Monday,
        bool Tuesday,
        bool Wednesday,
        bool Thursday,
        bool Friday,
        bool Saturday,
        bool Sunday
    );
}
