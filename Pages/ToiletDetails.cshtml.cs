using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ToiletFinder3000.Model;
using ToiletFinder3000.Services;

namespace ToiletFinder3000.Pages
{
    public class ToiletDetailsModel : PageModel
    {
        public Toilet Toilet { get; set; }
        private readonly ToiletService _toiletService;
        public ToiletDetailsModel(ToiletService toiletService)
        {
            _toiletService = toiletService;
        }

        public void OnGet(string id)
        {
            Toilet = _toiletService.GetToiletById(id);
        }
    }
}
