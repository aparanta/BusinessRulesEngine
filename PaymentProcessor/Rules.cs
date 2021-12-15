using System;
using System.Collections.Generic;
using PaymentProcessor;
namespace PaymentProcessor.Rules

{
    //place holder for events or call to external apis
  
    public interface IRule
    {
        public Result TakeAction();
    }

    public class GeneratePackingSlip : IRule
    {
        public Result TakeAction()
        {
            return new Result { IsSuccess = true, ActionInfo = ActionInfo.GeneratePackingSlip };

        }
    }

    public class DuplicatePackingSlip : IRule
    {
        public Result TakeAction()
        {
            return new Result { IsSuccess = true, ActionInfo = ActionInfo.GeneratePackingSlip };

        }
    }


    public class ActivateMembership : IRule
    {
        public Result TakeAction()
        {
            return new Result { IsSuccess = true, ActionInfo = ActionInfo.ActivateMembership };

        }
    }

    public class IssueCommission : IRule
    {
        public Result TakeAction()
        {
            return new Result { IsSuccess = true, ActionInfo = ActionInfo.IssueCommission };

        }

    }

    public class EmailForActivation : IRule
    {
        public Result TakeAction()
        {
            return new Result { IsSuccess = true, ActionInfo = ActionInfo.EmailForActivation };

        }

    }

}