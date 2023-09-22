using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Tienda.Models;

namespace Tienda.Data
{
    public class ProductosData
    {
        public static bool Registrar(Productos oProductos)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE usp_registrar2 '" + oProductos.IDpro + "','" + oProductos.Nombre + "','" + oProductos.Descripcion + "','" + oProductos.Precio + "'";
            if (!objEst.EjecutarSentencia(SentenciaSQL: sentencia, false))
            {
                objEst = null;
                return false;
            }
            else
            {
                objEst = null;
                return true;
            }
        }

        public static bool Actualizar(Productos oProductos)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE usp_actualizar2 '" + oProductos.IDpro + "','" + oProductos.Nombre + "','" + oProductos.Descripcion + "','" + oProductos.Precio + "'";
            if (!objEst.EjecutarSentencia(sentencia, false))
            {
                objEst = null;
                return false;
            }
            else
            {
                objEst = null;
                return true;
            }
        }


        public static bool Eliminar(string id)

        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE usp_eliminar2 '" + id + "'";
            if (!objEst.EjecutarSentencia(sentencia, false))
            {
                objEst = null;
                return false;
            }
            else
            {
                objEst = null;
                return true;
            }
        }
        public static List<Productos> Listar()
        {
            List< Productos> oListaProductos = new List<Productos>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE usp_listar2";
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListaProductos.Add(new Productos()
                    {
                        IDpro = Convert.ToInt32(dr["IDpro"]),
                        Nombre = dr["Nombre"].ToString(),
                        Descripcion = dr["Descripcion"].ToString(),
                        Precio = Convert.ToInt32(dr["Precio"]),
                    });
                }
                return oListaProductos;
            }
            else
            {
                return oListaProductos;
            }
        }

        public static List<Productos> Consultar(string id)
        {
            List<Productos> oListaProductos = new List<Productos>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE usp_obtener2 '" + id + "'";
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListaProductos.Add(new Productos()
                    {
                        IDpro = Convert.ToInt32(dr["IDpro"]),
                        Nombre = dr["Nombre"].ToString(),
                        Descripcion = dr["Descripcion"].ToString(),
                        Precio = Convert.ToInt32(dr["Precio"]),
                    });
                }
                return oListaProductos;
            }
            else
            {
                return oListaProductos;
            }
        }


    }

}