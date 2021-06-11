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
    class DocenteController
    {
        public IEnumerable<DocenteModel> obtenerDocentes()
        {
            using (DBContextString db = new DBContextString())
            {
                IEnumerable<DocenteModel> lst =
                    (from d in db.Docente
                     select new DocenteModel
                     {
                         Id_Docente = (int)d.Id_Docente,
                         Nombre_Docente = d.Nombre_Docente,
                         Telefono_Celular = d.Telefono_Celular,
                         Telefono_Casa = d.Telefono_Casa,
                         Telefono_Oficina =  d.Telefono_Oficina,
                         Correo_Electronico = d.Correo_Electronico
                     }).ToList();
                return lst;
            }
        }

        public void añadir(string nombre, string telcelular, string telcasa, string telofi, string correo)
        {
            using (DBContextString db = new DBContextString())
            {
                Models.DAO.Docente odocente = new Models.DAO.Docente();
                odocente.Nombre_Docente = nombre;
                odocente.Telefono_Celular = telcelular;
                odocente.Telefono_Casa = telcasa;
                odocente.Telefono_Oficina = telofi;
                odocente.Correo_Electronico = correo;
                db.Docente.Add(odocente);
                db.SaveChanges();
            }
        }

        public void Eliminar(int id)
        {
            using (DBContextString db = new DBContextString())
            {
                var edocente = (from d in db.Docente
                                where d.Id_Docente == id
                                select d).FirstOrDefault();

                db.Docente.Remove(edocente);
                db.SaveChanges();
            }
        }

        public void Modificar(int id, string nombre, string telcelular, string telcasa, string telofi, string correo)
        {
            using (DBContextString db = new DBContextString())
            {
                var update = db.Docente.Find(id);
                update.Nombre_Docente = nombre;
                update.Telefono_Celular = telcelular;
                update.Telefono_Casa = telcasa;
                update.Telefono_Oficina = telofi;
                update.Correo_Electronico = correo;
                db.Entry(update).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public IEnumerable<DocenteModel> Consulta(string palabra)
        {
            using (DBContextString db = new DBContextString())
            {
                IEnumerable<DocenteModel> lst =
                    (from d in db.Docente
                     where d.Nombre_Docente.Contains(palabra)
                     select new DocenteModel
                     {
                         Id_Docente = (int)d.Id_Docente,
                         Nombre_Docente = d.Nombre_Docente,
                         Telefono_Celular = d.Telefono_Celular,
                         Telefono_Casa = d.Telefono_Casa,
                         Telefono_Oficina = d.Telefono_Oficina,
                         Correo_Electronico = d.Correo_Electronico
                     }).ToList();
                return lst;
            }
        }
    }
}
