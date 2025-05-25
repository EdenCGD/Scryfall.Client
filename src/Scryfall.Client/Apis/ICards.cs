using Scryfall.Client.Models;
using static Scryfall.Client.Models.SearchOptions;

namespace Scryfall.Client.Apis;

/// <summary>
/// APIs for cards. Card objects represent individual Magic: The Gathering cards that players could
/// obtain and add to their collection (with a few minor exceptions).
/// </summary>
public interface ICards
{
    /// <summary>
    /// Fetch a card at random.
    /// </summary>
    /// <returns></returns>
    Task<Card> GetRandom();

    /// <summary>
    /// Get a page worth of cards
    /// </summary>
    /// <param name="page"></param>
    /// <returns></returns>
    Task<ResultList<Card>> Get(int page);

    /// <summary>
    /// Get a single card by the Scryfall Id
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task<Card> GetById(string id);

    /// <summary>
    /// Get a single card by the TCG Player Id
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task<Card> GetByTCGPlayerId(string id);

    /// <summary>
    /// Get a single card by the Arena Id
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task<Card> GetByArenaId(string id);

    /// <summary>
    /// Get a single card by the MTGO Id
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task<Card> GetByMTGOId(string id);

    /// <summary>
    /// Get a single card by the CardMarket Id
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task<Card> GetByCardMarketId(string id);

    /// <summary>
    /// Get a single card by the Multiverse Id
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task<Card> GetByMultiverseId(string id);

    /// <summary>
    /// Search for cards with a sort option
    /// </summary>
    /// <param name="query"></param>
    /// <param name="page"></param>
    /// <param name="sort"></param>
    /// <returns></returns>
    Task<ResultList<Card>> Search(string query, int page, CardSort sort);
    
    /// <summary>
    /// Search for cards using the full search options available
    /// </summary>
    /// <param name="query"></param>
    /// <param name="page"></param>
    /// <param name="options"></param>
    /// <returns></returns>
    Task<ResultList<Card>> Search(string query, int page, SearchOptions options);

    /// <summary>
    /// Get a single card by the Set, Collector Number and language
    /// </summary>
    /// <param name="set"></param>
    /// <param name="collectorNumber"></param>
    /// <param name="language"></param>
    /// <returns></returns>
    Task<Card> GetBySetAndCollectorNumber(string set, int collectorNumber, string language = null);

    /// <summary>
    /// Returns a Card based on a name search string.
    /// </summary>
    /// <param name="name"></param>
    /// <param name="isFuzzy">Search for the card using a fuzzy search, if more than one card is found then an exception will be thrown explaining such.</param>
    /// <param name="set">Refine the search by providing the set code.</param>
    /// <returns></returns>
    Task<Card> GetByNamed(string name, bool isFuzzy = true, string set = null);
}
