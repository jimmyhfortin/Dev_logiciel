using ShapesV1;
using SixLabors.ImageSharp;

namespace DrawShapes
{
    class Program
    {
        static void Main(string[] args)
        {
            string docs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string image_file = "ex1.png";
            string filename = docs + "/" + image_file;
            
            Canvas canvas = new Canvas(500,200, Color.AliceBlue);
            Draw.DrawHLine(canvas, 180, 20, 50, Color.Blue);
            Draw.DrawVLine(canvas, 180, 20, 50, Color.Blue);
            Draw.DrawRectangle(canvas, 50, 20, 100, 40, Color.Red);
            Draw.DrawSquare(canvas, 100, 80, 50, Color.Cyan);
            Draw.DrawLine(canvas, 100, 50, 120, 60, Color.Black);
            
            
            Console.WriteLine($"Writing image in file: {filename}");
            canvas.Save(filename);
        }
    }
}