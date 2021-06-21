using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horarios_CIES.Models.DTO
{
    public class CicloModel
    {
        [DisplayName("ID")]
        public int Id_Ciclo { get; set; }

        [DisplayName("CICLO")]
        public string Ciclo { get; set; }
    }
}
