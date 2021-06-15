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
                         Id = (int)d.Id,
                         Ciclo = d.Ciclo,
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

        public void Eliminar(int id)
        {
            using (DBContextString db = new DBContextString())
            {
                var ehorario = (from d in db.HorarioDocente
                              where d.Id_Docente == id
                              select d).FirstOrDefault();

                db.HorarioDocente.Remove(ehorario);
                db.SaveChanges();
            }
        }

        public void Modificar(int idM, int idD, string ciclo, string dia, string horai, string horaf, int id)
        {
            using (DBContextString db = new DBContextString())
            {
                var update = db.HorarioDocente.FindFind(id);
                update.Nombre_Grupo = nombre;
                update.Cuatrimestre = cuatrimestre;
                update.Id_Carrera = carrera;
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
                         Id = (int)d.Id,
                         Ciclo = d.Ciclo,
                         Nombre_Docente = d.Docente.Nombre_Docente,
                         Nombre_Materia = d.Materia.Nombre_Materia,
                         Dia = d.Dia,
                         Hora_Inicio = d.Hora_Inicio,
                         Hora_Fin = d.Hora_Fin
                     }).ToList();
                return lst;
            }
        }

        public IEnumerable<HorarioDocenteModel> comparar()
        {
            using (DBContextString db = new DBContextString())
            {
                IEnumerable<HorarioDocenteModel> lst =
                    (from d in db.HorarioDocente 
                     select new HorarioDocenteModel
                     {
                         Id_HorarioDocente = (int)d.Id_HorarioDocente,
                         Id_Docente = (int)d.Id_Docente,
                         Id_Materia = (int)d.Id_Materia,
                         Ciclo = d.Ciclo,
                         Dia = d.Dia,
                         Hora_Inicio = d.Hora_Inicio,
                         Hora_Fin = d.Hora_Fin,
                         Id = (int)d.Id
                     }).ToList();
                return lst;
            }
        }
    }
}
