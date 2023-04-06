using MathNet.Numerics.LinearAlgebra;
using System;
using System.Collections.Generic;
using System.Text;

namespace SSH.TrussSolver
{
    public class TrussElement
    {
        #region Ctor

        public TrussElement(string memberLabel,Node NodeI, Node NodeJ, double E, double A)
        {
            _memberlabel = memberLabel;
            _nodeI = NodeI;
            _nodeJ = NodeJ;
            _E = E;
            _A = A;
            EvaluateProperties();
            evaluateTransformationMatrix();
            EvaluateLocalAndGlobalStiffnessMatrix();
        }

        #endregion

        #region Private Fields

        private string _memberlabel;
        private Node _nodeI;
        private Node _nodeJ;
        private double _A;
        private double _E;
        private double _L;
        private double _theta;
        private double _K;
        private Matrix<double> _T;
        private Matrix<double> _kl;
        private Matrix<double> _kg;
        private double _IEndDisplacement;
        private double _JEndDisplacement;
        private double _IEndForce;
        private double _JEndForce;

        #endregion

        #region Public Properties

        public Matrix<double> klocal { get => _kl; set => _kl = value; }
        public Matrix<double> Kglobal { get => _kg; set => _kg = value; }
        public Matrix<double> T { get => _T; set => _T = value; }
        public double IEndDisplacement { get => _IEndDisplacement; set => _IEndDisplacement = value; }
        public double JEndDisplacement { get => _JEndDisplacement; set => _JEndDisplacement = value; }
        public double IEndForce { get => _IEndForce; set => _IEndForce = value; }
        public double JEndForce { get => _JEndForce; set => _JEndForce = value; }
        public double A { get => _A; set => _A = value; }
        public double E { get => _E; set => _E = value; }
        public double L { get => _L; set => _L = value; }
        public double Theta { get => 180 / Math.PI * _theta; set => _theta = value; }
        public Node NodeI { get => _nodeI; set => _nodeI = value; }
        public Node NodeJ { get => _nodeJ; set => _nodeJ = value; }
        public string Memberlabel { get => _memberlabel; set => _memberlabel = value; }

        #endregion

        #region Private Methods
        private void EvaluateProperties()
        {
            _L = Math.Sqrt(Math.Pow(_nodeJ.Xcoord-_nodeI.Xcoord, 2) + Math.Pow(_nodeJ.Ycoord - _nodeI.Ycoord, 2));
            _theta = Math.Atan2((_nodeJ.Ycoord - _nodeI.Ycoord), (_nodeJ.Xcoord  - _nodeI.Xcoord));
        }

        private void evaluateTransformationMatrix()
        {
            _T = Matrix<double>.Build.Dense(2, 4);
            _T[0, 0] = Math.Cos(_theta);
            _T[0, 1] = Math.Sin(_theta);
            _T[0, 2] = 0;
            _T[0, 3] = 0;

            _T[1, 0] = 0;
            _T[1, 1] = 0;
            _T[1, 2] = Math.Cos(_theta);
            _T[1, 3] = Math.Sin(_theta);
        }

        private void EvaluateLocalAndGlobalStiffnessMatrix()
        {
            _K = _E * _A / _L;
            _kl = Matrix<double>.Build.Dense(2, 2);
            _kl[0, 0] = _K;
            _kl[0, 1] = -_K;
            _kl[1, 0] = -_K;
            _kl[1, 1] = _K;

            _kg = (_T.Transpose() * _kl) * _T;
        }

        #endregion

        #region Public Methods

        void getNodeForce()
        {
            //Displacement[0, 0] = TotalDisplacementVector[2 * element.NodeI.ID - 2, 0];
            //Displacement[1, 0] = TotalDisplacementVector[2 * element.NodeI.ID - 1, 0];
            //Displacement[2, 0] = TotalDisplacementVector[2 * element.NodeJ.ID - 2, 0];
            //Displacement[3, 0] = TotalDisplacementVector[2 * element.NodeJ.ID - 1, 0];

            //var displacementLocal = element.T * Displacement;
            //element.IEndDisplacement = displacementLocal[0, 0];
            //element.JEndDisplacement = displacementLocal[1, 0];
            //element.IEndForce = element.E * element.A / element.L * (element.JEndDisplacement - element.IEndDisplacement);
            //element.JEndForce = element.E * element.A / element.L * (element.IEndDisplacement - element.JEndDisplacement);
        }

        #endregion
    }
}
