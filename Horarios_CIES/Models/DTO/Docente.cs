using System;
using System.Collections.Generic;
using System.Text;

namespace Horarios_CIES.Models.DTO
{
    class Docente
    {
        int _Id_Docente;
        string _Nombre_Docente;
        string _Apellido_Paterno;
        string _Apellido_Materno;
        int _Telefono;
        string _Correo_Electronico;

        public int Id_Docente
        {
            get
            {
                return _Id_Docente;
            }
            set
            {
                _Id_Docente = value;
            }
        }

        public string Nombre_Docente
        {
            get
            {
                return _Nombre_Docente;
            }
            set
            {
                _Nombre_Docente = value;
            }
        }

        public string Apellido_Paterno
        {
            get
            {
                return _Apellido_Paterno;
            }
            set
            {
                _Apellido_Paterno = value;
            }
        }

        public string Apellido_Materno
        {
            get
            {
                return _Apellido_Materno;
            }
            set
            {
                _Apellido_Materno = value;
            }
        }

        public int Telefono
        {
            get
            {
                return _Telefono;
            }
            set
            {
                _Telefono = value;
            }
        }

        public string Correo_Electronico
        {
            get
            {
                return _Correo_Electronico;
            }
            set
            {
                _Correo_Electronico = value;
            }
        }
    }
}
