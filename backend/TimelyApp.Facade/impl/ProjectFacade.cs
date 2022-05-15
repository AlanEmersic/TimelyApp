using TimelyApp.Dto;
using TimelyApp.Form;
using TimelyApp.Mapper;
using TimelyApp.Model;
using TimelyApp.Service;

namespace TimelyApp.Facade.impl
{
    public class ProjectFacade : IProjectFacade
    {
        IProjectService projectService;
        IProjectDtoMapper projectDtoMapper;
        IProjectFormMapper projectFormMapper;

        public ProjectFacade(IProjectService projectService, IProjectDtoMapper projectDtoMapper, IProjectFormMapper projectFormMapper)
        {
            this.projectService = projectService;
            this.projectDtoMapper = projectDtoMapper;
            this.projectFormMapper = projectFormMapper;
        }

        public void CreateProject(ProjectForm projectForm)
        {
            projectService.SaveProject(projectFormMapper.map(projectForm));
        }

        public void DeleteProject(int id)
        {
            projectService.DeleteProject(id);
        }

        public ICollection<ProjectDto> GetAllProjects()
        {
            return projectService.GetProjects().Select(p => projectDtoMapper.map(p)).ToList();
        }

        public ProjectDto GetProject(int id)
        {
            return projectDtoMapper.map(projectService.GetProject(id));
        }

        public void UpdateProject(int id, ProjectForm projectForm)
        {
            Project project = projectService.GetProject(id);

            if (project == null)
                return;

            projectService.UpdateProject(projectFormMapper.mapUpdate(project, projectForm));
        }
    }
}
