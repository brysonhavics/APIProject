using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Foseball.Services;
using FoseBall.Model;

namespace FoseBall.WebAPI.Controllers
{
    public class LeagueController : ApiController
    {
        private LeagueService CreateLeagueService()
        {
            var leagueService = new LeagueService();
            return leagueService;
        }

        public IHttpActionResult Get()
        {
            LeagueService leagueService = CreateLeagueService();
            var leagues = leagueService.GetLeagues();
            return Ok(leagues);
        }

        public IHttpActionResult Post(LeagueCreate model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateLeagueService();

            if (!service.CreateLeague(model))
                return InternalServerError();

            return Ok();
        }
    }
}
