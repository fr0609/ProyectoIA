using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace viajes_sin_limites
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rutas d = new Rutas();
            d.getRoute("mma", "sjo");
            Console.WriteLine("Exito");
            for (int i = 1; i < d.clone.Count; i++) {
                Console.WriteLine("Exito");
                Console.WriteLine(d.clone[i].origen +" ---> "+ d.clone[i-1].origen+" ---> "+d.clone[i].costo);

            
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           /* InitializeComponent();
            conexión.Open();
            comboBox1_BindingContextChanged();
            conexión.Close();*/
        }


       /* OleDbConnection conexión = new OleDbConnection(@"PROVIDER=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Quincho\Documents\GitHub\ProyectoIA\viajes_sin_limites\viajes_sin_limites\DatabaseVSL.accdb");

        public void Busqueda()
        {
            InitializeComponent();
            conexión = new OleDbConnection(@"PROVIDER=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Proyecto Abarrotes(Tiendita)\Tiendita.accdb");
            conexión.Open();
        }*/

        /*private DataTable GetData()
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\DatabaseVSL.accdb");
            con.Open();
            //DataSet dt = new DataSet(
            string comb = comboBox1.SelectedValue.ToString();
            OleDbDataAdapter dat = new OleDbDataAdapter("SELECT Id, Nombre, codigo_pais FROM Ciudades WHERE codigo_pais='" + comb + "'", con);
            // MessageBox.Show(SELECT Id, Nombre, codigo_pais FROM Ciudades WHERE codigo_pais="+comb)
            DataTable dt = new DataTable();
            dat.Fill(dt);
            return dt;
        }*/


      // private void comboBox1_BindingContextChanged(/*object sender, EventArgs e*/)
        /*{
            try
            {
                comboBox1.DataSource = GetData();
                comboBox1.DisplayMember = "codigo";
                comboBox1.ValueMember = "id_ciudad";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }   
        }*/

       private void Form1_Load(object sender, EventArgs e)
       {
           // TODO: esta línea de código carga datos en la tabla 'databaseVSLDataSet1.Paises' Puede moverla o quitarla según sea necesario.
           this.paisesTableAdapter.Fill(this.databaseVSLDataSet1.Paises);
           // TODO: esta línea de código carga datos en la tabla 'databaseVSLDataSet1.Ciudades' Puede moverla o quitarla según sea necesario.
           this.ciudadesTableAdapter.Fill(this.databaseVSLDataSet1.Ciudades);
           // TODO: esta línea de código carga datos en la tabla 'databaseVSLDataSet1.Ciudades' Puede moverla o quitarla según sea necesario.
           this.ciudadesTableAdapter.Fill(this.databaseVSLDataSet1.Ciudades);
           // TODO: esta línea de código carga datos en la tabla 'databaseVSLDataSet1.Paises' Puede moverla o quitarla según sea necesario.
           

       }


       private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
       {
           OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\DatabaseVSL.accdb");
           con.Open();
           string comb = comboBox1.SelectedValue.ToString();
           OleDbDataAdapter dat = new OleDbDataAdapter("SELECT Id, Nombre, codigo_pais FROM Ciudades WHERE codigo_pais='"+comb+"'", con);
           DataTable dt = new DataTable();
           dat.Fill(dt);
           int len= dt.Rows.Count;
           for (int i = 0; i < len; i++)
           {
               comboBox2.DataSource = dt;
               comboBox2.DisplayMember = "Nombre";
               comboBox2.ValueMember = "Id";
           }
           con.Close();
       }

       private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
       {
           try
           {
               OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\DatabaseVSL.accdb");
               con.Open();
               string comb = comboBox2.SelectedValue.ToString();
               OleDbDataAdapter dat = new OleDbDataAdapter("SELECT Codigo, Nombre, id_ciudad FROM Aeropuertos WHERE id_ciudad =" + comb + "", con);
               //MessageBox.Show(comb);
               DataTable dt = new DataTable();
               dat.Fill(dt);
               int len = dt.Rows.Count;
               for (int i = 0; i < len; i++)
               {
                   comboBox3.DataSource = dt;
                   comboBox3.DisplayMember = "Nombre";
                   comboBox3.ValueMember = "Codigo";
               }
               con.Close();
            }
            catch(Exception ex){
                // MessageBox.Show(ex.Message);
            }
       }

       private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
       {
           OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\DatabaseVSL.accdb");
           con.Open();
           string comb = comboBox4.SelectedValue.ToString();
           OleDbDataAdapter dat = new OleDbDataAdapter("SELECT Id, Nombre, codigo_pais FROM Ciudades WHERE codigo_pais='" + comb + "'", con);
           DataTable dt = new DataTable();
           dat.Fill(dt);
           int len = dt.Rows.Count;
           for (int i = 0; i < len; i++)
           {
               comboBox5.DataSource = dt;
               comboBox5.DisplayMember = "Nombre";
               comboBox5.ValueMember = "Id";
           }
           con.Close();
       }

       private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
       {
           try
            {
               OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\DatabaseVSL.accdb");
               con.Open();
               string comb = comboBox5.SelectedValue.ToString();
               OleDbDataAdapter dat = new OleDbDataAdapter("SELECT Codigo, Nombre, id_ciudad FROM Aeropuertos WHERE id_ciudad =" + comb + "", con);
               DataTable dt = new DataTable();
               dat.Fill(dt);
               int len = dt.Rows.Count;
               for (int i = 0; i < len; i++)
               {
                   comboBox6.DataSource = dt;
                   comboBox6.DisplayMember = "Nombre";
                   comboBox6.ValueMember = "Codigo";
               }
               con.Close();
            }
            catch(Exception ex){
            }
       }
    


    }
}
