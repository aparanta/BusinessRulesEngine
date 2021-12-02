using System;
using System.Collections.Generic;
using PaymentProcessor;
namespace PaymentProcessor.Rules

{
    public interface IRule
    {
        public Result TakeAction();
    }

    public class GeneratePackingSlip : IRule
    {
      public  Result TakeAction()
        {
            return new Result { IsSuccess = true, ActionInfo = PaymentInfoEnum.PhysicalProductPayment };

        }
    }


public class ActivateMembership : IRule
    {
     public   Result TakeAction()
        {
            return new Result { IsSuccess = true, ActionInfo = PaymentInfoEnum.NewMembership };

        }
    }

public class IssueCommission :IRule
{
    public  Result TakeAction()
        {
            return new Result { IsSuccess = true, ActionInfo = PaymentInfoEnum.CommissionGenerated };

        }

}

}