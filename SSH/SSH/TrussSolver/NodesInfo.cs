using System;
using System.Collections.Generic;
using System.Text;

namespace SSH.TrussSolver
{
    public class NodesInfo
    {
        #region Ctor
        public NodesInfo(int NodeID,double xcoord, double ycoord)
        {
            _NodeID = NodeID;
            _xcoord = xcoord;
            _ycoord = ycoord;
        }

        #endregion

        #region Private Fields

        private double _xcoord;
        private double _ycoord;
        private int _NodeID;
        private eRestraintCondition _xDirection;
        private eRestraintCondition _yDirection;
        private double _fx;
        private double _fy;


        #endregion


        #region Public Properties
        public double Xcoord { get => _xcoord; set => _xcoord = value; }
        public double Ycoord { get => _ycoord; set => _ycoord = value; }
        public int ID { get => _NodeID; set => _NodeID = value; }
        public eRestraintCondition XDirection { get => _xDirection; set => _xDirection = value; }
        public eRestraintCondition YDirection { get => _yDirection; set => _yDirection = value; }
        public double Fx { get => _fx; set => _fx = value; }
        public double Fy { get => _fy; set => _fy = value; }

        #endregion
    }
}
