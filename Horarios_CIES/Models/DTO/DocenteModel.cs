using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Horarios_CIES.Models.DTO
{
    public class DocenteModel
    {
        [DisplayName("ID")]
        public int Id_Docente { get; set; }
        [Required]

        [DisplayName("NOMBRE DEL DOCENTE")]
        public string Nombre_Docente { get; set; }

        [DisplayName("TEL. CELULAR")]
        public string Telefono_Celular { get; set; }

        [DisplayName("TEL. CASA")]
        public string Telefono_Casa { get; set; }

        [DisplayName("TEL. OFICINA")]
        public string Telefono_Oficina { get; set; }

        [DisplayName("CORREO ELECTRONICO")]
        public string Correo_Electronico { get; set; }
    }
}
