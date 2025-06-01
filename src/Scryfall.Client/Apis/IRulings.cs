using Scryfall.Client.Models;

namespace Scryfall.Client.Apis
{
    /// <summary>
    /// API for Rulings. Rulings represent Oracle rulings, Wizards of the Coast set release notes, or Scryfall notes for a particular card.
    /// </summary>
    public interface IRulings
    {
        /// <summary>
        /// Returns a List of rulings for a card with the given Scryfall ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<ResultList<Ruling>> GetById(string id);

        /// <summary>
        /// Returns a List of rulings for the card with the given set code and collector number.
        /// </summary>
        /// <param name="set"></param>
        /// <param name="collectorNumber"></param>
        /// <returns></returns>
        Task<ResultList<Ruling>> GetBySetAndCollectorNumber(string set, int collectorNumber);

        /// <summary>
        /// Returns rulings for a card with the given Magic: The Gathering Arena ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<ResultList<Ruling>> GetByArenaId(string id);

        /// <summary>
        /// Returns rulings for a card with the given MTGO ID (also known as the Catalog ID). The ID can either be the card’s mtgo_id or its mtgo_foil_id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<ResultList<Ruling>> GetByMTGOId(string id);

        /// <summary>
        /// Returns a List of rulings for a card with the given Multiverse ID. If the card has multiple multiverse IDs, this method can find either of them.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<ResultList<Ruling>> GetByMultiverseId(string id);
    }
}
