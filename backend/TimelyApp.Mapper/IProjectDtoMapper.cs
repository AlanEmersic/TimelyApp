using TimelyApp.Dto;
using TimelyApp.Model;

namespace TimelyApp.Mapper
{
    public interface IProjectDtoMapper
    {
        ProjectDto map(Project project);
    }
}
