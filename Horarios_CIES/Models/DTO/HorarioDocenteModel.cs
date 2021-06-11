using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Horarios_CIES.Models.DTO
{
    public class HorarioDocenteModel
    {
        public int Id_HorarioDocente { get; set; }
        [Required]

        public int Id_Materia { get; set; }

        public int Id_Docente { get; set; }

        public string Ciclo { get; set; }

        public string Dia { get; set; }

        public string Hora_Inicio { get; set; }

        public string Hora_Fin { get; set; }
    }

    public class HorarioDocenteMostrarModel
    {
        [DisplayName("CICLO")]
        public string Ciclo { get; set; }

        [DisplayName("DOCENTE")]
        public string Docente { get; set; }

        [DisplayName("MATERIA")]
        public string Materia { get; set; }

        [DisplayName("DIA")]
        public string Dia { get; set; }

        [DisplayName("HORA INICIO")]
        public string Hora_Inicio { get; set; }

        [DisplayName("HORA FIN")]
        public string Hora_Fin { get; set; }
    }
}
