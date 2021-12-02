using System;
using System.Collections.Generic;
namespace PaymentProcessor

{

    public enum PaymentInfoEnum
    {
        PhysicalProductPayment,
        NewMembership,
        UpgradeMembership,
    }

    public interface IRule
    {
        void TakeAction() ;
    }
    public abstract class Payment
    {


        public DateTime Date { get; set; }

        public int Amount { get; set; }

        public string PaymentInfo { get; set; }

        
        private List<IRule> rules = new List<IRule>();
         public void Attach(IRule rule)
        {
            rules.Add(rule);
        }
        public void Detach(IRule rule)
        {
            rules.Remove(rule);
        }
        public void Notify()
        {
            foreach (IRule rule in rules)
            {
                rule.TakeAction();
            }
            Console.WriteLine("");
        }

        public Payment ()
        {
            Notify();
        }
    }

    public class Result
    {
        public bool IsSuccess { get; set; }
        public string ActionInfo { get; set; }
    }


    
}
