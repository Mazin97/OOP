using Orientacao.SharedContext;

namespace Orientacao.SubscriptionContext
{
    public class Plan : Base
    {
        public string Title { get; set; }

        public decimal Price { get; set; }
    }
}