using System;

namespace SaveiPhone.Models
{
    public class Purchase
    {
        public int PurchaseId { get; set; }
        public string Person { get; set; }
        public string PhoneNumber { get; set; }
        public int PhoneId { get; set; }
        public DateTime Date { get; set; }
    }
}