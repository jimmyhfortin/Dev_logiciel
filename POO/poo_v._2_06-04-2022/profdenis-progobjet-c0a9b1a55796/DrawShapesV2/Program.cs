


using System.Runtime.CompilerServices;
using ShapesV2;
using SixLabors.ImageSharp;
using Point = ShapesV2.Point;
using Rectangle = ShapesV2.Rectangle;

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
            
            Canvas canvas = new Canvas(500,300, Color.Black);

            /*ShapesV2.Point p1 = new ShapesV2.Point(100, 50, Color.RebeccaPurple);
            p1.Draw(canvas);
            p1.X = 200;
            p1.Draw(canvas);
            p1.Y = 25;
            p1.DrawColor = Color.Chartreuse;
            p1.Draw(canvas);*/
            
            //Ligne vertical
            VLine vline = new VLine(new ShapesV2.Point(66, 88), 50, Color.Blue);
            vline.Draw(canvas);
            //Ligne Horizontale
            HLine hline = new HLine(new ShapesV2.Point(66, 88),50, Color.Blue);
            hline.Draw(canvas);
            //Rectangle
            Rectangle rectangle = new Rectangle(new ShapesV2.Point(100, 120), 50, 80, Color.Gold);
            rectangle.Draw(canvas);
            //Carre
            Carre carre = new Carre(new ShapesV2.Point(160, 120), 50, Color.Goldenrod);
            carre.Draw(canvas);
            //ligne diagonale
            Line ligne = new Line(new ShapesV2.Point(70, 20), new ShapesV2.Point(200,50), Color.Aqua);
            ligne.Draw(canvas);
            //Cercle
            Circle cercle = new Circle(new ShapesV2.Point(300, 50), 50, Color.DeepPink);
            cercle.Draw(canvas);
            
            Console.WriteLine($"Writing image in file: {filename}");
            canvas.Save(filename);
            
            /*ShapesV2.Point p5 = new ShapesV2.Point(2, 4);
            ShapesV2.Point p6 = new ShapesV2.Point(2, 3);
            ShapesV2.Point p7 = p6;
            Console.WriteLine($"p5 == p6? {p5 == p6}");
            Console.WriteLine($"p5.Equals(p6)? {p5.Equals(p6)}");
            p6.Y = 4;
            p7.DrawColor = Color.Aquamarine;
            Console.WriteLine($"p5 == p6? {p5 == p6}");
            Console.WriteLine($"p5.Equals(p6)? {p5.Equals(p6)}");*/
            
            
        }
    }
}