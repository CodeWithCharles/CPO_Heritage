using System;
using System.Collections.Generic;
using System.Text;

namespace CPO_Heritage_1.Classes
{
    public class ProduitAch : Produit
    {
        #region Attributs
        private int numeroFournisseur;
        private int prixAchat;
        #endregion

        #region Constructeurs
        public ProduitAch(string reference, string designation, int prixVente, int numeroFournisseur, int prixAchat) 
            : base(reference, designation, prixVente)
        {
            this.numeroFournisseur = numeroFournisseur;
            this.prixAchat = prixAchat;
        }
        #endregion

        #region Getters
        public int getNumeroFournisseur()
        {
            return this.numeroFournisseur;
        }

        public int getPrixAchat()
        {
            return this.prixAchat;
        }
        #endregion

        #region Setters
        private void setNumeroFournisseur(int numeroFournisseur)
        {
            this.numeroFournisseur = numeroFournisseur;
        }

        private void setPrixAchat(int prixAchat)
        {
            this.prixAchat = prixAchat;
        }
        #endregion

        #region Méthodes
        public new string afficher()
        {
            return base.afficher() + "\nFournisseur : " + this.numeroFournisseur 
                + "\nPrix d'achat : " + this.prixAchat + "euros";
        }
        #endregion
    }
}
