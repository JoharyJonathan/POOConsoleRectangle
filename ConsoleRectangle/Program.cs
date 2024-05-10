using System;

namespace ConsoleRectangle
{
    class Program
    {
        static void Main(string[] args)
        {   
            Rectangle rec = new Rectangle(120.23f, 35.1f);
            rec.Perimetre();
            rec.Surface();
            rec.Color();

            Console.WriteLine();

            Rectangle rect = new Rectangle(150.654f, 45.0045f, "bleu");
            rect.Perimetre();
            rect.Surface();
            rect.Color();

            Console.WriteLine();
            Console.WriteLine(rect.Couleur);

            Console.Read();
        }
    }
}
