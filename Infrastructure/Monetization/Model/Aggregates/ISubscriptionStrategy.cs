

namespace Infrastructure.Monetization.Model.Aggregates
{
    public interface ISubscriptionStrategy
    {
        public void Subscribe(Subscription entity);
    }
}