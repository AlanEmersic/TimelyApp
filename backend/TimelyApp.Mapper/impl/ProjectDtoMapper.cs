using TimelyApp.Dto;
using TimelyApp.Model;

namespace TimelyApp.Mapper.impl
{
    public class ProjectDtoMapper : IProjectDtoMapper
    {
        public ProjectDto map(Project project)
        {
            if (project == null)
                return null;

            return new ProjectDto(project.Id, project.Name, project.StartTime, project.EndTime, new TimeSpan(project.Duration));
        }
    }
}
