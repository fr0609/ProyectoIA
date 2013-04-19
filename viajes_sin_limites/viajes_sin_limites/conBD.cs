using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace viajes_sin_limites
{
    public class conBD
    {
        /**
         * consulta en la base de datos las ciudades de los paises de origen
         */
        public DataTable llenarCombo2(string comb) {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\DatabaseVSL.accdb");
            con.Open();
            OleDbDataAdapter dat = new OleDbDataAdapter("SELECT Id, Nombre, codigo_pais FROM Ciudades WHERE codigo_pais='" + comb + "'", con);
            DataTable dt = new DataTable();
            dat.Fill(dt);
           con.Close();
            return dt;
        }

        /**
         * consulta en la base de datos las ciudades de los paises de destino
         */
        public DataTable llenarCombo5(string comb) {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\DatabaseVSL.accdb");
            con.Open();
            OleDbDataAdapter dat = new OleDbDataAdapter("SELECT Id, Nombre, codigo_pais FROM Ciudades WHERE codigo_pais='" + comb + "'", con);
            DataTable dt = new DataTable();
            dat.Fill(dt);
            con.Close();
            return dt;
        }

        /**
         * consulta en la base de datos los aeropuertos de las ciudades de origen
         */
        public DataTable llenarCombo3(string comb) {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\DatabaseVSL.accdb");
            con.Open();
            OleDbDataAdapter dat = new OleDbDataAdapter("SELECT Codigo, Nombre, id_ciudad FROM Aeropuertos WHERE id_ciudad =" + comb + "", con);
            DataTable dt = new DataTable();
            dat.Fill(dt);
            con.Close();
            return dt;
        }

        /**
         * consulta en la base de datos los aeropuertos de las ciudades de destino
         */
        public DataTable llenarCombo6(string comb) {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\DatabaseVSL.accdb");
            con.Open();
            OleDbDataAdapter dat = new OleDbDataAdapter("SELECT Codigo, Nombre, id_ciudad FROM Aeropuertos WHERE id_ciudad =" + comb + "", con);
            DataTable dt = new DataTable();
            dat.Fill(dt);
            con.Close();
            return dt;
        }

        /**
         * busca el nombre de una cuidad con el codigo del aeropuerto que se encuentra an dicha ciudad
         */
        public string encontrarCiudad(string p_Aero)
        {
            try
            {
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\DatabaseVSL.accdb");
                con.Open();
                OleDbDataAdapter dat = new OleDbDataAdapter("SELECT Nombre FROM Ciudades WHERE (Id = (SELECT id_ciudad FROM Aeropuertos WHERE (Codigo = '" + p_Aero + "')))", con);
                DataTable dt = new DataTable();
                dat.Fill(dt);
                con.Close();
                string rt = dt.Rows[0][0].ToString();
                return rt;
            }catch(Exception ex){
                return "";
            }
        }

        /**
         * Busca en la base de datos el nombre del aeropuerdo donde se realizará la escala
         */
        public string encontrarEscala(string p_Escala)
        {
            try
            {
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\DatabaseVSL.accdb");
                con.Open();
                OleDbDataAdapter dat = new OleDbDataAdapter("SELECT Nombre FROM Aeropuertos WHERE (Codigo = '" + p_Escala + "')", con);
                DataTable dt = new DataTable();
                dat.Fill(dt);
                con.Close();
                string rt = dt.Rows[0][0].ToString();
                return rt;
            }
            catch (Exception ex)
            {
                return "";
            }
        }

        /**
         * consulta en la base de datos todos los aeropuertos existententes
         */
        public DataTable llenarComboEscalas(string p_PaisO,string p_PaisD)
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\DatabaseVSL.accdb");
            con.Open();
            OleDbDataAdapter dat = new OleDbDataAdapter("SELECT Aeropuertos.Codigo, Aeropuertos.Nombre FROM (Ciudades INNER JOIN Aeropuertos ON Aeropuertos.id_ciudad = Ciudades.Id) WHERE (Ciudades.codigo_pais <> '" + p_PaisO + "')AND (Ciudades.codigo_pais <> '" + p_PaisD + "')", con);
            DataTable dt = new DataTable();
            dat.Fill(dt);
            con.Close();
            return dt;
        }

    }
}
