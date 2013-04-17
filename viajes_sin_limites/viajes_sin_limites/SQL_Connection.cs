using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace viajes_sin_limites
{
    class SQL_Connection
    {
        /// <summary>
        /// Method to search routes.
        /// </summary>
        /// <returns>Return a list with all cities in the BD.</returns>
        public DataTable places()
        {
            DataSet places = null;
           OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\DatabaseVSL.accdb");
            con.Open();
            OleDbDataAdapter dat = new OleDbDataAdapter("select * from Aeropuertos", con);
            dat.Fill(places);
            con.Close();
            return places.Tables[0];
        }

        /// <summary>
        /// Method that takes all nodes which can be reached from a specific node.
        /// </summary>
        /// <param name="_current"></param>
        /// <returns>Nodes which can be reached from a specific node</returns>
        public DataTable LoadChildNodes(string _current)
        {
           // DataSet dt = new DataSet();
            //Connection = Var with the Data Source connection.
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\DatabaseVSL.accdb");
            con.Open();
            OleDbDataAdapter dat = new OleDbDataAdapter("select Origen,Destino,Costo from Vuelo WHERE Origen='" + _current+"'"/*"'"+"or Destino='"+ _current +"'"*/, con);
          //  MessageBox.Show(_current]);
            DataTable dt = new DataTable();
            dat.Fill(dt);
            con.Close();
            return dt;
         /*   using (SqlConnection _conexion = new SqlConnection(connection))
            {
                using (SqlCommand _command = _conexion.CreateCommand())
                {
                    _command.CommandText = "select * from Routes R,Cities C,RouteTypes RT " +
                    "where (R.OriginCityID=(select ID from Cities cts " +
                                            "where cts.Name='" + _current + "') " +
                            "or R.DestinyCityID=(select ID from Cities cts " +
                                            "where cts.Name='" + _current + "')) " +
                    "and (R.DestinyCityID=C.ID or R.OriginCityID=C.ID) and R.RouteTypeID=RT.ID";

                    _command.CommandType = CommandType.Text;
                    SqlDataAdapter _adapter = new SqlDataAdapter(_command);
                    dt = new DataSet();
                    _conexion.Open();
                    _adapter.Fill(dt);
                    _conexion.Close();
                }
            }*/
           
        }

    }
}
