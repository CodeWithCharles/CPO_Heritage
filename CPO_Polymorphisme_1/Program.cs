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
            Produit prod = new Produit("d01", "ceinture", 100);

            Console.WriteLine("Sans l'utilisation de virtual\n");

            prod = pf;
            afficherCaracteristiqueNonVirtual(prod);
            afficherMarge(prod, false);
            prod = pa;
            afficherCaracteristiqueNonVirtual(prod);
            afficherMarge(prod, false);

            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("Polymorphisme\n");

            prod = pf;
            afficherCaracteristique(prod);
            afficherMarge(prod, true);

            prod = pa;
            afficherCaracteristique(prod);
            afficherMarge(prod, true);

            Console.ReadKey();
        }

        public static void afficherCaracteristiqueNonVirtual(Produit pdt)
        {
            Console.WriteLine(pdt.afficherNonVirtual() + "\n");
        }

        public static void afficherCaracteristique(Produit pdt)
        {
            Console.WriteLine(pdt.afficher() + "\n");
        }

        public static void afficherMarge(Produit pdt, Boolean isVirtual)
        {
            Console.WriteLine("Marge : " + pdt.marge(isVirtual) + "euros\n");
        }
    }
}
