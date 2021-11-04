using Orientacao.NotificationContext;
using Orientacao.SharedContext;

namespace Orientacao.SubscriptionContext
{
    public class Student : Base
    {
        public Student()
        {
            this.Subscriptions = new List<Subscription>();
        }

        public User User { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public IList<Subscription> Subscriptions { get; set; }

        public bool IsPremium => Subscriptions.Any(x => !x.IsInactive);

        public void CreateSubscription(Subscription subscription)
        {
            if (IsPremium)
            {
                AddNotification(new Notification("Premium", "O aluno já possui uma inscrição ativa."));
                return;
            }

            Subscriptions.Add(subscription);
        }
    }
}