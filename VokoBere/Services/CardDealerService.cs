namespace VokoBere.Services
{
    public class CardDealerService: ICardDealerService
    {
        private List<CardValue> _deck = new List<CardValue> {
            CardValue.Seven, CardValue.Seven, CardValue.Seven, CardValue.Seven,
            CardValue.Eight, CardValue.Eight, CardValue.Eight, CardValue.Eight,
            CardValue.Nine, CardValue.Nine, CardValue.Nine, CardValue.Nine,
            CardValue.Ten, CardValue.Ten, CardValue.Ten, CardValue.Ten,
            CardValue.Jack, CardValue.Jack, CardValue.Jack, CardValue.Jack,
            CardValue.Queen, CardValue.Queen, CardValue.Queen, CardValue.Queen,
            CardValue.King, CardValue.King, CardValue.King, CardValue.King,
            CardValue.Ace, CardValue.Ace, CardValue.Ace, CardValue.Ace
        };

        private IRandomizer _random;
        private int _position = 0;

        public CardDealerService()
        {
            // ???
            ShuffleDeck();
        }

        public List<CardValue> GetAllCards()
        {
            return _deck;
        }

        public void ShuffleDeck()
        {
            int n = _deck.Count;
            while (n > 0)
            {
                n--;
                int k = _random.Generate(n);
                CardValue value = _deck[k];
                _deck[k] = _deck[n];
                _deck[n] = value;
            }
            _position = 0;
        }

        public CardValue Fetch()
        {
            if (_position == _deck.Count - 1)
            {
                ShuffleDeck();
            }
            return _deck[_position++];
        }
    }
}
