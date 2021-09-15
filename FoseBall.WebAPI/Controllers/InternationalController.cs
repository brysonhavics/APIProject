using Foseball.Services;
using FoseBall.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace FoseBall.WebAPI
{
    public class InternationalController : ApiController
    {
        private InternationalService CreateInternationalService()
        {
            
            var InternationalService = new InternationalService();
            return InternationalService;
        }

        [HttpGet]
        public IHttpActionResult Get()
        {
            InternationalService internationalService = CreateInternationalService();
            var international = internationalService.GetAllInternational();
            return Ok(international);
        }

        [HttpPost]
        public IHttpActionResult Post(InternationalCreate international)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateInternationalService();

            if (!service.CreateInternational(international))
                return InternalServerError();

            return Ok();
        }

        [HttpPut]
        public IHttpActionResult Put(InternationalEdit international)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateInternationalService();

            if (!service.UpdateInternational(international))
                return InternalServerError();
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult Delete(int international)
        {
            var service = CreateInternationalService();

            if (!service.DeleteInternational(international))
                return InternalServerError();

            return Ok();
        }
        
        
    }
    
}