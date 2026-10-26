using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Text;

namespace Escuela
{
    public static class ConexioBD
    {
        public static OleDbConnection ObtenerConexion()
        {
            string rutaBD = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "Datos",
                "Escuela.accdb"
                );
            string cadenaConexio =
                $"provider = microsoft.ACE.OLEDB.12.0;" +
                $"Data source={rutaBD}";
            return new OleDbConnection(cadenaConexio);
        }
    }
}
