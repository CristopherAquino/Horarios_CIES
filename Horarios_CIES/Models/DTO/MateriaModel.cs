using System;
using System.Collections.Generic;
using System.Text;

namespace Horarios_CIES.Models.DTO
{
    class MateriaModel
    {
        int _Id_Materia;
        string _Codigo_Materia;
        string _Nombre_Materia;
        int _Id_Docente;

        public int Id_Materia
        {
            get
            {
                return _Id_Materia;
            }
            set
            {
                _Id_Materia = value;
            }
        }

        public string Codigo_Materia
        {
            get
            {
                return _Codigo_Materia;
            }
            set
            {
                _Codigo_Materia = value;
            }
        }

        public string Nombre_Materia
        {
            get
            {
                return _Nombre_Materia;
            }
            set
            {
                _Nombre_Materia = value;
            }
        }

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
    }
}
