using DevCard___Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard___Project.ViewComponents;

public class HeaderViewComponents : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        var header = new Header(new Dictionary<string, string>() { { "صفحه اصلی", "Index" }, { "ارتباط با ما", "Contact" } },
                "me.jpeg");
        return View("_Header",header);
    }
}