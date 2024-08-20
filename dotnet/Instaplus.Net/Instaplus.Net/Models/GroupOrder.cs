using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Instaplus.Net.Models;

public sealed class GroupOrder
{
   
    
    public string Id { get; internal set; }
    public decimal Amount { get; internal set; }
    public decimal CollectedAmount { get; internal set; }
    public DateTime CreatedAt { get; internal set; }
    public DateTime ExpiresAtUtc { get; internal set; }
    public ReceivingAccountType ReceivingAccountType { get; internal set; }
    public string To { get; internal set; }
    public string? Notes { get; internal set; }
    public List<Order> Orders { get; internal set; }
    
    [NotMapped] public ReceivingAccountInfo.Account? Mobile => JsonSerializer.Deserialize<ReceivingAccountInfo.Account>(To);
    [NotMapped] public ReceivingAccountInfo.Wallet? Wallet => JsonSerializer.Deserialize<ReceivingAccountInfo.Wallet>(To);
    [NotMapped] public ReceivingAccountInfo.InstaPay? InstaPay => JsonSerializer.Deserialize<ReceivingAccountInfo.InstaPay>(To);
    [NotMapped] public ReceivingAccountInfo.BankAccount? BankAccount => JsonSerializer.Deserialize<ReceivingAccountInfo.BankAccount>(To);
    [NotMapped] public ReceivingAccountInfo.BankIban? BankIban => JsonSerializer.Deserialize<ReceivingAccountInfo.BankIban>(To);
    
    [JsonConstructor]
    internal GroupOrder() { }

    public class Order
    {
        public string Id { get; internal set; }
        public string ExternalId { get; internal set; }
        public decimal Amount { get; internal set; }
        public decimal CollectedAmount { get; internal set; }
        
        [JsonConstructor]
        internal Order() { }
    }
}

