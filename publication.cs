using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_VDM
{
    class publication
    {

        #region Champs

        private string _author = "Inconnu";

        private string _categorie = "Inconnu";

        
        private string _text = "Inconnu";

        
        private string _mail = "Inconnu";

      
        private string _sexe = "Inconnu";

       
        #endregion


        #region Propriétes

        public string author
        {
            get { return _author; }
            set { _author = value; }
        }
        public string categorie
        {
            get { return _categorie; }
            set { _categorie = value; }
        }
        public string text
        {
            get { return _text; }
            set { _text = value; }
        }
        public string mail
        {
            get { return _mail; }
            set { _mail = value; }
        }
        public string sexe
        {
            get { return _sexe; }
            set { _sexe = value; }
        }


        #endregion

        
        #region Constructeurs

        public publication(string author, string categorie, string text)
        {
            this.author = author;
            this.categorie = categorie;
            this.text = text;
            
        }


        public publication(string author, string categorie, string text, string mail, string sexe)
        {
            this.author = author;
            this.categorie = categorie;
            this.text = text;
            this.mail = mail;
            this.sexe = sexe;
        }
          #endregion


        #region Méthodes
        #endregion

    }
}
