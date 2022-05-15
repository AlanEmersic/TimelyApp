namespace TimelyApp.Dto
{
    public record ProjectDto(int id, string name, DateTime startTime, DateTime endTime, TimeSpan duration);
}
