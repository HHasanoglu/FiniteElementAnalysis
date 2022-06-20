using MathNet.Numerics.LinearAlgebra;
using System;
using System.Collections.Generic;
using System.Text;

namespace SSH.TrussSolver
{
    public class TrussElement
    {
        #region Ctor

        public TrussElement(double startNodeXcoord, double startNodeYcoord, double endNodeXcoord, double endNodeYcoord, int startNodeID, int endNodeID, double E, double A)
        {
            _startNodeXcoord = startNodeXcoord;
            _startNodeYcoord = startNodeYcoord;
            _endNodeXcoord = endNodeXcoord;
            _endNodeYcoord = endNodeYcoord;
            _startNodeID = startNodeID;
            _endNodeID = endNodeID;
            _E = E;
            _A = A;
            EvaluateProperties();
            evaluateTransformationMatrix();
            EvaluateLocalAndGlobalStiffnessMatrix();
        }

        #endregion

        #region Private Fields

        private double _startNodeXcoord;
        private double _startNodeYcoord;
        private double _endNodeXcoord;
        private double _endNodeYcoord;
        private int _startNodeID;
        private int _endNodeID;
        private double _A;
        private double _E;
        private double _L;
        private double _theta;
        private double _K;
        private Matrix<double> _T;
        private Matrix<double> _kl;
        private Matrix<double> _kg;

        //public TrussElement(double startNodeXcoord, double startNodeYcoord, double endNodeXcoord, double endNodeYcoord, double startNodeID, double endNodeID, double E, double A)
        //{
        //    _startNodeXcoord = startNodeXcoord;
        //    _startNodeYcoord = startNodeYcoord;
        //    _endNodeXcoord = endNodeXcoord;
        //    _endNodeYcoord = endNodeYcoord;
        //    _startNodeID = startNodeID;
        //    _endNodeID = endNodeID;
        //    _A = E;
        //    _E = A;
        //    EvaluateProperties();
        //    evaluateTransformationMatrix();
        //    EvaluateLocalAndGlobalStiffnessMatrix();

        //}

        #endregion

        #region Public Fiels

        public double StartNodeXcoord { get => _startNodeXcoord; set => _startNodeXcoord = value; }
        public double StartNodeYcoord { get => _startNodeYcoord; set => _startNodeYcoord = value; }
        public double EndNodeXcoord { get => _endNodeXcoord; set => _endNodeXcoord = value; }
        public double EndNodeYcoord { get => _endNodeYcoord; set => _endNodeYcoord = value; }
        public int  StartNodeID { get => _startNodeID; set => _startNodeID = value; }
        public int EndNodeID { get => _endNodeID; set => _endNodeID = value; }
        public Matrix<double> kl { get => _kl; set => _kl = value; }
        public Matrix<double> Kg { get => _kg; set => _kg = value; }

        #endregion


        #region Private Methods
        private void EvaluateProperties()
        {
            _L = Math.Sqrt(Math.Pow(_endNodeXcoord - _startNodeXcoord, 2) + Math.Pow(_endNodeYcoord - _startNodeYcoord, 2));
            _theta = Math.Atan2((_endNodeYcoord - _startNodeYcoord), (_endNodeXcoord - _startNodeXcoord));
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
    }
}
