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

                 case PaymentInfo.BookPayment:
                    //if (payment.PaymentInfo ==PaymentInfo.PhysicalProductPayment)

                    payment.Attach(new GeneratePackingSlip());
                    payment.Attach(new DuplicatePackingSlip());
                    //TODO add product class to differentiate and pull rules
                    break;

                 case PaymentInfo.VideoPayment:
                    //if (payment.PaymentInfo ==PaymentInfo.PhysicalProductPayment)

                    payment.Attach(new GeneratePackingSlip());
                    
                    break;


                default:
                    break;
            }
            payment.PaymentProcessor();

        }


    }




}