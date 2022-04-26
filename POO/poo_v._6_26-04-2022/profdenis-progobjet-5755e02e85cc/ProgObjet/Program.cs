using ShapesV1;

namespace ProgObjet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point1 p1 = new Point1(5, 2);
            Console.WriteLine("Point 1: " + p1);
            p1.x = 6;
            Console.WriteLine("Point 1: " + p1);

            Point2 p2 = new Point2(2, -3);
            Console.WriteLine("Point 2: " + p2);
            p2.Y = 4;
            Console.WriteLine("Point 2: " + p2);

            Point3 p3 = new Point3(5, 1);
            Console.WriteLine("Point 3: " + p3);
            p3.Y = 5;
            Console.WriteLine("Point 3: " + p3);
            Console.WriteLine("Point 3 Length: " + p3.Length());

            Point p4 = new Point(5, 4);
            Console.WriteLine("Point 4: " + p4);
            p4.ScaleX(2);
            Console.WriteLine("Point 4 (scaleX 2): " + p4);
            p4.ScaleY(1.5);
            Console.WriteLine("Point 4 (scaleY 1.5): " + p4);
            p4.Scale(0.5);
            Console.WriteLine("Point 4 (scaleX 0.5): " + p4);
            Console.WriteLine("Point 4 (MidPoint): " + p4.MidPoint());
            Console.WriteLine(2.5);
            Console.WriteLine(Math.Round(2.5));
            Console.WriteLine(Math.Round(2.5, MidpointRounding.AwayFromZero));


        }
    }
}