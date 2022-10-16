using System;
using System.Collections.Generic;
using System.Text;

namespace CPO_Heritage_2.Classes
{
    public class Biblio
    {
        #region Attributs
        public List<CD> cds { get; private set; }
        #endregion

        #region Constructeurs
        public Biblio()
        {
            this.cds = new List<CD>();
        }
        #endregion

        #region Fonctions
        public override string ToString()
        {
            string result = "";
            foreach (CD cd in this.cds)
            {
                result += cd.afficher() + "\n\n";
            }

            return result;
        }
        #endregion

        #region Méthodes
        public void addCD(params CD[] cdsToAdd)
        {
            foreach(CD newCD in cdsToAdd)
            {
                this.cds.Add(newCD);
            }
        }
        #endregion
    }
}
