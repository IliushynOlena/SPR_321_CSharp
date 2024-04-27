using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_IntroToOOP
{
    partial class Point
    {
        public void Test()
        {
            Console.WriteLine("Testing.....");
        }
    }
    partial class Point
    {

        public void SetXCoord(int newX)
        {
            if (newX > 0)
                xCoord = newX;
            else
                xCoord = 0;
        }
        public int GetX()
        {
            return xCoord;
        }
        public void SetYCoord(int newY)
        {
            if (newY > 0)
                yCoord = newY;
            else
                yCoord = 0;
        }
        public int GetY()
        {
            return yCoord;
        }

    }
    partial class Point
    {

        static Point()
        {
            count = 0;
        }
        public Point()
        {
            /*default values:
             numbers: 0
            boolean: false
            references types : null
            */
            xCoord = 0;
            yCoord = 0;
            Type = "Point";
        }
        public Point(int value) : this(value, value) { }

        public Point(int x, int yCoord)
        {
            SetXCoord(x);
            SetYCoord(yCoord);
        }

    }
}
