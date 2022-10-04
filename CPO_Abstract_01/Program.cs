using CPO_Heritage_1.Classes;
using System;

namespace CPO_Abstract_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProduitFab pf = new ProduitFab("f01", "réveil matin", 150, 1, 10, 50);
            ProduitAch pa = new ProduitAch("a01", "montre bracelet", 75, 1, 45);
            //Produit prod = new Produit("d01", "ceinture", 100);

            Console.WriteLine("Affichage du produit fabriqué hérité de la classe abstraite :\n");
            Console.WriteLine(pf.afficher());
            Console.WriteLine("\nAffichage du produit acheté hérité de la classe abstraite :\n");
            Console.WriteLine(pa.afficher());

            Console.ReadKey();

            Console.WriteLine("\nTest de getReference de la classe abstraite :\n");
            Console.WriteLine("ProduitFab : " + pf.getReference() + "\n");
            Console.WriteLine("ProduitAch : " + pa.getReference() + "\n");
        }
    }
}
