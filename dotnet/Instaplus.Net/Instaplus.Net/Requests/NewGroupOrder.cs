namespace Instaplus.Net.Requests;

public class NewGroupOrder
{
    public required string ReceivingAccountId { init; get; } = default!;
    public required string Notes { init; get; } = String.Empty;
    public required int ValidityInHours { init; get; }
    public required Order[] From { init; get; } 
    public class Order
    {
        public required string ExternalId { init; get; } = string.Empty;
        public required decimal Amount { init; get; }
    }
}