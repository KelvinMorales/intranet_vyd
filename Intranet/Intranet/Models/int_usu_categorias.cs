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
    
    public partial class int_usu_categorias
    {
        public int_usu_categorias()
        {
            this.int_usuarios = new HashSet<int_usuarios>();
        }
    
        public int cat_id { get; set; }
        public string cat_nombre { get; set; }
    
        public virtual ICollection<int_usuarios> int_usuarios { get; set; }
    }
}
