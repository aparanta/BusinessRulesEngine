
using System.Threading.Tasks;

namespace BusinessRulesEngine.Interfaces 
{
    

public interface IPaymentManager
{
    public Task<string> Manage(IPayment payment);

}

public interface IPaymentProcessor
{
    public Task<string> Process(IPayment payment);

}
}