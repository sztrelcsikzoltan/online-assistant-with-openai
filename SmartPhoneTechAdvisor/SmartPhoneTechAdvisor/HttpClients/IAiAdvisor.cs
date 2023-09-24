using Refit;
using SmartPhoneTechAdvisor.Models;


namespace SmartPhoneTechAdvisor.HttpClients
{
    public interface IAiAdvisor
    {
        [Get("/{phone}")]
        Task<AiPhoneSpec> GetPhoneSpecsAsync(string phone);
    }
}
