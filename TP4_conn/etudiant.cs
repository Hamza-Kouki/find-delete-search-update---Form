using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4_conn
{
    class etudiant
    {
        private int id;
        private string nom , prenom;
        public etudiant() { }
        public etudiant(int id, string nom, string prenom)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
        }
        public etudiant(int id)
        {
            this.id = id;
        }
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string NOM
        {
            get { return nom; }
            set { this.nom = value; }
        }
        public string PRENOM
        {
            get { return prenom; }
            set { this.prenom = value; }
        }
    }
}
