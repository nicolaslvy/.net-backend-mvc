using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using wSpunto_de_venta.Models;
using wSpunto_de_venta.Models.Request;

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
        [HttpPost]
        public IActionResult Add(ClienteRequest Omodel)
        {
            try
            {
                using (ventasContext db = new ventasContext())
                {
                    ClientesPunto Cliente = new ClientesPunto();
                    Cliente.Identificacion = Omodel.Identificacion;
                    Cliente.Nombre = Omodel.Nombre;
                    Cliente.Apellido = Omodel.Apellido;
                    db.ClientesPunto.Add(Cliente);
                    db.SaveChanges();

                }
            }
            catch (Exception ex)
            {

                
            }

            return Ok();
        }
        [HttpPut]
        public IActionResult Edit()
        {
            return Ok();
        }
        [HttpDelete]
        public IActionResult Delete()
        {
            return Ok();
        }


    }
}
