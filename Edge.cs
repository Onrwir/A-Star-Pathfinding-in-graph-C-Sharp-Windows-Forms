using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_star_pathfinding
{
    class Edge
    {
        public Vertex start, end;
        public int cost;


        public Edge(Vertex startVertex, Vertex endVertex, int cost)
        {
            start = startVertex;
            end = endVertex;
            this.cost = cost;
        }
    }
}
