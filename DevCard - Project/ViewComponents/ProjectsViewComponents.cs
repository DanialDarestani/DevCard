using DevCard___Project.Data;
using DevCard___Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard___Project.ViewComponents
{
	public class ProjectsViewComponents : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var projects = ProjectStore.GetProjects();
			return View("_Project",projects);
		}
	}
}
