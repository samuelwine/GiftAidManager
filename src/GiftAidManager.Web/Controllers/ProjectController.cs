using System.Linq;
using System.Threading.Tasks;
using GiftAidManager.Core;
using GiftAidManager.Core.ProjectAggregate;
using GiftAidManager.Core.ProjectAggregate.Specifications;
using GiftAidManager.SharedKernel.Interfaces;
using GiftAidManager.Web.ApiModels;
using GiftAidManager.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace GiftAidManager.Web.Controllers
{
    [Route("[controller]")]
    public class ProjectController : Controller
    {
        private readonly IRepository<Project> _projectRepository;

        public ProjectController(IRepository<Project> projectRepository)
        {
            _projectRepository = projectRepository;
        }

        // GET project/{projectId?}
        [HttpGet("{projectId:int}")]
        public async Task<IActionResult> Index(int projectId = 1)
        {
            var spec = new ProjectByIdWithItemsSpec(projectId);
            var project = await _projectRepository.GetBySpecAsync(spec);

            var dto = new ProjectViewModel
            {
                Id = project.Id,
                Name = project.Name,
                Items = project.Items
                            .Select(item => ToDoItemViewModel.FromToDoItem(item))
                            .ToList()
            };
            return View(dto);
        }
    }
}
