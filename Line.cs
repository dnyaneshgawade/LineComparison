using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparison
{
    public class Line
    {
        public int x1, x2, x3, x4, y1, y2,y3,y4;
        public Line(int x1,int x2, int x3, int x4,int y1,int y2, int y3, int y4)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.x3 = x3;
            this.x2 = x4;
            this.y1 = y1;
            this.y2 = y2;
            this.y3 = y3;
            this.y4 = y4;

        }

        public void calculate()
        {
            double lenth1 = Math.Sqrt((x2 - x1) ^ 2 + (y2 - y1) ^ 2);
            Console.WriteLine("the length of the first line is:"+lenth1);
            double lenth2 = Math.Sqrt((x4 - x3) ^ 2 + (y4 - y3) ^ 2);
            Console.WriteLine("the length of the second line is:" + lenth2);
            if (lenth1>lenth2)
                Console.WriteLine("first line is greter");
            else if(lenth1>lenth2)
                Console.WriteLine("second line is greter");
            else
                Console.WriteLine("both lines are equal");
        }
       

    }
}
