using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Tienda.Models;

namespace Tienda.Data
{
    public class ClientesData
    {
        public static bool registrar3(Clientes oUsuariocliente)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE usp_registrar3 '"+ oUsuariocliente.IDc + "','" + oUsuariocliente.nombre + "','" + oUsuariocliente.apellido + "','" + oUsuariocliente.direccion + "' , '" + oUsuariocliente.correoElectronico + "','" + oUsuariocliente.telefono + "','" + oUsuariocliente.codigoPostal + "'";
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

        public static bool actualizar3(Clientes oUsuariocliente)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE usp_actualizar3 '" + oUsuariocliente.IDc + "','" + oUsuariocliente.nombre + "','" + oUsuariocliente.apellido + "','" + oUsuariocliente.direccion + "' , '" + oUsuariocliente.correoElectronico + "','" + oUsuariocliente.telefono + "','" + oUsuariocliente.codigoPostal + "'";
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


        public static bool eliminar3(string IDc)

        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE usp_eliminar3 '" + IDc + "'";
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
        public static List<Clientes> listar3()
        {
            List<Clientes> oListaclientes = new List<Clientes>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE usp_listar3";
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListaclientes.Add(new Clientes()
                    {
                        IDc = Convert.ToInt32(dr["IDc"]),
                        nombre = dr["nombre"].ToString(),
                        apellido = dr["apellido"].ToString(),
                        direccion = dr["direccion"].ToString(),
                        correoElectronico = dr["correoElectronico"].ToString(),
                        telefono = dr["telefono"].ToString(),
                        codigoPostal = dr["codigoPostal"].ToString(),
                    });
                }
                return oListaclientes;
            }
            else
            {
                return oListaclientes;
            }
        }

        public static List<Clientes> consultar3(string IDc)
        {
            List<Clientes> oListaclientes = new List<Clientes>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE usp_obtener3 '" + IDc + "'";
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListaclientes.Add(new Clientes()
                    {
                        IDc = Convert.ToInt32(dr["IDc"]),
                        nombre = dr["nombre"].ToString(),
                        apellido = dr["apellido"].ToString(),
                        direccion = dr["direccion"].ToString(),
                        correoElectronico = dr["correo"].ToString(),
                        telefono = dr["telefono"].ToString(),
                        codigoPostal = dr["codigoPostal"].ToString(),
                    });
                }
                return oListaclientes;
            }
            else
            {
                return oListaclientes;
            }
        }


    }
}
