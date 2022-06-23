using System;
using System.Collections.Generic;
using System.Text;

namespace SSH.TrussSolver
{
    public class NodesInfo
    {
        #region Ctor
        public NodesInfo(double xcoord, double ycoord, double NodeID)
        {
            _xcoord = xcoord;
            _ycoord = ycoord;
            _NodeID = NodeID;
        }

        #endregion

        #region Private Fields

        private double _xcoord;
        private double _ycoord;
        private double _NodeID;
        private Load _Load;

        #endregion


        #region Public Properties
        public double Xcoord { get => _xcoord; set => _xcoord = value; }
        public double Ycoord { get => _ycoord; set => _ycoord = value; }
        public double NodeID { get => _NodeID; set => _NodeID = value; }
        public Load load =new Load();

        #endregion
    }
}
