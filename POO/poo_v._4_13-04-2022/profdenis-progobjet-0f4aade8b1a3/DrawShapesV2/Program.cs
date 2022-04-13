using ShapesV2;
using SixLabors.ImageSharp;

namespace DrawShapesV2
{
    class Program
    {
        static void Main(string[] args)
        {
            string docs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string image_file = "ex4.png";
            // string filename = docs + "/" + image_file;
            string filename = Path.Combine(docs, image_file);

            Canvas canvas = new Canvas(500, 300, Color.White);

            ShapesV2.Point p1 = new ShapesV2.Point(100, 50, Color.RebeccaPurple);
            p1.Draw(canvas);
            p1.X = 200;
            p1.Draw(canvas);
            p1.Y = 25;
            p1.DrawColor = Color.Chartreuse;
            p1.Draw(canvas);

            HLine hLine = new HLine(new ShapesV2.Point(100, 100), 200, Color.Brown);
            hLine.Draw(canvas);
            hLine.StartPoint.Y = 150;
            hLine.Draw(canvas);

            // VLine vLine = new VLine(p1, 50, Color.Brown);
            VLine vLine = new VLine(new ShapesV2.Point(66, 88), 50, Color.Gainsboro);
            vLine.Draw(canvas);
            vLine.StartPoint.X = 300;
            vLine.Draw(canvas);

            Line line = new Line(
                new ShapesV2.Point(50, 75),
                new ShapesV2.Point(250, 50),
                Color.Firebrick
            );
            line.Draw(canvas);

            Circle circle = new Circle(new ShapesV2.Point(250, 150), 50, Color.Orange);
            // circle.Draw(canvas);
            for (int i = 50; i <= 250; i += 25)
            {
                circle.Radius = i;
                circle.Draw(canvas);    
            }
            
            
            
            Console.WriteLine($"Writing image in file: {filename}");
            canvas.Save(filename);

            ShapesV2.Point p5 = new ShapesV2.Point(2, 4);
            ShapesV2.Point p6 = new ShapesV2.Point(2, 3);
            ShapesV2.Point p7 = p6;
            Console.WriteLine($"p5 == p6? {p5 == p6}");
            Console.WriteLine($"p5.Equals(p6)? {p5.Equals(p6)}");

            Console.WriteLine($"p6 == p7? {p6 == p7}");
            Console.WriteLine($"p6.Equals(p7)? {p6.Equals(p7)}");

            p7.Y = 4;
            p7.DrawColor = Color.Aquamarine;
            Console.WriteLine($"p5 == p6? {p5 == p6}");
            Console.WriteLine($"p5.Equals(p6)? {p5.Equals(p6)}");
        }
    }
}