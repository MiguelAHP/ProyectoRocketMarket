//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace APP_MARKEPLACE.Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class afiliado
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
        public int Nro_ruc { get; set; }
        public Nullable<int> telefono { get; set; }
        public string contraseña { get; set; }
        public string confir_contraseña { get; set; }
    
        public virtual distrito distrito { get; set; }
        public virtual pais pais { get; set; }
        public virtual provincia provincia { get; set; }
        public virtual tipo_empresa tipo_empresa { get; set; }
    }
}
