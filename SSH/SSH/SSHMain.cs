using DevExpress.XtraCharts;
using SSH.TrussSolver;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

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
            _restrainedNodes = new List<RestrainedNode>();
            _nodalForces = new List<PointLoad>();
            prepareUI();
            SetNodeTableColumns();
            SetElementsTableColumns();
            SetBCTableColumns();
            SetLoadTableColumns();
            EditNodeTableGridView();
            EditElementsTableGridView();
            EditBCTableGridView();
            EditLoadTableGridView();

        }

        private void RefreshGraphics()
        {
            Pen pen = new Pen(new SolidBrush(Color.SkyBlue));
            //for (int i = 0; i < 500; i+=100)
            //{
            //}
                    _g.DrawLine(pen, new Point(0, 100), new Point(1000, 100));
                    _g.DrawLine(pen, new Point(0, 0), new Point(1000, 200));
                    _g.DrawLine(pen, new Point(0, 150), new Point(1000, 300));
        }

        private void prepareUI()
        {
            cmbSupportType.Items.Add(eRestrainedDir.X);
            cmbSupportType.Items.Add(eRestrainedDir.Y);
            cmbSupportType.Items.Add(eRestrainedDir.XY);
            // Add a title to the chart (if necessary).
            //chElements.Titles.Add(new ChartTitle());
            //chElements.Titles[0].Text = "A Line Chart";
            //drawingControl.OptionsView.ShowRulers = false;
            //drawingControl.OptionsView.ShowPageBreaks = false;
            //drawingControl.OptionsView.ShowGrid= false;
        }

        #endregion

        #region Private Fields

        private List<NodesInfo> _nodesList;
        private List<TrussElement> _TrussElementsList;
        private int _nodeCount;
        private DataTable _dataNodeTable;
        private DataTable _dataTrussElementsTable;
        private DataTable _dataBoundaryConditionsTable;
        private DataTable _dataLoadTable;
        private List<RestrainedNode> _restrainedNodes;
        private List<PointLoad> _nodalForces;
        private Graphics _g;

        #endregion

        #region Private Methods
        private void SubscribeToEvents()
        {
            btnAddNode.Click += BtnAddNode_Click;
            btnAddElement.Click += BtnAddElement_Click;
            btnAddLoad.Click += BtnAddLoad_Click;
            btnAddRestrain.Click += BtnAddRestrain_Click;
            btnSolveTruss.Click += BtnSolveTruss_Click;
        }



        private void BtnSolveTruss_Click(object sender, EventArgs e)
        {
            Assembler assembler = new Assembler(_TrussElementsList, _nodalForces, _restrainedNodes, _nodesList.Count);
        }

        private void BtnAddRestrain_Click(object sender, EventArgs e)
        {
            eRestrainedDir restraniedType = (eRestrainedDir)cmbSupportType.SelectedIndex;
            int Id = Convert.ToInt32(txtBCNodeId.Text);
            _restrainedNodes.Add(new RestrainedNode(Id, restraniedType));
            AddRestrainedDataRows();
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

        private void EditBCTableGridView()
        {
            gvBoundaryConditions.OptionsView.ShowGroupPanel = false;
            gvBoundaryConditions.OptionsCustomization.AllowColumnMoving = false;
            gvBoundaryConditions.OptionsCustomization.AllowFilter = false;
            gvBoundaryConditions.OptionsMenu.EnableColumnMenu = false;
            gvBoundaryConditions.OptionsView.ShowIndicator = false;
            gvBoundaryConditions.OptionsView.AllowHtmlDrawHeaders = true;
            gvBoundaryConditions.OptionsView.ColumnAutoWidth = true;
            gvBoundaryConditions.Columns[0].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            gvBoundaryConditions.Columns[1].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gvBoundaryConditions.Columns[0].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            gvBoundaryConditions.Columns[1].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
        }

        private void EditLoadTableGridView()
        {
            gvLoads.OptionsView.ShowGroupPanel = false;
            gvLoads.OptionsCustomization.AllowColumnMoving = false;
            gvLoads.OptionsCustomization.AllowFilter = false;
            gvLoads.OptionsMenu.EnableColumnMenu = false;
            gvLoads.OptionsView.ShowIndicator = false;
            gvLoads.OptionsView.AllowHtmlDrawHeaders = true;
            gvLoads.OptionsView.ColumnAutoWidth = true;
            gvLoads.Columns[0].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            gvLoads.Columns[1].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gvLoads.Columns[0].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            gvLoads.Columns[1].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
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

        private void AddLoadsDataRows()
        {
            DataRow row;
            _dataLoadTable.Rows.Clear();
            foreach (PointLoad force in _nodalForces)
            {
                row = _dataLoadTable.NewRow();
                row[0] = force.NodeID;
                row[1] = force.Load.XComponent;
                row[2] = force.Load.YComponent;
                _dataLoadTable.Rows.Add(row);
            }
        }
        private void AddRestrainedDataRows()
        {
            DataRow row;
            _dataBoundaryConditionsTable.Rows.Clear();
            foreach (RestrainedNode restrain in _restrainedNodes)
            {
                row = _dataBoundaryConditionsTable.NewRow();
                row[0] = restrain.NodeID;
                row[1] = restrain.Direction;
                _dataBoundaryConditionsTable.Rows.Add(row);
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
            _dataTrussElementsTable.Columns.Add("Length", typeof(double)); 
            _dataTrussElementsTable.Columns.Add("Angle", typeof(double)); 
            gcTrussElements.DataSource = _dataTrussElementsTable;
        }
        private void SetBCTableColumns()
        {
            _dataBoundaryConditionsTable = new DataTable();
            _dataBoundaryConditionsTable.Columns.Add(" Node ID", typeof(int));
            _dataBoundaryConditionsTable.Columns.Add("Restrained Direction", typeof(eRestrainedDir));
            gcBoundaryConditions.DataSource = _dataBoundaryConditionsTable;
        }

        private void SetLoadTableColumns()
        {
            _dataLoadTable = new DataTable();
            _dataLoadTable.Columns.Add(" Node ID", typeof(int));
            _dataLoadTable.Columns.Add("X Component", typeof(double));
            _dataLoadTable.Columns.Add("Y Component", typeof(double));
            gcLoads.DataSource = _dataLoadTable;
        }

        #endregion

        #region Events

        private void BtnAddNode_Click(object sender, EventArgs e)
        {
            var Xcoord = Convert.ToDouble(txtNodeX.Text);
            var Ycoord = Convert.ToDouble(txtNodeY.Text);
            _nodesList.Add(new NodesInfo(Xcoord, Ycoord, ++_nodeCount));
            AddNodesDataRows();
            drawChart();
            //RefreshGraphics();
            //drawingControl.Refresh();
        }

        private void BtnAddLoad_Click(object sender, EventArgs e)
        {
            int node = Convert.ToInt32(txtNodeIdLoading.Text);
            double xComponent = Convert.ToDouble(txtXComponent.Text);
            double YComponent = Convert.ToDouble(txtYComponent.Text);
            _nodalForces.Add(new PointLoad(node, new Load(xComponent, YComponent)));
            AddLoadsDataRows();

        }

        private void drawChart()
        {

            // Create a line series.
            Series series1 = new Series("Series 1", ViewType.Line);

            // Add points to it.

            foreach (NodesInfo nodes in _nodesList)
            {
            series1.Points.Add(new SeriesPoint(nodes.Xcoord, nodes.Ycoord)); 

            }

            // Add the series to the chart.
            chartDrawing.Series.Add(series1);
            XYDiagram diagram = (XYDiagram)chartDrawing.Diagram;
            diagram.AxisY.WholeRange.MinValue = -1;
            diagram.AxisY.WholeRange.MaxValue = 5;

            // Set the numerical argument scale types for the series,
            // as it is qualitative, by default.
            series1.ArgumentScaleType = ScaleType.Numerical;

            // Access the view-type-specific options of the series.
            ((LineSeriesView)series1.View).MarkerVisibility = DevExpress.Utils.DefaultBoolean.True;
            ((LineSeriesView)series1.View).LineMarkerOptions.Kind = MarkerKind.Circle;

            // Access the type-specific options of the diagram.
            ((XYDiagram)chartDrawing.Diagram).EnableAxisXZooming = true;

            // Hide the legend (if necessary).
            chartDrawing.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;

            this.Controls.Add(chartDrawing);
        }


        #endregion
    }
}
