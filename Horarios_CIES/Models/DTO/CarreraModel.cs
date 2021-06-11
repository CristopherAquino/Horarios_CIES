using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Horarios_CIES.Models.DTO
{
    public class CarreraModel
    {
        [DisplayName("ID")]
        public int IdCarrera { get; set; }
        [Required]

        [DisplayName("NOMBRE DE CARRERA")]
        public string Nombre_Carrera { get; set; }
        
    }
}
