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
    
    public partial class HorarioGrupo
    {
        public long Id_HorarioGrupo { get; set; }
        public long Id_Grupo { get; set; }
        public long Id_HorarioDocente { get; set; }
    
        public virtual Grupo Grupo { get; set; }
        public virtual HorarioDocente HorarioDocente { get; set; }
    }
}