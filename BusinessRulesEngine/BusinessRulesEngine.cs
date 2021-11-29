using System;

namespace BusinessRulesEngine
{
    public interface IPayment {
        
    }
    public class Payment :IPayment
    {
        public DateTime Date { get; set; }

        public int Amount  { get; set; }

        public string PaymentInfo { get; set; }
    }
}
