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
    class HorarioGrupoCrearController
    {
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

        public IEnumerable<ComboMateriaModel> comboMateria(int? idc)
        {
            using (DBContextString db = new DBContextString())
            {
                IEnumerable<ComboMateriaModel> lst =
                    (from d in db.Materia
                     join g in db.HorarioDocente on d.Id_Materia equals g.Id_Materia
                     where g.Id_Ciclo == idc
                     orderby d.Id_Materia descending
                     select new ComboMateriaModel
                     {
                         Id_Materia = (int)d.Id_Materia,
                         Nombre_Materia = d.Nombre_Materia
                     }).Distinct().ToList();
                return lst;
            }
        }

        public IEnumerable<ComboDocenteModel> comboDocente(int? idm)
        {
            using (DBContextString db = new DBContextString())
            {
                IEnumerable<ComboDocenteModel> lst =
                    (from d in db.Docente
                     join g in db.HorarioDocente on d.Id_Docente equals g.Id_Docente
                     where g.Id_Materia == idm
                     orderby d.Id_Docente descending
                     select new ComboDocenteModel
                     {
                         Id_Docente = (int)d.Id_Docente,
                         Nombre_Docente = d.Nombre_Docente
                     }).Distinct().ToList();
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

        public void añadir(int idM, int idG, int idC, int id)
        {
            using (DBContextString db = new DBContextString())
            {
                Models.DAO.HorarioGrupo horario = new Models.DAO.HorarioGrupo();
                horario.Id_Grupo = idG;
                horario.Id_Materia = idM;
                horario.Id_Ciclo = idC;
                horario.Id = id;
                db.HorarioGrupo.Add(horario);
                db.Entry(horario).State = System.Data.Entity.EntityState.Added;
                db.SaveChanges();
            }
        }


        public bool IsIENumerableLleno(IEnumerable<HorarioGrupoModel> ultimo)
        {
            bool isFull = false;
            foreach (HorarioGrupoModel item in ultimo)
            {
                isFull = true;
                break;
            }
            return isFull;
        }

        public IEnumerable<HorarioGrupoModel> ultimo()
        {
            using (DBContextString db = new DBContextString())
            {
                IEnumerable <HorarioGrupoModel> lst =
                    (from d in db.HorarioGrupo
                     select new HorarioGrupoModel
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
                    int id = (int)db.HorarioGrupo.Max(x => x.Id);
                    return id;
                }
                int k = 0;
                return k;
            }
        }

        public bool valida(int id, int c)
        {
            using (DBContextString db = new DBContextString())
            {
                var a = IsIENumerableLleno(existencia(id, c));
                if (a != false)
                {
                    bool e = true;
                    return e;
                }
                bool k = false;
                return k;
            }
        }

        public IEnumerable<HorarioGrupoModel> existencia(int id, int ciclo)
        {
            using (DBContextString db = new DBContextString())
            {
                IEnumerable<HorarioGrupoModel> lst =
                    (from d in db.HorarioGrupo.Where(o => o.Id_Grupo == id && o.Id_Ciclo == ciclo)
                     select new HorarioGrupoModel
                     {
                         Id_Grupo = (int)d.Id_Grupo,
                     }).ToList();
                return lst;
            }
        }

        public bool IsIENumerableLlenoTabla(IEnumerable<TablaMateriaDocente> Existe)
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
                var a = IsIENumerableLlenoTabla(ObtenerTablaMaterias(idc, idM, idD));
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
