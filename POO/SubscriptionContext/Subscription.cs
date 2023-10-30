using ConsoleApp1.SharedContext;

namespace ConsoleApp1
{
    public class Subscription : Base
    {
        public Plan Plan { get; set; }
        public DateTime? EndDate { get; set;}
        public bool IsInactive => EndDate <= DateTime.Now;
    }
}
