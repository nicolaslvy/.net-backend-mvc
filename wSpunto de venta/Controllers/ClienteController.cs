using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using wSpunto_de_venta.Models;

namespace wSpunto_de_venta.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            using (ventasContext db = new ventasContext()) {
                var lst = db.ClientesPunto.ToList();
                return Ok(lst);
            }
        }
    }
}
