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
            try {
                DataTable dt = instancia.llenarComboEscalas(comboBox1.SelectedValue.ToString(), comboBox4.SelectedValue.ToString());
                comboBox7.DataSource = dt;
                comboBox7.DisplayMember = "Nombre";
                comboBox7.ValueMember = "Codigo";
            }
            catch (Exception ex) { 
                MessageBox.Show(ex.Message);
            }
            if (Escalas.Checked == true)
            {
                presupuesto.AutoCheck = false;
            }
            else {
                presupuesto.AutoCheck = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ciudadD.Text = "";
            ciudadD.Text = "";
            paisE.Text = "";
            CostoV.Text = "";
            duracionV.Text = "";
            label10.Text = "";

            if(Escalas.Checked==true){
                //MessageBox.Show("escala");
                try {
                    string origen = comboBox3.SelectedValue.ToString();
                    string destino = comboBox6.SelectedValue.ToString();
                    string escala = comboBox7.SelectedValue.ToString();
                    Rutas d = new Rutas();
                    d.getRoute(origen, destino, escala, 3);
                    ///////
                    int c = d.clone.Count;
                    string r = "";
                    foreach (treeNode t in d.clone)
                    {
                        r += t.origen + " ---> ";
                        Console.Write(t.origen + " ---> ");
                    }
                    if (r != "")
                    {
                        try
                        {
                            ciudadO.Text = instancia.encontrarCiudad(origen);
                            ciudadD.Text = instancia.encontrarCiudad(destino);
                            paisE.Text = instancia.encontrarEscala(escala);
                            textBox3.Text = r;
                        }
                        catch (Exception ex) { }
                    }
                    else
                    {
                        label10.Text = "no existe ruta";
                    }
                }
                catch(Exception ex){
                    MessageBox.Show("Se deben seleccionar un Pais, una Ciudad y un Aeropuerto, tanto de salida como de destion");
                }
            }
            else if (presupuesto.Checked == true)
            {
                //MessageBox.Show("presupuesto");
            }
            else {
                //MessageBox.Show("sin restricciones");

                try
                {
                    string origen = comboBox3.SelectedValue.ToString();
                    string destino = comboBox6.SelectedValue.ToString();
                    string escala = "";
                    Rutas d = new Rutas();
                    d.getRoute(origen, destino, escala, 3);
                    ///////
                    int c = d.clone.Count;
                    string r = "";
                    foreach (treeNode t in d.clone)
                    {
                        r += t.origen + " ---> ";
                        Console.Write(t.origen + " ---> ");
                    }
                    if (r != "")
                    {
                        try
                        {
                            ciudadO.Text = instancia.encontrarCiudad(origen);
                            ciudadD.Text = instancia.encontrarCiudad(destino);
                            textBox3.Text = r;
                        }
                        catch (Exception ex) { }
                    }
                    else
                    {
                        label10.Text = "no existe ruta";
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show("Se deben seleccionar un Pais, una Ciudad y un Aeropuerto, tanto de salida como de destion");
                }


            }
           /* try
            {

                string origen = comboBox3.SelectedValue.ToString();
                string destino = comboBox6.SelectedValue.ToString();
                string escala = comboBox7.SelectedValue.ToString();
                // if (escala.Equals(null))
                // {
                Rutas d = new Rutas();
                d.getRoute(origen, destino, "pty", 3);
                // d.getRoute("pty", "sjo");
                Console.WriteLine("Costo");
                // List<treeNode> r=d.clone.Reverse();
                //   Console.WriteLine(d.clone[0].costo);
                Console.WriteLine("Ruta");
                int c = d.clone.Count;
                string r = "";
                foreach (treeNode t in d.clone)
                {
                    r += t.origen + " ---> ";
                    Console.Write(t.origen + " ---> ");
                }
                if (r != "")
                {
                    try
                    {
                        ciudadO.Text = instancia.encontrarCiudad(origen);
                        ciudadD.Text = instancia.encontrarCiudad(destino);
                        paisE.Text = instancia.encontrarPais(escala);
                        textBox3.Text = r;
                    }
                    catch (Exception ex) { }
                }
                else
                {
                    label10.Text = "no existe ruta";
                }

                //    }
                /*
                    if (!escala.Equals(null))
                    {

                        Rutas d = new Rutas();
                        d.getRoute(origen, escala);
                        // d.getRoute("pty", "sjo");
                        // Console.WriteLine("Costo");
                        // List<treeNode> r=d.clone.Reverse();
                        decimal costo = d.clone[1].costo;
                        Console.WriteLine("Ruta");
                        foreach (treeNode t in d.clone)
                        {

                            Console.Write(t.origen + " ---> ");
                        }
                        //scale
                        Rutas d1 = new Rutas();
                        // d.getRoute("mma", "pty");
                        d1.getRoute(escala, destino);
                        Console.WriteLine("Costo");
                        // List<treeNode> r=d.clone.Reverse();
                        costo = costo + d1.clone[1].costo; //costo total de la ruta con escala.
                        Console.WriteLine(costo);
                        Console.WriteLine("Ruta");
                        foreach (treeNode t1 in d1.clone)
                        {

                            Console.Write(t1.origen + " ---> ");
                        }
                    }*/
           /* }catch(Exception ex){
                MessageBox.Show(ex.Message);
            }*/////////
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

        /**
         * instancia de conexion con la base de datos 
         */
       conBD instancia = new conBD();

       /**
        * carga los las ciudades de los paises de origen
        */
       private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
       {
           try
           {
               string comb = comboBox1.SelectedValue.ToString();
               DataTable dt = instancia.llenarCombo2(comb);
               comboBox2.DataSource = dt;
               comboBox2.DisplayMember = "Nombre";
               comboBox2.ValueMember = "Id";

               DataTable dt1 = instancia.llenarComboEscalas(comboBox1.SelectedValue.ToString(), comboBox4.SelectedValue.ToString());
               comboBox7.DataSource = dt1;
               comboBox7.DisplayMember = "Nombre";
               comboBox7.ValueMember = "Codigo";

           }
           catch (Exception ex) { }
       }

       /**
        * carga los aeropuertos de las ciudades de origen
        */
       private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
       {
           try
           {
               string comb = comboBox2.SelectedValue.ToString();
               DataTable dt = instancia.llenarCombo3(comb);
               comboBox3.DataSource = dt;
               comboBox3.DisplayMember = "Nombre";
               comboBox3.ValueMember = "Codigo";
           }
           catch (Exception ex)
           {
               // MessageBox.Show(ex.Message);
           }
       }

       /**
        * carga las ciudades de los paises de destino
        */
       private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
       {
           try
           {
               string comb = comboBox4.SelectedValue.ToString();
               DataTable dt = instancia.llenarCombo5(comb);
               comboBox5.DataSource = dt;
               comboBox5.DisplayMember = "Nombre";
               comboBox5.ValueMember = "Id";

               DataTable dt1 = instancia.llenarComboEscalas(comboBox1.SelectedValue.ToString(), comboBox4.SelectedValue.ToString());
               comboBox7.DataSource = dt1;
               comboBox7.DisplayMember = "Nombre";
               comboBox7.ValueMember = "Codigo";

           }
           catch (Exception ex) { }
       }

       /**
        * carga los aeropuertos de las ciudades de destino
        */
       private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
       {
           try
           {
               string comb = comboBox5.SelectedValue.ToString();
               DataTable dt = instancia.llenarCombo6(comb);
               comboBox6.DataSource = dt;
               comboBox6.DisplayMember = "Nombre";
               comboBox6.ValueMember = "Codigo";
           }
           catch (Exception ex)
           {
           }
       }

       private void presupuesto_CheckedChanged(object sender, EventArgs e)
       {
           if (presupuesto.Checked == true)
           {
               textBox3.Visible = true;
               Escalas.AutoCheck = false;
           }
           else {
               textBox3.Text = "";
               textBox3.Visible = false;
               Escalas.AutoCheck = true;
           }
       }
    


    }
}
