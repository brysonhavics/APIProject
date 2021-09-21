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
    public class TransferController : ApiController
    {
        [HttpPost]
        [Route("api/Transfer")]
        public IHttpActionResult PostTransfer(TransferCreate transfer)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateTransferService();

            if (!service.CreateTransfer(transfer))
                return InternalServerError();

            return Ok();
        }

        [HttpGet]
        [Route("api/Transfer")]
        public IHttpActionResult GetAllTransfers()
        {
            TransferService transferService = CreateTransferService();
            var transfers = transferService.GetAllTransfers();
            return Ok(transfers);
        }

        [HttpGet]
        [Route("api/Transfer/{id}")]
        public IHttpActionResult GetTransferById(int id)
        {
            TransferService transferService = CreateTransferService();
            var transfer = transferService.GetTransferById(id);
            return Ok(transfer);
        }

        public TransferService CreateTransferService()
        {
            var teamService = new TransferService();
            return teamService;
        }
    }
}
