using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Btssio2.ProjetVDM
{
    public class Membre
    {
        #region Champs

        private string _sexe = "Inconnu";
        private int _age = 0;
        private int _ageMin = 0;
        private int _ageMax = 0;
        private int _situation = 0;
        private int _latitude = 0;
        private int _longitude = 0;
        private string _dateNaissance = "Inconnu";

        #endregion

        #region Propriétés

         public string sexe
         {
             get { return _sexe; }
             set { _sexe = value; }
         }

         public int ageMin
         {
             get { return _ageMin; }
             set { _ageMin = value; }
         }

         public int ageMax
         {
             get { return _ageMax; }
             set { _ageMax = value; }
         }

         public int situation
         {
             get { return _situation; }
             set { _situation = value; }
         }

         public int latitude
         {
             get { return _latitude; }
             set { _latitude = value; }
         }

         public int longitude
         {
             get { return _longitude; }
             set { _longitude = value; }
         }

         public string dateNaissance
         {
             get { return _dateNaissance; }
             set { _dateNaissance = value; }
         }

         public int age
         {
             get { return _age; }
             set { _age = value; }
         }

        #endregion

        #region Constructeurs

        public Membre(string sexe, int age)
        {
            this.sexe = sexe;
            this.age = age;

        }

        public Membre(string sexe, int age, int situation)
        {
            this.sexe = sexe;
            this.age = age;
            this.situation = situation;
        }

        public Membre(string sexe, int age, int situation, int latitude, int longitude)
        {
            this.sexe = sexe;
            this.age = age;
            this.situation = situation;
            this.latitude = latitude;
            this.longitude = longitude;
        }

        public Membre(string sexe, int age, int situation, int latitude, int longitude, string detNaissance)
        {
            this.sexe = sexe;
            this.age = age;
            this.situation = situation;
            this.latitude = latitude;
            this.longitude = longitude;
            this.dateNaissance = dateNaissance;
        }

        #endregion 

        #region Méthodes

        #endregion
    }
}
