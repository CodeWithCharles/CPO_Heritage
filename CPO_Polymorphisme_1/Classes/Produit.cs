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
        public virtual string afficher()
        {
            return "Produit : " 
                + this.reference 
                + "\nDésignation : " 
                + this.designation 
                + " - " + this.prixVente + "euros";
        }

        public string afficherNonVirtual()
        {
            return "Produit : "
                + this.reference
                + "\nDésignation : "
                + this.designation
                + " - " + this.prixVente + "euros";
        }
        #endregion

        #region Fonctions
        public virtual double cout()
        {
            return 0;
        }

        public double coutNonVirtual()
        {
            return 0;
        }

        public double marge(Boolean isVirtual)
        {
            double marge = 0;
            if(isVirtual)
            {
                marge = this.prixVente - this.cout();
            } else
            {
                marge = this.prixVente - this.coutNonVirtual();
            }
            return marge;
        }
        #endregion
    }
}
