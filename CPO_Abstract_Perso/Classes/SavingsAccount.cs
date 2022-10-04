using System;
using System.Collections.Generic;
using System.Text;

namespace CPO_Abstract_Perso.Classes
{
    public class SavingsAccount : BankAccount
    {
        #region Attributs
        private Double annualInterestRate;
        #endregion

        #region Constructeur(s)
        public SavingsAccount(String owner, Double balance, Double annualInterestRate) : base(owner, balance)
        {
            this.annualInterestRate = annualInterestRate;
        }
        #endregion

        #region Getters
        public Double getAnnualInterestRate()
        {
            return this.annualInterestRate;
        }
        #endregion

        #region Setters
        public void setAnnualInterestRate(Double annualInterestRate)
        {
            this.annualInterestRate = annualInterestRate;
        }
        #endregion

        #region Methods
        public void depositMonthlyInterest()
        {
            this.balance *= this.annualInterestRate;
        }
        #endregion

        #region Functions
        public override Boolean withdrawal(Double amount)
        {
            Boolean result = false;
            if (this.balance - amount < 0)
            {
                this.balance -= amount;
                result = !result;
            }
            return result;
        }
        #endregion
    }
}
