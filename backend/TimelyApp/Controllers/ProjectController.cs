using Microsoft.AspNetCore.Mvc;
using TimelyApp.Facade;
using TimelyApp.Dto;
using TimelyApp.Form;

namespace TimelyApp.Controllers
{
    [ApiController]
    [Route("api/projects")]    
    public class ProjectController : Controller
    {
        readonly IProjectFacade projectFacade;

        public ProjectController(IProjectFacade projectFacade)
        {
            this.projectFacade = projectFacade;
        }

        [HttpGet]
        public IActionResult GetAllProjects()
        {
            return Ok(projectFacade.GetAllProjects());
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetProject(int id)
        {
            ProjectDto project = projectFacade.GetProject(id);

            if (project == null)
                return NotFound();

            return Ok(project);
        }

        [HttpPost]
        public IActionResult CreateProject([FromBody] ProjectForm projectForm)
        {
            projectFacade.CreateProject(projectForm);

            return Ok();
        }

        [HttpPut]
        [Route("{id}/update")]        
        public IActionResult UpdateProject(int id, [FromBody] ProjectForm projectForm)
        {
            projectFacade.UpdateProject(id, projectForm);

            return Ok();
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult DeleteProject(int id)
        {
            ProjectDto project = projectFacade.GetProject(id);

            if (project == null)
                return NotFound();

            projectFacade.DeleteProject(project.id);

            return Ok();
        }
    }
}
