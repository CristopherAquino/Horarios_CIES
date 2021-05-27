using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;

namespace Horarios_CIES.Models.DAO
{
    //Conexion a BD
    class DBContext
    {
        protected SQLiteConnection connection = new SQLiteConnection(@"Data Source = .\DBContext.db; Version=3");
    }
}
