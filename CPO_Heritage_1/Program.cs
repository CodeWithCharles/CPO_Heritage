using CPO_Heritage_1.Classes;
using System;

namespace CPO_Heritage_1
{
    class Program
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
        }
    }
}
