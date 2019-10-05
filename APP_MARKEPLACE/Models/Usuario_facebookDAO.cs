using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;


using APP_MARKEPLACE.Entity;
using APP_MARKEPLACE.SQLServer;

namespace APP_MARKEPLACE.Models
{
    public class Usuario_facebookDAO
    {
        Conexion cn = new Conexion();

        public List<Usuario_facebook> Listado()
        {
            List<Usuario_facebook> lista = new List<Usuario_facebook>();
            SqlCommand cmd = new SqlCommand("select * from usuarios_facebook", cn.getcn);
            cn.getcn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Usuario_facebook re = new Usuario_facebook();
                re.codigo = dr.GetInt32(0);
                re.nombres = dr.GetString(1);
                re.apellidos = dr.GetString(2);
                re.idpais = dr.GetInt32(3);
                re.idsexo = dr.GetInt32(4);
                re.email = dr.GetString(5);
                re.contraseña = dr.GetString(6);
                re.fechaNacimiento = dr.GetString(7);
                lista.Add(re);
            }
            dr.Close();
            cn.getcn.Close();
            return lista;
        }
        

    }
}