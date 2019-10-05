using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using APP_MARKEPLACE.Entity;
using APP_MARKEPLACE.SQLServer;

namespace APP_MARKEPLACE.Models
{
    public class UsuarioDL
    {
        UsuarioDAO usuarioDAO = new UsuarioDAO();
            public string Registrar_usuario(Usuario us)
        {
            return usuarioDAO.Registrar_usuario(us);
        }
        public List<Usuario> Listado_usuario()
        {
            return usuarioDAO.Listado_usuario();
        }
        public List<Pais> Listado_pais()
        {
            return usuarioDAO.Listado_pais();
        }
        public List<Sexo> Listado_sexo()
        {
            return usuarioDAO.Listado_sexo();
        }

    }
}