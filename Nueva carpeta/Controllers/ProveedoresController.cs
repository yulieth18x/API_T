using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Tienda.Data;
using Tienda.Models;

namespace Tienda.Controllers
{
    public class ProveedoresController : ApiController
    {
        // GET api/<controller>
        public List<Proveedores> Get()
        {
            return ProveedoresData.Listar();
        }
        // GET api/<controller>/5
        public List<Proveedores> Get(string id)
        {
            return ProveedoresData.Consultar(id);
        }
        // POST api/<controller>
        public bool Post([FromBody] Proveedores oProveedores)
        {
            return ProveedoresData.Registrar(oProveedores);
        }
        // PUT api/<controller>/5
        public bool Put([FromBody] Proveedores oProveedores)
        {
            return ProveedoresData.Actualizar(oProveedores);
        }
        // DELETE api/<controller>/5
        public bool Delete(string id)
        {
            return ProveedoresData.Eliminar(id);
        }
    }
}