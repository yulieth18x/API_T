using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Tienda.Models;

namespace Tienda.Data
{
    public class ProveedoresData
    {
        public static bool Registrar(Proveedores oProveedores)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE usp_registrar5 '" + oProveedores.IDprov + "','" + oProveedores.nombre + "','" + oProveedores.apellido + "','" + oProveedores.telefono + "' , '" + oProveedores.correoElectronico + "','" + oProveedores.direccion + "'";
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

        public static bool Actualizar(Proveedores oProveedores)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE usp_actualizar5 '" + oProveedores.IDprov + "','" + oProveedores.nombre + "','" + oProveedores.apellido + "','" + oProveedores.telefono + "' , '" + oProveedores.correoElectronico + "','" + oProveedores.direccion + "'";
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
            sentencia = "EXECUTE usp_eliminar5 '" + id + "'";
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
        public static List<Proveedores> Listar()
        {
            List<Proveedores> oListaprov = new List<Proveedores>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE usp_listar5";
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListaprov.Add(new Proveedores()
                    {
                        IDprov = Convert.ToInt32(dr["IDprov"]),
                        nombre = dr["nombre"].ToString(),
                        apellido = dr["apellido"].ToString(),
                        telefono = dr["telefono"].ToString(),
                        correoElectronico = dr["correoElectronico"].ToString(),
                        direccion = dr["direccion"].ToString(),
                    });
                }
                return oListaprov;
            }
            else
            {
                return oListaprov;
            }
        }

        public static List<Proveedores> Consultar(string id)
        {
            List<Proveedores> oListaprov = new List<Proveedores>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE usp_obtener5 '" + id + "'";
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListaprov.Add(new Proveedores()
                    {
                        IDprov = Convert.ToInt32(dr["IDprov"]),
                        nombre = dr["nombre"].ToString(),
                        apellido = dr["apellido"].ToString(),
                        telefono = dr["telefono"].ToString(),
                        correoElectronico = dr["correoElectronico"].ToString(),
                        direccion = dr["direccion"].ToString(),
                    });
                }
                return oListaprov;
            }
            else
            {
                return oListaprov;
            }
        }


    }
}
