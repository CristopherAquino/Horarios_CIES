using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Horarios_CIES.Models.DTO
{
    public class HorarioDocenteModel
    {
        public int Id_HorarioDocente { get; set; }
        public int Id_Docente { get; set; }

        public int Id_Materia { get; set; }

        public string Ciclo { get; set; }

        public string Dia { get; set; }

        public string Hora_Inicio { get; set; }

        public string Hora_Fin { get; set; }

        public int Id { get; set; }
    }

    public class HorarioDocenteMostrarModel
    {
        [DisplayName("ID")]
        public int Id { get; set; }

        [DisplayName("CICLO")]
        public string Ciclo { get; set; }

        [DisplayName("DOCENTE")]
        public string Nombre_Docente { get; set; }

        [DisplayName("MATERIA")]
        public string Nombre_Materia { get; set; }

        [DisplayName("DIA")]
        public string Dia { get; set; }

        [DisplayName("HORA INICIO")]
        public string Hora_Inicio { get; set; }

        [DisplayName("HORA FIN")]
        public string Hora_Fin { get; set; }
    }
}
