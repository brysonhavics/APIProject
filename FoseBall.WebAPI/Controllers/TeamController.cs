using Foseball.Services;
using FoseBall.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FoseBall.WebAPI.Controllers
{
    public class TeamController : ApiController
    {
        private TeamServices CreateTeamService()
        {
            var teamService = new TeamServices();
            return teamService;
        }

        [HttpGet]
        public IHttpActionResult Get()
        {
            TeamServices teamServices = CreateTeamService();
            var teams = teamServices.GetTeams();
            return Ok(teams);
        }
        [HttpPost]
        public IHttpActionResult Post(TeamCreate team)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateTeamService();

            if (!service.CreateTeam(team))
                return InternalServerError();

            return Ok();
        }

        [HttpGet]
        [Route("api/Team/{id}")]
        public IHttpActionResult GetTeamById(int id)
        {
            TeamServices teamService = CreateTeamService();
            var team = teamService.GetTeamById(id);
            return Ok(team);
        }

        [HttpGet]
        [Route("api/Team/League/{id}")]
        public IHttpActionResult GetTeamsInLeague(int id)
        {
            TeamServices teamService = CreateTeamService();
            var teams = teamService.GetTeamsByLeagueId(id);
            return Ok(teams);
        }

        [HttpGet]
        [Route("api/Team/League/Sorted/{id}")]
        public IHttpActionResult GetTeamsInLeagueSorted(int id)
        {
            TeamServices teamService = CreateTeamService();
            var teams = teamService.GetTeamsByLeagueRankSort(id);
            return Ok(teams);
        }

        [HttpPut]
        public IHttpActionResult Put(TeamEdit team)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var service = CreateTeamService();

            if (!service.UpdateTeam(team))
                return InternalServerError();

            return Ok();
        }

        public IHttpActionResult Delete(int id)
        {
            var service = CreateTeamService();
            if (!service.DeleteTeam(id))
                return InternalServerError();

            return Ok();
        }
    }
}