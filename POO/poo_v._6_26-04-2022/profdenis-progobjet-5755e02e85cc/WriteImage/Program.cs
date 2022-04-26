
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Formats.Png;

namespace WriteImage
{
    class Program
    {
        static void Main(string[] args)
        {
            // NuGet install SixLabors.ImageSharp
            int width = 100;
            var image = new Image<Rgb24>(width, width);
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    image[i, j] = Color.White;
                }
            }

            image[5, 15] =  Color.Blue;
            image[15, 5] = Color.Red;
            for (int i = 0; i < width; i++)
            {
                image[i, i] = Color.Chocolate;
            }

            string docs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            Console.WriteLine(docs);
            image.Save(docs + "/image.png", new PngEncoder());
        }
    }
}