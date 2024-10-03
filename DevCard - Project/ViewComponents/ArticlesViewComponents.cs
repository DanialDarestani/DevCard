using Microsoft.AspNetCore.Mvc;

namespace DevCard___Project.ViewComponents;

public class ArticlesViewComponents : ViewComponent
{
	public IViewComponentResult Invoke()
	{
		return View("_Article");
	}
}