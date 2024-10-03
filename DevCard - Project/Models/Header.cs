namespace DevCard___Project.Models
{
    public class Header(Dictionary<string,string> menus, string logo)
    {
        public Dictionary<string, string> Menus { get; set; } = menus;
        public string Logo { get; set; } = logo;
    }
}
