namespace Accounts.Service.Models
{
    public class AccountUpdateModel
    {
        public string TransactionId { get; set; }
        public string SenderAccountId { get; set; }
        
        public string ReceiverAccountId { get; set; }
        
        public long Amount { get; set; }

        public string Message { get; set; }

        public string UserId { get; set; }
    }
}