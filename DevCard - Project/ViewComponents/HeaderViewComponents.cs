using DevCard___Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard___Project.ViewComponents;

public class HeaderViewComponents : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        var header = new Header(new List<Menu>()
            {
                new Menu("صفحه اصلی","Home","Index",""), 
                new Menu("ارتباط با من","Home","Contact",""),
                new Menu("فروشگاه","Shop","Index",""),
                new Menu("Test1","Home","Test1",""),
                new Menu("Test2","Home","Test2",""),
                new Menu("Test3","Home","Test3",""),
                new Menu("Test4","Home","Test4",""),
                new Menu("Test5","Home","Test5",""),
                new Menu("Test6","Home","Test6",""),
                new Menu("Test7","Home","Test7",""),
                new Menu("Test8","Home","Test8",""),
                new Menu("Test9","Home","Test9",""),
                new Menu("Test10","Home","Test10",""),
            },
                "me.jpeg");
        return View("_Header",header);
    }
}