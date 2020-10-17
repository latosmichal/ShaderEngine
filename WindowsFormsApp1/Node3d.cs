using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Node3d
    {
        public double x, y, z, d;

        public Node3d(double x, double y, double z, double d = 1)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.d = d;
        }
        

        public void RotateX(Node3d axis, double alpha)
        {
            double ty = y - axis.y;
            double tz = z - axis.z;
            double tempY = ty * Math.Cos(alpha) - tz * Math.Sin(alpha);
            tz = ty * Math.Sin(alpha) + tz * Math.Cos(alpha);
            tempY += axis.y;
            tz += axis.z;
            y = tempY;
            z = tz;
        }
        public void RotateY(Node3d axis, double alpha)
        {
            double tx = x - axis.x;
            double tz = z - axis.z;
            double tempX = tx * Math.Cos(alpha) - tz * Math.Sin(alpha);
            tz = tx * Math.Sin(alpha) + tz * Math.Cos(alpha);
            tempX += axis.x;
            tz += axis.z;
            x = tempX;
            z = tz;
        }
        public void RotateZ(Node3d axis, double alpha)
        {
            double tx = x - axis.x;
            double ty = y - axis.y;
            double tempX = tx * Math.Cos(alpha) - ty * Math.Sin(alpha);
            ty = tx * Math.Sin(alpha) + ty * Math.Cos(alpha);
            tempX += axis.x;
            ty += axis.y;
            x = tempX;
            y = ty;
        }
        public void MoveUpDown(int s)
        {
            y += s;
        }
        public void MoveLeftRight(int s)
        {
            x += s;
        }
        public void ScaleUp(double s)
        {
            x *= s;
            y *= s;
            z *= s;
        }

        public override string ToString()
        {
            return "X: " + x + ", Y: " + y + ", Z: " + z;
        }
    }
}
