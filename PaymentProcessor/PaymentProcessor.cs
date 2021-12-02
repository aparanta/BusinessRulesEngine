using System;
using System.Collections.Generic;
using PaymentProcessor.Rules;
namespace PaymentProcessor

{

    public enum PaymentInfoEnum
    {
        PhysicalProductPayment,
        NewMembership,
        UpgradeMembership,
        BookPayment,

        VideoPayment,

        CommissionGenerated

    }


    public abstract class Payment
    {


        public DateTime Date { get; set; }

        public int Amount { get; set; }

        public string PaymentInfo { get; set; }


        private List<IRule> rules = new List<IRule>();

        private List<Result> results= new List<Result>();
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

        public Payment()
        {
            Notify();
        }
    }

    public class Result
    {
        public bool IsSuccess { get; set; }
        public PaymentInfoEnum ActionInfo { get; set; }
    }

    public class PhysicalProductPayment : Payment
    {

    }

    public class NewMembership : Payment
    {

    }

    public class UpgradeMembership : Payment
    {

    }

    public class VideoPayment : Payment
    {

    }


}
