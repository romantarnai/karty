using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VokoBere.Services;

namespace VokoBere.Services
{
    public class GameManagerService
    {
        private ICardDealerService _cardDealerService;

        public CardValue LastCard { get; set; }

        public List<CardValue> _DrawnCards { get; set; } = new List<CardValue>();

        public string EndEarlyMessage { get; set; }

        public int Count { get; set; }

        public GameManagerService(ICardDealerService cardDealerService)
        {
            _cardDealerService = cardDealerService;
        }

        public List<CardValue> StartGame()
        {
            List<CardValue> cards = new List<CardValue>();
            for (int i = 0; i < 2; i++)
            {
                LastCard = _cardDealerService.Fetch();
                Count = Count + (int)LastCard;
                _DrawnCards.Add(LastCard);
                cards.Add(LastCard);
            }

            return cards;
        }

        public CardValue Draw(int count)
        {
            LastCard = _cardDealerService.Fetch();
            Count = count + (int)LastCard;
            _DrawnCards.Add(LastCard);
            return LastCard;
        }

        public string EndEarly()
        {
            string karticky = "";
            foreach(var c in _DrawnCards)
            {
                karticky += c.ToString() + ", ";
            }
            if(Count > 21)
            {
                return EndEarlyMessage = $"Prohrál si, tvoje karty byly: {karticky} a jejich hodnota byla: {Count}";
            }
            else if(Count == 21)
            {
                return EndEarlyMessage = $"Vyhrál si, tvoje karty byly: {karticky} a jejich hodnota byla: {Count}";
            }
            else
            {
                return EndEarlyMessage = $"Konec hry, tvoje karty byly: {karticky} a jejich hodnota byla: {Count}";
            }
        }
    }
}
