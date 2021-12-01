using System;
using System.Threading.Tasks;
using BusinessRulesEngine.Interfaces;

namespace BusinessRulesEngine.Managers
{
    
    public class PaymentManager :IPaymentManager
    {
        private IPaymentProcessor paymentProcessor;

        public PaymentManager(IPaymentProcessor processor)
        {
            paymentProcessor = processor;
        }
        public async Task<string> Manage(IPayment payment)
        { //TODO
            

            return await paymentProcessor.Process(payment);
        }
    }
}
