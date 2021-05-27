using System;
using System.Collections.Generic;
using System.Text;

namespace Horarios_CIES.Models.DTO
{
    class HorarioGrupo
    {
        int _Id_HorarioGrupo;
        int _Id_Grupo;
        int _Id_HorarioDocente;

        public int Id_HorarioGrupo
        {
            get
            {
                return _Id_HorarioGrupo;
            }
            set
            {
                _Id_HorarioGrupo = value;
            }
        }

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
    }
}
