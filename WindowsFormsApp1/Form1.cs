using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Node3d central = new Node3d(200, 200, 200);
        public Node3d light = new Node3d(300, 300, 200);
        public Triangle[] triangles;
        public Node3d[] nodesAll;
        Bitmap bp;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bp = new Bitmap(pSpace.Width, pSpace.Height);
            nodesAll = Utility.GetNodes();
            triangles = Utility.GetTriangles(nodesAll);
            pSpace.Image = bp;            
            Drawing();
        }
        private void Clear(Bitmap bp)
        {
            for (int i = 0; i < bp.Width; i++)
            {
                for (int j = 0; j < bp.Height; j++)
                {
                    bp.SetPixel(i, j, Color.Black);
                }
            }
        }
        private void Drawing()
        {
            Clear(bp);
            double[] sz = new double[triangles.Length];
            for (int i = 0; i < triangles.Length; i++)
            {
                sz[i] = 0;
                for (int j = 0; j < 3; j++)
                {
                    sz[i] += triangles[i].nodes[j].z;
                }
                sz[i] /= 3;
            }            
            Array.Sort(sz, triangles);
            foreach (var item in sz)
            {
                Console.WriteLine(item);
            }
            //Array.Reverse(triangles);
            for (int i = 0; i < triangles.Length; i++)
            {
                triangles[i].UpCenter();
                triangles[i].UpNormal();
                triangles[i].PrintTriangle(bp,light);
            }
            pSpace.Image = bp;
        }

        private void BRotateX_Click(object sender, EventArgs e)
        {
            foreach (var item in nodesAll)
            {
                item.RotateX(central, Math.PI/12);
            }
            Drawing();            
        }

        private void BRotateY_Click(object sender, EventArgs e)
        {
            foreach (var item in nodesAll)
            {
                item.RotateY(central, Math.PI / 12);
            }
            Drawing();
        }

        private void BRotateZ_Click(object sender, EventArgs e)
        {
            foreach (var item in nodesAll)
            {
                item.RotateZ(central, Math.PI / 12);
            }
            Drawing();
        }

        private void BUp_Click(object sender, EventArgs e)
        {
            foreach (var item in nodesAll)
            {
                item.MoveUpDown(-10);
            }
            Drawing();
        }

        private void BDown_Click(object sender, EventArgs e)
        {
            foreach (var item in nodesAll)
            {
                item.MoveUpDown(10);
            }
            Drawing();
        }

        private void BLeft_Click(object sender, EventArgs e)
        {
            foreach (var item in nodesAll)
            {
                item.MoveLeftRight(-10);
            }
            Drawing();
        }

        private void BRight_Click(object sender, EventArgs e)
        {
            foreach (var item in nodesAll)
            {
                item.MoveLeftRight(10);
            }
            Drawing();
        }

        private void BScaleUp_Click(object sender, EventArgs e)
        {
            foreach (var item in nodesAll)
            {
                item.ScaleUp(1.05);
                item.MoveLeftRight(-10);
                item.MoveUpDown(-10);
            }
            Drawing();
        }

        private void BScaleDown_Click(object sender, EventArgs e)
        {
            foreach (var item in nodesAll)
            {
                item.ScaleUp(0.95);
                item.MoveLeftRight(10);
                item.MoveUpDown(10);
            }
            Drawing();
        }

        private void BLight_Click(object sender, EventArgs e)
        {
            if (light.x != 300)
            {
                light.x = 300;
                light.y = 200;
                light.z = 350;
            }
            else
            {
                light.x = 400;
                light.y = 400;
                light.z = 100;
            }
            Drawing();
    }
    }
}
