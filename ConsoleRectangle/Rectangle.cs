using System;

namespace ConsoleRectangle
{
    class Rectangle
    {
        private float longueur;
        private float largeur;
        private string couleur;

        public string Couleur
        {
            get
            {
                return couleur;
            }
        }

        public Rectangle(float Longueur, float Largeur)
        {
            longueur = Longueur;
            largeur = Largeur;
        }

        public Rectangle(float Longueur, float Largeur, String Couleur)
        {
            longueur = Longueur;
            largeur = Largeur;
            couleur = Couleur;
        }

        public void Perimetre()
        {
            float perimetre = (2 * longueur) + (2 * largeur);
            Console.WriteLine("Le perimetre du rectangle est " + perimetre );
        }

        public void Surface()
        {
            Console.WriteLine("La surface du rectangle est " + (longueur * largeur));
        }

        public void Color()
        {
            if (Couleur != null)
                Console.WriteLine("La couleur du rectangle est " + Couleur);
            else
                Console.WriteLine("Aucune couleur");
        }
    }
}
