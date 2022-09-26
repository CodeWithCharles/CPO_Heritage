using System;
using System.Collections.Generic;
using System.Text;

namespace CPO_Heritage_2.Classes
{
    public class CD
    {
        #region Attributs
        public string title { get; set; }
        public string creatorName { get; set; }
        public TimeSpan duration { get; private set; }
        public int stock { get; set; }
        public string comment { get; set; }
        #endregion

        #region Constructeur
        public CD(string title, string creatorName, TimeSpan duration, int stock = 0, string comment = "")
        {
            this.title = title;
            this.creatorName = creatorName;
            this.duration = duration;
            this.stock = stock;
            this.comment = comment;
        }
        #endregion

        #region Fonctions
        public virtual string afficher()
        {
            return String.Format("{0} de {1} avec {2} pistes pour une durée de {3}. {4} en stock.\nCommentaire :\n{5}",
                this.title,
                this.creatorName,
                (this.duration.ToString()),
                this.stock,
                this.comment);
        }
        #endregion
    }
}
