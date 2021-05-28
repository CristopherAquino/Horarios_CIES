using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Horarios_CIES.Controllers
{
    class CarreraController 
    {
        public IEnumerable<Models.DTO.CarreraModel> obtenerCarreras()
        {
            using (Models.DAO.DBContextString db = new Models.DAO.DBContextString())
            {
                IEnumerable<Models.DTO.CarreraModel> lst = (from d in db.Carrera
                                                 select new Models.DTO.CarreraModel
                                                 {
                                                     IdCarrera = (int)d.IdCarrera,
                                                     Nombre_Carrera = d.Nombre_Carrera
                                                 }).ToList();
                return lst;
            }
        }
    }
}
