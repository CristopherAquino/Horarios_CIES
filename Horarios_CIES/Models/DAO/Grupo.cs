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
    
    public partial class Grupo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Grupo()
        {
            this.HorarioGrupo = new HashSet<HorarioGrupo>();
        }
    
        public long Id_Grupo { get; set; }
        public string Nombre_Grupo { get; set; }
        public string Cuatrimestre { get; set; }
        public long Id_Carrera { get; set; }
    
        public virtual Carrera Carrera { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HorarioGrupo> HorarioGrupo { get; set; }
    }
}
