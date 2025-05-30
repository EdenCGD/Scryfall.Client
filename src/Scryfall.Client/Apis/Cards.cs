﻿using Scryfall.Client.Models;
using System.Net;
using static Scryfall.Client.Models.SearchOptions;

namespace Scryfall.Client.Apis;

///<inheritdoc cref="ICards"/>
public class Cards : ICards
{
    private readonly BaseRestService _restService;

    internal Cards(BaseRestService restService)
    {
        _restService = restService;
    }

    public Task<ResultList<Card>> Get(int page) => _restService.GetAsync<ResultList<Card>>($"/cards?page={page}");

    public Task<Card> GetById(string id) => _restService.GetAsync<Card>($"/cards/{id}");

    public Task<Card> GetByArenaId(string id) => _restService.GetAsync<Card>($"/cards/arena/{id}");

    public Task<Card> GetByCardMarketId(string id) => _restService.GetAsync<Card>($"/cards/cardmarket/{id}");

    public Task<Card> GetByMultiverseId(string id) => _restService.GetAsync<Card>($"/cards/multiverse/{id}");

    public Task<Card> GetByMTGOId(string id) => _restService.GetAsync<Card>($"/cards/mtgo/{id}");

    public Task<Card> GetByTCGPlayerId(string id) => _restService.GetAsync<Card>($"/cards/tcgplayer/{id}");

    public Task<Card> GetRandom() => _restService.GetAsync<Card>($"/cards/random", false);

    public Task<ResultList<Card>> Search(string query, int page, CardSort sort) =>
        Search(query, page, new SearchOptions { Sort = sort });

    public Task<ResultList<Card>> Search(string query, int page, SearchOptions options = default)
    {
        if (page < 1) page = 1;

        query = WebUtility.UrlEncode(query);
        return _restService.GetAsync<ResultList<Card>>($"/cards/search?q={query}&page={page}&{options.BuildQueryString()}");
    }

    public Task<Card> GetBySetAndCollectorNumber(string set, int collectorNumber, string language = null) 
        => _restService.GetAsync<Card>($"/cards/{set}/{collectorNumber}{(language == null ? "" : $"/{language}")}");

    public Task<Card> GetByNamed(string name, bool isFuzzy = true, string set = null)
        => _restService.GetAsync<Card>($"/cards/named?{(isFuzzy ? $"fuzzy={name}" : $"exact={name}")}{(set == null ? "" : $"&set={set}")}");

    public async Task<string[]> ListAutoCompleteNames(string name) 
        => (await _restService.GetAsync<Catalog>($"/cards/autocomplete?q={name}").ConfigureAwait(false)).Data;

    public async Task<ResultList<Card>> GetByCollection(Identifier[] identifiers) 
        => await _restService.PostAsync<ResultList<Card>>("/cards/collection", new { identifiers });
}