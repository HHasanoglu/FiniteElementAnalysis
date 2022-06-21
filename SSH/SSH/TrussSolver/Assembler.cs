using System;
using System.Collections.Generic;
using System.Text;
using MathNet.Numerics.LinearAlgebra;

namespace SSH.TrussSolver
{
    public class Assembler
    {
        //public Assembler(List<TrussElement> stiffnessList, int TotalNodes, List<RestrainedNodes> restrainedNodes)
        //{
        //    _StiffnessList = stiffnessList;
        //    _TotalNodes = TotalNodes;
        //    _restrainedNodes = restrainedNodes;
        //}
            //_Ndof = _TotalNodes * _dofPerNode;
            //evaluateTotalRestrainedNodes();

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

        public Assembler(List<TrussElement> stiffnessList, List<RestrainedNodes> restrainedNodes, int totalNodes)
        {
            _StiffnessList = stiffnessList;
            _TotalNodes = totalNodes;
            _restrainedNodes = restrainedNodes;
            _Ndof = _TotalNodes * _dofPerNode;
            evaluateTotalRestrainedNodes();
        }

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
            int[,] arr2d = new int[_TotalNodes, _dofPerNode];
            foreach (var node in _restrainedNodes)
            {
                var rowID = node.NodeID;
                if (node.Direction == eRestrainedDir.XDirection)
                {
                    arr2d[rowID-1, 0] = -1;
                }
                else if (node.Direction == eRestrainedDir.YDirection)
                {
                    arr2d[rowID-1, 1] = -1;
                }
                else if (node.Direction==eRestrainedDir.XYDirection)
                {
                    arr2d[rowID-1, 0] = -1;
                    arr2d[rowID-1, 1] = -1;
                }
            }
            int count = 0;
            for (int i = 0; i < _TotalNodes; i++)
            {
                for (int j = 0; j < _dofPerNode; j++)
                {
                    if (arr2d[i, j] == 0)
                    {
                        arr2d[i, j] = count;
                        count += 1;
                    }

                }

            }

            int[] G = new int[2* _dofPerNode];

            var KG = Matrix<double>.Build.Dense(count, count);
            foreach (TrussElement element in memberList)
            {
                for (int i = 0; i < _dofPerNode; i++)
                {
                    G[i] = arr2d[element.StartNodeID - 1, i];
                    G[i+2] = arr2d[element.EndNodeID - 1, i];
                }

                Matrix<double> Kg = element.Kg;
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        var P = G[i];
                        var Q = G[j];
                        if (P!=-1 && Q!=-1)
                        {
                            KG[P, Q] = KG[P, Q] + Kg[i,j];
                        }
                    }
                }
            }
            return KG;
        }
    }
}
