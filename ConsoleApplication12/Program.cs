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
        

        public int x;
        public int y;
        public Point()
        {

        }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    class Canvas
    {
        delegate string check();
        event check mouseclicked;
            
        public Point p1,p2,p3,p4;
        public Canvas()
        {
            mouseclicked = new check(mousecheck);

        }

    public Canvas(Point p1,Point p2,Point p3,Point p4)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            this.p4 = p4;
        }
         
        public string mousecheck()
        {
            string ans = "no";
            while(ans!="Yes")
            {
                Console.WriteLine("Enter Yes when ready");
                ans=Console.ReadLine();
            }
            return ans;
        }
    

        static void Main(string[] args)
        {
            Point point = new Point();
            Canvas canvas = new Canvas();
            

            string ans=canvas.mouseclicked();
            Console.WriteLine("The event has ocurred because the user has entered {0}", ans);
            Console.ReadKey();   

        }
    }
}

