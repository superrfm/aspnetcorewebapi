using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rfmagalhaes.aspnetcorewebapi.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class PedidoController
        : ControllerBase
    {
        // /Pedido - GET
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult PedidoPorId([FromRoute] int id) {

            if (id <= 0) return BadRequest(id);
            return Ok(id);
        }
    }
}
