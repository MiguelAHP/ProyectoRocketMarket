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
    public class AfiliadoDAO
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

        public List<Provincia> Listado_provincia()
        {
            List<Provincia> lista = new List<Provincia>();
            SqlCommand cmd = new SqlCommand("select * from provincia", cn.getcn);
            cn.getcn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Provincia re = new Provincia();
                re.idprovincia  = dr.GetInt32(0);
                re.nombre = dr.GetString(1);
                lista.Add(re);
            }
            dr.Close();
            cn.getcn.Close();
            return lista;
        }

        public List<Distrito> Listado_distrito()
        {
            List<Distrito> lista = new List<Distrito>();
            SqlCommand cmd = new SqlCommand("select * from distrito",cn.getcn);
            cn.getcn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Distrito re = new Distrito();
                re.iddistrito = dr.GetInt32(0);
                re.nombre = dr.GetString(1);
                lista.Add(re);
            }
            dr.Close();
            cn.getcn.Close();
            return lista;
        }
        
        public List<tipoEmpresa> Listado_tipoEmpresa()
        {
            List<tipoEmpresa> lista = new List<tipoEmpresa>();
            SqlCommand cmd = new SqlCommand("select * from tipo_empresa", cn.getcn);
            cn.getcn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                tipoEmpresa re = new tipoEmpresa();
                re.idtipo = dr.GetInt32(0);
                re.descripcion = dr.GetString(1);
                lista.Add(re);
            }
            dr.Close();
            cn.getcn.Close();
            return lista;
        }

        public List<Afiliado> Listado_afiliado()
        {
            List<Afiliado> lista = new List<Afiliado>();
            SqlCommand cmd = new SqlCommand("select * from afiliado", cn.getcn);
            cn.getcn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Afiliado re = new Afiliado();
                re.codigo=dr.GetInt32(0);
                re.nombres = dr.GetString(1);
                re.apellidos= dr.GetString(2);
                re.email = dr.GetString(3);
                re.empresa= dr.GetString(4);
                re.direccion = dr.GetString(5);
                re.idpais = dr.GetInt32(6);
                re.idprovincia = dr.GetInt32(7);
                re.iddistrito= dr.GetInt32(8);
                re.idtipo = dr.GetInt32(9);
                re.nroRuc = dr.GetInt32(10);
                re.telefono = dr.GetInt32(11);
                re.contraseña = dr.GetString(12);
                re.confir_contraseña = dr.GetString(13);
                lista.Add(re);
            }
            dr.Close();
            cn.getcn.Close();
            return lista;
        }

        public string Registrar_afiliado(Afiliado afi)
        {
            string msg = "";
            cn.getcn.Open();
            SqlCommand cmd = new SqlCommand("USP_Registro_afiliado", cn.getcn);
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("@cod", us.codigo);
            cmd.Parameters.AddWithValue("@nom", afi.nombres);
            cmd.Parameters.AddWithValue("@ape", afi.apellidos);
            cmd.Parameters.AddWithValue("@email", afi.email);
            cmd.Parameters.AddWithValue("@empre", afi.empresa);
            cmd.Parameters.AddWithValue("@dir", afi.direccion);
            cmd.Parameters.AddWithValue("@idpais", afi.idpais);
            cmd.Parameters.AddWithValue("@idprovincia", afi.idprovincia);
            cmd.Parameters.AddWithValue("@iddistrito", afi.iddistrito);
            cmd.Parameters.AddWithValue("@idtipo", afi.idtipo);
            cmd.Parameters.AddWithValue("@Nruc", afi.nroRuc);
            cmd.Parameters.AddWithValue("@fono", afi.telefono);
            cmd.Parameters.AddWithValue("@contra", afi.contraseña);
            cmd.Parameters.AddWithValue("@confcontra", afi.confir_contraseña);
            cmd.ExecuteNonQuery();
            cn.getcn.Close();

            return msg;
        }

        public Afiliado Detalle_afiliado(int id)
        {
            return Listado_afiliado().Where(c => c.codigo == id).FirstOrDefault();
        }

    }
}