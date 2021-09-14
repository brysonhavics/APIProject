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

        }
    }
}
