using A_star_pathfinding;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Astar_search_algorithm
{
    class Graph
    {
        public List<Vertex> vertices;
        public List<Edge> edges;

        public Graph()
        {
            vertices = new List<Vertex>();
            edges = new List<Edge>();
        }
        public void addEdge(string startVertex, string endVertex, int cost)
        {
            Edge newEdge = new Edge(vertices.Find(p => p.name == startVertex), vertices.Find(p => p.name == endVertex), cost);

            // Checking if added edge already exists
            if (edges.Contains(newEdge))
            {
                Console.WriteLine("Edge [" + newEdge.start.name + ", " + newEdge.end.name + ", " + newEdge.cost + "] exists");
            }
            else
            {
                edges.Add(newEdge);
                vertices.Find(p => p.name == startVertex).possibleRoutes.Add(newEdge); // Adding possible routes from vertex

            }


        }

        public void addEdge(Edge edge)
        {
            Edge newEdge = edge;

            // Checking if added edge already exists
            if (edges.Contains(newEdge))
            {
                Console.WriteLine("Edge [" + newEdge.start.name + ", " + newEdge.end.name + ", " + newEdge.cost + "] exists");
            }
            else
            {
                edges.Add(newEdge);
                vertices.Find(p => p.name == edge.start.name).possibleRoutes.Add(newEdge); // Adding possible routes from vertex

            }


        }



        public void addVertex(string name, int x, int y)
        {


            Vertex newVertex = new Vertex(name, x, y);

            // Checking if added vertex already exists
            if (vertices.Contains(newVertex) || vertices.Any(p => p.name == newVertex.name))
            {
                Console.WriteLine("Vertex [" + newVertex.name + ", " + newVertex.x + ", " + newVertex.y + "] exists");
            }
            else
            {
                vertices.Add(newVertex);
            }

        }


        public List<Vertex> A_star_search(Vertex start, Vertex end)
        {

            List<Vertex> openSet = new List<Vertex>();
            HashSet<Vertex> closedSet = new HashSet<Vertex>();

            // Adding start vertex to the open set
            openSet.Add(start);

            while (openSet.Count > 0)
            {
                // Finding the vertex with the lowest fScore in the open set
                Vertex currentVertex = openSet[0];
                for (int i = 1; i < openSet.Count; i++)
                {
                    
                    if (openSet[i].fScore < currentVertex.fScore || openSet[i].fScore == currentVertex.fScore && openSet[i].hScore < currentVertex.hScore)
                    {
                        currentVertex = openSet[i];
                    }
                }

                openSet.Remove(currentVertex);
                closedSet.Add(currentVertex);

                // Checking if the current vertex is the destination
                if (currentVertex == end)
                {
                    return RetracePath(start, end);
                }

                // Checking each possible route from the current vertex
                foreach (Edge edge in currentVertex.possibleRoutes)
                {
                    Vertex neighbour = edge.end;
                    if (closedSet.Contains(neighbour))
                    {
                        continue;
                    }

                    // Calculating the cost of reaching the neighbour from the current vertex
                    double newCostToNeighbour = currentVertex.gScore + edge.cost;
                    if (newCostToNeighbour < neighbour.gScore || !openSet.Contains(neighbour))
                    {
                        // Updating the cost values and adding parent of the neighbour to the current vertex
                        neighbour.gScore = newCostToNeighbour;
                        neighbour.hScore = Heuristic(neighbour, end);
                        neighbour.fScore = neighbour.gScore + neighbour.hScore;
                        neighbour.parent = currentVertex;

                        // Adding the neighbour to the open set if it's not already there
                        if (!openSet.Contains(neighbour))
                            openSet.Add(neighbour);
                    }
                }

            }
            // Returnig null if path was't found
            return null;
        }

        private static double Heuristic(Vertex a, Vertex b)
        {
            // Calculating euclidean distance
            double odleglosc = Math.Sqrt(Math.Pow(b.x - a.x, 2) + Math.Pow(b.y - a.y, 2));
            return odleglosc;
        }
        private List<Vertex> RetracePath(Vertex start, Vertex end)
        {
            // Retracing path from end to start using parent
            List<Vertex> path = new List<Vertex>();
            Vertex currentVertex = end;

            while (currentVertex != start)
            {
                path.Add(currentVertex);
                currentVertex = currentVertex.parent;
            }

            // Reversing the list to get the path from start to end
            path.Reverse();

            // Returning the retraced path
            return path;
        }
    }
}