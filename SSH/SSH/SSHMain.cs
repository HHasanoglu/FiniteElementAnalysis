using MathNet.Numerics.LinearAlgebra;
using SSH.TrussSolver;
using System.Collections.Generic;

namespace SSH
{
    public partial class SSHMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public SSHMain()
        {
            InitializeComponent();
            prepareData();
        }

        private void prepareData()
        {
            NodesInfo node1 = new NodesInfo(0, 0, 1);
            NodesInfo node2 = new NodesInfo(3, 0, 2);
            NodesInfo node3 = new NodesInfo(0, 4, 3);
            List<NodesInfo> listOfNodes = new List<NodesInfo>
            {
                node1,
                node2,
                node3
            };
            List<RestrainedNodes> restrainedNodes = new List<RestrainedNodes> {
                new RestrainedNodes(1,eRestrainedDir.XYDirection),
                new RestrainedNodes(3,eRestrainedDir.XYDirection),
                };
            
            PointLoad Load = new PointLoad(2, 0, -150000);

            List<TrussElement> StiffnessList = new List<TrussElement>();
            TrussElement element1 = new TrussElement(0, 0, 3, 0, 1, 2, 1, 1);
            StiffnessList.Add(element1);
            TrussElement element2 = new TrussElement(3, 0, 0, 4, 2, 3, 1, 1);
            StiffnessList.Add(element2);

            Assembler assembler = new Assembler(StiffnessList,  restrainedNodes,3);

            Matrix<double> KG =assembler.getAssembleMatrix(StiffnessList);
            Matrix<double> KGReduced = assembler.getAssembledReducedMatrix(StiffnessList);
        }
    }
}
