using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


namespace BusinessRulesEngine.Managers
{
    
    public class PaymentProcessor 
    {
        private static readonly HttpClient httpClient = new HttpClient();
        public async Task<string> Process(IPayment payment)
        { //TODO
            var jsonPayment = JsonSerializer.Serialize<IPayment>(payment);
            var stringContent = new StringContent(jsonPayment, UnicodeEncoding.UTF8, "application/json");

            //TODO
            var response = await httpClient.PostAsync("https://mockup/mockendpoint", stringContent);

            return response.Content.ReadAsStringAsync().Result;
        }
    }
}