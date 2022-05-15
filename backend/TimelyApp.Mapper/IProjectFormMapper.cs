using TimelyApp.Form;
using TimelyApp.Model;

namespace TimelyApp.Mapper
{
    public interface IProjectFormMapper
    {
        Project map(ProjectForm projectForm);

        Project mapUpdate(Project project, ProjectForm projectForm);
    }
}
