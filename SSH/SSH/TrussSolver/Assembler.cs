using System;
using System.Collections.Generic;
using System.Text;
using MathNet.Numerics.LinearAlgebra;

namespace SSH.TrussSolver
{
    public class Assembler
    {
        public Assembler(List<TrussElement> stiffnessList, int TotalNodes,List<RestrainedNodes> restrainedNodes)
        {
            _StiffnessList = stiffnessList;
            _TotalNodes = TotalNodes;
            _restrainedNodes = restrainedNodes;
            _Ndof = _TotalNodes * _dofPerNode;
            evaluateTotalRestrainedNodes();
        }

        private void evaluateTotalRestrainedNodes()
        {
            foreach (var node in _restrainedNodes)
            {
                if (node.Direction==eRestrainedDir.XYDirection)
                {
                    _nResTotal += 2;
                }
                else
                {
                    _nResTotal += 1;
                }

            }
        }

        private const int _dofPerNode=2;
        private List<TrussElement> _StiffnessList;
        private int _TotalNodes;
        private List<RestrainedNodes> _restrainedNodes;
        private int _nResTotal=0;
        private int _Ndof;

        public Matrix<double> getAssembleMatrix(List<TrussElement> memberList)
        {
            var KG = Matrix<double>.Build.Dense(_Ndof, _Ndof);
            //var sorted = StiffnessMatrixList.Ordw(x => x.StartNode);
            foreach (TrussElement element in memberList)
            {
                Matrix<double> Kg = element.Kg;
                var st1 = 2 * element.StartNodeID - 2;
                var st2 = 2 * element.StartNodeID - 1;
                var end1 = 2 * element.EndNodeID - 2;
                var end2 = 2 * element.EndNodeID - 1;
                var s = 0;
                for (int i = st1; i <= end2; i++)
                {
                    var en = 0; 
                    for (int j = st1; j <=end2; j++)
                    { 
                      KG[i, j] = KG[i, j] + Kg[s, en];
                        en += 1;
                    }
                    s +=1;
                }
            }
            return KG;
        }

        public Matrix<double> getAssembledReducedMatrix(List<TrussElement> memberList)
        {
            var KG = Matrix<double>.Build.Dense(_Ndof - _nResTotal, _Ndof - _nResTotal);
            //var sorted = StiffnessMatrixList.Ordw(x => x.StartNode);
            foreach (TrussElement element in memberList)
            {
                Matrix<double> Kg = element.Kg;
                var st1 = 2 * element.StartNodeID - 2;
                var st2 = 2 * element.StartNodeID - 1;
                var end1 = 2 * element.EndNodeID - 2;
                var end2 = 2 * element.EndNodeID - 1;
                var s = 0;
                for (int i = st1; i <= end2; i++)
                {
                    var en = 0;
                    for (int j = st1; j <= end2; j++)
                    {
                        KG[i, j] = KG[i, j] + Kg[s, en];
                        en += 1;
                    }
                    s += 1;
                }
            }
            return KG;
        }
    }
}
