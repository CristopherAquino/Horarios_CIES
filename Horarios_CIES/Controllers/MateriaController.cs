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
    class MateriaController
    {
        public IEnumerable<MateriaModelObtener> obtenerMaterias()
        {
            using (DBContextString db = new DBContextString())
            {
                IEnumerable<MateriaModelObtener> lst =
                    (from d in db.Materia
                     select new MateriaModelObtener
                     {
                         Id_Materia = (int)d.Id_Materia,
                         Codigo_Materia = d.Codigo_Materia,
                         Nombre_Materia = d.Nombre_Materia,
                         NombreGrupo = d.Grupo.Nombre_Grupo
                     }).ToList();
                return lst;
            }
        }

        public void añadir(string nombre, string codigo, int grupo)
        {
            using (DBContextString db = new DBContextString())
            {
                Models.DAO.Materia omateria = new Models.DAO.Materia();
                omateria.Codigo_Materia = codigo;
                omateria.Nombre_Materia = nombre;
                omateria.Id_Grupo = grupo;
                db.Materia.Add(omateria);
                db.SaveChanges();
            }
        }

        public void Eliminar(int id)
        {
            using (DBContextString db = new DBContextString())
            {
                var emateria = (from d in db.Materia
                              where d.Id_Materia == id
                              select d).FirstOrDefault();

                db.Materia.Remove(emateria);
                db.SaveChanges();
            }
        }

        public void Modificar(int id, string nombre, string codigo, int grupo)
        {
            using (DBContextString db = new DBContextString())
            {
                var update = db.Materia.Find(id);
                update.Nombre_Materia = nombre;
                update.Codigo_Materia = codigo;
                update.Id_Grupo = grupo;
                db.Entry(update).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public IEnumerable<MateriaModelObtener> Consulta(string palabra)
        {
            using (DBContextString db = new DBContextString())
            {
                IEnumerable<MateriaModelObtener> lst =
                    (from d in db.Materia
                     where d.Nombre_Materia.Contains(palabra)
                     select new MateriaModelObtener
                     {
                         Id_Materia = (int)d.Id_Materia,
                         Codigo_Materia = d.Codigo_Materia,
                         Nombre_Materia = d.Nombre_Materia,
                         NombreGrupo = d.Grupo.Nombre_Grupo
                     }).ToList();
                return lst;
            }
        }

        public IEnumerable<GrupoModel> combo()
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
    }
}
