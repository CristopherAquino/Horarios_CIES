using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Horarios_CIES.Models.DTO
{
    public class MateriaModel
    {
        public int Id_Materia { get; set; }
        [Required]

        public string Codigo_Materia { get; set; }

        public string Nombre_Materia { get; set; }

        public int Id_Grupo { get; set; }
    }

    public class MateriaModelObtener
    {
        [DisplayName("ID")]
        public int Id_Materia { get; set; }
        [Required]

        [DisplayName("CODIGO DE MATERIA")]
        public string Codigo_Materia { get; set; }

        [DisplayName("NOMBRE DE MATERIA")]
        public string Nombre_Materia { get; set; }

        [DisplayName("NOMBRE DE GRUPO")]
        public string NombreGrupo { get; set; }
    }
}
