using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APP_MARKEPLACE.Entity
{
    public class Usuario
    {
        public int codigo { get; set; } 
        public string nombres { get; set; }
        public int idpais { get; set; }
        public int idsexo { get; set; }
        public string email { get; set; }
        public string contraseña { get; set; }
        public string confir_contraseña { get; set; }
    }
}