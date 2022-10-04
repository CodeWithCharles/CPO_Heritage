using System;
using System.Collections.Generic;
using System.Text;

namespace CPO_Abstract_Perso.Classes
{
    public class CheckingAccount : BankAccount
    {
        #region Attributs
        private Double minimumFunds;
        #endregion

        #region Constructeur(s)
        public CheckingAccount(String owner, Double balance, Double minimumFunds = -200) : base(owner, balance)
        {
            this.minimumFunds = minimumFunds;
        }
        #endregion

        #region Getters
        public Double getMinimumFunds()
        {
            return this.minimumFunds;
        }
        #endregion

        #region Setters
        private void setMinimumFunds(Double minimumFunds)
        {
            this.minimumFunds = minimumFunds;
        }
        #endregion

        #region Functions
        public override Boolean withdrawal(Double amount)
        {
            Boolean result = false;
            if(this.balance - amount >= this.minimumFunds)
            {
                this.balance -= amount;
                result = !result;
            }
            return result;
        }
        #endregion
    }
}
