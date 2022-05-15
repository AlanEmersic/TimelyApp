using TimelyApp.Form;
using TimelyApp.Model;

namespace TimelyApp.Mapper.impl
{
    public class ProjectFormMapper : IProjectFormMapper
    {
        public Project map(ProjectForm projectForm)
        {
            if (projectForm == null)
                return null;

            DateTime startTime = DateTime.Parse(projectForm.StartTime);
            DateTime endTime = DateTime.Parse(projectForm.EndTime);
            TimeSpan duration = endTime - startTime;

            Project project = new Project();
            project.Name = projectForm.Name;
            project.Duration = duration.Ticks;
            project.StartTime = startTime;
            project.EndTime = endTime;

            return project;
        }

        public Project mapUpdate(Project project, ProjectForm projectForm)
        {
            if (projectForm == null)
                return null;

            DateTime startTime = DateTime.Parse(projectForm.StartTime);
            DateTime endTime = DateTime.Parse(projectForm.EndTime);
            TimeSpan duration = endTime - startTime;

            project.Name = projectForm.Name;
            project.Duration += duration.Ticks;
            project.EndTime = endTime;

            return project;
        }
    }
}
