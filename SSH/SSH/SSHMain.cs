using SSH.TrussSolver;
using System;
using System.Collections.Generic;
using System.Data;

namespace SSH
{

    public partial class SSHMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region Ctor

        public SSHMain()
        {
            InitializeComponent();
            SubscribeToEvents();
            _nodesList = new List<NodesInfo>();
            _TrussElementsList = new List<TrussElement>();

            SetNodeTableColumns();
            SetElementsTableColumns();
            EditNodeTableGridView();
            EditElementsTableGridView();

        }

        #endregion

        #region Private Fields

        private List<NodesInfo> _nodesList;
        private List<TrussElement> _TrussElementsList;
        private int _nodeCount;
        private DataTable _dataNodeTable;
        private DataTable _dataTrussElementsTable;

        #endregion

        #region Private Methods
        private void SubscribeToEvents()
        {
            btnAddNode.Click += BtnAddNode_Click;
            btnAddElement.Click += BtnAddElement_Click;
        }

        private void BtnAddElement_Click(object sender, EventArgs e)
        {
            var startnodeId = Convert.ToInt32(txtNodeI.Text);
            var EndnodeId = Convert.ToInt32(txtNodeJ.Text);
            NodesInfo startNode = _nodesList.Find(obj => obj.ID == startnodeId);
            NodesInfo endNode = _nodesList.Find(obj => obj.ID == EndnodeId);
            var E = Convert.ToDouble(txtStiffness.Text);
            var A = Convert.ToDouble(txtSectionArea.Text);

            _TrussElementsList.Add(new TrussElement(startNode, endNode, E, A));
            AddElementsDataRows();
        }

        private void EditNodeTableGridView()
        {
            gvNodes.OptionsView.ShowGroupPanel = false;
            gvNodes.OptionsCustomization.AllowColumnMoving = false;
            gvNodes.OptionsCustomization.AllowFilter = false;
            gvNodes.OptionsMenu.EnableColumnMenu = false;
            gvNodes.OptionsView.ShowIndicator = false;
            gvNodes.OptionsView.AllowHtmlDrawHeaders = true;
            gvNodes.OptionsView.ColumnAutoWidth = true;
            gvNodes.Columns[0].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            gvNodes.Columns[1].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gvNodes.Columns[2].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gvNodes.Columns[0].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            gvNodes.Columns[1].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gvNodes.Columns[2].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
        }

        private void EditElementsTableGridView()
        {
            gvTrussElements.OptionsView.ShowGroupPanel = false;
            gvTrussElements.OptionsCustomization.AllowColumnMoving = false;
            gvTrussElements.OptionsCustomization.AllowFilter = false;
            gvTrussElements.OptionsMenu.EnableColumnMenu = false;
            gvTrussElements.OptionsView.ShowIndicator = false;
            gvTrussElements.OptionsView.AllowHtmlDrawHeaders = true;
            gvTrussElements.Columns[0].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            gvTrussElements.Columns[1].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gvTrussElements.Columns[2].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gvTrussElements.Columns[0].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            gvTrussElements.Columns[1].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gvTrussElements.Columns[2].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
        }

        private void AddNodesDataRows()
        {
            DataRow row;
            _dataNodeTable.Rows.Clear();
            foreach (NodesInfo node in _nodesList)
            {
                row = _dataNodeTable.NewRow();
                row[0] = node.ID;
                row[1] = node.Xcoord;
                row[2] = node.Ycoord;
                _dataNodeTable.Rows.Add(row);
            }
        }
        private void AddElementsDataRows()
        {
            DataRow row;
            _dataTrussElementsTable.Rows.Clear();
            foreach (TrussElement elemnent in _TrussElementsList)
            {
                row = _dataTrussElementsTable.NewRow();
                row[0] = elemnent.StartNodeID;
                row[1] = elemnent.EndNodeID;
                row[2] = elemnent.L;
                row[3] = elemnent.Theta;
                _dataTrussElementsTable.Rows.Add(row);
            }
        }

        private void SetNodeTableColumns()
        {
            _dataNodeTable = new DataTable();
            _dataNodeTable.Columns.Add("NodeID", typeof(int));
            _dataNodeTable.Columns.Add("Xcoord", typeof(double)); ;
            _dataNodeTable.Columns.Add("Ycoord", typeof(double));
            gcNodes.DataSource = _dataNodeTable;
        }

        private void SetElementsTableColumns()
        {
            _dataTrussElementsTable = new DataTable();
            _dataTrussElementsTable.Columns.Add("Start NodeID", typeof(int));
            _dataTrussElementsTable.Columns.Add("End NodeID", typeof(int));
            //_dataTrussElementsTable.Columns.Add("Start Node Xcoord", typeof(double)); 
            //_dataTrussElementsTable.Columns.Add("Start Node Ycoord", typeof(double));
            //_dataTrussElementsTable.Columns.Add("End Node Xcoord", typeof(double)); 
            //_dataTrussElementsTable.Columns.Add("End Node Ycoord", typeof(double)); 
            _dataTrussElementsTable.Columns.Add("Length", typeof(double)); 
            _dataTrussElementsTable.Columns.Add("Angle", typeof(double)); 
            gcTrussElements.DataSource = _dataTrussElementsTable;
        }


        #endregion

        #region Events

        private void BtnAddNode_Click(object sender, EventArgs e)
        {
            var Xcoord = Convert.ToDouble(txtNodeX.Text);
            var Ycoord = Convert.ToDouble(txtNodeY.Text);
            _nodesList.Add(new NodesInfo(Xcoord, Ycoord, ++_nodeCount));
            AddNodesDataRows();

        }

        private void BtnAdd_Click(object sender, EventArgs e)

        {






            //NodesInfo node1 = new NodesInfo(0, 0, 1);
            //NodesInfo node2 = new NodesInfo(3, 0, 2);
            //NodesInfo node3 = new NodesInfo(0, 4, 3);
            //List<NodesInfo> listOfNodes = new List<NodesInfo>
            //{
            //    node1,
            //    node2,
            //    node3
            //};
            List<RestrainedNodes> restrainedNodes = new List<RestrainedNodes> {
                new RestrainedNodes(1,eRestrainedDir.XYDirection),
                new RestrainedNodes(3,eRestrainedDir.XYDirection),
                };

            List<PointLoad> loadList = new List<PointLoad>();
            PointLoad Load = new PointLoad(2, new Load(0, -150000));
            loadList.Add(Load);

            //List<TrussElement> trussMemberList = new List<TrussElement>();
            //TrussElement element1 = new TrussElement(0, 0, 3, 0, 1, 2, 1, 1);
            //trussMemberList.Add(element1);
            //TrussElement element2 = new TrussElement(3, 0, 0, 4, 2, 3, 1, 1);
            //trussMemberList.Add(element2);

            Assembler assembler = new Assembler(_TrussElementsList, loadList, restrainedNodes, _nodesList.Count);
        }

        #endregion

    }
}
