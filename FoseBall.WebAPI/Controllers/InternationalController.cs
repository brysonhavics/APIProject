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
            var InternationalId = Guid.Parse(Id.Coach.Ranking.Name());
            var InternationalService = new InternationalService(internationalId);
            return InternationalService;
        }
    }
    
}