using devDept.Eyeshot;
using devDept.Eyeshot.Entities;
using devDept.Eyeshot.Labels;
using devDept.Geometry;
using devDept.Graphics;
using MathNet.Numerics.LinearAlgebra;
using SSH.TrussSolver;
using System;
using System.Collections.Generic;
using System.Drawing;

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
        //protected override void OnLoad(EventArgs e)
        //{
        //    design1.ActiveViewport.AutoHideLabels = true;

        //    design1.ActiveViewport.Grid.AutoSize = true;
        //    design1.ActiveViewport.Grid.Step = 100;

        //    string concreteMatName = "Concrete";
        //    string steelMatName = "Blue steel";

        //    design1.Materials.Add(new Material(concreteMatName, Color.FromArgb(25, 25, 25), Color.LightGray, Color.FromArgb(31, 31, 31), .05f, 0));
        //    design1.Materials.Add(new Material(steelMatName, Color.RoyalBlue));

        //    // square column block
        //    Block b = new Block("squareCol");

        //    // creates a gray box
        //    Mesh m1 = Mesh.CreateBox(30, 30, 270);

        //    m1.ColorMethod = colorMethodType.byEntity;
        //    m1.Color = Color.Gray;
        //    m1.MaterialName = concreteMatName;

        //    // adds it to the block
        //    b.Entities.Add(m1);

        //    // creates a new black polyline
        //    LinearPath steel = new LinearPath();

        //    steel.Vertices = new Point3D[8];
        //    steel.Vertices[0] = new Point3D(4, 4, -20);
        //    steel.Vertices[1] = new Point3D(4, 4, 290);
        //    steel.Vertices[2] = new Point3D(4, 26, 290);
        //    steel.Vertices[3] = new Point3D(4, 26, -20);
        //    steel.Vertices[4] = new Point3D(26, 26, -20);
        //    steel.Vertices[5] = new Point3D(26, 26, 290);
        //    steel.Vertices[6] = new Point3D(26, 4, 290);
        //    steel.Vertices[7] = new Point3D(26, 4, -20);

        //    steel.ColorMethod = colorMethodType.byEntity;
        //    steel.Color = Color.Black;

        //    // adds it to the block
        //    b.Entities.Add(steel);

        //    // creates a price tag
        //    devDept.Eyeshot.Entities.Attribute at = new devDept.Eyeshot.Entities.Attribute(new Point3D(0, -15), "Price", "$25,000", 10);

        //    // adds it to the block
        //    b.Entities.Add(at);

        //    // adds the block to the master block dictionary
        //    design1.Blocks.Add(b);

        //    // inserts the "SquareCol" block many times: this is a HUGE memory and graphic resources saving for big models
        //    BlockReference reference;

        //    for (int k = 0; k < 4; k++)

        //        for (int j = 0; j < 5; j++)

        //            for (int i = 0; i < 5; i++)

        //                if (i < 2 && j < 2)

        //                    System.Diagnostics.Debug.WriteLine("No columns here");

        //                else
        //                {

        //                    reference = new BlockReference(i * 500, j * 400, k * 300, "squareCol", 1, 1, 1, 0);

        //                    // defines a different price for each one
        //                    reference.Attributes.Add("Price", "$" + i + ",000");

        //                    design1.Entities.Add(reference);

        //                }

        //    // again as above
        //    b = new Block("floor");

        //    double width = 2030;
        //    double depth = 1630;
        //    double dimA = 1000;
        //    double dimB = 800;

        //    Point2D[] outerPoints = new Point2D[7];

        //    outerPoints[0] = new Point2D(0, dimB);
        //    outerPoints[1] = new Point2D(dimA, dimB);
        //    outerPoints[2] = new Point2D(dimA, 0);
        //    outerPoints[3] = new Point2D(width, 0);
        //    outerPoints[4] = new Point2D(width, depth);
        //    outerPoints[5] = new Point2D(0, depth);
        //    outerPoints[6] = (Point2D)outerPoints[0].Clone();

        //    LinearPath outer = new LinearPath(Plane.XY, outerPoints);

        //    Point2D[] innerPoints = new Point2D[5];

        //    innerPoints[0] = new Point2D(1530, 800);
        //    innerPoints[1] = new Point2D(1530, 950);
        //    innerPoints[2] = new Point2D(1650, 950);
        //    innerPoints[3] = new Point2D(1650, 800);
        //    innerPoints[4] = (Point2D)innerPoints[0].Clone();

        //    LinearPath inner = new LinearPath(Plane.XY, innerPoints);

        //    devDept.Eyeshot.Entities.Region reg = new devDept.Eyeshot.Entities.Region(outer, inner);

        //    Mesh m2 = reg.ExtrudeAsMesh(30, 0.1, devDept.Geometry.Entities.GMesh.natureType.Plain);

        //    m2.ColorMethod = colorMethodType.byEntity;
        //    m2.Color = Color.White;
        //    m2.MaterialName = concreteMatName;

        //    b.Entities.Add(m2);

        //    design1.Blocks.Add(b);

        //    for (int i = 0; i < 4; i++)
        //    {

        //        reference = new BlockReference(0, 0, 270 + i * 300, "floor", 1, 1, 1, 0);

        //        design1.Entities.Add(reference);

        //    }

        //    string brickMatName = "Wall bricks";

        //    //design1.Materials.Add(new Material(brickMatName, new Bitmap("../../../../../../dataset/Assets/Textures/Bricks.jpg")));

        //    b = new Block("brickWall");

        //    Mesh rm = Mesh.CreateBox(470, 30, 270, devDept.Geometry.Entities.GMesh.natureType.RichPlain);

        //    rm.ApplyMaterial(brickMatName, devDept.Geometry.textureMappingType.Cubic, 1.5, 1.5);

        //    rm.ColorMethod = colorMethodType.byEntity;
        //    rm.Color = Color.Chocolate;

        //    b.Entities.Add(rm);

        //    design1.Blocks.Add(b);

        //    for (int j = 1; j < 4; j++)

        //        for (int i = 0; i < 2; i++)
        //        {

        //            reference = new BlockReference(1030 + i * 500, 0, j * 300, "brickWall", 1, 1, 1, 0);

        //            design1.Entities.Add(reference);

        //        }


        //    // Cylindrical column
        //    b = new Block("CylindricalCol");

        //    Mesh m3 = Mesh.CreateCylinder(20, 270, 32, devDept.Geometry.Entities.GMesh.natureType.Smooth);

        //    m3.ColorMethod = colorMethodType.byEntity;
        //    m3.Color = Color.RoyalBlue;
        //    m3.MaterialName = steelMatName;

        //    b.Entities.Add(m3);

        //    design1.Blocks.Add(b);

        //    for (int j = 0; j < 2; j++)

        //        for (int i = 0; i < 3; i++)
        //        {

        //            reference = new BlockReference(100 + i * 400, 115 + j * 200, 0, "CylindricalCol", 1, 1, 1, 0);

        //            design1.Entities.Add(reference);

        //        }

        //    // Roof (not a block this time)
        //    Mesh roof = Mesh.CreateBox(880, 280, 30);

        //    // Edits vertices to add a slope
        //    roof.Vertices[4].Z = 15;
        //    roof.Vertices[7].Z = 15;

        //    roof.Translate(60, 75, 270);

        //    design1.Entities.Add(roof, Color.DimGray);


        //    // Labels
        //    LeaderAndText lat = new LeaderAndText(new Point3D(0, 800, 1200),
        //                          "Height = 12 m", new Font("Tahoma", 8.25f), Color.White, new Vector2D(0, 20));

        //    lat.FillColor = Color.Black;
        //    design1.ActiveViewport.Labels.Add(lat);


        //    LeaderAndText ff;

        //    ff = new LeaderAndText(new Point3D(1000, 1000, 300),
        //             "First floor", new Font("Tahoma", 8.25f), Color.White, new Vector2D(0, 10));

        //    ff.FillColor = Color.Red;
        //    ff.Alignment = ContentAlignment.BottomCenter;

        //    design1.ActiveViewport.Labels.Add(ff);

        //    // fits the model in the viewport
        //    design1.ZoomFit();

        //    base.OnLoad(e);
        //}
    }
}
