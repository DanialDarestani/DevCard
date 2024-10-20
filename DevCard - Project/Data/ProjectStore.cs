using DevCard___Project.Models;

namespace DevCard___Project.Data
{
	public class ProjectStore
	{
		public static List<Project> GetProjects()
		{
			return new List<Project>()
			{
				new(1, "Taxi", "Requesting online Taxi for city trips", "Snapp", "project-1.jpg"),
				new(2, "RanjbarBuildings", "Luxury buildings construction company", "Majid Ranjbar", "project-2.jpg"),
				new(3, "SteakHouse", "Unique restaurant with variety of steakes", "SteakHouse", "project-3.jpg"),
				new(4, "MehrnazFarahani", "Lawyer of court in tehran, Iran", "MehrnazFarahani", "project-4.jpg")
			};
		}

        public static Project GetProjectBy(int Id)
        {
            return GetProjects().FirstOrDefault(x => x.ID == Id);
        }
	}
}
