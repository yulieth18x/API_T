using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tienda.Models
{
    public class Pedidos
    {
        public int IDpe { get; set; }
        public DateTime fecha { get; set; }
        public int fk_IDc { get; set; }
        public int fk_IDpro { get; set; }
        public int fk_IDcate { get; set; }
        public string direccionEnvio { get; set; }

    }
}


