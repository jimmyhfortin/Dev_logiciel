using ShapesV3;
using SixLabors.ImageSharp;

namespace DrawShapesV3
{
    class Program
    {
        static void Main(string[] args)
        {
            string docs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string image_file = "ex5.png";
            // string filename = docs + "/" + image_file;
            string filename = Path.Combine(docs, image_file);

            Canvas canvas = new Canvas(500, 300, Color.White);
            // ShapesV3.Point p1 = new ShapesV3.Point(100, 50, Color.RebeccaPurple);
            // p1.Draw(canvas);
            // p1.X = 200;
            // p1.Draw(canvas);
            // p1.Y = 25;
            // p1.DrawColor = Color.Chartreuse;
            // p1.Draw(canvas);
            ShapesV3.Shape line1 = new ShapesV3.Point(100, 50, Color.Aquamarine);
            line1.Draw(canvas);
            
        }
    }
}    