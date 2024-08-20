namespace Instaplus.Net.Requests;

public class NewOrder
{
    public required string ExternalId { init; get; } = string.Empty!;
    public required decimal Amount { init; get; }
    
    public required string ReceivingAccountId { init; get; } = default!;
    public required string Notes { init; get; } = String.Empty;
    public required int ValidityInHours { init; get; }
}