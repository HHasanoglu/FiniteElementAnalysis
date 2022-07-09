
namespace SSH
{
    partial class SSHMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribPgTrussSolver = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.txtStiffness = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSectionArea = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtYNodeI = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtXNodeI = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtYNodeJ = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtXNodeJ = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gcTrussElements = new DevExpress.XtraGrid.GridControl();
            this.gvTrussElements = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnAddNode = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.NodeY = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.NodeX = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.gcNodes = new DevExpress.XtraGrid.GridControl();
            this.gvNodes = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcTrussElements)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTrussElements)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcNodes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNodes)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.barButtonItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 2;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribPgTrussSolver,
            this.ribbonPage2});
            this.ribbonControl1.Size = new System.Drawing.Size(1081, 158);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // ribPgTrussSolver
            // 
            this.ribPgTrussSolver.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribPgTrussSolver.Name = "ribPgTrussSolver";
            this.ribPgTrussSolver.Text = "Truss Solver";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // txtStiffness
            // 
            this.txtStiffness.Location = new System.Drawing.Point(43, 47);
            this.txtStiffness.Name = "txtStiffness";
            this.txtStiffness.Size = new System.Drawing.Size(85, 21);
            this.txtStiffness.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "E";
            // 
            // txtSectionArea
            // 
            this.txtSectionArea.Location = new System.Drawing.Point(43, 81);
            this.txtSectionArea.Name = "txtSectionArea";
            this.txtSectionArea.Size = new System.Drawing.Size(85, 21);
            this.txtSectionArea.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "L";
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(43, 115);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(85, 21);
            this.txtLength.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtYNodeI);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtXNodeI);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(148, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 89);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Node I";
            // 
            // txtYNodeI
            // 
            this.txtYNodeI.Location = new System.Drawing.Point(58, 47);
            this.txtYNodeI.Name = "txtYNodeI";
            this.txtYNodeI.Size = new System.Drawing.Size(85, 21);
            this.txtYNodeI.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Ycoord";
            // 
            // txtXNodeI
            // 
            this.txtXNodeI.Location = new System.Drawing.Point(58, 20);
            this.txtXNodeI.Name = "txtXNodeI";
            this.txtXNodeI.Size = new System.Drawing.Size(85, 21);
            this.txtXNodeI.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Xcoord";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtYNodeJ);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtXNodeJ);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(341, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(173, 89);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Node J";
            // 
            // txtYNodeJ
            // 
            this.txtYNodeJ.Location = new System.Drawing.Point(58, 47);
            this.txtYNodeJ.Name = "txtYNodeJ";
            this.txtYNodeJ.Size = new System.Drawing.Size(85, 21);
            this.txtYNodeJ.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ycoord";
            // 
            // txtXNodeJ
            // 
            this.txtXNodeJ.Location = new System.Drawing.Point(58, 20);
            this.txtXNodeJ.Name = "txtXNodeJ";
            this.txtXNodeJ.Size = new System.Drawing.Size(85, 21);
            this.txtXNodeJ.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Xcoord";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(558, 70);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 49);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // gcTrussElements
            // 
            this.gcTrussElements.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gcTrussElements.Location = new System.Drawing.Point(21, 159);
            this.gcTrussElements.MainView = this.gvTrussElements;
            this.gcTrussElements.MenuManager = this.ribbonControl1;
            this.gcTrussElements.Name = "gcTrussElements";
            this.gcTrussElements.Size = new System.Drawing.Size(493, 136);
            this.gcTrussElements.TabIndex = 17;
            this.gcTrussElements.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTrussElements});
            // 
            // gvTrussElements
            // 
            this.gvTrussElements.GridControl = this.gcTrussElements;
            this.gvTrussElements.Name = "gvTrussElements";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.txtStiffness);
            this.groupBox3.Controls.Add(this.gcTrussElements);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.txtSectionArea);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.txtLength);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(0, 401);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(714, 284);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.gcNodes);
            this.groupBox4.Controls.Add(this.btnAddNode);
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Location = new System.Drawing.Point(0, 164);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(714, 231);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // btnAddNode
            // 
            this.btnAddNode.Location = new System.Drawing.Point(235, 61);
            this.btnAddNode.Name = "btnAddNode";
            this.btnAddNode.Size = new System.Drawing.Size(86, 49);
            this.btnAddNode.TabIndex = 16;
            this.btnAddNode.Text = "Add Node";
            this.btnAddNode.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.NodeY);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.NodeX);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Location = new System.Drawing.Point(16, 29);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(213, 89);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Nodes Input";
            // 
            // NodeY
            // 
            this.NodeY.Location = new System.Drawing.Point(58, 47);
            this.NodeY.Name = "NodeY";
            this.NodeY.Size = new System.Drawing.Size(85, 21);
            this.NodeY.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 50);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Ycoord";
            // 
            // NodeX
            // 
            this.NodeX.Location = new System.Drawing.Point(58, 20);
            this.NodeX.Name = "NodeX";
            this.NodeX.Size = new System.Drawing.Size(85, 21);
            this.NodeX.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "Xcoord";
            // 
            // gcNodes
            // 
            this.gcNodes.Location = new System.Drawing.Point(339, 20);
            this.gcNodes.MainView = this.gvNodes;
            this.gcNodes.MenuManager = this.ribbonControl1;
            this.gcNodes.Name = "gcNodes";
            this.gcNodes.Size = new System.Drawing.Size(367, 196);
            this.gcNodes.TabIndex = 17;
            this.gcNodes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvNodes});
            // 
            // gvNodes
            // 
            this.gvNodes.GridControl = this.gcNodes;
            this.gvNodes.Name = "gvNodes";
            // 
            // SSHMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 697);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "SSHMain";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcTrussElements)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTrussElements)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcNodes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNodes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribPgTrussSolver;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private System.Windows.Forms.TextBox txtStiffness;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSectionArea;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtYNodeI;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtXNodeI;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtYNodeJ;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtXNodeJ;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAdd;
        private DevExpress.XtraGrid.GridControl gcTrussElements;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTrussElements;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnAddNode;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox NodeY;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox NodeX;
        private System.Windows.Forms.Label label13;
        private DevExpress.XtraGrid.GridControl gcNodes;
        private DevExpress.XtraGrid.Views.Grid.GridView gvNodes;
    }
}

