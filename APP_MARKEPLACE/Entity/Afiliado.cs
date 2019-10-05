using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APP_MARKEPLACE.Entity
{
    public class Afiliado
    {
        public int codigo { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string email { get; set; }
        public string empresa { get; set; }
        public string direccion { get; set; }
        public int idpais { get; set; }
        public int idprovincia { get; set; }
        public int iddistrito { get; set; }
        public int idtipo { get; set; }
        public int nroRuc { get; set; }
        public int telefono { get; set; }
        public string contraseña { get; set; }
        public string confir_contraseña { get; set; }
    }
}