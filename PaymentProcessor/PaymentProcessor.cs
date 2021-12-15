using System;
using System.Collections.Generic;
using PaymentProcessor.Rules;
namespace PaymentProcessor

{

    public enum PaymentInfo
    {
        PhysicalProductPayment,
        NewMembership,
        UpgradeMembership,
        BookPayment,

        VideoPayment,

    }


    public enum ActionInfo
    {
        GeneratePackingSlip,
        ActivateMembership,

        IssueCommission,

        EmailForActivation,

        UpgradeMembership

    }

    public abstract class Product
    {
        public string Title { get; set; }

    }




    public abstract class Payment
    {


        public DateTime Date { get; set; }

        public int Amount { get; set; }

        public PaymentInfo PaymentInfo { get; set; }

        public Product Product { get; set; }

        private List<IRule> rules = new List<IRule>();

        public List<Result> results = new List<Result>();
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
                this.results.Add(rule.TakeAction());
            }
            //   Console.WriteLine("");
        }
        public void PaymentProcessor()
        {
            Notify();

        }
        public Payment()
        {
        }
    }

    public class Result
    {
        public bool IsSuccess { get; set; }
        public ActionInfo ActionInfo { get; set; }
    }

    public class PhysicalProductPayment : Payment
    {
        public PhysicalProductPayment()
        {
            this.PaymentInfo = PaymentInfo.PhysicalProductPayment;
        }
    }

    public class NewMembership : Payment
    {
        public NewMembership()
        {
            this.PaymentInfo = PaymentInfo.NewMembership;
        }
    }

    public class UpgradeMembership : Payment
    {
        public UpgradeMembership()
        {
            this.PaymentInfo = PaymentInfo.UpgradeMembership;
        }
    }

    public class VideoPayment : Payment
    {
        public VideoPayment()
        {
            this.PaymentInfo = PaymentInfo.VideoPayment;
        }
    }

    public class BookPayment : Payment
    {
        public BookPayment()
        {
            this.PaymentInfo = PaymentInfo.BookPayment;
           
        }
    }


}
