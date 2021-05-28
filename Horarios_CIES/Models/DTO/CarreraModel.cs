using System;
using System.Collections.Generic;
using System.Text;

namespace Horarios_CIES.Models.DTO
{
    class CarreraModel
    {
        int _IdCarrera;
        string _Nombre_Carrera;

        public int IdCarrera
        {
            get
            {
                return _IdCarrera;
            }
            set
            {
                _IdCarrera = value;
            }
        }

        public string Nombre_Carrera
        {
            get
            {
                return _Nombre_Carrera;
            }
            set
            {
                _Nombre_Carrera = value;
            }
        }
    }
}
