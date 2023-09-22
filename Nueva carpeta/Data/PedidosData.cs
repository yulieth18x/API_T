using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Web;
using Tienda.Models;

namespace Tienda.Data
{
    public class PedidosData
    {
            public static bool registrar4(Pedidos oUsuariopedido)
            {
                ConexionBD objEst = new ConexionBD();
                string sentencia;
                sentencia = "EXECUTE usp_registrar4 '" + oUsuariopedido.IDpe + "','" + oUsuariopedido.fecha + "','" + oUsuariopedido.fk_IDc + "','" + oUsuariopedido.fk_IDpro + "','" + oUsuariopedido.fk_IDcate + "','" + oUsuariopedido.direccionEnvio + "'";
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

            public static bool actualizar4(Pedidos oUsuariopedido)
            {
                ConexionBD objEst = new ConexionBD();
                string sentencia;
                sentencia = "EXECUTE usp_actualizar4 '" + oUsuariopedido.IDpe + "','" + oUsuariopedido.fecha + "','" + oUsuariopedido.fk_IDc + "','" + oUsuariopedido.fk_IDpro + "','" + oUsuariopedido.fk_IDcate + "','" + oUsuariopedido.direccionEnvio + "'";
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


            public static bool eliminar4(string id)

            {
                ConexionBD objEst = new ConexionBD();
                string sentencia;
                sentencia = "EXECUTE usp_eliminar4 '" + id + "'";
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
            public static List<Pedidos> listar4()
            {
                List<Pedidos> oListaPedidos = new List<Pedidos>();
                ConexionBD objEst = new ConexionBD();
                string sentencia;
                sentencia = "EXECUTE usp_listar4";
                if (objEst.Consultar(sentencia, false))
                {
                    SqlDataReader dr = objEst.Reader;
                    while (dr.Read())
                    {
                    oListaPedidos.Add(new Pedidos()
                        {
                        IDpe = Convert.ToInt32(dr["IDpe"]),
                        fecha = Convert.ToDateTime(dr["fecha"]),
                        fk_IDc = Convert.ToInt32(dr["fk_IDc"]),
                        fk_IDpro = Convert.ToInt32(dr["fk_IDpro"]),
                        fk_IDcate = Convert.ToInt32(dr["fk_IDcate"]),
                        direccionEnvio = dr["direccionEnvio"].ToString(),

                        });
                    }
                    return oListaPedidos;
                }
                else
                {
                    return oListaPedidos;
                }
            }

            public static List<Pedidos> consultar4(string IDpe)
            {
                List<Pedidos> oListaPedidos = new List<Pedidos>();
                ConexionBD objEst = new ConexionBD();
                string sentencia;
                sentencia = "EXECUTE usp_obtener4 '" + IDpe + "'";
                if (objEst.Consultar(sentencia, false))
                {
                    SqlDataReader dr = objEst.Reader;
                    while (dr.Read())
                    {
                    oListaPedidos.Add(new Pedidos()
                        {
                        IDpe = Convert.ToInt32(dr["IDpe"]),
                        fecha = Convert.ToDateTime(dr["fecha"]),
                        fk_IDc = Convert.ToInt32(dr["fk_IDc"]),
                        fk_IDpro = Convert.ToInt32(dr["idPRO"]),
                        fk_IDcate = Convert.ToInt32(dr["fk_IDcate"]),
                        direccionEnvio = dr["direccionEnvio"].ToString(),
                    });
                    }
                    return oListaPedidos;
                }
                else
                {
                    return oListaPedidos;
                }

            }


        
    }
}