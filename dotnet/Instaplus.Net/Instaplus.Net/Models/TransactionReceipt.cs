using System.Text.Json.Serialization;

namespace Instaplus.Net.Models;

public sealed class TransactionReceipt
{
    public string InstapayReference { get; internal set; }
    public DateTime Timestamp { get; internal set; }
    public decimal Amount { get; internal set; }
    public ReceivingAccountInfo.InstaPay  From { get; internal set; }
    
    [JsonConstructor]
    internal TransactionReceipt() {}
}