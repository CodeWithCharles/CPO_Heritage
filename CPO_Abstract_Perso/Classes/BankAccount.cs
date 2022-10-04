using System;
using System.Collections.Generic;
using System.Text;

namespace CPO_Abstract_Perso.Classes
{
    public abstract class BankAccount
    {
        #region Attributs
        protected String owner;
        protected Double balance;
        #endregion

        #region Constructeur(s)
        protected BankAccount(String owner, Double balance)
        {
            this.owner = owner;
            this.balance = balance;
        }
        #endregion

        #region Getters
        public String getOwner()
        {
            return this.owner;
        }

        public Double getBalance()
        {
            return this.balance;
        }
        #endregion

        #region Setters
        private void setOwner(String owner)
        {
            this.owner = owner;
        }

        private void setBalance(Double balance)
        {
            this.balance = balance;
        }
        #endregion

        #region Methods
        public void deposit(Double amount)
        {
            this.balance += amount;
        }
        #endregion

        #region Functions
        public abstract Boolean withdrawal(Double amount);
        #endregion
    }
}
