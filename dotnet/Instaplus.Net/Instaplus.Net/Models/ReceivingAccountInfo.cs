namespace Instaplus.Net.Models;

public class ReceivingAccountInfo
{
    public sealed class Account 
    {
        public string Number { get; internal set; } = default!;
    }

    public sealed class Wallet
    {
        public string Number { get; internal set; } = default!;
    }

    public sealed class BankIban
    {
        public string Iban { get; internal set; } = default!;
        public string ReceiverName { get; internal set; } = default!;
    }

    public sealed class BankAccount
    {
        public string BankCode { get; internal set; } = default!;
        public string AccountNumber { get; internal set; } = default!;
        public string ReceiverName { get; internal set; } = default!;
    }

    public sealed class InstaPay
    {
        public string IPA { get; internal set; } = default!;
        public string? Link { get; internal set; }
    }
}