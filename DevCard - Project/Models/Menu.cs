namespace DevCard___Project.Models
{
    public class Menu(string name,string controller,string action,string icon)
    {
        public string Name { get; set; } = name;
        public string Controller { get; set; } = controller;
        public string Action { get; set; } = action;
        public string Icon { get; set; } = icon;
    }
}
