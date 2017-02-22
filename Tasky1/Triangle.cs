using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasky1
{
    class Triangle
    {
        private double edge1;
        private double edge2;
        private double edge3;

        public readonly Point Point1;
        public readonly Point Point2;
        public readonly Point Point3;

        public Triangle(Point point1, Point point2, Point point3)
        {
            var edg1 = new Edge(point1, point2);
            var edg2 = new Edge(point1, point3);
            var edg3 = new Edge(point3, point2);
           
            this.Point1 = point1;
            this.Point2 = point2;
            this.Point3 = point3;

            if (edg1.Length >= edg2.Length + edg3.Length ||
                edg2.Length >= edg1.Length + edg3.Length ||
                edg3.Length >= edg2.Length + edg1.Length)
            {
                throw new ArgumentException("Triangle is degenerate.");
            }
            else
            {
                this.edge1 = edg1.Length;
                this.edge2 = edg2.Length;
                this.edge3 = edg3.Length;
            }
            
            
        }


        public double Perimeter
        {
            get
            {
                return (edge1 + edge2 + edge3);
            }
        }


        public double Area
        {
            get
            {
                double p = (edge1 + edge2 + edge3) / 2;
                return Math.Sqrt(p * (p - edge1) * (p - edge2) * (p - edge3));
            }
        }


        public bool IsRight
        {
            get
            {

                return (edge1 == Math.Sqrt(Math.Pow(edge2, 2) + Math.Pow(edge3, 2)) ||
                        edge2 == Math.Sqrt(Math.Pow(edge3, 2) + Math.Pow(edge1, 2)) ||
                        edge3 == Math.Sqrt(Math.Pow(edge2, 2) + Math.Pow(edge1, 2)));

            }
        }


        public bool IsIsosceles
        {
            get
            {
                return (edge1 == edge2 || edge1 == edge3 || edge2 == edge3);
            }
        }

        public static bool operator ==(Triangle tri1, Triangle tri2)
        {
            return (tri1.Point1 == tri2.Point1 && tri1.Point2 == tri2.Point2 && tri1.Point3 == tri2.Point3);
        }


        public static bool operator !=(Triangle tri1, Triangle tri2)
        {
            return (tri1.Point1 != tri2.Point1 && tri1.Point2 != tri2.Point2 && tri1.Point3 != tri2.Point3);
        }

    }
}