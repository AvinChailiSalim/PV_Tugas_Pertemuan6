using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace TugasPertemuan6
{
    public class Koneksi
    {
        public SqlConnection GetConn()
        {
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = "Data Source = DESKTOP-QE4PEIA; initial catalog = Kasir; integrated security = true";
            return Conn;
        }
    }
}
