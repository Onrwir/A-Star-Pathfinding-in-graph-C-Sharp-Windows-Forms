using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_star_pathfinding
{
    class Vertex
    {
        public string name;
        public int x, y;
        public double gScore, fScore, hScore;
        public Vertex parent;
        public List<Edge> possibleRoutes = new List<Edge>();


        public Vertex(string name, int x, int y)
        {
            this.name = name;
            this.x = x;
            this.y = y;
        }
    }
}
