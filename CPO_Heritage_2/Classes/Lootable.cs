using System;
using System.Collections.Generic;
using System.Text;

namespace CPO_Heritage_2.Classes
{
    public class Lootable
    {
        #region Attributs
        protected string lootableName;
        protected Dictionary<Enemy, Double> enemyDropRate;
        #endregion

        #region Constructeurs
        public Lootable(string name)
        {
            this.lootableName = name;
            this.enemyDropRate = new Dictionary<Enemy, Double>();
        }
        #endregion

        #region Getters
        public string getName()
        {
            return this.lootableName;
        }

        public Dictionary<Enemy, Double> getAllDropRate()
        {
            return this.enemyDropRate;
        }

        public Double getEnemyDropRate(Enemy enemy)
        {
            return this.enemyDropRate[enemy];
        }
        #endregion

        #region Setters
        private void setLootableName(string name)
        {
            this.lootableName = name;
        }

        private void setEnemyDropRate(Dictionary<Enemy, Double> enemyDropRate)
        {
            this.enemyDropRate = enemyDropRate;
        }
        #endregion

        #region Méthodes
        public void addEenmy(Enemy enemy, Double dropRate)
        {
            this.enemyDropRate.Add(enemy, dropRate);
        }
        #endregion

        #region Fonction
        public Boolean enemyExists(Enemy enemy)
        {
            return this.enemyDropRate.ContainsKey(enemy);
        }

        public string afficher()
        {
            string output = "Lootable : " + this.lootableName + "\n";
            foreach(KeyValuePair<Enemy, Double> drop in this.enemyDropRate)
            {
                output += drop.Key.getName() + " : " + drop.Value + " unité.s\n";
            }

            return output;
        }
        #endregion
    }
}
