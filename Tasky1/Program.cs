using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Tasky1
{
    class Program
    {

        static void Main(string[] args)
        {
            AvgPerimAndArea();

            var pn1 = new Point(2, 2);
            var pn2 = new Point(3, 4);
            var pn3 = new Point(5, 5);
            var pn4 = new Point(7, 4);
            var pn5 = new Point(6, 2);
            var pn6 = new Point(4, 1);

            var NAng = new NAngle(pn1, pn2, pn3, pn4, pn5, pn6);

            Console.WriteLine("Perimeter of N-angle is: " + NAng.Perimeter);
            Console.WriteLine("Area of N-angle is: " + NAng.Area);
        }


        public static void AvgPerimAndArea()
        {

            var pn1 = new Point(0, 0);
            var pn2 = new Point(0, 3);
            var pn3 = new Point(3, 0);

            var pn4 = new Point(0, 0);
            var pn5 = new Point(0, 4);
            var pn6 = new Point(4, 0);

            Triangle[] massTri = new Triangle[]
                {
                    new Triangle(pn1, pn2, pn3),
                    new Triangle(pn4, pn5, pn6)
                };

            double gensumPerim = 0;
            double gensumArea = 0;
            int counterPerim = 0;
            int counterArea = 0;

            for (int i = 0; i < massTri.Length; i++)
            {
                bool triIsRight;
                bool triIsIsosceles;

                triIsRight = massTri[i].IsRight;
                triIsIsosceles = massTri[i].IsIsosceles;

                if (triIsRight)
                {
                    counterPerim++;
                    gensumPerim += (massTri[i].Perimeter) / counterPerim;
                }

                if (triIsIsosceles)
                {
                    counterArea++;
                    gensumArea += (massTri[i].Area) / counterArea;
                }
            }
                Console.WriteLine("Average of peremeter is: " + gensumPerim);
                Console.WriteLine("Average of area is: " + gensumArea);

            
        }
    }


}