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
                if (node.Direction == eRestrainedDir.XYDirection)
                {
                    _nResTotal += 2;
                }
                else
                {
                    _nResTotal += 1;
                }

            }
        }

        private const int _dofPerNode = 2;
        private List<TrussElement> _ElementsList;
        private List<PointLoad> _loadList;
        private int _TotalNodes;
        private List<RestrainedNodes> _restrainedNodes;
        private int _nResTotal = 0;
        private int _Ndof;
        private Matrix<double> _KG;
        private Matrix<double> _KGReduced;
        private Matrix<double> _force;
        private Matrix<double> _forceReduced;
        private Matrix<double> _displacements;
        private Matrix<double> _displacementsTotal;
        private Matrix<double> _reactions;

        public Assembler(List<TrussElement> stiffnessList, List<PointLoad> loadList, List<RestrainedNodes> restrainedNodes, int totalNodes)
        {
            _ElementsList = stiffnessList;
            _loadList = loadList;
            _TotalNodes = totalNodes;
            _restrainedNodes = restrainedNodes;
            _Ndof = _TotalNodes * _dofPerNode;
            evaluateTotalRestrainedNodes();
            getAssembleMatrix();
            getAssembledReducedMatrix();
            GetReducedForceVector();
            GetDisplacementVector();
            GetTotalDisplacement();
            GetReactions();
            getMemberForces();
        }

        private void getMemberForces()
        {
            var Displacement = Matrix<double>.Build.Dense(4, 1);

            foreach (TrussElement element in _ElementsList)
            {

                Displacement[0,0]=_displacementsTotal[2 * element.StartNodeID - 2, 0];
                Displacement[1,0]=_displacementsTotal[2 * element.StartNodeID - 1, 0];
                Displacement[2, 0] = _displacementsTotal[2 * element.EndNodeID - 2, 0];
                Displacement[3, 0] = _displacementsTotal[2 * element.EndNodeID - 1, 0];
            }
        }

        private void GetReactions()
        {
            _reactions= _KG * _displacementsTotal;
        }

        private void getAssembleMatrix()
        {
            _KG = Matrix<double>.Build.Dense(_Ndof, _Ndof);
            //var sorted = StiffnessMatrixList.Ordw(x => x.StartNode);
            foreach (TrussElement element in _ElementsList)
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
                        _KG[i, j] = _KG[i, j] + Kg[s, en];
                        en += 1;
                    }
                    s += 1;
                }
            }
        }

        private void getAssembledReducedMatrix()
        {
            int[,] arr2d;
            int count;
            GetMappingArray(out arr2d, out count);

            int[] G = new int[2 * _dofPerNode];

            _KGReduced = Matrix<double>.Build.Dense(count, count);
            foreach (TrussElement element in _ElementsList)
            {
                for (int i = 0; i < _dofPerNode; i++)
                {
                    G[i] = arr2d[element.StartNodeID - 1, i];
                    G[i + 2] = arr2d[element.EndNodeID - 1, i];
                }

                Matrix<double> Kg = element.Kg;
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        var P = G[i];
                        var Q = G[j];
                        if (P != -1 && Q != -1)
                        {
                            _KGReduced[P, Q] = _KGReduced[P, Q] + Kg[i, j];
                        }
                    }
                }
            }
        }


        private void GetReducedForceVector()
        {
            int[,] arr2d;
            int count;
            GetMappingArray(out arr2d, out count);

            _forceReduced = Matrix<double>.Build.Dense(count, 1);

            foreach (PointLoad load in _loadList)
            {
                for (int i = 0; i < 2; i++)
                {
                    var Q = arr2d[load.NodeID - 1, i];
                    if (Q != -1)
                    {
                        switch (i)
                        {
                            case 0:

                                _forceReduced[Q, 0] = load.Load.XComponent;
                                break;
                            case 1:

                                _forceReduced[Q, 0] = load.Load.YComponent;
                                break;
                        }
                    }
                }
            }
        }

        private void GetMappingArray(out int[,] arr2d, out int count)
        {
            arr2d = new int[_TotalNodes, _dofPerNode];
            foreach (var node in _restrainedNodes)
            {
                var rowID = node.NodeID;
                if (node.Direction == eRestrainedDir.XDirection)
                {
                    arr2d[rowID - 1, 0] = -1;
                }
                else if (node.Direction == eRestrainedDir.YDirection)
                {
                    arr2d[rowID - 1, 1] = -1;
                }
                else if (node.Direction == eRestrainedDir.XYDirection)
                {
                    arr2d[rowID - 1, 0] = -1;
                    arr2d[rowID - 1, 1] = -1;
                }
            }
            count = 0;
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
        }
        private void  GetDisplacementVector()
        {

            _displacements = _KGReduced.Inverse() * _forceReduced;
        }

        private void GetTotalDisplacement()
        {
            int[,] arr2d;
            int count;
            GetMappingArray(out arr2d, out count);

            _displacementsTotal = Matrix<double>.Build.Dense(_Ndof, 1);

            for (int j = 0; j < _TotalNodes; j++)
            {
                for (int i = 0; i < 2; i++)
                {
                    var Q = arr2d[j, i];
                    if (Q != -1)
                    {
                        _displacementsTotal[2*j+i, 0] = _displacements[Q, 0];
                    }
                }
            }

        }






    }
}
