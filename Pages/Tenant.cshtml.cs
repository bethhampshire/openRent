using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OpenRent.Pages.Enums;
using OpenRent.Pages.Models.Components;

namespace OpenRent.Pages
{
    public class TenantModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public TenantModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public NavBar NavBar { get; set; } = new NavBar
        {
            Variant = Variant.Primary,
            Logo = new Logo
            {
                Variant = Variant.Primary
            }
        };

        public void OnGet()
        {
        }
    }

}
