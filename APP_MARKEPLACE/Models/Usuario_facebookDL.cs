using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using APP_MARKEPLACE.Entity;
using APP_MARKEPLACE.SQLServer;

namespace APP_MARKEPLACE.Models
{
    public class Usuario_facebookDL
    {
        Usuario_facebookDAO usuario_facebookDAO = new Usuario_facebookDAO();
        public List<Usuario_facebook> Listado()
        {
            return usuario_facebookDAO.Listado();
        }

    }
}