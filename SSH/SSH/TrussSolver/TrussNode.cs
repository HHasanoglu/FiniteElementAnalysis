using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSH.TrussSolver
{
    public class TrussNode:Node
    {
        #region Ctor

        public TrussNode(int NodeID, double xcoord, double ycoord):base(NodeID,xcoord,ycoord)
        {
            _dofPerNode = 2;
        }

        #endregion

        #region Private Fields

        private eRestraintCondition _xDirection;
        private eRestraintCondition _yDirection;
        private double _fx;
        private double _fy;
        private double _dispx;
        private double _dispy;

        #endregion

        #region Public Properties

        public eRestraintCondition XDirection { get => _xDirection; set => _xDirection = value; }
        public eRestraintCondition YDirection { get => _yDirection; set => _yDirection = value; }
        public double Fx { get => _fx; set => _fx = value; }
        public double Fy { get => _fy; set => _fy = value; }
        public double Dispx { get => _dispx; set => _dispx = value; }
        public double Dispy { get => _dispy; set => _dispy = value; }

        public double getXcoordFinal(int maginifactionFactor = 100) 
        {
            return _xcoord + maginifactionFactor * _dispx;
        }
        public double getYcoordFinal(int maginifactionFactor = 100)
        {
            return _ycoord + maginifactionFactor * _dispy;
        }
        #endregion


    }
}
