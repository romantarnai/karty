namespace VokoBere.Services
{
    public interface IRandomizer
    {
        /// <summary>
        /// Získá náhodné číslo v rozsahu 0..number
        /// </summary>
        /// <param name="number">Maximální rozsah intervalu ze kterého se generují náhodná čísla.</param>
        /// <returns>Náhodné číslo</returns>
        int Generate(int number);
    }
}
