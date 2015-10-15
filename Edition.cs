using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Btssio2.ProjetVDM
{
    class Edition
    {
        #region Champs

        private int _id = 0;
        private int _refId = 0;
        private string _text = "Inconnu";
        private string _type = "Inconnu";

        #endregion

        #region Propriétés

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        public int refId
        {
            get { return _refId; }
            set { _refId = value; }
        }
        public string text
        {
            get { return _text; }
            set { _text = value; }
        }

        public string type
        {
            get { return _type; }
            set { _type = value; }
        }

        #endregion

        #region Constructeurs

        public Edition(int _id, string text)
        {
            this.id = id;
            this.text = text;
        }

        public Edition(int _id, string text, string type)
        {
            this.id = id;
            this.text = text;
            this.type = type;
        }

        #endregion

        #region Méthodes
 


        #endregion
    }
}
