namespace DevCard___Project.Models;

public class Article(long id, string title, string description, string image)
{
	public long ID { get; set; } = id;
	public string Title { get; set; } = title;
	public string Description { get; set; } = description;
	public string Image { get; set; } = image;
}