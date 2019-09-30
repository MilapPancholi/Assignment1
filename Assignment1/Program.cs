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
            bool IsExit = false;
            do
            {
                int point1 = 0, point2 = 0, point3 = 0;
                int MenuNo = 0;
                Console.WriteLine("1. Enter Triangle Dimensions");
                Console.WriteLine("2. Exit");
                int.TryParse(Console.ReadLine(),out MenuNo);
                if (MenuNo == 1)
                {
                    Console.WriteLine("Enter Point 1:");
                    int.TryParse(Console.ReadLine(), out point1);

                    Console.WriteLine("Enter Point 2:");
                    int.TryParse(Console.ReadLine(), out point2);

                    Console.WriteLine("Enter Point 3:");
                    int.TryParse(Console.ReadLine(), out point3);

                    String Triangle=TriangleSolver.Analyze(point1,point2,point3);
                    Console.WriteLine(Triangle);
                }
                else
                {
                    IsExit = true;   
                }
            } while (!IsExit);
        }
    }
}
