using Foseball.Services;
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
    }
    
}