using System;
using System.Collections.Generic;
using PaymentProcessor;
namespace PaymentProcessor.Rules

{
    public interface IRulesManager
    {
        public void Manage(Payment payment);
    }



    public class RulesManager : IRulesManager
    {
        public RulesManager()
        {
        }

        public void Manage(Payment payment)
        {
            switch (payment.PaymentInfo)
            {
                case PaymentInfo.PhysicalProductPayment:
                    //if (payment.PaymentInfo ==PaymentInfo.PhysicalProductPayment)

                    payment.Attach(new GeneratePackingSlip());
                    payment.Attach(new IssueCommission());
                    payment.Attach(new EmailForActivation());
                    break;


                default:
                    break;
            }
            payment.PaymentProcessor();

        }


    }




}