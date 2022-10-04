using System;
using System.Collections.Generic;
using System.Text;

namespace CPO_Heritage_2.Classes
{
    public class Biblio
    {
        #region Attributs
        public List<Object> cds { get; private set; }
        #endregion

        #region Constructeurs
        public Biblio()
        {
            this.cds = new List<Object>();
        }
        #endregion

        #region Fonctions
        public override string ToString()
        {
            string result = "";
            foreach (Object cd in this.cds)
            {
                result += cd.ToString() + "\n\n";
            }

            return result;
        }
        #endregion

        #region Méthodes
        public void addCD(params Object[] cdsToAdd)
        {
            foreach(Object newCD in cdsToAdd)
            {
                this.cds.Add(newCD);
            }
        }
        #endregion
    }
}
