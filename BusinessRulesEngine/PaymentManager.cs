using System;
using System.Threading.Tasks;

namespace BusinessRulesEngine.Managers
{
    public interface IPaymentManager {
        public  Task<string> Manage(IPayment payment);
        
    }
    public class PaymentManager :IPaymentManager
    {
        public async Task<string> Manage(IPayment payment)
        { //TODO
            var paymentProcessor = new PaymentProcessor();

            return await paymentProcessor.Process(payment);
        }
    }
}
