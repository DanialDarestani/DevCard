using DevCard___Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard___Project.ViewComponents;

public class ArticlesViewComponents : ViewComponent
{
	public IViewComponentResult Invoke()
	{
		var articles = new List<Article>()
		{
			new(1,"Top 3 JavaScript Frameworks","Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient...","blog-post-thumb-card-1.jpg"),
			new(2,"About Remote Working","Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient...","blog-post-thumb-card-2.jpg"),
			new(3,"A Guide to Becoming a Full-Stack Developer","Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient...","blog-post-thumb-card-3.jpg"),
		};
		return View("_Article",articles);
	}
}