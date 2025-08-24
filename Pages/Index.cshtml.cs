using Microsoft.AspNetCore.Mvc.RazorPages;
using OpenRent.Pages.Models.Components;
using OpenRent.Pages.Enums;

namespace OpenRent.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public Hero Hero { get; set; } = new Hero {
            Title = "Renting the way it should be",
            IsPrimary = true,
            IsInverse = false,
            Body = "The destination for finding, advertising and managing rental property.",
            Buttons = new List<Button> 
                { 
                    new Button
                    {
                        ButtonText = "Tenant",
                        Route = "/Tenant",
                        Variant = Variant.Secondary
                    },
                    new Button
                    {
                        ButtonText = "Landlord",
                        Route = "/Landlord",
                        Variant = Variant.Primary
                    }
                }

        };

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
