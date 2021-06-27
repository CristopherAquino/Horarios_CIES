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
    class HorarioDocenteConsultaController
    {
        public IEnumerable<HorarioDocenteMostrarModel> obtenerHorariosDocentes()
        {
            using (DBContextString db = new DBContextString())
            {
                IEnumerable<HorarioDocenteMostrarModel> lst =
                    (from d in db.HorarioDocente
                     select new HorarioDocenteMostrarModel
                     {
                         Id_HorarioDocente = (int)d.Id_HorarioDocente,
                         Id = (int)d.Id,
                         Ciclo = d.Ciclos.Ciclo,
                         Nombre_Docente = d.Docente.Nombre_Docente,
                         Nombre_Materia = d.Materia.Nombre_Materia,
                         Dia = d.Dia,
                         Hora_Inicio = d.Hora_Inicio,
                         Hora_Fin = d.Hora_Fin
                     }).ToList();
                return lst;
            }
        }

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

        public IEnumerable<CicloModel> comboCiclo()
        {
            using (DBContextString db = new DBContextString())
            {
                IEnumerable<CicloModel> lst =
                    (from d in db.Ciclos
                     select new CicloModel
                     {
                         Id_Ciclo = (int)d.Id_Ciclo,
                         Ciclo = d.Ciclo
                     }).ToList();
                return lst;
            }
        }

        public void Eliminar(int id)
        {
            using (DBContextString db = new DBContextString())
            {
                var ehorario = (from d in db.HorarioDocente
                              where d.Id_HorarioDocente == id
                              select d).FirstOrDefault();

                db.HorarioDocente.Remove(ehorario);
                db.SaveChanges();
            }
        }

        public void Modificar(int id, int idM, string dia, string horai, string horaf)
        {
            using (DBContextString db = new DBContextString())
            {
                var update = db.HorarioDocente.Find(id);
                update.Id_Materia = idM;
                update.Dia = dia;
                update.Hora_Inicio = horai;
                update.Hora_Fin = horaf;
                db.Entry(update).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public IEnumerable<HorarioDocenteMostrarModel> Consulta(string palabra)
        {
            using (DBContextString db = new DBContextString())
            {
                IEnumerable<HorarioDocenteMostrarModel> lst =
                    (from d in db.HorarioDocente
                     where d.Docente.Nombre_Docente.Contains(palabra)
                     select new HorarioDocenteMostrarModel
                     {
                         Id_HorarioDocente = (int)d.Id_HorarioDocente,
                         Id = (int)d.Id,
                         Ciclo = d.Ciclos.Ciclo,
                         Nombre_Docente = d.Docente.Nombre_Docente,
                         Nombre_Materia = d.Materia.Nombre_Materia,
                         Dia = d.Dia,
                         Hora_Inicio = d.Hora_Inicio,
                         Hora_Fin = d.Hora_Fin
                     }).ToList();
                return lst;
            }
        }

        public IEnumerable<HorarioDocenteImprimirModel> compararidentificador(int id)
        {
            using (DBContextString db = new DBContextString())
            {
                IEnumerable<HorarioDocenteImprimirModel> lst =
                    (from d in db.HorarioDocente
                     where d.Id == id
                     select new HorarioDocenteImprimirModel
                     {
                         Id = (int)d.Id,
                         Ciclo = d.Ciclos.Ciclo,
                         Nombre_Docente = d.Docente.Nombre_Docente,
                         Nombre_Materia = d.Materia.Nombre_Materia,
                         Dia = d.Dia,
                         Hora_Inicio = d.Hora_Inicio,
                         Hora_Fin = d.Hora_Fin
                     }).ToList();
                return lst;
            }
        }

        public IEnumerable<HorarioDocenteModModel> obtenermenos(int id, int numero)
        {
            using (DBContextString db = new DBContextString())
            {
                IEnumerable<HorarioDocenteModModel> lst =
                    (from d in db.HorarioDocente
                     where d.Id == numero && d.Id_HorarioDocente != id
                     select new HorarioDocenteModModel
                     {
                         Id = (int)d.Id,
                         Nombre_Materia = d.Materia.Nombre_Materia,
                         Dia = d.Dia,
                         Hora_Inicio = d.Hora_Inicio,
                         Hora_Fin = d.Hora_Fin
                     }).ToList();
                return lst;
            }
        }
    }
}
