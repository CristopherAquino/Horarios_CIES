using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Horarios_CIES.Models.DTO
{
    public class GrupoModel
    {
        [DisplayName("ID")]
        public int Id_Grupo { get; set; }
        [Required]

        [DisplayName("NOMBRE DE GRUPO")]
        public string Nombre_Grupo { get; set; }

        [DisplayName("CUATRIMESTRE")]
        public string Cuatrimestre { get; set; }

        public int Id_Carrera { get; set; }

        [DisplayName("CARRERA")]
        public string NombreCarrera { get; set; }
    }

    public class GrupoModelObtener
    {
        [DisplayName("ID")]
        public int Id_Grupo { get; set; }
        [Required]

        [DisplayName("NOMBRE DE GRUPO")]
        public string Nombre_Grupo { get; set; }

        [DisplayName("CUATRIMESTRE")]
        public string Cuatrimestre { get; set; }

        [DisplayName("CARRERA")]
        public string NombreCarrera { get; set; }
    }
}
