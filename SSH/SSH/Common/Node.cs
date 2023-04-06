using System;
using System.Collections.Generic;
using System.Text;

namespace SSH.TrussSolver
{
    public abstract class Node
    {
        #region Ctor
        public Node(int NodeID,double xcoord, double ycoord)
        {
            _NodeID = NodeID;
            _xcoord = xcoord;
            _ycoord = ycoord;
        }

        #endregion

        #region Private Fields

        protected double _xcoord;
        protected double _ycoord;
        protected int _NodeID;
        protected int _dofPerNode;


        #endregion


        #region Public Properties
        public double Xcoord { get => _xcoord; set => _xcoord = value; }
        public double Ycoord { get => _ycoord; set => _ycoord = value; }
        public int ID { get => _NodeID; set => _NodeID = value; }
        public int DofPerNode { get => _dofPerNode; set => _dofPerNode = value; }
        #endregion
    }


}
