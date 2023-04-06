using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MathNet.Numerics.LinearAlgebra;

namespace SSH.TrussSolver
{
    public class Assembler
    {
        #region Ctor
        public Assembler(List<TrussElement> ElementList, List<Node> Nodes)
        {
            var KGlobal=getAssembleMatrix(Nodes, ElementList);
            var KGReduced= getAssembledReducedMatrix(Nodes,ElementList);
            var text = showMatrixRepresention(KGReduced);
            var forceReduced=GetReducedForceVector(Nodes);
            var displacement=GetDisplacementVector(KGReduced,forceReduced);
            var TotalDisplacementVector=GetTotalDisplacement(Nodes, displacement);
            var reactions=GetReactions(KGlobal, TotalDisplacementVector);
            SetMemberForces(ElementList,TotalDisplacementVector);
        }

        #endregion

        #region Private Regions

        private const int _dofPerNode = 2;
        private int _Ndof;

        #endregion

        #region private Methods

        #endregion
        private string showMatrixRepresention(Matrix<double> matrix)
        {
            var text = new StringBuilder();
            for (int i = 0; i < matrix.RowCount; i++)
            {
                for (int j = 0; j < matrix.ColumnCount; j++)
                {
                    text.Append(matrix[i, j]);
                    text.Append("\t");
                }
                text.AppendLine();
            }
            return text.ToString();
        }

        private void SetMemberForces(List<TrussElement> ElementsList, Matrix<double> TotalDisplacementVector)
        {
            var Displacement = Matrix<double>.Build.Dense(4, 1);

            foreach (TrussElement element in ElementsList)
            {
                Displacement[0, 0] = TotalDisplacementVector[2 * element.NodeI.ID - 2, 0];
                Displacement[1, 0] = TotalDisplacementVector[2 * element.NodeI.ID - 1, 0];
                Displacement[2, 0] = TotalDisplacementVector[2 * element.NodeJ.ID - 2, 0];
                Displacement[3, 0] = TotalDisplacementVector[2 * element.NodeJ.ID - 1, 0];

                var displacementLocal = element.T * Displacement;
                element.IEndDisplacement = displacementLocal[0, 0];
                element.JEndDisplacement = displacementLocal[1, 0];
                element.IEndForce = element.E * element.A / element.L * (element.JEndDisplacement - element.IEndDisplacement);
                element.JEndForce = element.E * element.A / element.L * (element.IEndDisplacement - element.JEndDisplacement);

            }
        }

        private Matrix<double> GetReactions(Matrix<double> KG, Matrix<double> displacementsTotal)
        {
            return KG * displacementsTotal;
        }

        private Matrix<double> getAssembleMatrix(List<Node> Nodes, List<TrussElement> ElementsList)
        {
            var Ndof = Nodes.Count * Nodes[0].DofPerNode;
            var KG = Matrix<double>.Build.Dense(Ndof, Ndof);
            var arr2d= GetMappingArrayPrimary(Nodes);
            var G = new int[2 * _dofPerNode];

            //var sorted = StiffnessMatrixList.Ordw(x => x.StartNode);
            foreach (TrussElement element in ElementsList)
            {
                Matrix<double> Kg = element.Kglobal;
                for (int i = 0; i < _dofPerNode; i++)
                {
                    G[i] = arr2d[element.NodeI.ID - 1, i];
                    G[i + 2] = arr2d[element.NodeJ.ID - 1, i];
                }

                for (int i = 0; i <= 3; i++)
                {
                    var P = G[i];
                    for (int j = 0; j <= 3; j++)
                    {
                        var Q = G[j];
                        KG[P, Q] = KG[P, Q] + Kg[i, j];
                    }
                }
            }
            return KG;
        }

        private Matrix<double> getAssembledReducedMatrix(List<Node> Nodes,List<TrussElement> ElementsList)
        {
            GetMappingArray(out int[,] arr2d, out int count, Nodes);

            int[] G = new int[2 * _dofPerNode];

            var KGReduced = Matrix<double>.Build.Dense(count, count);
            foreach (TrussElement element in ElementsList)
            {
                for (int i = 0; i < _dofPerNode; i++)
                {
                    G[i] = arr2d[element.NodeI.ID - 1, i];
                    G[i + 2] = arr2d[element.NodeJ.ID - 1, i];
                }

                Matrix<double> Kg = element.Kglobal;
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        var P = G[i];
                        var Q = G[j];
                        if (P != -1 && Q != -1)
                        {
                            KGReduced[P, Q] = KGReduced[P, Q] + Kg[i, j];
                        }
                    }
                }
            }
            return KGReduced;
        }


        private Matrix<double> GetReducedForceVector(List<Node> Nodes)
        {
            GetMappingArray(out int[,] arr2d, out int count, Nodes);

            var  forceReduced = Matrix<double>.Build.Dense(count, 1);

            foreach (TrussNode node in Nodes)
            {
                for (int i = 0; i < 2; i++)
                {
                    var Q = arr2d[node.ID - 1, i];
                    if (Q != -1)
                    {
                        switch (i)
                        {
                            case 0:

                                forceReduced[Q, 0] = node.Fx;
                                break;
                            case 1:

                                forceReduced[Q, 0] = node.Fy;
                                break;
                        }
                    }
                }
            }
            return forceReduced;
        }

        private void GetMappingArray(out int[,] arr2d, out int count, List<Node> Nodes)
        {

            arr2d = new int[Nodes.Count, Nodes[0].DofPerNode];
            foreach (TrussNode node in Nodes)
            {
                var rowID = node.ID;
                if (node.XDirection == eRestraintCondition.restrained) arr2d[rowID - 1, 0] = -1;
                if (node.YDirection == eRestraintCondition.restrained) arr2d[rowID - 1, 1] = -1;
            }
            count = 0;
            for (int i = 0; i < Nodes.Count; i++)
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

        private int[,] GetMappingArrayPrimary(List<Node> Nodes)
        {

            int[,]arr2d = new int[Nodes.Count, Nodes[0].DofPerNode];
            var count = 0;
            for (int i = 0; i < Nodes.Count; i++)
            {
                for (int j = 0; j < _dofPerNode; j++)
                {
                        arr2d[i, j] = count;
                }
            }
            return arr2d;
        }
        private Matrix<double> GetDisplacementVector(Matrix<double> KGReduced, Matrix<double> forceReduced)
        {

            return KGReduced.Inverse() * forceReduced;
        }

        private Matrix<double> GetTotalDisplacement(List<Node> Nodes, Matrix<double> displacements)
        {
            GetMappingArray(out int[,] arr2d, out int count, Nodes);
            var NumberOfDof = Nodes.Count * Nodes[0].DofPerNode;
            var displacementsTotal = Matrix<double>.Build.Dense(NumberOfDof, 1);

            for (int j = 0; j < NumberOfDof / 2; j++)
            {
                for (int i = 0; i < 2; i++)
                {
                    var Q = arr2d[j, i];
                    if (Q != -1)
                    {
                        var Id = 2 * j + i;
                        displacementsTotal[Id, 0] = displacements[Q, 0];
                        var node = (TrussNode)Nodes.FirstOrDefault(x => x.ID == j+1);
                        if (i==0)
                        {
                            node.Dispx = displacements[Q, 0];
                        }
                        else
                        {
                            node.Dispy= displacements[Q, 0];
                        }
                    }
                }
            }
            return displacementsTotal;
        }






    }
}
