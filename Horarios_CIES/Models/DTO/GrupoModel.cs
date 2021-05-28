using System;
using System.Collections.Generic;
using System.Text;

namespace Horarios_CIES.Models.DTO
{
    class GrupoModel
    {
        int _Id_Grupo;
        string _Nombre_Grupo;
        string _Cuatrimestre;
        int _Id_Carrera;

        public int Id_Grupo
        {
            get
            {
                return _Id_Grupo;
            }
            set
            {
                _Id_Grupo = value;
            }
        }

        public string Nombre_Grupo
        {
            get
            {
                return _Nombre_Grupo;
            }
            set
            {
                _Nombre_Grupo = value;
            }
        }

        public string Cuatrimestre
        {
            get
            {
                return _Cuatrimestre;
            }
            set
            {
                _Cuatrimestre = value;
            }
        }

        public int Id_Carrera
        {
            get
            {
                return _Id_Carrera;
            }
            set
            {
                _Id_Carrera = value;
            }
        }
    }
}
