
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNodeI = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddElement = new System.Windows.Forms.Button();
            this.gcTrussElements = new DevExpress.XtraGrid.GridControl();
            this.gvTrussElements = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.gcNodes = new DevExpress.XtraGrid.GridControl();
            this.gvNodes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnAddNode = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtNodeY = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNodeX = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNodeJ = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcTrussElements)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTrussElements)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcNodes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNodes)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.groupBox9.SuspendLayout();
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
            this.ribbonControl1.Size = new System.Drawing.Size(1237, 158);
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
            this.txtStiffness.Location = new System.Drawing.Point(58, 29);
            this.txtStiffness.Name = "txtStiffness";
            this.txtStiffness.Size = new System.Drawing.Size(85, 21);
            this.txtStiffness.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "E";
            // 
            // txtSectionArea
            // 
            this.txtSectionArea.Location = new System.Drawing.Point(58, 56);
            this.txtSectionArea.Name = "txtSectionArea";
            this.txtSectionArea.Size = new System.Drawing.Size(85, 21);
            this.txtSectionArea.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNodeJ);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNodeI);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(205, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(183, 89);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nodes Info";
            // 
            // txtNodeI
            // 
            this.txtNodeI.Location = new System.Drawing.Point(72, 29);
            this.txtNodeI.Name = "txtNodeI";
            this.txtNodeI.Size = new System.Drawing.Size(85, 21);
            this.txtNodeI.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Node I-ID";
            // 
            // btnAddElement
            // 
            this.btnAddElement.Location = new System.Drawing.Point(406, 70);
            this.btnAddElement.Name = "btnAddElement";
            this.btnAddElement.Size = new System.Drawing.Size(86, 49);
            this.btnAddElement.TabIndex = 16;
            this.btnAddElement.Text = "Add";
            this.btnAddElement.UseVisualStyleBackColor = true;
            // 
            // gcTrussElements
            // 
            this.gcTrussElements.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gcTrussElements.Location = new System.Drawing.Point(16, 142);
            this.gcTrussElements.MainView = this.gvTrussElements;
            this.gcTrussElements.MenuManager = this.ribbonControl1;
            this.gcTrussElements.Name = "gcTrussElements";
            this.gcTrussElements.Size = new System.Drawing.Size(628, 62);
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
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.gcTrussElements);
            this.groupBox3.Controls.Add(this.btnAddElement);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Location = new System.Drawing.Point(0, 475);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(714, 210);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Elements Info";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.gcNodes);
            this.groupBox4.Controls.Add(this.btnAddNode);
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Location = new System.Drawing.Point(0, 164);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(388, 305);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Nodes Info";
            // 
            // gcNodes
            // 
            this.gcNodes.Location = new System.Drawing.Point(16, 113);
            this.gcNodes.MainView = this.gvNodes;
            this.gcNodes.MenuManager = this.ribbonControl1;
            this.gcNodes.Name = "gcNodes";
            this.gcNodes.Size = new System.Drawing.Size(305, 175);
            this.gcNodes.TabIndex = 17;
            this.gcNodes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvNodes});
            // 
            // gvNodes
            // 
            this.gvNodes.GridControl = this.gcNodes;
            this.gvNodes.Name = "gvNodes";
            // 
            // btnAddNode
            // 
            this.btnAddNode.Location = new System.Drawing.Point(235, 48);
            this.btnAddNode.Name = "btnAddNode";
            this.btnAddNode.Size = new System.Drawing.Size(86, 49);
            this.btnAddNode.TabIndex = 16;
            this.btnAddNode.Text = "Add Node";
            this.btnAddNode.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtNodeY);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.txtNodeX);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Location = new System.Drawing.Point(16, 29);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(213, 78);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Nodes Input";
            // 
            // txtNodeY
            // 
            this.txtNodeY.Location = new System.Drawing.Point(58, 47);
            this.txtNodeY.Name = "txtNodeY";
            this.txtNodeY.Size = new System.Drawing.Size(85, 21);
            this.txtNodeY.TabIndex = 14;
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
            // txtNodeX
            // 
            this.txtNodeX.Location = new System.Drawing.Point(58, 20);
            this.txtNodeX.Name = "txtNodeX";
            this.txtNodeX.Size = new System.Drawing.Size(85, 21);
            this.txtNodeX.TabIndex = 12;
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
            // txtNodeJ
            // 
            this.txtNodeJ.Location = new System.Drawing.Point(72, 56);
            this.txtNodeJ.Name = "txtNodeJ";
            this.txtNodeJ.Size = new System.Drawing.Size(85, 21);
            this.txtNodeJ.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Node J-ID";
            // 
            // groupBox2
            // 
            this.groupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
            this.groupBox2.Controls.Add(this.txtStiffness);
            this.groupBox2.Controls.Add(this.txtSectionArea);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(16, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(171, 89);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Section Info";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.gridControl1);
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.groupBox7);
            this.groupBox5.Location = new System.Drawing.Point(394, 164);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(388, 305);
            this.groupBox5.TabIndex = 20;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Loading Info";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(16, 113);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbonControl1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(305, 175);
            this.gridControl1.TabIndex = 17;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(235, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 49);
            this.button1.TabIndex = 16;
            this.button1.Text = "Add Node";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.textBox1);
            this.groupBox7.Controls.Add(this.label3);
            this.groupBox7.Controls.Add(this.textBox2);
            this.groupBox7.Controls.Add(this.label6);
            this.groupBox7.Location = new System.Drawing.Point(16, 29);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(213, 78);
            this.groupBox7.TabIndex = 12;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Nodes Input";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(58, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(85, 21);
            this.textBox1.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ycoord";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(58, 20);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(85, 21);
            this.textBox2.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Xcoord";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.gridControl2);
            this.groupBox8.Controls.Add(this.button2);
            this.groupBox8.Controls.Add(this.groupBox9);
            this.groupBox8.Location = new System.Drawing.Point(788, 164);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(388, 305);
            this.groupBox8.TabIndex = 21;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Boundary Conditions Info";
            // 
            // gridControl2
            // 
            this.gridControl2.Location = new System.Drawing.Point(16, 113);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.MenuManager = this.ribbonControl1;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(305, 175);
            this.gridControl2.TabIndex = 17;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(235, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 49);
            this.button2.TabIndex = 16;
            this.button2.Text = "Add Node";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.textBox3);
            this.groupBox9.Controls.Add(this.label7);
            this.groupBox9.Controls.Add(this.textBox4);
            this.groupBox9.Controls.Add(this.label8);
            this.groupBox9.Location = new System.Drawing.Point(16, 29);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(213, 78);
            this.groupBox9.TabIndex = 12;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Nodes Input";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(58, 47);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(85, 21);
            this.textBox3.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Ycoord";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(58, 20);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(85, 21);
            this.textBox4.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Xcoord";
            // 
            // SSHMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 697);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "SSHMain";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcTrussElements)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTrussElements)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcNodes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNodes)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNodeI;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddElement;
        private DevExpress.XtraGrid.GridControl gcTrussElements;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTrussElements;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnAddNode;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtNodeY;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNodeX;
        private System.Windows.Forms.Label label13;
        private DevExpress.XtraGrid.GridControl gcNodes;
        private DevExpress.XtraGrid.Views.Grid.GridView gvNodes;
        private System.Windows.Forms.TextBox txtNodeJ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox8;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label8;
    }
}

