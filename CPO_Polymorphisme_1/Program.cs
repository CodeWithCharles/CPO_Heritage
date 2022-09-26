using CPO_Heritage_1.Classes;
using System;

namespace CPO_Polymorphisme_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProduitFab pf;
            ProduitAch pa;
            pf = new ProduitFab("f01", "réveil matin", 150, 1, 10, 50);
            pa = new ProduitAch("a01", "montre bracelet", 75, 1, 45);
            Console.WriteLine("affichage d'un produit fabriqué : \n");
            Console.WriteLine(pf.afficher());
            Console.WriteLine("\naffichage d'un produit acheté : \n");
            Console.WriteLine(pa.afficher());
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("Polymorphisme\n");

            afficherCaracteristique(pf);
            afficherMarge(pf);
            afficherCaracteristique(pa);
            afficherMarge(pa);

            Console.ReadKey();
        }

        public static void afficherCaracteristique(Produit pdt)
        {
            Console.WriteLine(pdt.afficher() + "\n");
        }

        public static void afficherMarge(Produit pdt)
        {
            Console.WriteLine("Marge : " + pdt.marge() + "euros\n");
        }
    }
}
