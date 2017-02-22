using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasky1
{
    class Edge
    {
        
        public readonly double Length;
        public readonly Point Point1, Point2;

        public Edge(Point point1, Point point2)
        {
            this.Point1 = point1;
            this.Point2 = point2;
            this.Length = Math.Sqrt(Math.Pow((Point2.X - Point1.X), 2) + Math.Pow((Point2.Y - Point1.Y), 2));
        }

        public static bool operator ==(Edge edge1, Edge edge2)
        {
            return (edge1.Point1 == edge2.Point1 && edge1.Point2 == edge2.Point2);
        }

        public static bool operator !=(Edge edge1, Edge edge2)
        {
            return (edge1.Point1 != edge2.Point1 && edge1.Point2 != edge2.Point2);
        }


    }
}