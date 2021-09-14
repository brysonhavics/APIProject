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
    [Authorize]
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

    }
}