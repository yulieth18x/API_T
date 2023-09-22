using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Tienda.Data;
using Tienda.Models;

namespace Tienda.Controllers
{
        public class PedidosController : ApiController
        {
            // GET api/<controller>
            public List<Pedidos> Get()
            {
                return PedidosData.listar4();
            }
            // GET api/<controller>/5
            public List<Pedidos> Get(string id)
            {
                return PedidosData.consultar4(id);
            }
            // POST api/<controller>
            public bool Post([FromBody] Pedidos oUsuariopedido)
            {
                return PedidosData.registrar4(oUsuariopedido);
            }
            // PUT api/<controller>/5
            public bool Put([FromBody] Pedidos oUsuariopedido)
            {
                return PedidosData.actualizar4(oUsuariopedido);
            }
            // DELETE api/<controller>/5
            public bool Delete(string id)
            {
                return PedidosData.eliminar4(id);
            }
        }
    
}