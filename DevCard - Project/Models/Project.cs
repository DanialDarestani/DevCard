namespace DevCard___Project.Models
{
	public class Project(long id, string name, string description, string client, string image)
	{
		public long ID { get; set; } = id;
		public string Name { get; set; } = name;
		public string Description { get; set; } = description;
		public string Client { get; set; } = client;
		public string Image { get; set; } = image;
	}
}
