//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Intranet.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class int_usuarios
    {
        public int_usuarios()
        {
            this.int_directorios = new HashSet<int_directorios>();
            this.int_eve_comentarios = new HashSet<int_eve_comentarios>();
            this.int_eventos = new HashSet<int_eventos>();
            this.int_solicitudes = new HashSet<int_solicitudes>();
        }
    
        public int usu_id { get; set; }
        public string usu_nombre { get; set; }
        public string usu_apellido { get; set; }
        public string usu_rut { get; set; }
        public string usu_sexo { get; set; }
        public string usu_correo { get; set; }
        public string usu_password { get; set; }
        public string usu_imagen { get; set; }
        public Nullable<System.DateTime> usu_cumpleaños { get; set; }
        public Nullable<int> usu_cat_id { get; set; }
        public Nullable<System.DateTime> usu_feccre { get; set; }
    
        public virtual ICollection<int_directorios> int_directorios { get; set; }
        public virtual ICollection<int_eve_comentarios> int_eve_comentarios { get; set; }
        public virtual ICollection<int_eventos> int_eventos { get; set; }
        public virtual ICollection<int_solicitudes> int_solicitudes { get; set; }
        public virtual int_usu_categorias int_usu_categorias { get; set; }
    }
}
