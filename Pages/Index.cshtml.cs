using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ToiletFinder3000.Model;
using ToiletFinder3000.Services;

namespace ToiletFinder3000.Pages
{
    public class IndexModel : PageModel
    {
        public List<Toilet> Toilets { get; set; }

        private readonly ILogger<IndexModel> _logger;
        private readonly ToiletService _toiletService;

        [BindProperty]
        public required string Id { get; set; }

        [BindProperty]
        public string Query { get; set; }

        public IndexModel(ILogger<IndexModel> logger, ToiletService toiletService)
        {
            _logger = logger;
            _toiletService = toiletService;
            Toilets = toiletService.GetAllToilets();
        }

        public void OnGet() { }

        public IActionResult OnPostDelete()
        {
            _toiletService.DeleteToilet(Id);
            return Redirect("/");
        }

        public IActionResult OnPostSearch()
        {
            if (string.IsNullOrEmpty(Query))
            {
                Toilets = _toiletService.GetAllToilets();
            }
            else
            {
                Toilets = _toiletService.SearchToilets(Query);
            }
            return Page();
        }
    }
}
