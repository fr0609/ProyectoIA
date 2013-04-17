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
        SQL_Connection ins = new  SQL_Connection();
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
        public treeNode(string  aeropuerto_origen, decimal cost,
            List<treeNode> childNodes)
        {
            origen = aeropuerto_origen;
            ChildNodes = childNodes;
          //  tiempo = tiempoV;
            costo = cost;
        }

        /// <summary>
        /// Method for loading the nodes that can be reached.
        /// </summary>
        public void LoadChildNodes()
        {
            DataTable DtSet = ins.LoadChildNodes(this.origen);
            this.ChildNodes = new List<treeNode>();
            int sum = DtSet.Rows.Count;
            //DtSet.Tables[0].Rows[][]
            for (int i = 0; i < sum; i++)
            {
                if (this.origen== DtSet.Rows[i][0].ToString())
                { continue; }
                treeNode node = new treeNode();
                node.origen = DtSet.Rows[i][0].ToString();
             //   node.tiempo = Convert.ToDecimal(DtSet.Tables[0].Rows[i][3].ToString());
                node.costo =(Convert.ToDecimal(DtSet.Rows[i][2].ToString()))+this.costo;
                
                node.ChildNodes = new List<treeNode>();
                this.ChildNodes.Add(node);
            }
        }
    }
}