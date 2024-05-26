namespace artcollab.API.Monetization.Interfaces.REST;

public class Writer : UserFactory
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Type { get; set; }
    public string Username { get; set; }
    public ReaderSubscriptionStrategy SubscriptionStrategy { get; set; }
}