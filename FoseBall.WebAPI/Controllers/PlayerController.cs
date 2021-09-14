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
        public IHttpActionResult GetPlayerById(int id)
        {
            PlayerService playerService = CreatePlayerService();
            var player = playerService.GetPlayerById(id);
            return Ok(player);
        }

        private PlayerService CreatePlayerService()
        {
            var teamService = new PlayerService();
            return teamService;
        }
    }
}
