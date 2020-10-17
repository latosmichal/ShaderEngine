using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Utility
    {
        public static int n = 50; //ilosc wierzchkolkow
        public static Node3d[] GetNodes()
        {
            double central = 200;
            Node3d[] nodes = new Node3d[n];
            double r = 200, y = 350;
            double j = 2 * Math.PI / (nodes.Length - 1);//ilosc wierzchoklkow w podstawie
            for (int i = 0; i < nodes.Length-1; i++) //-1 ponieważ nie biore ostatniego wierzcholka bedacego szczytem
            {               
                nodes[i] = new Node3d(r * Math.Sin(i * j) + central, y, r * Math.Cos(i * j)+central);
                Console.WriteLine(r * Math.Cos(i * j) + central);
            }
            nodes[nodes.Length - 1] = new Node3d(central, 100, central);

            return nodes;
        }
        public static Triangle[] GetTriangles(Node3d[] nodes)
        {
            Triangle[] triangles = new Triangle[n - 1];
            for (int i = 0; i < triangles.Length-1; i++)
            {
                triangles[i] = new Triangle(nodes[i], nodes[i + 1], nodes[nodes.Length - 1]);
                Console.WriteLine(triangles[i].ToString());
            }
            triangles[triangles.Length - 1] = new Triangle(nodes[nodes.Length - 2], nodes[0], nodes[nodes.Length - 1]);
            return triangles;

        }
        
    }
}
