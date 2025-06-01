using Scryfall.Client.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Scryfall.Client.Apis
{
    ///<inheritdoc cref="IRulings"/>
    public class Rulings : IRulings
    {
        private readonly BaseRestService RestService;

        internal Rulings(BaseRestService restService)
        {
            RestService = restService;
        }

        public Task<ResultList<Ruling>> GetByArenaId(string id)
            => RestService.GetAsync<ResultList<Ruling>>($"/cards/arena/{id}/rulings");

        public Task<ResultList<Ruling>> GetById(string id)
            => RestService.GetAsync<ResultList<Ruling>>($"/cards/{id}/rulings");

        public Task<ResultList<Ruling>> GetByMTGOId(string id)
            => RestService.GetAsync<ResultList<Ruling>>($"/cards/mtgo/{id}/rulings");

        public Task<ResultList<Ruling>> GetByMultiverseId(string id)
            => RestService.GetAsync<ResultList<Ruling>>($"/cards/multiverse/{id}/rulings");

        public Task<ResultList<Ruling>> GetBySetAndCollectorNumber(string set, int collectorNumber)
            => RestService.GetAsync<ResultList<Ruling>>($"/cards/{set}/{collectorNumber}/rulings");
    }
}
