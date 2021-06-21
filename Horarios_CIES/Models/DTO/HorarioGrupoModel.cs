using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Horarios_CIES.Models.DTO
{
    public class HorarioGrupoModel
    {
        public int Id_HorarioGrupo { get; set; }
        public int Id_Grupo { get; set; }
        public int Id_Materia { get; set; }
        public int Id_Ciclo { get; set; }
        public int Id { get; set; }
    }

    public class TablaMateriaDocente
    {
        [DisplayName("DIA")]
        public string Dia { get; set; }

        [DisplayName("HORA INICIO")]
        public string Hora_Inicio { get; set; }

        [DisplayName("HORA FIN")]
        public string Hora_Fin { get; set; }
    }
    public class ComboMateriaModel
    {
        public int Id_Materia { get; set; }
        public string Nombre_Materia { get; set; }
    }

    public class ComboDocenteModel
    {
        public int Id_Docente { get; set; }
        public string Nombre_Docente { get; set; }
    }
}
