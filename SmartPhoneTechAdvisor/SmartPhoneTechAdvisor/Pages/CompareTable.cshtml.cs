using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SmartPhoneTechAdvisor.Models;

namespace SmartPhoneTechAdvisor.Pages
{
    public class CompareTableModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public List<string> Phones { get; set; } = new();
        public List<AiPhoneSpec> PhoneSpecs { get; set; } = new();

        public void OnGet()
        {
        }
    }
}
