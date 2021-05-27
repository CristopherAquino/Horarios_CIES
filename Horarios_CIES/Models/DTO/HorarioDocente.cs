using System;
using System.Collections.Generic;
using System.Text;

namespace Horarios_CIES.Models.DTO
{
    class HorarioDocente
    {
        int _Id_HorarioDocente;
        int _Id_Materia;
        int _Id_Docente;
        string _Ciclo;
        string _Dia;
        string _Hora_Inicio;
        string _Hora_Fin;

        public int Id_HorarioDocente
        {
            get
            {
                return _Id_HorarioDocente;
            }
            set
            {
                _Id_HorarioDocente = value;
            }
        }

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

        public string Ciclo
        {
            get
            {
                return _Ciclo;
            }
            set
            {
                _Ciclo = value;
            }
        }

        public string Dia
        {
            get
            {
                return _Dia;
            }
            set
            {
                _Dia = value;
            }
        }

        public string Hora_Inicio
        {
            get
            {
                return _Hora_Inicio;
            }
            set
            {
                _Hora_Inicio = value;
            }
        }

        public string Hora_Fin
        {
            get
            {
                return _Hora_Fin;
            }
            set
            {
                _Hora_Fin = value;
            }
        }
    }
}
