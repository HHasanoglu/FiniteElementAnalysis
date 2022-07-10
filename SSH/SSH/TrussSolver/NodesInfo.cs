using System;
using System.Collections.Generic;
using System.Text;

namespace SSH.TrussSolver
{
    public class NodesInfo
    {
        #region Ctor
        public NodesInfo(double xcoord, double ycoord, int NodeID)
        {
            _xcoord = xcoord;
            _ycoord = ycoord;
            _NodeID = NodeID;
        }

        #endregion

        #region Private Fields

        private double _xcoord;
        private double _ycoord;
        private int _NodeID;

        #endregion


        #region Public Properties
        public double Xcoord { get => _xcoord; set => _xcoord = value; }
        public double Ycoord { get => _ycoord; set => _ycoord = value; }
        public int ID { get => _NodeID; set => _NodeID = value; }

        #endregion
    }
}
