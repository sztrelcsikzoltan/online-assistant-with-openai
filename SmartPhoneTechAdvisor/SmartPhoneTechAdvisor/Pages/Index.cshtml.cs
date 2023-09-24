using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SmartPhoneTechAdvisor.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public string? PhoneName1 { get; set; }
        [BindProperty]
        public string? PhoneName2 { get; set; }

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            _logger.LogInformation($"OnPost() called {PhoneName1}, {PhoneName2}");
            return RedirectToPage("CompareTable", new { Phones = new[] { PhoneName1, PhoneName2 } });
        }

    }
}