using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Horarios_CIES.Views;
using Horarios_CIES.Models.DTO;
using Horarios_CIES.Models.DAO;
using System.Data;

namespace Horarios_CIES.Controllers
{
    class HorarioDocenteCrearController
    {
        public IEnumerable<MateriaModel> comboMateria()
        {
            using (DBContextString db = new DBContextString())
            {
                IEnumerable<MateriaModel> lst =
                    (from d in db.Materia
                     select new MateriaModel
                     {
                         Id_Materia = (int)d.Id_Materia,
                         Nombre_Materia = d.Nombre_Materia
                     }).ToList();
                return lst;
            }
        }

        public IEnumerable<DocenteModel> comboDocente()
        {
            using (DBContextString db = new DBContextString())
            {
                IEnumerable<DocenteModel> lst =
                    (from d in db.Docente
                     select new DocenteModel
                     {
                         Id_Docente = (int)d.Id_Docente,
                         Nombre_Docente = d.Nombre_Docente
                     }).ToList();
                return lst;
            }
        }

        public void añadir(int idM, int idD, string ciclo, string dia, string horai, string horaf)
        {
            using (DBContextString db = new DBContextString())
            {
                Models.DAO.HorarioDocente horario = new Models.DAO.HorarioDocente();
                horario.Id_Materia = idM;
                horario.Id_Docente = idD;
                horario.Ciclo = ciclo;
                horario.Dia = dia;
                horario.Hora_Inicio = horai;
                horario.Hora_Fin = horaf;
                db.HorarioDocente.Add(horario);
                db.SaveChanges();
            }
        }
    }
}
