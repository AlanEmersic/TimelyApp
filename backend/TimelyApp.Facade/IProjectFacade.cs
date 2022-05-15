using TimelyApp.Dto;
using TimelyApp.Form;

namespace TimelyApp.Facade
{
    public interface IProjectFacade
    {
        ProjectDto GetProject(int id);

        ICollection<ProjectDto> GetAllProjects();

        void CreateProject(ProjectForm projectForm);

        void DeleteProject(int id);

        void UpdateProject(int id, ProjectForm projectForm);
    }
}
