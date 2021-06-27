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
    class HorarioGrupoConsultaController
    {
        public IEnumerable<HorarioGrupoMostrarModel> obtenerHorariosGrupos()
        {
            using (DBContextString db = new DBContextString())
            {
                IEnumerable<HorarioGrupoMostrarModel> lst =
                    (from d in db.HorarioGrupo
                     join g in db.HorarioDocente on d.Id_Materia equals g.Id_Materia
                     orderby d.Id
                     select new HorarioGrupoMostrarModel
                     {
                         Id = (int)d.Id,
                         Ciclo = d.Ciclos.Ciclo,
                         Nombre_Grupo = d.Grupo.Nombre_Grupo,
                         Nombre_Materia = d.Materia.Nombre_Materia,
                         Nombre_Docente = g.Docente.Nombre_Docente,
                         Dia = g.Dia,
                         Hora_Inicio = g.Hora_Inicio,
                         Hora_Fin = g.Hora_Fin
                     }).Distinct().ToList();
                return lst;
            }
        }

        public IEnumerable<GrupoModel> comboGrupo()
        {
            using (DBContextString db = new DBContextString())
            {
                IEnumerable<GrupoModel> lst =
                    (from d in db.Grupo
                     select new GrupoModel
                     {
                         Id_Grupo = (int)d.Id_Grupo,
                         Nombre_Grupo = d.Nombre_Grupo
                     }).ToList();
                return lst;
            }
        }

        public IEnumerable<ComboMateriaModel> comboMateria()
        {
            using (DBContextString db = new DBContextString())
            {
                IEnumerable<ComboMateriaModel> lst =
                    (from d in db.Materia
                     select new ComboMateriaModel
                     {
                         Id_Materia = (int)d.Id_Materia,
                         Nombre_Materia = d.Nombre_Materia
                     }).ToList();
                return lst;
            }
        }

        public IEnumerable<ComboDocenteModel> comboDocente()
        {
            using (DBContextString db = new DBContextString())
            {
                IEnumerable<ComboDocenteModel> lst =
                    (from d in db.Docente
                     select new ComboDocenteModel
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

        public IEnumerable<TablaMateriaDocente> ObtenerTablaMaterias(int? idc, int? idM, int? idD)
        {
            using (DBContextString db = new DBContextString())
            {
                IEnumerable<TablaMateriaDocente> lst =
                    (from d in db.HorarioDocente
                     where d.Id_Materia == idM && d.Id_Ciclo == idc && d.Id_Docente == idD
                     select new TablaMateriaDocente
                     {
                         Dia = d.Dia,
                         Hora_Inicio = d.Hora_Inicio,
                         Hora_Fin = d.Hora_Fin
                     }).ToList();
                return lst;
            }
        }

        public void Eliminar(int id, int idM)
        {
            using (DBContextString db = new DBContextString())
            {
                var ehorario = (from d in db.HorarioGrupo
                                where d.Id == id && d.Id_Materia == idM
                                select d).ToList();

                db.HorarioGrupo.RemoveRange(ehorario);
                db.SaveChanges();
            }
        }

        public void Modificar(int id, int idC, int idG, int idMV, int idM)
        {
            using (DBContextString db = new DBContextString())
            {
                var ehorario = (from d in db.HorarioGrupo
                                where d.Id == id && d.Id_Materia == idMV
                                select d).ToList();

                db.HorarioGrupo.RemoveRange(ehorario);
                db.SaveChanges();

                Models.DAO.HorarioGrupo horario = new Models.DAO.HorarioGrupo();
                horario.Id = id;
                horario.Id_Grupo = idG;
                horario.Id_Materia = idM;
                horario.Id_Ciclo = idC;
                db.HorarioGrupo.Add(horario);
                db.SaveChanges();
            }
        }

        public IEnumerable<HorarioGrupoMostrarModel> Consulta(string s)
        {
            using (DBContextString db = new DBContextString())
            {
                IEnumerable<HorarioGrupoMostrarModel> lst =
                    (from d in db.HorarioGrupo
                     join g in db.HorarioDocente on d.Id_Materia equals g.Id_Materia
                     where d.Grupo.Nombre_Grupo.Contains(s)
                     orderby d.Id
                     select new HorarioGrupoMostrarModel
                     {
                         Id = (int)d.Id,
                         Ciclo = d.Ciclos.Ciclo,
                         Nombre_Grupo = d.Grupo.Nombre_Grupo,
                         Nombre_Materia = d.Materia.Nombre_Materia,
                         Nombre_Docente = g.Docente.Nombre_Docente,
                         Dia = g.Dia,
                         Hora_Inicio = g.Hora_Inicio,
                         Hora_Fin = g.Hora_Fin
                     }).Distinct().ToList();
                return lst;
            }
        }

        public IEnumerable<HorarioGrupoImprimirModel> compararidentificador(int id)
        {
            using (DBContextString db = new DBContextString())
            {
                IEnumerable<HorarioGrupoImprimirModel> lst =
                    (from d in db.HorarioGrupo
                     join g in db.HorarioDocente on d.Id_Materia equals g.Id_Materia
                     orderby d.Id
                     where d.Id == id
                     select new HorarioGrupoImprimirModel
                     {
                         Id = (int)d.Id,
                         Ciclo = d.Ciclos.Ciclo,
                         Nombre_Materia = d.Materia.Nombre_Materia,
                         Nombre_Docente = g.Docente.Nombre_Docente,
                         Dia = g.Dia,
                         Hora_Inicio = g.Hora_Inicio,
                         Hora_Fin = g.Hora_Fin
                     }).Distinct().ToList();
                return lst;
            }
        }

        public IEnumerable<HorarioGrupoModModel> obtenermenos(int idMV, int numero)
        {
            using (DBContextString db = new DBContextString())
            {
                IEnumerable<HorarioGrupoModModel> lst =
                    (from d in db.HorarioGrupo
                     join g in db.HorarioDocente on d.Id_Materia equals g.Id_Materia
                     orderby d.Id
                     where d.Id == numero && d.Id_Materia != idMV
                     select new HorarioGrupoModModel
                     {
                         Id = (int)d.Id,
                         Nombre_Materia = d.Materia.Nombre_Materia,
                         Dia = g.Dia,
                         Hora_Inicio = g.Hora_Inicio,
                         Hora_Fin = g.Hora_Fin
                     }).Distinct().ToList();
                return lst;
            }
        }

        public bool IsIENumerableLleno(IEnumerable<TablaMateriaDocente> Existe)
        {
            bool isFull = false;
            foreach (TablaMateriaDocente item in Existe)
            {
                isFull = true;
                break;
            }
            return isFull;
        }

        public bool vacia(int? idc, int? idM, int? idD)
        {
            using (DBContextString db = new DBContextString())
            {
                var a = IsIENumerableLleno(ObtenerTablaMaterias(idc,idM,idD));
                if (a != false)
                {
                    bool e = true;
                    return e;
                }
                bool k = false;
                return k;
            }
        }
    }
}
