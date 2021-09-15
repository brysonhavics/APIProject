using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Foseball.Services;
using FoseBall.Data;
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

        public LeagueDetail GetLeagueByID(int id)
        {
            using (var ctx = new FoseBallDbContext())
            {
                var entity = ctx.Leagues.Single(e => e.LeagueId == id);
                return new LeagueDetail
                {
                    Name = entity.Name,
                    NumberOfTeams = entity.NumberOfTeams,
                    Nation = entity.Nation
                };
            }
        }

        public IHttpActionResult Put(LeagueEdit model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var that = CreateLeagueService();

            if (!that.UpdateLeague(model))
                return InternalServerError();

            return Ok();

        }
    }
}
