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
    public class CoachController : ApiController
    {
        private CoachService CreateCoachService()
        {
            var coachService = new CoachService();
            return coachService;
        }

        [HttpGet]
        public IHttpActionResult Get()
        {
            CoachService coachService = CreateCoachService();
            var coaches = coachService.GetCoach();
            return Ok(coaches);
        }

        [HttpGet]
        [Route("api/Coach/Id/{id}")]
        public IHttpActionResult Get(int id)
        {
            CoachService coachService = CreateCoachService();
            var coach = coachService.GetCoachByID(id);
            return Ok(coach);
        }

        [HttpGet]
        [Route("api/Coach/Nationality/{nationality}")]
        public IHttpActionResult Get(string nationality)
        {
            CoachService coachService = CreateCoachService();
            var coach = coachService.GetCoachByNationality(nationality);
            return Ok(coach);
        }

        [HttpPost]
        public IHttpActionResult Post(CoachCreate model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateCoachService();

            if (!service.CreateCoach(model))
                return InternalServerError();

            return Ok();
        }

        [HttpPut]
        public IHttpActionResult Put(CoachEdit model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var that = CreateCoachService();

            if (!that.UpdateCoach(model))
                return InternalServerError();

            return Ok();

        }

        [HttpDelete]
        [Route("api/League/{id}")]
        public IHttpActionResult Delete(int id)
        {
            var service = CreateCoachService();

            if (!service.DeleteCoach(id))
                return InternalServerError();

            return Ok();
        }
    }
}
