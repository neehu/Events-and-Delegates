using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CAnvas
{
    public delegate bool check();
    class Point
    {
        public int xposition;
        public int yposition;
        public Point()
        {

        }
        public Point(int xposition, int yposition)
        {
            this.xposition = xposition;
            this.yposition = yposition;
        }
    }
    class Canvas
    {

        event check mouseclicked;
        public Point firstPoint, secondPoint, thirdPoint, fourthPoint;
        public Canvas()
        {
            mouseclicked = new check(mousecheck);

        }

        public Canvas(Point firstPoint, Point secondPoint, Point thirdPoint, Point fourthPoint)
        {
            this.firstPoint = firstPoint;
            this.secondPoint = secondPoint;
            this.thirdPoint = thirdPoint;
            this.fourthPoint = fourthPoint;
        }

        public bool mousecheck()
        {

            if ((firstPoint.xposition <= 10) & (firstPoint.yposition <= 10))
                return true;
            else
                return false;


        }
        static void Main(string[] args)
        {

            bool answer = true;
            Point Firstpoint = new Point(10, 10);
            Point Secondpoint = new Point(10, 10);
            Point Thirdpoint = new Point(10, 10);
            Point Fourthpoint = new Point(10, 10);
            Canvas canvas = new Canvas(Firstpoint, Secondpoint, Thirdpoint, Fourthpoint);
            answer = canvas.mouseclicked();
            Console.WriteLine("The event has ocurred because the user has entered {0}", answer);
            Console.ReadKey();

        }
    }
}

