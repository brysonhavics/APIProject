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
        public IHttpActionResult Post(InternationalCreate international)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateInternationalService();

            if (!service.CreateInternational(international))
                return InternalServerError();

            return Ok();
        }

        public IHttpActionResult Put(InternationalEdit international)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateInternationalService();

            if (!service.UpdateInternational(international))
                return InternalServerError();
            return Ok();
        }
        
        
    }
    
}