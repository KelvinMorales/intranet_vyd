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
    
    public partial class int_sucursales
    {
        public int_sucursales()
        {
            this.int_directorios = new HashSet<int_directorios>();
        }
    
        public int suc_id { get; set; }
        public string suc_nombre { get; set; }
        public string suc_direccion { get; set; }
        public Nullable<int> suc_telefono { get; set; }
        public Nullable<System.DateTime> suc_feccre { get; set; }
        public Nullable<int> suc_usucre { get; set; }
        public Nullable<int> suc_emp_id { get; set; }
    
        public virtual ICollection<int_directorios> int_directorios { get; set; }
        public virtual int_empresas int_empresas { get; set; }
    }
}
