using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OpenRent.Pages.Enums;
using OpenRent.Pages.Models.Components;

namespace OpenRent.Pages
{
    public class LandlordModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public LandlordModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }
        public Hero Hero { get; set; } = new Hero
        {
            Title = "Discover the services we provide for Landlords",
            IsPrimary = true,
            IsInverse = true,
            Body = "We find you tenants and help with referencing, contracts and more if you need it.",
        };

        public Logo Logo { get; set; } = new Logo
        {
            Variant = Variant.PrimaryInverse,
        };

        public void OnGet()
        {
        }
    }

}
