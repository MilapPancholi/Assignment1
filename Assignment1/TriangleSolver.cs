using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public static class TriangleSolver
    {
        public static string Analyze(int point1,int point2,int point3)
        {
            if(point1<=0 || point2<=0 || point3<=0)
            {
                return "Invalid";
            }
            if (point1 + point2 > point3 && point1 + point3 > point2 && point2 + point3 > point1)
            {
                if (point1 == point2 && point2 == point3)
                {
                    return "Equilateral";
                }
                else if (point1 == point2 || point1 == point3 || point2 == point3)
                {
                    return "Isosceles";
                }
                else
                {
                    return "Scalene";
                }
            }
            else
            {
                return "Invalid";
            }
        }
    }
}
