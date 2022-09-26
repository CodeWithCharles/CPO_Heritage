using CPO_Heritage_2.Classes;
using CPO_Heritage_2.Classes.Entity;
using System;

namespace CPO_Heritage_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Enemy Zombie = new Enemy("Zombie", 1.2, 30, 5, 12);
            RangedEnemy Skeleton = new RangedEnemy("Squelette", 1, 20, 5, 10, 3);
            Enemy SkeletonBase = Skeleton;

            Lootable enemyFragment = new Lootable("Fragment d'hostile");
            Lootable rottenFlesh = new Lootable("Chair putréfiée");
            Lootable bone = new Lootable("Os");

            enemyFragment.addEenmy(Zombie, 2);
            enemyFragment.addEenmy(Skeleton, 1);

            rottenFlesh.addEenmy(Zombie, 3);

            bone.addEenmy(Skeleton, 4);

            Console.WriteLine(Zombie.afficher() + "\n");
            Console.WriteLine(Skeleton.afficher() + "\n");

            Console.ReadKey();

            Console.WriteLine(enemyFragment.afficher());
            Console.WriteLine(rottenFlesh.afficher());
            Console.WriteLine(bone.afficher());

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Test du polymorphisme externe\n");

            afficheCaracteristiques(Zombie);
            afficheCaracteristiques(Skeleton);

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Test de fonction virtuelle\n");

            afficheCaracteristiques(SkeletonBase);
            Console.WriteLine(SkeletonBase.afficher());

            Console.ReadKey();
        }

        public static void afficheCaracteristiques(Enemy enemy)
        {
            Console.WriteLine(enemy.afficher() + "\n");
        }
    }
}