using System;
using System.Collections.Generic;
using System.Text;

namespace CPO_Heritage_2.Classes
{
    public class Music : CD
    {
        #region Attributs
        public int trackNumber { get; private set; }
        #endregion

        #region Constructeur
        public Music(string title, string creatorName, TimeSpan duration, int trackNumber = 0, int stock = 0, string comment = "") : base(title, creatorName, duration, stock, comment)
        {
            this.trackNumber = trackNumber;
        }
        #endregion

        #region Fonctions
        public override string afficher()
        {
            return String.Format("{0} de {1} avec {2} pistes pour une durée de {3}. {4} en stock.\nCommentaire :\n{5}",
                this.title,
                this.creatorName,
                this.trackNumber,
                (this.duration.ToString()),
                this.stock,
                this.comment);
        }
        #endregion
    }
}
