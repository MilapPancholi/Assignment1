using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool IsExit = false,IsValidMenu=false;
            do
            {
                int point1 = 0, point2 = 0, point3 = 0;
                int MenuNo = 0;
                Console.WriteLine("1. Enter Triangle Dimensions");
                Console.WriteLine("2. Exit");
                IsValidMenu=int.TryParse(Console.ReadLine(),out MenuNo);
                if (MenuNo == 1)
                {
                    bool IsValidPoint1 = true;
                    do
                    {
                        Console.WriteLine("Enter Point 1:");
                        IsValidPoint1 = int.TryParse(Console.ReadLine(), out point1);
                    } while (!IsValidPoint1);

                    bool IsValidPoint2 = true;
                    do
                    {
                        Console.WriteLine("Enter Point 2:");
                        IsValidPoint2=int.TryParse(Console.ReadLine(), out point2);
                    } while (!IsValidPoint2);

                    bool IsValidPoint3 = true;
                    do
                    {
                        Console.WriteLine("Enter Point 3:");
                        IsValidPoint3 = int.TryParse(Console.ReadLine(), out point3);
                    } while (!IsValidPoint3);

                    String Triangle=TriangleSolver.Analyze(point1,point2,point3);
                    Console.WriteLine(Triangle);
                }
                else if(MenuNo==2)
                {
                    IsExit = true;   
                }
            } while (!IsExit || !IsValidMenu);
        }
    }
}
