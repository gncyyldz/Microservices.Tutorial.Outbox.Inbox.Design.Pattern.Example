using System.ComponentModel.DataAnnotations;

namespace Stock.Service.Models.Entities
{
    public class OrderInbox
    {
        [Key]
        public Guid IdempotentToken { get; set; }
        public bool Processed { get; set; }
        public string Payload { get; set; }
    }
}
