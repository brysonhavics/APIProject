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
    public class GameController : ApiController
    {
        private GameServices CreateGameService()
        {
            var gameService = new GameServices();
            return gameService;
        }

        [HttpPost]
        public IHttpActionResult Post(GameCreate game)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateGameService();

            if (!service.CreateGame(game))
                return InternalServerError();

            return Ok();
        }

        [HttpGet]
        public IHttpActionResult Get()
        {
            GameServices gameServices = CreateGameService();
            var games = gameServices.GetGames();
            return Ok(games);
        }

        [HttpGet]
        [Route("api/Game/{id}")]
        public IHttpActionResult GetGameById(int id)
        {
            GameServices gameService = CreateGameService();
            var game = gameService.GetGameById(id);
            return Ok(game);
        }

        [HttpDelete]
        [Route("api/Game/Delete/{id}")]
        public IHttpActionResult Delete(int id)
        {
            var service = CreateGameService();
            if (!service.DeleteGame(id))
                return InternalServerError();

            return Ok();
        }
    }
}