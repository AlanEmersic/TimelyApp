using TimelyApp.Model;
using TimelyApp.Repository;

namespace TimelyApp.Service.impl
{
    public class ProjectService : IProjectService
    {
        readonly ProjectDbContext dbContext;

        public ProjectService(ProjectDbContext dbContext)
        {
            this.dbContext = dbContext;
        }     

        public Project GetProject(int id)
        {
            return dbContext.Projects.Where(p => p.Id == id).FirstOrDefault();
        }

        public ICollection<Project> GetProjects()
        {
            return dbContext.Projects.ToList();
        }

        public void SaveProject(Project project)
        {
            dbContext.Projects.Add(project);
            dbContext.SaveChanges();
        }

        public void UpdateProject(Project project)
        {
            dbContext.Projects.Update(project);
            dbContext.SaveChanges();
        }

        public void DeleteProject(int id)
        {
            Project project = dbContext.Projects.FirstOrDefault(p => p.Id == id);

            if(project != null)
                dbContext.Projects.Remove(project);
            
            dbContext.SaveChanges();
        }
    }
}
