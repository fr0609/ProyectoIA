using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace viajes_sin_limites
{
    class Rutas
    {
        //Principal route list.
        public List<treeNode> List = new List<treeNode>();
        //List store route from Origin to destiny.
        public List<treeNode> clone = new List<treeNode>();
        //public List<treeNode> clone = new List<treeNode>();

        int finish = 0;
        decimal minimumcost = 1000;
        int _currentfinish = 0;

         //Methods to determinate the shorter route.
        /// <summary>
        /// Method to get a route.
        /// </summary>
        /// <param name="originCity"></param>
        /// <param name="destinyCity"></param>
        public void getRoute(string aeropuerto_origen, string aeropuerto_destino)
        {
            treeNode root = new treeNode(aeropuerto_origen,0, 0, 0, null);
            //Load Child Nodes.
            root.LoadChildNodes();
            //Method to determinate the full route.
            Routes(root, aeropuerto_destino, List);
        }

        /// <summary>
        /// Recursive method to obtain the route.
        /// </summary>
        /// <param name="_current"></param>
        /// <param name="destinyCity"></param>
        /// <param name="_currentList"></param>
        public void Routes(treeNode _current, string destinyCity, 
            List<treeNode> _currentList)
        {
            //Stop if found destiny city.
            if (_current.origen.Equals(destinyCity))
            {
                _currentList.Add(_current);
                finish = 1;
                _currentfinish = 1;
                return;
            }

            //Stop if the node is in the list.
            if (findNode(_current, _currentList))
            {
                _currentList.Add(_current);
                return;
            }

            //Load accesibles nodes.
            _current.LoadChildNodes();
            //Sorts ascending nodes duration.
            sortChildNodes(_current);
            //Add current node to principal nodes list.
            _currentList.Add(_current);

            int cont = _current.ChildNodes.Count;
            //Return method if is a ChildNode.
            if (cont == 0)
            {
                return;
            }

            for (int i = 0; i < cont; i++)
            {
                //Already exist a route.
                if (_currentfinish == 1)
                {   //Check if current route is shorter than min cost.
                    if (_current.costo > minimumcost)
                    {
                        return;
                    }

                }
                _current.ChildNodes[i].LoadChildNodes();
                //Recursive call to get full route.
                Routes(_current.ChildNodes[i], destinyCity, _currentList);
                //If found destiny city.
                if (finish == 1)
                {
                    finish = 0;
                    //If current route is shorter than minimun cost remplace this route.
                    if (_current.ChildNodes[i].costo < minimumcost)
                    {
                        minimumcost = _current.ChildNodes[i].costo;
                        //Create a list with the new route.
                        listClone(_currentList);
                    }
                    _currentList.RemoveAt(_currentList.Count - 1);
                    continue;
                }
                _currentList.RemoveAt(_currentList.Count - 1);
            }


        }

        /// <summary>
        /// Method to determine if the current node is already in the list
        /// </summary>
        /// <param name="node"></param>
        /// <param name="_currentList"></param>
        /// <returns></returns>
        public bool findNode(treeNode node, List<treeNode> _currentList)
        {
            for (int i = 0; i < _currentList.Count; i++)
            {   //Return true if the node was found
                if (_currentList[i].origen == node.origen)
                { return true; }
            }
            //False in otherwise
            return false;
        }

        /// <summary>
        /// Method that sorts ascending the nodes from a current node.
        /// </summary>
        /// <param name="node"></param>
        public void sortChildNodes(treeNode node)
        {
            var sortList = from o in node.ChildNodes
                           orderby o.Time ascending  //verificar
                           select o;
            node.ChildNodes = sortList.ToList<treeNode>();
            return;
        }

        /// <summary>
        /// Method that creates a list with the route from origin to destiny.
        /// </summary>
        /// <param name="list"></param>
        public void listClone(List<treeNode> list)
        {
            clone.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                treeNode node = new treeNode();
                node = list[i];
                clone.Add(node);
            }
            return;
        }
    }
    }
}
