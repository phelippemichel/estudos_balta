namespace ConsoleApp1.ContentContext.Enums
{
    public class Career : Content
    {
        public Career()
        {
            Items = new List<CarrerItem>();
        }
        public IList<CarrerItem> Items {get; set;}
        public int TotalCourses => Items.Count;
        //Expression Body        
    }
}
