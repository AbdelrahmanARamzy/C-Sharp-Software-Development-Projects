using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment1
{
    class CalculateDistanceAndAngle
    {
        static void Main(string[] args)
        {
            Console.Write("Welcome");
            Console.Write("\nThis application will calculate the distance and the angle between 2 points");

            Console.Write("\nThe value of X1: ");
            float point1X = float.Parse(Console.ReadLine());

            Console.Write("\nThe value of Y1: ");
            float point1Y = float.Parse(Console.ReadLine());

            Console.Write("\nThe value of X2: ");
            float point2X = float.Parse(Console.ReadLine());

            Console.Write("\nThe value of Y2: ");
            float point2Y = float.Parse(Console.ReadLine());

            float deltaX = point1X - point2X;
            float deltaY = point1Y - point2Y;

            float distance = (float)Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2));
            float angleInRadians = (float)Math.Atan2(deltaY, deltaX);
            float angleInDegrees = angleInRadians * 180 / (float)Math.PI;

            Console.Write("\nThe Distance: " + distance);
            Console.Write("\nThe Angle: " + angleInDegrees);

            Console.Write("\nPress any key to exit...");
            Console.ReadLine();
        }
    }
}
