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
    class CicloController
    {
        public IEnumerable<CicloModel> obtenerCiclos()
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

        public void añadir(string nombre)
        {
            using (DBContextString db = new DBContextString())
            {
                Models.DAO.Ciclos ociclos = new Models.DAO.Ciclos();
                ociclos.Ciclo= nombre;
                db.Ciclos.Add(ociclos);
                db.SaveChanges();
            }
        }

        public void Eliminar(int id)
        {
            using (DBContextString db = new DBContextString())
            {
                var eciclo = (from d in db.Ciclos
                                where d.Id_Ciclo == id
                                select d).FirstOrDefault();

                db.Ciclos.Remove(eciclo);
                db.SaveChanges();
            }
        }

        public void Modificar(int id, string nombre)
        {
            using (DBContextString db = new DBContextString())
            {
                var update = db.Ciclos.Find(id);
                update.Ciclo = nombre;
                db.Entry(update).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public IEnumerable<CicloModel> Consulta(string palabra)
        {
            using (DBContextString db = new DBContextString())
            {
                IEnumerable<CicloModel> lst =
                    (from d in db.Ciclos
                     where d.Ciclo.Contains(palabra)
                     select new CicloModel
                     {
                         Id_Ciclo = (int)d.Id_Ciclo,
                         Ciclo = d.Ciclo
                     }).ToList();
                return lst;
            }
        }
    }
}
