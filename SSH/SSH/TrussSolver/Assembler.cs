using System;
using System.Collections.Generic;
using System.Text;
using MathNet.Numerics.LinearAlgebra;

namespace SSH.TrussSolver
{
    public class Assembler
    {
        public Assembler(List<TrussElement> stiffnessList, int TotalNodes)
        {
            _StiffnessList = stiffnessList;
            _TotalNodes = TotalNodes;
        }

        private List<TrussElement> _StiffnessList;
        private int _TotalNodes;

        public void getAssembleMatrix(List<TrussElement> StiffnessMatrixList)
        {
            //var sorted = StiffnessMatrixList.Ordw(x => x.StartNode);
            foreach (TrussElement stiffnessMatrix in StiffnessMatrixList)
            {
                Matrix<double> localstifness = stiffnessMatrix.MGlobal;
            }


        }
    }
}
