using ShapesV3;
using SixLabors.ImageSharp;

namespace DrawShapesV3;

class Program
{
    static void Main(string[] args)
    {
        string docs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        string image_file = "shapesV3.png";
        string filename = Path.Combine(docs, image_file);

        Canvas canvas = new Canvas(500, 500, Color.White);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Line(new ShapesV3.Point(25, 25), new ShapesV3.Point(200, 300), Color.Lime));
        shapes.Add(new HLine(new ShapesV3.Point(100, 150), 200, Color.Fuchsia));
        shapes.Add(new VLine(new ShapesV3.Point(200, 250), 100, Color.Blue));

        shapes.Add(new Polygon(
            new ShapesV3.Point(50, 50),
            new ShapesV3.Point(150, 75),
            new ShapesV3.Point(125, 175)
        ));
        
        foreach (Shape shape in shapes)
        {
            shape.Draw(canvas);
        }

        Console.WriteLine($"Writing image in file: {filename}");
        canvas.Save(filename);
    }
}