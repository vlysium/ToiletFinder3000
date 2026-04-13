using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ToiletFinder3000.Model;
using ToiletFinder3000.Services;

namespace ToiletFinder3000.Pages
{
    public class CreateToiletModel : PageModel
    {
        [BindProperty]
        public required string NickName { get; set; }

        [BindProperty]
        public required string Street { get; set; }

        [BindProperty]
        public required string PostalCode { get; set; }

        [BindProperty]
        public required string City { get; set; }

        private ToiletService _toiletService;

        public CreateToiletModel(ToiletService toiletService)
        {
            _toiletService = toiletService;
        }

        public IActionResult OnPost()
        {
            Address address = new Address(Street, PostalCode, City);
            Toilet toilet = new Toilet(Guid.NewGuid().ToString(), NickName, address);
            _toiletService.AddToilet(toilet);

            return Redirect("/");
        }
    }
}
