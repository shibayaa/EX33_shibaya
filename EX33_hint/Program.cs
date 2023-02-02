using System;

namespace EX33
{
    class Program
    {
        static void Main(string[] args)
        {
            RectAngle rectAngle1 = new RectAngle(3.5f, 5);
            RectAngle rectAngle2 = new RectAngle(2, 4);
            RectAngle rectAngle3 = rectAngle1 + rectAngle2;
            Console.WriteLine($"2つの長方形が入る最小の長方形は ({rectAngle3.width},{rectAngle3.height})");
        }
    }
}
