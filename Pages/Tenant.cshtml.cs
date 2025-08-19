using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace OpenRent.Pages
{
    public class TenantModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public TenantModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }

}
