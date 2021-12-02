using System;
using System.Collections.Generic;
using PaymentProcessor;
namespace PaymentProcessor.Rules

{
    public interface IRuleManager
    {
        public void Manage(Payment payment);
    }

    public class RulesManager : IRuleManager
    {
      public  void Manage(Payment payment)
        {
           if( payment.Equals(typeof (PhysicalProductPayment)))

           {
             
               payment.Attach(new GeneratePackingSlip());
               payment.Attach(new IssueCommission() );


           }

        }
    }




}