//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Horarios_CIES.Models.DAO
{
    using System;
    using System.Collections.Generic;
    
    public partial class Docente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Docente()
        {
            this.HorarioDocente = new HashSet<HorarioDocente>();
            this.HorarioGrupo = new HashSet<HorarioGrupo>();
        }
    
        public long Id_Docente { get; set; }
        public string Nombre_Docente { get; set; }
        public string Telefono_Celular { get; set; }
        public string Telefono_Casa { get; set; }
        public string Telefono_Oficina { get; set; }
        public string Correo_Electronico { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HorarioDocente> HorarioDocente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HorarioGrupo> HorarioGrupo { get; set; }
    }
}
