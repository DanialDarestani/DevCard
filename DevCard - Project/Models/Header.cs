namespace DevCard___Project.Models
{
    public class Header(List<Menu> menus, string logo)
    {
        public List<Menu> Menus { get; set; } = menus;
        public string Logo { get; set; } = logo;
    }
}
