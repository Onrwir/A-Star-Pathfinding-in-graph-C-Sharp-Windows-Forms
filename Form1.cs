using A_star_pathfinding;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Astar_search_algorithm
{
    public partial class Form1 : Form
    {
        Graph graph = new Graph();
        public Form1()
        {
            InitializeComponent();
        }


        private void searchPath_Button_Click(object sender, EventArgs e)
        {
            // Checking if user selected start and end of path
            if (pathStart_cb.Text.Length == 0 || pathEnd_cb.Text.Length == 0)
            {
                MessageBox.Show("You need to select starting and ending vertex of path", "Not selected start or end of path");
                return;
            }

            foundPath_tb.Text = "";

            Vertex vertexA = graph.vertices.Find(p => p.name == pathStart_cb.Text);
            Vertex vertexB = graph.vertices.Find(p => p.name == pathEnd_cb.Text);

            List<Vertex> path = graph.A_star_search(vertexA, vertexB);



            if (path == null)
            {
                foundPath_tb.AppendText("No path has been found");
                return;
            }

            if (vertexA.name == vertexB.name)
            {
                foundPath_tb.AppendText(vertexA.name);
                DrawPoints(panel1);
                DrawEdges(panel1);
                return;
            }
            // Showing found path in text box
            foundPath_tb.AppendText(vertexA.name + "->");
            foreach (Vertex visited in path)
            {
                
                if (visited.Equals(path.Last()))
                {
                    foundPath_tb.AppendText(visited.name);
                }
                else
                {
                    foundPath_tb.AppendText(visited.name + "->");
                }

            }

            // Draw found path 
            using (Bitmap bitmap = new Bitmap(panel1.Width, panel1.Height))
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                
                DrawPoints(panel1);
                DrawEdges(panel1);
                

                int margin = panel1Margin;
                int height = panel1.Height;

                Pen penGreen = new Pen(Color.Green,2);

                // Handling negative input
                float minX = graph.vertices.Min(p => p.x);
                float minY = graph.vertices.Min(p => p.y);
                float translateX = 0;
                float translateY = 0;
                if (minX <= 0)
                {
                    translateX = Math.Abs(minX);
                }
                else if (minY <= 0)
                {
                    translateY = Math.Abs(minY);
                }
                else
                {
                    translateX = 0;
                    translateY = 0;
                }

                // Calculate scale to fit all data in panel
                float scaleX = (panel1.Width - margin * 2) / ((float)graph.vertices.Max(p => p.x) - graph.vertices.Min(p => p.x));
                float scaleY = (panel1.Height - margin * 2) / ((float)graph.vertices.Max(p => p.y) - graph.vertices.Min(p => p.y));
                float scale = Math.Min(scaleX, scaleY);

                if (new[] { scaleX, scaleY }.All(x => x == float.NegativeInfinity || x == float.PositiveInfinity))
                {
                    scale = 1;
                }

                // Calculate input data bounding box
                Tuple<float, float> pointsBoundingBoxCenter = boundingBoxCenter();
                float shiftX = ((panel1.Width / 2) - pointsBoundingBoxCenter.Item1 * scale);
                float shiftY = ((panel1.Height / 2) - pointsBoundingBoxCenter.Item2 * scale);


                foreach (Vertex visited in path)
                {

                    int startX = (int)((visited.parent.x + translateX) * scale + shiftX);
                    int startY = height - (int)((visited.parent.y + translateY) * scale + shiftY);
                    int endX = (int)((visited.x + translateX) * scale + shiftX);
                    int endY = height - (int)((visited.y + translateY) * scale + shiftY);


                    g.SmoothingMode = SmoothingMode.HighQuality;
                    g.DrawLine(penGreen, startX, startY, endX, endY);

                    float middleX = (startX + endX) / 2;
                    float middleY = (startY + endY) / 2;

                    // Calculate the angle of the line
                    float angle = (float)Math.Atan2(endY - startY, endX - startX);

                    // Length of arrowhead sides
                    int arrowLength = 10;

                    // Calculate the coordinates of the arrowhead
                    PointF arrowEnd1 = new PointF(
                        middleX - (float)(arrowLength * Math.Cos(angle + Math.PI / 4)),
                        middleY - (float)(arrowLength * Math.Sin(angle + Math.PI / 4))
                    );
                    PointF arrowEnd2 = new PointF(
                        middleX - (float)(arrowLength * Math.Cos(angle - Math.PI / 4)),
                        middleY - (float)(arrowLength * Math.Sin(angle - Math.PI / 4))
                    );

                    // Draw the arrowhead
                    g.DrawLine(penGreen, arrowEnd1, new PointF(middleX, middleY));
                    g.DrawLine(penGreen, arrowEnd2, new PointF(middleX, middleY));

                }

                using (Graphics panelGraphics = panel1.CreateGraphics())
                {
                    panelGraphics.DrawImage(bitmap, new Point(0, 0));
                }
                
            }


        }

        int panel1Margin = 20; 
         private void DrawPoints(Panel panel)
        {

            using (Bitmap bitmap = new Bitmap(panel.Width, panel.Height))

            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.Clear(panel.BackColor);

                int margin = panel1Margin;
                int height = (int)panel.Height;
                Brush brush = new SolidBrush(Color.Black);

                // Handling negative input
                float minX = graph.vertices.Min(p => p.x);
                float minY = graph.vertices.Min(p => p.y);
                float translateX = 0;
                float translateY = 0;
                if (minX <= 0)
                {
                    translateX = Math.Abs(minX);
                }
                else if (minY <= 0)
                {
                    translateY = Math.Abs(minY);
                }
                else
                {
                    translateX = 0;
                    translateY = 0;
                }

                // Calculate scale to fit all data in panel
                float scaleX = (panel.Width - margin * 2) / ((float)graph.vertices.Max(p => p.x) - graph.vertices.Min(p => p.x));
                float scaleY = (panel.Height - margin * 2) / ((float)graph.vertices.Max(p => p.y) - graph.vertices.Min(p => p.y));
                float scale = Math.Min(scaleX, scaleY);


                if (new[] {scaleX, scaleY}.All(x => x == float.NegativeInfinity || x == float.PositiveInfinity))
                {
                    scale = 1;
                }

                // Calculate input data bounding box
                Tuple<float, float> pointsBoundingBoxCenter = boundingBoxCenter();
                float shiftX = ((panel1.Width / 2) - pointsBoundingBoxCenter.Item1 * scale);
                float shiftY = ((panel1.Height / 2) - pointsBoundingBoxCenter.Item2 * scale);


                foreach (Vertex point in graph.vertices)
                {
                    int pointRadius = 3;
                    // Draw points
                    g.SmoothingMode = SmoothingMode.HighQuality;
                    Vertex newPoint = new Vertex(point.name, (int)((point.x + translateX) * scale)+ (int)(shiftX), (int)(((point.y + translateY) * scale) + (int)(shiftY)));
                    g.FillEllipse(brush, newPoint.x - pointRadius, height - newPoint.y - pointRadius, 2 * pointRadius, 2 * pointRadius);


                    // Draw points names
                    Font font = new Font("Arial", 10);
                    g.TranslateTransform(newPoint.x, height - newPoint.y);
                    g.DrawString(newPoint.name, font, brush, -20, -20);
                    g.ResetTransform();
                }

                using (Graphics panelGraphics = panel.CreateGraphics())
                {
                    panelGraphics.DrawImage(bitmap, new Point(0, 0));
                }
            }
        }
 



        private void DrawEdges(Panel panel)
        {
            using (Bitmap bitmap = new Bitmap(panel.Width, panel.Height))
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                DrawPoints(panel);

                int margin = panel1Margin;
                int height = (int)panel.Height;

                Pen penBlack = new Pen(Color.Black);
                Font font = new Font("Arial", 10);
                Brush brush = new SolidBrush(Color.Black);

                // Handling negative input
                float minX = graph.vertices.Min(p => p.x);
                float minY = graph.vertices.Min(p => p.y);
                float translateX = 0;
                float translateY = 0;
                if (minX <= 0)
                {
                    translateX = Math.Abs(minX);
                }
                else if (minY <= 0)
                {
                    translateY = Math.Abs(minY);
                }
                else
                {
                    translateX = 0;
                    translateY = 0;
                }
                // Calculate scale to fit all data in panel
                float scaleX = (panel.Width - margin * 2) / ((float)graph.vertices.Max(p => p.x) - graph.vertices.Min(p => p.x));
                float scaleY = (panel.Height - margin * 2) / ((float)graph.vertices.Max(p => p.y) - graph.vertices.Min(p => p.y));
                float scale = Math.Min(scaleX, scaleY);

                if (new[] { scaleX, scaleY }.All(x => x == float.NegativeInfinity || x == float.PositiveInfinity))
                {
                    scale = 1;
                }

                // Calculate input data bounding box
                Tuple<float, float> pointsBoundingBoxCenter = boundingBoxCenter();
                float shiftX = ((panel1.Width / 2) - pointsBoundingBoxCenter.Item1 * scale);
                float shiftY = ((panel1.Height / 2) - pointsBoundingBoxCenter.Item2 * scale);


                foreach (Edge edge in graph.edges)
                {

                    int startX = (int)((edge.start.x + translateX) * scale + shiftX);
                    int startY = height - (int)((edge.start.y + translateY) * scale + shiftY);
                    int endX = (int)((edge.end.x + translateX) * scale + shiftX);
                    int endY = height - (int)((edge.end.y + translateY) * scale + shiftY);


                    g.SmoothingMode = SmoothingMode.HighQuality;
                    g.DrawLine(penBlack, startX, startY, endX, endY);

                    float middleX = (startX + endX) / 2;
                    float middleY = (startY + endY) / 2;

                    // Calculate the angle of the line
                    float angle = (float)Math.Atan2(endY - startY, endX - startX);

                    // Length of arrowhead sides
                    int arrowLength = 10;

                    // Calculate the coordinates of the arrowhead
                    PointF arrowEnd1 = new PointF(
                        middleX - (float)(arrowLength * Math.Cos(angle + Math.PI / 4)),
                        middleY - (float)(arrowLength * Math.Sin(angle + Math.PI / 4))
                    );
                    PointF arrowEnd2 = new PointF(
                        middleX - (float)(arrowLength * Math.Cos(angle - Math.PI / 4)),
                         middleY - (float)(arrowLength * Math.Sin(angle - Math.PI / 4))
                    );

                    // Draw the arrowhead
                    g.DrawLine(penBlack, arrowEnd1, new PointF(middleX, middleY));
                    g.DrawLine(penBlack, arrowEnd2, new PointF(middleX, middleY));

                    Font fontCost = new Font("Arial", 9);
                    Brush brushCost = new SolidBrush(Color.Red);


                    g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;


                    // Checking angle of edge to always draw cost above it
                    if (Math.Abs(angle) >= Math.PI / 2 && Math.Abs(angle) <= 3 * Math.PI / 2)
                    {
                        g.TranslateTransform(middleX, middleY);
                        g.RotateTransform((float)(angle * (float)(180.0 / Math.PI)) + 180);
                        g.DrawString(edge.cost.ToString(), fontCost, brushCost, 20, -15);
                        g.ResetTransform();
                    }
                    else
                    {
                        g.TranslateTransform(middleX, middleY);
                        g.RotateTransform((float)(angle * (float)(180.0 / Math.PI)));
                        g.DrawString(edge.cost.ToString(), fontCost, brushCost, -20, -15);
                        g.ResetTransform();

                    }

                }
                
                using (Graphics panelGraphics = panel.CreateGraphics())
                {
                    panelGraphics.DrawImage(bitmap, new Point(0, 0));
                    
                }

            }
        }

        private void insertDataToComboBoxes()
        {

            // Clearing combo boxes
            edgeStart_cb.Items.Clear();
            edgeEnd_cb.Items.Clear();
            pathStart_cb.Items.Clear();
            pathEnd_cb.Items.Clear();

            // Adding vertex names to combo boxes
            foreach (Vertex point in graph.vertices)
            {
                edgeStart_cb.Items.Add(point.name);
                edgeEnd_cb.Items.Add(point.name);
                pathStart_cb.Items.Add(point.name);
                pathEnd_cb.Items.Add(point.name);
            }
        }

        private Tuple<float, float> boundingBoxCenter()
        {
            float minX = graph.vertices.Min(p => p.x);
            float maxX = graph.vertices.Max(p => p.x);
            float minY = graph.vertices.Min(p => p.y);
            float maxY = graph.vertices.Max(p => p.y);

            float tranX = 0;
            float tranY = 0;
            if (minX <= 0)
            {
                tranX = Math.Abs(minX);
            }
            else if (minY <= 0)
            {
                tranY = Math.Abs(minY);
            }
            else
            {
                tranX = 0;
                tranY = 0;
            }

            // Caclulate ceter of data bounding box
            float boundingBoxCenterX = (minX + tranX + maxX + tranX) / 2;
            float boundingBoxCenterY = (minY + tranY + maxY + tranY) / 2;


            return Tuple.Create(boundingBoxCenterX, boundingBoxCenterY);
        }

        private void addVertex_button_Click(object sender, EventArgs e)
        {
            foundPath_tb.Text = "";
            string vertexName = vertexName_tb.Text;
            if (vertexName.Length!=0)
            {
                if (graph.vertices.Any(p => p.name == vertexName) || graph.vertices.Any(p => p.x == vertexX_NUP.Value && p.y == vertexY_NUP.Value))
                {
                    MessageBox.Show("Vertex already exists, chagne name or coordinates", "Vertex Duplicate");
                }
                else
                {
                    // Adding and drawing vertex if not exists
                    Vertex newVertex = new Vertex(vertexName_tb.Text, (int)vertexX_NUP.Value, (int)vertexY_NUP.Value);
                    graph.vertices.Add(newVertex);
                    DrawPoints(panel1);
                    if (graph.edges.Count() != 0)
                    {
                        DrawEdges(panel1);
                    }

                    insertDataToComboBoxes();

                }                  

            }
            else
            {
                MessageBox.Show("Name can't be empty", "Empty box error");
            }
        }

        private void addEdge_button_Click(object sender, EventArgs e)
        {
            foundPath_tb.Text = "";
            if (edgeStart_cb.Text.Length != 0 && edgeEnd_cb.Text.Length != 0)
            {
                if (edgeStart_cb.Text == edgeEnd_cb.Text)
                {
                    MessageBox.Show("Start vertex can't be the same as end vertex", "Start same as end");
                    return;
                }
                else if (edgeCost_NUP.Value == 0)
                {
                    MessageBox.Show("Edge cost can't be equal to 0", "Empty cost");
                    return;
                }

                // Adding edge if not already exists between two verticies
                Edge newEdge = new Edge(graph.vertices.Find(p => p.name == edgeStart_cb.Text), graph.vertices.Find(p => p.name == edgeEnd_cb.Text), (int)edgeCost_NUP.Value);
                if (graph.edges.Any(edge => edge.start == newEdge.start && edge.end == newEdge.end) ||
                    graph.edges.Any(edge => edge.start == newEdge.end && edge.end == newEdge.start))
                {
                    MessageBox.Show("Edge between those vertices already exists", "Edge duplicate");
                    return;
                }
                graph.addEdge(newEdge);
                DrawEdges(panel1);
            }
            else
            {
                MessageBox.Show("Please select start and end vertex of an edge", "Start, end not selected");
            }
        }

        private void clearAllData()
        {
            // Clearing panel graphics and all data in storage
            List<ComboBox> comboBoxList = new List<ComboBox>
            {
                edgeStart_cb,
                edgeEnd_cb,
                pathStart_cb,
                pathEnd_cb
            };

            foreach(ComboBox comboBox in comboBoxList)
            {
                comboBox.Items.Clear();
                comboBox.Items.Add("");
                comboBox.Items.Clear();
                comboBox.SelectedIndex = -1;

            }

            graph.vertices.Clear();
            graph.edges.Clear();
            panel1.CreateGraphics().Clear(BackColor);
        }
        private void clearAllData_button_Click(object sender, EventArgs e)
        {
            clearAllData();
        }
        private void testData_button_Click(object sender, EventArgs e)
        {
            //adding test data to try the algorithm
            clearAllData();

            //adding vertices
            graph.addVertex("1", 2, 2);
            graph.addVertex("2", 5, 3);
            graph.addVertex("3", 11, 1);
            graph.addVertex("4", 1, 7);
            graph.addVertex("5", 7, 8);
            graph.addVertex("6", 14, 8);
            graph.addVertex("7", 4, 10);
            graph.addVertex("8", 9, 5);
            graph.addVertex("9", 10, 9);
            graph.addVertex("10", 3, 6);

            //adding edges
            graph.addEdge("1", "2", 3);
            graph.addEdge("1", "10", 1);
            graph.addEdge("2", "8", 4);
            graph.addEdge("3", "1", 5);
            graph.addEdge("4", "1", 2);
            graph.addEdge("4", "10", 2);
            graph.addEdge("5", "7", 3);
            graph.addEdge("5", "8", 4);
            graph.addEdge("6", "3", 4);
            graph.addEdge("7", "4", 5);
            graph.addEdge("7", "9", 9);
            graph.addEdge("8", "3", 8);
            graph.addEdge("8", "6", 3);
            graph.addEdge("9", "6", 1);
            graph.addEdge("9", "8", 2);
            graph.addEdge("10", "5", 2);

            DrawPoints(panel1);
            DrawEdges(panel1);
            insertDataToComboBoxes();



        }


    }
}
