


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
            //string filename = docs + "/" + image_file;
            string filename = Path.Combine(docs, image_file);
            
            Canvas canvas = new Canvas(500,300, Color.White);

            ShapesV2.Point p1 = new ShapesV2.Point(100, 50, Color.RebeccaPurple);
            p1.Draw(canvas);
            p1.X = 200;
            p1.Draw(canvas);
            p1.Y = 25;
            p1.DrawColor = Color.Chartreuse;
            p1.Draw(canvas);

            VLine vline = new VLine(new ShapesV2.Point(66, 88), 50, Color.Blue);
            vline.Draw(canvas);

            HLine hline = new HLine(new ShapesV2.Point(86, 108),50, Color.Blue);
            hline.Draw(canvas);
            
            
            Console.WriteLine($"Writing image in file: {filename}");
            canvas.Save(filename);
            
            /*ShapesV2.Point p5 = new ShapesV2.Point(2, 4);
            ShapesV2.Point p6 = new ShapesV2.Point(2, 3);
            Console.WriteLine($"p5 == p6? {p5 == p6}");
            Console.WriteLine($"p5.Equals(p6)? {p5.Equals(p6)}");
            p6.Y = 4;
            Console.WriteLine($"p5 == p6? {p5 == p6}");
            Console.WriteLine($"p5.Equals(p6)? {p5.Equals(p6)}");*/
            
            
        }
    }
}