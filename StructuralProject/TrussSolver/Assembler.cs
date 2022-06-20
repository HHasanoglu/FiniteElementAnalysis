//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace StructuralProject.TrussSolver
//{
//    public class Assembler
//    {
//        public Assembler(List<TrussStiffnessMatrix> stiffnessList, int TotalNodes)
//        {
//            _StiffnessList = stiffnessList;
//            _TotalNodes = TotalNodes;
//        }

//        private List<TrussStiffnessMatrix> _StiffnessList;
//        private int _TotalNodes;

//        public void getAssembleMatrix(List<TrussStiffnessMatrix> StiffnessMatrixList)
//        {
//            //var sorted = StiffnessMatrixList.Ordw(x => x.StartNode);
//            foreach (TrussStiffnessMatrix stiffnessMatrix in StiffnessMatrixList)
//            {
//                Matrix<double> localstifness = stiffnessMatrix.MGlobal;
//            }


//        }
//    }
//}
