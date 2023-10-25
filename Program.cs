using ConsoleApp1.ContentContext.Enums;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			var course = new Course();
			course.Level = EContentLevel.Beginner;
			foreach(var item in course.Modules)
			{

			}
			var career = new Career();
			career.Items.Add(new CarrerItem());
			Console.WriteLine(career.TotalCourses);
		}
	}
}
