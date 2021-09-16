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
    public class PlayerController : ApiController
    {
        [HttpPost]
        public IHttpActionResult PostPlayer(PlayerCreate player)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreatePlayerService();

            if (!service.CreatePlayer(player))
                return InternalServerError();

            return Ok();
        }

        [HttpGet]
        public IHttpActionResult GetAllPlayers()
        {
            PlayerService playerService = CreatePlayerService();
            var players = playerService.GetAllPlayers();
            return Ok(players);
        }

        [HttpGet]
        [Route("api/Player/{id}")]
        public IHttpActionResult GetPlayerById(int id)
        {
            PlayerService playerService = CreatePlayerService();
            var player = playerService.GetPlayerById(id);
            return Ok(player);
        }

        [HttpGet]
        [Route("api/Player/Team/{id}")]
        public IHttpActionResult GetPlayersByTeam(int id)
        {
            PlayerService playerService = CreatePlayerService();
            var players = playerService.GetPlayersByTeam(id);
            return Ok(players);
        }


        [HttpGet]
        public IHttpActionResult GetPlayersByPosition(string position)
        {
            PlayerService playerService = CreatePlayerService();
            var players = playerService.GetPlayersByPostition(position);
            return Ok(players);
        }

        [HttpPut]
        public IHttpActionResult EditPlayers(PlayerEdit player)
        {
            if (ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreatePlayerService();

            if (!service.PlayerEdit(player))
                return InternalServerError();

            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult DeletePlayer(int id)
        {
            var service = CreatePlayerService();
            if (!service.DeleteNote(id))
                return InternalServerError();

            return Ok();
        }

        private PlayerService CreatePlayerService()
        {
            var teamService = new PlayerService();
            return teamService;
        }
    }
}
