using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;




namespace ConsoleApplication12
{
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
        delegate bool check();
        event check mouseclicked;
            
        public Point point1,point2,point3,point4;
        public Canvas()
        {
            mouseclicked = new check(mousecheck);

        }

    public Canvas(Point point1,Point point2,Point point3,Point point4)
        {
            this.point1 = point1;
            this.point2 = point2;
            this.point3 = point3;
            this.point4 = point4;
        }

        public bool mousecheck()
        {
            if ((point1.xposition <= 10) & (point1.yposition <= 10))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        static void Main(string[] args)
        {
            Point point1,point2,point3,point4 = new Point();
            point1(10, 10);
            point2(10, 10);
            point3(10, 10);
            point4(10, 10);


            bool answer=canvas.mouseclicked();
            Console.WriteLine("The event has ocurred because the user has entered {0}", answer);
            Console.ReadKey();   

        }
    }
}

