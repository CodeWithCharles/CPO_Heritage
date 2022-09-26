using CPO_Heritage_2.Classes;
using System;

namespace CPO_Heritage_2
{
    class Program
    {
        #region Hidden
        #endregion
        static void Main(string[] args)
        {

            Movie film1 = new Movie("matrix", "Lana Wachowski, Lilly Wachowski", 
                new TimeSpan(2,16,0), "Keanu Reeves", 1, 
                "Avec un postulat de départ fascinant, des décors volontairement décadents, et des effets visuels époustouflants.\nThe Matrix offre un portrait intriguant de notre futur proche sous une forme intelligente de narration cinématographique.");
            Movie film2 = new Movie("pacific rim", "Guillermo del Toro", 
                new TimeSpan(2, 11, 0), "Charlie Hunnam", 5, 
                "Visuellement sublime, \"Pacific Rim\" coince un peu en terme d’histoire, trop classique.\nMais jamais assez pour pouvoir atténuer le plaisir de gosse éprouvé devant un tel spectacle.");

            CD cd1 = new Music("la vraie vie", "Bigflo et Oli", 
                new TimeSpan(1, 18, 54), 15, 3, 
                "Oui, sur la forme l'album est très bon : Des tracks aux mélodies et rythmes variés, des textes travaillés, un duo efficace à la diction maitrisé.");
            CD cd2 = new Music("hey kids", "The Oral Cigarettes", 
                new TimeSpan(0, 38, 19), 10, 4, 
                "Énorme album de la part de TOC!! Je surkiffe Amy et Kuzuke no baby.\nLes pistes Everything et A-E-U-I te rentrent dans le tête et les autres sont tout aussi bien.");

            Biblio biblio = new Biblio();
            biblio.addCD(film1, film2);
            biblio.addCD(cd1, cd2);

            Console.WriteLine(biblio.ToString());

            Console.ReadKey();

        }
    }
}
