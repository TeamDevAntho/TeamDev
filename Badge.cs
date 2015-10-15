using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Btssio2.ProjetVDM
{
    class Badge
    {
        #region Champs

        private string _id = "Inconnu";
        private string _name = "Inconnu";
        private string _type = "Inconnu";
        private string _description = "Inconnu";

        #endregion

        #region Propriétés

        public string id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string type
        {
            get { return _type; }
            set { _type = value; }
        }

        public string description
        {
            get { return _description; }
            set { _description = value; }
        }

        #endregion

        #region Constructeurs

        public Badge(string id, string name)
        {
            this.id = id;
            this.name = name;

        }

        public Badge(string id, string name, string type)
        {
            this.id = id;
            this.name = name;
            this.type = type;
        }

        public Badge(string id, string name, string type, string description)
        {
            this.id = id;
            this.name = name;
            this.type = type;
            this.description = description;
        }

        #endregion

        #region Méthodes

        #endregion
    }
}
