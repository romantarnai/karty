using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VokoBere.Services;

namespace VokoBere.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        private readonly ICardDealerService _Karty;

        public int Count { get; set; }
        [TempData]
        public string End { get; set; }
        public CardValue LastCard { get; set; } = CardValue.nothing;
        public List<CardValue> Cards { get; set; }

        public IndexModel(ILogger<IndexModel> logger, ICardDealerService cardDealerService)
        {
            _logger = logger;
            _Karty = cardDealerService;
            Cards = _Karty.GetAllCards();
        }

        public void OnGet()
        {

        }

        public IActionResult OnGetDraw(int count)
        {
            LastCard = _Karty.Fetch();
            Count = count + (int)LastCard;
            if(Count == 21)
            {
                End = "Vyhrál si";
                return RedirectToPage("Privacy");
            }
            else if(Count > 21)
            {
                End = "Prohrál si";
                return RedirectToPage("Privacy");
            }
            return Page();
        }
    }
}