using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Horarios_CIES.Views;
using Horarios_CIES.Models.DTO;
using Horarios_CIES.Models.DAO;
using System.Data;
using System.Threading.Tasks;

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

        public void añadir(int idM, int idD, string ciclo, string dia, string horai, string horaf, int id)
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
                horario.Id = id;
                db.HorarioDocente.Add(horario);
                db.SaveChanges();
            }
        }

        public bool IsIENumerableLleno(IEnumerable<HorarioDocenteModel> ultimo)
        {
            bool isFull = false;
            foreach (HorarioDocenteModel item in ultimo)
            {
                isFull = true;
                break;
            }
            return isFull;
        }

        public IEnumerable<HorarioDocenteModel> ultimo()
        {
            using (DBContextString db = new DBContextString())
            {
                IEnumerable <HorarioDocenteModel> lst =
                    (from d in db.HorarioDocente
                     select new HorarioDocenteModel
                     {
                         Id = (int)d.Id
                     }).ToList();
                return lst;
            }
        }

        public int identificador()
        {
            using (DBContextString db = new DBContextString())
            {
                var a = IsIENumerableLleno(ultimo());
                if(a != false)
                {
                    int id = (int)db.HorarioDocente.Max(x => x.Id);
                    return id;
                }
                int k = 0;
                return k;
            }
        }
    }
}
