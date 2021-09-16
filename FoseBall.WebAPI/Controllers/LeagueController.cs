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

        [HttpGet]
        public IHttpActionResult Get()
        {
            LeagueService leagueService = CreateLeagueService();
            var leagues = leagueService.GetLeagues();
            return Ok(leagues);
        }

        [HttpGet]
        [Route("api/League/Id/{id}")]
        public IHttpActionResult Get(int id)
        {
            LeagueService leagueService = CreateLeagueService();
            var league = leagueService.GetLeagueByID(id);
            return Ok(league);
        }

        [HttpGet]
        [Route("api/League/Nation/{nation}")]
        public IHttpActionResult Get(string nation)
        {
            LeagueService leagueService = CreateLeagueService();
            var league = leagueService.GetLeagueByNation(nation);
            return Ok(league);
        }

        [HttpPost]
        public IHttpActionResult Post(LeagueCreate model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateLeagueService();

            if (!service.CreateLeague(model))
                return InternalServerError();

            return Ok();
        }

        [HttpPut]
        public IHttpActionResult Put(LeagueEdit model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var that = CreateLeagueService();

            if (!that.UpdateLeague(model))
                return InternalServerError();

            return Ok();

        }

        [HttpDelete]
        [Route("api/League/{id}")]
        public IHttpActionResult Delete(int id)
        {
            var service = CreateLeagueService();

            if (!service.DeleteLeague(id))
                return InternalServerError();

            return Ok();
        }
    }
}
