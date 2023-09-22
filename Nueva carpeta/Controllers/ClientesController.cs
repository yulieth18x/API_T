using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Tienda.Data;
using Tienda.Models;

namespace Tienda.Controllers
{
    public class ClientesController : ApiController
    {
        // GET api/<controller>
        public List<Clientes> Get()
        {
            return ClientesData.listar3();
        }
        // GET api/<controller>/5
        public List<Clientes> Get(string id)
        {
            return ClientesData.consultar3(id);
        }
        // POST api/<controller>
        public bool Post([FromBody] Clientes oUsuariocliente)
        {
            return ClientesData.registrar3(oUsuariocliente);
        }
        // PUT api/<controller>/5
        public bool Put([FromBody] Clientes oUsuariocliente)
        {
            return ClientesData.actualizar3(oUsuariocliente);
        }
        // DELETE api/<controller>/5
        public bool Delete(string id)
        {
            return ClientesData.eliminar3(id);
        }
    }
}