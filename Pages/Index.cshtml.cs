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

        public IndexModel(ILogger<IndexModel> logger, ToiletService toiletService)
        {
            _logger = logger;
            Toilets = toiletService.GetAllToilets();
        }

        public void OnGet()
        {

        }
    }
}
