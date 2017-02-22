using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Tasky1
{
    class NAngle
    {
        public readonly List<Point> Points = new List<Point>();
        
        public readonly List<Edge> Edges = new List<Edge>();


        public NAngle(params Point[] point)
        {
            
                if (point.Length < 3)
                {
                    throw new System.ArgumentException("Not enough points.");
                }
                else
                    for (int i = 0; i < point.Length; i++)
                    {
                        this.Points.Add(point[i]);

                    }

                for (int i = 0; i < point.Length - 1; i++)
                {
                    Edges.Add(new Edge(point[i], point[i + 1]));

                }

                Edges.Add(new Edge(point[point.Length - 1], point[0]));

             if (!IsConvex)
              {
                throw new System.ArgumentException("N-angle is not convex.");
              }

            }


        private bool IsConvex
        {
            get
            {
                double AllAngle = 0;

                for(int i = 1; i < Points.Count - 1; i++)
                {
                    AllAngle += GetAngle(Points.ElementAt(i - 1), Points.ElementAt(i), Points.ElementAt(i + 1));
                }

                AllAngle += GetAngle(Points.ElementAt(Points.Count - 1), Points.ElementAt(0), Points.ElementAt(1));
                AllAngle += GetAngle(Points.ElementAt(Points.Count - 2), Points.ElementAt(Points.Count - 1), Points.ElementAt(0));

               // Console.WriteLine(AllAngle + " " + (180 * (Points.Count - 2)));

                return (180 * (Points.Count - 2) == AllAngle) ;
            }
        }


        private double GetAngle(Point point1, Point point2, Point point3)
        {
            double vectorX1, vectorY1;
            double vectorX2, vectorY2;
            double LengthVector1, LengthVector2;

            vectorX1 = point1.X - point2.X;
            vectorY1 = point1.Y - point2.Y;
            vectorX2 = point3.X - point2.X;
            vectorY2 = point3.Y - point2.Y;

            LengthVector1 = Math.Sqrt(Math.Pow(vectorX1, 2) + Math.Pow(vectorY1, 2));
            LengthVector2 = Math.Sqrt(Math.Pow(vectorX2, 2) + Math.Pow(vectorY2, 2));

           // Console.WriteLine(180/Math.PI*Math.Acos((vectorX1 * vectorX2 + vectorY1 * vectorY2) / (LengthVector1 * LengthVector2)));

            return (180 / Math.PI * Math.Acos((vectorX1 * vectorX2 + vectorY1 * vectorY2) / (LengthVector1 * LengthVector2)));
            
        }


        public double Perimeter
        {
            get
            {
                double Perim = 0;
                foreach(Edge edge1 in Edges)
                {
                    Perim += edge1.Length;
                }

                return Perim;
            }

        }

        public double Area
        {

            get
            {
                double Area = 0;

                for(int i = 1; i < Points.Count - 1; i++)
                {
                    var triangle = new Triangle(Points.ElementAt(0), Points.ElementAt(i), Points.ElementAt(i + 1));
                    Area += triangle.Area;
                }
                return Area;

            }
        }


    }


}
