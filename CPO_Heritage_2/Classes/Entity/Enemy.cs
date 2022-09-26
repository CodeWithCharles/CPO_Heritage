using System;
using System.Collections.Generic;
using System.Text;

namespace CPO_Heritage_2.Classes
{
    public class Enemy
    {
        #region Attributs
        protected string name;
        protected Double walkSpeed;
        protected Double health;
        protected Double attack;
        protected Double agressionRange;
        #endregion

        #region Constructeurs
        public Enemy(string name, Double walkSpeed, Double health, Double attack, Double agressionRange)
        {
            this.name = name;
            this.walkSpeed = walkSpeed;
            this.health = health;
            this.attack = attack;
            this.agressionRange = agressionRange;
        }
        #endregion

        #region Getters
        public string getName()
        {
            return this.name;
        }
        
        public Double getWalkSpeed()
        {
            return this.walkSpeed;
        }

        public Double getHealth()
        {
            return this.health;
        }

        public Double getAttack()
        {
            return this.attack;
        }

        public Double getAgressionRange()
        {
            return this.agressionRange;
        }
        #endregion

        #region Setters
        private void setName(string name)
        {
            this.name = name;
        }

        private void setWalkSpeed(float walkSpeed)
        {
            this.walkSpeed = walkSpeed;
        }

        private void setHealth(int health)
        {
            this.health = health;
        }

        private void setAttack(float attack)
        {
            this.attack = attack;
        }

        private void setAgressionRange(float agressionRange)
        {
            this.agressionRange = agressionRange;
        }
        #endregion

        #region Methods
        public void applyDamage(float damage)
        {
            this.health -= float.Parse(Math.Round(damage, 1).ToString());
        }
        #endregion

        #region Functions
        public virtual string afficher()
        {
            return "Monstre : " + this.name + "\nVitesse de marche : " + this.walkSpeed + "\nVie maximum : " + this.health + "\nAttaque : " + this.attack + "\nPortée d'agression : " + this.agressionRange;
        }
        #endregion
    }
}
