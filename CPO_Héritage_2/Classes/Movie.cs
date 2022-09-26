using System;
using System.Collections.Generic;
using System.Text;

namespace CPO_Heritage_2.Classes
{
    public class Movie : CD
    {
        #region Attributs
        public string mainActor { get; private set; }
        #endregion

        #region Constructeur
        public Movie(string title, string creatorName, TimeSpan duration, string mainActor, int stock = 0, string comment = "") : base(title, creatorName, duration, stock, comment)
        {
            this.mainActor = mainActor;
        }
        #endregion

        #region Fonction
        public override string ToString()
        {
            return String.Format("{0} de {1} avec {2} pour une durée de {3}. {4} en stock.\nCommentaire :\n{5}",
                this.title,
                this.creatorName,
                this.mainActor,
                (this.duration.ToString()),
                this.stock,
                this.comment);
        }
        #endregion
    }
}
