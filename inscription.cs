using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_VDM
{
    public class inscription
    {

        #region champs

        private string _birthday = "Inconnu";

        private string _title = "Inconnu";

        private int _hide = 0;

        private int _hideActivity = 0;

        private string _city = "Inconnu";

        private string _country = "Inconnu";

        private string _relationship = "Inconnu";

        private string _timezone = "Inconnu";

        private string _description = "Inconnu";

        private string _mail = "Inconnu";

        private string _password = "Inconnu";

       
        #endregion


        #region propriétés

        public string birthday
        {
            get { return _birthday; }
            set { _birthday = value; }
        }

        public string title
        {
            get { return _title; }
            set { _title = value; }
        }

        public int hide
        {
            get { return _hide; }
            set { _hide = value; }
        }

        public int hideActivity
        {
            get { return _hideActivity; }
            set { _hideActivity = value; }
        }

        public string city
        {
            get { return _city; }
            set { _city = value; }
        }

        public string country
        {
            get { return _country; }
            set { _country = value; }
        }

        public string relationship
        {
            get { return _relationship; }
            set { _relationship = value; }
        }

        public string timezone
        {
            get { return _timezone; }
            set { _timezone = value; }
        }
        public string description
        {
            get { return _description; }
            set { _description = value; }
        }
        public string mail
        {
            get { return _mail; }
            set { _mail = value; }
        }
        public string password
        {
            get { return _password; }
            set { _password = value; }
        }

        #endregion


        #region Constructeurs
        public inscription(string birthday,string title)
            {
                this.birthday = birthday;
                this.title = title;
            }

        public inscription(string birthday, string title, int hide, int hideActivity)
        {
            this.birthday = birthday;
            this.title = title;
            this.hide = hide;
            this.hideActivity = hideActivity;
        }

        public inscription(string birthday, string title, int hide, int hideActivity, string city, string country, string relationship)
        {
            this.birthday = birthday;
            this.title = title;
            this.hide = hide;
            this.hideActivity = hideActivity;
            this.city = city;
            this.country = country;
            this.relationship = relationship;
        }

        public inscription(string birthday, string title, int hide, int hideActivity, string city, string country, string relationship, string timezone, string description)
        {
            this.birthday = birthday;
            this.title = title;
            this.hide = hide;
            this.hideActivity = hideActivity;
            this.city = city;
            this.country = country;
            this.relationship = relationship;
            this.timezone = timezone;
            this.description = description;
        }


        public inscription(string birthday, string title, int hide, int hideActivity, string city, string country, string relationship, string timezone, string description, string mail, string password)
        {
            this.birthday = birthday;
            this.title = title;
            this.hide = hide;
            this.hideActivity = hideActivity;
            this.city = city;
            this.country = country;
            this.relationship = relationship;
            this.timezone = timezone;
            this.description = description;
            this.mail = mail;
            this.password = password;
        }

        #endregion


        #region Méthodes

        #endregion


    }
}
