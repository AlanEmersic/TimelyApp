using TimelyApp.Model;

namespace TimelyApp.Service
{
    public interface IProjectService
    {
        Project GetProject(int id);

        ICollection<Project> GetProjects();

        void SaveProject(Project project);

        void UpdateProject(Project project);

        void DeleteProject(int id);
    }
}
