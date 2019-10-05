using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


using APP_MARKEPLACE.SQLServer;
using APP_MARKEPLACE.Entity;

using System.Data.SqlClient;
using System.Data;

namespace APP_MARKEPLACE.Models
{
    public class UsuarioDAO
    {
        Conexion cn = new Conexion();
        public List<Pais> Listado_pais()
        {
            List<Pais> lista = new List<Pais>();
            SqlCommand cmd = new SqlCommand("select * from pais", cn.getcn);
            cn.getcn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Pais re = new Pais();
                re.idpais = dr.GetInt32(0);
                re.descripcion = dr.GetString(1);
                lista.Add(re);
            }
            dr.Close();
            cn.getcn.Close();
            return lista;
        }
        public List<Sexo> Listado_sexo()
        {
            List<Sexo> lista = new List<Sexo>();
            SqlCommand cmd = new SqlCommand("select * from sexo", cn.getcn);
            cn.getcn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Sexo re = new Sexo();
                re.idsexo = dr.GetInt32(0);
                re.descripcion = dr.GetString(1);
                lista.Add(re);
            }
            dr.Close();
            cn.getcn.Close();
            return lista;
        }

        public List<Usuario> Listado_usuario()
        {
            List<Usuario> lista = new List<Usuario>();
            SqlCommand cmd = new SqlCommand("select * from usuario", cn.getcn);
            cn.getcn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Usuario re = new Usuario();
                re.codigo = dr.GetInt32(0);
                re.nombres = dr.GetString(1);
                re.idpais = dr.GetInt32(2);
                re.idsexo = dr.GetInt32(3);
                re.email = dr.GetString(4);
                re.contraseña = dr.GetString(5);
                re.confir_contraseña = dr.GetString(6);
                lista.Add(re);
            }
            dr.Close();
            cn.getcn.Close();
            return lista;
        }
        public string Registrar_usuario(Usuario us)
        {
            string msg = "";
            cn.getcn.Open();
            SqlCommand cmd = new SqlCommand("USP_Registro_usuario", cn.getcn);
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("@cod", us.codigo);
            cmd.Parameters.AddWithValue("@nom", us.nombres);
            cmd.Parameters.AddWithValue("@idpais", us.idpais);
            cmd.Parameters.AddWithValue("@idsexo", us.idsexo);
            cmd.Parameters.AddWithValue("@email", us.email);
            cmd.Parameters.AddWithValue("@contra", us.contraseña);
            cmd.Parameters.AddWithValue("@confcontra", us.confir_contraseña);
            cmd.ExecuteNonQuery();
            cn.getcn.Close();
            return msg;
        }
    }
}