﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;
using System.Text.Json.Serialization;
using Instaplus.Net.Utils;

namespace Instaplus.Net.Models;

public sealed class GroupOrder
{ 
    public string Id { get; internal set; }
    public decimal TotalAmount { get; internal set; }
    public decimal CollectedAmount { get; internal set; }
    public DateTime CreatedAt { get; internal set; }
    public DateTime ExpiresAt { get; internal set; }
    public string ReceivingAccountId {get; internal set; }
    public ReceivingAccountType ReceivingAccountType { get; internal set; }
    public string To { get; internal set; }
    public string? Notes { get; internal set; }
    public List<Order>? Orders { get; internal set; }
    
    [NotMapped] public ReceivingAccountInfo.Account? Mobile => JsonSerializer.Deserialize<ReceivingAccountInfo.Account>(To, JsonSerializerOptionsUtils.DefaultJsonSerializerOptions);
    [NotMapped] public ReceivingAccountInfo.Wallet? Wallet => JsonSerializer.Deserialize<ReceivingAccountInfo.Wallet>(To, JsonSerializerOptionsUtils.DefaultJsonSerializerOptions);
    [NotMapped] public ReceivingAccountInfo.InstaPay? InstaPay => JsonSerializer.Deserialize<ReceivingAccountInfo.InstaPay>(To, JsonSerializerOptionsUtils.DefaultJsonSerializerOptions);
    [NotMapped] public ReceivingAccountInfo.BankAccount? BankAccount => JsonSerializer.Deserialize<ReceivingAccountInfo.BankAccount>(To, JsonSerializerOptionsUtils.DefaultJsonSerializerOptions);
    [NotMapped] public ReceivingAccountInfo.BankIban? BankIban => JsonSerializer.Deserialize<ReceivingAccountInfo.BankIban>(To, JsonSerializerOptionsUtils.DefaultJsonSerializerOptions);
    
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

