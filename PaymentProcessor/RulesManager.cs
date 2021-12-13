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
        { var something = 2 ; 
        
            if (payment.PaymentInfo ==PaymentInfoEnum.PhysicalProductPayment)

            {

                payment.Attach(new GeneratePackingSlip());
                payment.Attach(new IssueCommission());
                

            }
            payment.PaymentProcessor();

        }


    }




}