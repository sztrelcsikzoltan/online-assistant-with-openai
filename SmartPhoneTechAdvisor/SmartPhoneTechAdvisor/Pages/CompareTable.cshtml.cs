using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SmartPhoneTechAdvisor.HttpClients;
using SmartPhoneTechAdvisor.Models;

namespace SmartPhoneTechAdvisor.Pages
{
    public class CompareTableModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public List<string> Phones { get; set; } = new();
        public List<AiPhoneSpec> PhoneSpecs { get; set; } = new();

        private readonly IAiAdvisor _aiAdvisor;

        public CompareTableModel(IAiAdvisor aiAdvisor)
        {
            _aiAdvisor = aiAdvisor;
        }

        public async Task OnGetAsync()
        // public async void OnGetAsync()
        {
            foreach (var phone in Phones)
            {
                var phoneSpec = await _aiAdvisor.GetPhoneSpecsAsync(phone);
                PhoneSpecs.Add(phoneSpec);
            }
        }

    }
}
