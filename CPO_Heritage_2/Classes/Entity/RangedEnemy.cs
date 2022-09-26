using System;
using System.Collections.Generic;
using System.Text;

namespace CPO_Heritage_2.Classes.Entity
{
    public class RangedEnemy : Enemy
    {
        #region Attributs
        private Double weaponRange;
        #endregion

        #region Constructeurs
        public RangedEnemy(string name, Double walkSpeed, Double health, Double attack, Double agressionRange, Double weaponRange) : base(name, walkSpeed, health, attack, agressionRange)
        {
            this.weaponRange = weaponRange;
        }
        #endregion

        #region Getters
        public Double getWeaponRange()
        {
            return this.weaponRange;
        }
        #endregion

        #region Setters
        private void setWeaponRange(Double weaponRange)
        {
            this.weaponRange = weaponRange;
        }
        #endregion

        #region Functions
        public override string afficher()
        {
            return base.afficher() + "\nPortée de l'arme : " + this.weaponRange;
        }
        #endregion
    }
}
