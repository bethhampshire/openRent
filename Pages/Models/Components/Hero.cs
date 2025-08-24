namespace OpenRent.Pages.Models.Components
{
    public class Hero
    {
        public string Title { get; set; } = string.Empty;
        public bool IsPrimary { get; set; }
        public string Body { get; set; }
        public List<Button>? Buttons { get; set; }
        public bool IsInverse { get; set; }
    }
}
