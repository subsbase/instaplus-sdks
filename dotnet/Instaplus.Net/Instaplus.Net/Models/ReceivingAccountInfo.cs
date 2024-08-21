namespace Instaplus.Net.Models;

public class ReceivingAccountInfo
{
    public sealed class Account  : ReceivingAccountInfo
    {
        public string Number { get; set; } = default!;
    }

    public sealed class Wallet : ReceivingAccountInfo
    {
        public string Number { get; set; } = default!;
    }

    public sealed class BankIban : ReceivingAccountInfo
    {
        public string Iban { get; set; } = default!;
        public string ReceiverName { get; set; } = default!;
    }

    public sealed class BankAccount : ReceivingAccountInfo
    {
        public string BankCode { get; set; } = default!;
        public string AccountNumber { get; set; } = default!;
        public string ReceiverName { get; set; } = default!;
    }

    public sealed class InstaPay : ReceivingAccountInfo
    {
        public string IPA { get; set; } = default!;
        public string? Link { get; set; }
    }
}