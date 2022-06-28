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

            List<PointLoad> loadList = new List<PointLoad>();
            PointLoad Load = new PointLoad(2, new Load(0, -150000));
            loadList.Add(Load);

            List<TrussElement> trussMemberList = new List<TrussElement>();
            TrussElement element1 = new TrussElement(0, 0, 3, 0, 1, 2, 1, 1);
            trussMemberList.Add(element1);
            TrussElement element2 = new TrussElement(3, 0, 0, 4, 2, 3, 1, 1);
            trussMemberList.Add(element2);

            Assembler assembler = new Assembler(trussMemberList, loadList,restrainedNodes, listOfNodes.Count);



        }
    }
}
