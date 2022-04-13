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
            // string filename = docs + "/" + image_file;
            string filename = Path.Combine(docs, image_file);
            
            Canvas canvas = new Canvas(500,300, Color.White);
            DrawSolution.DrawHLine(canvas, 200, 175, 50, Color.Red);
            DrawSolution.DrawHLine(canvas, 10, 50, 100, Color.Aquamarine);
            
            DrawSolution.DrawVLine(canvas, 10, 50, 100, Color.Brown);
            DrawSolution.DrawVLine(canvas, 77, 99, 50, Color.Green);
            
            DrawSolution.DrawRectangle(canvas, 100, 100, 50, 75, Color.Fuchsia);
            DrawSolution.DrawSquare(canvas, 200, 100, 50, Color.Khaki);
            
            DrawSolution.DrawLine(canvas, 5, 5, 200, 50, Color.DarkGoldenrod);
            DrawSolution.DrawLine(canvas, 15, 15, 50, 150, Color.Purple);
            DrawSolution.DrawLine(canvas, 15, 25, 15, 150, Color.DarkOliveGreen);
            
            DrawSolution.DrawTriangle(canvas, 300, 50, 350, 100, 400, 50, Color.Orange);
            DrawSolution.DrawTriangle(canvas, 300, 150, 320, 190, 450, 50, Color.Firebrick);
            
            DrawSolution.DrawCircle(canvas, 400, 200, 50, Color.Indigo);
            
            Console.WriteLine($"Writing image in file: {filename}");
            canvas.Save(filename);
        }
    }
}