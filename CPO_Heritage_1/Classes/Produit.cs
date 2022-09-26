using System;
using System.Collections.Generic;
using System.Text;

namespace CPO_Heritage_1.Classes
{
    public class Produit
    {
        #region Attributs
        protected string reference;
        protected string designation;
        protected int prixVente;
        #endregion

        #region Constructeurs
        public Produit(string reference, string designation, int prixVente)
        {
            this.reference = reference;
            this.designation = designation;
            this.prixVente = prixVente;
        }
        #endregion

        #region Getters
        public string getReference()
        {
            return this.reference;
        }

        public string getDesignation()
        {
            return this.designation;
        }

        public int getPrixVente()
        {
            return this.prixVente;
        }
        #endregion

        #region Setters
        private void setReference(string reference)
        {
            this.reference = reference;
        }

        private void setDesignation(string designation)
        {
            this.designation = designation;
        }

        private void setPrixVente(int prixVente)
        {
            this.prixVente = prixVente;
        }
        #endregion

        #region Méthodes
        public string afficher()
        {
            return "Produit : " + this.reference + "\nDésignation : " + this.designation + " - " + this.prixVente + "euros";
        }
        #endregion
    }
}
