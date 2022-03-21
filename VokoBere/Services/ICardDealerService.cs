namespace VokoBere.Services
{
    public interface ICardDealerService
    {
        /// <summary>
        /// Zamíchá balíček karet a posune ukazatel na aktuální kartu na jeho začátek
        /// </summary>
        void ShuffleDeck();
        /// <summary>
        /// Získá kartu na vrčku baličku a posune ukazatel na další, pokud už v balíčku žádná karta nezbývá, zamíchá celý balíček
        /// </summary>
        /// <returns></returns>
        CardValue Fetch();
        /// <summary>
        /// Získá obsah celého balíčku. Mělo by sloužit jen pro ladění aplikace.
        /// </summary>
        /// <returns></returns>
        List<CardValue> GetAllCards();
    }
}
