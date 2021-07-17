using Microsoft.AspNetCore.Mvc;
using PlanetaTest.Models;
using System.Collections.Generic;

namespace PlanetaTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientController : ControllerBase
    {

        [HttpGet("{Identifer}")]
        public ActionResult<List<Client>> Get(long Identifer)
        {
            return ClientsManager.GetClientsFromDb(Identifer).GetClients();
        }
        [HttpPut("{Identifer}")]
        public ActionResult PutSubnet(long Identifer, int? IdSubnet = null)
        {
            var result = ClientsManager.UpdateSubnetOnClient(Identifer, IdSubnet);
            if (result == "true") return Ok();
            return BadRequest(result);
        }
    }
}
