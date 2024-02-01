using System;

namespace Project.Shared.Domain
{
    public class Cart : BaseDomainModel
    {
        public string CarName { get; set; }
        public int PurchaseId { get; set; }
        public int CustomerId { get; set; }
        public DateTime RentStart { get; set; }
        public DateTime RentEnd { get; set; }
        public bool IsCompleted { get; set; } // Flag to indicate whether the purchase is completed
    }
}
