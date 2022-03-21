using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VokoBere.Services;

namespace VokoBere.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        private readonly ICardDealerService _Karty;

        private readonly GameManagerService _gameManager;

        [TempData]
        public string End { get; set; }

        public int Count { get; set; }
        public CardValue LastCard { get; set; }
        public List<CardValue> Cards { get; set; }


        public IndexModel(ILogger<IndexModel> logger, ICardDealerService cardDealerService, GameManagerService gameManager)
        {
            _logger = logger;
            _Karty = cardDealerService;
            _gameManager = gameManager;
            Cards = _Karty.GetAllCards();
        }

        public void OnGet()
        {
            List<CardValue> starting_hand = _gameManager.StartGame();
            LastCard = _gameManager.LastCard;
            Count = _gameManager.Count;
        }

        public IActionResult OnGetDraw(int count)
        {
            _gameManager.Draw(count);
            LastCard = _gameManager.LastCard;
            Count = _gameManager.Count;
            if(Count > 21 || Count == 21)
            {
                End = _gameManager.EndEarly();
                return RedirectToPage("Privacy");
            }
            return Page();
        }

        public IActionResult OnGetEndEarly(int count)
        {
            End = _gameManager.EndEarly();
            return RedirectToPage("Privacy");
        }

        public void OnGetReset()
        {
            Count = 0;
            _Karty.ShuffleDeck();
            Cards = _Karty.GetAllCards();
            _gameManager.Count = 0;
            _gameManager._DrawnCards.Clear();
            _gameManager.StartGame();
            LastCard = _gameManager.LastCard;
            Count = _gameManager.Count;
        }

    }
}