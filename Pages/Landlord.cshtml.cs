using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace OpenRent.Pages
{
    public class LandlordModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public LandlordModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }

}
