using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Triangle
    {
        public Node3d[] nodes = new Node3d[3];
        public Node3d normal;
        public Node3d center;        

        public Triangle(Node3d p1, Node3d p2, Node3d p3)
        {
            this.nodes[0] = p1;
            this.nodes[1] = p2;
            this.nodes[2] = p3;
            UpCenter();
            UpNormal();
        }
        public void PrintTriangle(Bitmap bp, Node3d light)
        {            
            double[] sy = new double[3];
            for (int i = 0; i < 3; i++)
            {
                sy[i] = nodes[i].y;
            }
            Array.Sort(sy, nodes);

            double x;
            int l = (int)CalculateLight(light);
            for (double y = sy[0]; y < sy[2]; y++)
            {
                x = nodes[0].x + (nodes[2].x - nodes[0].x) * ((nodes[0].y - y) / (nodes[0].y - nodes[2].y));

                Pen blackPen = new Pen(Color.FromArgb(l,l,l), 3);
                // Draw line to screen.
                using (var graphics = Graphics.FromImage(bp))
                {
                    graphics.DrawLine(blackPen, (float)x,(float)y,(float)nodes[1].x,(float)nodes[1].y);
                }

            }
        }
        public double CalculateLight(Node3d sloneczko)
        {
            Node3d lightV = new Node3d(sloneczko.x - center.x, sloneczko.y - center.y, sloneczko.z - center.z);            
            double length = Math.Sqrt(lightV.x * lightV.x + lightV.y * lightV.y + lightV.z * lightV.z);
            lightV = new Node3d(lightV.x / length, lightV.y / length, lightV.z / length);
            double kd = 0.8;
            double lambert = Math.Abs(kd * 255 * (lightV.x * normal.x + lightV.y * normal.y + lightV.z * normal.z));
            return lambert;
        }
        public void UpNormal()
        {
            Node3d v1 = new Node3d(nodes[2].x - nodes[0].x, nodes[2].y - nodes[0].y, nodes[2].z - nodes[0].z);
            Node3d v2 = new Node3d(nodes[2].x - nodes[1].x, nodes[2].y - nodes[1].y, nodes[2].z - nodes[1].z);
            normal = new Node3d(v1.y * v2.z - v1.z * v2.y, v1.z * v2.x - v1.x * v2.z, v1.x * v2.y - v1.y * v2.x);
            double length = Math.Sqrt(normal.x * normal.x + normal.y * normal.y + normal.z * normal.z);
            normal = new Node3d(normal.x / length, normal.y / length, normal.z / length);
        }        
        public void UpCenter()
        {
            center = new Node3d((nodes[0].x+nodes[1].x+nodes[2].x)/3,(nodes[0].y+nodes[1].y+nodes[2].y)/3,(nodes[0].z+nodes[1].z+nodes[2].z)/3);
        }
        public override string ToString()
        {
            return this.nodes[0] + " " + this.nodes[1] + " " + this.nodes[2] + "\n";
        }

    }
}
