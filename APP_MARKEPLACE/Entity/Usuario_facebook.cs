using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APP_MARKEPLACE.Entity
{
    public class Usuario_facebook
    {
        public int codigo { get; set; }
        public string  nombres { get; set; }
        public string apellidos { get; set; }
        public int idpais { get; set; }

        public int idsexo { get; set; } 
        public string email { get; set; }
        public string contraseña { get; set; }
        public string fechaNacimiento { get; set; }
    }
}