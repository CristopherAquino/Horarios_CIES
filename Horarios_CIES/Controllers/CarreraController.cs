using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Horarios_CIES.Views;
using Horarios_CIES.Models.DTO;
using Horarios_CIES.Models.DAO;
using System.Data;
using System.Data.SQLite;

namespace Horarios_CIES.Controllers
{
    class CarreraController
    {
        public IEnumerable<CarreraModel> obtenerCarreras()
        {
            using (DBContextString db = new DBContextString())
            {
                IEnumerable<CarreraModel> lst =
                    (from d in db.Carrera
                     select new CarreraModel
                     {
                         IdCarrera = (int)d.IdCarrera,
                         Nombre_Carrera = d.Nombre_Carrera
                     }).ToList();
                return lst;
            }
        }

        public void añadir(string nombre)
        {
            using (DBContextString db = new DBContextString())
            {
                Models.DAO.Carrera ocarrera = new Models.DAO.Carrera();
                ocarrera.Nombre_Carrera = nombre;
                db.Carrera.Add(ocarrera);
                db.SaveChanges();
            }
        }

        public void Eliminar(int id)
        {
            using (DBContextString db = new DBContextString())
            {
                var ecarrera = (from d in db.Carrera
                                where d.IdCarrera == id
                                select d).FirstOrDefault();

                db.Carrera.Remove(ecarrera);
                db.SaveChanges();
            }
        }

        public void Modificar(int id,string nombre)
        {
            using (DBContextString db = new DBContextString())
            {
                var update = db.Carrera.Find(id);
                update.Nombre_Carrera = nombre;
                db.Entry(update).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public IEnumerable<CarreraModel> Consulta(string palabra)
        {
            using (DBContextString db = new DBContextString())
            {
                IEnumerable<CarreraModel> lst =
                    (from d in db.Carrera
                     where d.Nombre_Carrera.Contains(palabra)
                     select new CarreraModel
                     {
                         IdCarrera = (int)d.IdCarrera,
                         Nombre_Carrera = d.Nombre_Carrera
                     }).ToList();
                return lst;
            }
        }

    }
}
