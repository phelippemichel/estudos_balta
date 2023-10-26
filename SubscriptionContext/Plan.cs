using ConsoleApp1.SharedContext;
using ConsoleApp1.SubscriptionContext;

namespace ConsoleApp1
{
    public class Plan : Base
    {
        public User Title {get; set;}
        public decimal Price {get; set;}
    }
}