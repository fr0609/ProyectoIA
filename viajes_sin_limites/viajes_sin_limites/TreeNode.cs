using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;
namespace viajes_sin_limites
{
    /// <summary>
    /// Class for each node.
    /// </summary>
    public class treeNode
    {
        //Instance for connections, functions City, Type Road,
        //Time, Distance and Nodes.
        OleDbConnection ins = new  OleDbConnection();
        public string origen { get; set; }
        public string destino { get; set; }
        public string aerolinea { get; set; }
        public decimal tiempo { get; set; }
        public decimal distancia { get; set; }
        public decimal costo { get; set; }
        public List<treeNode> ChildNodes { get; set; }
        DatabaseVSLDataSet d= new DatabaseVSLDataSet();
        
        public treeNode()
        {

        }
        /// <summary>
        /// Class constructor.
        /// </summary>
        /// <param name="city"></param>
        /// <param name="type"></param>
        /// <param name="distance"></param>
        /// <param name="time"></param>
        /// <param name="childNodes"></param>
        public treeNode(string  aeropuerto_origen, decimal cost, decimal distanciaV,
            decimal tiempoV, List<treeNode> childNodes)
        {
            origen = aeropuerto_origen;
            ChildNodes = childNodes;
            distancia = distanciaV;
            tiempo = tiempoV;
            costo = cost;
        }

        /// <summary>
        /// Method for loading the nodes that can be reached.
        /// </summary>
        public void LoadChildNodes()
        {  
          //  DataSet DtSet = ins.LoadChildNodes(this.origen);
            DatabaseVSLDataSet1 DtSet = new DatabaseVSLDataSet1();
       //   string s=  d.Vuelo.IdColumn.ToString();
            this.ChildNodes = new List<treeNode>();
            int sum = DtSet.Vuelo.Count;
         //   DtSet.ReadXml
            for (int i = 0; i < sum; i++)
            {
                if (this.origen == DtSet.Tables[0].Rows[i][6].ToString())
                { continue; }
                treeNode node = new treeNode();
                node.origen = DtSet.Tables[0].Rows[i][6].ToString();
                //node. = DtSet.Tables[0].Rows[i][8].ToString();
                node.distancia = Convert.ToDecimal(DtSet.Tables[0].Rows[i][4].ToString());
                node.tiempo = (Convert.ToDecimal(DtSet.Tables[0].Rows[i][4].ToString())
                    * Convert.ToDecimal(DtSet.Tables[0].Rows[i][3].ToString())) + this.tiempo;
                node.ChildNodes = new List<treeNode>();
                this.ChildNodes.Add(node);
            }
        }
    }
}