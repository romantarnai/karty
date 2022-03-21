## Jednadvacítka

Vytvořte webovou aplikace pro jednoho uživatele realizující hru Jednadvacítka. Nehrajeme se sázkami.
Zadání se zaměřuje na implementaci Dependency Injection ve frameworku ASP.nET a TempData

* [Wikipedie](https://cs.wikipedia.org/wiki/Jednadvacet)
* [Popis hry](https://karetnihry.blogspot.com/2011/04/oko-jednadvacet.html)

## K dispozici

* Služba Randomizer pro generování náhodných čísel
* Služba CardDealerService pro správu herního balíčku (není kompletní)
* Enum CardValue obsahující názvy karet a jejich číselné hodnoty
* Základ služby GameManagerService (není kompletní)
* každý své znalosti a dovednosti

## Body zadání
1. Připojte do aplikace služby Randomizer a CardDealerService přes příslušná rozhraní vhodnou metodou
1. Vložte službu Randomizer do CardDealerService
1. Zprovozněte získávání náhodných karet z balíčku karet
1. Vytvořte vlastní službu pro správu samotné hry tak, aby do stránky bylo možné vložit pouze tuto službu
    1. Vytvořte metodu pro získání další karty z balíčku
    1. Vytvořte metodu pro konec kola
    1. Vytvořte kód pro evidenci hodnoty získaných karet (jen jejich součet)
    1. Vytvořte kód pro reset hry
    1. vytvořte kód pro vyhodnocení stavu hry, zamyslete se nad tím, kam jej umístit a co má vracet
1. vytvořte stránku pro hraní hry, hru lze realizovat pomocí více stránek nebo handlerů
1. Výsledek hry oznamujte pomocí TempData
