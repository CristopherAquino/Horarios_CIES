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
        public IEnumerable<GrupoModelObtener> obtenerGrupos()
        {
            using (DBContextString db = new DBContextString())
            {
                IEnumerable<GrupoModelObtener> lst =
                    (from d in db.Grupo
                     select new GrupoModelObtener
                     {
                         Id_Grupo = (int)d.Id_Grupo,
                         Nombre_Grupo = d.Nombre_Grupo,
                         Cuatrimestre = d.Cuatrimestre,
                         NombreCarrera = d.Carrera.Nombre_Carrera
                     }).ToList();
                return lst;
            }
        }

        public void añadir(string nombre, string cuatrimestre, int carrera)
        {
            using (DBContextString db = new DBContextString())
            {
                Models.DAO.Grupo ogrupo = new Models.DAO.Grupo();
                ogrupo.Nombre_Grupo = nombre;
                ogrupo.Cuatrimestre = cuatrimestre;
                ogrupo.Id_Carrera = carrera;
                db.Grupo.Add(ogrupo);
                db.SaveChanges();
            }
        }

        public void Eliminar(int id)
        {
            using (DBContextString db = new DBContextString())
            {
                var egrupo = (from d in db.Grupo
                              where d.Id_Grupo == id
                              select d).FirstOrDefault();

                db.Grupo.Remove(egrupo);
                db.SaveChanges();
            }
        }

        public void Modificar(int id, string nombre, string cuatrimestre, int carrera)
        {
            using (DBContextString db = new DBContextString())
            {
                var update = db.Grupo.Find(id);
                update.Nombre_Grupo = nombre;
                update.Cuatrimestre = cuatrimestre;
                update.Id_Carrera = carrera;
                db.Entry(update).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public IEnumerable<GrupoModelObtener> Consulta(string palabra)
        {
            using (DBContextString db = new DBContextString())
            {
                IEnumerable<GrupoModelObtener> lst =
                    (from d in db.Grupo
                     where d.Nombre_Grupo.Contains(palabra)
                     select new GrupoModelObtener
                     {
                         Id_Grupo = (int)d.Id_Grupo,
                         Nombre_Grupo = d.Nombre_Grupo,
                         Cuatrimestre = d.Cuatrimestre,
                         NombreCarrera = d.Carrera.Nombre_Carrera
                     }).ToList();
                return lst;
            }
        }
    }
}
