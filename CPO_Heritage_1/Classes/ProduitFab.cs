using System;
using System.Collections.Generic;
using System.Text;

namespace CPO_Heritage_1.Classes
{
    public class ProduitFab : Produit
    {
        #region Attributs
        private int numAtelierFabrication;
        private int nbHeuresFabrication;
        private int coutMatieresPremieres;
        #endregion

        #region Constructeurs
        public ProduitFab(string reference, string designation, int prixVente, int numAtelierFabrication, int nbHeuresFabrication, int coutMatieresPremieres) : base(reference, designation, prixVente)
        {
            this.numAtelierFabrication = numAtelierFabrication;
            this.nbHeuresFabrication = nbHeuresFabrication;
            this.coutMatieresPremieres = coutMatieresPremieres;
        }
        #endregion

        #region Getters
        public int getNumAtelierFabrication()
        {
            return this.numAtelierFabrication;
        }

        public int getNbHeuresFabrication()
        {
            return this.nbHeuresFabrication;
        }

        public int getCoutMatieresPremieres()
        {
            return this.coutMatieresPremieres;
        }
        #endregion

        #region Setters
        private void setNumAtelierFabrication(int numAtelierFabrication)
        {
            this.numAtelierFabrication = numAtelierFabrication;
        }

        private void setNbHeuresFabrication(int nbHeuresFabrication)
        {
            this.nbHeuresFabrication = nbHeuresFabrication;
        }

        private void setCoutMatieresPremieres(int coutMatieresPremieres)
        {
            this.coutMatieresPremieres = coutMatieresPremieres;
        }
        #endregion

        #region Méthodes
        public new string afficher()
        {
            return base.afficher() + "\nAtelier de fabrication : " + this.numAtelierFabrication + "\nNombre d'heures de fabrication : " + this.nbHeuresFabrication + " - Prix des matières premières : " + this.coutMatieresPremieres;
        }
        #endregion
    }
}
