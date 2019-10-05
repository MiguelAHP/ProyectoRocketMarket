using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using APP_MARKEPLACE.Entity;

namespace APP_MARKEPLACE.Models
{
    public class AfiliadoDL
    {
        AfiliadoDAO afiliadoDAO = new AfiliadoDAO();

        public string Registrar_afiliado(Afiliado afi)
        {
            return afiliadoDAO.Registrar_afiliado(afi);
        }

        public Afiliado Detalle_afiliado(int id)
        {
            return afiliadoDAO.Detalle_afiliado(id);
        }


        public List<Afiliado> Listado_afiliado()
        {
            return afiliadoDAO.Listado_afiliado();
        }      
        public List<Provincia> Listado_provincia()
        {
            return afiliadoDAO.Listado_provincia();
        }
        public List<Distrito> Listado_distrito()
        {
            return afiliadoDAO.Listado_distrito();
        }
        public List<tipoEmpresa> Listado_tipoEmpresa()
        {
            return afiliadoDAO.Listado_tipoEmpresa();
        }
        public List<Pais> Listado_pais()
        {
            return afiliadoDAO.Listado_pais();
        }
    }
}